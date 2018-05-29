Public Class 本人確認ダイアログ

    Private thisPersonInfo As Hashtable
    Private itemlimit As Integer = 7

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        thisPersonInfo = New Hashtable

    End Sub


    'Private Structure personInfo
    '    Dim 情報ラベル1 As String
    '    Dim 情報ラベル2 As String
    '    Dim 情報ラベル3 As String
    '    Dim 情報ラベル4 As String
    '    Dim 情報ラベル5 As String
    '    Dim 情報ラベル6 As String
    '    Dim 情報ラベル7 As String
    '    Dim 情報データ1 As String
    '    Dim 情報データ2 As String
    '    Dim 情報データ3 As String
    '    Dim 情報データ4 As String
    '    Dim 情報データ5 As String
    '    Dim 情報データ6 As String
    '    Dim 情報データ7 As String

    'End Structure

    'Dim thisPersonInfo As personInfo
    Private isRegistered As Boolean = False

    Public Sub 登録情報を設定(ByVal RegistrationStatus As Boolean)

        Me.isRegistered = RegistrationStatus

    End Sub


    Private Sub 本人情報のクリア()
        If thisPersonInfo IsNot Nothing Then
            thisPersonInfo.Clear()
        End If
    End Sub

    Public Sub 本人情報を設定(ByVal rowdata As Hashtable, ByVal gridColData As ArrayList, ByVal barcodeData As String, ByVal bloodPattern As String, ByVal optionItems As ArrayList)

        本人情報のクリア()

        Dim idx As Integer = 0
        Dim registrationStatus As Boolean = False

        For Each colitem In gridColData
            thisPersonInfo(colitem) = rowdata(colitem)

            If colitem = My.Settings.入力カラム名 And IsNumeric(rowdata(colitem)) Then
                registrationStatus = True
            End If

            idx += 1

            If idx >= itemlimit Then
                Exit For
            End If
        Next
        本人情報の表示(barcodeData, bloodPattern, optionItems)

        登録情報を設定(registrationStatus)

    End Sub

    Private Sub 本人情報の表示(ByVal barcodeData As String, ByVal bloodPattern As String, ByVal optionItems As ArrayList)

        Dim idx As Integer = 1

        ' エントリ（キーと値）の列挙
        For Each de As DictionaryEntry In thisPersonInfo
            Dim ctrl = Me.Controls.Find("情報ラベル" + CStr(idx), True)
            If ctrl IsNot Nothing AndAlso ctrl.Length > 0 Then
                ctrl(0).Text = de.Key
                'row.Item(String.Format("col{0:00}", i)) = ctrl(0).Text
            End If

            ctrl = Me.Controls.Find("情報データ" + CStr(idx), True)
            If ctrl IsNot Nothing AndAlso ctrl.Length > 0 Then
                ctrl(0).Text = de.Value
                'row.Item(String.Format("col{0:00}", i)) = ctrl(0).Text
            End If

            idx += 1
        Next

        バーコードLabel.Text = barcodeData
        If bloodPattern <> "" Then
            採血パターンLabel.Text = bloodPattern
        End If

        検査オプション項目表示(optionItems)
    End Sub

    Private Sub 検査オプション項目表示(ByVal optionItems As ArrayList)

        Dim strOptions As String = ""
        For Each item As String In optionItems

            strOptions += CStr("☑" + item + "　")

        Next

        その他検査Label.Text = strOptions


    End Sub

    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:オブジェクトを複数回破棄しない")>
    Private Sub 確定Btn_Click(sender As Object, e As EventArgs) Handles 確定Btn.Click

        If isRegistered Then
            Dim InputColName As String = My.Settings.入力カラム名
            If MessageBox.Show(String.Format("既に{0}を登録済ですが、新しい{0}に上書きしますか？", InputColName), "通番上書き確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                登録の確定()
            Else
                登録のキャンセル()
            End If

        Else

            登録の確定()
        End If



        Me.Close()
        CType(Me.Owner, MainForm).本人確認後処理()
        Me.Dispose()

    End Sub

    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:オブジェクトを複数回破棄しない")>
    Private Sub キャンセルBtn_Click(sender As Object, e As EventArgs) Handles キャンセルBtn.Click
        登録のキャンセル()
        Me.Close()
        CType(Me.Owner, MainForm).本人確認後処理()
        Me.Dispose()
    End Sub

    Private Sub 登録の確定()
        CType(Me.Owner, MainForm).confirmed = True

    End Sub

    Private Sub 登録のキャンセル()
        CType(Me.Owner, MainForm).confirmed = False
    End Sub

End Class