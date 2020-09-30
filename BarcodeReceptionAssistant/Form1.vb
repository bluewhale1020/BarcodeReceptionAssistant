Imports System.Collections.Specialized
Imports System.Text.RegularExpressions

Public Class MainForm

    Private currentSerialNumber As Integer = My.Settings.開始番号
    Private checkupDate As DateTime = Now.Date
    Private checkupTime As DateTime = Now
    Private sumOfPatients As Integer = 0
    Private gridColData As ArrayList = New ArrayList
    Private defaultBarcodeNumber As String = My.Settings.白紙バーコードNo

    Private searchMode As String = My.Settings.検索モード
    Public barcodeInputReady As Boolean = False
    Private gridDataTable As DataTable
    Private outputPath As String = My.Settings.出力先パス 'IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "outputdata.xlsx")
    Public confirmed As Boolean

    '通番印字　書式 


    Private Const SNumberDigit = 5
    Dim rx = New Regex("^[0-9]{5}$", RegexOptions.Compiled)
    Private oldSNumber As String = ""

    Private optionColNames As Array = {"腹囲", "視力", "聴力", "便", "胃部", "眼底", "心電図", "胸部X線", "血圧", "尿沈渣", "肺活量", "握力", "ホルムアルデヒド", "じん肺", "鉛", "電離", "インジウム"}
    Private bloodColName As String = "血液検査"
    Private urinaryColNames As Array = {"尿検査", "尿検査2"}
    Private urinaryMetaboliteColNames As Array = {"ﾒﾁﾙ馬尿酸", "Nメチルホルムアミド", "ﾏﾝﾃﾞﾙ酸", "ﾄﾘｸﾛﾙ酢酸", "馬尿酸", "2．5ﾍｷｻﾝｼﾞｵﾝ", "スチレン代謝物"}
    Private dispPersonInfo As StringCollection = My.Settings.ダイアローグ表示カラム

    'クラスオブジェクト
    Public excelCn As ExcelController
    Public logMngr As LogManager
    Public SNMnger As SerialNumberManager
    Public f2 As 本人確認ダイアログ
    Public f3 As 本人確認失敗ダイアログ

    'フォーム起動時処理

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        フォームの初期化()

        '関連クラスのインスタンス化
        excelCn = New ExcelController
        logMngr = New LogManager
        SNMnger = New SerialNumberManager


    End Sub

    Private Sub フォームの初期化()
        設定データの読込()
    End Sub

    Private Sub 設定データの読込()


        通番開始番号Box.Text = My.Settings.開始番号
        通番Box.Value = My.Settings.開始番号

        createOutputPath()

        出力先フォルダパスBox.Text = My.Settings.出力先パス
        出力ファイル名Box.Text = My.Settings.出力ファイル名
        OutputFilePathBox.Text = My.Settings.出力先パス
        バーコードカラム名Box.Text = My.Settings.バーコードカラム名
        入力カラム名Box.Text = My.Settings.入力カラム名
        検索モードBox.Text = My.Settings.検索モード
        バーコード受信方法Box.Text = My.Settings.受信方法
        白紙バーコードNoBox.Text = My.Settings.白紙バーコードNo

    End Sub

    Private Sub createOutputPath() '出力先のパスをデスクトップにする
        If My.Settings.出力先パス = "" Or IO.Directory.Exists(My.Settings.出力先パス) = False Then
            Dim defaultPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            outputPath = defaultPath
            My.Settings.出力先パス = defaultPath
        End If


    End Sub

    Private Sub 設定を保存Btn_Click(sender As Object, e As EventArgs) Handles 設定を保存Btn.Click
        設定データの保存()
    End Sub

    Public Sub 設定データの保存()

        My.Settings.開始番号 = 通番開始番号Box.Text
        My.Settings.出力先パス = 出力先フォルダパスBox.Text
        OutputFilePathBox.Text = 出力先フォルダパスBox.Text
        My.Settings.出力ファイル名 = 出力ファイル名Box.Text
        My.Settings.バーコードカラム名 = バーコードカラム名Box.Text
        My.Settings.入力カラム名 = 入力カラム名Box.Text
        My.Settings.検索モード = 検索モードBox.Text
        My.Settings.受信方法 = バーコード受信方法Box.Text
        My.Settings.白紙バーコードNo = 白紙バーコードNoBox.Text
        defaultBarcodeNumber = 白紙バーコードNoBox.Text


        MessageBox.Show("設定データを保存しました。", "保存完了", MessageBoxButtons.OK)

    End Sub



    'エクセル関連処理


    Private Sub dragdropMessage_DragDrop(sender As Object, e As DragEventArgs) Handles dragdropMessage.DragDrop

        エクセルファイルをインポート(e)
    End Sub

    Private Sub excelDataGridView_DragDrop(sender As Object, e As DragEventArgs) Handles excelDataGridView.DragDrop

        エクセルファイルをインポート(e)


    End Sub

    Public Sub エクセルファイルをインポート(e As DragEventArgs)

        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        If files.Count > 1 Then
            MessageBox.Show("エクセルファイルは一つだけドロップして下さい。", "複数ファイルエラー", MessageBoxButtons.OK)
            Exit Sub
        End If
        If IO.Path.GetExtension(files(0)) <> ".xlsx" Then
            MessageBox.Show("取り込めるのは、エクセルファイル(xlsx)のみです。", "複数ファイルエラー", MessageBoxButtons.OK)
            Exit Sub
        End If


        gridDataTable = excelCn.ファイルのロード(files(0))
        If gridDataTable Is Nothing Then

        ElseIf gridDataTable.Rows.Count > 0 Then
            Me.excelDataGridView.DataSource = gridDataTable
            列データをgridColDataに登録(gridDataTable)
            TabControl1.SelectTab("バーコード受付Page")
            バーコードデータBox.Select()
            バーコードデータBox_Enter(バーコードデータBox, New EventArgs())
            dragdropMessage.Visible = False


            Dim currentNumber As Integer = SNMnger.通番情報リセット(gridDataTable)

            通番Box.Value = currentNumber
            受付人数更新()
        Else
            MessageBox.Show("ファイルにデータがありません。", "空データエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub

    Private Sub 列データをgridColDataに登録(ByRef dtable As DataTable)
        If gridColData IsNot Nothing Then
            gridColData.Clear()
        End If


        For Each column As DataColumn In dtable.Columns
            gridColData.Add(column.ColumnName)
        Next

        カラム名選択を設定(gridColData)
    End Sub

    Private Sub カラム名選択を設定(ByVal gridColData As ArrayList)

        検索カラム選択Box.DataSource = gridColData
        Dim cloneColData As ArrayList
        cloneColData = New ArrayList(gridColData)
        フィルタカラム選択Box.DataSource = cloneColData

    End Sub

    Private Sub エクセルファイル出力Btn_Click(sender As Object, e As EventArgs) Handles エクセルファイル出力Btn.Click
        エクセルファイルを出力()
    End Sub


    Public Sub エクセルファイルを出力()

        Dim userOutputPath As String = OutputFilePathBox.Text

        If userOutputPath = "" Then
            userOutputPath = Me.outputPath
        End If

        If Me.CheckGridViewIsFilled = False Then
            Exit Sub
        End If


        If excelCn.ファイルの保存(gridDataTable, userOutputPath) = True Then
            MessageBox.Show("表データをエクセルに保存しました。", "保存完了", MessageBoxButtons.OK)
        Else

            MessageBox.Show("表データをエクセルに保存できませんでした。", "保存エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub ファイル選択Btn_Click(sender As Object, e As EventArgs) Handles ファイル選択Btn.Click

        'ダイアログを表示する
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            OutputFilePathBox.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub 出力先フォルダパス選択Btn_Click(sender As Object, e As EventArgs) Handles 出力先フォルダパス選択Btn.Click
        'ダイアログを表示する
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            出力先フォルダパスBox.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    'excelDataGridView操作
    Private ReadOnly Property CheckGridViewIsFilled
        Get

            If excelDataGridView.DataSource Is Nothing Then


                CheckGridViewIsFilled = False
            Else
                CheckGridViewIsFilled = True
            End If
        End Get
    End Property

    Private Function editGridCell(ByRef dgrid As DataGridView, ByVal colName As String, ByVal rowIdx As Int32, ByVal cellVal As String)
        Dim result As Boolean = True
        Try
            dgrid.Rows(rowIdx).Cells(colName).Value = cellVal
        Catch ex As Exception
            result = False
        End Try

        Return result

    End Function

    Private Function editTableRow(ByRef dtable As DataTable, ByVal colName As String, ByVal rowIdx As Int32, ByVal cellVal As String)

        Dim result As Boolean = True
        Try
            'テーブルの該当列のセルを編集

            dtable.Rows(rowIdx).Item(colName) = cellVal


            If colName = My.Settings.入力カラム名 Then

                'SNMnger.通番セルの変更(gridDataTable)
                '受付人数更新()

                'ValidateCurrentNumber()

                If IsNumeric(cellVal) Then
                    時刻印字(rowIdx, True)
                End If


            End If



        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function

    Private Sub excelDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles excelDataGridView.CellBeginEdit
        If IsDBNull(excelDataGridView.Item(e.ColumnIndex, e.RowIndex).Value) = False Then
            oldSNumber = excelDataGridView.Item(e.ColumnIndex, e.RowIndex).Value
        End If
        displayReadBarcodePrompt()

    End Sub

    Private Sub excelDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles excelDataGridView.CellValueChanged

        Dim colName As String = excelDataGridView.Columns(e.ColumnIndex).Name

        If colName = My.Settings.入力カラム名 Then
            'Dim cellVal As String = excelDataGridView.Item(e.ColumnIndex, e.RowIndex).Value


            SNMnger.通番セルの変更(gridDataTable)
            受付人数更新()

            ValidateCurrentNumber()

            If IsNumeric(excelDataGridView.Item(e.ColumnIndex, e.RowIndex).Value) Then
                時刻印字(e.RowIndex)
            End If


        End If


    End Sub
    Private Sub excelDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles excelDataGridView.CellValidating
        Dim cellVal As String = excelDataGridView.CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString()

        If cellVal <> "" And cellVal <> oldSNumber Then
            Dim colName As String = excelDataGridView.Columns(e.ColumnIndex).Name

            If colName = My.Settings.入力カラム名 Then

                If 通番重複データのチェック(cellVal) Then

                    'excelDataGridView.Item(e.ColumnIndex, e.RowIndex).Value = oldSNumber
                    If excelDataGridView.EditingControl IsNot Nothing Then
                        excelDataGridView.EditingControl.Text = oldSNumber
                        'MessageBox.Show("通番が重複しています。変更して下さい。", "通番重複エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        displayDuplicateSNumberAlert()
                        SendKeys.Send("{UP}")
                    End If



                    'excelDataGridView.EditingControl.Text = ""


                ElseIf 整理番号の書式をチェック(cellVal) = False Then
                    If excelDataGridView.EditingControl IsNot Nothing Then

                        If IsNumeric(cellVal) Then
                            excelDataGridView.EditingControl.Text = 右を0で埋める(Integer.Parse(cellVal))
                        Else

                            excelDataGridView.EditingControl.Text = oldSNumber
                            displayInappropriateSNumberAlert()
                            SendKeys.Send("{UP}")
                        End If

                    End If

                End If



            End If
        End If
    End Sub


    'Private Sub excelDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles excelDataGridView.CellFormatting
    '    Dim colName As String = excelDataGridView.Columns(e.ColumnIndex).Name

    '    If Not e.Value Is Nothing Then
    '        If e.Value.ToString() <> "" And colName = My.Settings.入力カラム名 Then
    '            If 整理番号の書式をチェック(e.Value.ToString()) = False Then

    '                e.Value = 右を0で埋める(Integer.Parse(e.Value.ToString()))


    '            End If

    '        End If
    '        e.FormattingApplied = True
    '    End If



    'End Sub

    'Private Sub excelDataGridView_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles excelDataGridView.CellParsing

    '    Dim colName As String = excelDataGridView.Columns(e.ColumnIndex).Name

    '    If e.Value.ToString() <> "" And colName = My.Settings.入力カラム名 Then
    '        'If 整理番号の書式をチェック(e.Value.ToString()) = False Then
    '        'If excelDataGridView.EditingControl IsNot Nothing Then
    '        e.Value = Integer.Parse(e.Value.ToString())
    '        'End If

    '        'End If

    '    End If

    '    e.ParsingApplied = True
    'End Sub


    Private Function 通番重複データのチェック(ByVal cellVal As String)

        If IsNumeric(cellVal) Then
            Dim result As Integer = SNMnger.通番が設定可能か確認(CInt(cellVal), gridDataTable)
            '重複数字があるか？
            If CInt(cellVal) = result Then
                'ない
                Return False

            Else
                Return True
            End If
        End If

        Return False



    End Function

    Private Function 整理番号の書式をチェック(ByVal cellVal As String)


        Return rx.IsMatch(cellVal)


    End Function


    '本人確認処理
    Private Sub バーコードデータBox_KeyDown(sender As Object, e As KeyEventArgs) Handles バーコードデータBox.KeyDown
        '--- CR(0x0d)を検知したら、読取されたとみなす
        If e.KeyCode = Keys.Enter Then
            Dim barcodeTest As String = バーコードデータBox.Text
            '--- 入力値がある場合だけ処理を継続。
            If barcodeTest <> "" Then
                フィルタのクリア()
                'バーコードデータの検索
                If barcodeTest <> defaultBarcodeNumber AndAlso 検索の実行(barcodeTest, "全文一致", My.Settings.バーコードカラム名) Then
                    '本人確認ダイアログ
                    f2 = New 本人確認ダイアログ()
                    Dim filteredColData As ArrayList = filterColDataForDisplay()
                    f2.本人情報を設定(DirectCast(getGridViewRow(), Hashtable), filteredColData, barcodeTest, getBloodPattern, getOptionItems, getUrinaryData, getUrinaryMetaboliteData, SNMnger.現在の通番を取得())
                    f2.ShowDialog(Me)


                Else
                    '本人確認失敗ダイアログ
                    f3 = New 本人確認失敗ダイアログ()
                    f3.バーコードデータ表示(barcodeTest)
                    f3.ShowDialog(Me)


                End If



            End If
        End If
    End Sub

    Private Function filterColDataForDisplay()

        Dim filterColData As New ArrayList
        Dim dispPersonArray As New ArrayList

        For Each item As String In dispPersonInfo
            dispPersonArray.Add(item)
        Next

        For Each colName In gridColData

            If dispPersonArray.Contains(colName) Then

                filterColData.Add(colName)

            End If


        Next

        Return filterColData

    End Function



    Private Function getOptionItems()
        Dim optionItems As ArrayList = New ArrayList
        Dim idx As Integer = 0
        For Each item In excelDataGridView.SelectedRows.Item(0).Cells
            Dim colName As String = excelDataGridView.Columns(idx).Name

            Dim strVal As String = Convert.ToString(item.Value)

            If strVal <> "" AndAlso Array.IndexOf(optionColNames, colName) <> -1 Then

                '聴力の場合は、種類を加える
                If colName = "聴力" Then
                    optionItems.Add(colName + strVal)
                Else
                    optionItems.Add(colName)
                End If

            End If


                idx += 1

        Next

        Return optionItems
    End Function
    Private Function getBloodPattern()

        Dim idx As Integer = 0
        For Each item In excelDataGridView.SelectedRows.Item(0).Cells
            Dim colName As String = excelDataGridView.Columns(idx).Name

            Dim strVal As String = Convert.ToString(item.Value)

            If colName = bloodColName Then
                Return strVal
            End If


            idx += 1

        Next

        Return ""
    End Function

    Private Function getUrinaryData()

        Dim urinaryData As ArrayList = New ArrayList
        Dim idx As Integer = 0
        For Each item In excelDataGridView.SelectedRows.Item(0).Cells
            Dim colName As String = excelDataGridView.Columns(idx).Name

            Dim strVal As String = Convert.ToString(item.Value)

            If Array.IndexOf(urinaryColNames, colName) <> -1 Then
                If colName = "尿検査" Then
                    If strVal <> "" Then
                        urinaryData.Add(colName)
                    Else
                        urinaryData.Add("")
                    End If


                ElseIf colName = "尿検査2" Then
                    urinaryData.Add(strVal)

                End If

            End If


            idx += 1

        Next

        Return urinaryData

    End Function

    Private Function getUrinaryMetaboliteData()

        Dim urinaryMetaboliteData As ArrayList = New ArrayList
        Dim idx As Integer = 0


        For Each item In excelDataGridView.SelectedRows.Item(0).Cells
            Dim colName As String = excelDataGridView.Columns(idx).Name

            Dim strVal As String = Convert.ToString(item.Value)

            If strVal <> "" AndAlso Array.IndexOf(urinaryMetaboliteColNames, colName) <> -1 Then

                urinaryMetaboliteData.Add(colName)


            End If


            idx += 1

        Next

        Return urinaryMetaboliteData

    End Function

    Private Function getGridViewRow()
        Dim drow As Hashtable = New Hashtable
        Dim idx As Integer = 0
        For Each item In excelDataGridView.SelectedRows.Item(0).Cells
            Dim colName As String = excelDataGridView.Columns(idx).Name
            drow(colName) = Convert.ToString(item.Value)

            idx += 1
        Next

        Return drow
    End Function

    Public Sub 本人確認後処理()
        If Me.confirmed Then '確定した
            'datagridviewの選択レコードの受付日時と通番にそれぞれ現在日時と現在の通番を入力する
            If 通番印字() Then
                'Dim snTable As OrderedDictionary = SNMnger.通番情報の取得 'SNMnger.通番を1加算

                '通番の入力(snTable("現在の通番"))
                受付人数更新()

            Else
                MessageBox.Show("グリッドデータに通番を登録できませんでした。", "通番登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else 'キャンセルした
            'datagridviewのレコード選択をクリアする
            excelDataGridView.ClearSelection()
        End If
        バーコードデータBox.Text = ""
        'バーコードデータBox.Select()
        Call Me.MainForm_Activated(Nothing, Nothing)   '表示更新の為、強制的にMainForm_Activatedをコール

    End Sub

    Public Sub 新規登録処理(ByVal barcodeTest As String)
        If Me.confirmed Then '確定した

            Dim drow As DataRow = gridDataTable.NewRow
            gridDataTable.Rows.Add(drow)
            gridDataTable.AcceptChanges()

            '新規列を選択
            Dim selectedRowId As Integer = gridDataTable.Rows.Count - 1
            'excelDataGridView.Rows(selectedRowId).Selected = True


            'gridDataTable.AcceptChanges()

            'excelDataGridView.Rows(selectedRowId).Selected = True
            'datagridviewの選択レコードの受付日時と通番にそれぞれ現在日時と現在の通番を入力する
            If 通番印字(True, selectedRowId) Then
                'Dim snTable As OrderedDictionary = SNMnger.通番情報の取得 'SNMnger.通番を1加算

                '在籍番号を入力
                在籍番号印字(barcodeTest, True, selectedRowId)

                gridDataTable.AcceptChanges()

                '通番加算





                SNMnger.通番セルの変更(gridDataTable)
                '通番の入力(snTable("現在の通番"))
                受付人数更新()

                ValidateCurrentNumber()


            Else
                MessageBox.Show("グリッドデータに通番を登録できませんでした。", "通番登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Call Me.MainForm_Activated(Nothing, Nothing)   '表示更新の為、強制的にMainForm_Activatedをコール

            '新規行選択
            検索の実行(barcodeTest, "全文一致", My.Settings.バーコードカラム名)


        Else 'キャンセルした
            'datagridviewのレコード選択をクリアする
            excelDataGridView.ClearSelection()
        End If
        バーコードデータBox.Text = ""



    End Sub

    Private Function 在籍番号印字(ByVal barcodeTest As String, ByVal Optional useDTable As Boolean = False, ByVal Optional tRowIdx As Integer = vbEmpty)
        'Dim strTime As String = 受付時刻を取得()
        'Dim barcodeTest As String = バーコードデータBox.Text



        If useDTable Then
            Dim rowIdx As Int32 = tRowIdx
            If editTableRow(gridDataTable, "在籍番号", rowIdx, barcodeTest) Then
                'editGridCell(excelDataGridView, "受付時間", rowIdx, strTime) And
                Return True
            Else
                Return False
            End If
        Else
            Dim rowIdx As Int32 = excelDataGridView.SelectedRows.Item(0).Index 'excelDataGridView.CurrentRow.Index　　' 
            If editGridCell(excelDataGridView, "在籍番号", rowIdx, barcodeTest) Then
                'editGridCell(excelDataGridView, "受付時間", rowIdx, strTime) And
                Return True
            Else
                Return False
            End If
        End If


    End Function

    Private Function 通番印字(ByVal Optional useDTable As Boolean = False, ByVal Optional tRowIdx As Integer = vbEmpty)
        'Dim strTime As String = 受付時刻を取得()
        Dim currentNumber As Integer = SNMnger.現在の通番を取得()


        If useDTable Then

            Dim rowIdx As Int32 = tRowIdx
            If editTableRow(gridDataTable, My.Settings.入力カラム名, rowIdx, 右を0で埋める(currentNumber)) Then '右を0で埋める(currentNumber)
                'editGridCell(excelDataGridView, "受付時間", rowIdx, strTime) And
                Return True
            Else
                Return False
        End If
        Else
        Dim rowIdx As Int32 = excelDataGridView.SelectedRows.Item(0).Index
            If editGridCell(excelDataGridView, My.Settings.入力カラム名, rowIdx, 右を0で埋める(currentNumber)) Then '右を0で埋める(currentNumber)
                'editGridCell(excelDataGridView, "受付時間", rowIdx, strTime) And
                Return True
            Else
                Return False
        End If
        End If


    End Function

    Private Function 右を0で埋める(ByVal currentNumber As Integer)

        Dim formatStr As String = ""

        For idx = 0 To SNumberDigit - 1
            formatStr += "0"
        Next


        Return currentNumber.ToString(formatStr)


    End Function


    '受診者の検索・リストのフィルタ
    Private Sub 検索Btn_Click(sender As Object, e As EventArgs) Handles 検索Btn.Click
        データの検索()
    End Sub
    Public Sub データの検索()
        If Me.CheckGridViewIsFilled = False Then
            Exit Sub
        End If

        フィルタのクリア()

        Dim searchKey As String = 検索キーBox.Text
        Dim colName As String = 検索カラム選択Box.SelectedValue
        Dim mode As String = 検索モードBox.Text

        If 検索の実行(searchKey, mode, colName) = False Then
            MessageBox.Show("検索結果がありません。", "検索結果：０", MessageBoxButtons.OK)
        End If

    End Sub

    Private Function 検索の実行(ByVal searchKey As String, ByVal mode As String, ByVal colname As String)
        If SearchGridViewRow(searchKey, excelDataGridView, mode, colname) Then
            Return True
        Else
            Return False
        End If



    End Function


    Private Function SearchGridViewRow(ByVal searchKey As String, ByRef dgrid As DataGridView, ByVal mode As String, ByVal colName As String)
        dgrid.ClearSelection()
        If searchKey = "" Then

            Exit Function
        End If

        Dim hasData As Boolean = False
        Dim resultIndex As Int32 = 0
        For i As Integer = 0 To dgrid.RowCount - 1
            Dim inputString As String = Convert.ToString(dgrid.Rows(i).Cells(colName).Value)
            Select Case mode
                Case "全文一致"
                    If searchKey = inputString Then
                        hasData = True
                        resultIndex = i
                        Exit For
                    End If
                Case "部分一致"
                    If inputString.Contains(searchKey) Then
                        hasData = True
                        resultIndex = i
                        Exit For
                    End If

            End Select

        Next


        If hasData Then

            dgrid.Rows(resultIndex).Selected = True
            dgrid.FirstDisplayedScrollingRowIndex = resultIndex
            dgrid.PerformLayout()
            Return True

        Else
            Return False
        End If



    End Function


    Private Sub 絞込Btn_Click(sender As Object, e As EventArgs) Handles 絞込Btn.Click

        フィルタを設定()
    End Sub

    Public Sub フィルタを設定()
        If Me.CheckGridViewIsFilled = False Then
            Exit Sub
        End If

        検索のクリア()

        Dim filterKey As String = フィルタキーBox.Text
        Dim colName As String = フィルタカラム選択Box.SelectedValue
        Dim oper As String = フィルタ条件選択Box.Text

        フィルタの実行(oper, colName, filterKey)


    End Sub

    Private Sub フィルタの実行(ByVal oper As String, ByVal colname As String, ByVal Optional filterKey As String = "")
        Dim strFilter As String
        If filterKey = "" Then
            strFilter = ""
        Else
            Select Case oper
                Case "と等しい"
                    strFilter = colname + " = '" + filterKey + "'"
                Case "を含む"
                    strFilter = colname + " LIKE " + "'%" + filterKey + "%'"
                Case "より大きい"
                    If colname = My.Settings.入力カラム名 Then
                        If 整理番号の書式をチェック(filterKey) = False Then
                            MessageBox.Show(Me, My.Settings.入力カラム名 + "は、既定の書式[5桁で左０埋め]で入力して下さい。", "入力書式エラー", vbOKOnly)
                            Exit Sub
                        Else
                            strFilter = colname + " > '" + filterKey + "'"

                        End If

                    ElseIf IsNumeric(filterKey) Then
                        strFilter = colname + " > '" + filterKey + "'"

                    Else
                        MessageBox.Show(Me, "大小比較は、数値を入力して下さい。", "非数値エラー", vbOKOnly)
                        Exit Sub
                    End If




                Case "より小さい"
                    If colname = My.Settings.入力カラム名 Then
                        If 整理番号の書式をチェック(filterKey) = False Then
                            MessageBox.Show(Me, My.Settings.入力カラム名 + "は、既定の書式[5桁で左０埋め]で入力して下さい。", "入力書式エラー", vbOKOnly)
                            Exit Sub
                        Else
                            strFilter = colname + " < '" + filterKey + "'"

                        End If

                    ElseIf IsNumeric(filterKey) Then
                        strFilter = colname + " < '" + filterKey + "'"

                    Else
                        MessageBox.Show(Me, "大小比較は、数値を入力して下さい。", "非数値エラー", vbOKOnly)
                        Exit Sub
                    End If



                Case Else
                    strFilter = ""
            End Select
        End If
        'strFilter = "CONVERT(ISNULL(整理番号,0),'System.Int32') > 10"
        gridDataTable.DefaultView.RowFilter = strFilter



    End Sub

    Private Sub フィルタのクリア()

        gridDataTable.DefaultView.RowFilter = ""
        フィルタカラム選択Box.Text = ""
        フィルタキーBox.Text = ""
        フィルタ条件選択Box.Text = ""
    End Sub

    Private Sub 検索のクリア()
        excelDataGridView.ClearSelection()

        検索カラム選択Box.Text = ""
        検索キーBox.Text = ""

    End Sub

    'ログの出力
    Private Sub ログの出力()
        If Me.CheckGridViewIsFilled = False Then
            Exit Sub
        End If
        Dim ht As OrderedDictionary = New OrderedDictionary
        Dim snTable As OrderedDictionary = SNMnger.通番情報の取得(gridDataTable)
        '        id    Z(10)
        '受付日    yyyy / m / d
        ht("受付日") = checkupDate.ToShortDateString
        '健診簿名    N(45)
        ht("健診簿名") = excelCn.インプットファイル名の取得

        '開始番号    Z(6)
        ht("開始番号") = snTable("開始番号")
        '終了番号    Z(6)
        ht("終了番号") = snTable("終了番号")
        '欠番    X(45)
        If snTable("欠番") Is Nothing Then
            ht("欠番") = ""
        Else
            ht("欠番") = String.Join("、", DirectCast(snTable("欠番"), ArrayList).ToArray)
        End If
        '受診者数    Z(6)
        ht("受付人数") = snTable("受付人数")
        '備考    N(255)

        logMngr.ログデータを保存(ht)




    End Sub

    '通番管理
    Public Sub 通番の入力(ByVal serialNumber As Integer)
        Me.通番Box.Value = serialNumber

    End Sub

    Private Sub 通番リセットBtn_Click(sender As Object, e As EventArgs) Handles 通番リセットBtn.Click
        Dim currentNumber As Integer = SNMnger.通番情報リセット(gridDataTable)

        通番Box.Value = currentNumber

    End Sub


    Private Sub 通番Box_ValueChanged(sender As Object, e As EventArgs) Handles 通番Box.ValueChanged
        If CheckGridViewIsFilled = False Then
            Exit Sub
        End If

        ValidateCurrentNumber()
    End Sub


    Private Sub ValidateCurrentNumber()

        Dim newCurrentNumber As Integer = SNMnger.現在の通番を更新(通番Box.Value, gridDataTable)

        通番Box.Value = newCurrentNumber



    End Sub

    '日付処理

    Private Function 時刻印字(ByVal rowIdx As Int32, ByVal Optional useDTable As Boolean = False)
        Dim strDateTime As String = 受付時刻を取得()

        'Dim rowIdx As Int32 = excelDataGridView.SelectedRows.Item(0).Index
        If useDTable Then
            If editTableRow(gridDataTable, "受付時間", rowIdx, strDateTime) Then
                Return True
            Else
                Return False
            End If
        Else
            If editGridCell(excelDataGridView, "受付時間", rowIdx, strDateTime) Then
                Return True
            Else
                Return False
            End If
        End If


    End Function

    Public Function 受付時刻を取得()
        Dim today As DateTime

        today = Now

        Dim strTime As String = DirectCast(today.ToString("yyyy/MM/dd HH:mm"), String)
        Return strTime

    End Function


    'メッセージ表示

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If TabControl1.SelectedTab.Name = "バーコード受付Page" Then
            バーコードデータBox.Select()
            バーコードデータBox_Enter(バーコードデータBox, New EventArgs())
        End If
    End Sub
    Private Sub バーコードデータBox_Enter(sender As Object, e As EventArgs) Handles バーコードデータBox.Enter
        If Panel1.BackColor <> Color.LightGreen And CheckGridViewIsFilled Then
            messageLabel.Text = "受診票のバーコードを読み取ってください。"
            Panel1.BackColor = Color.LightGreen
        End If
    End Sub
    Private Sub バーコードデータBox_Leave(sender As Object, e As EventArgs) Handles バーコードデータBox.Leave
        If Panel1.BackColor = Color.LightGreen And CheckGridViewIsFilled Then
            messageLabel.Text = "読み取りデータ欄にフォーカスを置いて、バーコードの読み取りを開始して下さい。"
            Panel1.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub displayReadBarcodePrompt()
        If CheckGridViewIsFilled And CheckBarcodeBoxSelected Then
            messageLabel.Text = "受診票のバーコードを読み取ってください。"
            Panel1.BackColor = Color.LightGreen
        ElseIf CheckGridViewIsFilled Then
            messageLabel.Text = "読み取りデータ欄にフォーカスを置いて、バーコードの読み取りを開始して下さい。"
            Panel1.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub displayDuplicateSNumberAlert()
        If CheckGridViewIsFilled Then
            messageLabel.Text = "通番が重複しています。変更して下さい。"
            Panel1.BackColor = Color.Salmon
        End If
    End Sub

    Private Sub displayInappropriateSNumberAlert()
        If CheckGridViewIsFilled Then
            messageLabel.Text = "セルに数字以外が入力されています。補足事項は備考欄に入力して下さい。"
            Panel1.BackColor = Color.Salmon
        End If
    End Sub



    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        '--- Windowがフォーカスを失ったら、処理継続不可能を示すメッセージを表示
        If CheckGridViewIsFilled Then
            messageLabel.Text = "フォームからフォーカスが外れました。バーコードの読み取りが出来ません！"
            Panel1.BackColor = Color.LightPink
            バーコードデータBox.Text = ""
        End If

    End Sub

    Private Sub 受付人数更新()
        Dim numOfReceivedPersons As Integer = SNMnger.受付人数を取得
        Dim totalNum As Integer = gridDataTable.Rows.Count

        受付人数Label.Text = CStr(numOfReceivedPersons) + "　／　" + CStr(totalNum) + "　　名"

    End Sub


    'その他
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Name = "バーコード受付Page" Then
            バーコードデータBox.Focus()
        End If
    End Sub

    Private ReadOnly Property CheckBarcodeBoxSelected
        Get

            If バーコードデータBox.Name = Me.ActiveControl.Name Then
                CheckBarcodeBoxSelected = True
            Else
                CheckBarcodeBoxSelected = False
            End If
        End Get
    End Property

    '最後の処理
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If CheckGridViewIsFilled Then
            If MessageBox.Show("フォームの表をエクセルファイルに保存しますか？", "保存確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                エクセルファイルを出力()
            End If

            ログの出力()
        End If




    End Sub

    Private Sub excelDataGridView_DragEnter(sender As Object, e As DragEventArgs) Handles excelDataGridView.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub dragdropMessage_DragEnter(sender As Object, e As DragEventArgs) Handles dragdropMessage.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub 絞込クリアBtn_Click(sender As Object, e As EventArgs) Handles 絞込クリアBtn.Click
        フィルタのクリア()

    End Sub


End Class
