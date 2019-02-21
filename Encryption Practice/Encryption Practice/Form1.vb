Public Class Form1
    Dim strChar As String
    Dim intAscII As Integer
    Dim strchar2 As String
    Dim key As Integer
    Dim why As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnencode_Click(sender As Object, e As EventArgs) Handles btnencode.Click
        strChar = rtbmessage.Text


        key = TextBox1.Text
        For index = 0 To strChar.Length - 1
            intAscII = Asc(strChar.Chars(index))
            intAscII += key
            If intAscII > 126 Then
                intAscII -= 94
            End If
            strchar2 += Chr(intAscII)
        Next
        rtbdecode.Text = strchar2
    End Sub

    Private Sub btndecode_Click(sender As Object, e As EventArgs) Handles btndecode.Click
        strchar2 = rtbdecode.Text


        key = TextBox1.Text
        For index = 0 To strchar2.Length - 1
            why = Asc(strchar2.Chars(index))
            why -= key
            If why < 32 Then
                why += 94
            End If
            strChar += Chr(why)
        Next
        rtbmessage.Text = strChar
    End Sub


End Class
