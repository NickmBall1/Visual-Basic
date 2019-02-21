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
        Me.btncomp = New System.Windows.Forms.Button()
        Me.btnplayer = New System.Windows.Forms.Button()
        Me.btnball = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncomp
        '
        Me.btncomp.Location = New System.Drawing.Point(12, 79)
        Me.btncomp.Name = "btncomp"
        Me.btncomp.Size = New System.Drawing.Size(12, 100)
        Me.btncomp.TabIndex = 0
        Me.btncomp.UseVisualStyleBackColor = True
        '
        'btnplayer
        '
        Me.btnplayer.Location = New System.Drawing.Point(638, 90)
        Me.btnplayer.Name = "btnplayer"
        Me.btnplayer.Size = New System.Drawing.Size(12, 100)
        Me.btnplayer.TabIndex = 1
        Me.btnplayer.UseVisualStyleBackColor = True
        '
        'btnball
        '
        Me.btnball.Location = New System.Drawing.Point(288, 255)
        Me.btnball.Name = "btnball"
        Me.btnball.Size = New System.Drawing.Size(14, 14)
        Me.btnball.TabIndex = 2
        Me.btnball.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(253, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 39)
        Me.Label1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(662, 565)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnball)
        Me.Controls.Add(Me.btnplayer)
        Me.Controls.Add(Me.btncomp)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncomp As Button
    Friend WithEvents btnplayer As Button
    Friend WithEvents btnball As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
