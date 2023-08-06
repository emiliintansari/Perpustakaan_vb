Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module sambung
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public atr As String
    Public Sub koneksi()
        Try
            Dim str As String =
                "Server=localhost;user id=root;password=;database=perpustakaan_uas"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
