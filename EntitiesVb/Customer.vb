Public Class Customer
    Public Sub New()
        Me.Name = ""
        BirthDay = Nothing
    End Sub
    Public Sub New(Name As String, Dni As Integer)
        Me.Name = Name
        Me.Dni = Dni
        BirthDay = Nothing
    End Sub
    Public Sub New(Name As String, Dni As Integer, BirthDay As Date)
        Me.Name = Name
        Me.Dni = Dni
        Me.BirthDay = BirthDay
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

    Private _birthDay As Date
    Public Property BirthDay As Date
        Get
            Return _birthDay
        End Get
        Set(value As Date)
            _birthDay = value
        End Set
    End Property
End Class
