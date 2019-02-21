Public Class Form1
    Dim xspeed As Integer
    Dim yspeed As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xspeed = -7
        yspeed = -5
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1.Top += yspeed
        Button1.Left += xspeed
        If Button1.Left <= 0 Then
            xspeed = xspeed * -1

        End If
        If Button1.Left >= Me.Width - 80 Then
            xspeed = xspeed * -1
        End If
        If Button1.Top <= 0 Then
            yspeed = yspeed * -1

        End If
        If Button1.Top >= Me.Height - 50 Then
            yspeed = yspeed * -1
        End If
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.W Then
            yspeed = -3
        End If
        If e.KeyCode = Keys.S Then
            yspeed = 3
        End If
        If e.KeyCode = Keys.A Then
            xspeed = -3
        End If
        If e.KeyCode = Keys.D Then
            xspeed = 3
        End If
    End Sub
End Class
