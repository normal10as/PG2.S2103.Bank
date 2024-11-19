﻿Public MustInherit Class Account
    Private _number As Integer
    Protected _balance As Decimal
    Public Sub New()
        _Enabled = True
    End Sub
    Public Sub New(number As Integer, balance As Decimal)
        MyBase.New()
        Me.Number = number
        _balance = balance
    End Sub
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            If value < 10000 Then
                Throw New ArgumentException("Numero de cuenta debe ser 10000 o superior")
            End If
            _number = value
        End Set
    End Property
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
    Private _customer As Customer
    Public Property Customer As Customer
        Get
            Return _customer
        End Get
        Set(value As Customer)
            _customer = value
        End Set
    End Property
    Public Property Enabled As Boolean
    Public Sub Deposit(value As Decimal)
        _balance += value
    End Sub

    Public MustOverride Sub Withdraw(value As Decimal)

    Public Overrides Function ToString() As String
        Return "Account " & Number
    End Function
End Class
