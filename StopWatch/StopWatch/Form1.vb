Public Class Form1
    Dim counter As Integer
    Dim minutes As Integer
    Dim seconds As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If counter = 100 Then
            seconds += 1
            counter = 0

        End If
        If seconds = 60 Then
            minutes += 1
            seconds = 0
        End If
        lblseconds.Text = seconds
        lblhundredth.Text = counter
        lblminutes.Text = minutes

        Label3.Text = TimeOfDay

    End Sub
End Class
