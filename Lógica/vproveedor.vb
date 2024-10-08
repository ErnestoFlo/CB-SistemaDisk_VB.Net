Public Class vproveedor
    Dim idProveedor, idDisco As Integer
    Dim nom_proveedor, nom_contacto, cargo_contacto, direccion, ciudad, departamento, pais, telefono, correo, terminos_pago As String
    Public Property gidProveedor
        Get
            Return idProveedor
        End Get
        Set(ByVal value)
            idProveedor = value
        End Set
    End Property
    Public Property gidDisco
        Get
            Return idDisco
        End Get
        Set(ByVal value)
            idDisco = value
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
    Public Property gnom_contacto
        Get
            Return nom_contacto
        End Get
        Set(ByVal value)
            nom_contacto = value
        End Set
    End Property
    Public Property gcargo_contacto
        Get
            Return cargo_contacto
        End Get
        Set(ByVal value)
            cargo_contacto = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property
    Public Property gciudad
        Get
            Return ciudad
        End Get
        Set(ByVal value)
            ciudad = value
        End Set
    End Property
    Public Property gdepartamento
        Get
            Return departamento
        End Get
        Set(ByVal value)
            departamento = value
        End Set
    End Property
    Public Property gpais
        Get
            Return pais
        End Get
        Set(ByVal value)
            pais = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(ByVal value)
            correo = value
        End Set
    End Property
    Public Property gterminos_pago
        Get
            Return terminos_pago
        End Get
        Set(ByVal value)
            terminos_pago = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal idProveedor As Integer, ByVal idDisco As Integer, ByVal nom_proveedor As String, ByVal nom_contacto As String, ByVal cargo_contacto As String, ByVal direccion As String, ByVal ciudad As String, ByVal departamento As String, ByVal pais As String, ByVal telefono As String, ByVal correo As String, ByVal terminos_pago As String)
        gidProveedor = idProveedor
        gidDisco = idDisco
        gnom_proveedor = nom_proveedor
        gnom_contacto = nom_contacto
        gcargo_contacto = cargo_contacto
        gdireccion = direccion
        gciudad = ciudad
        gdepartamento = departamento
        gpais = pais
        gtelefono = telefono
        gcorreo = correo
        gterminos_pago = terminos_pago
    End Sub
End Class
