Imports System.Math

Public Class Form1
    Dim Radius As Double
    Dim Diameter As Double
    Dim Area As Double
    Dim Circumference As Double
    Private Sub CalcCircle_Click(sender As Object, e As EventArgs) Handles CalcCircle.Click
        If Radbutton.Checked = True Then
            Radius = TextBox1.Text
            Diameter = 2 * Radius
            Circumference = 2 * PI * Radius
            Area = PI * Radius ^ 2
            Radiuslbl.Text = Radius
            Diameterlbl.Text = Diameter
            Arealbl.Text = Area
            Circumferencelbl.Text = Circumference

        End If
        If DiaButton.Checked = True Then
            diameter = TextBox1.Text
            Radius = Diameter / 2
            Circumference = 2 * PI * Radius
            Area = PI * Radius ^ 2
            Radiuslbl.Text = Radius
            Diameterlbl.Text = Diameter
            Arealbl.Text = Area
            Circumferencelbl.Text = Circumference

        End If
        If CircumButton.Checked = True Then
            Circumference = TextBox1.Text
            Radius = Circumference / (2 * PI)
            Diameter = 2 * Radius
            Area = PI * Radius ^ 2
            Radiuslbl.Text = Radius
            Diameterlbl.Text = Diameter
            Arealbl.Text = Area
            Circumferencelbl.Text = Circumference

        End If
        If AreaButton.Checked = True Then
            Area = TextBox1.Text
            Radius = Sqrt(Area / PI)
            Diameter = 2 * Radius
            Circumference = 2 * PI * Radius
            Radiuslbl.Text = Radius
            Diameterlbl.Text = Diameter
            Arealbl.Text = Area
            Circumferencelbl.Text = Circumference

        End If
    End Sub
End Class
