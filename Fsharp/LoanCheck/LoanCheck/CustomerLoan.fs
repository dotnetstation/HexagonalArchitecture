module CustomerLoan

type Customer = { Salary:int; Balance: int }

let CheckLoan customer loanAmount monthlyPayments = 
    customer.Salary > (loanAmount / monthlyPayments * 3) && customer.Balance > loanAmount /10