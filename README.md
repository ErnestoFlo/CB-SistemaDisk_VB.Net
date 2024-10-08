# CRUD VB.Net - Sistema de inventario de discos

_Sistema de final de curso. Realizado para el manejo e inventariado de discos_

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/Menu%20pricipal.png" /></p>

## Soluciones

_Este programa busca solucionar los problemas de gestion de inventario de una tienda de discos. Por lo que con nuestro sistema, buscamos gestionar mediante CRUDs una serie de modulos que facilitan al cliente a manejar de manera efectiva sus datos. Estos modulos son:_

* Clientes
* Categorias
* Productos 
* Proveedores
* Usuarios

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/modulos.png"/></p>


## Metodología de trabajo

_Para la elaboracion del proyecto, se planteo manejar el paradigma de programación de `POO` o `Programación Orientada a Objetos`, esto con el fin de buscar un desarrollo basada en objetos que no permitan el modelaje de `funciones`, `clases`, `métodos` y `formularios` con las cuales construimos la funcionalidad del sistema._

<p align="center" width="100%"><img src="https://raw.githubusercontent.com/ErnestoFlo/CB-SistemaDisk_VB.Net/refs/heads/master/Documentacion/estructura.png" /></p>

### Funciones

_Las **funciones** es el código que nos permite comunicarnos mediante la conexión hacia la `base de datos`, brindando acceso a cada uno de los formularios con los `procedimientos almacenados` creados para dar la funcionalidad de CRUD en cada pantalla del sistema._

_La estructura básica de las **Funciones** para el crud se trabajaron de la siguiente manera:_

**Conexión a BD:**
```
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
```
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

```
Dim cmd As New SqlCommand
```

**Mostrar:**

```
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
```
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

```
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
```
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

## Otras secciones para el README

_Estas son otras secciones que se pueden incluir par adetallar el desarrollo y aplicativo del sistema en el documento_

### Ejecución de pruebas

_Explica como aplicar y el por que de las pruebas del sistema_

### Pruebas end-to-end (E2E)

_Esta es la esquematización del flujo que lleva el proyecto, dinde se explica el por qué de su funcionamiento. Además de brindar un simulacro del comportamiento completo del sistema, de inicio a fin_

### Estilo de codificación

_Es una explicación	de la nomenclatura y tipo de orden que se llevo durante el desarrollo del proyecto_

Ejemplo de nomenclatura de modelos:
```
class ejemplo_model (models.Model):
    id_ejemplo	= models.AutoField(PrimaryKey = True)
    nombre = models.CharField(max_length=30)
    apellido = models.CharField(max_length=30)
```

## Despliegue

_Son las configuraciones necesarias para poner en producción el proyecto_

## Construido con:

_Se mencionan las herramientas con las que se desarrollo la app. Nota: Para poner una lista en el rreadme debemos usar un **asterisco** y para agregar un link usamos **Corchetes y Paréntesis**_

* [Django](https://www.djangoproject.com/) - Framework utilizado
* [Python](https://www.python.org/) - Manejador de dependencias

## Otras campos a mencionar

* Contribuyendo: Algunas directrices para leer detalles del codigo
* Wiki: Más informacion de como utilizar nuestro proyecto
* Versionado: Metodologia que se emplea para dar los tags de actualizacion de versiones del proyecto

## Autores

_Aqui se mencionan a todas las personas que ayudaron y contribuyeron en el desarrollo del sistema_

* **Ernesto Flores** - *Desarrollador Frontend* - [ErnestoFlo](https://github.com/ErnestoFlo)
* **Fulanito Detal** - *Documentación* - [fulanitodetal](#fulanito-de-tal)

## Licencia 

Este proyecto está bajo la licencia (Mi licencia) - Mira el archivo [LICENSE.md](LICENSE.md) para detalles

## Expresiones de Gratitud 

* Comentarios sobre este proyecto 
* Menciones y agradecimeintos a miembros del equipo. 
* Dar las gracias públicamente.
* etc.