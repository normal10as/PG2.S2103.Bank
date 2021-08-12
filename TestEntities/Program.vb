Imports System
Imports EntitiesVb
Module Program
    Sub Main(args As String())
        Dim custumer As Custumer
        custumer = New Custumer()
        custumer.Nombre = "Pepe"
        Console.WriteLine(custumer.Nombre)
    End Sub
End Module
