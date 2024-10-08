Public Class frmusuario
    Private dt As New DataTable
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub frmusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    '------------------- FUNCIONES LOCALES ------------------- '

    Private Sub Mostrar()
        Try
            Dim func As New fusuario
            dt = func.mostrar
            DataListado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                txtBuscar.Enabled = True
                DataListado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                DataListado.DataSource = Nothing
                txtBuscar.Enabled = False
                DataListado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True
        btnEditar.Visible = False
        Buscar()
    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = cboCampo.Text & " like '" & txtBuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                DataListado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                DataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        DataListado.Columns(1).Visible = False
    End Sub

    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidUsuario.Text = ""
        txtnombreUsuario.Text = ""
        txtapellidoUsuario.Text = ""
        txtDNI.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtlogin.Text = ""
        txtpassword.Text = ""
        txtacceso.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Mostrar()
        Limpiar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtidUsuario.Text = DataListado.SelectedCells.Item(1).Value
        txtnombreUsuario.Text = DataListado.SelectedCells.Item(2).Value
        txtapellidoUsuario.Text = DataListado.SelectedCells.Item(3).Value
        txtDNI.Text = DataListado.SelectedCells.Item(4).Value
        txtDireccion.Text = DataListado.SelectedCells.Item(5).Value
        txtTelefono.Text = DataListado.SelectedCells.Item(6).Value
        txtCorreo.Text = DataListado.SelectedCells.Item(7).Value
        txtlogin.Text = DataListado.SelectedCells.Item(8).Value
        txtpassword.Text = DataListado.SelectedCells.Item(9).Value
        txtacceso.Text = DataListado.SelectedCells.Item(10).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtnombreUsuario.Text <> "" And txtapellidoUsuario.Text <> "" And txtDNI.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCorreo.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" And txtacceso.Text <> "" Then
            Try
                Dim dts As New vusuario
                Dim func As New fusuario
                dts.gnombreUsuario = txtnombreUsuario.Text
                dts.gapellidoUsuario = txtapellidoUsuario.Text
                dts.gnumidentidad = txtDNI.Text
                dts.gdireccion = txtDireccion.Text
                dts.gtelefono = txtTelefono.Text
                dts.gcorreo = txtCorreo.Text
                dts.glogin = txtlogin.Text
                dts.gpassword = txtpassword.Text
                dts.gacceso = txtacceso.Text


                If func.insertar(dts) Then
                    MsgBox("Usuario registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    'Limpiar()'
                Else
                    MsgBox("Usuario no fue registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

                    Mostrar()
                    'Limpiar()'
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Falta ingresar algunos datos !!!", 0 + 16, "Error en ingreso...")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcel As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcel.Value = Not chkcel.Value
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar los datos de este cliente?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtidUsuario.Text <> "" And txtnombreUsuario.Text <> "" And txtapellidoUsuario.Text <> "" And txtDNI.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCorreo.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" And txtacceso.Text <> "" Then
                Try
                    Dim dts As New vusuario
                    Dim func As New fusuario

                    dts.gidUsuario = txtidUsuario.Text
                    dts.gnombreUsuario = txtnombreUsuario.Text
                    dts.gapellidoUsuario = txtapellidoUsuario.Text
                    dts.gnumidentidad = txtDNI.Text
                    dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.gcorreo = txtCorreo.Text
                    dts.glogin = txtlogin.Text
                    dts.gpassword = txtpassword.Text
                    dts.gacceso = txtacceso.Text

                    If func.editar(dts) Then
                        MsgBox("Usuario modificado correctamente", 0 + 64, "Proceso...")

                        Mostrar()
                        Limpiar()
                    Else
                        MsgBox("Usuario no fue modificado, intente de nuevo", 0 + 16, "Error en ingreso...")

                        Mostrar()
                        Limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Falta ingresar algunos datos...", 0 + 16, "Error en ingreso...")
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea eliminar este cliente?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)

                        Dim vdb As New vusuario
                        Dim func As New fusuario
                        vdb.gidUsuario = onekey
                        If func.eliminar(vdb) Then
                            ' Si elimina correctamente
                        Else
                            MsgBox("Usuario no fue eliminado !!!", 0 + 16, "Error en Proceso...")
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Cancelando eliminacion de Usuario!!!", 0 + 64, "Proceso...")
            Call Mostrar()
        End If
        Call Limpiar()
    End Sub

    Private Sub txtnombreUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombreUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtapellidoUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellidoUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el apellido del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDNI_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDNI.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el DNI del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la dirección del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el teléfono del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el correo del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtlogin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtlogin.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de acceso de su usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtpassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpassword.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la contraseña del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtacceso_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtacceso.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el valor de acceso del usuario, este dato es obligatorio")
        End If
    End Sub
End Class