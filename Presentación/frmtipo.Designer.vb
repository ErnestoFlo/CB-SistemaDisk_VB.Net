<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtipo
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
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombre_Categoria = New System.Windows.Forms.TextBox()
        Me.txtdiscoid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
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
        'txtflag
        '
        Me.txtflag.Enabled = False
        Me.txtflag.Location = New System.Drawing.Point(254, 23)
        Me.txtflag.Margin = New System.Windows.Forms.Padding(2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(76, 20)
        Me.txtflag.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtNombre_Categoria)
        Me.GroupBox1.Controls.Add(Me.txtdiscoid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(319, 191)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.Location = New System.Drawing.Point(130, 143)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 27)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guarda los datos del nuevo tipo de disco")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Location = New System.Drawing.Point(227, 143)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 27)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancela la operación actual")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEditar.Location = New System.Drawing.Point(130, 143)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 27)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Abandona mantenimiento de tipo de disco")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNuevo.Location = New System.Drawing.Point(27, 143)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(59, 27)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Llena nuevos datos de tipo de disco")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombre_Categoria
        '
        Me.txtNombre_Categoria.Location = New System.Drawing.Point(110, 82)
        Me.txtNombre_Categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre_Categoria.Name = "txtNombre_Categoria"
        Me.txtNombre_Categoria.Size = New System.Drawing.Size(181, 20)
        Me.txtNombre_Categoria.TabIndex = 3
        '
        'txtdiscoid
        '
        Me.txtdiscoid.Enabled = False
        Me.txtdiscoid.Location = New System.Drawing.Point(110, 47)
        Me.txtdiscoid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdiscoid.Name = "txtdiscoid"
        Me.txtdiscoid.Size = New System.Drawing.Size(23, 20)
        Me.txtdiscoid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Categoría:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.DataListado)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cbEliminar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(384, 313)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Tipo de Disco"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(248, 136)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(107, 15)
        Me.inexistente.TabIndex = 6
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistentes"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(27, 109)
        Me.DataListado.Margin = New System.Windows.Forms.Padding(2)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersWidth = 51
        Me.DataListado.RowTemplate.Height = 24
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(333, 162)
        Me.DataListado.TabIndex = 5
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 125
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(27, 275)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(56, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Elimina el/los datos de los tipos de discos seleccionados")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(154, 52)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(206, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'cbEliminar
        '
        Me.cbEliminar.AutoSize = True
        Me.cbEliminar.Location = New System.Drawing.Point(27, 84)
        Me.cbEliminar.Margin = New System.Windows.Forms.Padding(2)
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
        Me.cboCampo.Items.AddRange(New Object() {"tipoDIsco"})
        Me.cboCampo.Location = New System.Drawing.Point(27, 50)
        Me.cboCampo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(109, 21)
        Me.cboCampo.TabIndex = 0
        Me.cboCampo.Text = "tipoDIsco"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(692, 351)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 19)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Abandona la pantalla de mantenimiento de tipo de discos")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmtipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtflag)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmtipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Tipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombre_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscoid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents DataListado As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents cboCampo As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents erroricono As ErrorProvider
End Class
