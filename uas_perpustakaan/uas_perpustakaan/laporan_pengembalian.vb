Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class laporan_pengembalian
    Private Sub laporan_pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub

    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT header_pengembalian.id_pengembalian, header_pengembalian.id_petugas, petugas.nama_petugas, header_pengembalian.id_anggota, anggota.nama, detail_pengembalian.kode_buku, buku.judul_buku, header_pengembalian.tanggal_pengembalian
FROM header_pengembalian 
INNER JOIN petugas on header_pengembalian.id_petugas = petugas.id_petugas
INNER JOIN anggota on header_pengembalian.id_anggota = anggota.nim
INNER JOIN detail_pengembalian on header_pengembalian.id_pengembalian = detail_pengembalian.id_kembali
INNER JOIN buku on detail_pengembalian.kode_buku = buku.kode_buku"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            DataGridView1.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil pengembalian")
        End Try
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Me.Close()
        laporan_peminjaman.Show()
    End Sub

    Private Sub BukuTamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuTamuToolStripMenuItem.Click
        Me.Close()
        laporan_buku_tamu.Show()
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub
End Class