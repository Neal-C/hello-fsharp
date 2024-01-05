open System // Gets access to functionality in System namespace.

// Defines a list of names
let names = [ "Peter"; "Alice"; "Bob" ]

// Defines a function that takes a name and produces a greeting.
let getGreeting name = $"Hello, {name}"

// Prints a greeting for each name!
names
|> List.map getGreeting
|> List.iter (fun greeting -> printfn $"{greeting}! Enjoy your F#")