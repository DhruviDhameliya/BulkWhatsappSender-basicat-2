<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblBuidDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.ForeColor = System.Drawing.Color.Black
        Me.LblVersion.Location = New System.Drawing.Point(218, 5)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(57, 13)
        Me.LblVersion.TabIndex = 0
        Me.LblVersion.Text = "{{version}}"
        '
        'LblBuidDate
        '
        Me.LblBuidDate.AutoSize = True
        Me.LblBuidDate.BackColor = System.Drawing.Color.Transparent
        Me.LblBuidDate.ForeColor = System.Drawing.Color.Black
        Me.LblBuidDate.Location = New System.Drawing.Point(281, 5)
        Me.LblBuidDate.Name = "LblBuidDate"
        Me.LblBuidDate.Size = New System.Drawing.Size(69, 13)
        Me.LblBuidDate.TabIndex = 1
        Me.LblBuidDate.Text = "{{BuildDate}}"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(244, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loading API...."
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(602, 357)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblBuidDate)
        Me.Controls.Add(Me.LblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblBuidDate As Label
    Friend WithEvents Label1 As Label
End Class
