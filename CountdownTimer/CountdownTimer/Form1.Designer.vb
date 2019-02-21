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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblseconds = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudSeconds = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblminutes
        '
        Me.lblminutes.AutoSize = True
        Me.lblminutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblminutes.Location = New System.Drawing.Point(103, 117)
        Me.lblminutes.Name = "lblminutes"
        Me.lblminutes.Size = New System.Drawing.Size(23, 25)
        Me.lblminutes.TabIndex = 0
        Me.lblminutes.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblseconds
        '
        Me.lblseconds.AutoSize = True
        Me.lblseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblseconds.Location = New System.Drawing.Point(156, 117)
        Me.lblseconds.Name = "lblseconds"
        Me.lblseconds.Size = New System.Drawing.Size(23, 25)
        Me.lblseconds.TabIndex = 1
        Me.lblseconds.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'nudSeconds
        '
        Me.nudSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.nudSeconds.Location = New System.Drawing.Point(161, 220)
        Me.nudSeconds.Name = "nudSeconds"
        Me.nudSeconds.Size = New System.Drawing.Size(47, 30)
        Me.nudSeconds.TabIndex = 3
        '
        'nudMinutes
        '
        Me.nudMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.nudMinutes.Location = New System.Drawing.Point(161, 184)
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(47, 30)
        Me.nudMinutes.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(74, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minutes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(65, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seconds"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(70, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudMinutes)
        Me.Controls.Add(Me.nudSeconds)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblseconds)
        Me.Controls.Add(Me.lblminutes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblminutes As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblseconds As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudSeconds As NumericUpDown
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
