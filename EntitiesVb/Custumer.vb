Public Class Custumer
    Public Sub New()
        Nombre = ""
    End Sub
    Private _nombre As String
    Private _documento As Integer
    Private _fechaNacimiento As DateTime

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            ' aqui se pueden hacer validaciones
            _nombre = value.ToUpper()
        End Set
    End Property

End Class
