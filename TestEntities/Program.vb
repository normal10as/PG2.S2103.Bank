Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        'TestCustomer()
        TestAccount()
    End Sub

    Private Sub TestCustomer()
        Dim customer As Customer = New Customer()
        customer.Name = "Pepe"
        customer.Dni = 12345678
        customer.BirthDate = #2000-08-10#
        Console.WriteLine("Nombre: " & customer.Name)
        Console.WriteLine("Documento: " & customer.Dni)
        Console.WriteLine("Fecha de nacimiento: " & customer.BirthDate)
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
