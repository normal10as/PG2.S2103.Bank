Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        Dim custumer As Custumer
        custumer = New Custumer()
        custumer.Nombre = "Pepe"
        custumer.Documento = 12345678
        custumer.FechaNacimiento = #2000-08-10#
        Console.WriteLine("Nombre: " & custumer.Nombre)
        Console.WriteLine("Documento: " & custumer.Documento)
        Console.WriteLine("Fecha de nacimiento: " & custumer.FechaNacimiento)
    End Sub
End Module
