Public Class Account
    Private _number As Integer
    Protected _saldo As Decimal
    Public Sub New()
        _Enabled = True
    End Sub
    Public Sub New(number As Integer, saldo As Decimal)
        MyBase.New()
        Me.Number = number
        _saldo = saldo
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
    Public Property Enabled As Boolean
    Public Sub Depositar(value As Decimal)
        _saldo += value
    End Sub

    Public Overridable Sub Extraer(value As Decimal)
        If isSaldoSuficiente(value) Then
            _saldo -= value
        End If
    End Sub
    Private Function isSaldoSuficiente(monto As Decimal) As Boolean
        Return Saldo >= monto
    End Function
    Public Overrides Function ToString() As String
        Return "Account " & Number
    End Function
End Class
