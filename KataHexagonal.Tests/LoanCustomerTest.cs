using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataHexagonal;

namespace KataHexagonal.Tests
{
    public class LoanCustomerTest
    {
        [Test]
        public void ShouldRefuseLoanWhenTheBalanceIsLessThan10PerscentOfTheCredit()
        {
            int salary = 3000;
            int balance = 500;
            var loanCustomer = new LoanCustomer(salary, balance);

            Assert.IsFalse(loanCustomer.CheckLoan(100000,10));
        }

        [Test]
        public void ShouldRefuseLoanWhenTheSalaryIsLessThan3TimeMensuality()
        {
            int salary = 100;
            int balance = 500;
            var loanCustomer = new LoanCustomer(salary, balance);

            Assert.IsFalse(loanCustomer.CheckLoan(1000, 10));
        }

        [Test]
        public void ShouldAcceptLoanWhenTheBalanceIsMoreThan10PerscentOfTheCreditAndSalaryMoreThan3TimesMensuality()
        {
            int salary = 3100;
            int balance = 10500;
            var loanCustomer = new LoanCustomer(salary, balance);

            Assert.IsTrue(loanCustomer.CheckLoan(10000,10));
        }
    }
}
