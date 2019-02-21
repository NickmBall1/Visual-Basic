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
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.txtsecond = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnsubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(237, 55)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(100, 20)
        Me.txtfirst.TabIndex = 0
        '
        'txtsecond
        '
        Me.txtsecond.Location = New System.Drawing.Point(255, 118)
        Me.txtsecond.Name = "txtsecond"
        Me.txtsecond.Size = New System.Drawing.Size(100, 20)
        Me.txtsecond.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Choose A Mathematical Operation"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(140, 205)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnsubtract
        '
        Me.btnsubtract.Location = New System.Drawing.Point(226, 205)
        Me.btnsubtract.Name = "btnsubtract"
        Me.btnsubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnsubtract.TabIndex = 6
        Me.btnsubtract.Text = "Subtract"
        Me.btnsubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(140, 234)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btndivide
        '
        Me.btndivide.Location = New System.Drawing.Point(226, 234)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(75, 23)
        Me.btndivide.TabIndex = 8
        Me.btndivide.Text = "Divide"
        Me.btndivide.UseVisualStyleBackColor = True
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(175, 313)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 432)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnsubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsecond)
        Me.Controls.Add(Me.txtfirst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfirst As TextBox
    Friend WithEvents txtsecond As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnsubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents lblanswer As Label
End Class
