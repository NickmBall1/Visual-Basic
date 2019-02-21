Public Class Form1
    Dim myarray As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myarray.Add(TextBox1.Text)
        refresh()
    End Sub
    Private Sub refresh()
        ListBox1.Items.Clear()
        For Each thingy As String In myarray
            ListBox1.Items.Add(thingy)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim itemnumber As Integer
        itemnumber = ListBox1.SelectedIndex
        myarray.RemoveAt(itemnumber)
        refresh()
    End Sub
End Class
