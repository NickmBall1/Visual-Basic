Public Class Form3
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form1.Show()
        Me.Close()
        For index = 2 To 12
            Form1.totals(index) = 0
        Next
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim largestnumber As Single
        'for loop to look for the largest Number
        For item = 2 To 12
            If Form1.totals(item) > largestnumber Then
                largestnumber = Form1.totals(item)
            End If
        Next

        Button1.Height = (Form1.totals(2) / largestnumber) * 493
        Button2.Height = (Form1.totals(3) / largestnumber) * 493
        Button3.Height = (Form1.totals(4) / largestnumber) * 493
        Button4.Height = (Form1.totals(5) / largestnumber) * 493
        Button5.Height = (Form1.totals(6) / largestnumber) * 493
        Button6.Height = (Form1.totals(7) / largestnumber) * 493
        Button7.Height = (Form1.totals(8) / largestnumber) * 493
        Button8.Height = (Form1.totals(9) / largestnumber) * 493
        Button9.Height = (Form1.totals(10) / largestnumber) * 493
        Button10.Height = (Form1.totals(11) / largestnumber) * 493
        Button11.Height = (Form1.totals(12) / largestnumber) * 493
        Button1.Top = 493 - Button1.Height
        Button2.Top = 493 - Button2.Height
        Button3.Top = 493 - Button3.Height
        Button4.Top = 493 - Button4.Height
        Button5.Top = 493 - Button5.Height
        Button6.Top = 493 - Button6.Height
        Button7.Top = 493 - Button7.Height
        Button8.Top = 493 - Button8.Height
        Button9.Top = 493 - Button9.Height
        Button10.Top = 493 - Button10.Height
        Button11.Top = 493 - Button11.Height
        'compare each number in the array
        'to the largestnumber variable
        'end loop
        'set each buttons height to the percentage
        'that it is of the largestnumber
    End Sub
End Class