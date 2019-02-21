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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.Lblmake = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save Car"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(190, 109)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(100, 20)
        Me.txtmake.TabIndex = 3
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(190, 135)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(100, 20)
        Me.txtmodel.TabIndex = 4
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(190, 161)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(100, 20)
        Me.txtyear.TabIndex = 5
        '
        'Lblmake
        '
        Me.Lblmake.AutoSize = True
        Me.Lblmake.Location = New System.Drawing.Point(145, 112)
        Me.Lblmake.Name = "Lblmake"
        Me.Lblmake.Size = New System.Drawing.Size(34, 13)
        Me.Lblmake.TabIndex = 6
        Me.Lblmake.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Color"
        '
        'txtcolor
        '
        Me.txtcolor.Location = New System.Drawing.Point(190, 187)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(100, 20)
        Me.txtcolor.TabIndex = 10
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(190, 213)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(100, 20)
        Me.txtmileage.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mileage"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(449, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 329)
        Me.ListBox1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 484)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblmake)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtmake As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents Lblmake As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
