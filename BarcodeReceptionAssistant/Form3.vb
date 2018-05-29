Public Class 本人確認失敗ダイアログ
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:オブジェクトを複数回破棄しない")>
    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        Me.Close()
        Me.Dispose()

    End Sub
    Public Sub バーコードデータ表示(ByVal barcodeData As String)
        バーコードデータLabel.Text = barcodeData

    End Sub
End Class