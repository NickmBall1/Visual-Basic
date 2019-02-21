Imports System.IO
Public Class Form1
    Dim namearray As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        namearray.Add(TextBox1.Text)
        ListBox1.Items.Clear()
        For Each person As String In namearray
            ListBox1.Items.Add(person)
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
        Dim objfile As New StreamWriter(SaveFileDialog1.FileName)
        For Each item As String In namearray
            objfile.WriteLine(item)
        Next
        objfile.Close()
        objfile.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        Dim objfile As New StreamReader(OpenFileDialog1.FileName)
        Do Until objfile.Peek = -1
            namearray.Add(objfile.ReadLine())
        Loop

        objfile.Close()
        objfile.Dispose()
        For Each item As String In namearray
            ListBox1.Items.Add(item)
        Next
    End Sub
End Class
