Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest2

    Dim Main As BarcodeReceptionAssistant.MainForm


    <TestInitialize> Public Sub TestInitialize()

        Main = New BarcodeReceptionAssistant.MainForm


    End Sub

    <TestMethod()> Public Sub Test_右を0で埋める算()

        Dim expected As String = "00023"
        Dim input As Integer = 23




        Dim pbMain = New PrivateObject(Main)

        Dim actual As String = pbMain.Invoke("右を0で埋める", input)

        Console.WriteLine(actual)
        'Assert.IsTrue(actual.Contains(5))
        Assert.AreEqual(expected, actual)


    End Sub

    <TestMethod()> Public Sub TestMethod1()
    End Sub


    <TestCleanup> Public Sub TestCleanup()

    End Sub

End Class