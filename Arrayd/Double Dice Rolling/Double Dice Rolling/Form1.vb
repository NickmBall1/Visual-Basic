Public Class Form1
    Public totals(12) As Single
    Dim RND As New Random
    Dim dice1 As Single
    Dim dice2 As Single
    Dim sum As Single
    Dim idk As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'for   loop to generate the data
        idk = TextBox1.Text
        For a = 1 To idk

            dice1 = RND.Next(1, 7)
                dice2 = RND.Next(1, 7)
                sum = dice1 + dice2
            totals(sum) += 1
        Next
        'amke 2 random numbers from 1-6

        'add them together 
        'add 1 to the slot in the array
        'that corresponds to the total
        'end loop
        Form2.Show()
        Me.Hide()
    End Sub
End Class
