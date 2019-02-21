Public Class Form1
    Dim playerturn As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerturn = 0

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        playerturn += 1
        Btn1.Enabled = False

        If playerturn Mod 2 > 0 Then
            Btn1.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else Btn1.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        playerturn += 1
        Btn2.Enabled = False

        If playerturn Mod 2 > 0 Then
            Btn2.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else Btn2.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        playerturn += 1
        btn3.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn3.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn3.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        playerturn += 1
        btn4.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn4.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn4.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        playerturn += 1
        btn5.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn5.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn5.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        playerturn += 1
        btn6.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn6.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn6.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        playerturn += 1
        btn7.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn7.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn7.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        playerturn += 1
        btn8.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn8.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn8.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        playerturn += 1
        btn9.Enabled = False

        If playerturn Mod 2 > 0 Then
            btn9.BackColor = Color.Blue
            Label2.BackColor = Color.Red
        Else btn9.BackColor = Color.Red
            Label2.BackColor = Color.Blue
        End If
        checkwinner()
    End Sub
    Private Sub checkwinner()
        If Btn1.BackColor = Color.Blue And Btn2.BackColor = Color.Blue And btn3.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True

        ElseIf Btn1.BackColor = Color.Red And Btn2.BackColor = Color.Red And btn3.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True

        ElseIf btn4.BackColor = Color.Blue And btn5.BackColor = Color.Blue And btn6.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn7.BackColor = Color.Blue And btn8.BackColor = Color.Blue And btn9.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn1.BackColor = Color.Red And btn4.BackColor = Color.Red And btn7.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn1.BackColor = Color.Blue And btn4.BackColor = Color.Blue And btn7.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn2.BackColor = Color.Blue And btn5.BackColor = Color.Blue And btn8.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn2.BackColor = Color.Red And btn5.BackColor = Color.Red And btn8.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn3.BackColor = Color.Blue And btn6.BackColor = Color.Blue And btn9.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn3.BackColor = Color.Red And btn6.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn1.BackColor = Color.Blue And btn5.BackColor = Color.Blue And btn9.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn1.BackColor = Color.Red And btn5.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn3.BackColor = Color.Red And btn5.BackColor = Color.Red And btn7.BackColor = Color.Red Then
            MessageBox.Show("Red Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf btn3.BackColor = Color.Blue And btn5.BackColor = Color.Blue And btn7.BackColor = Color.Blue Then
            MessageBox.Show("Blue Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        ElseIf Btn1.Enabled = False And Btn2.Enabled = False And Btn3.Enabled = False And Btn4.Enabled = False And Btn5.Enabled = False And Btn6.Enabled = False And Btn7.Enabled = False And Btn8.Enabled = False And Btn9.Enabled = False Then
            MessageBox.Show("Nobody Wins!!!")
            Btn1.BackColor = Color.White
            Btn1.Enabled = True
            Btn2.BackColor = Color.White
            Btn2.Enabled = True
            btn3.BackColor = Color.White
            btn3.Enabled = True
            btn4.BackColor = Color.White
            btn4.Enabled = True
            btn5.BackColor = Color.White
            btn5.Enabled = True
            btn6.BackColor = Color.White
            btn6.Enabled = True
            btn7.BackColor = Color.White
            btn7.Enabled = True
            btn8.BackColor = Color.White
            btn8.Enabled = True
            btn9.BackColor = Color.White
            btn9.Enabled = True
        End If

    End Sub



End Class
