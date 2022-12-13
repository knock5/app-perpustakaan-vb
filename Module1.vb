Imports System.Data.Odbc

Module Module1

    Public conn As OdbcConnection
    Public ds As DataSet
    Public da As OdbcDataAdapter
    Public rd As OdbcDataReader

    Public Sub hubung()
        conn = New OdbcConnection("dsn=perpustakaandb")
        conn.Open()
    End Sub

    Public Sub data_set_buku(ByVal a As DataGridView, ByVal b As String)
        hubung()
        da = New OdbcDataAdapter(b, conn)
        ds = New DataSet
        da.Fill(ds)
        a.DataSource = ds
        a.DataMember = ds.Tables(0).ToString
        a.ReadOnly = True
        a.Columns("idbuku").HeaderText = "ID Buku"
        a.Columns("judulbuku").HeaderText = "Judul Buku"
        a.Columns("pengarang").HeaderText = "Pengarang"
        a.Columns("penerbit").HeaderText = "Penerbit"
    End Sub

    Public Sub data_set_anggota(ByVal a As DataGridView, ByVal b As String)
        hubung()
        da = New OdbcDataAdapter(b, conn)
        ds = New DataSet
        da.Fill(ds)
        a.DataSource = ds
        a.DataMember = ds.Tables(0).ToString
        a.ReadOnly = True
        a.Columns("idanggota").HeaderText = "ID Anggota"
        a.Columns("nama").HeaderText = "Nama Anggota"
        a.Columns("jk").HeaderText = "Jenis Kelamin"
        a.Columns("alamat").HeaderText = "Alamat"
    End Sub

    Public Sub data_set_peminjaman(ByVal a As DataGridView, ByVal b As String)
        hubung()
        da = New OdbcDataAdapter(b, conn)
        ds = New DataSet
        da.Fill(ds)
        a.DataSource = ds
        a.DataMember = ds.Tables(0).ToString
        a.ReadOnly = True
        a.Columns("nopinjaman").HeaderText = "No Peminjaman"
        a.Columns("idbuku").HeaderText = "ID Buku"
        a.Columns("idanggota").HeaderText = "ID Anggota"
        a.Columns("tglpinjam").HeaderText = "Tanggal Pinjam"
        a.Columns("tglkembali").HeaderText = "Tanggal Kembali"
    End Sub

    Public Sub dml(ByVal a As String)
        hubung()
        da = New OdbcDataAdapter(a, conn)
        ds = New DataSet
        da.Fill(ds)
    End Sub

    Public Sub combo(ByVal a As String, ByVal b As ComboBox, ByVal c As String, ByVal d As String)
        hubung()
        da = New OdbcDataAdapter(a, conn)
        ds = New DataSet
        da.Fill(ds)
        b.DataSource = ds.Tables(0)
        b.DisplayMember = c
        b.ValueMember = d
        b.SelectedValue = d
    End Sub


End Module
