using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataHexagonal
{
    public class LoanCustomer
    {
        public int Salary { get;  }
        public int Balance { get; }
        
        public LoanCustomer(int salary, int balance)
        {
            this.Salary = salary;
            this.Balance = balance;
        }

        public bool CheckLoan(int creditAmount, int numberOfMensuality)
        {
            return IsBalanceHigherThanTenPercent(creditAmount) && IsSalaryHigherThreeTimesToMonthlyPayement(creditAmount, numberOfMensuality);
        }

        private bool IsBalanceHigherThanTenPercent(int creditAmount)
        {
            return Balance > creditAmount * 0.1;
        }

        private bool IsSalaryHigherThreeTimesToMonthlyPayement(int creditAmount, int numberOfMensuality)
        {
            return Salary > ((creditAmount / numberOfMensuality)*3);
        }
    }
}
