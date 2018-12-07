Public Class Form1
    Dim Names(9) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Names(0) = "Billy"
        Names(1) = "Johnny"
        Names(2) = "Joey"
        Names(3) = "David"
        Names(4) = "Zach"
        Names(5) = "Alex"
        Names(6) = "Hannah"
        Names(7) = "Jared"
        Names(8) = "Ethan"
        Names(9) = "Gavin"
        DisplayArray()
    End Sub
    Private Sub DisplayArray()
        For index = 0 To 9
            ListBox1.Items.Add(Names(index))
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myname As String
        Dim Approved As Boolean
        Approved = False
        myname = TextBox1.Text
        For index = 0 To 9
            If myname = Names(index) Then
                Approved = True
            End If
        Next
        If Approved = True Then
            MessageBox.Show("Welcome")
        Else
            MessageBox.Show("Buzz off")
        End If
    End Sub
End Class
