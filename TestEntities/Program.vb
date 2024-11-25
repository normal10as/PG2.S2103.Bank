Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        'CustomerTest()
        'SavingAccountTest()
        'AccountTest()
        'CheckingAccountTest()
    End Sub
    Private Sub CustomerTest()
        Dim customer1 As Customer    ' Instanciación
        customer1 = New Customer()   ' Inicializacion
        customer1.Name = "Pepe"
        customer1.Id = 12345678
        customer1.BirthDay = #2000-08-10#
        ShowCustomer(customer1)
        Dim customer2 As Customer    ' Instanciación
        customer2 = New Customer("pepo", 98765432)   ' Inicializacion
        ShowCustomer(customer2)
        Dim customer3 As Customer    ' Instanciación
        customer3 = New Customer("papo", 98765432, #1990-5-23#)   ' Inicializacion
        ShowCustomer(customer3)
        Dim customer4 As Customer    ' Instanciación
        customer4 = New Customer With {.Name = "pipo"}    ' Inicializacion
        ShowCustomer(customer4)
        Dim customer5 As Customer    ' Instanciación
        customer5 = New Customer With {
            .Name = "pepa",
            .BirthDay = #1990-5-23#}   ' Inicializacion
        ShowCustomer(customer5)
    End Sub
    Private Sub ShowCustomer(customer As Customer)
        Console.WriteLine("Nombre: " & customer.Name)
        Console.WriteLine("Documento: " & customer.Id)
        Console.WriteLine("Fecha de nacimiento: " & customer.BirthDay)
    End Sub

    Private Sub CheckingAccountTest()
        Dim customer2 As Customer    ' Instanciación
        customer2 = New Customer("pepo", 98765432)   ' Inicializacion
        Dim account1 As CheckingAccount = New CheckingAccount()
        Console.WriteLine(account1)
        account1.Number = 123 ' falla la asignación
        account1.Number = 12345
        account1.OverdraftAmount = 5000
        account1.Customer = customer2
        Console.WriteLine(account1)
        'account1.Saldo = 1000 no es posible porque es solo lectura
        Console.WriteLine("Número: " & account1.Number)
        Console.WriteLine("Customer: " & account1.Customer.ToString())
        Dim customerX = account1.Customer
        Console.WriteLine("Customer: " & customerX.ToString())
        customerX.Name = "Pepon"
        Console.WriteLine("Customer: " & customer2.ToString())
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Deposit(3000)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(2500)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(2000)
        Console.WriteLine("Saldo: " & account1.Balance)
    End Sub
    Private Sub TestCurrentAccount()
        Dim account1 As CheckingAccount = New CheckingAccount()
        Console.WriteLine(account1)
        account1.Number = 123 ' falla la asignación
        account1.Number = 12345
        account1.OverdraftAmount = 5000
        Console.WriteLine(account1)
        'account1.Saldo = 1000 no es posible porque es solo lectura
        Console.WriteLine("Número: " & account1.Number)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Deposit(3000)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(2500)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(2000)
        Console.WriteLine("Saldo: " & account1.Balance)
    End Sub
    Private Sub SavingAccountTest()
        Dim account1 As SavingAccount = New SavingAccount(12345, 10000, 0.1)

        Try
            account1.Number = 123 ' falla la asignación
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        account1.Number = 12345
        account1.MonthlyInterestRate = 0.1
        'account1.Saldo = 1000 no es posible porque es solo lectura
        Console.WriteLine("Número: " & account1.Number)
        Console.WriteLine("Saldo: " & account1.Balance)
        Console.WriteLine("Tasa de interes mensual: " & account1.MonthlyInterestRate)
        account1.Deposit(3000)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.DepositMonthlyInterest()
        Console.WriteLine("Saldo capitalizado: " & account1.Balance)
        account1.Withdraw(2500)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(2000)
        Console.WriteLine("Saldo: " & account1.Balance)

        Try
            account1.Withdraw(13000)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Saldo: " & account1.Balance)
    End Sub
    'Private Sub AccountTest()
    '    Dim account1 As Account = New Account()
    '    Console.WriteLine(account1)
    '    account1.Number = 123 ' falla la asignación
    '    account1.Number = 12345
    '    'account1.Saldo = 1000 no es posible porque es solo lectura
    '    Console.WriteLine(account1.ToString())
    '    Console.WriteLine("Número: " & account1.Number)
    '    Console.WriteLine("Saldo: " & account1.Balance)
    '    account1.Deposit(3000)
    '    Console.WriteLine("Saldo: " & account1.Balance)
    '    account1.Withdraw(2500)
    '    Console.WriteLine("Saldo: " & account1.Balance)
    '    account1.Withdraw(2000)
    '    Console.WriteLine("Saldo: " & account1.Balance)
    'End Sub
End Module