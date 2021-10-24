<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTokoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditTokoFrm))
        Me.dtTanggalBuka = New System.Windows.Forms.DateTimePicker()
        Me.txtKotaToko = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaToko = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlamatToko = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdToko = New System.Windows.Forms.TextBox()
        Me.txtTeleponToko = New System.Windows.Forms.TextBox()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTanggalBuka
        '
        Me.dtTanggalBuka.Location = New System.Drawing.Point(139, 199)
        Me.dtTanggalBuka.Name = "dtTanggalBuka"
        Me.dtTanggalBuka.Size = New System.Drawing.Size(200, 20)
        Me.dtTanggalBuka.TabIndex = 100
        '
        'txtKotaToko
        '
        Me.txtKotaToko.Location = New System.Drawing.Point(134, 171)
        Me.txtKotaToko.MaxLength = 25
        Me.txtKotaToko.Name = "txtKotaToko"
        Me.txtKotaToko.Size = New System.Drawing.Size(290, 20)
        Me.txtKotaToko.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(3, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Kota"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaToko
        '
        Me.txtNamaToko.Location = New System.Drawing.Point(135, 76)
        Me.txtNamaToko.MaxLength = 25
        Me.txtNamaToko.Name = "txtNamaToko"
        Me.txtNamaToko.Size = New System.Drawing.Size(290, 20)
        Me.txtNamaToko.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(4, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Nama Toko"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlHeader.Size = New System.Drawing.Size(421, 35)
        Me.pnlHeader.TabIndex = 88
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(110, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Edit Data Toko"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 35)
        Me.Panel1.TabIndex = 89
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(259, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(340, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 4
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(4, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Tanggal Buka"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(4, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Telepon"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlamatToko
        '
        Me.txtAlamatToko.Location = New System.Drawing.Point(135, 103)
        Me.txtAlamatToko.MaxLength = 25
        Me.txtAlamatToko.Multiline = True
        Me.txtAlamatToko.Name = "txtAlamatToko"
        Me.txtAlamatToko.Size = New System.Drawing.Size(290, 60)
        Me.txtAlamatToko.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Alamat Toko"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(4, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Toko"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdToko
        '
        Me.txtIdToko.Location = New System.Drawing.Point(139, 43)
        Me.txtIdToko.MaxLength = 6
        Me.txtIdToko.Name = "txtIdToko"
        Me.txtIdToko.ReadOnly = True
        Me.txtIdToko.Size = New System.Drawing.Size(119, 20)
        Me.txtIdToko.TabIndex = 87
        '
        'txtTeleponToko
        '
        Me.txtTeleponToko.Location = New System.Drawing.Point(135, 227)
        Me.txtTeleponToko.MaxLength = 25
        Me.txtTeleponToko.Name = "txtTeleponToko"
        Me.txtTeleponToko.Size = New System.Drawing.Size(290, 20)
        Me.txtTeleponToko.TabIndex = 93
        '
        'EditTokoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 291)
        Me.Controls.Add(Me.dtTanggalBuka)
        Me.Controls.Add(Me.txtKotaToko)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaToko)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlamatToko)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdToko)
        Me.Controls.Add(Me.txtTeleponToko)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditTokoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtTanggalBuka As DateTimePicker
    Friend WithEvents txtKotaToko As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaToko As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlamatToko As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdToko As TextBox
    Friend WithEvents txtTeleponToko As TextBox
End Class
