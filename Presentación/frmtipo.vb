Public Class frmtipo
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim R As Integer
        R = MsgBox("¿Esta seguro que desea salir?", 4 + 32 + 256, "Confirme...")
        If R = 6 Then
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private dt As New DataTable
    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtBuscar.Text = ""
        txtdiscoid.Text = ""
        txtflag.Text = ""
        txtNombre_Categoria.Text = ""
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
            Dim func As New ftipo
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Mostrar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Mostrar()
        Limpiar()
    End Sub

    Private Sub frmtipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre_Categoria.Text <> "" Then
            Try
                Dim dts As New vtipo
                Dim func As New ftipo
                dts.gtipoDisco = txtNombre_Categoria.Text


                If func.insertar(dts) Then
                    MsgBox("Tipo Disco registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    'Limpiar()'
                Else
                    MsgBox("El tipo de disco no fue registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar los datos de este proveedor?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtNombre_Categoria.Text <> "" And txtdiscoid.Text <> "" Then
                Try
                    Dim dts As New vtipo
                    Dim func As New ftipo

                    dts.gdiscoid = txtdiscoid.Text
                    dts.gtipoDisco = txtNombre_Categoria.Text

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

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        btnEditar.Visible = True
        btnGuardar.Visible = False

        txtdiscoid.Text = DataListado.SelectedCells.Item(1).Value
        txtNombre_Categoria.Text = DataListado.SelectedCells.Item(2).Value
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcel As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcel.Value = Not chkcel.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea eliminar este Tipo de Disco?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("discoid").Value)

                        Dim vdb As New vtipo
                        Dim func As New ftipo
                        vdb.gdiscoid = onekey
                        If func.eliminar(vdb) Then
                            MsgBox("Tipo de disco eliminado correctamente", 0 + 64, "Proceso...")
                        Else
                            MsgBox("El tipo de disco no fue eliminado !!!", 0 + 16, "Error en Proceso...")
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub txtNombre_Categoria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre_Categoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del tipo de disco, este dato es obligatorio")
        End If
    End Sub
End Class