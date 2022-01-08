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
        Me.tabPrinter = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.txtHeader1 = New System.Windows.Forms.TextBox()
        Me.txtHeader2 = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.txtHeader3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFooter1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFooter2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabSetting.SuspendLayout()
        Me.tabNota.SuspendLayout()
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
        Me.tabSetting.Size = New System.Drawing.Size(461, 190)
        Me.tabSetting.TabIndex = 1
        '
        'tabNota
        '
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
        Me.tabNota.Size = New System.Drawing.Size(453, 164)
        Me.tabNota.TabIndex = 0
        Me.tabNota.Text = "Nota Penjualan"
        Me.tabNota.UseVisualStyleBackColor = True
        '
        'tabPrinter
        '
        Me.tabPrinter.Controls.Add(Me.Label5)
        Me.tabPrinter.Controls.Add(Me.ComboBox1)
        Me.tabPrinter.Location = New System.Drawing.Point(4, 22)
        Me.tabPrinter.Name = "tabPrinter"
        Me.tabPrinter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrinter.Size = New System.Drawing.Size(453, 164)
        Me.tabPrinter.TabIndex = 1
        Me.tabPrinter.Text = "Printer"
        Me.tabPrinter.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 35)
        Me.Panel1.TabIndex = 119
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
        'txtHeader1
        '
        Me.txtHeader1.Location = New System.Drawing.Point(160, 22)
        Me.txtHeader1.Multiline = True
        Me.txtHeader1.Name = "txtHeader1"
        Me.txtHeader1.Size = New System.Drawing.Size(276, 19)
        Me.txtHeader1.TabIndex = 125
        '
        'txtHeader2
        '
        Me.txtHeader2.Location = New System.Drawing.Point(160, 47)
        Me.txtHeader2.Multiline = True
        Me.txtHeader2.Name = "txtHeader2"
        Me.txtHeader2.Size = New System.Drawing.Size(276, 19)
        Me.txtHeader2.TabIndex = 126
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(265, 21)
        Me.ComboBox1.TabIndex = 0
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
        'PengaturanUmumFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 273)
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
End Class
