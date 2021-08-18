Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        Dim customer As Customer
        customer = New Customer()
        customer.Name = "Pepe"
        customer.Dni = 12345678
        customer.BirthDate = #2000-08-10#
        Console.WriteLine("Nombre: " & customer.Name)
        Console.WriteLine("Documento: " & customer.Dni)
        Console.WriteLine("Fecha de nacimiento: " & customer.BirthDate)
    End Sub
End Module
