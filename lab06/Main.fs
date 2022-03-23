open System

// utils

let ident x = x

// let gcd x y =


// 11

let sum x y z =
    x + y + z

let times x y z =
    x * y * z

// — можно сделать красивше до полной чистоты функции, применив ещё две функции: проверяют пустоту и возвращают 1 в случае проверки пустоты
// а функцию sum сделать каррируемой саму на себя
// let return1 x = 1
// let isunit x = if x = () then true else false

let rec mapTC lst (func:(int->int->int->int)) =
    match lst with
    | x::(y::(z::tail)) -> (func x y z)::(mapTC tail func)
    | x::(y::tail) -> (func x y 1)::[]
    | x::tail -> (func x 1 1)::[]

let map lst func = 
    mapTC lst func

// get map: len lst1 % 3 = 0, len lst2 * 3 = len lst1, lst1 -> lst2
let task11 lst func =
    map lst func

[<EntryPoint>]
let main argv = 
    let lst = [1;4;11;2;7;9;20]
    printfn "%A" (task11 lst sum)
    printfn "%A" (task11 lst times)
    0

(*
 Variant 3 — Alexander Zhdanoff
 tasks: 3, 11, 13, 15, 27, 30, 39, 45,51
 12—20
*)

//// task3

// индексация n с нуля aka индекс массивов a[0]
//let rec isNglMaxSearchTC lst n max=
//    match lst with
//    | head::tail when (n = 0) -> if head >= max then true else false
//    | head::tail when  head > max -> isNglMaxSearchTC tail (n-1) head
//    | head::tail -> isNglMaxSearchTC tail (n-1) max

//let isNglMaxSearch lst n =
//    isNglMaxSearchTC  lst n (Int32.MinValue)

//let task3 array n =
//    isNglMaxSearch array n

//[<EntryPoint>]
//let main argv = 
//    let array = [5; 11; 3; 18; 9; 2; 3] 
//    let n = 4
//    printfn "%A" (task3 array n)
//    0

//// task11

//let union x y = if x && y then true else false

//let rec findAnotherTC lst diff =
//    match lst with
//    | head::tail when head = diff -> findAnother tail 
//    | head::tail when  head > max -> isNglMaxSearchTC tail (n-1) head
//    | head::tail -> isNglMaxSearchTC tail (n-1) max

//let findAnother lst =
//    findAnotherTC lst.Tail lst.Head

//let task11 array =
//    findAnother array

//[<EntryPoint>]
//let main argv = 
//    let array = [5; 5; 4; 5; 5; 5; 5] 
//    printfn "%A" (task11 array)
//    0

//// task13

//let isEqual x y = fun x -> if y = x then true else false

//let rec findMinTC lst min =
//    match lst with
//    | head::tail when head < min -> findMinTC tail head
//    | head::tail -> findMinTC tail min
//    | _ -> min
    
//let rec rawListTC lst cndtn =
//    match lst with
//    | head::tail when cndtn head -> head::tail
//    | head::tail -> (rawListTC tail cndtn)::head


//let shiftToMin array =
//    let min = findMinTC array (Int32.MaxValue)
//    rawListTC lst (isEqual <| min)

//let task13 array =
//    shiftToMin array

//[<EntryPoint>]
//let main argv = 
//    let array = [5; 5; 4; 2; 1; 13; 8; 5] 
//    printfn "%A" (task 13 array)
//    0


//// task15

//let task15 array n =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0

//// task27

//let task27 array =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0

//// task30

//let task30 array n =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0

//// task39

//let task39 array =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0

//// task45

//let task45 array seq =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0

//// task51

//let task51 lst =

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0
