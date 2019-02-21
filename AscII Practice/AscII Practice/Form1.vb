Public Class Form1
    Dim strCharacter As String
    Dim intASCII As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strCharacter = txtChar.Text
        txtASCII.Text = Asc(strCharacter)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intASCII = txtASCII.Text
        txtChar.Text = Chr(intASCII)
    End Sub
End Class
