using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class Account
    {
        private int number;
        private decimal saldo;
        public Account()
        {
            Enabled = true;
        }
        public Account(int number, decimal saldo) : this()
        {
            Number = number;
            this.saldo = saldo;
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 9999)
                    number = value;
            }
        }
        public decimal Saldo { get => saldo; }

        public bool Enabled { get; set; }
        public void Depositar(decimal value)
        {
            saldo += value;
        }
        public void Extraer(decimal value)
        {
            if (isSaldoSuficiente(value)) // validación
                saldo -= value;
        }
        private bool isSaldoSuficiente(decimal Monto)
        {
            return Saldo >= Monto;
        }
    }
}
