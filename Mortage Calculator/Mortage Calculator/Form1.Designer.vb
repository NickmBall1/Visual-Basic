<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDown = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.rad15 = New System.Windows.Forms.RadioButton()
        Me.rad20 = New System.Windows.Forms.RadioButton()
        Me.rad30 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotalinterest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Purchase Price"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Down Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Interest Rate"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(108, 26)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtDown
        '
        Me.txtDown.Location = New System.Drawing.Point(108, 73)
        Me.txtDown.Name = "txtDown"
        Me.txtDown.Size = New System.Drawing.Size(100, 20)
        Me.txtDown.TabIndex = 5
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(93, 115)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtInterest.TabIndex = 6
        '
        'rad15
        '
        Me.rad15.AutoSize = True
        Me.rad15.Location = New System.Drawing.Point(54, 207)
        Me.rad15.Name = "rad15"
        Me.rad15.Size = New System.Drawing.Size(67, 17)
        Me.rad15.TabIndex = 7
        Me.rad15.TabStop = True
        Me.rad15.Text = "15 Years"
        Me.rad15.UseVisualStyleBackColor = True
        '
        'rad20
        '
        Me.rad20.AutoSize = True
        Me.rad20.Location = New System.Drawing.Point(54, 230)
        Me.rad20.Name = "rad20"
        Me.rad20.Size = New System.Drawing.Size(67, 17)
        Me.rad20.TabIndex = 8
        Me.rad20.TabStop = True
        Me.rad20.Text = "20 Years"
        Me.rad20.UseVisualStyleBackColor = True
        '
        'rad30
        '
        Me.rad30.AutoSize = True
        Me.rad30.Location = New System.Drawing.Point(54, 253)
        Me.rad30.Name = "rad30"
        Me.rad30.Size = New System.Drawing.Size(67, 17)
        Me.rad30.TabIndex = 9
        Me.rad30.TabStop = True
        Me.rad30.Text = "30 Years"
        Me.rad30.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Length of Loan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Location = New System.Drawing.Point(222, 332)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(39, 13)
        Me.lblpayment.TabIndex = 12
        Me.lblpayment.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label7"
        '
        'lbltotalinterest
        '
        Me.lbltotalinterest.AutoSize = True
        Me.lbltotalinterest.Location = New System.Drawing.Point(222, 361)
        Me.lbltotalinterest.Name = "lbltotalinterest"
        Me.lbltotalinterest.Size = New System.Drawing.Size(39, 13)
        Me.lbltotalinterest.TabIndex = 14
        Me.lbltotalinterest.Text = "Label8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 424)
        Me.Controls.Add(Me.lbltotalinterest)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblpayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rad30)
        Me.Controls.Add(Me.rad20)
        Me.Controls.Add(Me.rad15)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtDown)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDown As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents rad15 As RadioButton
    Friend WithEvents rad20 As RadioButton
    Friend WithEvents rad30 As RadioButton


    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblpayment As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltotalinterest As Label
End Class

