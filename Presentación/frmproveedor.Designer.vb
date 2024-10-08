<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidDisco = New System.Windows.Forms.TextBox()
        Me.txtbuscarProducto = New System.Windows.Forms.Button()
        Me.txtterminos_pago = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtpais = New System.Windows.Forms.TextBox()
        Me.txtdepartamento = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcargo_contacto = New System.Windows.Forms.TextBox()
        Me.txtnom_contacto = New System.Windows.Forms.TextBox()
        Me.txtnom_proveedor = New System.Windows.Forms.TextBox()
        Me.txtnombreDisco = New System.Windows.Forms.TextBox()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbEliminar = New System.Windows.Forms.CheckBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidDisco)
        Me.GroupBox1.Controls.Add(Me.txtbuscarProducto)
        Me.GroupBox1.Controls.Add(Me.txtterminos_pago)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtpais)
        Me.GroupBox1.Controls.Add(Me.txtdepartamento)
        Me.GroupBox1.Controls.Add(Me.txtciudad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtcargo_contacto)
        Me.GroupBox1.Controls.Add(Me.txtnom_contacto)
        Me.GroupBox1.Controls.Add(Me.txtnom_proveedor)
        Me.GroupBox1.Controls.Add(Me.txtnombreDisco)
        Me.GroupBox1.Controls.Add(Me.txtidProveedor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 405)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtidDisco
        '
        Me.txtidDisco.Location = New System.Drawing.Point(128, 57)
        Me.txtidDisco.Name = "txtidDisco"
        Me.txtidDisco.Size = New System.Drawing.Size(23, 20)
        Me.txtidDisco.TabIndex = 32
        '
        'txtbuscarProducto
        '
        Me.txtbuscarProducto.Location = New System.Drawing.Point(236, 57)
        Me.txtbuscarProducto.Name = "txtbuscarProducto"
        Me.txtbuscarProducto.Size = New System.Drawing.Size(50, 20)
        Me.txtbuscarProducto.TabIndex = 31
        Me.txtbuscarProducto.Text = "..."
        Me.txtbuscarProducto.UseVisualStyleBackColor = True
        '
        'txtterminos_pago
        '
        Me.txtterminos_pago.Location = New System.Drawing.Point(128, 317)
        Me.txtterminos_pago.Name = "txtterminos_pago"
        Me.txtterminos_pago.Size = New System.Drawing.Size(75, 20)
        Me.txtterminos_pago.TabIndex = 30
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(128, 291)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtcorreo.TabIndex = 29
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(128, 265)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(60, 20)
        Me.txttelefono.TabIndex = 28
        '
        'txtpais
        '
        Me.txtpais.Location = New System.Drawing.Point(128, 239)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(100, 20)
        Me.txtpais.TabIndex = 27
        '
        'txtdepartamento
        '
        Me.txtdepartamento.Location = New System.Drawing.Point(128, 213)
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(100, 20)
        Me.txtdepartamento.TabIndex = 26
        '
        'txtciudad
        '
        Me.txtciudad.Location = New System.Drawing.Point(128, 187)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(100, 20)
        Me.txtciudad.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Términos de pago:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Correo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "País:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Departamento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Ciudad:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(140, 360)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "&Editar"
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Edita los datos del proveedor actual")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(236, 360)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancela la operación actual")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(140, 360)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "&Guardar"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guarda los datos del nuevo proveedor")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(39, 360)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "&Nuevo"
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Llena nuevos datos de proveedor")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(128, 161)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 11
        '
        'txtcargo_contacto
        '
        Me.txtcargo_contacto.Location = New System.Drawing.Point(128, 135)
        Me.txtcargo_contacto.Name = "txtcargo_contacto"
        Me.txtcargo_contacto.Size = New System.Drawing.Size(100, 20)
        Me.txtcargo_contacto.TabIndex = 10
        '
        'txtnom_contacto
        '
        Me.txtnom_contacto.Location = New System.Drawing.Point(128, 109)
        Me.txtnom_contacto.Name = "txtnom_contacto"
        Me.txtnom_contacto.Size = New System.Drawing.Size(75, 20)
        Me.txtnom_contacto.TabIndex = 9
        '
        'txtnom_proveedor
        '
        Me.txtnom_proveedor.Location = New System.Drawing.Point(128, 83)
        Me.txtnom_proveedor.Name = "txtnom_proveedor"
        Me.txtnom_proveedor.Size = New System.Drawing.Size(75, 20)
        Me.txtnom_proveedor.TabIndex = 8
        '
        'txtnombreDisco
        '
        Me.txtnombreDisco.Location = New System.Drawing.Point(157, 57)
        Me.txtnombreDisco.Name = "txtnombreDisco"
        Me.txtnombreDisco.Size = New System.Drawing.Size(71, 20)
        Me.txtnombreDisco.TabIndex = 7
        '
        'txtidProveedor
        '
        Me.txtidProveedor.Enabled = False
        Me.txtidProveedor.Location = New System.Drawing.Point(128, 31)
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.Size = New System.Drawing.Size(23, 20)
        Me.txtidProveedor.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cargo de contacto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre de contacto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Controls.Add(Me.cbEliminar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 291)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Proveedores"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(155, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(223, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(7, 256)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Elimina el/los datos de los proveedores seleccionados")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(152, 151)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(107, 15)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(7, 77)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersWidth = 51
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(371, 154)
        Me.DataListado.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'cbEliminar
        '
        Me.cbEliminar.AutoSize = True
        Me.cbEliminar.Location = New System.Drawing.Point(6, 46)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(75, 19)
        Me.cbEliminar.TabIndex = 1
        Me.cbEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.cbEliminar, "Habilita la opción para de eliminar")
        Me.cbEliminar.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"Nombre_de_disco", "Nombre_de_proveedor", "Nombre_de_contacto", "Cargo_de_contacto", "Dirección", "Ciudad", "Departamento", "País", "Teléfono", "Correo", "Términos_de_pago"})
        Me.cboCampo.Location = New System.Drawing.Point(6, 19)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 0
        Me.cboCampo.Text = "Nombre_de_disco"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(677, 321)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "&Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Abandona mantenimiento de proveedores")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmproveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmproveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtterminos_pago As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtpais As TextBox
    Friend WithEvents txtdepartamento As TextBox
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcargo_contacto As TextBox
    Friend WithEvents txtnom_contacto As TextBox
    Friend WithEvents txtnom_proveedor As TextBox
    Friend WithEvents txtnombreDisco As TextBox
    Friend WithEvents txtidProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents cbEliminar As CheckBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtbuscarProducto As Button
    Friend WithEvents txtidDisco As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents erroricono As ErrorProvider
End Class
