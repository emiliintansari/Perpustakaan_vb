Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Public Class Peminjaman
    Private Sub panggil_anggota()
        Call koneksi()
        Dim str As String
        Dim adaptor As New MySqlDataAdapter
        Dim dt = New DataTable

        str = "SELECT * FROM anggota"
        cmd = New MySqlCommand(str, conn)
        adaptor = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        adaptor.Fill(dt)
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("nama"))
        Next

        tb_nama_anggota.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_nama_anggota.AutoCompleteCustomSource = col
        tb_nama_anggota.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub panggil_idanggota()
        Call koneksi()
        Dim str As String
        str = "SELECT nim FROM anggota WHERE 
            nama='" & tb_nama_anggota.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tb_id_anggota.Text = rd.Item("nim")
        End If
    End Sub

    Private Sub panggil_pegawai()
        Call koneksi()
        Dim str As String
        Dim adaptor As New MySqlDataAdapter
        Dim dt = New DataTable

        str = "SELECT * FROM petugas"
        cmd = New MySqlCommand(str, conn)
        adaptor = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        adaptor.Fill(dt)
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("nama_petugas"))
        Next

        tb_nama_pegawai.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_nama_pegawai.AutoCompleteCustomSource = col
        tb_nama_pegawai.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub panggil_idpegawai()
        Call koneksi()
        Dim str As String
        str = "SELECT id_petugas FROM petugas WHERE 
            nama_petugas='" & tb_nama_pegawai.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tb_id_pegawai.Text = rd.Item("id_petugas")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        anggota.Show()
    End Sub

    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggil_pegawai()
        Call panggil_anggota()
        Call otomatis_()
    End Sub

    Private Sub tb_nama_pegawai_TextChanged(sender As Object, e As EventArgs) Handles tb_nama_pegawai.TextChanged
        panggil_idpegawai()
    End Sub


    Private Sub dgv_peminjaman_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_peminjaman.CellEndEdit
        If e.ColumnIndex = 0 Then
            Call koneksi()
            Dim str As String
            Dim tgl_pinjam = dtp_pinjam.Value, tgl_kembali
            str = "SELECT * FROM buku WHERE 
            kode_buku='" & dgv_peminjaman.Rows(e.RowIndex).Cells(0).Value & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                dgv_peminjaman.Rows(e.RowIndex).Cells(1).Value = rd.Item("judul_buku")
                dgv_peminjaman.Rows(e.RowIndex).Cells(2).Value = 1
                tgl_kembali = tgl_pinjam.AddDays(7)
                dgv_peminjaman.Rows(e.RowIndex).Cells(3).Value = tgl_kembali
                dgv_peminjaman.Rows(e.RowIndex).Cells(4).Value = "DIPINJAM"
            End If

        End If
    End Sub

    Private Sub tb_nama_pegawai_Leave(sender As Object, e As EventArgs) Handles tb_nama_pegawai.Leave
        Call panggil_idpegawai()
    End Sub

    Private Sub otomatis_()
        Call koneksi()
        cmd = New MySqlCommand("select id_pinjaman from header_peminjaman  ORDER BY id_pinjaman desc LIMIT 1", conn)
        Dim hitung As Long
        Dim no As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            no = "PJM" + "101"
        Else
            rd.Read()
            hitung = Double.Parse(Microsoft.VisualBasic.Right(rd.Item("id_pinjaman"), 3)) + 1
            no = "PJM" & hitung
        End If
        lb_nopin.Text = no

    End Sub

    Private Sub simpan()
        koneksi()
        Dim sql_header As String =
    "INSERT INTO header_peminjaman VALUES(
    '" & lb_nopin.Text & "',
    '" & tb_id_pegawai.Text & "',
    '" & tb_id_anggota.Text & "',
    '" & dtp_pinjam.Value & "',
    'DIPINJAM')"

        cmd = New MySqlCommand(sql_header, conn)
        cmd.ExecuteNonQuery()

        'cmd = New MySqlCommand(sql_header, conn)
        'cmd.ExecuteNonQuery()
        For Each data As DataGridViewRow In dgv_peminjaman.Rows
            If data.Cells(0).Value <> "" Then


                Dim sql As String =
                "INSERT INTO detail_peminjaman VALUES(
                '" & lb_nopin.Text & "',
                '" & data.Cells(0).Value & "',
                '" & data.Cells(2).Value & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()

                'Dim sql_update As String =
                '"UPDATE tb_barang SET
                'stokBarang =stokBarang-'" & data.Cells(3).Value & "'
                'WHERE idBarang='" & data.Cells(0).Value & "'"
                'cmd = New MySqlCommand(sql_update, conn)
                'cmd.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("Data Berhasil Disimpan!")
        dgv_peminjaman.Rows.Clear()


    End Sub

    Private Sub clear()
        tb_id_anggota.Text = ""
        tb_id_pegawai.Text = ""
        tb_nama_anggota.Text = ""
        tb_nama_pegawai.Text = ""
    End Sub

    Private Sub tb_nama_anggota_Leave(sender As Object, e As EventArgs) Handles tb_nama_anggota.Leave
        Call panggil_idanggota()
    End Sub

    Private Sub bt_simpan_Click_1(sender As Object, e As EventArgs) Handles bt_simpan.Click
        Call simpan()
        Call clear()
        Call otomatis_()
    End Sub

    'ping!!!!!!!!!!!!'
    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandingPageToolStripMenuItem.Click
        Close()
        Halaman_utama.Visible = True
        Halaman_utama.Enabled = True
        Halaman_utama.Show()
        login.Close()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        End
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        Me.Close()
        Pengembalian.Show()
    End Sub

    Private Sub CariDataPeminjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariDataPeminjamToolStripMenuItem.Click
        Me.Close()
        Cari_Data.Show()
    End Sub
End Class