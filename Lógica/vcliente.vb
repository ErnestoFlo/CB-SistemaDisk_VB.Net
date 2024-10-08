Public Class vcliente
    Dim idcliente As Integer
    Dim nombres, apellidos, dni, direccion, telefono, movil, correo, fechanac, departamento, pais, ciudad, sexo, nomcont, telcont As String
    ' Los metodos Setter permiten guardar datos en cualquiera de los campos
    ' los metodos Getter leen los datos que poseen los campos
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property
    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
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
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gmovil
        Get
            Return movil
        End Get
        Set(ByVal value)
            movil = value
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
    Public Property gfechanac
        Get
            Return fechanac
        End Get
        Set(ByVal value)
            fechanac = value
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
    Public Property gciudad
        Get
            Return ciudad
        End Get
        Set(ByVal value)
            ciudad = value
        End Set
    End Property
    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(ByVal value)
            sexo = value
        End Set
    End Property
    Public Property gnomcont
        Get
            Return nomcont
        End Get
        Set(ByVal value)
            nomcont = value
        End Set
    End Property
    Public Property gtelcont
        Get
            Return telcont
        End Get
        Set(ByVal value)
            telcont = value
        End Set
    End Property

    ' Ahora vamos a crear los constructores. Ellos son los que reciben todos los datos y se comunican con la carpeta datos.
    ' Es aquí donde se realizan las acciones de agregar, modificar y eliminar.
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String, ByVal movil As String, ByVal correo As String, ByVal fechanac As Date, ByVal departamento As String, ByVal pais As String, ByVal ciudad As String, ByVal sexo As String, ByVal nomcont As String, ByVal telcont As String)
        gidcliente = idcliente
        gnombres = nombres
        gapellidos = apellidos
        gdni = dni
        gdireccion = direccion
        gtelefono = telefono
        gmovil = movil
        gcorreo = correo
        gfechanac = fechanac
        gdepartamento = departamento
        gpais = pais
        gciudad = ciudad
        gsexo = sexo
        gnomcont = nomcont
        gtelcont = telcont
    End Sub
End Class
