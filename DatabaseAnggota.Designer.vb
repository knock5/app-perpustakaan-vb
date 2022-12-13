<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseAnggota
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
        Me.GbDeleteAnggota = New System.Windows.Forms.GroupBox()
        Me.BtnDelCancelAnggota = New System.Windows.Forms.Button()
        Me.BtnDelConfirmAnggota = New System.Windows.Forms.Button()
        Me.TxtIdDeleteAnggota = New System.Windows.Forms.TextBox()
        Me.TxtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.TxtIdAnggota = New System.Windows.Forms.TextBox()
        Me.LbJkAnggota = New System.Windows.Forms.Label()
        Me.LbNamaAnggota = New System.Windows.Forms.Label()
        Me.LbIdAnggota = New System.Windows.Forms.Label()
        Me.BtnCloseAnggota = New System.Windows.Forms.Button()
        Me.BtnDeleteAnggota = New System.Windows.Forms.Button()
        Me.BtnClearAnggota = New System.Windows.Forms.Button()
        Me.BtnSimpanAnggota = New System.Windows.Forms.Button()
        Me.DgAnggota = New System.Windows.Forms.DataGridView()
        Me.TxtAlamatAnggota = New System.Windows.Forms.TextBox()
        Me.LbAlamatAnggota = New System.Windows.Forms.Label()
        Me.CbJkAnggota = New System.Windows.Forms.ComboBox()
        Me.BtnMenuAnggota = New System.Windows.Forms.Button()
        Me.BtnEditAnggota = New System.Windows.Forms.Button()
        Me.GbMenuAnggota = New System.Windows.Forms.GroupBox()
        Me.GbDeleteAnggota.SuspendLayout()
        CType(Me.DgAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMenuAnggota.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDeleteAnggota
        '
        Me.GbDeleteAnggota.Controls.Add(Me.BtnDelCancelAnggota)
        Me.GbDeleteAnggota.Controls.Add(Me.BtnDelConfirmAnggota)
        Me.GbDeleteAnggota.Controls.Add(Me.TxtIdDeleteAnggota)
        Me.GbDeleteAnggota.Location = New System.Drawing.Point(528, 28)
        Me.GbDeleteAnggota.Name = "GbDeleteAnggota"
        Me.GbDeleteAnggota.Size = New System.Drawing.Size(326, 142)
        Me.GbDeleteAnggota.TabIndex = 25
        Me.GbDeleteAnggota.TabStop = False
        Me.GbDeleteAnggota.Text = "ID Anggota"
        '
        'BtnDelCancelAnggota
        '
        Me.BtnDelCancelAnggota.Location = New System.Drawing.Point(151, 85)
        Me.BtnDelCancelAnggota.Name = "BtnDelCancelAnggota"
        Me.BtnDelCancelAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelCancelAnggota.TabIndex = 2
        Me.BtnDelCancelAnggota.Text = "Batal"
        Me.BtnDelCancelAnggota.UseVisualStyleBackColor = True
        '
        'BtnDelConfirmAnggota
        '
        Me.BtnDelConfirmAnggota.Location = New System.Drawing.Point(232, 85)
        Me.BtnDelConfirmAnggota.Name = "BtnDelConfirmAnggota"
        Me.BtnDelConfirmAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelConfirmAnggota.TabIndex = 1
        Me.BtnDelConfirmAnggota.Text = "Oke"
        Me.BtnDelConfirmAnggota.UseVisualStyleBackColor = True
        '
        'TxtIdDeleteAnggota
        '
        Me.TxtIdDeleteAnggota.Location = New System.Drawing.Point(6, 31)
        Me.TxtIdDeleteAnggota.Name = "TxtIdDeleteAnggota"
        Me.TxtIdDeleteAnggota.Size = New System.Drawing.Size(301, 22)
        Me.TxtIdDeleteAnggota.TabIndex = 0
        '
        'TxtNamaAnggota
        '
        Me.TxtNamaAnggota.Location = New System.Drawing.Point(133, 62)
        Me.TxtNamaAnggota.Name = "TxtNamaAnggota"
        Me.TxtNamaAnggota.Size = New System.Drawing.Size(282, 22)
        Me.TxtNamaAnggota.TabIndex = 23
        '
        'TxtIdAnggota
        '
        Me.TxtIdAnggota.Location = New System.Drawing.Point(133, 28)
        Me.TxtIdAnggota.Name = "TxtIdAnggota"
        Me.TxtIdAnggota.Size = New System.Drawing.Size(282, 22)
        Me.TxtIdAnggota.TabIndex = 22
        '
        'LbJkAnggota
        '
        Me.LbJkAnggota.AutoSize = True
        Me.LbJkAnggota.Location = New System.Drawing.Point(20, 105)
        Me.LbJkAnggota.Name = "LbJkAnggota"
        Me.LbJkAnggota.Size = New System.Drawing.Size(107, 17)
        Me.LbJkAnggota.TabIndex = 21
        Me.LbJkAnggota.Text = "Jenis Kelamin : "
        '
        'LbNamaAnggota
        '
        Me.LbNamaAnggota.AutoSize = True
        Me.LbNamaAnggota.Location = New System.Drawing.Point(20, 65)
        Me.LbNamaAnggota.Name = "LbNamaAnggota"
        Me.LbNamaAnggota.Size = New System.Drawing.Size(57, 17)
        Me.LbNamaAnggota.TabIndex = 20
        Me.LbNamaAnggota.Text = "Nama : "
        '
        'LbIdAnggota
        '
        Me.LbIdAnggota.AutoSize = True
        Me.LbIdAnggota.Location = New System.Drawing.Point(20, 31)
        Me.LbIdAnggota.Name = "LbIdAnggota"
        Me.LbIdAnggota.Size = New System.Drawing.Size(90, 17)
        Me.LbIdAnggota.TabIndex = 19
        Me.LbIdAnggota.Text = "ID Anggota : "
        '
        'BtnCloseAnggota
        '
        Me.BtnCloseAnggota.Location = New System.Drawing.Point(257, 186)
        Me.BtnCloseAnggota.Name = "BtnCloseAnggota"
        Me.BtnCloseAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseAnggota.TabIndex = 18
        Me.BtnCloseAnggota.Text = "Selesai"
        Me.BtnCloseAnggota.UseVisualStyleBackColor = True
        '
        'BtnDeleteAnggota
        '
        Me.BtnDeleteAnggota.Location = New System.Drawing.Point(340, 186)
        Me.BtnDeleteAnggota.Name = "BtnDeleteAnggota"
        Me.BtnDeleteAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteAnggota.TabIndex = 17
        Me.BtnDeleteAnggota.Text = "Hapus"
        Me.BtnDeleteAnggota.UseVisualStyleBackColor = True
        '
        'BtnClearAnggota
        '
        Me.BtnClearAnggota.Location = New System.Drawing.Point(176, 186)
        Me.BtnClearAnggota.Name = "BtnClearAnggota"
        Me.BtnClearAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearAnggota.TabIndex = 16
        Me.BtnClearAnggota.Text = "Clear"
        Me.BtnClearAnggota.UseVisualStyleBackColor = True
        '
        'BtnSimpanAnggota
        '
        Me.BtnSimpanAnggota.Location = New System.Drawing.Point(95, 186)
        Me.BtnSimpanAnggota.Name = "BtnSimpanAnggota"
        Me.BtnSimpanAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpanAnggota.TabIndex = 15
        Me.BtnSimpanAnggota.Text = "Simpan"
        Me.BtnSimpanAnggota.UseVisualStyleBackColor = True
        '
        'DgAnggota
        '
        Me.DgAnggota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAnggota.Location = New System.Drawing.Point(30, 249)
        Me.DgAnggota.Name = "DgAnggota"
        Me.DgAnggota.RowTemplate.Height = 24
        Me.DgAnggota.Size = New System.Drawing.Size(824, 208)
        Me.DgAnggota.TabIndex = 14
        '
        'TxtAlamatAnggota
        '
        Me.TxtAlamatAnggota.Location = New System.Drawing.Point(133, 139)
        Me.TxtAlamatAnggota.Name = "TxtAlamatAnggota"
        Me.TxtAlamatAnggota.Size = New System.Drawing.Size(282, 22)
        Me.TxtAlamatAnggota.TabIndex = 27
        '
        'LbAlamatAnggota
        '
        Me.LbAlamatAnggota.AutoSize = True
        Me.LbAlamatAnggota.Location = New System.Drawing.Point(20, 144)
        Me.LbAlamatAnggota.Name = "LbAlamatAnggota"
        Me.LbAlamatAnggota.Size = New System.Drawing.Size(63, 17)
        Me.LbAlamatAnggota.TabIndex = 26
        Me.LbAlamatAnggota.Text = "Alamat : "
        '
        'CbJkAnggota
        '
        Me.CbJkAnggota.FormattingEnabled = True
        Me.CbJkAnggota.Location = New System.Drawing.Point(133, 102)
        Me.CbJkAnggota.Name = "CbJkAnggota"
        Me.CbJkAnggota.Size = New System.Drawing.Size(280, 24)
        Me.CbJkAnggota.TabIndex = 28
        '
        'BtnMenuAnggota
        '
        Me.BtnMenuAnggota.Location = New System.Drawing.Point(610, 198)
        Me.BtnMenuAnggota.Name = "BtnMenuAnggota"
        Me.BtnMenuAnggota.Size = New System.Drawing.Size(112, 23)
        Me.BtnMenuAnggota.TabIndex = 29
        Me.BtnMenuAnggota.Text = "Back to Menu"
        Me.BtnMenuAnggota.UseVisualStyleBackColor = True
        '
        'BtnEditAnggota
        '
        Me.BtnEditAnggota.Location = New System.Drawing.Point(14, 186)
        Me.BtnEditAnggota.Name = "BtnEditAnggota"
        Me.BtnEditAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditAnggota.TabIndex = 30
        Me.BtnEditAnggota.Text = "Edit"
        Me.BtnEditAnggota.UseVisualStyleBackColor = True
        '
        'GbMenuAnggota
        '
        Me.GbMenuAnggota.Controls.Add(Me.LbIdAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.BtnEditAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.LbNamaAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.LbJkAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.CbJkAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.BtnCloseAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.TxtIdAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.BtnDeleteAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.BtnClearAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.TxtAlamatAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.BtnSimpanAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.TxtNamaAnggota)
        Me.GbMenuAnggota.Controls.Add(Me.LbAlamatAnggota)
        Me.GbMenuAnggota.Location = New System.Drawing.Point(12, 12)
        Me.GbMenuAnggota.Name = "GbMenuAnggota"
        Me.GbMenuAnggota.Size = New System.Drawing.Size(471, 230)
        Me.GbMenuAnggota.TabIndex = 31
        Me.GbMenuAnggota.TabStop = False
        Me.GbMenuAnggota.Text = "Input Data"
        '
        'DatabaseAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(881, 485)
        Me.Controls.Add(Me.GbMenuAnggota)
        Me.Controls.Add(Me.BtnMenuAnggota)
        Me.Controls.Add(Me.GbDeleteAnggota)
        Me.Controls.Add(Me.DgAnggota)
        Me.Name = "DatabaseAnggota"
        Me.Text = "DatabaseAnggota"
        Me.GbDeleteAnggota.ResumeLayout(False)
        Me.GbDeleteAnggota.PerformLayout()
        CType(Me.DgAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMenuAnggota.ResumeLayout(False)
        Me.GbMenuAnggota.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbDeleteAnggota As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelCancelAnggota As System.Windows.Forms.Button
    Friend WithEvents BtnDelConfirmAnggota As System.Windows.Forms.Button
    Friend WithEvents TxtIdDeleteAnggota As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaAnggota As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdAnggota As System.Windows.Forms.TextBox
    Friend WithEvents LbJkAnggota As System.Windows.Forms.Label
    Friend WithEvents LbNamaAnggota As System.Windows.Forms.Label
    Friend WithEvents LbIdAnggota As System.Windows.Forms.Label
    Friend WithEvents BtnCloseAnggota As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteAnggota As System.Windows.Forms.Button
    Friend WithEvents BtnClearAnggota As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanAnggota As System.Windows.Forms.Button
    Friend WithEvents DgAnggota As System.Windows.Forms.DataGridView
    Friend WithEvents TxtAlamatAnggota As System.Windows.Forms.TextBox
    Friend WithEvents LbAlamatAnggota As System.Windows.Forms.Label
    Friend WithEvents CbJkAnggota As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMenuAnggota As System.Windows.Forms.Button
    Friend WithEvents BtnEditAnggota As System.Windows.Forms.Button
    Friend WithEvents GbMenuAnggota As System.Windows.Forms.GroupBox
End Class
