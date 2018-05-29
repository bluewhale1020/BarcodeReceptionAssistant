Imports System.Collections.Specialized
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    Dim SNMClass As BarcodeReceptionAssistant.SerialNumberManager
    Dim dtable As DataTable
    Dim colData As ArrayList

    <TestInitialize> Public Sub TestInitialize()

        SNMClass = New BarcodeReceptionAssistant.SerialNumberManager
        dtable = New DataTable
        dtable.Columns.Add("整理番号")

        For i = 1 To 10
            Dim drow As DataRow = dtable.NewRow()
            If i = 5 Then
                drow(0) = ""
            Else
                drow(0) = i
            End If

            dtable.Rows.Add(drow)
        Next

        Dim pbObj = New PrivateObject(SNMClass)
        colData = New ArrayList
        colData = pbObj.Invoke("createColDataFromDatatable", dtable)


    End Sub

    <TestMethod()> Public Sub Test_現在の通番を取得()

        Dim expected As Integer = 1
        Dim actual As Integer

        actual = SNMClass.現在の通番を取得
        Console.WriteLine(actual)
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub Test_createColDataFromDatatable()

        Dim expected As ArrayList = New ArrayList()
        Dim actual As ArrayList = New ArrayList()
        actual = colData

        For i = 1 To 10
            If i = 5 Then
                'expected.Add("")
            Else
                expected.Add(i)
            End If

        Next


        Assert.AreEqual(expected(0), actual(0))
        Assert.AreEqual(expected(4), actual(4))
        Assert.AreEqual(expected(5), actual(5))
        Assert.AreEqual(expected(8), actual(8))

    End Sub

    <TestMethod()> Public Sub Test_受付人数を計算()

        Dim expected As Integer = 9
        Dim actual As Integer

        Dim pbObj = New PrivateObject(SNMClass)
        actual = pbObj.Invoke("受付人数を計算", colData)
        Console.WriteLine(actual)
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub Test_通番最大値の取得()

        Dim expected As Integer = 10
        Dim actual As Integer

        Dim pbObj = New PrivateObject(SNMClass)
        actual = pbObj.Invoke("通番最大値の取得", colData)
        Console.WriteLine(actual)
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub Test_通番最小値の取得()

        Dim expected As Integer = 1
        Dim actual As Integer

        Dim pbObj = New PrivateObject(SNMClass)
        actual = pbObj.Invoke("通番最小値の取得", colData)
        Console.WriteLine(actual)
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub Test_通番情報の取得()

        Dim expected As OrderedDictionary = New OrderedDictionary()
        expected.Add("開始番号", 1)
        expected.Add("終了番号", 1)
        expected.Add("現在の通番", 1)
        expected.Add("受付人数", 0)

        Dim actual As OrderedDictionary

        actual = SNMClass.通番情報の取得()
        Console.WriteLine(actual)
        'Assert.AreSame(expected, actual)
        Assert.AreEqual(expected("開始番号"), actual("開始番号"))
        Assert.AreEqual(expected("終了番号"), actual("終了番号"))
        Assert.AreEqual(expected("現在の通番"), actual("現在の通番"))
        Assert.AreEqual(expected("受付人数"), actual("受付人数"))

    End Sub

    <TestMethod()> Public Sub Test_欠番を計算()

        Dim expected As ArrayList = New ArrayList()
        expected.Add(5)


        Dim actual As ArrayList

        Dim pbObj = New PrivateObject(SNMClass)
        pbObj.Invoke("欠番を計算", dtable)
        actual = pbObj.GetField("missingNumbers")

        Console.WriteLine(actual)
        Assert.IsTrue(actual.Contains(5))
        'Assert.AreEqual(expected("開始番号"), actual("開始番号"))


    End Sub

    <TestMethod()> Public Sub Test_通番を1加算()

        Dim expected As OrderedDictionary = New OrderedDictionary()
        'expected.Add("開始番号", 1)
        'expected.Add("終了番号", 1)
        expected.Add("現在の通番", 2)
        'expected.Add("受付人数", 1)

        Dim actual As OrderedDictionary

        actual = SNMClass.通番を1加算()

        'Assert.AreEqual(expected("開始番号"), actual("開始番号"))
        'Assert.AreEqual(expected("終了番号"), actual("終了番号"))
        Assert.AreEqual(expected("現在の通番"), actual("現在の通番"))
        'Assert.AreEqual(expected("受付人数"), actual("受付人数"))
        Console.WriteLine(actual("現在の通番"))
        actual = SNMClass.通番を1加算()
        'expected("終了番号") = 2
        expected("現在の通番") = 3
        'expected("受付人数") = 2

        'Assert.AreEqual(expected("開始番号"), actual("開始番号"))
        'Assert.AreEqual(expected("終了番号"), actual("終了番号"))
        Assert.AreEqual(expected("現在の通番"), actual("現在の通番"))
        'Assert.AreEqual(expected("受付人数"), actual("受付人数"))

        Console.WriteLine(actual("現在の通番"))
        'Assert.AreSame(expected, actual)



    End Sub

    <TestMethod()> Public Sub Test_通番セルの変更()

        Dim expected As OrderedDictionary = New OrderedDictionary()
        expected.Add("開始番号", 1)
        expected.Add("終了番号", 15)
        expected.Add("現在の通番", 1)
        expected.Add("受付人数", 9)

        Dim actual As OrderedDictionary
        dtable.Rows(2).Item("整理番号") = 15
        SNMClass.通番セルの変更(dtable)
        actual = SNMClass.通番情報の取得

        Assert.AreEqual(expected("開始番号"), actual("開始番号"))
        Assert.AreEqual(expected("終了番号"), actual("終了番号"))
        Assert.AreEqual(expected("現在の通番"), actual("現在の通番"))
        Assert.AreEqual(expected("受付人数"), actual("受付人数"))
        Console.WriteLine(actual("現在の通番"))

        dtable.Rows.RemoveAt(0)
        SNMClass.通番セルの変更(dtable)
        actual = SNMClass.通番情報の取得

        expected("開始番号") = 2
        expected("現在の通番") = 1
        expected("受付人数") = 8

        Assert.AreEqual(expected("開始番号"), actual("開始番号"))
        Assert.AreEqual(expected("終了番号"), actual("終了番号"))
        Assert.AreEqual(expected("現在の通番"), actual("現在の通番"))
        Assert.AreEqual(expected("受付人数"), actual("受付人数"))

        Console.WriteLine(actual("現在の通番"))
        'Assert.AreSame(expected, actual)



    End Sub


    <TestMethod()> Public Sub TestMethod1()



        Assert.IsTrue(True)
    End Sub



    <TestCleanup> Public Sub TestCleanup()
        dtable.Dispose()

    End Sub

End Class