Public Class Account
    Private _number As Integer
    Private _saldo As Decimal
    Public Sub New()
    End Sub
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            If value > 9999 Then
                _number = value
            End If
        End Set
    End Property
    Public ReadOnly Property Saldo As Decimal
        Get
            Return _saldo
        End Get
    End Property

    Public Sub Depositar(value As Decimal)
        _saldo += value
    End Sub

    Public Sub Extraer(value As Decimal)
        If isSaldoSuficiente(value) Then
            _saldo -= value
        End If
    End Sub
    Private Function isSaldoSuficiente(monto As Decimal) As Boolean
        Return Saldo >= monto
    End Function
End Class
