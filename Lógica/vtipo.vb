Public Class vtipo
    Dim discoid As Integer
    Dim tipoDisco As String

    Public Property gdiscoid
        Get
            Return discoid
        End Get
        Set(ByVal value)
            discoid = value
        End Set
    End Property

    Public Property gtipoDisco
        Get
            Return tipoDisco
        End Get
        Set(ByVal value)
            tipoDisco = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDisco As Integer, ByVal tipoDisco As String)
        gdiscoid = idDisco
        gtipoDisco = tipoDisco
    End Sub
End Class
