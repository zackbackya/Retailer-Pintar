<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisPengeluaranFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditJenisPengeluaranFrm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdJenisPengeluaran = New System.Windows.Forms.TextBox()
        Me.txtNamaJenisPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(421, 35)
        Me.pnlHeader.TabIndex = 32
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(163, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Edit Jenis Pengeluaran"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnSelesai)
        Me.Panel1.Location = New System.Drawing.Point(3, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 35)
        Me.Panel1.TabIndex = 33
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
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Id Jenis Pengeluaran"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdJenisPengeluaran
        '
        Me.txtIdJenisPengeluaran.Location = New System.Drawing.Point(150, 45)
        Me.txtIdJenisPengeluaran.MaxLength = 6
        Me.txtIdJenisPengeluaran.Name = "txtIdJenisPengeluaran"
        Me.txtIdJenisPengeluaran.ReadOnly = True
        Me.txtIdJenisPengeluaran.Size = New System.Drawing.Size(103, 20)
        Me.txtIdJenisPengeluaran.TabIndex = 30
        '
        'txtNamaJenisPengeluaran
        '
        Me.txtNamaJenisPengeluaran.Location = New System.Drawing.Point(150, 71)
        Me.txtNamaJenisPengeluaran.MaxLength = 25
        Me.txtNamaJenisPengeluaran.Name = "txtNamaJenisPengeluaran"
        Me.txtNamaJenisPengeluaran.Size = New System.Drawing.Size(274, 20)
        Me.txtNamaJenisPengeluaran.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(3, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nama Jenis Pengeluaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditJenisPengeluaranFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 134)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdJenisPengeluaran)
        Me.Controls.Add(Me.txtNamaJenisPengeluaran)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditJenisPengeluaranFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retailer Pintar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents btnSimpan As Button
    Private WithEvents btnSelesai As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdJenisPengeluaran As TextBox
    Friend WithEvents txtNamaJenisPengeluaran As TextBox
    Friend WithEvents Label2 As Label
End Class
