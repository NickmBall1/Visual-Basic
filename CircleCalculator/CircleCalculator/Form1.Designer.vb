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
        Me.Radbutton = New System.Windows.Forms.RadioButton()
        Me.DiaButton = New System.Windows.Forms.RadioButton()
        Me.CircumButton = New System.Windows.Forms.RadioButton()
        Me.AreaButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CalcCircle = New System.Windows.Forms.Button()
        Me.Radiuslbl = New System.Windows.Forms.Label()
        Me.Diameterlbl = New System.Windows.Forms.Label()
        Me.Circumferencelbl = New System.Windows.Forms.Label()
        Me.Arealbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Radbutton
        '
        Me.Radbutton.AutoSize = True
        Me.Radbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Radbutton.Location = New System.Drawing.Point(146, 147)
        Me.Radbutton.Name = "Radbutton"
        Me.Radbutton.Size = New System.Drawing.Size(86, 28)
        Me.Radbutton.TabIndex = 0
        Me.Radbutton.TabStop = True
        Me.Radbutton.Text = "Radius"
        Me.Radbutton.UseVisualStyleBackColor = True
        '
        'DiaButton
        '
        Me.DiaButton.AutoSize = True
        Me.DiaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.DiaButton.Location = New System.Drawing.Point(146, 170)
        Me.DiaButton.Name = "DiaButton"
        Me.DiaButton.Size = New System.Drawing.Size(103, 28)
        Me.DiaButton.TabIndex = 1
        Me.DiaButton.TabStop = True
        Me.DiaButton.Text = "Diameter"
        Me.DiaButton.UseVisualStyleBackColor = True
        '
        'CircumButton
        '
        Me.CircumButton.AutoSize = True
        Me.CircumButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CircumButton.Location = New System.Drawing.Point(146, 193)
        Me.CircumButton.Name = "CircumButton"
        Me.CircumButton.Size = New System.Drawing.Size(152, 28)
        Me.CircumButton.TabIndex = 2
        Me.CircumButton.TabStop = True
        Me.CircumButton.Text = "Circumference"
        Me.CircumButton.UseVisualStyleBackColor = True
        '
        'AreaButton
        '
        Me.AreaButton.AutoSize = True
        Me.AreaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.AreaButton.Location = New System.Drawing.Point(146, 216)
        Me.AreaButton.Name = "AreaButton"
        Me.AreaButton.Size = New System.Drawing.Size(68, 28)
        Me.AreaButton.TabIndex = 3
        Me.AreaButton.TabStop = True
        Me.AreaButton.Text = "Area"
        Me.AreaButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(146, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select the Attribute You Want"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(146, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the Value"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(175, 266)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.TextBox1.TabIndex = 6
        '
        'CalcCircle
        '
        Me.CalcCircle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.CalcCircle.Location = New System.Drawing.Point(68, 301)
        Me.CalcCircle.Name = "CalcCircle"
        Me.CalcCircle.Size = New System.Drawing.Size(287, 30)
        Me.CalcCircle.TabIndex = 7
        Me.CalcCircle.Text = "Calculate the Circle"
        Me.CalcCircle.UseVisualStyleBackColor = True
        '
        'Radiuslbl
        '
        Me.Radiuslbl.AutoSize = True
        Me.Radiuslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Radiuslbl.Location = New System.Drawing.Point(160, 375)
        Me.Radiuslbl.Name = "Radiuslbl"
        Me.Radiuslbl.Size = New System.Drawing.Size(0, 24)
        Me.Radiuslbl.TabIndex = 8
        '
        'Diameterlbl
        '
        Me.Diameterlbl.AutoSize = True
        Me.Diameterlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Diameterlbl.Location = New System.Drawing.Point(170, 399)
        Me.Diameterlbl.Name = "Diameterlbl"
        Me.Diameterlbl.Size = New System.Drawing.Size(0, 24)
        Me.Diameterlbl.TabIndex = 9
        '
        'Circumferencelbl
        '
        Me.Circumferencelbl.AutoSize = True
        Me.Circumferencelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Circumferencelbl.Location = New System.Drawing.Point(220, 423)
        Me.Circumferencelbl.Name = "Circumferencelbl"
        Me.Circumferencelbl.Size = New System.Drawing.Size(0, 24)
        Me.Circumferencelbl.TabIndex = 10
        '
        'Arealbl
        '
        Me.Arealbl.AutoSize = True
        Me.Arealbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Arealbl.Location = New System.Drawing.Point(136, 447)
        Me.Arealbl.Name = "Arealbl"
        Me.Arealbl.Size = New System.Drawing.Size(0, 24)
        Me.Arealbl.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(74, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Radius:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(74, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Diameter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(74, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Circumference:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(75, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Area:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 587)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Arealbl)
        Me.Controls.Add(Me.Circumferencelbl)
        Me.Controls.Add(Me.Diameterlbl)
        Me.Controls.Add(Me.Radiuslbl)
        Me.Controls.Add(Me.CalcCircle)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AreaButton)
        Me.Controls.Add(Me.CircumButton)
        Me.Controls.Add(Me.DiaButton)
        Me.Controls.Add(Me.Radbutton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Radbutton As RadioButton
    Friend WithEvents DiaButton As RadioButton
    Friend WithEvents CircumButton As RadioButton
    Friend WithEvents AreaButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CalcCircle As Button
    Friend WithEvents Radiuslbl As Label
    Friend WithEvents Diameterlbl As Label
    Friend WithEvents Circumferencelbl As Label
    Friend WithEvents Arealbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
