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
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdToko = New System.Windows.Forms.TextBox()
        Me.txtAlasan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNamaToko = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFaktur = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(143, 165)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtTanggal.TabIndex = 100
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(143, 196)
        Me.txtQty.MaxLength = 25
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(123, 20)
        Me.txtQty.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Qty"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdProduk
        '
        Me.txtIdProduk.Location = New System.Drawing.Point(143, 108)
        Me.txtIdProduk.MaxLength = 25
        Me.txtIdProduk.Name = "txtIdProduk"
        Me.txtIdProduk.Size = New System.Drawing.Size(123, 20)
        Me.txtIdProduk.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(12, 108)
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
        Me.pnlHeader.Size = New System.Drawing.Size(558, 35)
        Me.pnlHeader.TabIndex = 88
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(130, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Penyesuaian Stok"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(4, 313)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 35)
        Me.Panel1.TabIndex = 89
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(396, 5)
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
        Me.btnSelesai.Location = New System.Drawing.Point(477, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 4
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Tanggal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Alasan"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(143, 137)
        Me.txtBarcode.MaxLength = 25
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(183, 20)
        Me.txtBarcode.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Toko"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdToko
        '
        Me.txtIdToko.Location = New System.Drawing.Point(143, 76)
        Me.txtIdToko.MaxLength = 6
        Me.txtIdToko.Name = "txtIdToko"
        Me.txtIdToko.Size = New System.Drawing.Size(123, 20)
        Me.txtIdToko.TabIndex = 87
        '
        'txtAlasan
        '
        Me.txtAlasan.Location = New System.Drawing.Point(143, 226)
        Me.txtAlasan.MaxLength = 25
        Me.txtAlasan.Multiline = True
        Me.txtAlasan.Name = "txtAlasan"
        Me.txtAlasan.Size = New System.Drawing.Size(200, 54)
        Me.txtAlasan.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(272, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Nama Produk"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.BackColor = System.Drawing.Color.White
        Me.txtNamaProduk.Location = New System.Drawing.Point(403, 108)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(152, 20)
        Me.txtNamaProduk.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(272, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Nama Toko"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaToko
        '
        Me.txtNamaToko.BackColor = System.Drawing.Color.White
        Me.txtNamaToko.Location = New System.Drawing.Point(403, 76)
        Me.txtNamaToko.Name = "txtNamaToko"
        Me.txtNamaToko.Size = New System.Drawing.Size(152, 20)
        Me.txtNamaToko.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(12, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Faktur"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFaktur
        '
        Me.txtFaktur.Enabled = False
        Me.txtFaktur.Location = New System.Drawing.Point(143, 44)
        Me.txtFaktur.MaxLength = 6
        Me.txtFaktur.Name = "txtFaktur"
        Me.txtFaktur.ReadOnly = True
        Me.txtFaktur.Size = New System.Drawing.Size(119, 20)
        Me.txtFaktur.TabIndex = 105
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(143, 286)
        Me.txtKeterangan.MaxLength = 25
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(200, 20)
        Me.txtKeterangan.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(12, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Keterangan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TambahPenyesuaianStokFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 351)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFaktur)
        Me.Controls.Add(Me.txtNamaToko)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdProduk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdToko As TextBox
    Friend WithEvents txtAlasan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNamaToko As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFaktur As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label10 As Label
End Class
