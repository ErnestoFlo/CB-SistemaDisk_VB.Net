Imports System.Data.SqlClient
Public Class fcliente
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_cliente")
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

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@numidentidad", dts.gdni)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@movil", dts.gmovil)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfechanac)
            cmd.Parameters.AddWithValue("@departamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("@pais", dts.gpais)
            cmd.Parameters.AddWithValue("@ciudad", dts.gciudad)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@nom_contacto", dts.gnomcont)
            cmd.Parameters.AddWithValue("@tel_contacto", dts.gtelcont)

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
    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@clienteid", dts.gidcliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@numidentidad", dts.gdni)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@movil", dts.gmovil)
            cmd.Parameters.AddWithValue("@correo", dts.gcorreo)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfechanac)
            cmd.Parameters.AddWithValue("@departamento", dts.gdepartamento)
            cmd.Parameters.AddWithValue("@pais", dts.gpais)
            cmd.Parameters.AddWithValue("@ciudad", dts.gciudad)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@nom_contacto", dts.gnomcont)
            cmd.Parameters.AddWithValue("@tel_contacto", dts.gtelcont)
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
    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@clienteid", SqlDbType.NVarChar, 50).Value = dts.gidcliente
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
