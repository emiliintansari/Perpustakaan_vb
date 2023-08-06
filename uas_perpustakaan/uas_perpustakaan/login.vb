Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class login
    Private Sub LandingPageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        landingpage.Show()
        Me.Close()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        tb_username.Text = ""
        tb_password.Text = ""
        Close()
        landingpage.Show()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Call koneksi()
            Dim str As String
            str = "SELECT * FROM petugas WHERE username='" & tb_username.Text & "' AND password='" & tb_password.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                Halaman_utama.nama_user = rd.Item("username")
                Halaman_utama.Show()
                Call clear()
                Halaman_utama.Visible = True
                Halaman_utama.Enabled = True
                Me.Hide()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb_username.Text = ""
                tb_password.Text = ""
                tb_username.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        landingpage.Hide()
    End Sub

    Private Sub clear()
        tb_username.Text = ""
        tb_password.Text = ""
    End Sub
End Class