Public Class Form1
    Dim rnd As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newnumber As Integer
        newnumber = rnd.Next(1, 6)
        Select Case newnumber
            Case 1
                MessageBox.Show("Arrays are awesome")
            Case 2
                MessageBox.Show("Why aren't you using a Array")
            Case 3
                MessageBox.Show("Arrays are better than select cases")
            Case 4
                MessageBox.Show("Arrays are a list function")
            Case 5
                MessageBox.Show("This is getting repetitive")
        End Select

    End Sub
End Class
