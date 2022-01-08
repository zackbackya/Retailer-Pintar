Public Class EditCustomerFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editCustomer()

    End Sub

    Private Sub editCustomer()
        Call koneksi()
        Try
            Dim jenis_kelamin As String

            If rdLakiLaki.Checked = True Then
                jenis_kelamin = "L"
            ElseIf rdPerempuan.Checked = True Then
                jenis_kelamin = "P"
            End If


            cmd = New MySqlConnector.MySqlCommand("update ms_Customer set nik = '" & txtNIKCustomer.Text & "', nama = '" & txtNamaCustomer.Text & "', alamat = '" & txtAlamatCustomer.Text & "', jenis_kelamin = '" & jenis_kelamin & "', telepon = '" & txtTeleponCustomer.Text & "' where id  = '" & txtIdCustomer.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CustomerFrm.tampilData()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNIKCustomer.Text = CustomerFrm.nik
        txtIdCustomer.Text = CustomerFrm.id_Customer
        txtNamaCustomer.Text = CustomerFrm.nama_Customer
        txtAlamatCustomer.Text = CustomerFrm.alamat_Customer
        txtTeleponCustomer.Text = CustomerFrm.telepon_Customer

        If CustomerFrm.jenis_kelamin = "L" Then
            rdLakiLaki.Checked = True
        Else
            rdPerempuan.Checked = True
        End If

        txtNamaCustomer.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditCustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editCustomer()
        End If
    End Sub

    Private Sub txtAlamatCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtAlamatCustomer.GotFocus
        txtAlamatCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtAlamatCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtAlamatCustomer.LostFocus
        txtAlamatCustomer.BackColor = Color.White
    End Sub

    Private Sub txtNamaCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtNamaCustomer.GotFocus
        txtNamaCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaCustomere_LostFocus(sender As Object, e As EventArgs) Handles txtNamaCustomer.LostFocus
        txtNamaCustomer.BackColor = Color.White
    End Sub

    Private Sub txtNIKCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtNIKCustomer.GotFocus
        txtNIKCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNIKCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtNIKCustomer.LostFocus
        txtNIKCustomer.BackColor = Color.White
    End Sub

    Private Sub txtTeleponCustomer_GotFocus(sender As Object, e As EventArgs) Handles txtTeleponCustomer.GotFocus
        txtTeleponCustomer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtTeleponCustomer_LostFocus(sender As Object, e As EventArgs) Handles txtTeleponCustomer.LostFocus
        txtTeleponCustomer.BackColor = Color.White
    End Sub
End Class