Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl2.Text = Form1.totals(2)
        lbl3.Text = Form1.totals(3)
        lbl4.Text = Form1.totals(4)
        lbl5.Text = Form1.totals(5)
        lbl6.Text = Form1.totals(6)
        lbl7.Text = Form1.totals(7)
        lbl8.Text = Form1.totals(8)
        lbl9.Text = Form1.totals(9)
        lbl10.Text = Form1.totals(10)
        lbl11.Text = Form1.totals(11)
        lbl12.Text = Form1.totals(12)
    End Sub
End Class