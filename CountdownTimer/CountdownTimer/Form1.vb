Public Class Form1
    Dim minutes As Integer
    Dim seconds As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        minutes = nudMinutes.Value
        seconds = nudSeconds.Value
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds -= 1
        lblminutes.Text = minutes
        lblseconds.Text = seconds
        If seconds <= 0 Then
            minutes -= 1
            seconds = 60
        End If
        If lblseconds.Text = 0 Then
            If lblminutes.Text = 0 Then
                Timer1.Enabled = False
                Me.BackColor = Color.Red


            End If
        End If


    End Sub
End Class
