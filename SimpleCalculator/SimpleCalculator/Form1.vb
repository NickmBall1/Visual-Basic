Public Class Form1
    Dim dblFirstNumber As Double
    Dim dblSecondNumber As Double
    Dim dblAnswer As Double

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dblFirstNumber = txtfirst.Text
        dblSecondNumber = txtsecond.Text
        dblAnswer = dblFirstNumber + dblSecondNumber
        lblanswer.Text = "The Sum of" & dblFirstNumber & " and " & dblSecondNumber & " equals" & dblAnswer
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        dblFirstNumber = txtfirst.Text
        dblSecondNumber = txtsecond.Text
        dblAnswer = dblFirstNumber - dblSecondNumber
        lblanswer.Text = "The Difference of" & dblFirstNumber & " and " & dblSecondNumber & " equals" & dblAnswer
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        dblFirstNumber = txtfirst.Text
        dblSecondNumber = txtsecond.Text
        dblAnswer = dblFirstNumber * dblSecondNumber
        lblanswer.Text = "The Product of" & dblFirstNumber & " and " & dblSecondNumber & " equals" & dblAnswer
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        dblFirstNumber = txtfirst.Text
        dblSecondNumber = txtsecond.Text
        dblAnswer = dblFirstNumber / dblSecondNumber
        lblanswer.Text = "The Quotient of" & dblFirstNumber & " and " & dblSecondNumber & " equals " & dblAnswer
    End Sub
End Class
