<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 本人確認失敗ダイアログ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(本人確認失敗ダイアログ))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.キャンセルBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MessageLabel2 = New System.Windows.Forms.Label()
        Me.MessageLabel1 = New System.Windows.Forms.Label()
        Me.バーコードデータLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.キャンセルBtn)
        Me.Panel2.Controls.Add(Me.OKBtn)
        Me.Panel2.Location = New System.Drawing.Point(436, 224)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 51)
        Me.Panel2.TabIndex = 3
        '
        'キャンセルBtn
        '
        Me.キャンセルBtn.Location = New System.Drawing.Point(25, 8)
        Me.キャンセルBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.キャンセルBtn.Name = "キャンセルBtn"
        Me.キャンセルBtn.Size = New System.Drawing.Size(112, 38)
        Me.キャンセルBtn.TabIndex = 4
        Me.キャンセルBtn.Text = "キャンセル"
        Me.キャンセルBtn.UseVisualStyleBackColor = True
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.OKBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OKBtn.Location = New System.Drawing.Point(173, 8)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(112, 38)
        Me.OKBtn.TabIndex = 1
        Me.OKBtn.Text = "新規登録"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(13, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 200)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.MessageLabel2)
        Me.Panel3.Controls.Add(Me.MessageLabel1)
        Me.Panel3.Controls.Add(Me.バーコードデータLabel)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 200)
        Me.Panel3.TabIndex = 0
        '
        'MessageLabel2
        '
        Me.MessageLabel2.AutoSize = True
        Me.MessageLabel2.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MessageLabel2.Location = New System.Drawing.Point(25, 93)
        Me.MessageLabel2.Name = "MessageLabel2"
        Me.MessageLabel2.Size = New System.Drawing.Size(517, 24)
        Me.MessageLabel2.TabIndex = 3
        Me.MessageLabel2.Text = "新規追加ボタンを押して下さい。やり直す場合は、キャンセルを押し、"
        '
        'MessageLabel1
        '
        Me.MessageLabel1.AutoSize = True
        Me.MessageLabel1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MessageLabel1.Location = New System.Drawing.Point(25, 54)
        Me.MessageLabel1.Name = "MessageLabel1"
        Me.MessageLabel1.Size = New System.Drawing.Size(539, 24)
        Me.MessageLabel1.TabIndex = 2
        Me.MessageLabel1.Text = "健診簿に該当する受診者が見つかりませんでした。追加したい場合は、"
        '
        'バーコードデータLabel
        '
        Me.バーコードデータLabel.AutoSize = True
        Me.バーコードデータLabel.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.バーコードデータLabel.Location = New System.Drawing.Point(178, 11)
        Me.バーコードデータLabel.Name = "バーコードデータLabel"
        Me.バーコードデータLabel.Size = New System.Drawing.Size(129, 24)
        Me.バーコードデータLabel.TabIndex = 1
        Me.バーコードデータLabel.Text = "バーコードデータ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "バーコード情報："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(593, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "もう一度バーコードを読み込むか、読み取りデータ欄に直接手入力して下さい。"
        '
        '本人確認失敗ダイアログ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 302)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "本人確認失敗ダイアログ"
        Me.Text = "本人確認失敗"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents OKBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MessageLabel1 As Label
    Friend WithEvents バーコードデータLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MessageLabel2 As Label
    Friend WithEvents キャンセルBtn As Button
    Friend WithEvents Label2 As Label
End Class
