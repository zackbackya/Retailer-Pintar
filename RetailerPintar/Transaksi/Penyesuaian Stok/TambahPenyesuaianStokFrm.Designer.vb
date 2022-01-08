<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPenyesuaianStokFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPenyesuaianStokFrm))
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdProduk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdToko = New System.Windows.Forms.TextBox()
        Me.txtAlasan = New System.Windows.Forms.TextBox()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.txtNamaToko = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFaktur = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStokSkg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTanggal
        '
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTanggal.Location = New System.Drawing.Point(135, 199)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(162, 20)
        Me.dtTanggal.TabIndex = 7
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(135, 225)
        Me.txtQty.MaxLength = 12
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(63, 20)
        Me.txtQty.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(4, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Qty"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdProduk
        '
        Me.txtIdProduk.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdProduk.Location = New System.Drawing.Point(135, 121)
        Me.txtIdProduk.MaxLength = 10
        Me.txtIdProduk.Name = "txtIdProduk"
        Me.txtIdProduk.ReadOnly = True
        Me.txtIdProduk.Size = New System.Drawing.Size(162, 20)
        Me.txtIdProduk.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(4, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Id Produk"
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
        Me.pnlHeader.Size = New System.Drawing.Size(565, 35)
        Me.pnlHeader.TabIndex = 88
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(190, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Penyesuaian Stok"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 35)
        Me.Panel1.TabIndex = 89
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(403, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(484, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 12
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
        Me.Label5.Text = "Tanggal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(4, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Alasan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(4, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Toko"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdToko
        '
        Me.txtIdToko.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdToko.Location = New System.Drawing.Point(135, 69)
        Me.txtIdToko.MaxLength = 10
        Me.txtIdToko.Name = "txtIdToko"
        Me.txtIdToko.ReadOnly = True
        Me.txtIdToko.Size = New System.Drawing.Size(162, 20)
        Me.txtIdToko.TabIndex = 2
        '
        'txtAlasan
        '
        Me.txtAlasan.Location = New System.Drawing.Point(135, 251)
        Me.txtAlasan.MaxLength = 25
        Me.txtAlasan.Multiline = True
        Me.txtAlasan.Name = "txtAlasan"
        Me.txtAlasan.Size = New System.Drawing.Size(434, 66)
        Me.txtAlasan.TabIndex = 9
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.BackColor = System.Drawing.Color.White
        Me.txtNamaProduk.Location = New System.Drawing.Point(135, 147)
        Me.txtNamaProduk.MaxLength = 50
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(434, 20)
        Me.txtNamaProduk.TabIndex = 5
        '
        'txtNamaToko
        '
        Me.txtNamaToko.BackColor = System.Drawing.SystemColors.Control
        Me.txtNamaToko.Location = New System.Drawing.Point(135, 95)
        Me.txtNamaToko.MaxLength = 25
        Me.txtNamaToko.Name = "txtNamaToko"
        Me.txtNamaToko.ReadOnly = True
        Me.txtNamaToko.Size = New System.Drawing.Size(434, 20)
        Me.txtNamaToko.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(4, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Faktur"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFaktur
        '
        Me.txtFaktur.Enabled = False
        Me.txtFaktur.Location = New System.Drawing.Point(135, 43)
        Me.txtFaktur.MaxLength = 10
        Me.txtFaktur.Name = "txtFaktur"
        Me.txtFaktur.ReadOnly = True
        Me.txtFaktur.Size = New System.Drawing.Size(162, 20)
        Me.txtFaktur.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(135, 323)
        Me.txtKeterangan.MaxLength = 25
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(434, 20)
        Me.txtKeterangan.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(4, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Keterangan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Stok saat ini"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStokSkg
        '
        Me.txtStokSkg.BackColor = System.Drawing.Color.White
        Me.txtStokSkg.Location = New System.Drawing.Point(135, 173)
        Me.txtStokSkg.MaxLength = 25
        Me.txtStokSkg.Name = "txtStokSkg"
        Me.txtStokSkg.ReadOnly = True
        Me.txtStokSkg.Size = New System.Drawing.Size(63, 20)
        Me.txtStokSkg.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(4, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Nama Toko"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(4, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Nama Produk"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TambahPenyesuaianStokFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 387)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStokSkg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFaktur)
        Me.Controls.Add(Me.txtNamaToko)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdProduk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdToko)
        Me.Controls.Add(Me.txtAlasan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TambahPenyesuaianStokFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdProduk As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdToko As TextBox
    Friend WithEvents txtAlasan As TextBox
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents txtNamaToko As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFaktur As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStokSkg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
