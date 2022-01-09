<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PengaturanUmumFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PengaturanUmumFrm))
        Me.tabSetting = New System.Windows.Forms.TabControl()
        Me.tabNota = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btGambar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFooter2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFooter1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeader3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHeader2 = New System.Windows.Forms.TextBox()
        Me.txtHeader1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabPrinter = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.tabSetting.SuspendLayout()
        Me.tabNota.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrinter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSetting
        '
        Me.tabSetting.Controls.Add(Me.tabNota)
        Me.tabSetting.Controls.Add(Me.tabPrinter)
        Me.tabSetting.Location = New System.Drawing.Point(4, 43)
        Me.tabSetting.Name = "tabSetting"
        Me.tabSetting.SelectedIndex = 0
        Me.tabSetting.Size = New System.Drawing.Size(461, 289)
        Me.tabSetting.TabIndex = 1
        '
        'tabNota
        '
        Me.tabNota.Controls.Add(Me.Label7)
        Me.tabNota.Controls.Add(Me.TextBox1)
        Me.tabNota.Controls.Add(Me.txtPath)
        Me.tabNota.Controls.Add(Me.btGambar)
        Me.tabNota.Controls.Add(Me.PictureBox1)
        Me.tabNota.Controls.Add(Me.txtFooter2)
        Me.tabNota.Controls.Add(Me.Label4)
        Me.tabNota.Controls.Add(Me.txtFooter1)
        Me.tabNota.Controls.Add(Me.Label2)
        Me.tabNota.Controls.Add(Me.txtHeader3)
        Me.tabNota.Controls.Add(Me.Label1)
        Me.tabNota.Controls.Add(Me.txtHeader2)
        Me.tabNota.Controls.Add(Me.txtHeader1)
        Me.tabNota.Controls.Add(Me.Label3)
        Me.tabNota.Controls.Add(Me.Label6)
        Me.tabNota.Location = New System.Drawing.Point(4, 22)
        Me.tabNota.Name = "tabNota"
        Me.tabNota.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNota.Size = New System.Drawing.Size(453, 263)
        Me.tabNota.TabIndex = 0
        Me.tabNota.Text = "Nota Penjualan"
        Me.tabNota.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "LOGO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 155)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 102)
        Me.TextBox1.TabIndex = 136
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(160, 177)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(195, 19)
        Me.txtPath.TabIndex = 135
        '
        'btGambar
        '
        Me.btGambar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btGambar.Location = New System.Drawing.Point(361, 173)
        Me.btGambar.Name = "btGambar"
        Me.btGambar.Size = New System.Drawing.Size(75, 27)
        Me.btGambar.TabIndex = 134
        Me.btGambar.Text = "Pilih Logo"
        Me.btGambar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 102)
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        '
        'txtFooter2
        '
        Me.txtFooter2.Location = New System.Drawing.Point(160, 122)
        Me.txtFooter2.Multiline = True
        Me.txtFooter2.Name = "txtFooter2"
        Me.txtFooter2.Size = New System.Drawing.Size(276, 19)
        Me.txtFooter2.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(14, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Footer 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFooter1
        '
        Me.txtFooter1.Location = New System.Drawing.Point(160, 97)
        Me.txtFooter1.Multiline = True
        Me.txtFooter1.Name = "txtFooter1"
        Me.txtFooter1.Size = New System.Drawing.Size(276, 19)
        Me.txtFooter1.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(14, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Footer 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHeader3
        '
        Me.txtHeader3.Location = New System.Drawing.Point(160, 72)
        Me.txtHeader3.Multiline = True
        Me.txtHeader3.Name = "txtHeader3"
        Me.txtHeader3.Size = New System.Drawing.Size(276, 19)
        Me.txtHeader3.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(14, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Header 3"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHeader2
        '
        Me.txtHeader2.Location = New System.Drawing.Point(160, 47)
        Me.txtHeader2.Multiline = True
        Me.txtHeader2.Name = "txtHeader2"
        Me.txtHeader2.Size = New System.Drawing.Size(276, 19)
        Me.txtHeader2.TabIndex = 126
        '
        'txtHeader1
        '
        Me.txtHeader1.Location = New System.Drawing.Point(160, 22)
        Me.txtHeader1.Multiline = True
        Me.txtHeader1.Name = "txtHeader1"
        Me.txtHeader1.Size = New System.Drawing.Size(276, 19)
        Me.txtHeader1.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Header 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(14, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Header 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabPrinter
        '
        Me.tabPrinter.Controls.Add(Me.Label5)
        Me.tabPrinter.Controls.Add(Me.ComboBox1)
        Me.tabPrinter.Location = New System.Drawing.Point(4, 22)
        Me.tabPrinter.Name = "tabPrinter"
        Me.tabPrinter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrinter.Size = New System.Drawing.Size(453, 263)
        Me.tabPrinter.TabIndex = 1
        Me.tabPrinter.Text = "Printer"
        Me.tabPrinter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Printer Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(265, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 35)
        Me.Panel1.TabIndex = 119
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(296, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 120
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(377, 4)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 121
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(138, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Pengaturan Umum"
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(4, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(461, 35)
        Me.pnlHeader.TabIndex = 118
        '
        'PengaturanUmumFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 371)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.tabSetting)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PengaturanUmumFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.tabSetting.ResumeLayout(False)
        Me.tabNota.ResumeLayout(False)
        Me.tabNota.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrinter.ResumeLayout(False)
        Me.tabPrinter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabSetting As TabControl
    Friend WithEvents tabNota As TabPage
    Friend WithEvents tabPrinter As TabPage
    Friend WithEvents txtHeader2 As TextBox
    Friend WithEvents txtHeader1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents txtFooter2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFooter1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeader3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtPath As TextBox
    Private WithEvents btGambar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
