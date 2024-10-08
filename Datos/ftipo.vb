Imports System.Data.SqlClient

Public Class ftipo

    Inherits Conexion
    Dim cmd As New SqlCommand


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_tipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vtipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_tipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@tipoDisco", dts.gtipoDisco)

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

    Public Function editar(ByVal dts As vtipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_tipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@discoid", dts.gdiscoid)
            cmd.Parameters.AddWithValue("@tipoDisco", dts.gtipoDisco)

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

    Public Function eliminar(ByVal dts As vtipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_tipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@discoid", SqlDbType.NVarChar, 50).Value = dts.gdiscoid
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
