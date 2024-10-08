Public Class frmproveedor
    Private dt As New DataTable
    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtBuscar.Text = ""
        txtbuscarProducto.Text = ""
        txtcargo_contacto.Text = ""
        txtciudad.Text = ""
        txtcorreo.Text = ""
        txtdepartamento.Text = ""
        txtdireccion.Text = ""
        txtnombreDisco.Text = ""
        txtidProveedor.Text = ""
        txtnom_contacto.Text = ""
        txtnom_proveedor.Text = ""
        txtpais.Text = ""
        txttelefono.Text = ""
        txtterminos_pago.Text = ""
        txtidDisco.Text = ""
    End Sub

    Private Sub ocultar_columnas()
        DataListado.Columns(1).Visible = False
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

    Private Sub Mostrar()
        Try
            Dim func As New fproveedor
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
    Private Sub frmproveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtnom_proveedor.TextChanged

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub txtbuscarProducto_Click(sender As Object, e As EventArgs) Handles txtbuscarProducto.Click
        frmproducto.ShowDialog()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Mostrar()
        Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtidDisco.Text <> "" And txtnom_proveedor.Text <> "" And txtnom_contacto.Text <> "" And txtcargo_contacto.Text <> "" And txtdireccion.Text <> "" And txtciudad.Text <> "" And txtdepartamento.Text <> "" And txtpais.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And txtterminos_pago.Text <> "" Then
            Try
                Dim dts As New vproveedor
                Dim func As New fproveedor

                dts.gidDisco = txtidDisco.Text
                dts.gnom_proveedor = txtnom_proveedor.Text
                dts.gnom_contacto = txtnom_contacto.Text
                dts.gcargo_contacto = txtcargo_contacto.Text
                dts.gdireccion = txtdireccion.Text
                dts.gciudad = txtciudad.Text
                dts.gdepartamento = txtdepartamento.Text
                dts.gpais = txtpais.Text
                dts.gtelefono = txttelefono.Text
                dts.gcorreo = txtcorreo.Text
                dts.gterminos_pago = txtterminos_pago.Text

                If func.insertar(dts) Then
                    MsgBox("Proveedor registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    'Limpiar()'
                Else
                    MsgBox("El proveedor no fue registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

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

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea eliminar este proveedor?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idProveedor").Value)

                        Dim vdb As New vproveedor
                        Dim func As New fproveedor
                        vdb.gidProveedor = onekey
                        If func.eliminar(vdb) Then
                            MsgBox("Proveedor eliminado correctamente", 0 + 64, "Proceso...")
                        Else
                            MsgBox("El proveedor no fue eliminado !!!", 0 + 16, "Error en Proceso...")
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Cancelando eliminacion de proveedor!!!", 0 + 64, "Proceso...")
            Call Mostrar()
        End If
        Call Limpiar()
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtidProveedor.Text = DataListado.SelectedCells.Item(1).Value
        txtidDisco.Text = DataListado.SelectedCells.Item(2).Value
        txtnombreDisco.Text = DataListado.SelectedCells.Item(3).Value
        txtnom_proveedor.Text = DataListado.SelectedCells.Item(4).Value
        txtnom_contacto.Text = DataListado.SelectedCells.Item(5).Value
        txtcargo_contacto.Text = DataListado.SelectedCells.Item(6).Value
        txtdireccion.Text = DataListado.SelectedCells.Item(7).Value
        txtciudad.Text = DataListado.SelectedCells.Item(8).Value
        txtdepartamento.Text = DataListado.SelectedCells.Item(9).Value
        txtpais.Text = DataListado.SelectedCells.Item(10).Value
        txttelefono.Text = DataListado.SelectedCells.Item(11).Value
        txtcorreo.Text = DataListado.SelectedCells.Item(12).Value
        txtterminos_pago.Text = DataListado.SelectedCells.Item(13).Value

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcel As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcel.Value = Not chkcel.Value
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar los datos de este proveedor?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtidProveedor.Text <> "" And txtidDisco.Text <> "" And txtnom_proveedor.Text <> "" And txtnom_contacto.Text <> "" And txtcargo_contacto.Text <> "" And txtdireccion.Text <> "" And txtciudad.Text <> "" And txtdepartamento.Text <> "" And txtpais.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And txtterminos_pago.Text <> "" Then
                Try
                    Dim dts As New vproveedor
                    Dim func As New fproveedor

                    dts.gidProveedor = txtidProveedor.Text
                    dts.gidDisco = txtidDisco.Text
                    dts.gnom_proveedor = txtnom_proveedor.Text
                    dts.gnom_contacto = txtnom_contacto.Text
                    dts.gcargo_contacto = txtcargo_contacto.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gciudad = txtciudad.Text
                    dts.gdepartamento = txtdepartamento.Text
                    dts.gpais = txtpais.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gcorreo = txtcorreo.Text
                    dts.gterminos_pago = txtterminos_pago.Text

                    If func.editar(dts) Then
                        MsgBox("Proveedor modificado correctamente", 0 + 64, "Proceso...")

                        Mostrar()
                        Limpiar()
                    Else
                        MsgBox("El proveedor no fue modificado, intente de nuevo", 0 + 16, "Error en ingreso...")

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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtidDisco_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtidDisco.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el identificador del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnombreDisco_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombreDisco.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnom_proveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnom_proveedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnom_contacto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnom_contacto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de contacto del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcargo_contacto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcargo_contacto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el cargo del contacto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la dirección del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtciudad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtciudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la ciudad del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el departamento del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtpais_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpais.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el país del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txttelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el teléfono de proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtcorreo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el correo del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtterminos_pago_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtterminos_pago.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese los terminos de pago del proveedor, este dato es obligatorio")
        End If
    End Sub
End Class