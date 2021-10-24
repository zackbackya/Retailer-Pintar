Imports MySqlConnector
Public Class JenisPengeluaranFrm
    Public id_Jenis_Pengeluaran, nama_Jenis_Pengeluaran As String

    Private Sub JenisPengeluaranFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Dispose()


    End Sub

    Private Sub JenisPengeluaranFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahJenisPengeluaran()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editJenisPengeluaran()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusJenisPengeluaran()
        End If



    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Call tambahJenisPengeluaran()

    End Sub

    Private Sub tambahJenisPengeluaran()
        Try
            TambahJenisPengeluaranFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editJenisPengeluaran()
        Try
            id_Jenis_Pengeluaran = DataGridView1.CurrentRow.Cells(0).Value.ToString
            nama_Jenis_Pengeluaran = DataGridView1.CurrentRow.Cells(1).Value.ToString
            EditJenisPengeluaranFrm.ShowDialog()



        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusJenisPengeluaran()
        Try

            Dim x As Object = MessageBox.Show("Apakah Yakin Data Akan dihapus ?", "Retail Pintar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Jenis_Pengeluaran where id_Jenis_Pengeluaran = '" & id & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Terhapus", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call tampilData()

            ElseIf x = Windows.Forms.DialogResult.No Then
                Call tampilData()
            End If

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_Jenis_Pengeluaran", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusJenisPengeluaran()
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editJenisPengeluaran()
    End Sub
End Class