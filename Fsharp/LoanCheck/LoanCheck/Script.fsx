// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#r "../packages/FSharp.Data.2.2.3/lib/net40/FSharp.Data.dll"
open FSharp.Data

// Define your library scripting code here
let customers = new CsvProvider<"Data/customer.csv">()

let cust = customers.Filter(fun row -> row.Email = "john.doe@foobar.com").Rows |> Seq.head

for customer in customers.Rows do
    if customer.Email =  "john.doe@foobar.com" then
        printfn "%s" customer.Email
printfn "here we are"
