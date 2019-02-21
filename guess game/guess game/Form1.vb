Public Class Form1
    Dim RandomNumber As New Random
    Dim intguess As Integer
    Dim intnumber As Integer
    Dim numguess As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intguess = TextBox1.Text

        Label4.Text = numguess
        If intguess = intnumber Then
            MessageBox.Show("Congrats!!! You have guessed the right number")
            Application.Exit()
            Process.Start(Application.ExecutablePath)
        ElseIf numguess = 0 Then
            MessageBox.Show("You have lost")
            Application.Exit()
            Process.Start(Application.ExecutablePath)
        ElseIf intguess > intnumber Then
            Label3.Text = ("Go lower")
            numguess -= 1
        ElseIf intguess < intnumber Then
            Label3.Text = ("Go higher")
            numguess -= 1

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intnumber = RandomNumber.Next(1, 101)
        Label2.Text = intnumber
        numguess = 5
        Label4.Text = numguess
    End Sub


End Class
