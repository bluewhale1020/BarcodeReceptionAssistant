Public Class 本人確認失敗ダイアログ
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:オブジェクトを複数回破棄しない")>
    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        新規登録の確定()
        Me.Close()
        CType(Me.Owner, MainForm).新規登録処理(バーコードデータLabel.Text)
        Me.Dispose()

    End Sub
    Public Sub バーコードデータ表示(ByVal barcodeData As String)
        バーコードデータLabel.Text = barcodeData

    End Sub

    Private Sub キャンセルBtn_Click(sender As Object, e As EventArgs) Handles キャンセルBtn.Click
        登録のキャンセル()
        Me.Close()
        CType(Me.Owner, MainForm).新規登録処理(バーコードデータLabel.Text)
        Me.Dispose()
    End Sub


    Private Sub 新規登録の確定()
        CType(Me.Owner, MainForm).confirmed = True

    End Sub

    Private Sub 登録のキャンセル()
        CType(Me.Owner, MainForm).confirmed = False
    End Sub

End Class