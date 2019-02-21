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
        Me.txtChar = New System.Windows.Forms.TextBox()
        Me.txtASCII = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChar
        '
        Me.txtChar.Location = New System.Drawing.Point(12, 12)
        Me.txtChar.Name = "txtChar"
        Me.txtChar.Size = New System.Drawing.Size(264, 20)
        Me.txtChar.TabIndex = 0
        '
        'txtASCII
        '
        Me.txtASCII.Location = New System.Drawing.Point(282, 12)
        Me.txtASCII.Name = "txtASCII"
        Me.txtASCII.Size = New System.Drawing.Size(282, 20)
        Me.txtASCII.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Change to Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(221, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Change to Character"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 443)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtASCII)
        Me.Controls.Add(Me.txtChar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChar As TextBox
    Friend WithEvents txtASCII As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
