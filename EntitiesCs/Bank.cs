using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class Bank
    {
        private List<Customer> customers;

        public Bank()
        {
            customers = new List<Customer>();
        }

        public void AddCliente(Customer customer)
        {
            customers.Add(customer);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
