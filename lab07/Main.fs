﻿(*
Variant 3 Alexander Zhdanoff
tasks: 3, 13, 23, 33, 43, 53
16.
*)

//// task3

//let task3 lst index = 
//    let max = List.max lst

//    if lst.Item index = max
//    then true
//    else false

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;17;19;14]
//    let ind = 3
//    printfn "%A" (task3 lst ind)
//    0

//// task13

//let task13 lst =
//    let min = List.min lst
//    let minindex = List.findIndex (fun x -> x = min) lst
//    let lst1, lst2 = List.splitAt minindex lst
//    lst2 @ lst1

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;17;19;14]
//    printfn "%A" (task13 lst)
//    0

// task23

//let task23 lst =
//    let sorted = List.sort lst
//    let min1, min2 = sorted.Head, sorted.Tail.Head
//    (min1, min2)

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;17;19;14]
//    printfn "%A" (task23 lst)
//    0

//// task33

//let task33 (lst:int list) =
//    let first = lst.Head
//    let scnd = lst.Tail.Head

//    if first * scnd < 0
//    then
//        let siqnseq = seq {for i in 1..2..lst.Length do yield! seq {sign first; sign scnd}}
//        Seq.forall2 (fun x y -> if x*y > 0 then true else false) lst siqnseq
//    else false
        
    
//[<EntryPoint>]
//let main argv = 
//    let lst = [-3; 2; -1; 1; -1; 1]
//    printfn "%A" (task33 lst)
//    0

//// task43

let getmincounts (lst, min) =
    List.filter (fun x -> x = min) lst |> List.length

let task43 lst =
     (lst, List.min lst) |> getmincounts
    

[<EntryPoint>]
let main argv = 
    let lst = [5;11;3;21;3;17;19;14]
    let ind = 3
    printfn "%A" (task43 lst)
    0

//// task53

//let roundup x = 
//    let res = round x
//    if x > res then res + 1.0
//    else res

//let task53 lst = 
//    let floated = List.map (fun x -> float x) lst
//    let max = List.max floated
//    let average = List.average floated
//    (average, max, [ for i in (average |> roundup)..max do yield i ])

//[<EntryPoint>]
//let main argv = 
//    let lst = [2;4;5;1;2;3;1;17]
//    printfn "average, max, list: %A" (task53 lst)
//    0


(*
Variant 3 Alexander Zhdanoff
17.
Для введенного числа N построить список неповторяющихся кортежей
(a,b), таких, что существует пара (x,y): X*Y=N, НОД(X,Y)=d, a=X/d, b=Y/d
*)

//let rec gcd (x, y) =
//    if y = 0 then x
//    else gcd (y, (x % y))

//let solve17 num =
//    let divs = [
//        for i in 1..num do
//            if num % i = 0
//            then yield i
//    ]

//    let pairs = [
//        let n = (divs.Length / 2 - 1 + (divs.Length % 2))
//        for i in 0..n do
//            yield (divs.Item i, divs.Item (divs.Length - 1 - i))
//    ]
//    //let pairs = divs |> List.allPairs divs |> List.filter (fun (x, y) -> x*y = num)

//    [
//    for pair in pairs do
//        let gcd = pair |> gcd
//        yield (fst pair / gcd, snd pair / gcd)
//    ]


//[<EntryPoint>]
//let main argv = 
//    let num = 625
//    printfn "%A" (solve17 num)
//    0

(*
Variant 3 Alexander Zhdanoff
18.
*)

//let solve18 arr1 arr2 = 
//    let folder = [| arr1; arr2 |]
//    Array.concat folder

//[<EntryPoint>]
//let main argv = 
//    let arr1 = [| for i in 1..10 do yield i |]
//    let arr2 = [| for i in 11..20 do yield i |]
//    printfn "%A" (solve18 arr1 arr2)
//    0

(*
Variant 3 Alexander Zhdanoff
19.
task 8, task 16
*)

//let task3 (str:string) =
//    let splitted = str.Split " "
//    let rnd = System.Random()
//    let res = splitted |> Array.sortBy (fun x -> rnd.Next(0, splitted.Length))
//    res |> String.concat " " |> printfn "%A"

//let task8 (str:string) =
//    let splited = str.Split " "
//    Array.fold (fun acc x -> if (x |> String.length) % 2 = 0 then acc+1 else acc) 0 splited |> printfn "%A"

//let task16 flag =
//    let cmprColots = function 
//        | "White" -> 0
//        | "Blue" -> 1
//        | "Red" -> 2
//    Array.sortBy (fun color -> cmprColots color) flag |> Array.iter (fun x -> printfn "%A" x)

//[<EntryPoint>]
//let main argv = 
//    let loremipsum3 = "A B C D E F G H I K L"
//    let loremipsum8 = "Lorem Ipsum Dolor Ligma Filo Degro Giga Cdfi"
//    let flag = [|
//        "Red";
//        "White";
//        "Blue"
//    |]
    
//    System.Console.WriteLine "Выберите программу 3,8,16:"
//    let task = match System.Console.ReadLine() with
//    | "3" -> task3 loremipsum3
//    | "8" -> task8 loremipsum8
//    | "16" -> task16 flag
//    | _ -> printfn "Неправильный символ"

//    //printfn "%A" task
//    0

(*
Variant 3 Alexander Zhdanoff
20.
*)