<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleWindow
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsoleWindow))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtEditer = New System.Windows.Forms.TextBox()
        Me.mstMainMenu = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規作成NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.上書き保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.印刷PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.印刷プレビューVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.元に戻すUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.やり直しRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.すべて選択AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.デバッグToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.実行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NLog出力テストToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.カスタマイズCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.内容CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.インデックスIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.検索SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.バージョン情報AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.mstMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 175)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEditer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mstMainMenu)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtConsole)
        Me.SplitContainer1.Size = New System.Drawing.Size(881, 523)
        Me.SplitContainer1.SplitterDistance = 262
        Me.SplitContainer1.TabIndex = 0
        '
        'txtEditer
        '
        Me.txtEditer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditer.Location = New System.Drawing.Point(0, 24)
        Me.txtEditer.Multiline = True
        Me.txtEditer.Name = "txtEditer"
        Me.txtEditer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEditer.Size = New System.Drawing.Size(881, 238)
        Me.txtEditer.TabIndex = 0
        Me.txtEditer.Text = "QuelI -> EX[""HKCU\Software\Microsoft\Internet Explorer\Main""] <- {""Start Page"" & " &
    "SZ::""http://www.yahoo.co.jp""} -> {REG}"
        '
        'mstMainMenu
        '
        Me.mstMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.デバッグToolStripMenuItem, Me.ツールTToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.mstMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstMainMenu.Name = "mstMainMenu"
        Me.mstMainMenu.Size = New System.Drawing.Size(881, 24)
        Me.mstMainMenu.TabIndex = 1
        Me.mstMainMenu.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成NToolStripMenuItem, Me.開くOToolStripMenuItem, Me.toolStripSeparator, Me.上書き保存SToolStripMenuItem, Me.名前を付けて保存AToolStripMenuItem, Me.toolStripSeparator1, Me.印刷PToolStripMenuItem, Me.印刷プレビューVToolStripMenuItem, Me.toolStripSeparator2, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '新規作成NToolStripMenuItem
        '
        Me.新規作成NToolStripMenuItem.Image = CType(resources.GetObject("新規作成NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新規作成NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem"
        Me.新規作成NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新規作成NToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.新規作成NToolStripMenuItem.Text = "新規作成(&N)"
        '
        '開くOToolStripMenuItem
        '
        Me.開くOToolStripMenuItem.Image = CType(resources.GetObject("開くOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.開くOToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem"
        Me.開くOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.開くOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.開くOToolStripMenuItem.Text = "開く(&O)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(181, 6)
        '
        '上書き保存SToolStripMenuItem
        '
        Me.上書き保存SToolStripMenuItem.Image = CType(resources.GetObject("上書き保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.上書き保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem"
        Me.上書き保存SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.上書き保存SToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)"
        '
        '名前を付けて保存AToolStripMenuItem
        '
        Me.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem"
        Me.名前を付けて保存AToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        '印刷PToolStripMenuItem
        '
        Me.印刷PToolStripMenuItem.Image = CType(resources.GetObject("印刷PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.印刷PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.印刷PToolStripMenuItem.Name = "印刷PToolStripMenuItem"
        Me.印刷PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.印刷PToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.印刷PToolStripMenuItem.Text = "印刷(&P)"
        '
        '印刷プレビューVToolStripMenuItem
        '
        Me.印刷プレビューVToolStripMenuItem.Image = CType(resources.GetObject("印刷プレビューVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.印刷プレビューVToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.印刷プレビューVToolStripMenuItem.Name = "印刷プレビューVToolStripMenuItem"
        Me.印刷プレビューVToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.印刷プレビューVToolStripMenuItem.Text = "印刷プレビュー(&V)"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元に戻すUToolStripMenuItem, Me.やり直しRToolStripMenuItem, Me.toolStripSeparator3, Me.切り取りTToolStripMenuItem, Me.コピーCToolStripMenuItem, Me.貼り付けPToolStripMenuItem, Me.toolStripSeparator4, Me.すべて選択AToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '元に戻すUToolStripMenuItem
        '
        Me.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem"
        Me.元に戻すUToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.元に戻すUToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)"
        '
        'やり直しRToolStripMenuItem
        '
        Me.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem"
        Me.やり直しRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.やり直しRToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.やり直しRToolStripMenuItem.Text = "やり直し(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(170, 6)
        '
        '切り取りTToolStripMenuItem
        '
        Me.切り取りTToolStripMenuItem.Image = CType(resources.GetObject("切り取りTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.切り取りTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem"
        Me.切り取りTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.切り取りTToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.切り取りTToolStripMenuItem.Text = "切り取り(&T)"
        '
        'コピーCToolStripMenuItem
        '
        Me.コピーCToolStripMenuItem.Image = CType(resources.GetObject("コピーCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.コピーCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem"
        Me.コピーCToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.コピーCToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.コピーCToolStripMenuItem.Text = "コピー(&C)"
        '
        '貼り付けPToolStripMenuItem
        '
        Me.貼り付けPToolStripMenuItem.Image = CType(resources.GetObject("貼り付けPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.貼り付けPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem"
        Me.貼り付けPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.貼り付けPToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(170, 6)
        '
        'すべて選択AToolStripMenuItem
        '
        Me.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem"
        Me.すべて選択AToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)"
        '
        'デバッグToolStripMenuItem
        '
        Me.デバッグToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.実行ToolStripMenuItem, Me.NLog出力テストToolStripMenuItem})
        Me.デバッグToolStripMenuItem.Name = "デバッグToolStripMenuItem"
        Me.デバッグToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.デバッグToolStripMenuItem.Text = "デバッグ"
        '
        '実行ToolStripMenuItem
        '
        Me.実行ToolStripMenuItem.Name = "実行ToolStripMenuItem"
        Me.実行ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.実行ToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.実行ToolStripMenuItem.Text = "実行"
        '
        'NLog出力テストToolStripMenuItem
        '
        Me.NLog出力テストToolStripMenuItem.Name = "NLog出力テストToolStripMenuItem"
        Me.NLog出力テストToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NLog出力テストToolStripMenuItem.Text = "NLog出力テスト"
        '
        'ツールTToolStripMenuItem
        '
        Me.ツールTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.カスタマイズCToolStripMenuItem, Me.オプションOToolStripMenuItem})
        Me.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem"
        Me.ツールTToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ツールTToolStripMenuItem.Text = "ツール(&T)"
        '
        'カスタマイズCToolStripMenuItem
        '
        Me.カスタマイズCToolStripMenuItem.Name = "カスタマイズCToolStripMenuItem"
        Me.カスタマイズCToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.カスタマイズCToolStripMenuItem.Text = "カスタマイズ(&C)"
        '
        'オプションOToolStripMenuItem
        '
        Me.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem"
        Me.オプションOToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.オプションOToolStripMenuItem.Text = "オプション(&O)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.内容CToolStripMenuItem, Me.インデックスIToolStripMenuItem, Me.検索SToolStripMenuItem, Me.toolStripSeparator5, Me.バージョン情報AToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        '内容CToolStripMenuItem
        '
        Me.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem"
        Me.内容CToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.内容CToolStripMenuItem.Text = "内容(&C)"
        '
        'インデックスIToolStripMenuItem
        '
        Me.インデックスIToolStripMenuItem.Name = "インデックスIToolStripMenuItem"
        Me.インデックスIToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.インデックスIToolStripMenuItem.Text = "インデックス(&I)"
        '
        '検索SToolStripMenuItem
        '
        Me.検索SToolStripMenuItem.Name = "検索SToolStripMenuItem"
        Me.検索SToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.検索SToolStripMenuItem.Text = "検索(&S)"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(164, 6)
        '
        'バージョン情報AToolStripMenuItem
        '
        Me.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem"
        Me.バージョン情報AToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)..."
        '
        'txtConsole
        '
        Me.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsole.Location = New System.Drawing.Point(0, 0)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(881, 257)
        Me.txtConsole.TabIndex = 1
        '
        'ConsoleWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MainMenuStrip = Me.mstMainMenu
        Me.Name = "ConsoleWindow"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.mstMainMenu.ResumeLayout(False)
        Me.mstMainMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtEditer As TextBox
    Friend WithEvents mstMainMenu As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規作成NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開くOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents 上書き保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 名前を付けて保存AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 印刷PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 印刷プレビューVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 元に戻すUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents やり直しRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 切り取りTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents コピーCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 貼り付けPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents すべて選択AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents カスタマイズCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オプションOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 内容CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents インデックスIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 検索SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents バージョン情報AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtConsole As TextBox
    Friend WithEvents デバッグToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NLog出力テストToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 実行ToolStripMenuItem As ToolStripMenuItem
End Class
