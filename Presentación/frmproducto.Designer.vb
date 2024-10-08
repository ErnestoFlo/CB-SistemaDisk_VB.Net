<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmproducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.PictureBox()
        Me.btnCargar = New System.Windows.Forms.PictureBox()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.txtNombreTipo = New System.Windows.Forms.TextBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtDiscoId = New System.Windows.Forms.TextBox()
        Me.txtNombreDisco = New System.Windows.Forms.TextBox()
        Me.txtiddisco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbEliminar = New System.Windows.Forms.CheckBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.txtNombreTipo)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtPrecioCompra)
        Me.GroupBox1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.txtCapacidad)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtDiscoId)
        Me.GroupBox1.Controls.Add(Me.txtNombreDisco)
        Me.GroupBox1.Controls.Add(Me.txtiddisco)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(545, 591)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Ingresa los datos del producto")
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(217, 615)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "&Guardar"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guarda los datos del nuevo producto")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.SisDiscos.My.Resources.Resources.filedelete
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnLimpiar.Location = New System.Drawing.Point(328, 481)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(50, 34)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.TabStop = False
        '
        'btnCargar
        '
        Me.btnCargar.BackgroundImage = Global.SisDiscos.My.Resources.Resources.fileadd
        Me.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnCargar.Location = New System.Drawing.Point(328, 439)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(50, 34)
        Me.btnCargar.TabIndex = 32
        Me.btnCargar.TabStop = False
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(468, 101)
        Me.btnbuscarcategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(51, 28)
        Me.btnbuscarcategoria.TabIndex = 31
        Me.btnbuscarcategoria.Text = "..."
        Me.btnbuscarcategoria.UseVisualStyleBackColor = True
        '
        'txtNombreTipo
        '
        Me.txtNombreTipo.Location = New System.Drawing.Point(209, 101)
        Me.txtNombreTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreTipo.Name = "txtNombreTipo"
        Me.txtNombreTipo.Size = New System.Drawing.Size(183, 22)
        Me.txtNombreTipo.TabIndex = 30
        '
        'imagen
        '
        Me.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen.Location = New System.Drawing.Point(171, 439)
        Me.imagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(133, 76)
        Me.imagen.TabIndex = 29
        Me.imagen.TabStop = False
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(171, 393)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(99, 22)
        Me.txtMarca.TabIndex = 28
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(171, 361)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(72, 22)
        Me.txtStock.TabIndex = 27
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.Location = New System.Drawing.Point(171, 329)
        Me.txtPrecioCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(79, 22)
        Me.txtPrecioCompra.TabIndex = 26
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(171, 297)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(79, 22)
        Me.txtPrecioVenta.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 428)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Imagen:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 396)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Marca:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 364)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Stock:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 332)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Precio Compra:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 300)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Precio Venta:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(171, 542)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 28)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "&Editar"
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Edita los datos del producto actual")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(301, 542)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancela la operación actual")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(40, 542)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "&Nuevo"
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Llena nuevos datos de producto")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(171, 265)
        Me.txtNombreProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(99, 22)
        Me.txtNombreProveedor.TabIndex = 11
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(171, 233)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(79, 22)
        Me.txtCapacidad.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(171, 134)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(347, 90)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtDiscoId
        '
        Me.txtDiscoId.Location = New System.Drawing.Point(171, 102)
        Me.txtDiscoId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiscoId.Name = "txtDiscoId"
        Me.txtDiscoId.Size = New System.Drawing.Size(29, 22)
        Me.txtDiscoId.TabIndex = 8
        '
        'txtNombreDisco
        '
        Me.txtNombreDisco.Location = New System.Drawing.Point(171, 70)
        Me.txtNombreDisco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreDisco.Name = "txtNombreDisco"
        Me.txtNombreDisco.Size = New System.Drawing.Size(293, 22)
        Me.txtNombreDisco.TabIndex = 7
        '
        'txtiddisco
        '
        Me.txtiddisco.Enabled = False
        Me.txtiddisco.Location = New System.Drawing.Point(171, 38)
        Me.txtiddisco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtiddisco.Name = "txtiddisco"
        Me.txtiddisco.Size = New System.Drawing.Size(29, 22)
        Me.txtiddisco.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Disco:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Disco:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1045, 482)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Abandona mantenimiento de productos")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Controls.Add(Me.cbEliminar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Location = New System.Drawing.Point(619, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(527, 414)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Productos"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(207, 23)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(296, 22)
        Me.txtBuscar.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(8, 377)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Elimina el/los datos de los productos seleccionados")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(191, 138)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(116, 16)
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
        Me.DataListado.Location = New System.Drawing.Point(8, 94)
        Me.DataListado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersWidth = 51
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(511, 265)
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
        Me.cbEliminar.Location = New System.Drawing.Point(8, 59)
        Me.cbEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(77, 20)
        Me.cbEliminar.TabIndex = 1
        Me.cbEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.cbEliminar, "Habilita la opción para de eliminar")
        Me.cbEliminar.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"Tipo_de_disco", "Nombre_de_disco", "Descripción", "Capacidad", "Nombre_de_proveedor", "Marca", "Imagen"})
        Me.cboCampo.Location = New System.Drawing.Point(8, 23)
        Me.cboCampo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(160, 24)
        Me.cboCampo.TabIndex = 0
        Me.cboCampo.Text = "Tipo_de_disco"
        Me.cboCampo.UseWaitCursor = True
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscoId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDisco As System.Windows.Forms.TextBox
    Friend WithEvents txtiddisco As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarcategoria As System.Windows.Forms.Button
    Friend WithEvents txtNombreTipo As System.Windows.Forms.TextBox
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents DataListado As System.Windows.Forms.DataGridView
    Friend WithEvents cbEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents cboCampo As System.Windows.Forms.ComboBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnLimpiar As PictureBox
    Friend WithEvents btnCargar As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents erroricono As ErrorProvider
End Class
