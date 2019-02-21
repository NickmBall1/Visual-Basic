Public Class Form1
    Dim origintext As String
    Dim reveretext As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        origintext = TextBox1.Text
        For index = origintext.Length - 1 To 0 Step -1
            reveretext += origintext.Chars(index)

        Next

        If origintext = reveretext Then
            Label2.Text = "It's a palindrome"
        Else Label2.Text = "It's not a palindrome"
        End If
    End Sub
End Class
