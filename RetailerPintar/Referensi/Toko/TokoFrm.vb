Imports MySqlConnector

Public Class TokoFrm

    Public id_Toko, nama_Toko, alamat_Toko, kota_toko, tanggal_buka_toko, telepon_Toko As String

    Private Sub TokoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Dispose()


    End Sub

    Private Sub TokoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahToko()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editToko()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusToko()
        End If



    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Call tambahToko()

    End Sub

    Private Sub tambahToko()
        Try
            TambahTokoFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editToko()
        Try

            id_Toko = DataGridView1.CurrentRow.Cells(0).Value.ToString
            nama_Toko = DataGridView1.CurrentRow.Cells(1).Value.ToString
            alamat_Toko = DataGridView1.CurrentRow.Cells(2).Value.ToString
            kota_toko = DataGridView1.CurrentRow.Cells(3).Value.ToString
            tanggal_buka_toko = DataGridView1.CurrentRow.Cells(4).Value.ToString
            telepon_Toko = DataGridView1.CurrentRow.Cells(5).Value.ToString
            EditTokoFrm.ShowDialog()

        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusToko()
        Try

            Dim x As Object = MessageBox.Show("Apakah Yakin Data Akan dihapus ?", "Retail Pintar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Toko where id_toko = '" & id & "'"
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

            da = New MySqlDataAdapter("select * from ms_Toko", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusToko()
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editToko()
    End Sub
End Class