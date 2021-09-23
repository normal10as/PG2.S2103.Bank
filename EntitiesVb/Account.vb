Public Class Account
    Private _number As Integer
    Protected _balance As Decimal
    Public Sub New()
        _Enabled = True
    End Sub
    Public Sub New(number As Integer, balance As Decimal)
        MyBase.New()
        Me.Number = number
        _balance = balance
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
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
    Public Property Enabled As Boolean
    Public Sub Deposit(value As Decimal)
        _balance += value
    End Sub

    Public Overridable Sub Withdraw(value As Decimal)
        If isBalanceAvailable(value) Then
            _balance -= value
        End If
    End Sub
    Private Function isBalanceAvailable(amonto As Decimal) As Boolean
        Return Balance >= amonto
    End Function
End Class