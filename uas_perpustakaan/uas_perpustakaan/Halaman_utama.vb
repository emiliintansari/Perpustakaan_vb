Imports MySql.Data.MySqlClient
Public Class Halaman_utama
    Public nama_user As String
    Private Sub Halaman_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status_label.Text = nama_user
        Me.Enabled = False
        Me.Visible = False
        'login.Show()
    End Sub
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        admin.Show()
        Me.Close()
    End Sub
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        buku.Show()
        Me.Close()
    End Sub
    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Me.Close()
        'login.Show()
        landingpage.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub ProgramStudiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        prodi.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        'Me.Close()
        laporan_peminjaman.Show()
    End Sub

    Private Sub DendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DendaToolStripMenuItem.Click
        'Me.Close()
        denda.show()
    End Sub

    Private Sub CariDataPeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariDataPeminjamToolStripMenuItem.Click
        'Me.Close()
        Cari_Data.Show()
    End Sub

    Private Sub AanggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AanggotaToolStripMenuItem.Click
        'Me.Close()
        anggota.Show()
    End Sub

    Private Sub PemijamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemijamanToolStripMenuItem.Click
        'Me.Close()
        Peminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem1.Click
        'Me.Close()
        laporan_pengembalian.show()
    End Sub

    Private Sub BukuTamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuTamuToolStripMenuItem.Click
        'Me.Close()
        laporan_buku_tamu.show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        'Me.Close()
        Pengembalian.Show()
    End Sub
End Class