open System

// utils

let rec forLoop body times = 
    if times <= 0 then
        ()
    else
        body
        forLoop body (times - 1)

let rec whileLoop body predicate =
    if predicate then
        body
        whileLoop body predicate
    else
        ()

let rec gcd x y =
    if y = 0 then x
    else gcd y (x % y)


//let rec readList n = 
//    if n=0 then []
//    else
//    let Head = System.Convert.ToInt32(System.Console.ReadLine())
//    let Tail = readList (n-1)
//    Head::Tail


//let rec opList l (f:int->int->int) : int= 
//    match l with
//    |head::[] -> head
//    |head::t -> f head (opList t f) 
//    |[] -> 0

// 11.

//let case11caseStatement langName =
//    printfn "11."
//    match langName with
//    | "F#" | "Prolog" -> printfn "Подлиза"
//    | "Python" | "Rust" | "Go" -> printfn "Питонист"
//    | "Java" | "Kotlin" -> printfn "Тебя к крестогосподам занесёт"
//    | "C#" | "C++" -> printfn "Полетайкин би лайк"
//    | _ -> printfn "Нет языка в списках"

// 12. - реализация внутри main

// 13.

//let rec multprod args = 
//    match args with
//    | [] -> 0
//    | head::[] -> head
//    | head::tail -> head * multprod tail

//let rec multminTC args min =
//    match args with
//    | head::tail when head < min -> multminTC tail head
//    | head::tail -> multminTC tail min
//    | [] -> min

//let multmin args =
//    multminTC args (System.Int32.MaxValue)

//let rec multmaxTC args max =
//    match args with
//    | head::tail when head > max -> multmaxTC tail head
//    | head::tail -> multmaxTC tail max
//    | [] -> max

//let multmax args =
//    multmaxTC args (System.Int32.MinValue)

//let case13prodminmax args =
//    printfn "13. %A" args
//    printfn "Произведение: %A" (multprod args) // рекурсия вверх
//    printfn "Минимальное: %A" (multmin args) // хвостовая
//    printfn "Максимальное: %A" (multmax args) // хвостовая

// 14.

//let isLess x y = if x < y then true else false

//let rec TC func lst min =
//    match lst with
//    | head1::(head2::tail) when func head1 head2 -> multminTC tail head1
//    | head1::(head2::tail) when func head2 head1 -> multminTC tail head2
//    | head::[] when func min head -> min
//    | head::[] when func head min -> head
//    | [] -> min
//    | _ -> min


//let rec curringFunc func lst =
//    TC func lst (System.Int32.MaxValue)
    

//let rec divSearchTC (iter:int) (times:int) (items:list<int>):list<int> = 
//    match iter with
//    | _ when iter > times -> items
//    | _ when times % iter = 0 -> divSearchTC (iter + 1) times (iter::items)
//    | _ -> divSearchTC (iter + 1) times items
        

//let divSearch number =
//    divSearchTC 1 number [] // поменять 1 на 2, если нужно найти наименьшее, больше 1

//let numbersDivIter number func =
//    let divs = divSearch number
//    let min = curringFunc isLess divs
//    divs, min

//let case14divSearch number =
//    printfn "14. Число - %A" number
//    let divs, min = numbersDivIter number isLess
//    printfn "Делители - %A" divs
//    printfn "Минимальный - %A" min

// 15. — с применением генератора
// взял компоненты сложения, т.е. 3 + 2 = 5


let times x y = x * y

let numbersCoprimeIter number =
    let coprimes = [
        for i in 1 .. number/2 do
            if (number - i) % i <> 0
            then
                yield (i, number - i, i * (number - i))
    ]

    coprimes

let case15coprimeNumbers number =
    printfn "15. Числа - %A" number
    let sumMapToPrimes = numbersCoprimeIter number
    printfn "Взаимнопростые компоненты сложения числа, их произведение - \n %A" sumMapToPrimes


// 16.


// 17.

let case17divsSearch = //
    ()

// 18. Work with numbers
// Variant 3 — Zhdanoff Alexader

// 1



//let maxgcd =
//    ()

//let case181 x =
//    let divs = [
//        for n in 1 .. x do
//            if x % n = 0
//            then
//                yield n
//    ]
//    let res = 

// 2

//let prodNonDiv5 = // TODO: ???
//    ()

//let case182 =
//    ()

// 3

//let maxEvenNonPrime = // TODO: делитель числа, его произведения
//    ()

//let case183 =
//    ()

[<EntryPoint>]
let main argv =
    // case11caseStatement "Python"
    // case12CaseStatement - first superpositions then carring
    
    //printfn "12."
    //let func langName =
    //    match langName with
    //    | "F#" | "Prolog" -> printfn "Подлиза"
    //    | "Python" | "Rust" | "Go" -> printfn "Питонист"
    //    | "Java" | "Kotlin" -> printfn "Тебя к крестогосподам занесёт"
    //    | "C#" | "C++" -> printfn "Полетайкин би лайк"
    //    | _ -> printfn "Нет языка в списках"

     

    // superpositions — написать только оператором суперпозиции << >>

    //let inputLang X = (if X=1 then "F#" else "Python")
    //let newfunc = inputLang >> func
    //newfunc 1

    // carring — написать только оператором каррирования <| |>

    //let inputLang = "Prolog"
    //inputLang |> func 

    //

    // case13prodminmax [1; 3; 2; 5; 4]
    // case14divSearch 25
    //case15coprimeNumbers 16
    //case16unitTest15 // test 15
    //case16eulerNumber 100
    //case16gcd 52 13
    // case17divsSearch
    // case181
    // case182
    // case183
    0 // return 0