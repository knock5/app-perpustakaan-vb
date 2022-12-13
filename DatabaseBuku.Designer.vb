<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseBuku
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
        Me.DgBuku = New System.Windows.Forms.DataGridView()
        Me.BtnSimpanBuku = New System.Windows.Forms.Button()
        Me.BtnClearBuku = New System.Windows.Forms.Button()
        Me.BtnDeleteBuku = New System.Windows.Forms.Button()
        Me.BtnCloseBuku = New System.Windows.Forms.Button()
        Me.LbJudulBuku = New System.Windows.Forms.Label()
        Me.LbPengarang = New System.Windows.Forms.Label()
        Me.LbPenerbit = New System.Windows.Forms.Label()
        Me.TxtJudulBuku = New System.Windows.Forms.TextBox()
        Me.TxtPengarangBuku = New System.Windows.Forms.TextBox()
        Me.TxtPenerbitBuku = New System.Windows.Forms.TextBox()
        Me.GbDeleteBuku = New System.Windows.Forms.GroupBox()
        Me.BtnDelCancelBuku = New System.Windows.Forms.Button()
        Me.BtnDelConfirmBuku = New System.Windows.Forms.Button()
        Me.BtnMenuBuku = New System.Windows.Forms.Button()
        Me.BtnEditBuku = New System.Windows.Forms.Button()
        Me.LbIdBuku = New System.Windows.Forms.Label()
        Me.GbMenuBuku = New System.Windows.Forms.GroupBox()
        Me.CbIdDeleteBuku = New System.Windows.Forms.ComboBox()
        Me.CbIdBukuList = New System.Windows.Forms.ComboBox()
        Me.BtnConfirmUpdateBuku = New System.Windows.Forms.Button()
        Me.BtnCancelBuku = New System.Windows.Forms.Button()
        CType(Me.DgBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDeleteBuku.SuspendLayout()
        Me.GbMenuBuku.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgBuku
        '
        Me.DgBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBuku.Location = New System.Drawing.Point(12, 264)
        Me.DgBuku.Name = "DgBuku"
        Me.DgBuku.RowTemplate.Height = 24
        Me.DgBuku.Size = New System.Drawing.Size(824, 208)
        Me.DgBuku.TabIndex = 0
        '
        'BtnSimpanBuku
        '
        Me.BtnSimpanBuku.Location = New System.Drawing.Point(93, 185)
        Me.BtnSimpanBuku.Name = "BtnSimpanBuku"
        Me.BtnSimpanBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpanBuku.TabIndex = 1
        Me.BtnSimpanBuku.Text = "Simpan"
        Me.BtnSimpanBuku.UseVisualStyleBackColor = True
        '
        'BtnClearBuku
        '
        Me.BtnClearBuku.Location = New System.Drawing.Point(174, 185)
        Me.BtnClearBuku.Name = "BtnClearBuku"
        Me.BtnClearBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearBuku.TabIndex = 2
        Me.BtnClearBuku.Text = "Clear"
        Me.BtnClearBuku.UseVisualStyleBackColor = True
        '
        'BtnDeleteBuku
        '
        Me.BtnDeleteBuku.Location = New System.Drawing.Point(336, 185)
        Me.BtnDeleteBuku.Name = "BtnDeleteBuku"
        Me.BtnDeleteBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteBuku.TabIndex = 3
        Me.BtnDeleteBuku.Text = "Hapus"
        Me.BtnDeleteBuku.UseVisualStyleBackColor = True
        '
        'BtnCloseBuku
        '
        Me.BtnCloseBuku.Location = New System.Drawing.Point(255, 185)
        Me.BtnCloseBuku.Name = "BtnCloseBuku"
        Me.BtnCloseBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseBuku.TabIndex = 4
        Me.BtnCloseBuku.Text = "Selesai"
        Me.BtnCloseBuku.UseVisualStyleBackColor = True
        '
        'LbJudulBuku
        '
        Me.LbJudulBuku.AutoSize = True
        Me.LbJudulBuku.Location = New System.Drawing.Point(14, 64)
        Me.LbJudulBuku.Name = "LbJudulBuku"
        Me.LbJudulBuku.Size = New System.Drawing.Size(90, 17)
        Me.LbJudulBuku.TabIndex = 7
        Me.LbJudulBuku.Text = "Judul Buku : "
        '
        'LbPengarang
        '
        Me.LbPengarang.AutoSize = True
        Me.LbPengarang.Location = New System.Drawing.Point(14, 106)
        Me.LbPengarang.Name = "LbPengarang"
        Me.LbPengarang.Size = New System.Drawing.Size(90, 17)
        Me.LbPengarang.TabIndex = 8
        Me.LbPengarang.Text = "Pengarang : "
        '
        'LbPenerbit
        '
        Me.LbPenerbit.AutoSize = True
        Me.LbPenerbit.Location = New System.Drawing.Point(14, 149)
        Me.LbPenerbit.Name = "LbPenerbit"
        Me.LbPenerbit.Size = New System.Drawing.Size(73, 17)
        Me.LbPenerbit.TabIndex = 9
        Me.LbPenerbit.Text = "Penerbit : "
        '
        'TxtJudulBuku
        '
        Me.TxtJudulBuku.Location = New System.Drawing.Point(119, 64)
        Me.TxtJudulBuku.Name = "TxtJudulBuku"
        Me.TxtJudulBuku.Size = New System.Drawing.Size(282, 22)
        Me.TxtJudulBuku.TabIndex = 10
        '
        'TxtPengarangBuku
        '
        Me.TxtPengarangBuku.Location = New System.Drawing.Point(119, 103)
        Me.TxtPengarangBuku.Name = "TxtPengarangBuku"
        Me.TxtPengarangBuku.Size = New System.Drawing.Size(282, 22)
        Me.TxtPengarangBuku.TabIndex = 11
        '
        'TxtPenerbitBuku
        '
        Me.TxtPenerbitBuku.Location = New System.Drawing.Point(119, 144)
        Me.TxtPenerbitBuku.Name = "TxtPenerbitBuku"
        Me.TxtPenerbitBuku.Size = New System.Drawing.Size(282, 22)
        Me.TxtPenerbitBuku.TabIndex = 12
        '
        'GbDeleteBuku
        '
        Me.GbDeleteBuku.Controls.Add(Me.CbIdDeleteBuku)
        Me.GbDeleteBuku.Controls.Add(Me.BtnDelCancelBuku)
        Me.GbDeleteBuku.Controls.Add(Me.BtnDelConfirmBuku)
        Me.GbDeleteBuku.Location = New System.Drawing.Point(508, 43)
        Me.GbDeleteBuku.Name = "GbDeleteBuku"
        Me.GbDeleteBuku.Size = New System.Drawing.Size(314, 142)
        Me.GbDeleteBuku.TabIndex = 13
        Me.GbDeleteBuku.TabStop = False
        Me.GbDeleteBuku.Text = "ID Buku"
        '
        'BtnDelCancelBuku
        '
        Me.BtnDelCancelBuku.Location = New System.Drawing.Point(151, 72)
        Me.BtnDelCancelBuku.Name = "BtnDelCancelBuku"
        Me.BtnDelCancelBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelCancelBuku.TabIndex = 2
        Me.BtnDelCancelBuku.Text = "Batal"
        Me.BtnDelCancelBuku.UseVisualStyleBackColor = True
        '
        'BtnDelConfirmBuku
        '
        Me.BtnDelConfirmBuku.Location = New System.Drawing.Point(232, 72)
        Me.BtnDelConfirmBuku.Name = "BtnDelConfirmBuku"
        Me.BtnDelConfirmBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelConfirmBuku.TabIndex = 1
        Me.BtnDelConfirmBuku.Text = "Oke"
        Me.BtnDelConfirmBuku.UseVisualStyleBackColor = True
        '
        'BtnMenuBuku
        '
        Me.BtnMenuBuku.Location = New System.Drawing.Point(594, 213)
        Me.BtnMenuBuku.Name = "BtnMenuBuku"
        Me.BtnMenuBuku.Size = New System.Drawing.Size(112, 23)
        Me.BtnMenuBuku.TabIndex = 33
        Me.BtnMenuBuku.Text = "Back to Menu"
        Me.BtnMenuBuku.UseVisualStyleBackColor = True
        '
        'BtnEditBuku
        '
        Me.BtnEditBuku.Location = New System.Drawing.Point(12, 185)
        Me.BtnEditBuku.Name = "BtnEditBuku"
        Me.BtnEditBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditBuku.TabIndex = 34
        Me.BtnEditBuku.Text = "Edit"
        Me.BtnEditBuku.UseVisualStyleBackColor = True
        '
        'LbIdBuku
        '
        Me.LbIdBuku.AutoSize = True
        Me.LbIdBuku.Location = New System.Drawing.Point(17, 25)
        Me.LbIdBuku.Name = "LbIdBuku"
        Me.LbIdBuku.Size = New System.Drawing.Size(65, 17)
        Me.LbIdBuku.TabIndex = 35
        Me.LbIdBuku.Text = "ID Buku :"
        '
        'GbMenuBuku
        '
        Me.GbMenuBuku.Controls.Add(Me.BtnCancelBuku)
        Me.GbMenuBuku.Controls.Add(Me.BtnConfirmUpdateBuku)
        Me.GbMenuBuku.Controls.Add(Me.CbIdBukuList)
        Me.GbMenuBuku.Controls.Add(Me.TxtPenerbitBuku)
        Me.GbMenuBuku.Controls.Add(Me.BtnEditBuku)
        Me.GbMenuBuku.Controls.Add(Me.LbJudulBuku)
        Me.GbMenuBuku.Controls.Add(Me.LbIdBuku)
        Me.GbMenuBuku.Controls.Add(Me.BtnCloseBuku)
        Me.GbMenuBuku.Controls.Add(Me.LbPengarang)
        Me.GbMenuBuku.Controls.Add(Me.BtnDeleteBuku)
        Me.GbMenuBuku.Controls.Add(Me.BtnClearBuku)
        Me.GbMenuBuku.Controls.Add(Me.LbPenerbit)
        Me.GbMenuBuku.Controls.Add(Me.BtnSimpanBuku)
        Me.GbMenuBuku.Controls.Add(Me.TxtJudulBuku)
        Me.GbMenuBuku.Controls.Add(Me.TxtPengarangBuku)
        Me.GbMenuBuku.Location = New System.Drawing.Point(12, 12)
        Me.GbMenuBuku.Name = "GbMenuBuku"
        Me.GbMenuBuku.Size = New System.Drawing.Size(490, 224)
        Me.GbMenuBuku.TabIndex = 37
        Me.GbMenuBuku.TabStop = False
        Me.GbMenuBuku.Text = "Input Data"
        '
        'CbIdDeleteBuku
        '
        Me.CbIdDeleteBuku.FormattingEnabled = True
        Me.CbIdDeleteBuku.Location = New System.Drawing.Point(32, 26)
        Me.CbIdDeleteBuku.Name = "CbIdDeleteBuku"
        Me.CbIdDeleteBuku.Size = New System.Drawing.Size(250, 24)
        Me.CbIdDeleteBuku.TabIndex = 3
        '
        'CbIdBukuList
        '
        Me.CbIdBukuList.FormattingEnabled = True
        Me.CbIdBukuList.Location = New System.Drawing.Point(119, 25)
        Me.CbIdBukuList.Name = "CbIdBukuList"
        Me.CbIdBukuList.Size = New System.Drawing.Size(191, 24)
        Me.CbIdBukuList.TabIndex = 36
        '
        'BtnConfirmUpdateBuku
        '
        Me.BtnConfirmUpdateBuku.Location = New System.Drawing.Point(326, 26)
        Me.BtnConfirmUpdateBuku.Name = "BtnConfirmUpdateBuku"
        Me.BtnConfirmUpdateBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirmUpdateBuku.TabIndex = 37
        Me.BtnConfirmUpdateBuku.Text = "Update"
        Me.BtnConfirmUpdateBuku.UseVisualStyleBackColor = True
        '
        'BtnCancelBuku
        '
        Me.BtnCancelBuku.Location = New System.Drawing.Point(407, 26)
        Me.BtnCancelBuku.Name = "BtnCancelBuku"
        Me.BtnCancelBuku.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelBuku.TabIndex = 38
        Me.BtnCancelBuku.Text = "Cancel"
        Me.BtnCancelBuku.UseVisualStyleBackColor = True
        '
        'DatabaseBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(848, 484)
        Me.Controls.Add(Me.GbMenuBuku)
        Me.Controls.Add(Me.BtnMenuBuku)
        Me.Controls.Add(Me.GbDeleteBuku)
        Me.Controls.Add(Me.DgBuku)
        Me.Name = "DatabaseBuku"
        Me.Text = "Database Buku"
        CType(Me.DgBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDeleteBuku.ResumeLayout(False)
        Me.GbMenuBuku.ResumeLayout(False)
        Me.GbMenuBuku.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgBuku As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSimpanBuku As System.Windows.Forms.Button
    Friend WithEvents BtnClearBuku As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteBuku As System.Windows.Forms.Button
    Friend WithEvents BtnCloseBuku As System.Windows.Forms.Button
    Friend WithEvents LbJudulBuku As System.Windows.Forms.Label
    Friend WithEvents LbPengarang As System.Windows.Forms.Label
    Friend WithEvents LbPenerbit As System.Windows.Forms.Label
    Friend WithEvents TxtJudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtPengarangBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtPenerbitBuku As System.Windows.Forms.TextBox
    Friend WithEvents GbDeleteBuku As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelCancelBuku As System.Windows.Forms.Button
    Friend WithEvents BtnDelConfirmBuku As System.Windows.Forms.Button
    Friend WithEvents BtnMenuBuku As System.Windows.Forms.Button
    Friend WithEvents BtnEditBuku As System.Windows.Forms.Button
    Friend WithEvents LbIdBuku As System.Windows.Forms.Label
    Friend WithEvents GbMenuBuku As System.Windows.Forms.GroupBox
    Friend WithEvents CbIdDeleteBuku As System.Windows.Forms.ComboBox
    Friend WithEvents BtnConfirmUpdateBuku As System.Windows.Forms.Button
    Friend WithEvents CbIdBukuList As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancelBuku As System.Windows.Forms.Button

End Class
