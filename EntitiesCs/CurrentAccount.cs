using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int number, decimal saldo, decimal overdraftAmount) : base(number, saldo)
        {
            OverdraftAmount = overdraftAmount;
        }
        public decimal OverdraftAmount { get; set; }
        public override void Extraer(decimal value)
        {
            if (isSaldoSuficiente(value)) // validación
                saldo -= value;
        }
        private bool isSaldoSuficiente(decimal Monto)
        {
            return Saldo >= Monto - OverdraftAmount;
        }
    }
}
