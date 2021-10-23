using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class Account
    {
        private int number;
        protected decimal balance;  // permite acceder a este campo en las subclases
        public Account()
        {
            Enabled = true;
        }
        public Account(int number, decimal balance) : this()    // encadena  el constructor sin parámetros
        {
            Number = number;
            this.balance = balance;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 9999)   // regla para aceptar el valor
                    number = value;
            }
        }
        public decimal Balance { get => balance; }
        public bool Enabled { get; set; }
        public void Withdraw(decimal value) //Extracción
        {
            balance += value;
        }
        public virtual void Deposit(decimal value)  // metodo virtual permite ser sobreescrito
        {
            if (isBalanceAvailable(value)) // validación si hay saldo
                balance -= value;
        }
        private bool isBalanceAvailable(decimal amount) // saldo no puede ser negativo
        {
            return Balance >= amount;
        }
    }
}