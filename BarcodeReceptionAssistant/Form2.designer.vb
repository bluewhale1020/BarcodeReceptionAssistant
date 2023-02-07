<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 本人確認ダイアログ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(本人確認ダイアログ))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.尿代謝詳細Label = New System.Windows.Forms.Label()
        Me.尿代謝Label = New System.Windows.Forms.Label()
        Me.尿検査2Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.尿検査Label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.othersPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.その他検査Label = New System.Windows.Forms.Label()
        Me.血液検査Panel = New System.Windows.Forms.Panel()
        Me.採血パターンLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.情報データ9 = New System.Windows.Forms.Label()
        Me.情報ラベル9 = New System.Windows.Forms.Label()
        Me.情報データ8 = New System.Windows.Forms.Label()
        Me.情報ラベル8 = New System.Windows.Forms.Label()
        Me.情報データ7 = New System.Windows.Forms.Label()
        Me.情報データ6 = New System.Windows.Forms.Label()
        Me.情報データ5 = New System.Windows.Forms.Label()
        Me.情報データ4 = New System.Windows.Forms.Label()
        Me.情報データ3 = New System.Windows.Forms.Label()
        Me.情報データ2 = New System.Windows.Forms.Label()
        Me.情報データ1 = New System.Windows.Forms.Label()
        Me.情報ラベル7 = New System.Windows.Forms.Label()
        Me.情報ラベル6 = New System.Windows.Forms.Label()
        Me.情報ラベル5 = New System.Windows.Forms.Label()
        Me.情報ラベル4 = New System.Windows.Forms.Label()
        Me.情報ラベル3 = New System.Windows.Forms.Label()
        Me.情報ラベル2 = New System.Windows.Forms.Label()
        Me.情報ラベル1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.通番入力ラベル = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.バーコードLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.確定Btn = New System.Windows.Forms.Button()
        Me.キャンセルBtn = New System.Windows.Forms.Button()
        Me.後日便ボタン = New System.Windows.Forms.CheckBox()
        Me.後日尿ボタン = New System.Windows.Forms.CheckBox()
        Me.電離ボタン = New System.Windows.Forms.CheckBox()
        Me.胸部XPボタン = New System.Windows.Forms.CheckBox()
        Me.胃部XPボタン = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.othersPanel.SuspendLayout()
        Me.血液検査Panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(18, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 514)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.尿代謝詳細Label)
        Me.GroupBox2.Controls.Add(Me.尿代謝Label)
        Me.GroupBox2.Controls.Add(Me.尿検査2Label)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.尿検査Label)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.othersPanel)
        Me.GroupBox2.Controls.Add(Me.血液検査Panel)
        Me.GroupBox2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 209)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "検査オプション"
        '
        '尿代謝詳細Label
        '
        Me.尿代謝詳細Label.AutoSize = True
        Me.尿代謝詳細Label.ForeColor = System.Drawing.Color.SaddleBrown
        Me.尿代謝詳細Label.Location = New System.Drawing.Point(430, 49)
        Me.尿代謝詳細Label.MaximumSize = New System.Drawing.Size(280, 0)
        Me.尿代謝詳細Label.Name = "尿代謝詳細Label"
        Me.尿代謝詳細Label.Size = New System.Drawing.Size(0, 18)
        Me.尿代謝詳細Label.TabIndex = 20
        '
        '尿代謝Label
        '
        Me.尿代謝Label.AutoSize = True
        Me.尿代謝Label.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.尿代謝Label.ForeColor = System.Drawing.Color.Navy
        Me.尿代謝Label.Location = New System.Drawing.Point(353, 49)
        Me.尿代謝Label.Name = "尿代謝Label"
        Me.尿代謝Label.Size = New System.Drawing.Size(0, 18)
        Me.尿代謝Label.TabIndex = 21
        '
        '尿検査2Label
        '
        Me.尿検査2Label.AutoSize = True
        Me.尿検査2Label.ForeColor = System.Drawing.Color.SaddleBrown
        Me.尿検査2Label.Location = New System.Drawing.Point(430, 16)
        Me.尿検査2Label.Name = "尿検査2Label"
        Me.尿検査2Label.Size = New System.Drawing.Size(0, 18)
        Me.尿検査2Label.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "血液検査"
        '
        '尿検査Label
        '
        Me.尿検査Label.AutoSize = True
        Me.尿検査Label.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.尿検査Label.ForeColor = System.Drawing.Color.Navy
        Me.尿検査Label.Location = New System.Drawing.Point(353, 16)
        Me.尿検査Label.Name = "尿検査Label"
        Me.尿検査Label.Size = New System.Drawing.Size(0, 18)
        Me.尿検査Label.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "その他"
        '
        'othersPanel
        '
        Me.othersPanel.Controls.Add(Me.その他検査Label)
        Me.othersPanel.Location = New System.Drawing.Point(112, 134)
        Me.othersPanel.Name = "othersPanel"
        Me.othersPanel.Size = New System.Drawing.Size(583, 69)
        Me.othersPanel.TabIndex = 3
        '
        'その他検査Label
        '
        Me.その他検査Label.AutoSize = True
        Me.その他検査Label.ForeColor = System.Drawing.Color.Navy
        Me.その他検査Label.Location = New System.Drawing.Point(3, 0)
        Me.その他検査Label.MaximumSize = New System.Drawing.Size(500, 0)
        Me.その他検査Label.Name = "その他検査Label"
        Me.その他検査Label.Size = New System.Drawing.Size(148, 18)
        Me.その他検査Label.TabIndex = 2
        Me.その他検査Label.Text = "その他の検査はありません"
        '
        '血液検査Panel
        '
        Me.血液検査Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.血液検査Panel.Controls.Add(Me.採血パターンLabel)
        Me.血液検査Panel.Location = New System.Drawing.Point(112, 28)
        Me.血液検査Panel.Name = "血液検査Panel"
        Me.血液検査Panel.Size = New System.Drawing.Size(199, 30)
        Me.血液検査Panel.TabIndex = 4
        '
        '採血パターンLabel
        '
        Me.採血パターンLabel.AutoSize = True
        Me.採血パターンLabel.ForeColor = System.Drawing.Color.Maroon
        Me.採血パターンLabel.Location = New System.Drawing.Point(16, 6)
        Me.採血パターンLabel.Name = "採血パターンLabel"
        Me.採血パターンLabel.Size = New System.Drawing.Size(32, 18)
        Me.採血パターンLabel.TabIndex = 1
        Me.採血パターンLabel.Text = "無し"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.情報データ9)
        Me.GroupBox1.Controls.Add(Me.情報ラベル9)
        Me.GroupBox1.Controls.Add(Me.情報データ8)
        Me.GroupBox1.Controls.Add(Me.情報ラベル8)
        Me.GroupBox1.Controls.Add(Me.情報データ7)
        Me.GroupBox1.Controls.Add(Me.情報データ6)
        Me.GroupBox1.Controls.Add(Me.情報データ5)
        Me.GroupBox1.Controls.Add(Me.情報データ4)
        Me.GroupBox1.Controls.Add(Me.情報データ3)
        Me.GroupBox1.Controls.Add(Me.情報データ2)
        Me.GroupBox1.Controls.Add(Me.情報データ1)
        Me.GroupBox1.Controls.Add(Me.情報ラベル7)
        Me.GroupBox1.Controls.Add(Me.情報ラベル6)
        Me.GroupBox1.Controls.Add(Me.情報ラベル5)
        Me.GroupBox1.Controls.Add(Me.情報ラベル4)
        Me.GroupBox1.Controls.Add(Me.情報ラベル3)
        Me.GroupBox1.Controls.Add(Me.情報ラベル2)
        Me.GroupBox1.Controls.Add(Me.情報ラベル1)
        Me.GroupBox1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "受診者情報"
        '
        '情報データ9
        '
        Me.情報データ9.AutoSize = True
        Me.情報データ9.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ9.Location = New System.Drawing.Point(488, 142)
        Me.情報データ9.MaximumSize = New System.Drawing.Size(163, 0)
        Me.情報データ9.Name = "情報データ9"
        Me.情報データ9.Size = New System.Drawing.Size(66, 15)
        Me.情報データ9.TabIndex = 22
        Me.情報データ9.Text = "情報データ9"
        '
        '情報ラベル9
        '
        Me.情報ラベル9.AutoSize = True
        Me.情報ラベル9.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル9.Location = New System.Drawing.Point(409, 142)
        Me.情報ラベル9.Name = "情報ラベル9"
        Me.情報ラベル9.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル9.TabIndex = 21
        Me.情報ラベル9.Text = "情報ラベル9"
        '
        '情報データ8
        '
        Me.情報データ8.AutoSize = True
        Me.情報データ8.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ8.Location = New System.Drawing.Point(488, 103)
        Me.情報データ8.MaximumSize = New System.Drawing.Size(163, 0)
        Me.情報データ8.Name = "情報データ8"
        Me.情報データ8.Size = New System.Drawing.Size(66, 15)
        Me.情報データ8.TabIndex = 20
        Me.情報データ8.Text = "情報データ8"
        '
        '情報ラベル8
        '
        Me.情報ラベル8.AutoSize = True
        Me.情報ラベル8.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル8.Location = New System.Drawing.Point(409, 103)
        Me.情報ラベル8.Name = "情報ラベル8"
        Me.情報ラベル8.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル8.TabIndex = 19
        Me.情報ラベル8.Text = "情報ラベル8"
        '
        '情報データ7
        '
        Me.情報データ7.AutoSize = True
        Me.情報データ7.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ7.Location = New System.Drawing.Point(488, 66)
        Me.情報データ7.MaximumSize = New System.Drawing.Size(163, 0)
        Me.情報データ7.Name = "情報データ7"
        Me.情報データ7.Size = New System.Drawing.Size(66, 15)
        Me.情報データ7.TabIndex = 18
        Me.情報データ7.Text = "情報データ7"
        '
        '情報データ6
        '
        Me.情報データ6.AutoSize = True
        Me.情報データ6.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ6.Location = New System.Drawing.Point(488, 29)
        Me.情報データ6.MaximumSize = New System.Drawing.Size(163, 0)
        Me.情報データ6.Name = "情報データ6"
        Me.情報データ6.Size = New System.Drawing.Size(66, 15)
        Me.情報データ6.TabIndex = 17
        Me.情報データ6.Text = "情報データ6"
        '
        '情報データ5
        '
        Me.情報データ5.AutoSize = True
        Me.情報データ5.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ5.ForeColor = System.Drawing.Color.Teal
        Me.情報データ5.Location = New System.Drawing.Point(114, 173)
        Me.情報データ5.MaximumSize = New System.Drawing.Size(163, 0)
        Me.情報データ5.Name = "情報データ5"
        Me.情報データ5.Size = New System.Drawing.Size(92, 20)
        Me.情報データ5.TabIndex = 16
        Me.情報データ5.Text = "情報データ5"
        '
        '情報データ4
        '
        Me.情報データ4.AutoSize = True
        Me.情報データ4.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ4.Location = New System.Drawing.Point(115, 142)
        Me.情報データ4.MaximumSize = New System.Drawing.Size(235, 0)
        Me.情報データ4.Name = "情報データ4"
        Me.情報データ4.Size = New System.Drawing.Size(66, 15)
        Me.情報データ4.TabIndex = 15
        Me.情報データ4.Text = "情報データ4"
        '
        '情報データ3
        '
        Me.情報データ3.AutoSize = True
        Me.情報データ3.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ3.Location = New System.Drawing.Point(115, 103)
        Me.情報データ3.MaximumSize = New System.Drawing.Size(235, 0)
        Me.情報データ3.Name = "情報データ3"
        Me.情報データ3.Size = New System.Drawing.Size(66, 15)
        Me.情報データ3.TabIndex = 14
        Me.情報データ3.Text = "情報データ3"
        '
        '情報データ2
        '
        Me.情報データ2.AutoSize = True
        Me.情報データ2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ2.Location = New System.Drawing.Point(115, 64)
        Me.情報データ2.MaximumSize = New System.Drawing.Size(235, 0)
        Me.情報データ2.Name = "情報データ2"
        Me.情報データ2.Size = New System.Drawing.Size(66, 15)
        Me.情報データ2.TabIndex = 13
        Me.情報データ2.Text = "情報データ2"
        '
        '情報データ1
        '
        Me.情報データ1.AutoSize = True
        Me.情報データ1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報データ1.Location = New System.Drawing.Point(115, 28)
        Me.情報データ1.MaximumSize = New System.Drawing.Size(235, 0)
        Me.情報データ1.Name = "情報データ1"
        Me.情報データ1.Size = New System.Drawing.Size(66, 15)
        Me.情報データ1.TabIndex = 12
        Me.情報データ1.Text = "情報データ1"
        '
        '情報ラベル7
        '
        Me.情報ラベル7.AutoSize = True
        Me.情報ラベル7.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル7.Location = New System.Drawing.Point(409, 66)
        Me.情報ラベル7.Name = "情報ラベル7"
        Me.情報ラベル7.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル7.TabIndex = 11
        Me.情報ラベル7.Text = "情報ラベル7"
        '
        '情報ラベル6
        '
        Me.情報ラベル6.AutoSize = True
        Me.情報ラベル6.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル6.Location = New System.Drawing.Point(409, 29)
        Me.情報ラベル6.Name = "情報ラベル6"
        Me.情報ラベル6.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル6.TabIndex = 10
        Me.情報ラベル6.Text = "情報ラベル6"
        '
        '情報ラベル5
        '
        Me.情報ラベル5.AutoSize = True
        Me.情報ラベル5.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル5.Location = New System.Drawing.Point(39, 179)
        Me.情報ラベル5.Name = "情報ラベル5"
        Me.情報ラベル5.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル5.TabIndex = 9
        Me.情報ラベル5.Text = "情報ラベル5"
        '
        '情報ラベル4
        '
        Me.情報ラベル4.AutoSize = True
        Me.情報ラベル4.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル4.Location = New System.Drawing.Point(39, 142)
        Me.情報ラベル4.Name = "情報ラベル4"
        Me.情報ラベル4.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル4.TabIndex = 8
        Me.情報ラベル4.Text = "情報ラベル4"
        '
        '情報ラベル3
        '
        Me.情報ラベル3.AutoSize = True
        Me.情報ラベル3.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル3.Location = New System.Drawing.Point(39, 103)
        Me.情報ラベル3.Name = "情報ラベル3"
        Me.情報ラベル3.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル3.TabIndex = 7
        Me.情報ラベル3.Text = "情報ラベル3"
        '
        '情報ラベル2
        '
        Me.情報ラベル2.AutoSize = True
        Me.情報ラベル2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル2.Location = New System.Drawing.Point(39, 64)
        Me.情報ラベル2.Name = "情報ラベル2"
        Me.情報ラベル2.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル2.TabIndex = 6
        Me.情報ラベル2.Text = "情報ラベル2"
        '
        '情報ラベル1
        '
        Me.情報ラベル1.AutoSize = True
        Me.情報ラベル1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.情報ラベル1.Location = New System.Drawing.Point(39, 28)
        Me.情報ラベル1.Name = "情報ラベル1"
        Me.情報ラベル1.Size = New System.Drawing.Size(66, 15)
        Me.情報ラベル1.TabIndex = 5
        Me.情報ラベル1.Text = "情報ラベル1"
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.バーコードLabel)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 86)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.通番入力ラベル)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(518, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(203, 35)
        Me.Panel4.TabIndex = 3
        '
        '通番入力ラベル
        '
        Me.通番入力ラベル.AutoSize = True
        Me.通番入力ラベル.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.通番入力ラベル.ForeColor = System.Drawing.SystemColors.Highlight
        Me.通番入力ラベル.Location = New System.Drawing.Point(117, 9)
        Me.通番入力ラベル.Name = "通番入力ラベル"
        Me.通番入力ラベル.Size = New System.Drawing.Size(35, 20)
        Me.通番入力ラベル.TabIndex = 1
        Me.通番入力ラベル.Text = "なし"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "通番入力"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(514, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "以下の受診者と一致しました。該当者か受診票で確認し、確定ボタンを押して下さい。"
        '
        'バーコードLabel
        '
        Me.バーコードLabel.AutoSize = True
        Me.バーコードLabel.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.バーコードLabel.Location = New System.Drawing.Point(125, 11)
        Me.バーコードLabel.Name = "バーコードLabel"
        Me.バーコードLabel.Size = New System.Drawing.Size(101, 19)
        Me.バーコードLabel.TabIndex = 1
        Me.バーコードLabel.Text = "バーコードデータ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "バーコード情報："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.確定Btn)
        Me.Panel2.Controls.Add(Me.キャンセルBtn)
        Me.Panel2.Location = New System.Drawing.Point(443, 533)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 47)
        Me.Panel2.TabIndex = 1
        '
        '確定Btn
        '
        Me.確定Btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.確定Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.確定Btn.Location = New System.Drawing.Point(179, 4)
        Me.確定Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.確定Btn.Name = "確定Btn"
        Me.確定Btn.Size = New System.Drawing.Size(112, 38)
        Me.確定Btn.TabIndex = 1
        Me.確定Btn.Text = "確定"
        Me.確定Btn.UseVisualStyleBackColor = False
        '
        'キャンセルBtn
        '
        Me.キャンセルBtn.Location = New System.Drawing.Point(20, 4)
        Me.キャンセルBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.キャンセルBtn.Name = "キャンセルBtn"
        Me.キャンセルBtn.Size = New System.Drawing.Size(112, 38)
        Me.キャンセルBtn.TabIndex = 0
        Me.キャンセルBtn.Text = "キャンセル"
        Me.キャンセルBtn.UseVisualStyleBackColor = True
        '
        '後日便ボタン
        '
        Me.後日便ボタン.AutoSize = True
        Me.後日便ボタン.Location = New System.Drawing.Point(21, 547)
        Me.後日便ボタン.Name = "後日便ボタン"
        Me.後日便ボタン.Size = New System.Drawing.Size(76, 24)
        Me.後日便ボタン.TabIndex = 2
        Me.後日便ボタン.Text = "後日便"
        Me.後日便ボタン.UseVisualStyleBackColor = True
        '
        '後日尿ボタン
        '
        Me.後日尿ボタン.AutoSize = True
        Me.後日尿ボタン.Location = New System.Drawing.Point(103, 547)
        Me.後日尿ボタン.Name = "後日尿ボタン"
        Me.後日尿ボタン.Size = New System.Drawing.Size(76, 24)
        Me.後日尿ボタン.TabIndex = 3
        Me.後日尿ボタン.Text = "後日尿"
        Me.後日尿ボタン.UseVisualStyleBackColor = True
        '
        '電離ボタン
        '
        Me.電離ボタン.AutoSize = True
        Me.電離ボタン.Location = New System.Drawing.Point(187, 547)
        Me.電離ボタン.Name = "電離ボタン"
        Me.電離ボタン.Size = New System.Drawing.Size(60, 24)
        Me.電離ボタン.TabIndex = 4
        Me.電離ボタン.Text = "電離"
        Me.電離ボタン.UseVisualStyleBackColor = True
        '
        '胸部XPボタン
        '
        Me.胸部XPボタン.AutoSize = True
        Me.胸部XPボタン.Location = New System.Drawing.Point(262, 547)
        Me.胸部XPボタン.Name = "胸部XPボタン"
        Me.胸部XPボタン.Size = New System.Drawing.Size(60, 24)
        Me.胸部XPボタン.TabIndex = 5
        Me.胸部XPボタン.Text = "胸部"
        Me.胸部XPボタン.UseVisualStyleBackColor = True
        '
        '胃部XPボタン
        '
        Me.胃部XPボタン.AutoSize = True
        Me.胃部XPボタン.Location = New System.Drawing.Point(337, 547)
        Me.胃部XPボタン.Name = "胃部XPボタン"
        Me.胃部XPボタン.Size = New System.Drawing.Size(60, 24)
        Me.胃部XPボタン.TabIndex = 6
        Me.胃部XPボタン.Text = "胃部"
        Me.胃部XPボタン.UseVisualStyleBackColor = True
        '
        '本人確認ダイアログ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 583)
        Me.Controls.Add(Me.胃部XPボタン)
        Me.Controls.Add(Me.胸部XPボタン)
        Me.Controls.Add(Me.電離ボタン)
        Me.Controls.Add(Me.後日尿ボタン)
        Me.Controls.Add(Me.後日便ボタン)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "本人確認ダイアログ"
        Me.Text = "本人確認ダイアログ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.othersPanel.ResumeLayout(False)
        Me.othersPanel.PerformLayout()
        Me.血液検査Panel.ResumeLayout(False)
        Me.血液検査Panel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents バーコードLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents 確定Btn As Button
    Friend WithEvents キャンセルBtn As Button
    Friend WithEvents 血液検査Panel As Panel
    Friend WithEvents othersPanel As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents 採血パターンLabel As Label
    Friend WithEvents 情報データ7 As Label
    Friend WithEvents 情報データ6 As Label
    Friend WithEvents 情報データ5 As Label
    Friend WithEvents 情報データ4 As Label
    Friend WithEvents 情報データ3 As Label
    Friend WithEvents 情報データ2 As Label
    Friend WithEvents 情報データ1 As Label
    Friend WithEvents 情報ラベル7 As Label
    Friend WithEvents 情報ラベル6 As Label
    Friend WithEvents 情報ラベル5 As Label
    Friend WithEvents 情報ラベル4 As Label
    Friend WithEvents 情報ラベル3 As Label
    Friend WithEvents 情報ラベル2 As Label
    Friend WithEvents 情報ラベル1 As Label
    Friend WithEvents その他検査Label As Label
    Friend WithEvents 尿検査2Label As Label
    Friend WithEvents 尿検査Label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents 通番入力ラベル As Label
    Friend WithEvents 情報データ8 As Label
    Friend WithEvents 情報ラベル8 As Label
    Friend WithEvents 情報データ9 As Label
    Friend WithEvents 情報ラベル9 As Label
    Friend WithEvents 尿代謝詳細Label As Label
    Friend WithEvents 尿代謝Label As Label
    Friend WithEvents 後日便ボタン As CheckBox
    Friend WithEvents 後日尿ボタン As CheckBox
    Friend WithEvents 電離ボタン As CheckBox
    Friend WithEvents 胸部XPボタン As CheckBox
    Friend WithEvents 胃部XPボタン As CheckBox
End Class
