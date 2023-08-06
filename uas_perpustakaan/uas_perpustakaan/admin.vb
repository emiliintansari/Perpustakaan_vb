Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient

Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub
    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM petugas"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "c")
            dgv_admin.DataSource = ds.Tables("c")
        Catch ex As Exception
            MessageBox.Show("gagal tampil admin")
        End Try
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call simpan_admin()
        Call tampil_data()
        Call clear()
    End Sub
    Private Sub simpan_admin()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO petugas VALUES('" & tb_id.Text & "','" &
                tb_nama.Text & "','" & tb_username.Text & "','" & tb_password.Text & "','" &
                tb_telp.Text & "','" & tb_alamat.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("BERHASIL DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clear()
        tb_id.Text = ""
        tb_nama.Text = ""
        tb_username.Text = ""
        tb_password.Text = ""
        tb_alamat.Text = ""
        tb_telp.Text = ""
    End Sub
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Call hapus()
        Call tampil_data()
        Call clear()
    End Sub
    Private Sub hapus()
        Try
            Call koneksi()
            Dim sql As String = "DELETE FROM petugas WHERE id_petugas = '" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Hapus Data Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call edit_buku()
        Call tampil_data()
        Call clear()
    End Sub
    Private Sub edit_buku()
        Try
            Call koneksi()
            Dim sql As String = "update petugas set nama_petugas='" & tb_nama.Text & "',username='" & tb_username.Text & "',password='" & tb_password.Text & "',no_telp_petugas='" & tb_telp.Text & "',alamat_petugas='" & tb_alamat.Text & "'WHERE id_petugas='" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data user Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clear()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Me.Close()
        buku.Show()
        Me.clear()
    End Sub
    Private Sub ProgramStudiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        prodi.Show()
    End Sub
    Private Sub dgv_admin_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_admin.CellContentDoubleClick

        tb_id.Text = dgv_admin.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = dgv_admin.Rows(e.RowIndex).Cells(1).Value
        tb_username.Text = dgv_admin.Rows(e.RowIndex).Cells(2).Value
        tb_password.Text = dgv_admin.Rows(e.RowIndex).Cells(3).Value
        tb_telp.Text = dgv_admin.Rows(e.RowIndex).Cells(4).Value
        tb_alamat.Text = dgv_admin.Rows(e.RowIndex).Cells(5).Value
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