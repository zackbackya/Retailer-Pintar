Public Class TambahCustomerFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim jenis_kelamin As String

            If rdLakiLaki.Checked = True Then
                jenis_kelamin = "L"
            ElseIf rdPerempuan.Checked = True Then
                jenis_kelamin = "P"
            End If

            str = "insert into ms_Customer values ('" & txtIdCustomer.Text & "','" & txtNIKCustomer.Text & "','" & txtNamaCustomer.Text & "','" & txtAlamatCustomer.Text & "','" & jenis_kelamin & "','" & txtTeleponCustomer.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call CustomerFrm.tampilData()
            Call GenTempID()
            txtNIKCustomer.Text = ""
            txtNamaCustomer.Text = ""
            txtAlamatCustomer.Text = ""
            txtTeleponCustomer.Text = ""
            txtNamaCustomer.Focus()


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaCustomer.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahCustomerFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdCustomer.Text = "CT-" + idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub
End Class