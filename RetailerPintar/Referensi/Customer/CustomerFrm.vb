Imports MySqlConnector

Public Class CustomerFrm

    Public nik, id_Customer, nama_Customer, alamat_Customer, jenis_kelamin, telepon_Customer As String

    Private Sub CustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Close()


    End Sub

    Private Sub CustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
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
            nik = DataGridView1.CurrentRow.Cells(0).Value.ToString
            id_Customer = DataGridView1.CurrentRow.Cells(1).Value.ToString
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

            Dim x As Object = MessageBox.Show("Apakah Yakin Data Akan dihapus ?", "Retail Pintar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Customer where id = '" & id & "'"
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
End Class