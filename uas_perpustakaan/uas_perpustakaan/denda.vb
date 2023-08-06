Imports MySql.Data.MySqlClient
Public Class denda
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Me.Close()
        buku.Show()
    End Sub

    Private Sub AanggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AanggotaToolStripMenuItem.Click
        Me.Close()
        anggota.Show()
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub masuk()
        Call koneksi()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO denda VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("BERHASIL DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call masuk()
        Call clear()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub CariDataToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
        Cari_Data.Show()
    End Sub
End Class