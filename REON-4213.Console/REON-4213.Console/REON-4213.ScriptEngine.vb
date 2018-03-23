Imports System.Text.RegularExpressions
Imports NLog
Namespace REON_4213

    Public Class ScriptEngine

        ' REON-4213.11をベースにしたスクリプト言語
        ' 文法は基本的にREON-4213を踏襲
        ' ただし、{DW},{HW}は実用可能な物に置き換える

        ' 基本構文
        ' 構文開始句 -> コマンド <- オプション -> 何に対して
        ' 例）
        ' QuelI -> EX["HKCU\Software\Microsoft\Internet Explorer\Main"] <- {"Start Page" & SZ::"http://www.yahoo.co.jp"} -> {REG}
        ' QuelI -> EX[Ipconfig] <- "/All" ->{CMD}

        '上記の構文が理解できるようなParserを作るのが目標

        '仕様
        ' 1構文1行で記述。改行不可（今のところ）
        ' QuelI -> で始まり、{REG}, {CMD}, {HW}, {DW}, {TzW}, {UW}, {RW} で終わる（本家REON-4213準拠）
        ' ただし、{REG}, {CMD} 以外は現状未定義とする

        'ベースとなる技術仕様等
        'http://www.genomirai.com/WorldSettingDocument/index.php?REON4213.11

        Dim _ReadText As String
        Dim _CmdLines As List(Of String)
        Dim _logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

        Sub New()
            _ReadText = ""
        End Sub

        Sub New(fname As String)
            _ReadText = ""
            ReadScript(fname)
        End Sub

        Sub New(fname As String, encoding As System.Text.Encoding)
            _ReadText = ""
            ReadScript(fname, encoding)
        End Sub

        'ファイルの読み込み
        Private Sub ReadScript(fname As String)
            _ReadText = System.IO.File.ReadAllText(fname)
        End Sub

        Private Sub ReadScript(fname As String, encoding As System.Text.Encoding)
            _ReadText = System.IO.File.ReadAllText(fname, encoding)
        End Sub


        '構文解析
        'まず-> を分解して
        'その中から <- と｛｝で囲まれた部分を抽出する

        ''' <summary>
        ''' 読み込まれたスクリプトファイルを行単位に分割する
        ''' </summary>
        Private Sub ReadTextToCommandParse()

            If _ReadText = "" Then
                Throw New Exception("スクリプトファイルが読み込まれていません")
            End If

            For Each cmd As String In _ReadText
                _CmdLines.Add(cmd)
            Next
        End Sub

        '''' <summary>
        '''' スクリプトファイルを読み込み実行
        '''' </summary>
        ''Sub EXeC()

        ''    ReadTextToCommandParse()

        ''    For Each cmd As String In _CmdLines

        ''        If DefCheck(cmd) Then
        ''            'コマンドの取得
        ''            Dim command As String = GetCommand(cmd)
        ''            _logger.Info("COMMAND :" & command)

        ''            'オプションの取得
        ''            Dim opt As List(Of String) = GetOption(cmd)
        ''            _logger.Info("OPTION :" & opt.ToString)

        ''            '発動子の取得
        ''            Dim ExecPointer As String = GetExecutePointer(cmd)
        ''            _logger.Info("EXECPtr : " & ExecPointer)

        ''        End If


        ''    Next
        ''End Sub

        ''' <summary>
        ''' スクリプトを直接実行（1行単位実行）
        ''' </summary>
        ''' <param name="ScriptText">スクリプト</param>

        Sub EXeC(ScriptText As String)

            Dim cmd As String = ScriptText

            If DefCheck(cmd) Then
                'コマンドの取得
                Dim command As String = GetCommand(cmd)
                _logger.Info("COMMAND :" & command & vbCrLf)

                'オプションの取得
                Dim opt As List(Of String) = GetOption(cmd)
                For Each op In opt
                    _logger.Info("OPTION :" & op & vbCrLf)
                Next

                '発動子の取得
                Dim ExecPointer As String = GetExecutePointer(cmd)
                _logger.Info("EXECPtr : " & ExecPointer & vbCrLf)

                Dim result As Boolean = False

                '結果が取れた
                Select Case ExecPointer.ToUpper
                    Case "CMD"
                        result = cmdEXeC(command, opt)
                    Case "REG"
                        result = regEXeC(command, opt)
                End Select

                If result Then
                    _logger.Info("操作は成功しました" & vbCrLf)
                Else
                    _logger.Info("操作は失敗しました" & vbCrLf)
                End If


            End If
        End Sub


        ''' <summary>
        ''' コマンド定義確認
        ''' </summary>
        ''' <param name="command">読み込まれたスクリプト</param>
        ''' <returns>確認できた場合True,できなければFalse</returns>
        Private Function DefCheck(command As String) As Boolean
            '実行スクリプトの最初が QuelI で始まっているのを確認する
            'コマンド定義部分は -> で分割された1番目に来る
            Dim cmd As String = Split(command, "->")(0).Trim(" ")
            If cmd.ToUpper = "QUELI" Then Return True Else Return False
        End Function

        ''' <summary>
        ''' コマンド部分を取得
        ''' </summary>
        ''' <param name="command">読み込まれたスクリプト</param>
        ''' <returns>コマンド部本体</returns>
        Private Function GetCommand(command As String) As String

            'コマンド部分は -> で分割された2番目に来る
            Dim cmd As String = Split(command, "->")(1).Trim(" ")
            'その中の、<- があればそれより手前がコマンドになるので取り除く
            Dim c = Split(cmd, "<-")(0)
            '取得したコマンドから EX[ ]部分を抜き出して返す

            Dim RegEx As New Text.RegularExpressions.Regex("\[.*]", RegexOptions.IgnoreCase + RegexOptions.Singleline)
            Dim m As Text.RegularExpressions.Match = RegEx.Match(c)

            If m.Success Then
                '結果から " " と [ ] をはずした上で返す
                Return m.Value.Trim(""""c).Trim("["c, "]"c)
            Else
                Throw New Exception("REON-4213: Command Parse Error -> " & c)
            End If

        End Function

        ''' <summary>
        ''' オプション部分を取得
        ''' </summary>
        ''' <param name="Command">読み込まれたスクリプト</param>
        ''' <returns>オプションのリスト</returns>
        Private Function GetOption(command As String) As List(Of String)

            Dim retval As New List(Of String)
            retval.Clear()

            'コマンド部分は -> で分割された2番目に来る
            Dim cmd As String = Split(command, "->")(1).Trim(" ")
            'その中の、<- より後ろ側がオプション部分になるので、それを分割して返す
            Dim opt As String = Split(cmd, "<-")(1).Trim(" ")

            '取得したオプション部分をさらに分割する
            'オプション部分は { } で囲まれており、その中でオプションを分割する識別子は & である
            Dim RegEx As New Text.RegularExpressions.Regex("{.*}")
            Dim m As Text.RegularExpressions.Match = RegEx.Match(opt)

            '{ } を外した物を、さらに＆で分割する
            If m.Success Then
                Dim opts As String = m.Value.Trim("{"c, "}"c)
                For Each s As String In opts.Split("&")

                    retval.Add(s)

                Next
            Else
                Throw New Exception("REON-4213: Option Parse Error -> " & opt)
            End If

            Return retval

        End Function

        ''' <summary>
        ''' 発動子の取得
        ''' </summary>
        ''' <param name="cmd"></param>
        ''' <returns>実行対象（cmd/regstory など）</returns>
        Private Function GetExecutePointer(cmd As String) As String
            '発動子部分は -> で分割された3番目に来る
            Dim exec As String = Split(cmd, "->")(2).Trim(" ")

            '取得した発動子から { }部分を抜き出して返す

            Dim RegEx As New Text.RegularExpressions.Regex("{.*}")
            Dim m As Text.RegularExpressions.Match = RegEx.Match(exec)

            '{ } を外した物を返す
            If m.Success Then
                Return m.Value.Trim("{"c, "}"c)
            Else
                Throw New Exception("REON-4213: ExecPointer Parse Error -> " & cmd)
            End If

        End Function


        Private Function cmdEXeC(command As String, opt As List(Of String)) As Boolean


        End Function


        Private Function regEXeC(RegKey As String, opt As List(Of String)) As Boolean

            'パラメータがきちんとあるかチェック
            If opt.Count <> 2 Then
                _logger.Error("REG アクセスに対するパラメータ数が多いか不足しています" & vbCrLf)
                _logger.Error("パラメータ数：{0}" & vbCrLf, opt.Count)
                Return False
            End If

            Dim RegName As String = opt(0)
            Dim RegValue As String = opt(1)

            _logger.Info("RegName is {0}" & vbCrLf, RegName)
            _logger.Info("RegValue is {0}" & vbCrLf, RegValue)

            'パラメータの確認
            'オプションのValueを:で区切った左側がデータ型
            Select Case Split(RegValue, "::")(0)
                Case "SZ"
                    'REG_SZ
                    _logger.Info("RegValue_Type is SZ" & vbCrLf)

                Case "DW"
                    'REG_DWORD
                    _logger.Info("RegValue_Type is DW" & vbCrLf)

                Case "BI"
                    'REG_BINARY
                    _logger.Info("このデータ型は未実装です")
                    Return False

                Case "MZ"
                    'REG_MULTI_SZ
                    _logger.Info("このデータ型は未実装です")
                    Return False

                Case "EZ"
                    'REG_EXPAND_SZ
                    _logger.Info("このデータ型は未実装です")
                    Return False

            End Select

            Try
                Microsoft.Win32.Registry.SetValue(RegKey, RegName, RegValue)
            Catch ex As Exception
                _logger.Error(ex.ToString & vbCrLf)
                Return False
            End Try
            Return True

        End Function

    End Class
End Namespace