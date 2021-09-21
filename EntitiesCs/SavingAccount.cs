﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
    public class SavingAccount : Account
    {
        public SavingAccount(int number, decimal saldo, decimal monthlyInterestRate) : base(number, saldo)
        {
            MonthlyInterestRate = monthlyInterestRate;
        }
        public decimal MonthlyInterestRate { get; set; }
        public void Capitalizar()
        {
            Depositar(Saldo * MonthlyInterestRate);
        }
    }
}