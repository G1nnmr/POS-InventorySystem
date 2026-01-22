Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Module dbConnection
    Public conn As MySqlConnection
    Public command As New MySqlCommand
    Public read As MySqlDataReader
    Public query As String
    Public i As Integer
    Public dt As New DataTable
    Public da As SqlDataAdapter
    Dim res As Boolean

    Public Function Connect() As Boolean
        Try
            conn = New MySqlConnection With {            'VAS           V@Sposinventory.,
            .ConnectionString = "server=localhost; userid=VAS; password=V@Sposinventory.,; database=vas; sslmode= none; pooling=false"
            }
            conn.Open()
            res = True
        Catch ex As Exception
            res = False
            MsgBox("Database Connection Failed!", vbExclamation)
        End Try
        Return res
    End Function
End Module