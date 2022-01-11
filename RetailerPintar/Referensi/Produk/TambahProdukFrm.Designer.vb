<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahProdukFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahProdukFrm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.txtIdProduk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.txtNamaPendekProduk = New System.Windows.Forms.TextBox()
        Me.txtIdSupplier = New System.Windows.Forms.TextBox()
        Me.txtIdGolongan = New System.Windows.Forms.TextBox()
        Me.txtLokasiProduk = New System.Windows.Forms.TextBox()
        Me.txtHargaBeliProduk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbAktifProduk = New System.Windows.Forms.CheckBox()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.cbGolongan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAktif3 = New System.Windows.Forms.CheckBox()
        Me.cbAktif2 = New System.Windows.Forms.CheckBox()
        Me.txtJmlMin3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHargaJualProduk3 = New System.Windows.Forms.TextBox()
        Me.txtJmlMin2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtHargaJualProduk2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHargaJualProduk1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStokProduk = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(602, 35)
        Me.pnlHeader.TabIndex = 4
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(154, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Data Produk"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(3, 538)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 35)
        Me.Panel1.TabIndex = 28
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(440, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(521, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 15
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'txtIdProduk
        '
        Me.txtIdProduk.Location = New System.Drawing.Point(134, 44)
        Me.txtIdProduk.MaxLength = 6
        Me.txtIdProduk.Name = "txtIdProduk"
        Me.txtIdProduk.ReadOnly = True
        Me.txtIdProduk.Size = New System.Drawing.Size(119, 20)
        Me.txtIdProduk.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Id Produk"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(134, 70)
        Me.txtBarcode.MaxLength = 50
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(471, 20)
        Me.txtBarcode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Location = New System.Drawing.Point(134, 96)
        Me.txtNamaProduk.MaxLength = 50
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(471, 20)
        Me.txtNamaProduk.TabIndex = 3
        '
        'txtNamaPendekProduk
        '
        Me.txtNamaPendekProduk.Location = New System.Drawing.Point(134, 122)
        Me.txtNamaPendekProduk.MaxLength = 17
        Me.txtNamaPendekProduk.Name = "txtNamaPendekProduk"
        Me.txtNamaPendekProduk.Size = New System.Drawing.Size(200, 20)
        Me.txtNamaPendekProduk.TabIndex = 4
        '
        'txtIdSupplier
        '
        Me.txtIdSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdSupplier.Location = New System.Drawing.Point(134, 174)
        Me.txtIdSupplier.MaxLength = 10
        Me.txtIdSupplier.Name = "txtIdSupplier"
        Me.txtIdSupplier.Size = New System.Drawing.Size(116, 20)
        Me.txtIdSupplier.TabIndex = 6
        '
        'txtIdGolongan
        '
        Me.txtIdGolongan.BackColor = System.Drawing.SystemColors.Control
        Me.txtIdGolongan.Location = New System.Drawing.Point(134, 227)
        Me.txtIdGolongan.MaxLength = 10
        Me.txtIdGolongan.Name = "txtIdGolongan"
        Me.txtIdGolongan.Size = New System.Drawing.Size(116, 20)
        Me.txtIdGolongan.TabIndex = 8
        '
        'txtLokasiProduk
        '
        Me.txtLokasiProduk.Location = New System.Drawing.Point(134, 280)
        Me.txtLokasiProduk.MaxLength = 25
        Me.txtLokasiProduk.Name = "txtLokasiProduk"
        Me.txtLokasiProduk.Size = New System.Drawing.Size(312, 20)
        Me.txtLokasiProduk.TabIndex = 10
        '
        'txtHargaBeliProduk
        '
        Me.txtHargaBeliProduk.Location = New System.Drawing.Point(134, 306)
        Me.txtHargaBeliProduk.MaxLength = 12
        Me.txtHargaBeliProduk.Name = "txtHargaBeliProduk"
        Me.txtHargaBeliProduk.Size = New System.Drawing.Size(200, 20)
        Me.txtHargaBeliProduk.TabIndex = 11
        Me.txtHargaBeliProduk.Text = "0"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(3, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nama Produk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(3, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Id Supplier"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(3, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Nama Pendek"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(3, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Harga Beli"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(3, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Lokasi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(3, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Id Golongan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbAktifProduk
        '
        Me.cbAktifProduk.AutoSize = True
        Me.cbAktifProduk.Location = New System.Drawing.Point(134, 148)
        Me.cbAktifProduk.Name = "cbAktifProduk"
        Me.cbAktifProduk.Size = New System.Drawing.Size(47, 17)
        Me.cbAktifProduk.TabIndex = 5
        Me.cbAktifProduk.Text = "Aktif"
        Me.cbAktifProduk.UseVisualStyleBackColor = True
        '
        'cbSupplier
        '
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(134, 200)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(312, 21)
        Me.cbSupplier.TabIndex = 7
        '
        'cbGolongan
        '
        Me.cbGolongan.FormattingEnabled = True
        Me.cbGolongan.Location = New System.Drawing.Point(134, 253)
        Me.cbGolongan.Name = "cbGolongan"
        Me.cbGolongan.Size = New System.Drawing.Size(312, 21)
        Me.cbGolongan.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(3, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Nama Supplier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(3, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 20)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Nama Golongan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cbAktif3)
        Me.GroupBox1.Controls.Add(Me.cbAktif2)
        Me.GroupBox1.Controls.Add(Me.txtJmlMin3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtHargaJualProduk3)
        Me.GroupBox1.Controls.Add(Me.txtJmlMin2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtHargaJualProduk2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtHargaJualProduk1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 174)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ Harga Jual Retail ]"
        '
        'cbAktif3
        '
        Me.cbAktif3.AutoSize = True
        Me.cbAktif3.Location = New System.Drawing.Point(508, 71)
        Me.cbAktif3.Name = "cbAktif3"
        Me.cbAktif3.Size = New System.Drawing.Size(47, 17)
        Me.cbAktif3.TabIndex = 77
        Me.cbAktif3.Text = "Akitf"
        Me.cbAktif3.UseVisualStyleBackColor = True
        '
        'cbAktif2
        '
        Me.cbAktif2.AutoSize = True
        Me.cbAktif2.Location = New System.Drawing.Point(508, 45)
        Me.cbAktif2.Name = "cbAktif2"
        Me.cbAktif2.Size = New System.Drawing.Size(47, 17)
        Me.cbAktif2.TabIndex = 76
        Me.cbAktif2.Text = "Akitf"
        Me.cbAktif2.UseVisualStyleBackColor = True
        '
        'txtJmlMin3
        '
        Me.txtJmlMin3.Location = New System.Drawing.Point(442, 68)
        Me.txtJmlMin3.MaxLength = 12
        Me.txtJmlMin3.Name = "txtJmlMin3"
        Me.txtJmlMin3.Size = New System.Drawing.Size(60, 20)
        Me.txtJmlMin3.TabIndex = 73
        Me.txtJmlMin3.Text = "0"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(311, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 20)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Jumlah Minimal 3"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(6, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 20)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Harga Jual 3"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHargaJualProduk3
        '
        Me.txtHargaJualProduk3.Location = New System.Drawing.Point(137, 68)
        Me.txtHargaJualProduk3.MaxLength = 12
        Me.txtHargaJualProduk3.Name = "txtHargaJualProduk3"
        Me.txtHargaJualProduk3.Size = New System.Drawing.Size(168, 20)
        Me.txtHargaJualProduk3.TabIndex = 70
        Me.txtHargaJualProduk3.Text = "0"
        '
        'txtJmlMin2
        '
        Me.txtJmlMin2.Location = New System.Drawing.Point(442, 42)
        Me.txtJmlMin2.MaxLength = 12
        Me.txtJmlMin2.Name = "txtJmlMin2"
        Me.txtJmlMin2.Size = New System.Drawing.Size(60, 20)
        Me.txtJmlMin2.TabIndex = 69
        Me.txtJmlMin2.Text = "0"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(311, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 20)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Jumlah Minimal 2"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(6, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 20)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Harga Jual 2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHargaJualProduk2
        '
        Me.txtHargaJualProduk2.Location = New System.Drawing.Point(137, 42)
        Me.txtHargaJualProduk2.MaxLength = 12
        Me.txtHargaJualProduk2.Name = "txtHargaJualProduk2"
        Me.txtHargaJualProduk2.Size = New System.Drawing.Size(168, 20)
        Me.txtHargaJualProduk2.TabIndex = 65
        Me.txtHargaJualProduk2.Text = "0"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Harga Jual 1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHargaJualProduk1
        '
        Me.txtHargaJualProduk1.Location = New System.Drawing.Point(137, 16)
        Me.txtHargaJualProduk1.MaxLength = 12
        Me.txtHargaJualProduk1.Name = "txtHargaJualProduk1"
        Me.txtHargaJualProduk1.Size = New System.Drawing.Size(168, 20)
        Me.txtHargaJualProduk1.TabIndex = 60
        Me.txtHargaJualProduk1.Text = "0"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(256, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "/ Pcs"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(3, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 20)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Stok"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStokProduk
        '
        Me.txtStokProduk.Location = New System.Drawing.Point(134, 332)
        Me.txtStokProduk.MaxLength = 12
        Me.txtStokProduk.Name = "txtStokProduk"
        Me.txtStokProduk.Size = New System.Drawing.Size(116, 20)
        Me.txtStokProduk.TabIndex = 65
        Me.txtStokProduk.Text = "0"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(6, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(587, 66)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = resources.GetString("Label18.Text")
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TambahProdukFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 577)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStokProduk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbGolongan)
        Me.Controls.Add(Me.cbSupplier)
        Me.Controls.Add(Me.cbAktifProduk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHargaBeliProduk)
        Me.Controls.Add(Me.txtLokasiProduk)
        Me.Controls.Add(Me.txtIdGolongan)
        Me.Controls.Add(Me.txtIdSupplier)
        Me.Controls.Add(Me.txtNamaPendekProduk)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdProduk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahProdukFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents txtIdProduk As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents txtNamaPendekProduk As TextBox
    Friend WithEvents txtIdSupplier As TextBox
    Friend WithEvents txtIdGolongan As TextBox
    Friend WithEvents txtLokasiProduk As TextBox
    Friend WithEvents txtHargaBeliProduk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbAktifProduk As CheckBox
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents cbGolongan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHargaJualProduk1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtHargaJualProduk2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStokProduk As TextBox
    Friend WithEvents txtJmlMin2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtJmlMin3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtHargaJualProduk3 As TextBox
    Friend WithEvents cbAktif3 As CheckBox
    Friend WithEvents cbAktif2 As CheckBox
    Friend WithEvents Label18 As Label
End Class
