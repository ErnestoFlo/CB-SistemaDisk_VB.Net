# CRUD VB.Net - Sistema de inventario de discos

_Sistema de final de curso. Realizado para el manejo e inventariado de discos_

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/Menu%20pricipal.png" /></p>

## Soluciones

_Este programa busca solucionar los problemas de gestion de inventario de una tienda de discos. Por lo que con nuestro sistema, buscamos gestionar mediante CRUDs una serie de modulos que facilitan al cliente a manejar de manera efectiva sus datos. Estos modulos son:_

* Clientes
* Categorías
* Productos 
* Proveedores
* Usuarios

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/modulos.png"/></p>


## Metodología de trabajo

_Para la elaboración del proyecto, se planteó manejar el paradigma de programación de `POO` o `Programación Orientada a Objetos`, esto con el fin de buscar un desarrollo basado en objetos que nos permita el modelaje de `funciones`, `clases`, `métodos` y `formularios` con las cuales construimos la funcionalidad del sistema._

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/estructura.png" /></p>

### Funciones

_Las **funciones** es el código que nos permite comunicarnos mediante la conexión hacia la `base de datos`, brindando acceso a cada uno de los formularios con los `procedimientos almacenados` creados para dar la funcionalidad de CRUD en cada pantalla del sistema. Estas funciones estan alojadas en la carpeta de `Datos`._

_La estructura básica de las **Funciones** para el crud se trabajaron de la siguiente manera:_

**Conexión a BD:**
```vb
    Protected Function conectado()
        Try
            cnn = New SqlConnection("data source=AquiPonesTuInstanciaEnElServidor; initial catalog=sistema_discos ;integrated security= true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
```

**Desconexión a BD:**
```vb
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
```

**Crear Variable cmd para utilizar como comando:**

```vb
Dim cmd As New SqlCommand
```

**Mostrar:**

```vb
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("procedimiento_mostrar")
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
```

**Ingresar:**
```vb
    Public Function insertar(ByVal dts As vMetodo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("procedimiento_insertar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@variableA", dts.gvariableA)
            cmd.Parameters.AddWithValue("@variableB", dts.gvariableB)
            cmd.Parameters.AddWithValue("@variableC", dts.gvariableC)

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
```

**Editar:**

```vb
    Public Function editar(ByVal dts As vMetodo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("procedimiento_editar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id", dts.gid)
            cmd.Parameters.AddWithValue("@variableA", dts.gvariableA)
            cmd.Parameters.AddWithValue("@variableB", dts.gvariableB)
            cmd.Parameters.AddWithValue("@variableC", dts.gvariableC)

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
```

**Eliminar:**
```vb
    Public Function eliminar(ByVal dts As vMetodo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("procedimiento_eliminar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid

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
```
### Métodos

_Los **métodos** son las variables centrales, que nos permite la comunicación entre la `base de datos` y el `entorno intereactivo` de nuestro sistema interactuando con estas mediate `ByVal dts As vMetodo` en las funciones. Aqui es donde "setteamos" variables para guardar información y "getteamos" para leer los datos que poseen estos campos. Estos métodos se alamcenanan en la carpeta `Lógica`_

**Ejemplo:**

```vb
    Dim id As Integer
    Dim variableA, variableB, variableC As String

    Public Property gid
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property

    Public Property gvariableA
        Get
            Return variableA
        End Get
        Set(ByVal value)
            variableA = value
        End Set
    End Property

    Public Property gvariableB
        Get
            Return variableB
        End Get
        Set(ByVal value)
            variableB = value
        End Set
    End Property

    Public Property gvariableC
        Get
            Return variableC
        End Get
        Set(ByVal value)
            variableC = value
        End Set
    End Property
```

**Constructores:**

_Los `constructores` son los métodos encargados de inicializar el objeto que se acaba de crear y es donde se recopilan los datos para enviar a BD mediante nuestra instancia. Ejemplo:_

```vb
    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal variableA As String, ByVal variableB As String, ByVal variableC As String)
        gid = id
        gvariableA = variableA
        gvariableB = variableB
        gvariableC = variableC

    End Sub
```

<br/>
> [!NOTE]
> Cabe recalcar que incluye un contructor vacío o sin parámetros por que es un ejemplo de `sobrecarga de constructores` el cual tiene propósitos muy útiles como los siguientes:_

