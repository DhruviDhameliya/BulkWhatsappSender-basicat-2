<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.FaceBookPictureBox = New System.Windows.Forms.PictureBox()
        Me.WhatsAppPictureBox = New System.Windows.Forms.PictureBox()
        Me.WebSiteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.EmailPictureBox = New System.Windows.Forms.PictureBox()
        Me.TwitterPictureBox = New System.Windows.Forms.PictureBox()
        Me.InstagramPictureBox = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.BuildLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaceBookPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhatsAppPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwitterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstagramPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OkButton.Location = New System.Drawing.Point(143, 258)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(150, 28)
        Me.OkButton.TabIndex = 3
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'FaceBookPictureBox
        '
        Me.FaceBookPictureBox.Image = CType(resources.GetObject("FaceBookPictureBox.Image"), System.Drawing.Image)
        Me.FaceBookPictureBox.Location = New System.Drawing.Point(95, 3)
        Me.FaceBookPictureBox.Name = "FaceBookPictureBox"
        Me.FaceBookPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.FaceBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FaceBookPictureBox.TabIndex = 4
        Me.FaceBookPictureBox.TabStop = False
        '
        'WhatsAppPictureBox
        '
        Me.WhatsAppPictureBox.Image = CType(resources.GetObject("WhatsAppPictureBox.Image"), System.Drawing.Image)
        Me.WhatsAppPictureBox.Location = New System.Drawing.Point(49, 3)
        Me.WhatsAppPictureBox.Name = "WhatsAppPictureBox"
        Me.WhatsAppPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.WhatsAppPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WhatsAppPictureBox.TabIndex = 6
        Me.WhatsAppPictureBox.TabStop = False
        '
        'WebSiteLinkLabel
        '
        Me.WebSiteLinkLabel.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.WebSiteLinkLabel.Location = New System.Drawing.Point(13, 228)
        Me.WebSiteLinkLabel.Name = "WebSiteLinkLabel"
        Me.WebSiteLinkLabel.Size = New System.Drawing.Size(413, 20)
        Me.WebSiteLinkLabel.TabIndex = 9
        Me.WebSiteLinkLabel.TabStop = True
        Me.WebSiteLinkLabel.Text = "{{Website}}"
        Me.WebSiteLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailPictureBox
        '
        Me.EmailPictureBox.Image = CType(resources.GetObject("EmailPictureBox.Image"), System.Drawing.Image)
        Me.EmailPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.EmailPictureBox.Name = "EmailPictureBox"
        Me.EmailPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.EmailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.EmailPictureBox.TabIndex = 10
        Me.EmailPictureBox.TabStop = False
        '
        'TwitterPictureBox
        '
        Me.TwitterPictureBox.Image = CType(resources.GetObject("TwitterPictureBox.Image"), System.Drawing.Image)
        Me.TwitterPictureBox.Location = New System.Drawing.Point(141, 3)
        Me.TwitterPictureBox.Name = "TwitterPictureBox"
        Me.TwitterPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.TwitterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.TwitterPictureBox.TabIndex = 12
        Me.TwitterPictureBox.TabStop = False
        '
        'InstagramPictureBox
        '
        Me.InstagramPictureBox.Image = CType(resources.GetObject("InstagramPictureBox.Image"), System.Drawing.Image)
        Me.InstagramPictureBox.Location = New System.Drawing.Point(187, 3)
        Me.InstagramPictureBox.Name = "InstagramPictureBox"
        Me.InstagramPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.InstagramPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.InstagramPictureBox.TabIndex = 13
        Me.InstagramPictureBox.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.EmailPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.WhatsAppPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.FaceBookPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.TwitterPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.InstagramPictureBox)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 345)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(414, 47)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contact && Follow Us"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameLabel.Location = New System.Drawing.Point(13, 109)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(413, 19)
        Me.ProductNameLabel.TabIndex = 16
        Me.ProductNameLabel.Text = "{{ProductName}}"
        Me.ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNameLabel.Location = New System.Drawing.Point(13, 131)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(413, 19)
        Me.CompanyNameLabel.TabIndex = 17
        Me.CompanyNameLabel.Text = "{{CompanyName}}"
        Me.CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VersionLabel
        '
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(13, 171)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(413, 19)
        Me.VersionLabel.TabIndex = 18
        Me.VersionLabel.Text = "{{Version}}"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuildLabel
        '
        Me.BuildLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildLabel.Location = New System.Drawing.Point(13, 193)
        Me.BuildLabel.Name = "BuildLabel"
        Me.BuildLabel.Size = New System.Drawing.Size(413, 19)
        Me.BuildLabel.TabIndex = 19
        Me.BuildLabel.Text = "{{Build}}"
        Me.BuildLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAbout
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OkButton
        Me.ClientSize = New System.Drawing.Size(438, 404)
        Me.Controls.Add(Me.BuildLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.WebSiteLinkLabel)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaceBookPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhatsAppPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwitterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstagramPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OkButton As Button
    Friend WithEvents FaceBookPictureBox As PictureBox
    Friend WithEvents WhatsAppPictureBox As PictureBox
    Friend WithEvents WebSiteLinkLabel As LinkLabel
    Friend WithEvents EmailPictureBox As PictureBox
    Friend WithEvents TwitterPictureBox As PictureBox
    Friend WithEvents InstagramPictureBox As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents CompanyNameLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents BuildLabel As Label
End Class
