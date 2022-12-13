Public Class MainPerpustakaan

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        DatabaseAnggota.Close()
        DatabaseBuku.Close()
        DatabasePeminjaman.Close()
    End Sub

    Private Sub MainPerpustakaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbTable.Items.Add("Tabel Anggota")
        CbTable.Items.Add("Tabel Buku")
        CbTable.Items.Add("Tabel Peminjaman")
        CbTable.Items.Add("Tampilan Semua Database")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        If CbTable.Text = "Tabel Anggota" Then
            DatabaseAnggota.Show()
            Me.Hide()
        ElseIf CbTable.Text = "Tabel Buku" Then
            DatabaseBuku.Show()
            Me.Hide()
        ElseIf CbTable.Text = "Tabel Peminjaman" Then
            DatabasePeminjaman.Show()
            Me.Hide()
        ElseIf CbTable.Text = "Tampilan Semua Database" Then
            ViewAllDatabase.Show()
            Me.Hide()
        End If
    End Sub

End Class