Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        'TestCustomer()
        'TestAccount()
        TestSavingAccount()
    End Sub
    Private Sub TestCustomer()
        Dim customer1 As Customer    ' Instanciación
        customer1 = New Customer()   ' Inicializacion
        customer1.Name = "Pepe"
        customer1.Dni = 12345678
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
        Console.WriteLine("Documento: " & customer.Dni)
        Console.WriteLine("Fecha de nacimiento: " & customer.BirthDay)
    End Sub
    Private Sub TestSavingAccount()
        Dim account1 As SavingAccount = New SavingAccount(12345, 10000, 0.1)
        account1.Number = 123 ' falla la asignación
        account1.Number = 12345
        account1.MonthlyInterestRate = 0.1
        'account1.Saldo = 1000 no es posible porque es solo lectura
        Console.WriteLine("Número: " & account1.Number)
        Console.WriteLine("Saldo: " & account1.Saldo)
        Console.WriteLine("Tasa de interes mensual: " & account1.MonthlyInterestRate)
        account1.Depositar(3000)
        Console.WriteLine("Saldo: " & account1.Saldo)
        account1.Capitalizar()
        Console.WriteLine("Saldo capitalizado: " & account1.Saldo)
        account1.Extraer(2500)
        Console.WriteLine("Saldo: " & account1.Saldo)
        account1.Extraer(2000)
        Console.WriteLine("Saldo: " & account1.Saldo)
    End Sub
    Private Sub TestAccount()
        Dim account1 As Account = New Account()
        account1.Number = 123 ' falla la asignación
        account1.Number = 12345
        'account1.Saldo = 1000 no es posible porque es solo lectura
        Console.WriteLine("Número: " & account1.Number)
        Console.WriteLine("Saldo: " & account1.Saldo)
        account1.Depositar(3000)
        Console.WriteLine("Saldo: " & account1.Saldo)
        account1.Extraer(2500)
        Console.WriteLine("Saldo: " & account1.Saldo)
        account1.Extraer(2000)
        Console.WriteLine("Saldo: " & account1.Saldo)
    End Sub
End Module