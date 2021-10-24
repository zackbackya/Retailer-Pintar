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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHargaBeliProduk = New System.Windows.Forms.TextBox()
        Me.txtHargaJualProduk = New System.Windows.Forms.TextBox()
        Me.txtStokProduk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbAktifProduk = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.cbGolongan = New System.Windows.Forms.ComboBox()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.Size = New System.Drawing.Size(693, 35)
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
        Me.Panel1.Location = New System.Drawing.Point(3, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 35)
        Me.Panel1.TabIndex = 28
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(531, 5)
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
        Me.btnSelesai.Location = New System.Drawing.Point(612, 5)
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
        Me.txtBarcode.Size = New System.Drawing.Size(445, 20)
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
        Me.txtNamaProduk.Size = New System.Drawing.Size(445, 20)
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
        Me.txtIdSupplier.Location = New System.Drawing.Point(134, 174)
        Me.txtIdSupplier.MaxLength = 6
        Me.txtIdSupplier.Name = "txtIdSupplier"
        Me.txtIdSupplier.Size = New System.Drawing.Size(116, 20)
        Me.txtIdSupplier.TabIndex = 7
        '
        'txtIdGolongan
        '
        Me.txtIdGolongan.Location = New System.Drawing.Point(134, 200)
        Me.txtIdGolongan.MaxLength = 6
        Me.txtIdGolongan.Name = "txtIdGolongan"
        Me.txtIdGolongan.Size = New System.Drawing.Size(116, 20)
        Me.txtIdGolongan.TabIndex = 37
        '
        'txtLokasiProduk
        '
        Me.txtLokasiProduk.Location = New System.Drawing.Point(134, 226)
        Me.txtLokasiProduk.MaxLength = 25
        Me.txtLokasiProduk.Name = "txtLokasiProduk"
        Me.txtLokasiProduk.Size = New System.Drawing.Size(445, 20)
        Me.txtLokasiProduk.TabIndex = 10
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(585, 44)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(111, 121)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 41
        Me.pictureBox1.TabStop = False
        '
        'txtHargaBeliProduk
        '
        Me.txtHargaBeliProduk.Location = New System.Drawing.Point(134, 252)
        Me.txtHargaBeliProduk.MaxLength = 12
        Me.txtHargaBeliProduk.Name = "txtHargaBeliProduk"
        Me.txtHargaBeliProduk.Size = New System.Drawing.Size(200, 20)
        Me.txtHargaBeliProduk.TabIndex = 11
        '
        'txtHargaJualProduk
        '
        Me.txtHargaJualProduk.Location = New System.Drawing.Point(134, 278)
        Me.txtHargaJualProduk.MaxLength = 12
        Me.txtHargaJualProduk.Name = "txtHargaJualProduk"
        Me.txtHargaJualProduk.Size = New System.Drawing.Size(200, 20)
        Me.txtHargaJualProduk.TabIndex = 12
        '
        'txtStokProduk
        '
        Me.txtStokProduk.Location = New System.Drawing.Point(134, 304)
        Me.txtStokProduk.MaxLength = 12
        Me.txtStokProduk.Name = "txtStokProduk"
        Me.txtStokProduk.Size = New System.Drawing.Size(116, 20)
        Me.txtStokProduk.TabIndex = 13
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
        Me.Label7.Location = New System.Drawing.Point(3, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Harga Beli"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(3, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Lokasi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(3, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Id Golongan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(3, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Harga Jual"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(3, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 20)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Stok"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(340, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "*untuk nama distruk"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "/ pcs"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSupplier
        '
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(259, 173)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(437, 21)
        Me.cbSupplier.TabIndex = 57
        '
        'cbGolongan
        '
        Me.cbGolongan.FormattingEnabled = True
        Me.cbGolongan.Location = New System.Drawing.Point(259, 201)
        Me.cbGolongan.Name = "cbGolongan"
        Me.cbGolongan.Size = New System.Drawing.Size(437, 21)
        Me.cbGolongan.TabIndex = 58
        '
        'TambahProdukFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 369)
        Me.Controls.Add(Me.cbGolongan)
        Me.Controls.Add(Me.cbSupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbAktifProduk)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStokProduk)
        Me.Controls.Add(Me.txtHargaJualProduk)
        Me.Controls.Add(Me.txtHargaBeliProduk)
        Me.Controls.Add(Me.pictureBox1)
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
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents txtHargaBeliProduk As TextBox
    Friend WithEvents txtHargaJualProduk As TextBox
    Friend WithEvents txtStokProduk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbAktifProduk As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents cbGolongan As ComboBox
End Class
