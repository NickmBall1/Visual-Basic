Public Class Form1
    Dim RandomNumber As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = RandomNumber.Next(1, 6)
        ListBox1.Items.Add(Label1.Text)
    End Sub
End Class
