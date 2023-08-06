Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Public Class buku
    Private Sub buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub
    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM buku"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            dgv_buku.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil user")
        End Try
    End Sub
    Private Sub simpan_buku()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO buku VALUES('" & tb_id.Text & "','" &
                tb_isbn.Text & "','" & tb_judul.Text & "','" & tb_penulis.Text & "','" &
                tb_penerbit.Text & "','" & tb_tahun_terbit.Text & "','" & tb_stok.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("BERHASIL DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call simpan_buku()
        Call tampil_data()
        Call clear()
    End Sub

    Private Sub edit_buku()
        Try
            Call koneksi()
            Dim sql As String = "update buku set kode_buku='" &
                tb_isbn.Text & "',judul_buku='" & tb_judul.Text & "',penulis_buku='" &
                tb_penulis.Text & "',penerbit_buku='" & tb_penerbit.Text & "',tahun_terbit='" &
                tb_tahun_terbit.Text & "',stok='" & tb_stok.Text & "' WHERE id_buku='" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data user Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgv_user_CellMouseDoubleClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_buku.CellMouseDoubleClick
        tb_id.Text = dgv_buku.Rows(e.RowIndex).Cells(0).Value
        tb_isbn.Text = dgv_buku.Rows(e.RowIndex).Cells(1).Value
        tb_judul.Text = dgv_buku.Rows(e.RowIndex).Cells(2).Value
        tb_penulis.Text = dgv_buku.Rows(e.RowIndex).Cells(3).Value
        tb_penerbit.Text = dgv_buku.Rows(e.RowIndex).Cells(4).Value
        tb_tahun_terbit.Text = dgv_buku.Rows(e.RowIndex).Cells(5).Value
        tb_stok.Text = dgv_buku.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call edit_buku()
        Call tampil_data()
        Call clear()
    End Sub

    Private Sub hapus_data()
        Try
            Call koneksi()
            Dim sql As String = "DELETE FROM buku WHERE id_buku = '" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Hapus Data Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Call hapus_data()
        Call tampil_data()
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()

    End Sub


    Private Sub tb_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_id.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("SELECT * FROM buku WHERE id_buku = '" & tb_id.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                tb_isbn.Text = rd.Item("kode_buku")
                tb_judul.Text = rd.Item("judul_buku")
                tb_penulis.Text = rd.Item("penulis_buku")
                tb_penerbit.Text = rd.Item("penerbit_buku")
                tb_tahun_terbit.Text = rd.Item("tahun_terbit")
                tb_stok.Text = rd.Item("stok")
            End If
        End If
    End Sub

    Private Sub clear()
        tb_id.Text = ""
        tb_isbn.Text = ""
        tb_judul.Text = ""
        tb_penulis.Text = ""
        tb_penerbit.Text = ""
        tb_tahun_terbit.Text = ""
        tb_stok.Text = ""
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clear()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub DendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DendaToolStripMenuItem.Click
        Me.Close()
        denda.Show()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        Me.Close()
        anggota.Show()
    End Sub
End Class