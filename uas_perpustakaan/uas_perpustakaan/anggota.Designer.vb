<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(anggota))
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nim = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.dgv_anggota = New System.Windows.Forms.DataGridView()
        Me.LandingPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AanggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.rb_l = New System.Windows.Forms.RadioButton()
        Me.rb_p = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_prodi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_lahir = New System.Windows.Forms.DateTimePicker()
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!)
        Me.btn_clear.Location = New System.Drawing.Point(149, 461)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(394, 31)
        Me.btn_clear.TabIndex = 86
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Alamat"
        '
        'tb_alamat
        '
        Me.tb_alamat.AllowDrop = True
        Me.tb_alamat.Location = New System.Drawing.Point(253, 312)
        Me.tb_alamat.Multiline = True
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(291, 37)
        Me.tb_alamat.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "NIM"
        '
        'tb_nim
        '
        Me.tb_nim.Location = New System.Drawing.Point(252, 208)
        Me.tb_nim.Name = "tb_nim"
        Me.tb_nim.Size = New System.Drawing.Size(291, 20)
        Me.tb_nim.TabIndex = 79
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(252, 234)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(291, 20)
        Me.tb_nama.TabIndex = 78
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!)
        Me.btn_edit.Location = New System.Drawing.Point(441, 425)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(102, 34)
        Me.btn_edit.TabIndex = 76
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_hapus.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!)
        Me.btn_hapus.Location = New System.Drawing.Point(294, 425)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(102, 34)
        Me.btn_hapus.TabIndex = 75
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!)
        Me.btn_simpan.Location = New System.Drawing.Point(149, 425)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(102, 34)
        Me.btn_simpan.TabIndex = 74
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'dgv_anggota
        '
        Me.dgv_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_anggota.Location = New System.Drawing.Point(563, 203)
        Me.dgv_anggota.Name = "dgv_anggota"
        Me.dgv_anggota.Size = New System.Drawing.Size(747, 251)
        Me.dgv_anggota.TabIndex = 73
        '
        'LandingPageToolStripMenuItem
        '
        Me.LandingPageToolStripMenuItem.Name = "LandingPageToolStripMenuItem"
        Me.LandingPageToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LandingPageToolStripMenuItem.Text = "Home"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.BukuToolStripMenuItem, Me.AanggotaToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'AanggotaToolStripMenuItem
        '
        Me.AanggotaToolStripMenuItem.Name = "AanggotaToolStripMenuItem"
        Me.AanggotaToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AanggotaToolStripMenuItem.Text = "Denda"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LandingPageToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.MasterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'rb_l
        '
        Me.rb_l.AutoSize = True
        Me.rb_l.Location = New System.Drawing.Point(268, 260)
        Me.rb_l.Name = "rb_l"
        Me.rb_l.Size = New System.Drawing.Size(64, 17)
        Me.rb_l.TabIndex = 88
        Me.rb_l.TabStop = True
        Me.rb_l.Text = "Laki-laki"
        Me.rb_l.UseVisualStyleBackColor = True
        '
        'rb_p
        '
        Me.rb_p.AutoSize = True
        Me.rb_p.Location = New System.Drawing.Point(416, 260)
        Me.rb_p.Name = "rb_p"
        Me.rb_p.Size = New System.Drawing.Size(79, 17)
        Me.rb_p.TabIndex = 89
        Me.rb_p.TabStop = True
        Me.rb_p.Text = "Perempuan"
        Me.rb_p.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Tahun Masuk"
        '
        'cb_prodi
        '
        Me.cb_prodi.FormattingEnabled = True
        Me.cb_prodi.Location = New System.Drawing.Point(252, 387)
        Me.cb_prodi.Name = "cb_prodi"
        Me.cb_prodi.Size = New System.Drawing.Size(291, 21)
        Me.cb_prodi.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(122, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Prodi"
        '
        'dtp_lahir
        '
        Me.dtp_lahir.Location = New System.Drawing.Point(253, 284)
        Me.dtp_lahir.Name = "dtp_lahir"
        Me.dtp_lahir.Size = New System.Drawing.Size(200, 20)
        Me.dtp_lahir.TabIndex = 96
        '
        'dtp_tahun
        '
        Me.dtp_tahun.Location = New System.Drawing.Point(253, 354)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tahun.TabIndex = 97
        '
        'anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtp_tahun)
        Me.Controls.Add(Me.dtp_lahir)
        Me.Controls.Add(Me.cb_prodi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rb_p)
        Me.Controls.Add(Me.rb_l)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_nim)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgv_anggota)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "anggota"
        Me.Text = "anggota"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nim As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents dgv_anggota As DataGridView
    Friend WithEvents LandingPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AanggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents rb_l As RadioButton
    Friend WithEvents rb_p As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_prodi As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_lahir As DateTimePicker
    Friend WithEvents dtp_tahun As DateTimePicker
End Class
