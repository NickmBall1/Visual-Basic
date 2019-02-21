Public Class Form1
    Public totals(12) As Single
    Dim RND As New Random
    Dim dice1 As Single
    Dim dice2 As Single
    Dim idk As Single
    Dim sum As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idk = TextBox1.Text
        For index = 1 To idk
            dice1 = RND.Next(1, 7)
            dice2 = RND.Next(1, 7)
            sum = dice1 + dice2
            totals(sum) += 1
        Next
        Me.Hide()
        Form2.Show()
    End Sub
End Class
