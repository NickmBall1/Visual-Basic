Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.DarkSeaGreen
        Button1.Height = 100
        Button1.Width = 100
        Button1.Top = 70
        Button1.Left = 100
        Button2.Show()

    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.DarkSeaGreen
        Label1.Text = ""
        Button2.Height = 100
        Button2.Width = 100
        Button2.Top = 70
        Button2.Left = 100
        Button2.Hide()

    End Sub
    Private Sub button3_click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "Progamming is Easy"
    End Sub

End Class
