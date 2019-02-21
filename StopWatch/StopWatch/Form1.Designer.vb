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
        Me.components = New System.ComponentModel.Container()
        Me.lblminutes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblseconds = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhundredth = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblminutes
        '
        Me.lblminutes.AutoSize = True
        Me.lblminutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblminutes.Location = New System.Drawing.Point(95, 171)
        Me.lblminutes.Name = "lblminutes"
        Me.lblminutes.Size = New System.Drawing.Size(23, 25)
        Me.lblminutes.TabIndex = 0
        Me.lblminutes.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(124, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'lblseconds
        '
        Me.lblseconds.AutoSize = True
        Me.lblseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblseconds.Location = New System.Drawing.Point(148, 171)
        Me.lblseconds.Name = "lblseconds"
        Me.lblseconds.Size = New System.Drawing.Size(23, 25)
        Me.lblseconds.TabIndex = 2
        Me.lblseconds.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(177, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "."
        '
        'lblhundredth
        '
        Me.lblhundredth.AutoSize = True
        Me.lblhundredth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblhundredth.Location = New System.Drawing.Point(200, 171)
        Me.lblhundredth.Name = "lblhundredth"
        Me.lblhundredth.Size = New System.Drawing.Size(23, 25)
        Me.lblhundredth.TabIndex = 4
        Me.lblhundredth.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(67, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Start/Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(223, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 46)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 472)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblhundredth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblseconds)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblminutes)
        Me.Name = "Form1"
        Me.Text = ":"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblminutes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblseconds As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblhundredth As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
