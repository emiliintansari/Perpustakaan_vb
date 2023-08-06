Imports MySql.Data.MySqlClient
Public Class prodi
    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub

    Private Sub prodi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data()
    End Sub
    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM program_studi"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "d")
            dgv_prodi.DataSource = ds.Tables("d")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call simpan()
        Call clear()
        Call tampil_data()
    End Sub

    Private Sub simpan()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO program_studi VALUES('" & tb_id.Text & "','" &
                tb_nama.Text & "','" & tb_akreditas.Text & "','" & dtp_brdiri.Value & "','" &
                tb_noskop.Text & "')"
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
        tb_akreditas.Text = ""
        dtp_brdiri.Text = ""
        tb_noskop.Text = ""
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click

        Call hapus()
        Call tampil_data()
        Call clear()
    End Sub

    Private Sub hapus()
        Try
            Call koneksi()
            Dim sql As String = "DELETE FROM program_studi WHERE id_prodi = '" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Hapus Data Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_prodi_CellContentDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prodi.CellContentDoubleClick
        tb_id.Text = dgv_prodi.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = dgv_prodi.Rows(e.RowIndex).Cells(1).Value
        tb_akreditas.Text = dgv_prodi.Rows(e.RowIndex).Cells(2).Value
        dtp_brdiri.Value = dgv_prodi.Rows(e.RowIndex).Cells(3).Value
        tb_noskop.Text = dgv_prodi.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call edit()
        Call tampil_data()
        Call clear()
    End Sub

    Private Sub edit()
        Try
            Call koneksi()
            Dim sql As String = "update program_studi set nama_prodi='" &
                tb_nama.Text & "',akreditas='" &
                tb_akreditas.Text & "',tanggal_berdiri='" &
                dtp_brdiri.Value & "',noskpendirian='" &
                tb_noskop.Text & "'WHERE id_prodi='" & tb_id.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Me.Close()
        buku.Show()
    End Sub
End Class