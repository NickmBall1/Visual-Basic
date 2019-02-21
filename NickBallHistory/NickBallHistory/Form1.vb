Public Class Form1
    Dim score As Integer
    Dim finalscore As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        If TextBox1.Text = ("george washington") Then
            score += 1
        End If
        If CheckBox2.Checked = True And CheckBox4.Checked = True And CheckBox1.Checked = False And CheckBox3.Checked = False Then
            score += 1
        End If
        If radbtn2.Checked = True Then
            score += 1
        End If
        If radbtntrue1.Checked = True Then
            score += 1
        End If
        If radbtntrue2.Checked = True Then
            score += 1
        End If
        If radbtntrue3.Checked = True Then
            score += 1
        End If
        finalscore = (score / 6) * 100

        If finalscore > 60 Then
            Label7.Text = (finalscore & "% You have passed")

        Else
            Label7.Text = (finalscore & "% You have failed")

        End If

    End Sub
End Class
