﻿using System;
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
        // agerga un cliente al banko
        public void AddCliente(Customer customer)
        {
            customers.Add(customer);
        }
        // devuelve todos los clientes
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        // devuelve todos los clientes que coincida el nombre
        public List<Customer> GetCustomers(string name)
        {
            return customers.FindAll(c => c.Name.Contains( name));
        }
        // devuelve el ciente segun su id
        public Customer GetCustomer(int id)
        {
            return customers.Find(c => c.Id == id);
        }
        // elimina un cliente
        public void RemoveCliente(Customer customer)
        {
            customers.Remove(customer);
        }
        // informa el numero de clientes
        public int AccountCounter
        {
            get => customers.Count;
        }
    }
}
