using System;
using EntitiesCs;

namespace TestEntitiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerTest();
            AccountTest();
        }

        private static void AccountTest()
        {
            Account account1 = new Account();
            account1.Number = 123; // falla por la regla establecida
            account1.Number = 12345;
            //account1.Saldo = 1000; No se puede asignar porque es de solo lectura
            Console.WriteLine("Numero: " + account1.Number);
            Console.WriteLine("Saldo: " + account1.Saldo);
            account1.Depositar(3000);
            Console.WriteLine("Saldo: " + account1.Saldo);
            account1.Extraer(2500);
            Console.WriteLine("Saldo: " + account1.Saldo);
            account1.Extraer(2000);
            Console.WriteLine("Saldo: " + account1.Saldo);
        }
        private static void CustomerTest()
        {
            Customer customer = new Customer();
            customer.Name = "Pepe";
            customer.Dni = 12345678;
            customer.BirthDate = new DateTime(2000, 08, 10);
            Console.WriteLine("Nombre: " + customer.Name);
            Console.WriteLine("Documento: " + customer.Dni);
            Console.WriteLine("Fecha de nacimiento: " + customer.BirthDate);
        }
    }
}
