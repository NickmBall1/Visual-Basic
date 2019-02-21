Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As Single
        Dim second As Single
        Dim newnumber As Single
        Dim endpoint As Single
        first = 1
        second = 1
        ListBox1.Items.Clear()
        ListBox1.Items.Add(first)
        ListBox1.Items.Add(second)
        endpoint = TextBox1.Text

        For index = 1 To endpoint - 2
            newnumber = first + second
            ListBox1.Items.Add(newnumber)
            If first <= second Then
                first = newnumber
            Else
                second = newnumber
            End If
        Next
    End Sub
End Class

