Public Class Customer
    Public Sub New()
        Name = ""
        Dni = 0
        BirthDate = Nothing
    End Sub

    ' Campo, este forma parte de la implementación privada
    Private _name As String
    ' Propiedad, forma parte de la interfaz pública
    Public Property Name As String
        ' Metodo Getter es para obtener el valor
        Get
            Return _name
        End Get
        ' Método Setter es para asignar el valor
        Set(value As String)
            ' aqui se pueden hacer validaciones
            _name = value.ToUpper()
        End Set
    End Property

    Private _dni As Integer
    Public Property Dni As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property

    Private _birthDate As Date
    Public Property BirthDate As Date
        Get
            Return _birthDate
        End Get
        Set(value As Date)
            _birthDate = value
        End Set
    End Property
End Class
