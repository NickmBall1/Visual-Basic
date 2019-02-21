Imports System.IO
Public Class Form1
    Dim sum As Double
    Dim numberitem As Double
    Dim average As Double
    Dim numbers As New ArrayList
    Dim first As Integer
    Dim second As Integer
    Dim newnumber As Single
    Dim calculate As New ArrayList
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim objfile As New StreamReader(OpenFileDialog1.FileName)
        Do Until objfile.Peek = -1
            Dim number As Double
            number = objfile.ReadLine
            numbers.Add(number)
            ListBox1.Items.Add(number)
        Loop
        objfile.Close()
        objfile.Dispose()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim objfile As New StreamWriter(SaveFileDialog1.FileName)

        objfile.WriteLine(sum)
            objfile.WriteLine(numberitem)
            objfile.WriteLine(average)

        objfile.Close()
        objfile.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item In numbers
            numberitem += 1
            Label4.Text = numberitem
        Next
        first = 0.0
        For Each n In numbers
            first += n
            sum = first
            Label2.Text = sum
        Next
        average = sum / numberitem
        Label6.Text = average
    End Sub

End Class
