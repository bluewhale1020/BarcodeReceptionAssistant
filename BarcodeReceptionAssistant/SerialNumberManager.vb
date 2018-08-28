Imports System.Collections.Specialized

Public Class SerialNumberManager

    Private startNumber As Integer = My.Settings.開始番号
    Private endNumber As Integer = startNumber
    Private numOfReceivedPersons As Integer = 0
    Private currentNumber As Integer = startNumber
    Private missingNumbers As ArrayList

    Public Sub New()
        initializeNumberInfo()
    End Sub

    Private Sub initializeNumberInfo()
        startNumber = My.Settings.開始番号
        endNumber = startNumber
        numOfReceivedPersons = 0
        currentNumber = startNumber
        missingNumbers = New ArrayList()
    End Sub

    Public Function 通番情報リセット()

        initializeNumberInfo()

        Return 現在の通番を取得()

    End Function

    Public Function 現在の通番を取得()

        Return currentNumber
    End Function

    Public Function 通番が設定可能か確認(ByVal newCurrentNumber As Integer, ByRef gridDataTable As DataTable)

        Dim colData As ArrayList = createColDataFromDatatable(gridDataTable)

        If colData.Contains(newCurrentNumber) Then
            '重複する通番
            '１を足す
            newCurrentNumber += 1
            If colData.Contains(newCurrentNumber) Then
                '最大値＋１を返す
                newCurrentNumber = 通番最大値の取得(colData) + 1
            End If


        End If
        Return newCurrentNumber

    End Function

    Public Function 受付人数を取得()

        Return numOfReceivedPersons
    End Function

    Public Sub 開始番号の更新(ByVal newStartNumber As Integer)

        startNumber = newStartNumber
    End Sub

    Public Function 通番情報の取得(ByRef Optional gridDataTable As DataTable = Nothing)

        Dim snTable As OrderedDictionary = New OrderedDictionary()
        snTable.Add("開始番号", startNumber)
        snTable.Add("終了番号", endNumber)
        snTable.Add("現在の通番", currentNumber)
        snTable.Add("受付人数", numOfReceivedPersons)

        If gridDataTable IsNot Nothing Then
            欠番を計算(gridDataTable)
            snTable.Add("欠番", missingNumbers)
        End If

        '

        Return snTable

    End Function

    Public Function 現在の通番を更新(ByVal newCurrentNumber As Integer, ByRef gridDataTable As DataTable) ', ByRef gridDataTable As DataTable

        newCurrentNumber = 通番が設定可能か確認(newCurrentNumber, gridDataTable)

        currentNumber = newCurrentNumber
        'numOfReceivedPersons += addedVal

        'If endNumber < currentNumber - 1 Then
        '    endNumber = currentNumber - 1
        'End If



        'Dim missingTotal = 欠番を計算(gridDataTable)



        Return currentNumber

    End Function

    Public Function 通番を1加算()  'ByRef gridDataTable As DataTable

        'If endNumber < currentNumber Then
        '    endNumber = currentNumber
        'End If

        currentNumber += 1
        'numOfReceivedPersons += 1





        'Dim missingTotal = 欠番を計算(gridDataTable)


        Return 通番情報の取得()

    End Function


    Private Sub 欠番を計算(ByRef gridDataTable As DataTable)
        If missingNumbers IsNot Nothing Then
            missingNumbers.Clear()
        End If

        Dim colData As ArrayList = createColDataFromDatatable(gridDataTable)
        colData.Sort()

        Dim pointer As Integer = startNumber

        For Each colVal As String In colData
            Dim sNumber As Integer = CInt(colVal)
            If pointer = sNumber Then

            Else
                While pointer < sNumber
                    missingNumbers.Add(pointer)
                    pointer += 1
                End While

            End If
            pointer += 1

        Next


    End Sub

    Private Function createColDataFromDatatable(ByRef gridDataTable As DataTable) As ArrayList
        'Dim colData As ArrayList = (From row As DataRow In gridDataTable.Rows
        '                            Select CStr(row.Item(My.Settings.入力カラム名)))

        Dim colData As ArrayList = New ArrayList
        For Each row As DataRow In gridDataTable.Rows
            If row.Item(My.Settings.入力カラム名) IsNot Nothing And IsDBNull(row.Item(My.Settings.入力カラム名)) = False Then
                Dim strVal As String = row.Item(My.Settings.入力カラム名)
                If strVal <> "" Then
                    colData.Add(CInt(row.Item(My.Settings.入力カラム名)))
                End If
            End If


        Next

        Return colData

    End Function

    Private Function 受付人数を計算(ByVal colData As ArrayList)

        numOfReceivedPersons = colData.Count

        Return numOfReceivedPersons

    End Function


    Public Function 通番セルの変更(ByRef gridDataTable As DataTable)

        Dim colData As ArrayList = createColDataFromDatatable(gridDataTable)

        startNumber = 通番最小値の取得(colData)

        endNumber = 通番最大値の取得(colData)

        '欠番を計算(gridDataTable)

        受付人数を計算(colData)
        Return True

    End Function

    Private Function 通番最大値の取得(ByVal colData As ArrayList)

        Dim maxNum As Integer = 0


        For Each item In colData

            If item > maxNum Then
                maxNum = item
            End If

        Next


        Return maxNum

    End Function

    Private Function 通番最小値の取得(ByVal colData As ArrayList)

        Dim minNum As Integer = 10000


        For Each item In colData

            If item < minNum Then
                minNum = item
            End If

        Next


        Return minNum
    End Function

End Class
