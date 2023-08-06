Imports MySql.Data.MySqlClient

Public Class Pengembalian
    Public nominal_denda, total_buku, tgl_pinjam
    Private Sub Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call otomatis_id()
        Call panggil_pegawai()
        Call panggil_anggota()
        Call panggil_peminjaman_id()
        Call tampil()
        Call panggil_denda()
    End Sub



    Private Sub tampil()
        Try
            Call koneksi()
            Dim sql As String = "SELECT anggota.nim,header_peminjaman.id_pinjaman, anggota.nama,header_peminjaman.tgl_pinjam, 
            (select count(detail_peminjaman.id_pinjam) from detail_peminjaman Where detail_peminjaman.id_pinjam = header_peminjaman.id_pinjaman)
            as jml FROM header_peminjaman INNER JOIN anggota ON header_peminjaman.id_anggota=anggota.nim 
            WHERE header_peminjaman.status = 'DIPINJAM'"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            dgv_lihat.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show("gagal tampil")
        End Try
    End Sub
    Private Sub tampil_pinjam(idpinjam)
        Try
            Call koneksi()
            Dim sql As String = "SELECT detail_peminjaman.id_pinjam,detail_peminjaman.kode_buku,buku.judul_buku,detail_peminjaman.jumlah,header_peminjaman.tgl_pinjam FROM detail_peminjaman INNER JOIN buku ON buku.kode_buku=detail_peminjaman.kode_buku INNER JOIN header_peminjaman ON detail_peminjaman.id_pinjam = header_peminjaman.id_pinjaman
            WHERE detail_peminjaman.id_pinjam='" & idpinjam & "'"
            da = New MySqlDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "a")
            dgv_pengembalian.DataSource = ds.Tables("a")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub hitung_denda()
        Dim tgl_kembali, tgl_tempo, selisih

        tgl_kembali = dtp_kembali.Value
        tgl_tempo = DateAdd(DateInterval.Day, 7, tgl_pinjam)
        If tgl_kembali > tgl_tempo Then
            selisih = DateDiff(DateInterval.Day, tgl_tempo, tgl_kembali)
            TextBox1.Text = selisih * nominal_denda * total_buku
        Else
            TextBox1.Text = 0
        End If
    End Sub


    Private Sub cari()
        Try
            Call koneksi()
            cmd = New MySqlCommand("SELECT anggota.nim,header_peminjaman.id_pinjaman, anggota.nama,header_peminjaman.tgl_pinjam, 
            (select count(detail_peminjaman.id_pinjam) from detail_peminjaman Where detail_peminjaman.id_pinjam = header_peminjaman.id_pinjaman)
            as jml FROM header_peminjaman INNER JOIN anggota ON header_peminjaman.id_anggota=anggota.nim 
            WHERE anggota.nama LIKE '%" & tb_cari.Text & "%' and header_peminjaman.status = 'DIPINJAM'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call koneksi()
                da = New MySqlDataAdapter("SELECT anggota.nim,header_peminjaman.id_pinjaman, anggota.nama,header_peminjaman.tgl_pinjam, 
            (select count(detail_peminjaman.id_pinjam) from detail_peminjaman Where detail_peminjaman.id_pinjam = header_peminjaman.id_pinjaman)
            as jml FROM header_peminjaman INNER JOIN anggota ON header_peminjaman.id_anggota=anggota.nim 
            WHERE anggota.nama LIKE '%" & tb_cari.Text & "%' and header_peminjaman.status = 'DIPINJAM'", conn)
                ds = New DataSet
                da.Fill(ds, "KETEMU")
                dgv_lihat.DataSource = ds.Tables("KETEMU")
                dgv_lihat.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("gadaa")
        End Try
    End Sub

    Private Sub otomatis_id()
        Call koneksi()
        cmd = New MySqlCommand("select id_pengembalian from header_pengembalian  ORDER BY id_pengembalian DESC LIMIT 1", conn)
        Dim hitung As Long
        Dim no As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            no = "KMB" + "101"
        Else
            rd.Read()
            hitung = Double.Parse(Microsoft.VisualBasic.Right(rd.Item("id_pengembalian"), 3)) + 1
            no = "KMB" & hitung
        End If
        lb_noblk.Text = no
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

        tb_cari.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_cari.AutoCompleteCustomSource = col
        tb_cari.AutoCompleteMode = AutoCompleteMode.Suggest
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
    Private Sub panggil_denda()
        Call koneksi()
        Dim str As String
        str = "SELECT nominal FROM denda "
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            nominal_denda = rd.Item("nominal")
        End If
    End Sub

    Private Sub panggil_peminjaman_id()
        Call koneksi()
        Dim str As String
        str = "SELECT id_pinjaman FROM header_peminjaman WHERE 
            id_anggota='" & tb_id_anggota.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            'cbx_peminjam.Text = rd.Item("id_pinjaman")
        End If
    End Sub

    Private Sub tb_nama_pegawai_Leave(sender As Object, e As EventArgs) Handles tb_nama_pegawai.Leave
        Call panggil_idpegawai()
    End Sub

    Private Sub tb_nama_anggota_Leave(sender As Object, e As EventArgs) Handles tb_nama_anggota.Leave
        '   Call panggil_idanggota()
        Call panggil_peminjaman_id()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Call tampil_data()
        Call cari()
    End Sub
    Private Sub dgv_lihat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lihat.CellContentClick
        Dim id_pinjam = dgv_lihat.Rows(e.RowIndex).Cells(1).Value()
        tampil_pinjam(id_pinjam)
        tb_nama_anggota.Text = dgv_lihat.Rows(e.RowIndex).Cells(2).Value()
        tb_id_anggota.Text = dgv_lihat.Rows(e.RowIndex).Cells(0).Value()
        tgl_pinjam = dgv_lihat.Rows(e.RowIndex).Cells(3).Value()
        total_buku = dgv_lihat.Rows(e.RowIndex).Cells(4).Value()
    End Sub

    Private Sub simpan()
        koneksi()
        Dim sql_header As String =
    "INSERT INTO header_pengembalian VALUES(
    '" & lb_noblk.Text & "',
    '" & dtp_kembali.Text & "',
    '" & tb_id_pegawai.Text & "',
    '" & tb_id_anggota.Text & "')"
        ' & data.Cells(0).Value & gajadiii !!!!!!
        cmd = New MySqlCommand(sql_header, conn)
        cmd.ExecuteNonQuery()

        'cmd = New MySqlCommand(sql_header, conn)
        'cmd.ExecuteNonQuery()
        For Each data As DataGridViewRow In dgv_pengembalian.Rows
            If data.Cells(0).Value <> "" Then
                Dim sql As String =
                "INSERT INTO detail_pengembalian VALUES(
                '" & data.Cells(0).Value & "',
                '" & lb_noblk.Text & "',
                '" & data.Cells(1).Value & "',
                '" & data.Cells(2).Value & "',
                '" & data.Cells(3).Value & "',
                '" & data.Cells(4).Value & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()

                Dim sql_update As String =
                "UPDATE header_peminjaman SET
                status = 'kembali'
                WHERE id_pinjaman ='" & data.Cells(0).Value & "'"
                cmd = New MySqlCommand(sql_update, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("Data Berhasil Disimpan!")
        Call tampil()
    End Sub

    Private Sub tb_cari_Leave(sender As Object, e As EventArgs) Handles tb_cari.Leave
        Call cari()
        Call panggil_anggota()
    End Sub

    Private Sub PemijamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemijamanToolStripMenuItem.Click
        Me.Close()
        Peminjaman.Show()
    End Sub

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

    Private Sub dtp_kembali_ValueChanged(sender As Object, e As EventArgs) Handles dtp_kembali.ValueChanged
        Call hitung_denda()
    End Sub
    Private Sub clear()
        tb_id_anggota.Text = ""
        tb_id_pegawai.Text = ""
        tb_nama_anggota.Text = ""
        tb_nama_pegawai.Text = ""
    End Sub

    Private Sub clear_dgv()
        dgv_pengembalian.DataSource = Nothing
        dgv_pengembalian.Rows.Clear()
        dgv_pengembalian.Columns.Clear()
    End Sub

    Private Sub bt_simpan_Click(sender As Object, e As EventArgs) Handles bt_simpan.Click
        Call simpan()
        Call otomatis_id()
        Call clear()
        Call clear_dgv()
    End Sub
End Class