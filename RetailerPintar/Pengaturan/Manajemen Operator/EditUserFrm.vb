Public Class EditUserFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editUser()

    End Sub

    Private Sub editUser()
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

            Dim userLama As String = ManajemenUserFrm.username

            cmd = New MySqlConnector.MySqlCommand("update ms_User set username = '" & txtUsername.Text & "', password = '" & txtPassword.Text & "', role = '" & role & "' where username = '" & userLama & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ManajemenUserFrm.tampilData()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            'MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Text = ManajemenUserFrm.username
        txtPassword.Text = ManajemenUserFrm.password

        If ManajemenUserFrm.role = "ADMIN" Then
            rdAdmin.Checked = True
        ElseIf ManajemenUserFrm.role = "SUPERUSER" Then
            rdSuperAdmin.Checked = True
        ElseIf ManajemenUserFrm.role = "KASIR" Then
            rdKasir.Checked = True
        Else
            rdUser.Checked = True
        End If

        txtPassword.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditUserFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editUser()

        End If

    End Sub


End Class