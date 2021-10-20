<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPromoFrm
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
        Me.dtTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPromo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdPromo = New System.Windows.Forms.TextBox()
        Me.cbAktifPromo = New System.Windows.Forms.CheckBox()
        Me.txtIdProduk = New System.Windows.Forms.TextBox()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTanggalAwal
        '
        Me.dtTanggalAwal.Location = New System.Drawing.Point(138, 137)
        Me.dtTanggalAwal.Name = "dtTanggalAwal"
        Me.dtTanggalAwal.Size = New System.Drawing.Size(200, 20)
        Me.dtTanggalAwal.TabIndex = 100
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Location = New System.Drawing.Point(263, 104)
        Me.txtNamaProduk.MaxLength = 25
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(257, 20)
        Me.txtNamaProduk.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(3, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Nama Produk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaPromo
        '
        Me.txtNamaPromo.Location = New System.Drawing.Point(138, 77)
        Me.txtNamaPromo.MaxLength = 25
        Me.txtNamaPromo.Name = "txtNamaPromo"
        Me.txtNamaPromo.Size = New System.Drawing.Size(382, 20)
        Me.txtNamaPromo.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(3, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Nama Promo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlHeader.Size = New System.Drawing.Size(517, 35)
        Me.pnlHeader.TabIndex = 88
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(150, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tambah Data Promo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(3, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 41)
        Me.Panel1.TabIndex = 89
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.Location = New System.Drawing.Point(355, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 29)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "F11 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelesai.Location = New System.Drawing.Point(436, 5)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 29)
        Me.btnSelesai.TabIndex = 4
        Me.btnSelesai.Text = "Esc Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(3, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Tanggal Awal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Id Promo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdPromo
        '
        Me.txtIdPromo.Location = New System.Drawing.Point(138, 44)
        Me.txtIdPromo.MaxLength = 6
        Me.txtIdPromo.Name = "txtIdPromo"
        Me.txtIdPromo.ReadOnly = True
        Me.txtIdPromo.Size = New System.Drawing.Size(119, 20)
        Me.txtIdPromo.TabIndex = 87
        '
        'cbAktifPromo
        '
        Me.cbAktifPromo.AutoSize = True
        Me.cbAktifPromo.Location = New System.Drawing.Point(359, 142)
        Me.cbAktifPromo.Name = "cbAktifPromo"
        Me.cbAktifPromo.Size = New System.Drawing.Size(47, 17)
        Me.cbAktifPromo.TabIndex = 101
        Me.cbAktifPromo.Text = "Aktif"
        Me.cbAktifPromo.UseVisualStyleBackColor = True
        '
        'txtIdProduk
        '
        Me.txtIdProduk.Location = New System.Drawing.Point(138, 104)
        Me.txtIdProduk.MaxLength = 6
        Me.txtIdProduk.Name = "txtIdProduk"
        Me.txtIdProduk.ReadOnly = True
        Me.txtIdProduk.Size = New System.Drawing.Size(119, 20)
        Me.txtIdProduk.TabIndex = 102
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(138, 163)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(200, 20)
        Me.dtTanggalAkhir.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(3, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Tanggal Akhir"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TambahPromoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 234)
        Me.Controls.Add(Me.dtTanggalAkhir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdProduk)
        Me.Controls.Add(Me.cbAktifPromo)
        Me.Controls.Add(Me.dtTanggalAwal)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaPromo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdPromo)
        Me.Name = "TambahPromoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TambahPromoFrm"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtTanggalAwal As DateTimePicker
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaPromo As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdPromo As TextBox
    Friend WithEvents cbAktifPromo As CheckBox
    Friend WithEvents txtIdProduk As TextBox
    Friend WithEvents dtTanggalAkhir As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
