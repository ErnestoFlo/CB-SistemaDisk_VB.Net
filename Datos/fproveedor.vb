Imports System.Data.SqlClient
Public Class fproveedor

    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedor")
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

    Public Function insertar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idDisco", dts.gidDisco)
            cmd.Parameters.AddWithValue("@nom_proveedor", dts.gnom_proveedor)
            cmd.Parameters.AddWithValue("@nom_contacto", dts.gnom_contacto)
            cmd.Parameters.AddWithValue("@cargo_contacto", dts.gcargo_contacto)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@ciudad", dts.gciudad)
            cmd.Parameters.AddWithValue("@departamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("@pais", dts.gpais)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@terminos_pago", dts.gterminos_pago)
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

    Public Function editar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idProveedor", dts.gidProveedor)
            cmd.Parameters.AddWithValue("@idDisco", dts.gidDisco)
            cmd.Parameters.AddWithValue("@nom_proveedor", dts.gnom_proveedor)
            cmd.Parameters.AddWithValue("@nom_contacto", dts.gnom_contacto)
            cmd.Parameters.AddWithValue("@cargo_contacto", dts.gcargo_contacto)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@ciudad", dts.gciudad)
            cmd.Parameters.AddWithValue("@departamento", dts.gdireccion)
            cmd.Parameters.AddWithValue("@pais", dts.gpais)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@terminos_pago", dts.gterminos_pago)
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

    Public Function eliminar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idProveedor", SqlDbType.NVarChar, 50).Value = dts.gidProveedor
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
