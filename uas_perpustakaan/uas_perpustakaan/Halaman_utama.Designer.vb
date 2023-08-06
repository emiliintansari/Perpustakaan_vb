<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Halaman_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Halaman_utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LandingPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AanggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemijamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariDataPeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuTamuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LandingPageToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LandingPageToolStripMenuItem
        '
        Me.LandingPageToolStripMenuItem.Name = "LandingPageToolStripMenuItem"
        Me.LandingPageToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.LandingPageToolStripMenuItem.Text = "Back"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.BukuToolStripMenuItem, Me.DendaToolStripMenuItem, Me.AanggotaToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'DendaToolStripMenuItem
        '
        Me.DendaToolStripMenuItem.Name = "DendaToolStripMenuItem"
        Me.DendaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DendaToolStripMenuItem.Text = "Denda"
        '
        'AanggotaToolStripMenuItem
        '
        Me.AanggotaToolStripMenuItem.Name = "AanggotaToolStripMenuItem"
        Me.AanggotaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AanggotaToolStripMenuItem.Text = "Anggota"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PemijamanToolStripMenuItem, Me.PengembalianToolStripMenuItem, Me.CariDataPeminjamToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PemijamanToolStripMenuItem
        '
        Me.PemijamanToolStripMenuItem.Name = "PemijamanToolStripMenuItem"
        Me.PemijamanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PemijamanToolStripMenuItem.Text = "Peminjaman"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'CariDataPeminjamToolStripMenuItem
        '
        Me.CariDataPeminjamToolStripMenuItem.Name = "CariDataPeminjamToolStripMenuItem"
        Me.CariDataPeminjamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CariDataPeminjamToolStripMenuItem.Text = "Cari Data Buku"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem, Me.PengembalianToolStripMenuItem1, Me.BukuTamuToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PeminjamanToolStripMenuItem.Text = "LP_Peminjaman"
        '
        'PengembalianToolStripMenuItem1
        '
        Me.PengembalianToolStripMenuItem1.Name = "PengembalianToolStripMenuItem1"
        Me.PengembalianToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PengembalianToolStripMenuItem1.Text = "LP_Pengembalian"
        '
        'BukuTamuToolStripMenuItem
        '
        Me.BukuTamuToolStripMenuItem.Name = "BukuTamuToolStripMenuItem"
        Me.BukuTamuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BukuTamuToolStripMenuItem.Text = "LP_Buku Tamu"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_label})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 608)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_label
        '
        Me.status_label.Name = "status_label"
        Me.status_label.Size = New System.Drawing.Size(46, 17)
        Me.status_label.Text = "ADMIN"
        '
        'Halaman_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(990, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "Halaman_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LandingPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemijamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status_label As ToolStripStatusLabel
    Friend WithEvents BukuTamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AanggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariDataPeminjamToolStripMenuItem As ToolStripMenuItem
End Class
