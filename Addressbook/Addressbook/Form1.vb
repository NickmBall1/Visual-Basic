Imports System.IO
Public Class Form1
    Dim contactarray As New ArrayList
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim objnewcontact As New Contact
        objnewcontact.first = txtfirst.Text
        objnewcontact.last = txtlast.Text
        objnewcontact.phone = txtphone.Text
        objnewcontact.email = txtemail.Text
        objnewcontact.address = txtaddress.Text
        contactarray.Add(objnewcontact)
        txtfirst.Text = ""
        txtlast.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""
        txtaddress.Text = ""
        refreshlist()
    End Sub
    Private Sub refreshlist()
        ListBox1.Items.Clear()
        For Each person As Contact In contactarray
            ListBox1.Items.Add(person)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim slot As Integer
        slot = ListBox1.SelectedIndex
        lblfirst.Text = contactarray(slot).first
        lbllast.Text = contactarray(slot).last
        lblphone.Text = contactarray(slot).phone
        lblemail.Text = contactarray(slot).email
        lbladdress.Text = contactarray(slot).address
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub SaveContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveContactsToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim objfile As New StreamWriter(SaveFileDialog1.FileName)
        For Each item As Contact In contactarray
            objfile.WriteLine(item.first)
            objfile.WriteLine(item.last)
            objfile.WriteLine(item.phone)
            objfile.WriteLine(item.email)
            objfile.WriteLine(item.address)
        Next
        objfile.Close()
        objfile.Dispose()
    End Sub
    Private Sub LoadContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadContactsToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim objfile As New StreamReader(OpenFileDialog1.FileName)
        Do Until objfile.Peek = -1
            Dim objnewcontact As New Contact
            objnewcontact.first = objfile.ReadLine()
            objnewcontact.last = objfile.ReadLine()
            objnewcontact.phone = objfile.ReadLine()
            objnewcontact.email = objfile.ReadLine()
            objnewcontact.address = objfile.ReadLine()

            contactarray.Add(objnewcontact)
        Loop

        objfile.Close()
        objfile.Dispose()
        For Each item As Contact In contactarray
            ListBox1.Items.Add(item)
        Next
        refreshlist()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim itemnumber As Integer
        itemnumber = ListBox1.SelectedIndex
        contactarray.RemoveAt(itemnumber)
        refreshlist()
    End Sub
End Class
