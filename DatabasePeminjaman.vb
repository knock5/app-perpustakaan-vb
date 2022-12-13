Public Class DatabasePeminjaman

    Private Sub DatabasePeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GbDeletePjm.Hide()
        combo("SELECT * FROM buku", CbIdBuku, "idbuku", "judulbuku")
        combo("SELECT * FROM anggota", CbIdAnggota, "idanggota", "nama")
        data_set_peminjaman(DgPeminjaman, "SELECT * FROM peminjaman")
    End Sub

    Private Sub BtnSimpanPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanPjm.Click
        If TxtNoPinjamanPjm.Text = "" Or CbIdBuku.Text = "" Or CbIdAnggota.Text = "" Or DpTglPinjamPjm.Text = "" Or DpTglKembaliPjm.Text = "" Then
            MsgBox("Harap isi semua data", MsgBoxStyle.Information, "Pesan")
        Else
            dml("INSERT INTO peminjaman(nopinjaman, idbuku, idanggota, tglpinjam, tglkembali) values ('" + TxtNoPinjamanPjm.Text + "','" + CbIdBuku.Text + "','" + CbIdAnggota.Text + "','" + DpTglPinjamPjm.Text + "','" + DpTglKembaliPjm.Text + "')")
            data_set_peminjaman(DgPeminjaman, "SELECT * FROM peminjaman")
            MessageBox.Show("Data berhasil disimpan", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ClearPeminjaman()
            DatabasePeminjaman_Load(sender, e)
        End If
    End Sub

    Private Sub BtnClearPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearPjm.Click
        Call ClearPeminjaman()
    End Sub

    Private Sub BtnClosePjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClosePjm.Click
        Me.Close()
        DatabaseBuku.Close()
        DatabaseAnggota.Close()
        MainPerpustakaan.Close()
    End Sub

    Private Sub BtnDeletePjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePjm.Click
        Call HideMenuPeminjaman()
        LbNamaAnggotaPjm.Hide()
        LbNamaBukuPjm.Hide()
        TxtNamaAnggotaPjm.Hide()
        TxtNamaBukuPjm.Hide()
    End Sub

    Private Sub BtnDelConfirmPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelConfirmPjm.Click
        If TxtIdDeletePjm.Text = "" Then
            MsgBox("Nomor Pinjaman belum diisi", MsgBoxStyle.Information, "Pesan")
        Else
            dml("DELETE FROM peminjaman WHERE nopinjaman=('" + TxtIdDeletePjm.Text + "')")
            MessageBox.Show("Data berhasil dihapus", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HideDeleteBoxPeminjaman()
            LbNamaAnggotaPjm.Show()
            LbNamaBukuPjm.Show()
            TxtNamaAnggotaPjm.Show()
            TxtNamaBukuPjm.Show()
            DatabasePeminjaman_Load(sender, e)
        End If
    End Sub

    Sub ClearPeminjaman()
        TxtNoPinjamanPjm.Text = ""
        CbIdBuku.Text = ""
        CbIdAnggota.Text = ""
        DpTglPinjamPjm.Text = ""
        DpTglKembaliPjm.Text = ""
        TxtNamaBukuPjm.Text = ""
        TxtNamaAnggotaPjm.Text = ""
    End Sub

    Sub HideMenuPeminjaman()
        GbMenuPjm.Hide()
        GbDeletePjm.Show()
    End Sub

    Sub HideDeleteBoxPeminjaman()
        GbMenuPjm.Show()
        GbDeletePjm.Hide()
    End Sub

    Private Sub BtnDelCancelPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelCancelPjm.Click
        Call HideDeleteBoxPeminjaman()
        LbNamaAnggotaPjm.Show()
        LbNamaBukuPjm.Show()
        TxtNamaAnggotaPjm.Show()
        TxtNamaBukuPjm.Show()
    End Sub

    Private Sub BtnMenuPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuPjm.Click
        MainPerpustakaan.Show()
        MainPerpustakaan.CbTable.Text = ""
        Me.Close()
    End Sub

    Private Sub BtnEditPjm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditPjm.Click
        Try
            If TxtNoPinjamanPjm.Text = "" Then
                MsgBox("Nomor Pinjaman yang dituju kosong, Harap isi!", MessageBoxButtons.OK, "Pesan")
            Else
                dml("UPDATE peminjaman SET idbuku='" + CbIdBuku.Text + "', idanggota='" + CbIdAnggota.Text + "', tglpinjam='" + DpTglPinjamPjm.Text + "', tglkembali='" + DpTglKembaliPjm.Text + "' where nopinjaman='" + TxtNoPinjamanPjm.Text + "'")

                MsgBox("Data berhasil diperbarui")

                data_set_peminjaman(DgPeminjaman, "SELECT * FROM peminjaman")
                Call ClearPeminjaman()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub CbIdBuku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbIdBuku.SelectedIndexChanged
        Try
            TxtNamaBukuPjm.Text = CbIdBuku.SelectedValue
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CbIdAnggota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbIdAnggota.SelectedIndexChanged
        Try
            TxtNamaAnggotaPjm.Text = CbIdAnggota.SelectedValue
        Catch ex As Exception
        End Try
    End Sub
End Class