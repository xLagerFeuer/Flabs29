open System

// Haskell Maybe, F# Option
// option — functor, applicativeFunctor and monada by definition.

//type option =
//    | Some of 'b
//    | None

let map func some =
    match some with
    | Some(b) -> Some(func b)
    | None -> None

let apply somefunc some  =
    match somefunc, some with
    | Some(f), Some(b) -> Some (f b)
    | _ -> None

let monada some (func2opt:'b->option<'b>) =
    match some with
    | Some(b) -> func2opt b
    | None -> None

let functorlaw1test =
    map id (Some(3)) = Some(3)

let functorlaw2test =
    let funcF x = x + 1
    let funcG x = x * 2
    let funcFG = funcF >> funcG
    let pathOne = Some(3) |> map funcF |> map funcG
    let pathTwo = Some(3) |> map funcFG

    pathOne = pathTwo

let applicativeFunctorlaw1test =
    apply (Some(id)) (Some(3)) = Some(3)

let applicativeFunctorlaw2test =
    let funcF x = x + 1
    let pathOne = Some(3) |> apply (Some(funcF))
    let pathTwo = Some(funcF 3) |> apply (Some(id))

    pathOne = pathTwo

//let applicativeFunctorlaw3test = // исключение, т.к. закон коммутативности аргументов не работает при строгой типизации
//    let funcF x = x + 1
//    let pathOne = Some(3) |> apply (Some(funcF))
//    let pathTwo = Some(funcF) |> apply (Some(3))

//    pathOne = pathTwo

//let applicativeFunctorlaw4test = // аналогично с 3

[<EntryPoint>]
let main argv =
    Console.WriteLine(functorlaw1test)
    Console.WriteLine(functorlaw2test)

    Console.WriteLine(applicativeFunctorlaw1test)
    Console.WriteLine(applicativeFunctorlaw2test)
    //Console.WriteLine(applicativeFunctorlaw3test)
    //Console.WriteLine(applicativeFunctorlaw4test)

    0 
