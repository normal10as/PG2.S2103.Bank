﻿using System;
using EntitiesCs;

namespace TestEntitiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerTest();
            AccountTest();
            SavingAccountTest();
            CheckingAccountTest();
        }

        private static void CheckingAccountTest()
        {
            CheckingAccount account1 = new CheckingAccount(12345,10000,5000);
            //account1.Number = 123; // falla por la regla establecida
            //account1.Number = 12345;
            //account1.OverdraftAmount = 5000;
            //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
            Console.WriteLine("Numero: " + account1.Number);
            Console.WriteLine("Saldo: " + account1.Balance);
            Console.WriteLine("Monto de sobregiro: " + account1.OverdraftAmount);
            account1.Withdraw(3000);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2500);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2000);
            Console.WriteLine("Saldo: " + account1.Balance);
        }
        private static void SavingAccountTest()
        {
            SavingAccount account1 = new SavingAccount(12345,10000,0.10m);
            account1.Number = 123; // falla por la regla establecida
            account1.Number = 12345;
            account1.MonthlyInterestRate = 0.1m;
            //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
            Console.WriteLine("Numero: " + account1.Number);
            Console.WriteLine("Saldo: " + account1.Balance);
            Console.WriteLine("Tasa de interes mensual: " + account1.MonthlyInterestRate);
            account1.Withdraw(3000);
            account1.DepositMonthlyInterest();
            Console.WriteLine("Saldo capitalizado: " + account1.Balance);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2500);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2000);
            Console.WriteLine("Saldo: " + account1.Balance);
        }        
        private static void AccountTest()
        {
            Account account1 = new Account();
            account1.Number = 123; // falla por la regla establecida
            account1.Number = 12345;
            //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
            Console.WriteLine("Numero: " + account1.Number);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Withdraw(3000);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2500);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.Deposit(2000);
            Console.WriteLine("Saldo: " + account1.Balance);
            Account account2 = new Account(23456, 10000);
            Console.WriteLine("Numero: " + account2.Number);
            Console.WriteLine("Saldo: " + account2.Balance);
        }
        private static void CustomerTest()
        {
            Customer customer1; // instanciación
            customer1 = new Customer();   // inicialización
            customer1.Name = "Pepe";
            customer1.Id = 12345678;
            customer1.BirthDay = new DateTime(2000, 08, 10);
            ShowCustomer(customer1);
            Customer customer2; // instanciación
            customer2 = new Customer("pepo",98765432);   // inicialización
            ShowCustomer(customer2);
            Customer customer3; // instanciación
            customer3 = new Customer("papo", 98765432, new DateTime(1990,5,23));   // inicialización
            ShowCustomer(customer3);
            Customer customer4; // instanciación
            customer4 = new Customer {Name = "pipo"};   // inicialización
            ShowCustomer(customer4);
            Customer customer5; // instanciación
            customer5 = new Customer {
                Name ="pepa", 
                BirthDay = new DateTime(1990, 5, 23)
            };   // inicialización
            ShowCustomer(customer5);
        }
        private static void ShowCustomer(Customer customer)
        {
            Console.WriteLine("Nombre: " + customer.Name);
            Console.WriteLine("Documento: " + customer.Id);
            Console.WriteLine("Fecha de nacimiento: " + customer.BirthDay);
        }
    }
}
