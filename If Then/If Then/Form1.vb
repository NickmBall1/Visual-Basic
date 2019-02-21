Public Class Form1
    Dim strName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strName = TextBox1.Text
        If strName = "Nick" Or strName = "Zim" Or strName = "Moose" Or strName = "Zach" Then
            MessageBox.Show("Welcome to the jungle!!!")
        Else MessageBox.Show("Who do you think you are?!?!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intAge As Integer
        intAge = TextBox1.Text
        If intAge < 16 Then
            MessageBox.Show("ah, how sweet")
            Me.BackColor = Color.Black
        ElseIf intAge >= 16 And intAge < 18 Then
            MessageBox.Show("At least you can drive now")
            Me.BackColor = Color.DarkGray
        ElseIf intAge >= 18 And intAge < 21 Then
            MessageBox.Show("You can play the lottery now")
            Me.BackColor = Color.Gray
        ElseIf intAge >= 21 Then
            MessageBox.Show("You can do almost anything now")
            Me.BackColor = Color.White
        End If
    End Sub
End Class