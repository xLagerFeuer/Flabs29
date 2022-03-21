open System

// utils

//let min x y = 
//    if x > y then y
//    else x

//let max x y =
//    if x 

let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail


let rec opList l (f:int->int->int) : int= 
    match l with
    |head::[] -> head
    |head::t -> f head (opList t f) 
    |[] -> 0

// 11.

let case11caseStatement langName =
    printfn "11."
    match langName with
    | "F#" | "Prolog" -> printfn "Подлиза"
    | "Python" | "Rust" | "Go" -> printfn "Питонист"
    | "Java" | "Kotlin" -> printfn "Тебя к крестогосподам занесёт"
    | "C#" | "C++" -> printfn "Полетайкин би лайк"
    | _ -> printfn "Нет языка в списках"

// 12. - реализация внутри main

// 13.

let rec multprod args = 
    match args with
    | [] -> 0
    | head::[] -> head
    | head::tail -> head * multprod tail

let rec multminTC args min =
    match args with
    | head::tail when head < min -> multminTC tail head
    | head::tail -> multminTC tail min
    | [] -> min

let multmin args =
    multminTC args (System.Int32.MaxValue)

let rec multmaxTC args max =
    match args with
    | head::tail when head > max -> multmaxTC tail head
    | head::tail -> multmaxTC tail max
    | [] -> max

let multmax args =
    multmaxTC args (System.Int32.MinValue)

let case13prodminmax args =
    printfn "13. %A" args
    printfn "Произведение: %A" (multprod args) // рекурсия вверх
    printfn "Минимальное: %A" (multmin args) // хвостовая
    printfn "Максимальное: %A" (multmax args) // хвостовая

// 14.

let case14divSearch =
    ()

// 15.

let case15coprimeNumbers X func initY = // declare types defination
    ()

// 16.

let case16unitTest15 =
    ()

let case16eulerNumber =
    ()

let case16gcd =
    ()

// 17.

let case17divsSearch = //
    ()

// 18. Work with numbers
// Variant 3 — Zhdanoff Alexader

// 1

let maxgcd =
    ()

let case181 =
    ()

// 2

let prodNonDiv5 = // TODO: ???
    ()

let case182 =
    ()

// 3

let gcd =
    ()

let maxEvenNonPrime = // TODO: делитель числа, его произведения
    ()

let case183 =
    ()

[<EntryPoint>]
let main argv =
    case11caseStatement "Python"
    
    // case12CaseStatement - first superpositions then carring
    
    let inputLang = "Prolog"

    // superpositions — написать только оператором суперпозиции << >>

    //compare inputLang
    //<< functional << "Подлиза"
    //<< newest << "Питонист"
    //<< jvm << "Тебя к крестогосподам занесёт"
    //<< C << "Полетайкин би лайк"
    //>> voidDestructor

    // carring — написать только оператором каррирования <| |>



    //

    // case13prodminmax [1; 3; 2; 5; 4]
    // case13prodTailCall
    // case14divSearch
    // case15coprimeNumbers
    // case16eulerNumber
    // case16gcd
    // case17divsSearch
    // case181
    // case182
    // case183

    0 // return 0
