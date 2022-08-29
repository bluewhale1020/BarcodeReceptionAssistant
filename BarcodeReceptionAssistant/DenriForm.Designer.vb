<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DenriForm
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
        Me.通番ラベル = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.キャンセルBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '通番ラベル
        '
        Me.通番ラベル.AutoSize = True
        Me.通番ラベル.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.通番ラベル.ForeColor = System.Drawing.SystemColors.Highlight
        Me.通番ラベル.Location = New System.Drawing.Point(84, 127)
        Me.通番ラベル.Name = "通番ラベル"
        Me.通番ラベル.Size = New System.Drawing.Size(188, 64)
        Me.通番ラベル.TabIndex = 2
        Me.通番ラベル.Text = "00000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "電離のみの受診者を受付します"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "通番"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.キャンセルBtn)
        Me.Panel2.Controls.Add(Me.OKBtn)
        Me.Panel2.Location = New System.Drawing.Point(58, 222)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 41)
        Me.Panel2.TabIndex = 5
        '
        'キャンセルBtn
        '
        Me.キャンセルBtn.Location = New System.Drawing.Point(19, 6)
        Me.キャンセルBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.キャンセルBtn.Name = "キャンセルBtn"
        Me.キャンセルBtn.Size = New System.Drawing.Size(84, 30)
        Me.キャンセルBtn.TabIndex = 4
        Me.キャンセルBtn.Text = "キャンセル"
        Me.キャンセルBtn.UseVisualStyleBackColor = True
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.OKBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OKBtn.Location = New System.Drawing.Point(130, 6)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(84, 30)
        Me.OKBtn.TabIndex = 1
        Me.OKBtn.Text = "新規受付"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'DenriForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 276)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.通番ラベル)
        Me.Name = "DenriForm"
        Me.Text = "電離のみ受付"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 通番ラベル As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents キャンセルBtn As Button
    Friend WithEvents OKBtn As Button
End Class
