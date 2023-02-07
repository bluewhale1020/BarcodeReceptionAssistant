Public Class 本人確認ダイアログ

    Private thisPersonInfo As Hashtable
    Private itemlimit As Integer = 9

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        thisPersonInfo = New Hashtable

    End Sub


    Private isRegistered As Boolean = False

    Public Sub 登録情報を設定(ByVal RegistrationStatus As Boolean)

        Me.isRegistered = RegistrationStatus

    End Sub


    Private Sub 本人情報のクリア()
        If thisPersonInfo IsNot Nothing Then
            thisPersonInfo.Clear()
        End If
    End Sub

    Public Sub 本人情報を設定(ByVal rowdata As Hashtable, ByVal gridColData As ArrayList, ByVal barcodeData As String, ByVal bloodPattern As String, ByVal optionItems As ArrayList, ByVal urinaryData As ArrayList, ByVal urinaryMetaboliteData As ArrayList, ByVal newSerialNumber As Integer, ByVal lateSamples As Hashtable, ByVal denriData As Boolean, ByVal takeXrays As Hashtable)

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
        本人情報の表示(barcodeData, bloodPattern, optionItems, urinaryData, urinaryMetaboliteData, newSerialNumber)

        登録情報を設定(registrationStatus)

        後日便尿設定(lateSamples)
        XP設定(takeXrays)
        電離設定(denriData)

    End Sub

    Private Sub 本人情報の表示(ByVal barcodeData As String, ByVal bloodPattern As String, ByVal optionItems As ArrayList, ByVal urinaryData As ArrayList, ByVal urinaryMetaboliteData As ArrayList, ByVal newSerialNumber As Integer)

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

        通番入力ラベル.Text = Str(newSerialNumber)

        '尿検査オプションの表示
        尿検査表示(urinaryData)
        '尿代謝オプションの表示
        尿代謝表示(urinaryMetaboliteData)

        検査オプション項目表示(optionItems)
    End Sub

    Private Sub 後日便尿設定(lateSamples)
        後日便ボタン.Checked = lateSamples("便")

        後日尿ボタン.Checked = lateSamples("尿検査")
    End Sub

    Private Sub 電離設定(denriData)
        電離ボタン.Checked = denriData
    End Sub

    Private Sub XP設定(takeXrays As Hashtable)
        If String.IsNullOrEmpty(takeXrays("胸部X線")) Then
            胸部XPボタン.Enabled = False
        Else
            胸部XPボタン.Enabled = True
            胸部XPボタン.Checked = takeXrays("胸部X線")
        End If
        If String.IsNullOrEmpty(takeXrays("胃部")) Then
            胃部XPボタン.Enabled = False
        Else
            胃部XPボタン.Enabled = True
            胃部XPボタン.Checked = takeXrays("胃部")
        End If
    End Sub

    Private Sub 尿検査表示(ByVal urinaryData As ArrayList)

        If urinaryData(0) <> "" Then

            尿検査Label.Text = "☑" + urinaryData(0)

        End If
        If urinaryData.Count > 1 AndAlso urinaryData(1) <> "" Then
            urinaryData.RemoveAt(0)
            尿検査2Label.Text = String.Join("・", TryCast(urinaryData.ToArray(GetType(String)), String()))

        End If

    End Sub

    Private Sub 尿代謝表示(ByVal urinaryMetaboliteData As ArrayList)

        If urinaryMetaboliteData.Count > 0 Then

            尿代謝Label.Text = "☑尿代謝"

            尿代謝詳細Label.Text = String.Join(" ・ ", urinaryMetaboliteData.ToArray)

        Else
            尿代謝Label.Text = ""

            尿代謝詳細Label.Text = ""

        End If


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

    Private Sub 後日便ボタン_CheckedChanged(sender As Object, e As EventArgs) Handles 後日便ボタン.CheckedChanged
        If Not CType(Me.Owner, MainForm) Is Nothing Then
            CType(Me.Owner, MainForm).lateFecalSample = 後日便ボタン.Checked
        End If

    End Sub

    Private Sub 後日尿ボタン_CheckedChanged(sender As Object, e As EventArgs) Handles 後日尿ボタン.CheckedChanged
        If Not CType(Me.Owner, MainForm) Is Nothing Then
            CType(Me.Owner, MainForm).lateUrinarySample = 後日尿ボタン.Checked
        End If
    End Sub

    Private Sub 電離ボタン_CheckedChanged(sender As Object, e As EventArgs) Handles 電離ボタン.CheckedChanged
        If Not CType(Me.Owner, MainForm) Is Nothing Then
            CType(Me.Owner, MainForm).denriData = 電離ボタン.Checked
        End If
    End Sub

    Private Sub 胸部XPボタン_CheckedChanged(sender As Object, e As EventArgs) Handles 胸部XPボタン.CheckedChanged
        If Not CType(Me.Owner, MainForm) Is Nothing AndAlso 胸部XPボタン.Enabled = True Then
            CType(Me.Owner, MainForm).takeBreastXray = 胸部XPボタン.Checked
        End If
    End Sub

    Private Sub 胃部XPボタン_CheckedChanged(sender As Object, e As EventArgs) Handles 胃部XPボタン.CheckedChanged
        If Not CType(Me.Owner, MainForm) Is Nothing AndAlso 胃部XPボタン.Enabled = True Then
            CType(Me.Owner, MainForm).takeStomachXray = 胃部XPボタン.Checked
        End If
    End Sub
End Class