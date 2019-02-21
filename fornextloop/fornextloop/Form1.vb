Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim endnumber As Integer
        Dim p As Integer
        p = 1
        endnumber = textbox1.text
        For counter = 1 To endnumber
            If endnumber Mod counter = 0 Then
                p = 0

            Else p = 1
                ListBox1.Items.Add(counter)
            End If
        Next

    End Sub
End Class