* **Flexibilidad de creación de objetos:** Le brindas al programador la opción de crear un objeto sin la necesidad de proporcinar la totalidad de las variables, además de poder asignar los valores posteriormente por medio de los `métodos`.
* **Compatibilidad con librerías y Framework:** Algunos frameworks usados para la `serialización/deserialización`, mapeo de bases de datos `ORM` o `interfaces gráficas` requieren este constructor para instanciar objetos.
* **Inicialización por defecto:** Es útil para asignar a un objeto valores predeterminados de arranque. 
* **Sobrecarga de constructores:** Dejar el contructor vacío nos permite dar flexibilidad al momento de la creación del objeto en cuestión, ya que nos permite crear multiples escenario donde no es necesaria la incialización de todos los valores del objeto.

### Formularios

_Los `Formularios` son la parte visual del proyecto, y es donde validamos la manera en la que se gestionan los datos. es aquí donde llamamos las funciones para su aplicación._

<p align="center" width="100%"> <img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/crud.png"/> </p>

_Para darle la funcionalidad al sistema, utilizamos una serie de funciones las cuales son asignadas a los componentes. Estas son las funciones:_

**Llenar información en componentes de DataGridView**
_Se compone de una función que se encarga de llenar los datos de los componentes de un `DataGridView` en este caso ejemplificado como **DataListado** que al dar click en uno de sus datos, llena automaticamente los componente como es este caso, cajas de texto con su información._
>[!IMPORTANT]
>_Este código es crucial para la funcionalidad de `Eliminar` y `Editar` ya que es por esta funcion con la que el sistema mapea el dato que quiere aplicar este cambio en la base de datos._

```vb
    Private Sub DataListado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtid.Text = DataListado.SelectedCells.Item(1).Value
        txtComponenteA.Text = DataListado.SelectedCells.Item(2).Value
        txtComponenteB.Text = DataListado.SelectedCells.Item(3).Value
        txtComponenteC.Text = DataListado.SelectedCells.Item(4).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub
```

**Mostrar y actualizar datos**
_Esta es la función encargada de mostrar los datos en el `DataGridView`._

```vb
    Private Sub Mostrar()
        Try
            Dim func As New ffuncion
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

    Private Sub ocultar_columnas()
        DataListado.Columns(1).Visible = False
    End Sub
```

**Funciones de buscador:**
_Esta función se encarga de filtrar la información por medio de dos componentes, los cuales son un `ComboBox` nombrado como **cboCampo** con las opciones posibles con las que filtrará los datos, estos indicados con el título de las columnas, y la información se clasificará gracias al componente `TextBox` el cual es nombrado como **txtBuscar** el cual es validado mediadno un `If` que nos da la pauta de los datos mapeado con una similitud con lo que el usario esta buscando._

```vb
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

    

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub
```

**Ejemplo de validación en componentes:**
_Este es un ejemplo de la estructura con la que se valida que los componentes dentro del formulario se ingresen vacíos._

```vb
    Private Sub txtComponente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtComponente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese un valor valido, este dato es obligatorio")
        End If
    End Sub
```

**Limpiar componentes**
_Funcion integrada para resetear el contenido de los componentes._


```vb
    Private Sub Limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtComponenteA.Text = ""
        txtComponenteB.Text = ""
        txtComponenteC.Text = ""
    End Sub
```

**Guardar información**
_Esta función, es la encargada de la asignación del proceso de guardar con el evento Click de un botón, con esto validamos el valor del contenido ingresado mediante el usuario a nuestro formulario. Procediendo asi a llamar las `Funciones` y `Métodos` aplicando asi sus funcionalidades en esta etapa del proceso, además de aplicar validadores como el `TryCatch` que dan un mensaje visual al usuario en caso de que ocurra un error. El objetivo principal de esta función es la de guardar datos en la `Base de Datos`_

```vb
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtComponenteA.Text <> "" And txtComponenteB.Text <> "" And txtComponenteC.Text <> "" Then
            Try
                Dim dts As New vMetodo
                Dim func As New ffuncion
                dts.gvariableA = txtComponenteA.Text
                dts.gvariableB = txtComponenteB.Text
                dts.gvariableC = txtComponenteC.Text
  
                If func.insertar(dts) Then
                    MsgBox("Dato registrado correctamente", 0 + 64, "Proceso...")

                    Mostrar()
                    Limpiar()
                Else
                    MsgBox("Dato no registrado, intente de nuevo !!!", 0 + 16, "Error en ingreso...")

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
```

