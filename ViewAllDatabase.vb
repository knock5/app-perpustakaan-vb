Public Class ViewAllDatabase

    Private Sub ViewAllDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        data_set_anggota(DataGridView1, "SELECT * FROM anggota")
        data_set_buku(DataGridView2, "SELECT * FROM buku")
        data_set_peminjaman(DataGridView3, "SELECT * FROM peminjaman")

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        MainPerpustakaan.Show()
        Me.Close()
    End Sub
End Class