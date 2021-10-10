Public Class TambahSupplierFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try

            str = "insert into ms_Supplier values ('" & txtIdSupplier.Text & "','" & txtNamaSupplier.Text & "','" & txtAlamatSupplier.Text & "','" & txtTeleponSupplier.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call SupplierFrm.tampilData()
            Call GenTempID()
            txtNamaSupplier.Text = ""
            txtAlamatSupplier.Text = ""
            txtTeleponSupplier.Text = ""
            txtNamaSupplier.Focus()


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahSupplierFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaSupplier.Focus()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub TambahSupplierFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdSupplier.Text = idjam
    End Sub


End Class