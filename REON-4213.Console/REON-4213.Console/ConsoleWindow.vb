Public Class ConsoleWindow
    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Dim _logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Private Sub NLog出力テストToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NLog出力テストToolStripMenuItem.Click
        _logger.Info("DEBUG.LOG" & vbCrLf)
    End Sub

    Private Sub 実行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 実行ToolStripMenuItem.Click
        Dim reon As New REON_4213.ScriptEngine()

        For Each cmd In txtEditer.Text.Split(vbCrLf)
            reon.EXeC(cmd)
        Next

    End Sub
End Class
