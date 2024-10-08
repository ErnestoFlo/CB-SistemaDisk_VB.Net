Imports System.Drawing.Imaging

Public Class frmproducto

    Private dt As New DataTable
    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtBuscar.Text = ""
        txtCapacidad.Text = ""
        txtDescripcion.Text = ""
        txtDiscoId.Text = ""
        txtiddisco.Text = ""
        txtMarca.Text = ""
        txtNombreDisco.Text = ""
        txtNombreProveedor.Text = ""
        txtNombreTipo.Text = ""
        txtPrecioCompra.Text = ""
        txtPrecioVenta.Text = ""
        txtStock.Text = ""

        imagen.Image = Nothing
        'Imagen.BackgroundImage = My.Resources.nofile
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New fproducto
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
        DataListado.Columns(2).Visible = False
    End Sub

    Private Sub DataListado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcel As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcel.Value = Not chkcel.Value
        End If
    End Sub

    Private Sub frmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtCapacidad.Text <> "" And txtDescripcion.Text <> "" And txtDiscoId.Text <> "" And txtMarca.Text <> "" And txtNombreDisco.Text <> "" And txtNombreProveedor.Text <> "" And txtNombreTipo.Text <> "" And txtPrecioCompra.Text <> "" And txtPrecioVenta.Text <> "" And txtStock.Text <> "" Then
            Try
                Dim dts As New vproducto
                Dim func As New fproducto

                dts.gdiscoid = txtDiscoId.Text
                dts.gnombre_disco = txtNombreDisco.Text
                dts.gdescripcion = txtDescripcion.Text
                dts.gcapacidad = txtCapacidad.Text
                dts.gnom_proveedor = txtNombreProveedor.Text
                dts.gprecio_venta = txtPrecioVenta.Text
                dts.gprecio_compra = txtPrecioCompra.Text
                dts.gstock = txtStock.Text
                dts.gmarca = txtMarca.Text

                'Variable de control en memoria de la imagen
                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                    'asignamos el buffer a getter de la imagen
                    dts.gimagen = ms.GetBuffer
                Else
                    'imagen.BackgroundImage = My.Resources.nofile
                    'imagen.Image.Save(ms, imagen.Image.RawFormat)
                    dts.gimagen = ""
                End If

                'asignamos el buffer a getter de la imagen
                dts.gimagen = ms.GetBuffer

                If func.insertar(dts) Then
                    MsgBox("Producto registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("El producto no fue registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtiddisco.Text = DataListado.SelectedCells.Item(1).Value
        txtDiscoId.Text = DataListado.SelectedCells.Item(2).Value
        txtNombreTipo.Text = DataListado.SelectedCells.Item(3).Value
        txtNombreDisco.Text = DataListado.SelectedCells.Item(4).Value
        txtDescripcion.Text = DataListado.SelectedCells.Item(5).Value
        txtCapacidad.Text = DataListado.SelectedCells.Item(6).Value
        txtNombreProveedor.Text = DataListado.SelectedCells.Item(7).Value
        txtPrecioVenta.Text = DataListado.SelectedCells.Item(8).Value
        txtPrecioCompra.Text = DataListado.SelectedCells.Item(9).Value
        txtStock.Text = DataListado.SelectedCells.Item(10).Value
        txtMarca.Text = DataListado.SelectedCells.Item(11).Value

        imagen.BackgroundImage = Nothing

        Dim b() As Byte = DataListado.SelectedCells.Item(12).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        btnEditar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea eliminar este producto?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idDisco").Value)

                        Dim vdb As New vproducto
                        Dim func As New fproducto
                        vdb.gidDisco = onekey
                        If func.eliminar(vdb) Then
                            ' Si elimina correctamente
                            MsgBox("Producto Eliminado correctamente", 0 + 64, "Completado")

                        Else
                            MsgBox("El producto no fue eliminado !!!", 0 + 16, "Error en Proceso...")
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

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar los datos de este cliente?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtCapacidad.Text <> "" And txtDescripcion.Text <> "" And txtDiscoId.Text <> "" And txtMarca.Text <> "" And txtNombreDisco.Text <> "" And txtNombreProveedor.Text <> "" And txtNombreTipo.Text <> "" And txtPrecioCompra.Text <> "" And txtPrecioVenta.Text <> "" And txtStock.Text <> "" Then
                Try
                    Dim dts As New vproducto
                    Dim func As New fproducto

                    dts.gidDisco = txtiddisco.Text
                    dts.gdiscoid = txtDiscoId.Text
                    dts.gnombre_disco = txtNombreDisco.Text
                    dts.gdescripcion = txtDescripcion.Text
                    dts.gcapacidad = txtCapacidad.Text
                    dts.gnom_proveedor = txtNombreProveedor.Text
                    dts.gprecio_venta = txtPrecioVenta.Text
                    dts.gprecio_compra = txtPrecioCompra.Text
                    dts.gstock = txtStock.Text
                    dts.gmarca = txtMarca.Text

                    'Variable de control en memoria de la imagen
                    Dim ms As New IO.MemoryStream()

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                        'asignamos el buffer a getter de la imagen
                        dts.gimagen = ms.GetBuffer
                    Else
                        'imagen.Image.Save(ms, imagen.Image.RawFormat)
                        dts.gimagen = ""
                    End If

                    'asignamos el buffer a getter de la imagen
                    dts.gimagen = ms.GetBuffer

                    If func.editar(dts) Then
                        MsgBox("Producto modificado correctamente", 0 + 64, "Proceso...")

                        Mostrar()
                        Limpiar()
                    Else
                        MsgBox("El producto no fue modificado, intente de nuevo", 0 + 16, "Error en ingreso...")

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

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frmtipo.ShowDialog()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        imagen.Image = Nothing
        'imagen.BackgroundImage = My.Resources.nofile
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtNombreDisco_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreDisco.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDiscoId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDiscoId.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el identificador del tipo de disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNombreTipo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreTipo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del tipo de disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la descripción del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtCapacidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCapacidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la capacidad del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtNombreProveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreProveedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del proveedor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtPrecioVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecioVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de venta del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtPrecioCompra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecioCompra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de compra del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtStock_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la existencia del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtMarca_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la marca del disco, este dato es obligatorio")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call Mostrar()
        Call Limpiar()
    End Sub
End Class