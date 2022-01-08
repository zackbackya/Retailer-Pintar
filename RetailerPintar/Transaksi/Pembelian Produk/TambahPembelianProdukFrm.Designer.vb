<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPembelianProdukFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPembelianProdukFrm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.dgPembelian = New System.Windows.Forms.DataGridView()
        Me.id_produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aksi = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbTunai = New System.Windows.Forms.RadioButton()
        Me.rbKredit = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtJatuhTempo = New System.Windows.Forms.DateTimePicker()
        Me.dgProduk = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(790, 42)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "TOTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlHeader.Size = New System.Drawing.Size(1064, 35)
        Me.pnlHeader.TabIndex = 110
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(192, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Pembelian Produk"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(3, 603)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 35)
        Me.Panel1.TabIndex = 111
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(902, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(983, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 13
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'dgPembelian
        '
        Me.dgPembelian.AllowUserToDeleteRows = False
        Me.dgPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPembelian.BackgroundColor = System.Drawing.Color.White
        Me.dgPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_produk, Me.produk, Me.jumlah, Me.harga, Me.sub_total, Me.aksi})
        Me.dgPembelian.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgPembelian.Location = New System.Drawing.Point(3, 216)
        Me.dgPembelian.Name = "dgPembelian"
        Me.dgPembelian.Size = New System.Drawing.Size(790, 381)
        Me.dgPembelian.TabIndex = 9
        '
        'id_produk
        '
        Me.id_produk.FillWeight = 67.68188!
        Me.id_produk.HeaderText = "Id Produk"
        Me.id_produk.Name = "id_produk"
        '
        'produk
        '
        Me.produk.FillWeight = 218.7095!
        Me.produk.HeaderText = "Produk"
        Me.produk.Name = "produk"
        Me.produk.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'aksi
        '
        Me.aksi.FillWeight = 48.08933!
        Me.aksi.HeaderText = "Aksi"
        Me.aksi.Name = "aksi"
        Me.aksi.Text = "Hapus"
        Me.aksi.ToolTipText = "Hapus"
        Me.aksi.UseColumnTextForButtonValue = True
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(3, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 19)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Nota"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(134, 87)
        Me.txtNota.MaxLength = 12
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ReadOnly = True
        Me.txtNota.Size = New System.Drawing.Size(162, 20)
        Me.txtNota.TabIndex = 1
        '
        'dtTanggal
        '
        Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTanggal.Location = New System.Drawing.Point(134, 113)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(162, 20)
        Me.dtTanggal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(3, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Tanggal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(269, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Jatuh Tempo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbTunai
        '
        Me.rbTunai.AutoSize = True
        Me.rbTunai.Location = New System.Drawing.Point(134, 141)
        Me.rbTunai.Name = "rbTunai"
        Me.rbTunai.Size = New System.Drawing.Size(52, 17)
        Me.rbTunai.TabIndex = 3
        Me.rbTunai.TabStop = True
        Me.rbTunai.Text = "Tunai"
        Me.rbTunai.UseVisualStyleBackColor = True
        '
        'rbKredit
        '
        Me.rbKredit.AutoSize = True
        Me.rbKredit.Location = New System.Drawing.Point(192, 141)
        Me.rbKredit.Name = "rbKredit"
        Me.rbKredit.Size = New System.Drawing.Size(52, 17)
        Me.rbKredit.TabIndex = 4
        Me.rbKredit.TabStop = True
        Me.rbKredit.Text = "Kredit"
        Me.rbKredit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(3, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Status"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKodeSupplier
        '
        Me.txtKodeSupplier.BackColor = System.Drawing.Color.White
        Me.txtKodeSupplier.Location = New System.Drawing.Point(134, 164)
        Me.txtKodeSupplier.MaxLength = 10
        Me.txtKodeSupplier.Name = "txtKodeSupplier"
        Me.txtKodeSupplier.Size = New System.Drawing.Size(162, 20)
        Me.txtKodeSupplier.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(3, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Supplier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(117, 47)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(671, 31)
        Me.lblTotal.TabIndex = 124
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtJatuhTempo
        '
        Me.dtJatuhTempo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtJatuhTempo.Location = New System.Drawing.Point(400, 138)
        Me.dtJatuhTempo.Name = "dtJatuhTempo"
        Me.dtJatuhTempo.Size = New System.Drawing.Size(162, 20)
        Me.dtJatuhTempo.TabIndex = 5
        '
        'dgProduk
        '
        Me.dgProduk.AllowUserToAddRows = False
        Me.dgProduk.AllowUserToDeleteRows = False
        Me.dgProduk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProduk.BackgroundColor = System.Drawing.Color.White
        Me.dgProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProduk.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgProduk.Location = New System.Drawing.Point(799, 64)
        Me.dgProduk.Name = "dgProduk"
        Me.dgProduk.ReadOnly = True
        Me.dgProduk.Size = New System.Drawing.Size(268, 533)
        Me.dgProduk.TabIndex = 11
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.Color.White
        Me.txtCari.Location = New System.Drawing.Point(799, 41)
        Me.txtCari.MaxLength = 25
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(268, 20)
        Me.txtCari.TabIndex = 10
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Location = New System.Drawing.Point(134, 190)
        Me.txtKeterangan.MaxLength = 50
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(659, 20)
        Me.txtKeterangan.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(3, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Keterangan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaSupplier
        '
        Me.txtNamaSupplier.BackColor = System.Drawing.SystemColors.Control
        Me.txtNamaSupplier.Location = New System.Drawing.Point(302, 164)
        Me.txtNamaSupplier.MaxLength = 10
        Me.txtNamaSupplier.Name = "txtNamaSupplier"
        Me.txtNamaSupplier.ReadOnly = True
        Me.txtNamaSupplier.Size = New System.Drawing.Size(491, 20)
        Me.txtNamaSupplier.TabIndex = 7
        '
        'TambahPembelianProdukFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 641)
        Me.Controls.Add(Me.txtNamaSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.dgProduk)
        Me.Controls.Add(Me.dtJatuhTempo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbKredit)
        Me.Controls.Add(Me.rbTunai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.dgPembelian)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahPembelianProdukFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents dgPembelian As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbTunai As RadioButton
    Friend WithEvents rbKredit As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeSupplier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dtJatuhTempo As DateTimePicker
    Friend WithEvents dgProduk As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNamaSupplier As TextBox
    Friend WithEvents id_produk As DataGridViewTextBoxColumn
    Friend WithEvents produk As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents aksi As DataGridViewButtonColumn
End Class