**Editar información:**
_Esta función, es la encargada de edita la información de un dato seleccionado por el usuario mediante el evento Click de un botón. Al igual que la funcion de `Guardar`, validamos el valor del contenido que desea editar y el ingresado para su posterior edición. Procediendo asi a llamar las `Funciones` y `Métodos` aplicando asi sus funcionalidades, además de seguir aplicar validadores como el `TryCatch`. El objetivo principal de esta función es la de editar datos en la `Base de Datos`_

```vb
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim result As Integer
        result = MsgBox("¿Realmente desea editar estos datos?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            If Me.ValidateChildren = True And txtComponenteA.Text <> "" And txtComponenteB.Text <> "" And txtComponenteC.Text <> "" Then
                Try
                    Dim dts As New vMetodo
                    Dim func As New ffuncion
                    dts.gvariableA = txtComponenteA.Text
                    dts.gvariableB = txtComponenteB.Text
                    dts.gvariableC = txtComponenteC.Text

                    If func.editar(dts) Then
                        MsgBox("Datos modificados correctamente", 0 + 64, "Proceso...")

                        Mostrar()
                        Limpiar()
                    Else
                        MsgBox("Datos no modificados, intente de nuevo", 0 + 16, "Error en ingreso...")

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
```

**Eliminar información:**
_Por último el proceso de Eliminar se secciona en 3 funcionalidad, La primera es la encargada de confirmar que el usuario desea eliminar un dato, esto con la funcion de `CheckedChanged`, una vez que el usuario indica que desea eliminar el dato, se habilida la columna de **Eliminar** en el `DataGridView` y al seleccionarla, ya tendiramos la opcion de Eliminar activada la cual consiste en confimar mediante el evento Click de un botón que el usuario desea eliminar el dato en cuestion dando asi inicio al procediendo de llamar las `Funciones` y `Métodos` para aplicar  la funcionalidades de eliminar. El objetivo principal de esta función es la de eliminar datos en la `Base de Datos`_

```vb
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
        result = MsgBox("¿Realmente desea eliminar este dato?", 4 + 32 + 256, "Confirme...")
        If result = 6 Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id").Value)

                        Dim vdb As New vMetodo
                        Dim func As New ffuncion
                        vdb.gid = onekey
                        If func.eliminar(vdb) Then
                            ' Si elimina correctamente
                        Else
                            MsgBox("Dato no eliminado !!!", 0 + 16, "Error en Proceso...")
                        End If
                    End If
                Next
                Call Mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Cancelando eliminación de datos!!!", 0 + 64, "Proceso...")
            Call Mostrar()
        End If
        Call Limpiar()
    End Sub
```

_Con esto cubrimos las partes fundamentales de procesos que suceden en los formularios._

## Instalación

_Para la instalación de nuestro sistema, primero es importante conocer los componentes con los que trabajamos para su construcción._

### Construido con:

_Las herramientas necesarias para el desarrollo, compilación, manejo y gestión de este sistema son:_

* [Visual Studio](https://visualstudio.microsoft.com/es/) - Entorno de desarrollo
* [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) - Administrador de SQL
* [VB](https://learn.microsoft.com/es-es/dotnet/visual-basic/) - Lenguaje de programación
* [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) - Base de datos

### Pasos para la instalación
_Para comenzar, debemos contar con el código del sistema, y para esto, se cuenta con este repositorio de github:_

* [Descargar](https://github.com/ErnestoFlo/CB-SistemaDisk_VB.Net/archive/refs/heads/master.zip)

## Autores

* **Kimberly Castro** - *Desarrolladora* 
* **Hermes Paguaga** - *Desarrollador* 
* **Ernesto Flores** - *Auditor y Documentación* - [ErnestoFlo](https://github.com/ErnestoFlo)


## Expresiones de Gratitud 

* Gracias a Kimberly Castro por permitirme auditar y comprender su código para la realización de esta documentación y poder nutrir nuestros portafolios con este proyecto.