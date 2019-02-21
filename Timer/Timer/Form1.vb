Public Class Form1
    Dim counter As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        Label1.Text = counter
        If counter = 200 Then
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
End Class
