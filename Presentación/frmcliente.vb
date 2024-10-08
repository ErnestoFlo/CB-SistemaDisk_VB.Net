Public Class frmcliente
    Private dt As New DataTable

    Private Sub frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
    Private Sub Mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar
            DataListado.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                txtBuscar.Enabled = True
                DataListado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                DataListado.DataSource = Nothing
                txtbuscar.Enabled = False
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtApellido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el apellido del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDNI_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDNI.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el DNI del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el teléfono del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la dirección del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtMovil_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMovil.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el correo del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el correo del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtFechaNac_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la fecha de nacimiento del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtCiudad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCiudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la ciudad de origen del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el departamento de origen del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtPais_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPais.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el país de origen del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtSexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSexo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el sexo del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNomCont_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNomCont.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de contacto del cliente, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtTelCont_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelCont.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el teléfono de contacto del cliente, este dato es obligatorio")
        End If
    End Sub
    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtidcliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtMovil.Text = ""
        txtCorreo.Text = ""
        txtFechaNac.Text = ""
        txtDepartamento.Text = ""
        txtPais.Text = ""
        txtCiudad.Text = ""
        txtSexo.Text = ""
        txtNomCont.Text = ""
        txtTelCont.Text = ""
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDNI.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtMovil.Text <> "" And txtCorreo.Text <> "" And txtFechaNac.Text <> "" And txtDepartamento.Text <> "" And txtPais.Text <> "" And txtCiudad.Text <> "" And txtSexo.Text <> "" And txtNomCont.Text <> "" And txtTelCont.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New fcliente
                dts.gnombres = txtNombre.Text
                dts.gapellidos = txtApellido.Text
                dts.gdni = txtDNI.Text
                dts.gdireccion = txtDireccion.Text
                dts.gtelefono = txtTelefono.Text
                dts.gmovil = txtMovil.Text
                dts.gcorreo = txtCorreo.Text
                dts.gfechanac = Convert.ToDateTime(txtFechaNac.Text)
                dts.gdepartamento = txtDepartamento.Text
                dts.gpais = txtPais.Text
                dts.gciudad = txtCiudad.Text
                dts.gsexo = txtSexo.Text
                dts.gnomcont = txtNomCont.Text
                dts.gtelcont = txtTelCont.Text
                If func.insertar(dts) Then
                    MsgBox("Cliente registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("Cliente no fue registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

                    Mostrar()
                    Limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Falta ingresar algunos datos !!!", 0 + 16, "Error en ingreso...")
        End If
    End Sub

    Private Sub DataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtidcliente.Text = DataListado.SelectedCells.Item(1).Value
        txtNombre.Text = DataListado.SelectedCells.Item(2).Value
        txtApellido.Text = DataListado.SelectedCells.Item(3).Value
        txtDNI.Text = DataListado.SelectedCells.Item(4).Value
        txtDireccion.Text = DataListado.SelectedCells.Item(5).Value
        txtTelefono.Text = DataListado.SelectedCells.Item(6).Value
        txtMovil.Text = DataListado.SelectedCells.Item(7).Value
        txtCorreo.Text = DataListado.SelectedCells.Item(8).Value
        txtFechaNac.Text = DataListado.SelectedCells.Item(9).Value
        txtDepartamento.Text = DataListado.SelectedCells.Item(10).Value
        txtPais.Text = DataListado.SelectedCells.Item(11).Value
        txtCiudad.Text = DataListado.SelectedCells.Item(12).Value
        txtSexo.Text = DataListado.SelectedCells.Item(13).Value
        txtNomCont.Text = DataListado.SelectedCells.Item(14).Value
        txtTelCont.Text = DataListado.SelectedCells.Item(15).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar los datos de este cliente?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDNI.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtMovil.Text <> "" And txtCorreo.Text <> "" And txtFechaNac.Text <> "" And txtDepartamento.Text <> "" And txtPais.Text <> "" And txtCiudad.Text <> "" And txtSexo.Text <> "" And txtNomCont.Text <> "" And txtTelCont.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gidcliente = txtidcliente.Text
                    dts.gnombres = txtNombre.Text
                    dts.gapellidos = txtApellido.Text
                    dts.gdni = txtDNI.Text
                    dts.gdireccion = txtDireccion.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.gmovil = txtMovil.Text
                    dts.gcorreo = txtCorreo.Text
                    dts.gfechanac = Convert.ToDateTime(txtFechaNac.Text)
                    dts.gdepartamento = txtDepartamento.Text
                    dts.gpais = txtPais.Text
                    dts.gciudad = txtCiudad.Text
                    dts.gsexo = txtSexo.Text
                    dts.gnomcont = txtNomCont.Text
                    dts.gtelcont = txtTelCont.Text
                    If func.editar(dts) Then
                        MsgBox("Cliente modificado correctamente", 0 + 64, "Proceso...")

                        Mostrar()
                        Limpiar()
                    Else
                        MsgBox("Cliente no fue modificado, intente de nuevo", 0 + 16, "Error en ingreso...")

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

    Private Sub cbEliminar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub DataListado_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcel As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcel.Value = Not chkcel.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea eliminar este cliente?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("clienteid").Value)

                        Dim vdb As New vcliente
                        Dim func As New fcliente
                        vdb.gidcliente = onekey
                        If func.eliminar(vdb) Then
                            ' Si elimina correctamente
                        Else
                            MsgBox("Cliente no fue eliminado !!!", 0 + 16, "Error en Proceso...")
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Cancelando eliminacion de clientes!!!", 0 + 64, "Proceso...")
            Call Mostrar()
        End If
        Call Limpiar()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call Mostrar()
        Call Limpiar()
    End Sub

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles toolTip1.Popup

    End Sub

    Private Sub txtFechaNac_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFechaNac.Validating
        If DirectCast(sender, DateTimePicker).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la fecha de nacimiento del cliente, este dato es obligatorio")
        End If
    End Sub
End Class