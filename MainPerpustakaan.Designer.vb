<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPerpustakaan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.CbTable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.BtnGo)
        Me.GroupBox1.Controls.Add(Me.CbTable)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aplikasi Database Perpustakaan"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(464, 241)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(556, 241)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 2
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'CbTable
        '
        Me.CbTable.FormattingEnabled = True
        Me.CbTable.Location = New System.Drawing.Point(122, 137)
        Me.CbTable.Name = "CbTable"
        Me.CbTable.Size = New System.Drawing.Size(237, 24)
        Me.CbTable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Menu :"
        '
        'MainPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 377)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainPerpustakaan"
        Me.Text = "MainPerpustakaan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents CbTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
