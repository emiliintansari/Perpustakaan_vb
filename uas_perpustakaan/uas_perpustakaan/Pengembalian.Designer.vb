<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pengembalian))
        Me.lb_noblk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_simpan = New System.Windows.Forms.Button()
        Me.dgv_pengembalian = New System.Windows.Forms.DataGridView()
        Me.tb_id_pegawai = New System.Windows.Forms.TextBox()
        Me.tb_id_anggota = New System.Windows.Forms.TextBox()
        Me.dtp_kembali = New System.Windows.Forms.DateTimePicker()
        Me.tb_nama_pegawai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nama_anggota = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_lihat = New System.Windows.Forms.DataGridView()
        Me.tb_cari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LandingPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemijamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariDataPeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_pengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_lihat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_noblk
        '
        Me.lb_noblk.AutoSize = True
        Me.lb_noblk.Location = New System.Drawing.Point(172, 131)
        Me.lb_noblk.Name = "lb_noblk"
        Me.lb_noblk.Size = New System.Drawing.Size(28, 13)
        Me.lb_noblk.TabIndex = 48
        Me.lb_noblk.Text = "......."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "ID Pengembalian"
        '
        'bt_edit
        '
        Me.bt_edit.Location = New System.Drawing.Point(348, 393)
        Me.bt_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(107, 36)
        Me.bt_edit.TabIndex = 46
        Me.bt_edit.Text = "Clear"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_simpan
        '
        Me.bt_simpan.Location = New System.Drawing.Point(93, 393)
        Me.bt_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Size = New System.Drawing.Size(107, 36)
        Me.bt_simpan.TabIndex = 45
        Me.bt_simpan.Text = "Simpan"
        Me.bt_simpan.UseVisualStyleBackColor = True
        '
        'dgv_pengembalian
        '
        Me.dgv_pengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pengembalian.Location = New System.Drawing.Point(54, 240)
        Me.dgv_pengembalian.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_pengembalian.Name = "dgv_pengembalian"
        Me.dgv_pengembalian.RowHeadersWidth = 62
        Me.dgv_pengembalian.RowTemplate.Height = 28
        Me.dgv_pengembalian.Size = New System.Drawing.Size(727, 149)
        Me.dgv_pengembalian.TabIndex = 44
        '
        'tb_id_pegawai
        '
        Me.tb_id_pegawai.Location = New System.Drawing.Point(323, 24)
        Me.tb_id_pegawai.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_pegawai.Name = "tb_id_pegawai"
        Me.tb_id_pegawai.ReadOnly = True
        Me.tb_id_pegawai.Size = New System.Drawing.Size(141, 20)
        Me.tb_id_pegawai.TabIndex = 42
        '
        'tb_id_anggota
        '
        Me.tb_id_anggota.Location = New System.Drawing.Point(323, 60)
        Me.tb_id_anggota.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_anggota.Name = "tb_id_anggota"
        Me.tb_id_anggota.ReadOnly = True
        Me.tb_id_anggota.Size = New System.Drawing.Size(141, 20)
        Me.tb_id_anggota.TabIndex = 41
        '
        'dtp_kembali
        '
        Me.dtp_kembali.Location = New System.Drawing.Point(171, 94)
        Me.dtp_kembali.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_kembali.Name = "dtp_kembali"
        Me.dtp_kembali.Size = New System.Drawing.Size(332, 20)
        Me.dtp_kembali.TabIndex = 35
        Me.dtp_kembali.Value = New Date(2023, 8, 2, 0, 0, 0, 0)
        '
        'tb_nama_pegawai
        '
        Me.tb_nama_pegawai.Location = New System.Drawing.Point(171, 24)
        Me.tb_nama_pegawai.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_pegawai.Name = "tb_nama_pegawai"
        Me.tb_nama_pegawai.Size = New System.Drawing.Size(141, 20)
        Me.tb_nama_pegawai.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Tanggal Pengembalian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nama"
        '
        'tb_nama_anggota
        '
        Me.tb_nama_anggota.Location = New System.Drawing.Point(171, 60)
        Me.tb_nama_anggota.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_anggota.Name = "tb_nama_anggota"
        Me.tb_nama_anggota.Size = New System.Drawing.Size(141, 20)
        Me.tb_nama_anggota.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_noblk)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_id_pegawai)
        Me.GroupBox1.Controls.Add(Me.tb_id_anggota)
        Me.GroupBox1.Controls.Add(Me.dtp_kembali)
        Me.GroupBox1.Controls.Add(Me.tb_nama_pegawai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_nama_anggota)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 156)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(640, 393)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(550, 396)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Total Denda"
        '
        'dgv_lihat
        '
        Me.dgv_lihat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lihat.Location = New System.Drawing.Point(54, 434)
        Me.dgv_lihat.Name = "dgv_lihat"
        Me.dgv_lihat.Size = New System.Drawing.Size(727, 92)
        Me.dgv_lihat.TabIndex = 55
        '
        'tb_cari
        '
        Me.tb_cari.Location = New System.Drawing.Point(93, 531)
        Me.tb_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_cari.Name = "tb_cari"
        Me.tb_cari.Size = New System.Drawing.Size(141, 20)
        Me.tb_cari.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 534)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "CARI"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 49)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(-3, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 40)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Pengembalian"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LandingPageToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.MenuStrip1.TabIndex = 59
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
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PemijamanToolStripMenuItem, Me.CariDataPeminjamToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PemijamanToolStripMenuItem
        '
        Me.PemijamanToolStripMenuItem.Name = "PemijamanToolStripMenuItem"
        Me.PemijamanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PemijamanToolStripMenuItem.Text = "pemijaman "
        '
        'CariDataPeminjamToolStripMenuItem
        '
        Me.CariDataPeminjamToolStripMenuItem.Name = "CariDataPeminjamToolStripMenuItem"
        Me.CariDataPeminjamToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CariDataPeminjamToolStripMenuItem.Text = "cari data peminjam"
        '
        'Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tb_cari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_lihat)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.dgv_pengembalian)
        Me.Name = "Pengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian"
        CType(Me.dgv_pengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_lihat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_noblk As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_edit As Button
    Friend WithEvents bt_simpan As Button
    Friend WithEvents dgv_pengembalian As DataGridView
    Friend WithEvents tb_id_pegawai As TextBox
    Friend WithEvents tb_id_anggota As TextBox
    Friend WithEvents dtp_kembali As DateTimePicker
    Friend WithEvents tb_nama_pegawai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nama_anggota As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_lihat As DataGridView
    Friend WithEvents tb_cari As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LandingPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemijamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariDataPeminjamToolStripMenuItem As ToolStripMenuItem
End Class
