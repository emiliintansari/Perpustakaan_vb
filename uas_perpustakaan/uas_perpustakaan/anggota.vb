Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class anggota
    Private Sub anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_prodi()
        Call tampil_data()
    End Sub

    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
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

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Me.Close()
        buku.Show()
    End Sub

    Private Sub AanggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AanggotaToolStripMenuItem.Click
        Me.Close()
        denda.Show()
    End Sub

    Dim jenis_kelamin As String

    Private Sub rb_l_CheckedChanged(sender As Object, e As EventArgs) Handles rb_l.CheckedChanged
        jenis_kelamin = "Laki-laki"
    End Sub

    Private Sub rb_p_CheckedChanged(sender As Object, e As EventArgs) Handles rb_p.CheckedChanged
        jenis_kelamin = "Perempuan"
    End Sub

    Private Sub tampil_prodi()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM program_studi"
            cmd = New MySqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            While rd.Read
                cb_prodi.Items.Add(rd("nama_prodi"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tampil_data()
        Try
            Call koneksi()
            Dim sql As String = "SELECT * FROM Anggota"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            dgv_anggota.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil Anggota")
        End Try
    End Sub
    Private Sub simpan_anggota()
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO Anggota VALUES('" & tb_nim.Text & "','" &
                tb_nama.Text & "','" & jenis_kelamin & "','" & dtp_lahir.Value & "','" &
                tb_alamat.Text & "','" & dtp_tahun.Value.Year & "','" & cb_prodi.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("BERHASIL DI TAMBAH")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call simpan_anggota()
        Call tampil_data()
        Call clear()
    End Sub

    Private Sub edit_anggota()
        Try
            Call koneksi()
            Dim sql As String = "update Anggota set nama='" &
                tb_nama.Text & "',jk='" & jenis_kelamin & "',tgl_lhir='" &
                dtp_lahir.Text & "',alamat='" & tb_alamat.Text & "',tahun_masuk='" &
                dtp_tahun.Value.Year & "',prodi='" & cb_prodi.Text & "' WHERE nim='" & tb_nim.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Edit Data anggota Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call edit_anggota()
        Call tampil_data()
        Call clear()
    End Sub

    'error gabisa ketika di klik di bagain tahun 
    Private Sub dgv_anggota_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_anggota.CellContentDoubleClick
        tb_nim.Text = dgv_anggota.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = dgv_anggota.Rows(e.RowIndex).Cells(1).Value
        jenis_kelamin = dgv_anggota.Rows(e.RowIndex).Cells(2).Value
        dtp_lahir.Value = dgv_anggota.Rows(e.RowIndex).Cells(3).Value
        tb_alamat.Text = dgv_anggota.Rows(e.RowIndex).Cells(4).Value
        'dtp_tahun.Value = dgv_anggota.Rows(e.RowIndex).Cells(5).Value
        cb_prodi.Text = dgv_anggota.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub clear()
        tb_nim.Text = ""
        tb_nama.Text = ""
        jenis_kelamin = ""
        'dtp_lahir.Value = ""
        tb_alamat.Text = ""
        'dtp_tahun.Value = ""
        cb_prodi.Text = ""
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clear()
    End Sub

    Private Sub hapus()
        Try
            Call koneksi()
            Dim sql As String = "DELETE FROM Anggota WHERE nim = '" & tb_nim.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Hapus Data Berhasil")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Call hapus()
        Call clear()
        Call tampil_data()
    End Sub
End Class