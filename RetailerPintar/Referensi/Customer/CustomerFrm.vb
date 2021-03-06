Imports MySqlConnector

Public Class CustomerFrm

    Public nik, id_Customer, nama_Customer, alamat_Customer, jenis_kelamin, telepon_Customer As String

    Private Sub CustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Dispose()


    End Sub

    Private Sub CustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahCustomer()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editCustomer()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusCustomer()
        End If



    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Call tambahCustomer()

    End Sub

    Private Sub tambahCustomer()
        Try
            TambahCustomerFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editCustomer()
        Try
            id_Customer = DataGridView1.CurrentRow.Cells(0).Value.ToString
            nik = DataGridView1.CurrentRow.Cells(1).Value.ToString
            nama_Customer = DataGridView1.CurrentRow.Cells(2).Value.ToString
            alamat_Customer = DataGridView1.CurrentRow.Cells(3).Value.ToString
            jenis_kelamin = DataGridView1.CurrentRow.Cells(4).Value.ToString
            telepon_Customer = DataGridView1.CurrentRow.Cells(5).Value.ToString
            EditCustomerFrm.ShowDialog()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub hapusCustomer()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Customer where id = '" & id & "'"
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

    Public Sub tampilData()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select * from ms_Customer", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusCustomer()
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editCustomer()
    End Sub

    Private Sub txtCari_GotFocus(sender As Object, e As EventArgs) Handles txtCari.GotFocus
        txtCari.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCari_LostFocus(sender As Object, e As EventArgs) Handles txtCari.LostFocus
        txtCari.BackColor = Color.White
    End Sub
End Class