Imports System.Data.SqlClient
Public Class fusuario

    Inherits Conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuario")
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

    Public Function insertar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombreUsuario", dts.gnombreUsuario)
            cmd.Parameters.AddWithValue("@apellidoUsuario", dts.gapellidoUsuario)
            cmd.Parameters.AddWithValue("@numidentidad", dts.gnumidentidad)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)

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

    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idUsuario", dts.gidUsuario)
            cmd.Parameters.AddWithValue("@nombreUsuario", dts.gnombreUsuario)
            cmd.Parameters.AddWithValue("@apellidoUsuario", dts.gapellidoUsuario)
            cmd.Parameters.AddWithValue("@numidentidad", dts.gnumidentidad)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)

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

    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idUsuario", SqlDbType.NVarChar, 50).Value = dts.gidUsuario
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

    Public Function validar_usuario(ByVal dts As vusuario)

        Try
            conectado()

            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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
