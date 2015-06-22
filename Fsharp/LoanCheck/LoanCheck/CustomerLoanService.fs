module CustomerLoanService

open FSharp.Data
open CustomerLoan
open System

type Customers = CsvProvider<"Data/customer.csv">

let CheckLoanForCustomer email loanAmount monthelyPayments = 
    let customers = Customers.GetSample()
    let customer = customers.Rows 
                    |> Seq.filter(fun row -> row.Email = email) 
                    |> Seq.head
    
    CheckLoan { Salary=customer.Salaire; Balance= customer.Balance } loanAmount monthelyPayments