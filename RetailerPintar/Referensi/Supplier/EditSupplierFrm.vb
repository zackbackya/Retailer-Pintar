Public Class EditSupplierFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editSupplier()

    End Sub

    Private Sub editSupplier()
        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_Supplier set nama_Supplier = '" & txtNamaSupplier.Text & "', alamat = '" & txtAlamatSupplier.Text & "', telepon = '" & txtTeleponSupplier.Text & "' where id_Supplier = '" & txtIdSupplier.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call SupplierFrm.tampilData()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditSupplierFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdSupplier.Text = SupplierFrm.id_Supplier
        txtNamaSupplier.Text = SupplierFrm.nama_Supplier
        txtAlamatSupplier.Text = SupplierFrm.alamat_Supplier
        txtTeleponSupplier.Text = SupplierFrm.telepon_Supplier

        txtNamaSupplier.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditSupplierFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editSupplier()
        End If

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