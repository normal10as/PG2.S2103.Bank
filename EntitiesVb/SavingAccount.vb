Public Class SavingAccount
    Inherits Account    ' esta clase dispone de todos los miembre de Account

    Private _MonthlyInterestRate As Decimal
    Public Sub New(number As Integer, saldo As Decimal, monthlyInterestRate As Decimal)
        MyBase.New(number, saldo)   ' constructor no se hereda, si no se especifica se invoca New()
        _MonthlyInterestRate = monthlyInterestRate
    End Sub
    Public Property MonthlyInterestRate() As Decimal
        Get
            Return _MonthlyInterestRate
        End Get
        Set(ByVal value As Decimal)
            _MonthlyInterestRate = value
        End Set
    End Property
    Public Sub Capitalizar()
        Depositar(Saldo * MonthlyInterestRate)  'Metodo heredado, reuso la funcionalidad con fin que coincide con el requerimiento
    End Sub
End Class