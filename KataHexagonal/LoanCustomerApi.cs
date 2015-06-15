using KataHexagonal.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHexagonal
{
    public class LoanCustomerApi
    {
        public ICustomerRepository customerRepostiroy { get; set; }

        public LoanCustomerApi(ICustomerRepository customerRepository)
        {
            this.customerRepostiroy = customerRepository;
        }

        public bool CheckCredit(string email, int creditAmount, int numberOfMensuality)
        {
            LoanCustomer loanCustomer = customerRepostiroy.CutomerByEmail(email);

            return loanCustomer.CheckLoan(creditAmount, numberOfMensuality);
        }
    }
}
