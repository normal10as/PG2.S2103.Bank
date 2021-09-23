Public Class CurrentAccount
    Inherits Account
    Private _OverdraftAmount As String
    Public Property OverdraftAmount() As String
        Get
            Return _OverdraftAmount
        End Get
        Set(ByVal value As String)
            _OverdraftAmount = value
        End Set
    End Property
    Public Overrides Sub Extraer(value As Decimal)
        If isSaldoSuficiente(value) Then
            _saldo -= value
        End If
    End Sub
    Private Function isSaldoSuficiente(monto As Decimal) As Boolean
        Return Saldo >= monto - OverdraftAmount
    End Function
End Class
