Public Class vproducto

    Dim idDisco, discoid, stock As Integer
    Dim nombre_disco, descripcion, capacidad, nom_proveedor, marca As String
    Dim precio_venta, precio_compra As Double
    Dim imagen As Byte()
    ' Los metodos Setter permiten guardar datos en cualquiera de los campos
    ' los metodos Getter leen los datos que poseen los campos
    Public Property gidDisco
        Get
            Return idDisco
        End Get
        Set(ByVal value)
            idDisco = value
        End Set
    End Property
    Public Property gdiscoid
        Get
            Return discoid
        End Get
        Set(ByVal value)
            discoid = value
        End Set
    End Property

    Public Property gnombre_disco
        Get
            Return nombre_disco
        End Get
        Set(ByVal value)
            nombre_disco = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Property gcapacidad
        Get
            Return capacidad
        End Get
        Set(ByVal value)
            capacidad = value
        End Set
    End Property

    Public Property gnom_proveedor
        Get
            Return nom_proveedor
        End Get
        Set(ByVal value)
            nom_proveedor = value
        End Set
    End Property

    Public Property gprecio_venta
        Get
            Return precio_venta
        End Get
        Set(ByVal value)
            precio_venta = value
        End Set
    End Property

    Public Property gprecio_compra
        Get
            Return precio_compra
        End Get
        Set(ByVal value)
            precio_compra = value
        End Set
    End Property

    Public Property gstock
        Get
            Return stock
        End Get
        Set(ByVal value)
            stock = value
        End Set
    End Property

    Public Property gmarca
        Get
            Return marca
        End Get
        Set(ByVal value)
            marca = value
        End Set
    End Property

    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property

    ' Ahora vamos a crear los constructores. Ellos son los que reciben todos los datos y se comunican con la carpeta datos.
    ' Es aquí donde se realizan las acciones de agregar, modificar y eliminar.
    Public Sub New()

    End Sub

    Public Sub New(ByVal idDisco As Integer, ByVal discoid As Integer, ByVal nombre_disco As String, ByVal descripcion As String, ByVal capacidad As String, ByVal nom_proveedor As String, ByVal precio_venta As Double, ByVal precio_compra As Double, ByVal stock As Integer, ByVal marca As String, ByVal imagen As Byte)
        gidDisco = idDisco
        gdiscoid = discoid
        gnombre_disco = nombre_disco
        gdescripcion = descripcion
        gcapacidad = capacidad
        gnom_proveedor = nom_proveedor
        gprecio_venta = precio_venta
        gprecio_compra = precio_compra
        gstock = stock
        gmarca = marca
        gimagen = imagen
    End Sub

End Class
