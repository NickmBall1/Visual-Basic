Public Class Form1
    Dim xspeedb As Integer
    Dim yspeedb As Integer
    Dim yspeedp As Integer
    Dim yspeedc As Integer
    Dim player As Integer
    Dim computer As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xspeedb = 2
        yspeedb = 2
        yspeedp = 0
        yspeedc = 1
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btnplayer.Focus()
        Moveball()
        MovePlayer()
        MoveComputer()
        PlayerBounce()
        ComputerBounce()
    End Sub
    Private Sub Moveball()
        btnball.Top += yspeedb
        btnball.Left += xspeedb
        If btnball.Left <= 0 Then
            xspeedb = xspeedb * -1
            player += 1
            btnball.Left = 400
        End If
        If btnball.Left >= Me.Width - 25 Then
            computer += 1
            btnball.Left = 400
        End If
        If btnball.Top <= 0 Then
            yspeedb = yspeedb * -1

        End If
        If btnball.Top >= Me.Height - 50 Then
            yspeedb = yspeedb * -1
        End If
        checkwin()

    End Sub
    Private Sub MovePlayer()
        btnplayer.Top += yspeedp
        If btnplayer.Top <= 0 Then
            yspeedp = yspeedp * -1
            btnplayer.Top = 0
        End If
        If btnplayer.Top >= Me.Height - 140 Then
            yspeedp = yspeedp * -1
            btnplayer.Top = Me.Height - 140
        End If
    End Sub

    Private Sub MoveComputer()
        btncomp.Top += yspeedc
        If btncomp.Top <> btnball.Top Then

            btncomp.Top = btnball.Top + 15
        End If

        If btncomp.Top <= 0 Then
            yspeedc = yspeedc * -1
            btncomp.Top = 0
        End If
        If btncomp.Top >= Me.Height - 140 Then
            yspeedc = yspeedc * -1
            btncomp.Top = Me.Height - 140
        End If
    End Sub
    Private Sub PlayerBounce()
        If btnball.Right >= btnplayer.Left Then
            If btnplayer.Bottom > btnball.Top Then
                If btnplayer.Top < btnball.Bottom Then

                    xspeedb = xspeedb * -1
                End If
            End If
        End If
    End Sub
    Private Sub ComputerBounce()
        If btnball.Left <= btncomp.Right Then
            If btncomp.Bottom > btnball.Top Then
                If btncomp.Top < btnball.Bottom Then

                    xspeedb = xspeedb * -1
                End If
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Hide()
    End Sub

    Private Sub btnplayer_KeyDown(sender As Object, e As KeyEventArgs) Handles btnplayer.KeyDown
        If e.KeyCode = Keys.W Then
            yspeedp = -2
        End If
        If e.KeyCode = Keys.S Then
            yspeedp = 2
        End If
    End Sub

    Private Sub btnplayer_KeyUp(sender As Object, e As KeyEventArgs) Handles btnplayer.KeyUp
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.S Then
            yspeedp = 0
        End If
    End Sub
    Private Sub checkwin()
        If player = 3 Then
            Label1.Text = ("Player wins")

            player = 0
            computer = 0
        ElseIf computer = 3 Then
            Label1.Text = ("Computer wins")

            player = 0
            computer = 0
        End If

    End Sub
End Class
