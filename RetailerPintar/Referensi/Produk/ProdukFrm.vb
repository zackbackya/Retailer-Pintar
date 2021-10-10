Imports MySqlConnector

Public Class ProdukFrm
    Private Sub ProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_produk", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class