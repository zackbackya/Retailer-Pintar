Imports MySqlConnector

Public Class ManajemenUserFrm
    Public username, password, role As String
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahUserFrm.ShowDialog()

    End Sub


    Private Sub UserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call tampilData()
        Me.KeyPreview = True

    End Sub

    Private Sub UserFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahUser()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editUser()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusUser()
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub tambahUser()
        Try
            TambahUserFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editUser()
        Try

            username = DataGridView1.CurrentRow.Cells(0).Value.ToString

            Call koneksi()

            Dim str As String
            str = "select * from ms_user where username = '" & username & "'"
            cmd = New MySqlCommand(str, conn)
            rd_1 = cmd.ExecuteReader
            rd_1.Read()
            password = rd_1.Item(1)
            role = rd_1.Item(2)


            EditUserFrm.ShowDialog()


        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusUser()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()
                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_User where username = '" & id & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Anda berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call tampilData()

            ElseIf x = Windows.Forms.DialogResult.No Then
                Call tampilData()
            End If

        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editUser()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusUser()
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select username,role,last_login from ms_user", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtCari_GotFocus(sender As Object, e As EventArgs) Handles txtCari.GotFocus
        txtCari.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCari_LostFocus(sender As Object, e As EventArgs) Handles txtCari.LostFocus
        txtCari.BackColor = Color.White
    End Sub
End Class