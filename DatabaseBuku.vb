Imports System.Data.Odbc

Public Class DatabaseBuku

    Private Sub DatabaseBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GbDeleteBuku.Hide()
        BtnConfirmUpdateBuku.Hide()
        BtnCancelBuku.Hide()

        CbIdBukuList.Enabled = False
        combo("SELECT * FROM buku", CbIdBukuList, "idbuku", "judulbuku")
        combo("SELECT * FROM buku", CbIdDeleteBuku, "idbuku", "judulbuku")
        data_set_buku(DgBuku, "SELECT * FROM buku")

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanBuku.Click
        If TxtJudulBuku.Text = "" Then
            MsgBox("Harap masukkan judul buku", MsgBoxStyle.Information, "Pesan")
        Else
            dml("INSERT INTO buku(judulbuku, pengarang, penerbit) values ('" + TxtJudulBuku.Text + "','" + TxtPengarangBuku.Text + "','" + TxtPenerbitBuku.Text + "')")
            data_set_buku(DgBuku, "SELECT * FROM buku")
            MessageBox.Show("Data berhasil disimpan", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
            DatabaseBuku_Load(sender, e)
        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearBuku.Click
        Call clear()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteBuku.Click
        Call hideMenu()
    End Sub

    Private Sub BtnDelCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelCancelBuku.Click
        Call hideDeleteBox()
    End Sub

    Private Sub BtnDelConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelConfirmBuku.Click
        If CbIdDeleteBuku.Text = "" Then
            MsgBox("ID Buku belum diisi", MsgBoxStyle.Information, "Pesan")
        Else
            dml("DELETE FROM buku WHERE idbuku=('" + CbIdDeleteBuku.Text + "')")
            MessageBox.Show("Data berhasil dihapus", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call hideDeleteBox()
            DatabaseBuku_Load(sender, e)
        End If
    End Sub

    Sub clear()
        CbIdBukuList.Text = ""
        TxtJudulBuku.Text = ""
        TxtPengarangBuku.Text = ""
        TxtPenerbitBuku.Text = ""
    End Sub

    Sub hideMenu()
        GbMenuBuku.Hide()
        GbDeleteBuku.Show()
    End Sub

    Sub hideDeleteBox()
        GbMenuBuku.Show()
        GbDeleteBuku.Hide()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseBuku.Click
        Me.Close()
        DatabaseAnggota.Close()
        DatabasePeminjaman.Close()
        MainPerpustakaan.Close()
    End Sub

    Private Sub BtnMenuBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuBuku.Click
        MainPerpustakaan.Show()
        MainPerpustakaan.CbTable.Text = ""
        Me.Close()
    End Sub

    Private Sub BtnEditBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditBuku.Click
        Try
            If CbIdBukuList.Enabled = False Then
                CbIdBukuList.Enabled = True

                BtnConfirmUpdateBuku.Show()
                BtnCancelBuku.Show()
                BtnEditBuku.Hide()
                BtnSimpanBuku.Hide()
                BtnClearBuku.Hide()
                BtnCloseBuku.Hide()
                BtnDeleteBuku.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnConfirmUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmUpdateBuku.Click
        If CbIdBukuList.Text = "" Then
            MsgBox("ID yang dituju kosong, Harap isi!", MessageBoxButtons.OK, "Pesan")
        Else
            dml("UPDATE buku SET judulbuku='" + TxtJudulBuku.Text + "', pengarang='" + TxtPengarangBuku.Text + "', penerbit='" + TxtPenerbitBuku.Text + "' where idbuku='" + CbIdBukuList.Text + "'")

            MsgBox("Data berhasil diperbarui")

            data_set_buku(DgBuku, "SELECT * FROM buku")
            Call clear()

            BtnConfirmUpdateBuku.Hide()
            BtnCancelBuku.Hide()
            BtnEditBuku.Show()
            BtnSimpanBuku.Show()
            BtnClearBuku.Show()
            BtnCloseBuku.Show()
            BtnDeleteBuku.Show()
        End If
    End Sub

    Private Sub BtnCancelBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelBuku.Click
        Call clear()

        BtnConfirmUpdateBuku.Hide()
        BtnCancelBuku.Hide()
        BtnEditBuku.Show()
        BtnSimpanBuku.Show()
        BtnClearBuku.Show()
        BtnCloseBuku.Show()
        BtnDeleteBuku.Show()

        CbIdBukuList.Enabled = False
    End Sub
End Class
