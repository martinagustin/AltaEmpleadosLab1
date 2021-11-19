Imports System.Data.OleDb
Module Conexiones
    Public Conexion As OleDb.OleDbConnection

    Public Sub AbrirConexion()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\source\repos\visual\datos.mdb;"
        Try

            Conexion.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "2021")

            Conexion.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "2021")
        End Try
    End Sub
    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)

        Conexion.Open()

        Try

            Dim cmd As New OleDbCommand(Sql, Conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logro realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "2021")
        End Try
        Conexion.Close()
    End Sub


End Module
