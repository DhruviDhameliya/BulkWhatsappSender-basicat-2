<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLicense
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
        Me.requestkeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.licensekeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.licensestatusLabel = New System.Windows.Forms.Label()
        Me.activateButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.copyButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'requestkeyTextBox
        '
        Me.requestkeyTextBox.Location = New System.Drawing.Point(12, 88)
        Me.requestkeyTextBox.Multiline = True
        Me.requestkeyTextBox.Name = "requestkeyTextBox"
        Me.requestkeyTextBox.ReadOnly = True
        Me.requestkeyTextBox.Size = New System.Drawing.Size(430, 22)
        Me.requestkeyTextBox.TabIndex = 0
        Me.requestkeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.requestkeyTextBox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Number"
        Me.Label1.Visible = False
        '
        'licensekeyTextBox
        '
        Me.licensekeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.licensekeyTextBox.Location = New System.Drawing.Point(12, 185)
        Me.licensekeyTextBox.Multiline = True
        Me.licensekeyTextBox.Name = "licensekeyTextBox"
        Me.licensekeyTextBox.Size = New System.Drawing.Size(430, 56)
        Me.licensekeyTextBox.TabIndex = 3
        Me.licensekeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.licensekeyTextBox.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "License Number"
        Me.Label3.Visible = False
        '
        'licensestatusLabel
        '
        Me.licensestatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.licensestatusLabel.Location = New System.Drawing.Point(12, 248)
        Me.licensestatusLabel.Name = "licensestatusLabel"
        Me.licensestatusLabel.Size = New System.Drawing.Size(430, 24)
        Me.licensestatusLabel.TabIndex = 5
        Me.licensestatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.licensestatusLabel.Visible = False
        '
        'activateButton
        '
        Me.activateButton.Location = New System.Drawing.Point(340, 284)
        Me.activateButton.Name = "activateButton"
        Me.activateButton.Size = New System.Drawing.Size(102, 26)
        Me.activateButton.TabIndex = 6
        Me.activateButton.Text = "Activate"
        Me.activateButton.UseVisualStyleBackColor = True
        Me.activateButton.Visible = False
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(232, 284)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(102, 26)
        Me.cancelButton.TabIndex = 7
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        Me.cancelButton.Visible = False
        '
        'copyButton
        '
        Me.copyButton.Location = New System.Drawing.Point(308, 140)
        Me.copyButton.Name = "copyButton"
        Me.copyButton.Size = New System.Drawing.Size(66, 24)
        Me.copyButton.TabIndex = 8
        Me.copyButton.Text = "Copy"
        Me.copyButton.UseVisualStyleBackColor = True
        Me.copyButton.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Send This Order Number Through Whatsapp At +91 99132 99862 Or  +91 99132 99806"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(280, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Generate Order Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Please Enter Your Mobile Number With Country Code"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(380, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 24)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(10, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 14
        '
        'FrmLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 320)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.copyButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.activateButton)
        Me.Controls.Add(Me.licensestatusLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.licensekeyTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.requestkeyTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLicense"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activate Application"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents requestkeyTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents licensekeyTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents licensestatusLabel As Label
    Friend WithEvents activateButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents copyButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
End Class
