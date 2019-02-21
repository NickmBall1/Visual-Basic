Public Class Form1
    Dim largest As Integer
    Dim smallest As Integer
    Dim rnd As New Random
    Dim numbers(999) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 0 To 999
            numbers(index) = rnd.Next(1, 1000001)
        Next
        For jimbob = 0 To 999
            ListBox1.Items.Add(numbers(jimbob))
        Next
        For bunnies = 0 To 999
            If numbers(bunnies) > largest Then
                largest = numbers(bunnies)
            End If
        Next
        lbllargest.Text = largest
        smallest = 1000000
        For index = 0 To 999
            If numbers(index) < smallest Then
                smallest = numbers(index)
            End If
        Next
        lblSmallest.Text = smallest
    End Sub
End Class
