Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        Dim customer As Customer
        customer = New Customer()
        customer.Nombre = "Pepe"
        customer.Documento = 12345678
        customer.FechaNacimiento = #2000-08-10#
        Console.WriteLine("Nombre: " & customer.Nombre)
        Console.WriteLine("Documento: " & customer.Documento)
        Console.WriteLine("Fecha de nacimiento: " & customer.FechaNacimiento)
    End Sub
End Module
