Public Class Form1
    Dim x As Double
    Dim Mytext As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = TxtNumber.Text
        Label2.Text = ("The number is ") & x

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mytext = TxtWords.Text
        Label4.Text = Mytext
    End Sub
End Class
