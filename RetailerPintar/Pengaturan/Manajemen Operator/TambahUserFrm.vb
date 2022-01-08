Imports MySqlConnector

Public Class TambahUserFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()

        Call koneksi()
        Dim str As String
        str = "select * from ms_user where username = '" & txtUsername.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd_1 = cmd.ExecuteReader
        rd_1.Read()
        If rd_1.HasRows = True Then
            MessageBox.Show("Maaf Username Sudah Terdaftar, Silahkan Pilih Username Lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'update ms_user SET last_login = now() where username = '" & txtUsername.Text & "'


        Else
            Call koneksi()
            Try
                Dim role As String
                If rdAdmin.Checked = True Then
                    role = "ADMIN"
                ElseIf rdSuperAdmin.Checked = True Then
                    role = "SUPERUSER"
                ElseIf rdKasir.Checked = True Then
                    role = "KASIR"
                ElseIf rdUser.Checked = True Then
                    role = "USER"
                End If

                str = "insert into ms_user values ('" & txtUsername.Text & "','" & TextBox1.Text & "','" & role & "','')"
                cmd = New MySqlConnector.MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Call ManajemenUserFrm.tampilData()

                txtUsername.Text = ""
                TextBox1.Text = ""
                txtUsername.Focus()

            Catch ex As Exception

                MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If


    End Sub

    Private Sub TambahUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahUserFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

End Class