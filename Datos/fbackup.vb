Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class fbackup

    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function backupbase() As Boolean
        Try
            conectado()
            ' mostrar_cliente es un procedimiento almacenado en la BD
            cmd = New SqlCommand("backup_base")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
