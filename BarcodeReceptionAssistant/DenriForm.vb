Public Class DenriForm
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:オブジェクトを複数回破棄しない")>
    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        新規登録の確定()
        Me.Close()
        CType(Me.Owner, MainForm).電離新規登録処理()
        Me.Dispose()
    End Sub

    Private Sub キャンセルBtn_Click(sender As Object, e As EventArgs) Handles キャンセルBtn.Click
        登録のキャンセル()
        Me.Close()
        CType(Me.Owner, MainForm).電離新規登録処理()
    End Sub

    Private Sub 新規登録の確定()
        CType(Me.Owner, MainForm).confirmed = True

    End Sub

    Private Sub 登録のキャンセル()
        CType(Me.Owner, MainForm).confirmed = False
    End Sub

    Public Sub 通番表示(ByVal serialNumber As Integer)
        通番ラベル.Text = serialNumber.ToString("D5")
    End Sub
End Class