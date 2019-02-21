Public Class Form1
    Dim numbers(19) As Integer
    Dim rnd As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 0 To 19
            numbers(index) = rnd.Next(1, 101)
        Next

        For index = 0 To 19
            ListBox1.Items.Add(numbers(index))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim temp As Integer
        For dave = 0 To 19
            For index = 0 To 18
                If numbers(index) > numbers(index + 1) Then
                    temp = numbers(index + 1)
                    numbers(index + 1) = numbers(index)
                    numbers(index) = temp
                End If

            Next
        Next
        For index = 0 To 19
            ListBox2.Items.Add(numbers(index))
        Next
    End Sub
End Class
