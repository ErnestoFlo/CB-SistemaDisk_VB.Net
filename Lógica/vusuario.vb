Public Class vusuario

    Dim idUsuario As Integer
    Dim nombreUsuario, apellidoUsuario, numidentidad, direccion, telefono, correo, login, password, acceso As String

    Public Property gidUsuario
        Get
            Return idUsuario
        End Get
        Set(ByVal value)
            idUsuario = value
        End Set
    End Property

    Public Property gnombreUsuario
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value)
            nombreUsuario = value
        End Set
    End Property

    Public Property gapellidoUsuario
        Get
            Return apellidoUsuario
        End Get
        Set(ByVal value)
            apellidoUsuario = value
        End Set
    End Property

    Public Property gnumidentidad
        Get
            Return numidentidad
        End Get
        Set(ByVal value)
            numidentidad = value
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

    Public Property gcorreo
        Get
            Return correo
        End Get
        Set(ByVal value)
            correo = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(ByVal value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(ByVal value)
            acceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal nombreUsuario As String, ByVal apellidoUsuario As String, ByVal numidentidad As String, ByVal direccion As String, ByVal telefono As String, ByVal correo As String, ByVal login As String, ByVal password As String, ByVal acceso As String)
        gidUsuario = idUsuario
        gnombreUsuario = nombreUsuario
        gapellidoUsuario = apellidoUsuario
        gnumidentidad = numidentidad
        gdireccion = direccion
        gtelefono = telefono
        gcorreo = correo
        glogin = login
        gpassword = password
        gacceso = acceso
    End Sub

End Class
