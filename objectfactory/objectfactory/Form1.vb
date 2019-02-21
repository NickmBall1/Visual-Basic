Public Class Form1
    Dim cararray As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objnewcar As New Automobile
        objnewcar.make = txtmake.Text
        objnewcar.model = txtmodel.Text
        objnewcar.color = txtcolor.Text
        objnewcar.year = txtyear.Text
        objnewcar.mileage = txtmileage.Text
        cararray.Add(objnewcar)
        ListBox1.Items.Add(objnewcar.year & " " & objnewcar.make & " " & objnewcar.model)

    End Sub
End Class
