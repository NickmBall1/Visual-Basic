Public Class Form1
    Dim randomnumber As New Random
    Dim playermoney As Integer
    Dim betarray As New ArrayList
    Dim number As String
    Dim colors As String
    Dim even As String
    Dim row As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Text = randomnumber.Next(0, 37)
        Dim test As Integer
        Dim testes As Integer
        Dim newnumber As Integer
        newnumber = Button2.Text
        Select Case newnumber
            Case 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36
                Button2.BackColor = Color.Red
                Button2.ForeColor = Color.Black
                colors = "red"
            Case 2, 4, 6, 7, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35
                Button2.BackColor = Color.Black
                Button2.ForeColor = Color.White
                colors = "black"
            Case 0
                Button2.BackColor = Color.Green
                Button2.ForeColor = Color.Black
                colors = "green"


        End Select
        ListBox2.Items.Add(newnumber & " " & colors)
        Select Case test
            Case 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35
                even = "odd"
            Case 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36
                even = "even"
            Case 0
                even = "DAMM"
        End Select
        Select Case testes
            Case 1, 2, 3
                row = "row 1"
            Case 4, 5, 6
                row = "row 2"
            Case 7, 8, 9
                row = "row 3"
            Case 10, 11, 12
                row = "row 4"
            Case 13, 14, 15
                row = "row 5"
            Case 16, 17, 18
                row = "row 6"
            Case 19, 20, 21
                row = "row 7"
            Case 22, 23, 24
                row = "row 8"
            Case 25, 26, 27
                row = "row 9"
            Case 28, 29, 30
                row = "row 10"
            Case 31, 32, 33
                row = "row 11"
            Case 34, 35, 36
                row = "row 12"
        End Select


        For Each bet As Betobj In betarray
            If number = Button2.Text Then
                bet.amount *= 36
                playermoney += bet.amount
            End If
            If bet.placedbet = colors Then
                bet.amount *= 2
                playermoney += bet.amount
            End If
            If bet.placedbet = even Then
                bet.amount *= 2
                playermoney += bet.amount
            End If
            If bet.placedbet = row Then
                bet.amount *= 12
                playermoney += bet.amount
            End If

            Label3.Text = playermoney
        Next
        betarray.Clear()
        If playermoney <= 0 Then
            MessageBox.Show("you lose")
            Me.Close()
        End If
    End Sub
    Private Sub placebet(ByVal placedbet As String, ByVal amount As Integer)
        Dim obj As New Betobj
        obj.amount = amount
        obj.placedbet = placedbet
        betarray.Add(obj)
        ListBox1.Items.Clear()
        For Each bet As Betobj In betarray
            ListBox1.Items.Add(bet)
        Next
        playermoney -= obj.amount
        Label3.Text = playermoney
    End Sub
    Private Function getbetamount()
        Dim money As Integer
        If radbtn1.Checked = True Then
            money = 1
        End If
        If radbtn5.Checked = True Then
            money = 5
        End If
        If radbtn25.Checked = True Then
            money = 25
        End If
        If radbtn100.Checked = True Then
            money = 100

        End If
        If radbtn1000.Checked = True Then
            money = 1000
        End If
        If radbtnother.Checked = True Then
            money = txtother.Text
        End If
        If money > playermoney + 1 Then
            money = 0
            MessageBox.Show("you have insufficient funds")

        End If
        Return money
    End Function
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        placebet("9", getbetamount())
    End Sub

    Private Sub btnblack_Click(sender As Object, e As EventArgs) Handles btnblack.Click
        placebet("black", getbetamount())
    End Sub

    Private Sub btnodd_Click(sender As Object, e As EventArgs) Handles btnodd.Click
        placebet("odd", getbetamount())
    End Sub

    Private Sub btneven_Click(sender As Object, e As EventArgs) Handles btneven.Click
        placebet("even", getbetamount())
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        placebet("5", getbetamount())
    End Sub

    Private Sub btnred_Click(sender As Object, e As EventArgs) Handles btnred.Click
        placebet("red", getbetamount())
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        placebet("6", getbetamount())
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        placebet("3", getbetamount())
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        placebet("15", getbetamount())
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        placebet("11", getbetamount())
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        placebet("12", getbetamount())
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        placebet("8", getbetamount())
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        placebet("50", getbetamount())
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        placebet("23", getbetamount())
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        placebet("24", getbetamount())
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        placebet("18", getbetamount())
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        placebet("14", getbetamount())
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        placebet("17", getbetamount())
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        placebet("21", getbetamount())
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        placebet("20", getbetamount())
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        placebet("10", getbetamount())
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        placebet("13", getbetamount())
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        placebet("16", getbetamount())
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        placebet("19", getbetamount())
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        placebet("30", getbetamount())
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        placebet("25", getbetamount())
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        placebet("26", getbetamount())
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        placebet("27", getbetamount())
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        placebet("22", getbetamount())
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        placebet("34", getbetamount())
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        placebet("35", getbetamount())
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        placebet("36", getbetamount())
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        placebet("33", getbetamount())
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        placebet("32", getbetamount())
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        placebet("31", getbetamount())
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        placebet("28", getbetamount())
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        placebet("29", getbetamount())
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        placebet("0", getbetamount())
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        placebet("7", getbetamount())
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        placebet("4", getbetamount())
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        placebet("1", getbetamount())
    End Sub

    Private Sub btnrow12_Click(sender As Object, e As EventArgs) Handles btnrow12.Click
        placebet("row 12", getbetamount())
    End Sub

    Private Sub btnrow11_Click(sender As Object, e As EventArgs) Handles btnrow11.Click
        placebet("row 11", getbetamount())
    End Sub

    Private Sub btnrow10_Click(sender As Object, e As EventArgs) Handles btnrow10.Click
        placebet("row 10", getbetamount())
    End Sub

    Private Sub btnrow9_Click(sender As Object, e As EventArgs) Handles btnrow9.Click
        placebet("row 9", getbetamount())
    End Sub

    Private Sub btnrow8_Click(sender As Object, e As EventArgs) Handles btnrow8.Click
        placebet("row 8", getbetamount())
    End Sub

    Private Sub btnrow7_Click(sender As Object, e As EventArgs) Handles btnrow7.Click
        placebet("row 7", getbetamount())
    End Sub

    Private Sub btnrow6_Click(sender As Object, e As EventArgs) Handles btnrow6.Click
        placebet("row 6", getbetamount())
    End Sub

    Private Sub btnrow5_Click(sender As Object, e As EventArgs) Handles btnrow5.Click
        placebet("row 5", getbetamount())
    End Sub

    Private Sub btnrow4_Click(sender As Object, e As EventArgs) Handles btnrow4.Click
        placebet("row 4", getbetamount())
    End Sub

    Private Sub btnrow3_Click(sender As Object, e As EventArgs) Handles btnrow3.Click
        placebet("row 3", getbetamount())
    End Sub

    Private Sub btnrow2_Click(sender As Object, e As EventArgs) Handles btnrow2.Click
        placebet("row 2", getbetamount())
    End Sub

    Private Sub btnrow1_Click(sender As Object, e As EventArgs) Handles btnrow1.Click
        placebet("row 1", getbetamount())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playermoney = 5000
        Label3.Text = playermoney
    End Sub


End Class
