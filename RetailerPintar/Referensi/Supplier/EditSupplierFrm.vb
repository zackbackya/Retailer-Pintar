Public Class EditSupplierFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editSupplier()

    End Sub

    Private Sub editSupplier()
        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_Supplier set nama_Supplier = '" & txtNamaSupplier.Text & "', alamat = '" & txtAlamatSupplier.Text & "', telepon = '" & txtTeleponSupplier.Text & "' where id_Supplier = '" & txtIdSupplier.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Diupdate", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call SupplierFrm.tampilData()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub EditSupplierFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdSupplier.Text = SupplierFrm.id_Supplier
        txtNamaSupplier.Text = SupplierFrm.nama_Supplier
        txtAlamatSupplier.Text = SupplierFrm.alamat_Supplier
        txtTeleponSupplier.Text = SupplierFrm.telepon_Supplier

        txtNamaSupplier.Focus()

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub EditSupplierFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editSupplier()
        End If




    End Sub
End Class