namespace LoanCheck

open FsUnit
open NUnit.Framework
open CustomerLoan

[<TestFixture>]
module LoanCustomerTest = 
    [<Test>]
    let ``Should refuse loan request when the salary is not 3 time higher than monthly payment`` () =
        let customer = { Salary=1200; Balance = 10000 }
        CheckLoan customer 50000 12 |> should be False

    [<Test>]
    let ``Should accept loan when salary is 3 time higher than monthly payment`` () =
        let customer = { Salary=3000; Balance = 10000 }
        CheckLoan customer 10000 12 |> should be True

    [<Test>]
    let ``Should refuse loan when balance is less than ten percent loan amount`` () =
        let customer = { Salary=3000; Balance = 900 }
        CheckLoan customer 10000 12 |> should be False
        
    [<Test>]
    let ``Should accept loan when balance is more than ten percent loan amount`` () =
        let customer = { Salary=3000; Balance = 1900 }
        CheckLoan customer 10000 12 |> should be True
