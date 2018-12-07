<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lbllast = New System.Windows.Forms.Label()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(526, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadContactsToolStripMenuItem, Me.SaveContactsToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadContactsToolStripMenuItem
        '
        Me.LoadContactsToolStripMenuItem.Name = "LoadContactsToolStripMenuItem"
        Me.LoadContactsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadContactsToolStripMenuItem.Text = "Load Contacts"
        '
        'SaveContactsToolStripMenuItem
        '
        Me.SaveContactsToolStripMenuItem.Name = "SaveContactsToolStripMenuItem"
        Me.SaveContactsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveContactsToolStripMenuItem.Text = "Save Contacts"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(502, 436)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btndelete)
        Me.TabPage1.Controls.Add(Me.lbladdress)
        Me.TabPage1.Controls.Add(Me.lblemail)
        Me.TabPage1.Controls.Add(Me.lblphone)
        Me.TabPage1.Controls.Add(Me.lbllast)
        Me.TabPage1.Controls.Add(Me.lblfirst)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(494, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Contacts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(252, 159)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(0, 13)
        Me.lbladdress.TabIndex = 10
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(252, 133)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(0, 13)
        Me.lblemail.TabIndex = 9
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(252, 107)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(0, 13)
        Me.lblphone.TabIndex = 8
        '
        'lbllast
        '
        Me.lbllast.AutoSize = True
        Me.lbllast.Location = New System.Drawing.Point(252, 81)
        Me.lbllast.Name = "lbllast"
        Me.lbllast.Size = New System.Drawing.Size(0, 13)
        Me.lbllast.TabIndex = 7
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Location = New System.Drawing.Point(252, 55)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(0, 13)
        Me.lblfirst.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Phone#:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(185, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "First Name:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(141, 342)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCreate)
        Me.TabPage2.Controls.Add(Me.txtaddress)
        Me.TabPage2.Controls.Add(Me.txtemail)
        Me.TabPage2.Controls.Add(Me.txtphone)
        Me.TabPage2.Controls.Add(Me.txtlast)
        Me.TabPage2.Controls.Add(Me.txtfirst)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(494, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Create Contact"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(200, 323)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Add Contact"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(281, 275)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(100, 20)
        Me.txtaddress.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(281, 223)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 8
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(281, 171)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(100, 20)
        Me.txtphone.TabIndex = 7
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(281, 119)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(100, 20)
        Me.txtlast.TabIndex = 6
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(281, 67)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(100, 20)
        Me.txtfirst.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone #:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(188, 210)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete Contact"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 475)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lbllast As Label
    Friend WithEvents lblfirst As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btndelete As Button
End Class
