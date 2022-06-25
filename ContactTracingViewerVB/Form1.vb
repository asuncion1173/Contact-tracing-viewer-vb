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
End Class
