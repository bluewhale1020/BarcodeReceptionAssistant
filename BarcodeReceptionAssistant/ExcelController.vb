Imports ClosedXML.Excel
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class ExcelController
    Private inputFileName As String = ""
    Private fileName As String
    Private objBook As XLWorkbook
    Private objSheet As IXLWorksheet
    Private regexColName = New Regex("[A-Za-z]+", RegexOptions.Compiled)
    Private dtable As DataTable
    Private rx_date = New Regex("日|受付時", RegexOptions.Compiled)
    'Private numericCols As String() = New String() {"整理番号"}
    Private Const TOTAL = "合計"
    Private Const COLUMN_BIKO = "備考"

    Public Function ファイルのロード(ByVal filePath As String)
        'ファイルストリーム作成
        Using fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

            Try

                '読み取り専用で開く
                objBook = New XLWorkbook(fs, XLEventTracking.Disabled)
                'objBook = New XLWorkbook(filePath)
                objSheet = objBook.Worksheets.Worksheet(1)

                inputFileName = filePath

                dtable = New Data.DataTable("gridData")
                Dim dateColIdcs As ArrayList = New ArrayList


                Dim noReceptionData As Boolean = False
                Dim header As IXLRow = objSheet.Row(1)

                If カラム名検索("受付時間", header) = 0 Then
                    noReceptionData = True
                    '先頭に受付時間カラムを追加
                    dtable.Columns.Add("受付時間")
                End If

                For column = 1 To header.CellsUsed.Count
                    If rx_date.IsMatch(header.Cell(column).Value) Then
                        dateColIdcs.Add(column)
                    End If


                    dtable.Columns.Add(New DataColumn(header.Cell(column).Value, GetType(String)))


                Next


                Dim rows As IXLRows = objSheet.RowsUsed
                Dim rowidx As Integer = 1
                'Dim lastrowidx As Integer = objSheet.RowsUsed.Count
                For Each row In rows

                    Dim isSumRow As Boolean = False

                    If rowidx = 1 Then
                        rowidx += 1
                        Continue For
                    End If

                    Dim drow As DataRow = dtable.NewRow()

                    Dim cells = row.Cells.ToDictionary(
            Function(cell) ConvertCellReferenceToNumber(cell.Address.ToInvariantString),
            Function(cell) cell)

                    If noReceptionData = True Then
                        '先頭に受付時間データを追加
                        drow(0) = ""
                    End If


                    Dim bikoIdx As Integer = カラム名検索(COLUMN_BIKO, header)


                    For i = 0 To cells.Keys.Max()
                        Dim c As IXLCell
                        Dim inputData As String = ""
                        If (cells.TryGetValue(i, c)) Then

                            If dateColIdcs.Contains(i + 1) Then
                                If IsDate(c.Value) = False AndAlso c.Value <> "" Then
                                    inputData = シリアル日付変換(Double.Parse(c.Value))
                                Else
                                    inputData = c.Value

                                End If



                            Else
                                inputData = c.Value

                            End If

                            If (i + 1) = bikoIdx AndAlso inputData = TOTAL Then
                                isSumRow = True
                            End If
                            'Console.WriteLine(c.CellValue) 'need hanle for special values 
                            'Else
                            '    drow(i + 1) = ""
                            'Console.WriteLine("empty")
                        End If

                        If noReceptionData = True Then
                            drow(i + 1) = inputData
                        Else
                            drow(i) = inputData
                        End If


                    Next
                    If Not isSumRow Then
                        dtable.Rows.Add(drow)
                    End If

                    rowidx += 1
                Next


                'Return dtable
            Catch ex As Exception
                MessageBox.Show("指定のファイルを開けませんでした。" + ex.Message, "ファイルのロードエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtable = Nothing

            Finally
                If objBook IsNot Nothing Then
                    objSheet = Nothing
                    objBook.Dispose()


                End If


            End Try

        End Using


        Return dtable

    End Function

    Private Function カラム名検索(ByVal colName As String, ByRef header As IXLRow) As Integer

        For colnum = 1 To header.CellsUsed.Count
            If CStr(header.Cell(colnum).Value) = colName Then
                Return colnum
            End If

        Next

        Return 0

    End Function

    Private Function シリアル日付変換(ByVal serialDate As Double) As String

        Dim dateObj As DateTime = DateTime.FromOADate(serialDate)

        Return dateObj.ToShortDateString

    End Function


    Public Function インプットファイル名の取得()

        Return IO.Path.GetFileName(inputFileName)

    End Function

    Public Function ファイルの保存(ByRef gridDataTable As DataTable, ByVal outputPath As String, ByVal addSumRow As Boolean)

        Return exportDataTableToExcel(gridDataTable, outputPath, addSumRow)


    End Function

    Private Function exportDataTableToExcel(ByRef objdt As DataTable, ByVal StrFilePath As String, ByVal addSumRow As Boolean)

        fileName = My.Settings.出力ファイル名 + ".xlsx"

        Dim saveFilePath As String = IO.Path.Combine(StrFilePath, createFullFileName(fileName))
        Dim copiedTable As DataTable = objdt.Copy

        If addSumRow Then
            集計行の追加(copiedTable)
        End If

        objBook = New XLWorkbook()
        objBook.Worksheets.Add(copiedTable)


        Dim result As Boolean = True
        Try
            objBook.SaveAs(saveFilePath)
        Catch ex As Exception
            result = False
            'MessageBox.Show("グリッドデータをエクセルに保存できませんでした。", "保存エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objBook.Dispose()
            copiedTable = Nothing
        End Try


        Return result

    End Function

    Private Sub 集計行の追加(ByRef dtable As DataTable)

        Dim drow As DataRow = dtable.NewRow()
        Dim startPrint As Boolean = False
        Dim i As Integer = 0
        For Each column As DataColumn In dtable.Columns
            If Not startPrint Then
                drow(i) = ""
            Else
                Dim count As Integer = dtable.Select("[" + column.ColumnName + "] <> '' AND [" + column.ColumnName + "] IS NOT NULL").Count
                'Dim count As Integer = Convert.ToInt32(dtable.Compute("COUNT([" + column.ColumnName + "])", "[" + column.ColumnName + "] IS NOT NULL"))
                drow(i) = count
            End If


            If column.ColumnName = COLUMN_BIKO Then
                startPrint = True
                drow(i) = TOTAL
            End If
            i += 1
        Next



        dtable.Rows.Add(drow)

    End Sub


    Private Function createFullFileName(fileName)

        fileName = (Now.Date).ToLongDateString + fileName

        Return fileName
    End Function

    Private Function ConvertCellReferenceToNumber(cellReference As String) As Integer
        Dim colLetters = regexColName.Match(cellReference).Value.ToCharArray()
        Array.Reverse(colLetters)

        Dim convertedValue = Asc(colLetters(0)) - 65

        For i = 1 To colLetters.Length - 1
            Dim current = Asc(colLetters(i)) - 64
            convertedValue += current * Math.Pow(26, i)
        Next

        Return convertedValue
    End Function

End Class
