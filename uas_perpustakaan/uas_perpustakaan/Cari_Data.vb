Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Public Class Cari_Data
    Private Sub Cari_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub

    Private Sub tampil()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM buku"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            dgv.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil user")
        End Try
    End Sub

    Private Sub cari()
        Try
            Call koneksi()
            cmd = New MySqlCommand("SELECT * FROM buku where judul_buku LIKE '%" & TextBox1.Text & "%'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call koneksi()
                da = New MySqlDataAdapter("SELECT * FROM buku where judul_buku LIKE '%" & TextBox1.Text & "%'", conn)
                ds = New DataSet
                da.Fill(ds, "KETEMU")
                dgv.DataSource = ds.Tables("KETEMU")
                dgv.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Data Tidak Ketemu")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call cari()
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub

    Private Sub PemijamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemijamanToolStripMenuItem.Click
        Me.Close()
        Peminjaman.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

End Class