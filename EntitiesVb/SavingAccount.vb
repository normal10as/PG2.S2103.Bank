Public Class SavingAccount
    Inherits Account
    Private _MonthlyInterestRate As Decimal
    Public Property MonthlyInterestRate() As Decimal
        Get
            Return _MonthlyInterestRate
        End Get
        Set(ByVal value As Decimal)
            _MonthlyInterestRate = value
        End Set
    End Property
    Public Sub Capitalizar()
        Depositar(Saldo * MonthlyInterestRate)
    End Sub
End Class
