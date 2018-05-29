Imports System.Collections
Imports System.Collections.Specialized
Imports System.IO

Public Class LogManager

    Private logPath As String = My.Settings.ログファイルパス
    Dim sw As StreamWriter
    Dim fs As FileStream = Nothing

    Public Function ログデータを保存(ByVal logData As OrderedDictionary)

        Dim strLog As String = ログデータの作成(logData)
        Dim result As Boolean = True

        'ログファイルを取得



        'ログデータをテキストデータに書き込む

        'ログファイルの保存
        Dim fileExists As Boolean = File.Exists(logPath)
        Try
            Using writer As New StreamWriter(logPath, True)
                If Not fileExists Then
                    writer.WriteLine("バーコード受付ツール　ログデータ ファイル使用開始日：" + DateTime.Today.ToString("dd-MMM-yyyy"))
                End If
                writer.WriteLine(strLog)
            End Using
        Catch ex As Exception
            result = False
        End Try


        Return result



    End Function

    Private Function ログデータの作成(ByVal logData As OrderedDictionary)

        Dim strLog As String = ""


        ' エントリ（キーと値）の列挙
        For Each de As DictionaryEntry In logData
            strLog += de.Key.ToString + ":" + de.Value.ToString + ","
        Next

        Return strLog

    End Function


End Class
