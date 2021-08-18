Public Class Customer
    Public Sub New()
        Nombre = ""
        Documento = 0
        FechaNacimiento = Nothing
    End Sub

    ' Campo, este forma parte de la implementación privada
    Private _nombre As String
    ' Propiedad, forma parte de la interfaz pública
    Public Property Nombre As String
        ' Metodo Getter es para obtener el valor
        Get
            Return _nombre
        End Get
        ' Método Setter es para asignar el valor
        Set(value As String)
            ' aqui se pueden hacer validaciones
            _nombre = value.ToUpper()
        End Set
    End Property

    Private _documento As Integer
    Public Property Documento As Integer
        Get
            Return _documento
        End Get
        Set(value As Integer)
            _documento = value
        End Set
    End Property

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
End Class
