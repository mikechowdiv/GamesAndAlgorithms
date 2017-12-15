using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAcct
{
    class SavingsAccount
    {
        private static double annualInterestRate = 0.04;
        private double savingsBalance;

        public SavingsAccount(double startingbalance)
        {
            SavingsBalance = startingbalance;
        }

        public double SavingsBalance
        {
            get { return savingsBalance; }
            set { savingsBalance = value + CalculateMonthlyInterest(value); }
        }

        public double CalculateMonthlyInterest(double value)
        {
            return value * (annualInterestRate / 12);
        }

        public static void ModifyInterestRate(double rate)
        {
            annualInterestRate = rate / 100;
        }

        public override string ToString()
        {
            return string.Format("Total on Savings Account is {0:C}", SavingsBalance);
        }
    }
}
