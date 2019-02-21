Public Class Form1
    Dim btnarray As New ArrayList
    Dim rnd As New Random
    Dim randomnumber As Integer
    Dim counter As Integer
    Dim score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnarray.Add(Button1)
        btnarray.Add(Button2)
        btnarray.Add(Button3)
        btnarray.Add(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        randomnumber = rnd.Next(0, 4)
        btnarray(randomnumber).backcolor = Color.DeepSkyBlue
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1


        If counter = 10 Then
            MessageBox.Show("You lose!!!")
            Timer1.Enabled = False
            counter = 0
            score = 0
            For Each thing As Button In btnarray
                thing.BackColor = Color.White
            Next
        End If
        Label2.Text = score
    End Sub
    Private Sub newbutton()
        For index = 1 To 10000000

        Next
        randomnumber = rnd.Next(0, 4)
        btnarray(randomnumber).backcolor = Color.DeepSkyBlue
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.DeepSkyBlue Then
            Button1.BackColor = Color.White
            counter = 0
            score += 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.DeepSkyBlue Then
            Button2.BackColor = Color.White
            counter = 0
            score += 1
            newbutton()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.DeepSkyBlue Then
            Button3.BackColor = Color.White
            counter = 0
            score += 1
            newbutton()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.DeepSkyBlue Then
            Button4.BackColor = Color.White
            counter = 0
            score += 1
            newbutton()
        End If
    End Sub
End Class
