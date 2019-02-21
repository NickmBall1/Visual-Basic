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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbmessage = New System.Windows.Forms.RichTextBox()
        Me.rtbdecode = New System.Windows.Forms.RichTextBox()
        Me.btnencode = New System.Windows.Forms.Button()
        Me.btndecode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Key"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Message"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Encoded"
        '
        'rtbmessage
        '
        Me.rtbmessage.Location = New System.Drawing.Point(59, 129)
        Me.rtbmessage.Name = "rtbmessage"
        Me.rtbmessage.Size = New System.Drawing.Size(217, 272)
        Me.rtbmessage.TabIndex = 4
        Me.rtbmessage.Text = ""
        '
        'rtbdecode
        '
        Me.rtbdecode.Location = New System.Drawing.Point(318, 129)
        Me.rtbdecode.Name = "rtbdecode"
        Me.rtbdecode.Size = New System.Drawing.Size(220, 272)
        Me.rtbdecode.TabIndex = 5
        Me.rtbdecode.Text = ""
        '
        'btnencode
        '
        Me.btnencode.Location = New System.Drawing.Point(123, 407)
        Me.btnencode.Name = "btnencode"
        Me.btnencode.Size = New System.Drawing.Size(75, 23)
        Me.btnencode.TabIndex = 6
        Me.btnencode.Text = "Encode"
        Me.btnencode.UseVisualStyleBackColor = True
        '
        'btndecode
        '
        Me.btndecode.Location = New System.Drawing.Point(386, 407)
        Me.btndecode.Name = "btndecode"
        Me.btndecode.Size = New System.Drawing.Size(75, 23)
        Me.btndecode.TabIndex = 7
        Me.btndecode.Text = "Decode"
        Me.btndecode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 462)
        Me.Controls.Add(Me.btndecode)
        Me.Controls.Add(Me.btnencode)
        Me.Controls.Add(Me.rtbdecode)
        Me.Controls.Add(Me.rtbmessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rtbmessage As RichTextBox
    Friend WithEvents rtbdecode As RichTextBox
    Friend WithEvents btnencode As Button
    Friend WithEvents btndecode As Button
End Class
