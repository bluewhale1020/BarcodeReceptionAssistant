﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.バーコード受付Page = New System.Windows.Forms.TabPage()
        Me.受診済み絞込ボタン = New System.Windows.Forms.CheckBox()
        Me.通番リセットBtn = New System.Windows.Forms.Button()
        Me.通番Box = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.電離のみ受付Btn = New System.Windows.Forms.Button()
        Me.バーコードデータBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.受付人数Label = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.レコード検索Page = New System.Windows.Forms.TabPage()
        Me.絞込クリアBtn = New System.Windows.Forms.Button()
        Me.フィルタ条件選択Box = New System.Windows.Forms.ComboBox()
        Me.フィルタカラム選択Box = New System.Windows.Forms.ComboBox()
        Me.フィルタキーBox = New System.Windows.Forms.TextBox()
        Me.絞込Btn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.検索カラム選択Box = New System.Windows.Forms.ComboBox()
        Me.検索キーBox = New System.Windows.Forms.TextBox()
        Me.検索Btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.データ出力Page = New System.Windows.Forms.TabPage()
        Me.ファイル選択Btn = New System.Windows.Forms.Button()
        Me.エクセルファイル出力Btn = New System.Windows.Forms.Button()
        Me.OutputFilePathBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.設定Page = New System.Windows.Forms.TabPage()
        Me.白紙バーコードNoBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.出力ファイル名Box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.入力カラム名Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.出力先フォルダパス選択Btn = New System.Windows.Forms.Button()
        Me.バーコードカラム名Box = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.バーコード受信方法Box = New System.Windows.Forms.ComboBox()
        Me.検索モードBox = New System.Windows.Forms.ComboBox()
        Me.設定を保存Btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.出力先フォルダパスBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.通番開始番号Box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dragdropMessage = New System.Windows.Forms.Label()
        Me.excelDataGridView = New System.Windows.Forms.DataGridView()
        Me.grdDataSet = New System.Data.DataSet()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.バーコード受付Page.SuspendLayout()
        CType(Me.通番Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.レコード検索Page.SuspendLayout()
        Me.データ出力Page.SuspendLayout()
        Me.設定Page.SuspendLayout()
        CType(Me.excelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AllowDrop = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.dragdropMessage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.excelDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1164, 668)
        Me.SplitContainer1.SplitterDistance = 275
        Me.SplitContainer1.SplitterWidth = 7
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.バーコード受付Page)
        Me.TabControl1.Controls.Add(Me.レコード検索Page)
        Me.TabControl1.Controls.Add(Me.データ出力Page)
        Me.TabControl1.Controls.Add(Me.設定Page)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1164, 275)
        Me.TabControl1.TabIndex = 0
        '
        'バーコード受付Page
        '
        Me.バーコード受付Page.BackColor = System.Drawing.SystemColors.Control
        Me.バーコード受付Page.Controls.Add(Me.受診済み絞込ボタン)
        Me.バーコード受付Page.Controls.Add(Me.通番リセットBtn)
        Me.バーコード受付Page.Controls.Add(Me.通番Box)
        Me.バーコード受付Page.Controls.Add(Me.Label1)
        Me.バーコード受付Page.Controls.Add(Me.GroupBox1)
        Me.バーコード受付Page.Controls.Add(Me.Panel1)
        Me.バーコード受付Page.Location = New System.Drawing.Point(4, 29)
        Me.バーコード受付Page.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.バーコード受付Page.Name = "バーコード受付Page"
        Me.バーコード受付Page.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.バーコード受付Page.Size = New System.Drawing.Size(1156, 242)
        Me.バーコード受付Page.TabIndex = 0
        Me.バーコード受付Page.Text = "バーコード受付"
        '
        '受診済み絞込ボタン
        '
        Me.受診済み絞込ボタン.Appearance = System.Windows.Forms.Appearance.Button
        Me.受診済み絞込ボタン.AutoSize = True
        Me.受診済み絞込ボタン.Cursor = System.Windows.Forms.Cursors.Default
        Me.受診済み絞込ボタン.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.受診済み絞込ボタン.Location = New System.Drawing.Point(990, 204)
        Me.受診済み絞込ボタン.Name = "受診済み絞込ボタン"
        Me.受診済み絞込ボタン.Size = New System.Drawing.Size(113, 30)
        Me.受診済み絞込ボタン.TabIndex = 5
        Me.受診済み絞込ボタン.Text = "受診済み絞込"
        Me.受診済み絞込ボタン.UseVisualStyleBackColor = True
        '
        '通番リセットBtn
        '
        Me.通番リセットBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.通番リセットBtn.Font = New System.Drawing.Font("Meiryo UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.通番リセットBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.通番リセットBtn.Location = New System.Drawing.Point(998, 158)
        Me.通番リセットBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.通番リセットBtn.Name = "通番リセットBtn"
        Me.通番リセットBtn.Size = New System.Drawing.Size(105, 31)
        Me.通番リセットBtn.TabIndex = 4
        Me.通番リセットBtn.Text = "通番 リセット"
        Me.通番リセットBtn.UseVisualStyleBackColor = False
        Me.通番リセットBtn.Visible = False
        '
        '通番Box
        '
        Me.通番Box.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.通番Box.Location = New System.Drawing.Point(843, 160)
        Me.通番Box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.通番Box.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.通番Box.Name = "通番Box"
        Me.通番Box.Size = New System.Drawing.Size(113, 23)
        Me.通番Box.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(725, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "次の通番"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.電離のみ受付Btn)
        Me.GroupBox1.Controls.Add(Me.バーコードデータBox)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 115)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "読み取りデータ"
        '
        '電離のみ受付Btn
        '
        Me.電離のみ受付Btn.BackColor = System.Drawing.Color.Lavender
        Me.電離のみ受付Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.電離のみ受付Btn.Font = New System.Drawing.Font("Meiryo UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.電離のみ受付Btn.ForeColor = System.Drawing.Color.SlateBlue
        Me.電離のみ受付Btn.Location = New System.Drawing.Point(74, 73)
        Me.電離のみ受付Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.電離のみ受付Btn.Name = "電離のみ受付Btn"
        Me.電離のみ受付Btn.Size = New System.Drawing.Size(105, 31)
        Me.電離のみ受付Btn.TabIndex = 6
        Me.電離のみ受付Btn.Text = "電離のみ受付"
        Me.電離のみ受付Btn.UseVisualStyleBackColor = False
        '
        'バーコードデータBox
        '
        Me.バーコードデータBox.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.バーコードデータBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.バーコードデータBox.Location = New System.Drawing.Point(74, 35)
        Me.バーコードデータBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.バーコードデータBox.Name = "バーコードデータBox"
        Me.バーコードデータBox.Size = New System.Drawing.Size(420, 28)
        Me.バーコードデータBox.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.受付人数Label)
        Me.Panel1.Controls.Add(Me.messageLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(725, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "受付人数"
        '
        '受付人数Label
        '
        Me.受付人数Label.AutoSize = True
        Me.受付人数Label.Location = New System.Drawing.Point(965, 17)
        Me.受付人数Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.受付人数Label.Name = "受付人数Label"
        Me.受付人数Label.Size = New System.Drawing.Size(105, 20)
        Me.受付人数Label.TabIndex = 1
        Me.受付人数Label.Text = "0　／　0　　名"
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(45, 17)
        Me.messageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(337, 20)
        Me.messageLabel.TabIndex = 0
        Me.messageLabel.Text = "下の表スペースに健診簿をドラッグ・ドロップして下さい"
        '
        'レコード検索Page
        '
        Me.レコード検索Page.BackColor = System.Drawing.SystemColors.Control
        Me.レコード検索Page.Controls.Add(Me.絞込クリアBtn)
        Me.レコード検索Page.Controls.Add(Me.フィルタ条件選択Box)
        Me.レコード検索Page.Controls.Add(Me.フィルタカラム選択Box)
        Me.レコード検索Page.Controls.Add(Me.フィルタキーBox)
        Me.レコード検索Page.Controls.Add(Me.絞込Btn)
        Me.レコード検索Page.Controls.Add(Me.Label13)
        Me.レコード検索Page.Controls.Add(Me.検索カラム選択Box)
        Me.レコード検索Page.Controls.Add(Me.検索キーBox)
        Me.レコード検索Page.Controls.Add(Me.検索Btn)
        Me.レコード検索Page.Controls.Add(Me.Label4)
        Me.レコード検索Page.Location = New System.Drawing.Point(4, 22)
        Me.レコード検索Page.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.レコード検索Page.Name = "レコード検索Page"
        Me.レコード検索Page.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.レコード検索Page.Size = New System.Drawing.Size(1156, 249)
        Me.レコード検索Page.TabIndex = 1
        Me.レコード検索Page.Text = "レコード検索"
        '
        '絞込クリアBtn
        '
        Me.絞込クリアBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.絞込クリアBtn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.絞込クリアBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.絞込クリアBtn.Location = New System.Drawing.Point(977, 166)
        Me.絞込クリアBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.絞込クリアBtn.Name = "絞込クリアBtn"
        Me.絞込クリアBtn.Size = New System.Drawing.Size(114, 43)
        Me.絞込クリアBtn.TabIndex = 21
        Me.絞込クリアBtn.Text = "クリア"
        Me.絞込クリアBtn.UseVisualStyleBackColor = False
        '
        'フィルタ条件選択Box
        '
        Me.フィルタ条件選択Box.FormattingEnabled = True
        Me.フィルタ条件選択Box.Items.AddRange(New Object() {"と等しい", "を含む", "より大きい", "より小さい", "空でない"})
        Me.フィルタ条件選択Box.Location = New System.Drawing.Point(660, 170)
        Me.フィルタ条件選択Box.Name = "フィルタ条件選択Box"
        Me.フィルタ条件選択Box.Size = New System.Drawing.Size(121, 28)
        Me.フィルタ条件選択Box.TabIndex = 14
        '
        'フィルタカラム選択Box
        '
        Me.フィルタカラム選択Box.FormattingEnabled = True
        Me.フィルタカラム選択Box.Location = New System.Drawing.Point(210, 170)
        Me.フィルタカラム選択Box.Name = "フィルタカラム選択Box"
        Me.フィルタカラム選択Box.Size = New System.Drawing.Size(121, 28)
        Me.フィルタカラム選択Box.TabIndex = 13
        '
        'フィルタキーBox
        '
        Me.フィルタキーBox.Location = New System.Drawing.Point(377, 170)
        Me.フィルタキーBox.Name = "フィルタキーBox"
        Me.フィルタキーBox.Size = New System.Drawing.Size(265, 28)
        Me.フィルタキーBox.TabIndex = 12
        '
        '絞込Btn
        '
        Me.絞込Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.絞込Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.絞込Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.絞込Btn.Location = New System.Drawing.Point(831, 166)
        Me.絞込Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.絞込Btn.Name = "絞込Btn"
        Me.絞込Btn.Size = New System.Drawing.Size(114, 43)
        Me.絞込Btn.TabIndex = 11
        Me.絞込Btn.Text = "絞込"
        Me.絞込Btn.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(56, 117)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "レコードの絞込（フィルタ）"
        '
        '検索カラム選択Box
        '
        Me.検索カラム選択Box.FormattingEnabled = True
        Me.検索カラム選択Box.Location = New System.Drawing.Point(210, 54)
        Me.検索カラム選択Box.Name = "検索カラム選択Box"
        Me.検索カラム選択Box.Size = New System.Drawing.Size(121, 28)
        Me.検索カラム選択Box.TabIndex = 9
        '
        '検索キーBox
        '
        Me.検索キーBox.Location = New System.Drawing.Point(377, 54)
        Me.検索キーBox.Name = "検索キーBox"
        Me.検索キーBox.Size = New System.Drawing.Size(350, 28)
        Me.検索キーBox.TabIndex = 8
        '
        '検索Btn
        '
        Me.検索Btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.検索Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.検索Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.検索Btn.Location = New System.Drawing.Point(831, 50)
        Me.検索Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.検索Btn.Name = "検索Btn"
        Me.検索Btn.Size = New System.Drawing.Size(114, 43)
        Me.検索Btn.TabIndex = 7
        Me.検索Btn.Text = "検索"
        Me.検索Btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(56, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "レコードの検索"
        '
        'データ出力Page
        '
        Me.データ出力Page.BackColor = System.Drawing.SystemColors.Control
        Me.データ出力Page.Controls.Add(Me.ファイル選択Btn)
        Me.データ出力Page.Controls.Add(Me.エクセルファイル出力Btn)
        Me.データ出力Page.Controls.Add(Me.OutputFilePathBox)
        Me.データ出力Page.Controls.Add(Me.Label5)
        Me.データ出力Page.Location = New System.Drawing.Point(4, 22)
        Me.データ出力Page.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.データ出力Page.Name = "データ出力Page"
        Me.データ出力Page.Size = New System.Drawing.Size(1156, 249)
        Me.データ出力Page.TabIndex = 2
        Me.データ出力Page.Text = "データ出力"
        '
        'ファイル選択Btn
        '
        Me.ファイル選択Btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ファイル選択Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ファイル選択Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ファイル選択Btn.Location = New System.Drawing.Point(813, 54)
        Me.ファイル選択Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ファイル選択Btn.Name = "ファイル選択Btn"
        Me.ファイル選択Btn.Size = New System.Drawing.Size(114, 43)
        Me.ファイル選択Btn.TabIndex = 20
        Me.ファイル選択Btn.Text = "選択"
        Me.ファイル選択Btn.UseVisualStyleBackColor = False
        '
        'エクセルファイル出力Btn
        '
        Me.エクセルファイル出力Btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.エクセルファイル出力Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.エクセルファイル出力Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.エクセルファイル出力Btn.Location = New System.Drawing.Point(876, 179)
        Me.エクセルファイル出力Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.エクセルファイル出力Btn.Name = "エクセルファイル出力Btn"
        Me.エクセルファイル出力Btn.Size = New System.Drawing.Size(225, 43)
        Me.エクセルファイル出力Btn.TabIndex = 13
        Me.エクセルファイル出力Btn.Text = "エクセルファイルに出力"
        Me.エクセルファイル出力Btn.UseVisualStyleBackColor = False
        '
        'OutputFilePathBox
        '
        Me.OutputFilePathBox.Location = New System.Drawing.Point(254, 54)
        Me.OutputFilePathBox.Name = "OutputFilePathBox"
        Me.OutputFilePathBox.Size = New System.Drawing.Size(512, 28)
        Me.OutputFilePathBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ファイル出力先"
        '
        '設定Page
        '
        Me.設定Page.BackColor = System.Drawing.SystemColors.Control
        Me.設定Page.Controls.Add(Me.白紙バーコードNoBox)
        Me.設定Page.Controls.Add(Me.Label12)
        Me.設定Page.Controls.Add(Me.出力ファイル名Box)
        Me.設定Page.Controls.Add(Me.Label2)
        Me.設定Page.Controls.Add(Me.入力カラム名Box)
        Me.設定Page.Controls.Add(Me.Label11)
        Me.設定Page.Controls.Add(Me.出力先フォルダパス選択Btn)
        Me.設定Page.Controls.Add(Me.バーコードカラム名Box)
        Me.設定Page.Controls.Add(Me.Label10)
        Me.設定Page.Controls.Add(Me.バーコード受信方法Box)
        Me.設定Page.Controls.Add(Me.検索モードBox)
        Me.設定Page.Controls.Add(Me.設定を保存Btn)
        Me.設定Page.Controls.Add(Me.Label9)
        Me.設定Page.Controls.Add(Me.Label8)
        Me.設定Page.Controls.Add(Me.出力先フォルダパスBox)
        Me.設定Page.Controls.Add(Me.Label7)
        Me.設定Page.Controls.Add(Me.通番開始番号Box)
        Me.設定Page.Controls.Add(Me.Label6)
        Me.設定Page.Location = New System.Drawing.Point(4, 22)
        Me.設定Page.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.設定Page.Name = "設定Page"
        Me.設定Page.Size = New System.Drawing.Size(1156, 249)
        Me.設定Page.TabIndex = 3
        Me.設定Page.Text = "設定"
        '
        '白紙バーコードNoBox
        '
        Me.白紙バーコードNoBox.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.白紙バーコードNoBox.Location = New System.Drawing.Point(677, 182)
        Me.白紙バーコードNoBox.Name = "白紙バーコードNoBox"
        Me.白紙バーコードNoBox.Size = New System.Drawing.Size(150, 25)
        Me.白紙バーコードNoBox.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(488, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "白紙バーコードNo"
        '
        '出力ファイル名Box
        '
        Me.出力ファイル名Box.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出力ファイル名Box.Location = New System.Drawing.Point(198, 130)
        Me.出力ファイル名Box.Name = "出力ファイル名Box"
        Me.出力ファイル名Box.Size = New System.Drawing.Size(150, 25)
        Me.出力ファイル名Box.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "出力ファイル名"
        '
        '入力カラム名Box
        '
        Me.入力カラム名Box.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.入力カラム名Box.Location = New System.Drawing.Point(677, 24)
        Me.入力カラム名Box.Name = "入力カラム名Box"
        Me.入力カラム名Box.Size = New System.Drawing.Size(150, 25)
        Me.入力カラム名Box.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(488, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "入力カラム名"
        '
        '出力先フォルダパス選択Btn
        '
        Me.出力先フォルダパス選択Btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.出力先フォルダパス選択Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出力先フォルダパス選択Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.出力先フォルダパス選択Btn.Location = New System.Drawing.Point(355, 77)
        Me.出力先フォルダパス選択Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.出力先フォルダパス選択Btn.Name = "出力先フォルダパス選択Btn"
        Me.出力先フォルダパス選択Btn.Size = New System.Drawing.Size(100, 34)
        Me.出力先フォルダパス選択Btn.TabIndex = 19
        Me.出力先フォルダパス選択Btn.Text = "選択"
        Me.出力先フォルダパス選択Btn.UseVisualStyleBackColor = False
        '
        'バーコードカラム名Box
        '
        Me.バーコードカラム名Box.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.バーコードカラム名Box.Location = New System.Drawing.Point(198, 182)
        Me.バーコードカラム名Box.Name = "バーコードカラム名Box"
        Me.バーコードカラム名Box.Size = New System.Drawing.Size(150, 25)
        Me.バーコードカラム名Box.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "バーコードカラム名"
        '
        'バーコード受信方法Box
        '
        Me.バーコード受信方法Box.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.バーコード受信方法Box.FormattingEnabled = True
        Me.バーコード受信方法Box.Items.AddRange(New Object() {"USB(HID)"})
        Me.バーコード受信方法Box.Location = New System.Drawing.Point(677, 130)
        Me.バーコード受信方法Box.Name = "バーコード受信方法Box"
        Me.バーコード受信方法Box.Size = New System.Drawing.Size(150, 26)
        Me.バーコード受信方法Box.TabIndex = 16
        '
        '検索モードBox
        '
        Me.検索モードBox.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.検索モードBox.FormattingEnabled = True
        Me.検索モードBox.Items.AddRange(New Object() {"全文一致", "部分一致"})
        Me.検索モードBox.Location = New System.Drawing.Point(677, 77)
        Me.検索モードBox.Name = "検索モードBox"
        Me.検索モードBox.Size = New System.Drawing.Size(150, 26)
        Me.検索モードBox.TabIndex = 15
        '
        '設定を保存Btn
        '
        Me.設定を保存Btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.設定を保存Btn.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.設定を保存Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.設定を保存Btn.Location = New System.Drawing.Point(944, 182)
        Me.設定を保存Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.設定を保存Btn.Name = "設定を保存Btn"
        Me.設定を保存Btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.設定を保存Btn.Size = New System.Drawing.Size(152, 43)
        Me.設定を保存Btn.TabIndex = 14
        Me.設定を保存Btn.Text = "設定を保存"
        Me.設定を保存Btn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(488, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "バーコード受信方法"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "検索モード"
        '
        '出力先フォルダパスBox
        '
        Me.出力先フォルダパスBox.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出力先フォルダパスBox.Location = New System.Drawing.Point(198, 80)
        Me.出力先フォルダパスBox.Name = "出力先フォルダパスBox"
        Me.出力先フォルダパスBox.Size = New System.Drawing.Size(150, 25)
        Me.出力先フォルダパスBox.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "出力先フォルダパス"
        '
        '通番開始番号Box
        '
        Me.通番開始番号Box.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.通番開始番号Box.Location = New System.Drawing.Point(198, 27)
        Me.通番開始番号Box.Name = "通番開始番号Box"
        Me.通番開始番号Box.Size = New System.Drawing.Size(150, 25)
        Me.通番開始番号Box.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "通番開始番号"
        '
        'dragdropMessage
        '
        Me.dragdropMessage.AllowDrop = True
        Me.dragdropMessage.AutoSize = True
        Me.dragdropMessage.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.dragdropMessage.Font = New System.Drawing.Font("Meiryo UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dragdropMessage.Location = New System.Drawing.Point(414, 170)
        Me.dragdropMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dragdropMessage.Name = "dragdropMessage"
        Me.dragdropMessage.Padding = New System.Windows.Forms.Padding(10)
        Me.dragdropMessage.Size = New System.Drawing.Size(332, 44)
        Me.dragdropMessage.TabIndex = 1
        Me.dragdropMessage.Text = "ここへエクセルファイルをドラッグ・ドロップ"
        '
        'excelDataGridView
        '
        Me.excelDataGridView.AllowDrop = True
        Me.excelDataGridView.AllowUserToDeleteRows = False
        Me.excelDataGridView.AllowUserToOrderColumns = True
        Me.excelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.excelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.excelDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.excelDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.excelDataGridView.MultiSelect = False
        Me.excelDataGridView.Name = "excelDataGridView"
        Me.excelDataGridView.RowTemplate.Height = 24
        Me.excelDataGridView.Size = New System.Drawing.Size(1164, 386)
        Me.excelDataGridView.TabIndex = 0
        '
        'grdDataSet
        '
        Me.grdDataSet.DataSetName = "NewDataSet"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem1.Text = "列削除"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 668)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "バーコード受付ツール"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.バーコード受付Page.ResumeLayout(False)
        Me.バーコード受付Page.PerformLayout()
        CType(Me.通番Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.レコード検索Page.ResumeLayout(False)
        Me.レコード検索Page.PerformLayout()
        Me.データ出力Page.ResumeLayout(False)
        Me.データ出力Page.PerformLayout()
        Me.設定Page.ResumeLayout(False)
        Me.設定Page.PerformLayout()
        CType(Me.excelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents バーコード受付Page As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents messageLabel As Label
    Friend WithEvents レコード検索Page As TabPage
    Friend WithEvents データ出力Page As TabPage
    Friend WithEvents 設定Page As TabPage
    Friend WithEvents excelDataGridView As DataGridView
    Friend WithEvents grdDataSet As DataSet
    Friend WithEvents 受付人数Label As Label
    Friend WithEvents dragdropMessage As Label
    Friend WithEvents 通番リセットBtn As Button
    Friend WithEvents 通番Box As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents バーコードデータBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents 検索カラム選択Box As ComboBox
    Friend WithEvents 検索キーBox As TextBox
    Friend WithEvents 検索Btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents エクセルファイル出力Btn As Button
    Friend WithEvents OutputFilePathBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents 出力先フォルダパス選択Btn As Button
    Friend WithEvents バーコードカラム名Box As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents バーコード受信方法Box As ComboBox
    Friend WithEvents 検索モードBox As ComboBox
    Friend WithEvents 設定を保存Btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents 出力先フォルダパスBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents 通番開始番号Box As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ファイル選択Btn As Button
    Friend WithEvents 入力カラム名Box As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents 出力ファイル名Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents 白紙バーコードNoBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents フィルタ条件選択Box As ComboBox
    Friend WithEvents フィルタカラム選択Box As ComboBox
    Friend WithEvents フィルタキーBox As TextBox
    Friend WithEvents 絞込Btn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents 絞込クリアBtn As Button
    Friend WithEvents 受診済み絞込ボタン As CheckBox
    Friend WithEvents 電離のみ受付Btn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
