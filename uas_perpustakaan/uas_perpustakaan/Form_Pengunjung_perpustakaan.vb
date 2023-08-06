Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class Form_Pengunjung_perpustakaan
    Dim JENIS As String
    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        landingpage.Show()
        Me.Close()
    End Sub
    Private Sub tampil_prodi()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM program_studi"
            cmd = New MySqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            While rd.Read
                cbx_programstd.Items.Add(rd("nama_prodi"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form_Pengunjung_perpustakaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Enabled = False
        Call tampil_prodi()

    End Sub

    Private Sub rekam_tamu()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO buku_tamu VALUES('" &
                tb_nama.Text & "','" &
                tb_nim.Text & "','" & cbx_programstd.Text & "','" &
                JENIS & "','" &
                DateTimePicker1.Value & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("BERHASIL DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clear_h()
        tb_nama.Text = ""
        tb_nim.Text = ""
        cbx_programstd.Text = ""
        JENIS = ""
    End Sub

    Private Sub btn_kirim_Click(sender As Object, e As EventArgs) Handles btn_kirim.Click
        Call rekam_tamu()
        Call clear_h()
    End Sub

    Private Sub rb_baca_CheckedChanged(sender As Object, e As EventArgs) Handles rb_baca.CheckedChanged
        JENIS = "Membaca"
    End Sub

    Private Sub rd_pinjam_CheckedChanged(sender As Object, e As EventArgs) Handles rd_pinjam.CheckedChanged
        JENIS = "Meminjam"
    End Sub
End Class