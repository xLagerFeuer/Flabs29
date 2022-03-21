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
    match langName with
    | "F#" | "Prolog" -> printf "Подлиза"
    | "Python" | "Rust" | "Go" -> printf "Сойбой"
    | "Java" | "Kotlin" -> printf "Тебя к крестогосподам занесёт"
    | "C#" -> printf "Полетайкин би лайк"
    | "C++" -> printf "Зося би лайк"
    | "1C" -> printf "Выскубов би лайк"
    | _ -> printf "Хе-хе"

// 12. - реализация внутри main

// 13.

let rec multprod args:list<int> ?prod=0 = 
    match args with
    | 
    | 
    | [] -> 0

let rec multmin args =
    match args with
    | head::[] -> head
    | head::tail -> multmin(head multmin(tail))
    | [] -> []

let rec multmax args:list<int> =
    match args with
    |
    |
    | [] -> 0

let case13prodminmax args =
    printf "Произведение: %f" (multprod args) // рекурсия снизу вверх
    printf "Минимальное: %f" (multmin args) // хвостовая
    printf "Максимальное: %f" (multmax args) // хвостовая

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
    
        // гег

    //

    case13prodminmax [1 3 2 5 4]
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
