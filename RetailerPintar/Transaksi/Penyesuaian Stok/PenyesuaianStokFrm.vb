Imports MySqlConnector

Public Class PenyesuaianStokFrm

    Public id_PenyesuaianStok, nama_PenyesuaianStok, alamat_PenyesuaianStok, kota_PenyesuaianStok, tanggal_buka_PenyesuaianStok, telepon_PenyesuaianStok As String

    Private Sub PenyesuaianStokFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call CheckRole()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub PenyesuaianStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahPenyesuaianStok()
        ElseIf e.KeyCode = Keys.F10 Then
            If LoginFrm.RoleName = "ADMIN" Then
                ''
            End If
        Else
            Call hapusPenyesuaianStok()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call tambahPenyesuaianStok()
    End Sub

    Private Sub tambahPenyesuaianStok()
        Try
            TambahPenyesuaianStokFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hapusPenyesuaianStok()
        Try

            Dim x As Object = MessageBox.Show("Apakah Yakin Data Akan dihapus ?", "Retail Pintar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from tx_penyesuaian_stok where faktur = '" & id & "'"
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

            da = New MySqlDataAdapter("select * from tx_penyesuaian_stok", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusPenyesuaianStok()
    End Sub

    Private Sub CheckRole()

        If LoginFrm.RoleName = "ADMIN" Then
            'admin role
            btnHapus.Enabled = False
        End If

    End Sub

End Class