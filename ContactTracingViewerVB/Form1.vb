Imports System.IO
Public Class Form1
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim filereader As System.IO.StreamReader

        Dim search As String = searchTxtBox.Text + ".txt"

        filereader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\ASUNCION\Desktop\Visitor's Files\" + search)
        viewSpecTxtBox.Text = filereader.ReadToEnd()

    End Sub
End Class
