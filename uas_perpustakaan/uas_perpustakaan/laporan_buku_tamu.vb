Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class laporan_buku_tamu
    Private Sub laporan_buku_tamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub

    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM buku_tamu"
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
        Peminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem1.Click
        Me.Close()
        Pengembalian.Show()
    End Sub
End Class