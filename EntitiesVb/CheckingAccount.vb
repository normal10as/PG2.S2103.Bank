Public Class CheckingAccount
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
    Public Overrides Sub Withdraw(value As Decimal)
        If isBalanceAvailable(value) Then
            _balance -= value
        End If
    End Sub
    Private Function isBalanceAvailable(amount As Decimal) As Boolean
        Return Balance >= amount - OverdraftAmount
    End Function
End Class
