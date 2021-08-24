using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class Account
    {
        private int number;
        private decimal saldo;
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
