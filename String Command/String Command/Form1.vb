Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mystring As String
        mystring = "Thomas"
        'ListBox1.Items.Add(mystring.Length)
        'ListBox1.Items.Add(mystring.Chars(2))
        'ListBox1.Items.Add(mystring.Substring(3, 2))
        For index = 0 To mystring.Length - 1
            ListBox1.Items.Add(mystring.Chars(index))
        Next
    End Sub
End Class
