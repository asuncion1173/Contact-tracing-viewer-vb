Imports System.IO
Public Class Form1

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim filereader As System.IO.StreamReader

        Dim search As String = searchTxtBox.Text + ".txt"

        If File.Exists(search) Then
            filereader = My.Computer.FileSystem.OpenTextFileReader(search)
            viewSpecTxtBox.Text = filereader.ReadToEnd()
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim filepath() As Object = Directory.GetFiles("C:\Users\ASUNCION\source\repos\VB\ContactTracingViewerVB\ContactTracingViewerVB\bin\Debug", "*.txt")
        For Each item As String In filepath
            Dim result As String = Path.GetFileName(item)
            ListBox1.Items.Add(result)
        Next
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        searchTxtBox.Clear()
        viewSpecTxtBox.Clear()
    End Sub
End Class
