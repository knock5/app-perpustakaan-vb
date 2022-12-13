Public Class DatabaseAnggota

    Private Sub DatabaseAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GbDeleteAnggota.Hide()

        data_set_anggota(DgAnggota, "SELECT * FROM anggota")

        Call ClearAnggota()
        CbJkAnggota.Items.Add("Laki-Laki")
        CbJkAnggota.Items.Add("Perempuan")
    End Sub

    Private Sub BtnSimpanAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanAnggota.Click
        If TxtIdAnggota.Text = "" Or TxtNamaAnggota.Text = "" Or CbJkAnggota.Text = "" Then
            MsgBox("(ID, Nama, Jenis Kelamin) Harus diisi!", MsgBoxStyle.Information, "Harap Lengkapi Data")
        Else
            dml("INSERT INTO anggota(idanggota, nama, jk, alamat) values ('" + TxtIdAnggota.Text + "','" + TxtNamaAnggota.Text + "','" + CbJkAnggota.Text + "','" + TxtAlamatAnggota.Text + "')")
            data_set_anggota(DgAnggota, "SELECT * FROM anggota")
            MessageBox.Show("Data berhasil disimpan", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ClearAnggota()
            DatabaseAnggota_Load(sender, e)
        End If
    End Sub

    Private Sub BtnClearAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearAnggota.Click
        Call ClearAnggota()
    End Sub

    Private Sub BtnCloseAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseAnggota.Click
        Me.Close()
        DatabaseBuku.Close()
        DatabasePeminjaman.Close()
        MainPerpustakaan.Close()
    End Sub

    Private Sub BtnDeleteAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAnggota.Click
        Call HideMenuAnggota()
        TxtIdDeleteAnggota.Text = ""
    End Sub

    Private Sub BtnDelCancelAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelCancelAnggota.Click
        Call HideGbDeleteAnggota()
        TxtIdDeleteAnggota.Text = ""
    End Sub

    Private Sub BtnDelConfirmAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelConfirmAnggota.Click
        If TxtIdDeleteAnggota.Text = "" Then
            MsgBox("ID Anggota belum diisi", MsgBoxStyle.Information, "Pesan")
        Else
            dml("DELETE FROM anggota WHERE idanggota=('" + TxtIdDeleteAnggota.Text + "')")
            MessageBox.Show("Data berhasil dihapus", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call HideGbDeleteAnggota()
            DatabaseAnggota_Load(sender, e)
        End If
    End Sub

    Sub ClearAnggota()
        TxtIdAnggota.Text = ""
        TxtNamaAnggota.Text = ""
        CbJkAnggota.Text = ""
        TxtAlamatAnggota.Text = ""
    End Sub

    Sub HideMenuAnggota()
        GbMenuAnggota.Hide()
        GbDeleteAnggota.Show()
    End Sub

    Sub HideGbDeleteAnggota()
        GbMenuAnggota.Show()
        GbDeleteAnggota.Hide()
    End Sub

    Private Sub BtnMenuAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuAnggota.Click
        MainPerpustakaan.Show()
        MainPerpustakaan.CbTable.Text = ""
        Me.Close()
    End Sub

    Private Sub BtnEditAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditAnggota.Click
        Try
            If TxtIdAnggota.Text = "" Then
                MsgBox("ID yang dituju kosong, Harap isi!", MessageBoxButtons.OK, "Pesan")
            Else
                dml("UPDATE anggota SET nama='" + TxtNamaAnggota.Text + "', jk='" + CbJkAnggota.Text + "', alamat='" + TxtAlamatAnggota.Text + "' where idanggota='" + TxtIdAnggota.Text + "'")

                MsgBox("Data berhasil diperbarui")

                data_set_anggota(DgAnggota, "SELECT * FROM anggota")
                Call ClearAnggota()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class