Public Class Form1
    Dim Temps(30) As Double
    Dim Days As Integer
    Dim Sum As Double
    Dim Average As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sum = 0
        Temps(Days) = TextBox1.Text
        ListTemps.Items.Add(Temps(Days))
        Days = Days + 1
        'loop to add all the numbers in the array +
        For index = 1 To 30
            'Sum += Temps(Days)
            Sum = Temps.Sum
        Next
        'calculate average(aftter the loop)
        Average = Sum / Days
        Label4.Text = Average
        'show temps in listbox+
        'put average into label4
        Label5.Text = Days
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListTemps.Items.Clear()
        Average = 0
        For index = 1 To 30
            Temps(index) = 0
        Next
        Days = 0
    End Sub
End Class
