Public Class TambahSupplierFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try

            str = "insert into ms_Supplier values ('" & txtIdSupplier.Text & "','" & txtNamaSupplier.Text & "','" & txtAlamatSupplier.Text & "','" & txtTeleponSupplier.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call SupplierFrm.tampilData()
            Call GenTempID()
            txtNamaSupplier.Text = ""
            txtAlamatSupplier.Text = ""
            txtTeleponSupplier.Text = ""
            txtNamaSupplier.Focus()


        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahSupplierFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaSupplier.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahSupplierFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdSupplier.Text = "SP-" + idjam
    End Sub

    Private Sub txtAlamatSupplier_GotFocus(sender As Object, e As EventArgs) Handles txtAlamatSupplier.GotFocus
        txtAlamatSupplier.BackColor = Color.LightYellow
    End Sub

    Private Sub txtAlamatSupplier_LostFocus(sender As Object, e As EventArgs) Handles txtAlamatSupplier.LostFocus
        txtAlamatSupplier.BackColor = Color.White
    End Sub

    Private Sub txtNamaSupplier_GotFocus(sender As Object, e As EventArgs) Handles txtNamaSupplier.GotFocus
        txtNamaSupplier.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaSupplier_LostFocus(sender As Object, e As EventArgs) Handles txtNamaSupplier.LostFocus
        txtNamaSupplier.BackColor = Color.White
    End Sub

    Private Sub txtTeleponSupplier_GotFocus(sender As Object, e As EventArgs) Handles txtTeleponSupplier.GotFocus
        txtTeleponSupplier.BackColor = Color.LightYellow
    End Sub

    Private Sub txtTeleponSupplier_LostFocus(sender As Object, e As EventArgs) Handles txtTeleponSupplier.LostFocus
        txtTeleponSupplier.BackColor = Color.White
    End Sub
End Class