using KataHexagonal.Adapter;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHexagonal.Tests
{
    public class LoanCustomerApiTest
    {
        [Test]
        public void ShouldAcceptLoanForCustomerRadone()
        {
            var customerRepo = Substitute.For<ICustomerRepository>();
            customerRepo.CutomerByEmail("rad@one.com").Returns(new LoanCustomer(3100, 10500));
            var loanCustomerApi = new LoanCustomerApi(customerRepo);

            var resultCredit = loanCustomerApi.CheckCredit("rad@one.com", 10000, 10);

            Assert.IsTrue(resultCredit);
        }
    }
}
