namespace LoanCheck

open FsUnit
open NUnit.Framework
open CustomerLoanService

[<TestFixture>]
module CustomerLoanServiceTest =
    [<Test>]
    let ``Integration test for check loan`` () =
        CheckLoanForCustomer "john.doe@foobar.com" 10000 12 |> should be False


