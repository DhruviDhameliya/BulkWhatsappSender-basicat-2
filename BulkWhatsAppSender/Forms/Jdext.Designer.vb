<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jdext
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jdext))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblNumbers = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LstNumbers = New System.Windows.Forms.ListView()
        Me.ClnNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LblNumbers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(493, 38)
        Me.Panel3.TabIndex = 79
        '
        'LblNumbers
        '
        Me.LblNumbers.AutoSize = True
        Me.LblNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblNumbers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumbers.ForeColor = System.Drawing.Color.White
        Me.LblNumbers.Location = New System.Drawing.Point(8, 8)
        Me.LblNumbers.Name = "LblNumbers"
        Me.LblNumbers.Size = New System.Drawing.Size(122, 20)
        Me.LblNumbers.TabIndex = 1
        Me.LblNumbers.Text = "Just Dial Extractor"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(419, 353)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(66, 61)
        Me.Button12.TabIndex = 89
        Me.Button12.Text = "Clear"
        Me.Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button12.UseVisualStyleBackColor = False
        Me.Button12.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(267, 101)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 34)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Add To List"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(153, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 34)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'LstNumbers
        '
        Me.LstNumbers.BackColor = System.Drawing.Color.White
        Me.LstNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClnNumber, Me.ColumnHeader2})
        Me.LstNumbers.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstNumbers.FullRowSelect = True
        Me.LstNumbers.GridLines = True
        Me.LstNumbers.HideSelection = False
        Me.LstNumbers.Location = New System.Drawing.Point(3, 157)
        Me.LstNumbers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstNumbers.Name = "LstNumbers"
        Me.LstNumbers.Size = New System.Drawing.Size(408, 329)
        Me.LstNumbers.TabIndex = 83
        Me.LstNumbers.UseCompatibleStateImageBehavior = False
        Me.LstNumbers.View = System.Windows.Forms.View.Details
        '
        'ClnNumber
        '
        Me.ClnNumber.Text = "Name"
        Me.ClnNumber.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Number"
        Me.ColumnHeader2.Width = 115
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(419, 422)
        Me.Button11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(66, 61)
        Me.Button11.TabIndex = 86
        Me.Button11.Text = "Exports"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button11.UseVisualStyleBackColor = False
        Me.Button11.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Write URL: ex. https://www.justdial.com/Surat/search?q=trueline-solution"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 101)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 34)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Start Extracting"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(470, 20)
        Me.TextBox1.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "You can extract number while place is open"
        '
        'Jdext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LstNumbers)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Jdext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Just Dial Extractor"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblNumbers As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LstNumbers As ListView
    Friend WithEvents ClnNumber As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button11 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
