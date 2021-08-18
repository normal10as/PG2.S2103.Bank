using System;
using EntitiesCs;

namespace TestEntitiesCs
{
    class Program
    {
        static void Main(string[] args)
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
