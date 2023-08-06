<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Peminjaman))
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_simpan = New System.Windows.Forms.Button()
        Me.dgv_peminjaman = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_id_pegawai = New System.Windows.Forms.TextBox()
        Me.tb_id_anggota = New System.Windows.Forms.TextBox()
        Me.dtp_pinjam = New System.Windows.Forms.DateTimePicker()
        Me.tb_nama_pegawai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nama_anggota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_nopin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LandingPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariDataPeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_edit
        '
        Me.bt_edit.Location = New System.Drawing.Point(514, 403)
        Me.bt_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(147, 36)
        Me.bt_edit.TabIndex = 30
        Me.bt_edit.Text = "Clear"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_simpan
        '
        Me.bt_simpan.Location = New System.Drawing.Point(138, 403)
        Me.bt_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Size = New System.Drawing.Size(150, 36)
        Me.bt_simpan.TabIndex = 29
        Me.bt_simpan.Text = "Simpan"
        Me.bt_simpan.UseVisualStyleBackColor = True
        '
        'dgv_peminjaman
        '
        Me.dgv_peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_peminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column1})
        Me.dgv_peminjaman.Location = New System.Drawing.Point(54, 268)
        Me.dgv_peminjaman.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_peminjaman.Name = "dgv_peminjaman"
        Me.dgv_peminjaman.RowHeadersWidth = 62
        Me.dgv_peminjaman.RowTemplate.Height = 28
        Me.dgv_peminjaman.Size = New System.Drawing.Size(707, 114)
        Me.dgv_peminjaman.TabIndex = 28
        '
        'Column2
        '
        Me.Column2.HeaderText = "Id Buku"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nama Buku"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tanggal Harus Kembali"
        Me.Column5.Name = "Column5"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Status"
        Me.Column1.Name = "Column1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 69)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 20)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_id_pegawai
        '
        Me.tb_id_pegawai.Location = New System.Drawing.Point(315, 33)
        Me.tb_id_pegawai.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_pegawai.Name = "tb_id_pegawai"
        Me.tb_id_pegawai.ReadOnly = True
        Me.tb_id_pegawai.Size = New System.Drawing.Size(141, 20)
        Me.tb_id_pegawai.TabIndex = 26
        '
        'tb_id_anggota
        '
        Me.tb_id_anggota.Location = New System.Drawing.Point(315, 69)
        Me.tb_id_anggota.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_anggota.Name = "tb_id_anggota"
        Me.tb_id_anggota.ReadOnly = True
        Me.tb_id_anggota.Size = New System.Drawing.Size(141, 20)
        Me.tb_id_anggota.TabIndex = 25
        '
        'dtp_pinjam
        '
        Me.dtp_pinjam.Location = New System.Drawing.Point(163, 103)
        Me.dtp_pinjam.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_pinjam.Name = "dtp_pinjam"
        Me.dtp_pinjam.Size = New System.Drawing.Size(332, 20)
        Me.dtp_pinjam.TabIndex = 5
        Me.dtp_pinjam.Value = New Date(2023, 8, 2, 0, 0, 0, 0)
        '
        'tb_nama_pegawai
        '
        Me.tb_nama_pegawai.Location = New System.Drawing.Point(163, 33)
        Me.tb_nama_pegawai.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_pegawai.Name = "tb_nama_pegawai"
        Me.tb_nama_pegawai.Size = New System.Drawing.Size(141, 20)
        Me.tb_nama_pegawai.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(-3, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 40)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Peminjaman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(18, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(18, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tanggal Peminjaman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(18, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nama"
        '
        'tb_nama_anggota
        '
        Me.tb_nama_anggota.Location = New System.Drawing.Point(163, 69)
        Me.tb_nama_anggota.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_anggota.Name = "tb_nama_anggota"
        Me.tb_nama_anggota.Size = New System.Drawing.Size(141, 20)
        Me.tb_nama_anggota.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(18, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "id_peminjaman"
        '
        'lb_nopin
        '
        Me.lb_nopin.AutoSize = True
        Me.lb_nopin.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lb_nopin.Location = New System.Drawing.Point(160, 142)
        Me.lb_nopin.Name = "lb_nopin"
        Me.lb_nopin.Size = New System.Drawing.Size(28, 13)
        Me.lb_nopin.TabIndex = 34
        Me.lb_nopin.Text = "......."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lb_nopin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tb_id_pegawai)
        Me.GroupBox1.Controls.Add(Me.tb_id_anggota)
        Me.GroupBox1.Controls.Add(Me.dtp_pinjam)
        Me.GroupBox1.Controls.Add(Me.tb_nama_pegawai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_nama_anggota)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 178)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(802, 49)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LandingPageToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LandingPageToolStripMenuItem
        '
        Me.LandingPageToolStripMenuItem.Name = "LandingPageToolStripMenuItem"
        Me.LandingPageToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LandingPageToolStripMenuItem.Text = "Keluar"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengembalianToolStripMenuItem, Me.CariDataPeminjamToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'CariDataPeminjamToolStripMenuItem
        '
        Me.CariDataPeminjamToolStripMenuItem.Name = "CariDataPeminjamToolStripMenuItem"
        Me.CariDataPeminjamToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CariDataPeminjamToolStripMenuItem.Text = "Cari Data  Buku"
        '
        'Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.dgv_peminjaman)
        Me.Name = "Peminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman"
        CType(Me.dgv_peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_edit As Button
    Friend WithEvents bt_simpan As Button
    Friend WithEvents dgv_peminjaman As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_id_pegawai As TextBox
    Friend WithEvents tb_id_anggota As TextBox
    Friend WithEvents dtp_pinjam As DateTimePicker
    Friend WithEvents tb_nama_pegawai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nama_anggota As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_nopin As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LandingPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariDataPeminjamToolStripMenuItem As ToolStripMenuItem
End Class
