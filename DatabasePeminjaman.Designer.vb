<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabasePeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GbDeletePjm = New System.Windows.Forms.GroupBox()
        Me.BtnDelCancelPjm = New System.Windows.Forms.Button()
        Me.BtnDelConfirmPjm = New System.Windows.Forms.Button()
        Me.TxtIdDeletePjm = New System.Windows.Forms.TextBox()
        Me.TxtNoPinjamanPjm = New System.Windows.Forms.TextBox()
        Me.LbIdAnggotaPjm = New System.Windows.Forms.Label()
        Me.LbIdBukuPjm = New System.Windows.Forms.Label()
        Me.LbNoPinjamanPjm = New System.Windows.Forms.Label()
        Me.BtnClosePjm = New System.Windows.Forms.Button()
        Me.BtnDeletePjm = New System.Windows.Forms.Button()
        Me.BtnClearPjm = New System.Windows.Forms.Button()
        Me.BtnSimpanPjm = New System.Windows.Forms.Button()
        Me.DgPeminjaman = New System.Windows.Forms.DataGridView()
        Me.LbTglPinjamPjm = New System.Windows.Forms.Label()
        Me.LbTglKembaliPjm = New System.Windows.Forms.Label()
        Me.DpTglPinjamPjm = New System.Windows.Forms.DateTimePicker()
        Me.DpTglKembaliPjm = New System.Windows.Forms.DateTimePicker()
        Me.BtnMenuPjm = New System.Windows.Forms.Button()
        Me.GbMenuPjm = New System.Windows.Forms.GroupBox()
        Me.CbIdAnggota = New System.Windows.Forms.ComboBox()
        Me.CbIdBuku = New System.Windows.Forms.ComboBox()
        Me.BtnEditPjm = New System.Windows.Forms.Button()
        Me.LbNamaBukuPjm = New System.Windows.Forms.Label()
        Me.TxtNamaBukuPjm = New System.Windows.Forms.TextBox()
        Me.LbNamaAnggotaPjm = New System.Windows.Forms.Label()
        Me.TxtNamaAnggotaPjm = New System.Windows.Forms.TextBox()
        Me.GbDeletePjm.SuspendLayout()
        CType(Me.DgPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMenuPjm.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDeletePjm
        '
        Me.GbDeletePjm.Controls.Add(Me.BtnDelCancelPjm)
        Me.GbDeletePjm.Controls.Add(Me.BtnDelConfirmPjm)
        Me.GbDeletePjm.Controls.Add(Me.TxtIdDeletePjm)
        Me.GbDeletePjm.Location = New System.Drawing.Point(439, 22)
        Me.GbDeletePjm.Name = "GbDeletePjm"
        Me.GbDeletePjm.Size = New System.Drawing.Size(310, 119)
        Me.GbDeletePjm.TabIndex = 25
        Me.GbDeletePjm.TabStop = False
        Me.GbDeletePjm.Text = "Nomor Pinjaman"
        '
        'BtnDelCancelPjm
        '
        Me.BtnDelCancelPjm.Location = New System.Drawing.Point(151, 74)
        Me.BtnDelCancelPjm.Name = "BtnDelCancelPjm"
        Me.BtnDelCancelPjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelCancelPjm.TabIndex = 2
        Me.BtnDelCancelPjm.Text = "Batal"
        Me.BtnDelCancelPjm.UseVisualStyleBackColor = True
        '
        'BtnDelConfirmPjm
        '
        Me.BtnDelConfirmPjm.Location = New System.Drawing.Point(232, 74)
        Me.BtnDelConfirmPjm.Name = "BtnDelConfirmPjm"
        Me.BtnDelConfirmPjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelConfirmPjm.TabIndex = 1
        Me.BtnDelConfirmPjm.Text = "Oke"
        Me.BtnDelConfirmPjm.UseVisualStyleBackColor = True
        '
        'TxtIdDeletePjm
        '
        Me.TxtIdDeletePjm.Location = New System.Drawing.Point(6, 31)
        Me.TxtIdDeletePjm.Name = "TxtIdDeletePjm"
        Me.TxtIdDeletePjm.Size = New System.Drawing.Size(301, 22)
        Me.TxtIdDeletePjm.TabIndex = 0
        '
        'TxtNoPinjamanPjm
        '
        Me.TxtNoPinjamanPjm.Location = New System.Drawing.Point(111, 24)
        Me.TxtNoPinjamanPjm.Name = "TxtNoPinjamanPjm"
        Me.TxtNoPinjamanPjm.Size = New System.Drawing.Size(282, 22)
        Me.TxtNoPinjamanPjm.TabIndex = 22
        '
        'LbIdAnggotaPjm
        '
        Me.LbIdAnggotaPjm.AutoSize = True
        Me.LbIdAnggotaPjm.Location = New System.Drawing.Point(6, 89)
        Me.LbIdAnggotaPjm.Name = "LbIdAnggotaPjm"
        Me.LbIdAnggotaPjm.Size = New System.Drawing.Size(90, 17)
        Me.LbIdAnggotaPjm.TabIndex = 21
        Me.LbIdAnggotaPjm.Text = "ID Anggota : "
        '
        'LbIdBukuPjm
        '
        Me.LbIdBukuPjm.AutoSize = True
        Me.LbIdBukuPjm.Location = New System.Drawing.Point(6, 58)
        Me.LbIdBukuPjm.Name = "LbIdBukuPjm"
        Me.LbIdBukuPjm.Size = New System.Drawing.Size(65, 17)
        Me.LbIdBukuPjm.TabIndex = 20
        Me.LbIdBukuPjm.Text = "ID Buku: "
        '
        'LbNoPinjamanPjm
        '
        Me.LbNoPinjamanPjm.AutoSize = True
        Me.LbNoPinjamanPjm.Location = New System.Drawing.Point(6, 24)
        Me.LbNoPinjamanPjm.Name = "LbNoPinjamanPjm"
        Me.LbNoPinjamanPjm.Size = New System.Drawing.Size(104, 17)
        Me.LbNoPinjamanPjm.TabIndex = 19
        Me.LbNoPinjamanPjm.Text = "No. Pinjaman : "
        '
        'BtnClosePjm
        '
        Me.BtnClosePjm.Location = New System.Drawing.Point(256, 200)
        Me.BtnClosePjm.Name = "BtnClosePjm"
        Me.BtnClosePjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnClosePjm.TabIndex = 18
        Me.BtnClosePjm.Text = "Selesai"
        Me.BtnClosePjm.UseVisualStyleBackColor = True
        '
        'BtnDeletePjm
        '
        Me.BtnDeletePjm.Location = New System.Drawing.Point(337, 200)
        Me.BtnDeletePjm.Name = "BtnDeletePjm"
        Me.BtnDeletePjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeletePjm.TabIndex = 17
        Me.BtnDeletePjm.Text = "Hapus"
        Me.BtnDeletePjm.UseVisualStyleBackColor = True
        '
        'BtnClearPjm
        '
        Me.BtnClearPjm.Location = New System.Drawing.Point(175, 200)
        Me.BtnClearPjm.Name = "BtnClearPjm"
        Me.BtnClearPjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearPjm.TabIndex = 16
        Me.BtnClearPjm.Text = "Clear"
        Me.BtnClearPjm.UseVisualStyleBackColor = True
        '
        'BtnSimpanPjm
        '
        Me.BtnSimpanPjm.Location = New System.Drawing.Point(94, 200)
        Me.BtnSimpanPjm.Name = "BtnSimpanPjm"
        Me.BtnSimpanPjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpanPjm.TabIndex = 15
        Me.BtnSimpanPjm.Text = "Simpan"
        Me.BtnSimpanPjm.UseVisualStyleBackColor = True
        '
        'DgPeminjaman
        '
        Me.DgPeminjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPeminjaman.Location = New System.Drawing.Point(25, 254)
        Me.DgPeminjaman.Name = "DgPeminjaman"
        Me.DgPeminjaman.RowTemplate.Height = 24
        Me.DgPeminjaman.Size = New System.Drawing.Size(824, 217)
        Me.DgPeminjaman.TabIndex = 14
        '
        'LbTglPinjamPjm
        '
        Me.LbTglPinjamPjm.AutoSize = True
        Me.LbTglPinjamPjm.Location = New System.Drawing.Point(6, 121)
        Me.LbTglPinjamPjm.Name = "LbTglPinjamPjm"
        Me.LbTglPinjamPjm.Size = New System.Drawing.Size(86, 17)
        Me.LbTglPinjamPjm.TabIndex = 26
        Me.LbTglPinjamPjm.Text = "Tgl Pinjam : "
        '
        'LbTglKembaliPjm
        '
        Me.LbTglKembaliPjm.AutoSize = True
        Me.LbTglKembaliPjm.Location = New System.Drawing.Point(6, 159)
        Me.LbTglKembaliPjm.Name = "LbTglKembaliPjm"
        Me.LbTglKembaliPjm.Size = New System.Drawing.Size(94, 17)
        Me.LbTglKembaliPjm.TabIndex = 28
        Me.LbTglKembaliPjm.Text = "Tgl Kembali : "
        '
        'DpTglPinjamPjm
        '
        Me.DpTglPinjamPjm.CustomFormat = "yyyy-MM-dd"
        Me.DpTglPinjamPjm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DpTglPinjamPjm.Location = New System.Drawing.Point(111, 121)
        Me.DpTglPinjamPjm.Name = "DpTglPinjamPjm"
        Me.DpTglPinjamPjm.Size = New System.Drawing.Size(114, 22)
        Me.DpTglPinjamPjm.TabIndex = 30
        '
        'DpTglKembaliPjm
        '
        Me.DpTglKembaliPjm.CustomFormat = "yyyy-MM-dd"
        Me.DpTglKembaliPjm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DpTglKembaliPjm.Location = New System.Drawing.Point(111, 159)
        Me.DpTglKembaliPjm.Name = "DpTglKembaliPjm"
        Me.DpTglKembaliPjm.Size = New System.Drawing.Size(114, 22)
        Me.DpTglKembaliPjm.TabIndex = 31
        Me.DpTglKembaliPjm.Value = New Date(2022, 11, 27, 18, 42, 20, 0)
        '
        'BtnMenuPjm
        '
        Me.BtnMenuPjm.Location = New System.Drawing.Point(642, 212)
        Me.BtnMenuPjm.Name = "BtnMenuPjm"
        Me.BtnMenuPjm.Size = New System.Drawing.Size(123, 36)
        Me.BtnMenuPjm.TabIndex = 32
        Me.BtnMenuPjm.Text = "Back to Menu"
        Me.BtnMenuPjm.UseVisualStyleBackColor = True
        '
        'GbMenuPjm
        '
        Me.GbMenuPjm.Controls.Add(Me.CbIdAnggota)
        Me.GbMenuPjm.Controls.Add(Me.CbIdBuku)
        Me.GbMenuPjm.Controls.Add(Me.BtnEditPjm)
        Me.GbMenuPjm.Controls.Add(Me.LbNoPinjamanPjm)
        Me.GbMenuPjm.Controls.Add(Me.LbIdBukuPjm)
        Me.GbMenuPjm.Controls.Add(Me.DpTglKembaliPjm)
        Me.GbMenuPjm.Controls.Add(Me.BtnClosePjm)
        Me.GbMenuPjm.Controls.Add(Me.LbIdAnggotaPjm)
        Me.GbMenuPjm.Controls.Add(Me.BtnDeletePjm)
        Me.GbMenuPjm.Controls.Add(Me.BtnClearPjm)
        Me.GbMenuPjm.Controls.Add(Me.DpTglPinjamPjm)
        Me.GbMenuPjm.Controls.Add(Me.BtnSimpanPjm)
        Me.GbMenuPjm.Controls.Add(Me.TxtNoPinjamanPjm)
        Me.GbMenuPjm.Controls.Add(Me.LbTglKembaliPjm)
        Me.GbMenuPjm.Controls.Add(Me.LbTglPinjamPjm)
        Me.GbMenuPjm.Location = New System.Drawing.Point(12, 12)
        Me.GbMenuPjm.Name = "GbMenuPjm"
        Me.GbMenuPjm.Size = New System.Drawing.Size(421, 236)
        Me.GbMenuPjm.TabIndex = 33
        Me.GbMenuPjm.TabStop = False
        Me.GbMenuPjm.Text = "Input Data"
        '
        'CbIdAnggota
        '
        Me.CbIdAnggota.FormattingEnabled = True
        Me.CbIdAnggota.Location = New System.Drawing.Point(111, 91)
        Me.CbIdAnggota.Name = "CbIdAnggota"
        Me.CbIdAnggota.Size = New System.Drawing.Size(282, 24)
        Me.CbIdAnggota.TabIndex = 34
        '
        'CbIdBuku
        '
        Me.CbIdBuku.FormattingEnabled = True
        Me.CbIdBuku.Location = New System.Drawing.Point(111, 53)
        Me.CbIdBuku.Name = "CbIdBuku"
        Me.CbIdBuku.Size = New System.Drawing.Size(282, 24)
        Me.CbIdBuku.TabIndex = 33
        '
        'BtnEditPjm
        '
        Me.BtnEditPjm.Location = New System.Drawing.Point(13, 198)
        Me.BtnEditPjm.Name = "BtnEditPjm"
        Me.BtnEditPjm.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditPjm.TabIndex = 32
        Me.BtnEditPjm.Text = "Edit"
        Me.BtnEditPjm.UseVisualStyleBackColor = True
        '
        'LbNamaBukuPjm
        '
        Me.LbNamaBukuPjm.AutoSize = True
        Me.LbNamaBukuPjm.Location = New System.Drawing.Point(439, 148)
        Me.LbNamaBukuPjm.Name = "LbNamaBukuPjm"
        Me.LbNamaBukuPjm.Size = New System.Drawing.Size(93, 17)
        Me.LbNamaBukuPjm.TabIndex = 34
        Me.LbNamaBukuPjm.Text = "Nama Buku : "
        '
        'TxtNamaBukuPjm
        '
        Me.TxtNamaBukuPjm.Location = New System.Drawing.Point(558, 148)
        Me.TxtNamaBukuPjm.Name = "TxtNamaBukuPjm"
        Me.TxtNamaBukuPjm.Size = New System.Drawing.Size(207, 22)
        Me.TxtNamaBukuPjm.TabIndex = 35
        '
        'LbNamaAnggotaPjm
        '
        Me.LbNamaAnggotaPjm.AutoSize = True
        Me.LbNamaAnggotaPjm.Location = New System.Drawing.Point(439, 184)
        Me.LbNamaAnggotaPjm.Name = "LbNamaAnggotaPjm"
        Me.LbNamaAnggotaPjm.Size = New System.Drawing.Size(110, 17)
        Me.LbNamaAnggotaPjm.TabIndex = 36
        Me.LbNamaAnggotaPjm.Text = "Nama Anggota :"
        '
        'TxtNamaAnggotaPjm
        '
        Me.TxtNamaAnggotaPjm.Location = New System.Drawing.Point(558, 184)
        Me.TxtNamaAnggotaPjm.Name = "TxtNamaAnggotaPjm"
        Me.TxtNamaAnggotaPjm.Size = New System.Drawing.Size(207, 22)
        Me.TxtNamaAnggotaPjm.TabIndex = 37
        '
        'DatabasePeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(871, 494)
        Me.Controls.Add(Me.TxtNamaAnggotaPjm)
        Me.Controls.Add(Me.LbNamaAnggotaPjm)
        Me.Controls.Add(Me.TxtNamaBukuPjm)
        Me.Controls.Add(Me.LbNamaBukuPjm)
        Me.Controls.Add(Me.GbMenuPjm)
        Me.Controls.Add(Me.BtnMenuPjm)
        Me.Controls.Add(Me.GbDeletePjm)
        Me.Controls.Add(Me.DgPeminjaman)
        Me.Name = "DatabasePeminjaman"
        Me.Text = "DatabasePeminjaman"
        Me.GbDeletePjm.ResumeLayout(False)
        Me.GbDeletePjm.PerformLayout()
        CType(Me.DgPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMenuPjm.ResumeLayout(False)
        Me.GbMenuPjm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbDeletePjm As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelCancelPjm As System.Windows.Forms.Button
    Friend WithEvents BtnDelConfirmPjm As System.Windows.Forms.Button
    Friend WithEvents TxtIdDeletePjm As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoPinjamanPjm As System.Windows.Forms.TextBox
    Friend WithEvents LbIdAnggotaPjm As System.Windows.Forms.Label
    Friend WithEvents LbIdBukuPjm As System.Windows.Forms.Label
    Friend WithEvents LbNoPinjamanPjm As System.Windows.Forms.Label
    Friend WithEvents BtnClosePjm As System.Windows.Forms.Button
    Friend WithEvents BtnDeletePjm As System.Windows.Forms.Button
    Friend WithEvents BtnClearPjm As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanPjm As System.Windows.Forms.Button
    Friend WithEvents DgPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents LbTglPinjamPjm As System.Windows.Forms.Label
    Friend WithEvents LbTglKembaliPjm As System.Windows.Forms.Label
    Friend WithEvents DpTglPinjamPjm As System.Windows.Forms.DateTimePicker
    Friend WithEvents DpTglKembaliPjm As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnMenuPjm As System.Windows.Forms.Button
    Friend WithEvents GbMenuPjm As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEditPjm As System.Windows.Forms.Button
    Friend WithEvents CbIdBuku As System.Windows.Forms.ComboBox
    Friend WithEvents LbNamaBukuPjm As System.Windows.Forms.Label
    Friend WithEvents TxtNamaBukuPjm As System.Windows.Forms.TextBox
    Friend WithEvents CbIdAnggota As System.Windows.Forms.ComboBox
    Friend WithEvents LbNamaAnggotaPjm As System.Windows.Forms.Label
    Friend WithEvents TxtNamaAnggotaPjm As System.Windows.Forms.TextBox
End Class
