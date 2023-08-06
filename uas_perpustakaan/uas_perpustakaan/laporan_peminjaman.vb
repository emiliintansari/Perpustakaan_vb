Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class laporan_peminjaman
    Private Sub laporan_peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub

    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT header_peminjaman.id_pinjaman, header_peminjaman.id_petugas, petugas.nama_petugas, header_peminjaman.id_anggota, anggota.nama, detail_peminjaman.kode_buku, buku.judul_buku, header_peminjaman.tgl_pinjam
FROM ((header_peminjaman
INNER JOIN petugas ON header_peminjaman.id_petugas = petugas.id_petugas)
INNER JOIN anggota ON header_peminjaman.id_anggota = anggota.nim)
INNER JOIN detail_peminjaman ON detail_peminjaman.id_pinjam = header_peminjaman.id_pinjaman
INNER JOIN buku ON detail_peminjaman.kode_buku = buku.kode_buku"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil Anggota")
        End Try
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Me.Close()
        laporan_pengembalian.Show()
    End Sub

    Private Sub BukuTamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuTamuToolStripMenuItem.Click
        Me.Close()
        laporan_buku_tamu.Show()
    End Sub
End Class