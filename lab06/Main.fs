open System

// utils

let ident x = x

// let gcd x y =


// 11

//let sum x y z =
//    x + y + z

//let times x y z =
//    x * y * z

//// — можно сделать красивше до полной чистоты функции, применив ещё две функции: проверяют пустоту и возвращают 1 в случае проверки пустоты
//// а функцию sum сделать каррируемой саму на себя
//// let return1 x = 1
//// let isunit x = if x = () then true else false

//let rec mapTC lst (func:(int->int->int->int)) =
//    match lst with
//    | x::(y::(z::tail)) -> (func x y z)::(mapTC tail func)
//    | x::(y::tail) -> (func x y 1)::[]
//    | x::tail -> (func x 1 1)::[]

//let map lst func = 
//    mapTC lst func

//// get map: len lst1 % 3 = 0, len lst2 * 3 = len lst1, lst1 -> lst2
//let task11 lst func =
//    map lst func

//[<EntryPoint>]
//let main argv = 
//    let lst = [1;4;11;2;7;9;20]
//    printfn "%A" (task11 lst sum)
//    printfn "%A" (task11 lst times)
//    0

(*
 Variant 3 — Alexander Zhdanoff
 tasks: 3, 11, 13, 15, 27, 30, 39, 45,51
 12—20
*)

// task3

//глобальный максимум => самый большое значение max
//индексация n с нуля aka индекс массивов a[0]
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

//let findAnother (lst:int list) =
//    let rec getDiff lst diff =
//        match lst with
//        | head::tail when head = diff -> getDiff tail diff
//        | x::y::tail ->
//            if diff = x then y else x
//    getDiff lst.Tail lst.Head

//let task11 array =
//    findAnother array

//[<EntryPoint>]
//let main argv = 
//    let array = [5; 5; 4; 5; 5; 5; 5] 
//    printfn "%A" (task11 array)
//    0

//// task13

//let isEqual x = fun y -> if x = y then true else false

//let shiftToMin array =
//    let rec findMin lst min =
//        match lst with
//        | head::tail when head < min -> findMin tail head
//        | head::tail -> findMin tail min
//        | _ -> min
        
//    let rec rawList lstL lstR cndtn =
//        match lstL with
//        | head::tail when cndtn head -> lstL @ lstR
//        | head::tail -> rawList tail (lstR @ head::[]) cndtn

//    let min = findMin array (Int32.MaxValue)
//    rawList array [] (isEqual min)

//let task13 array =
//    shiftToMin array

//[<EntryPoint>]
//let main argv = 
//    let array = [5; 5; 4; 2; 1; 13; 8; 5] 
//    printfn "%A" (task13 array)
//    0


// task15

let task15 (lst:int list) n =
    let rec isLocalMin lst n =
        match lst with
        | head::pnt::tail when n = 1 -> if head > pnt && pnt < tail.Head then true else false
        | head::tail -> isLocalMin tail (n-1)
    if n = 0 && lst.Head < lst.Tail.Head then true
    else isLocalMin lst n
    

//// по определению, локальный минимум x - x: существует E>0 f(x-E) > f(x), f(x+E) > f(x) => localmin [5,1,2,0] = 1
//// индексация с нуля
//[<EntryPoint>]
//let main argv =
//    let arr = [5; 3; 2; 7; 9; 1; 16; 25] 
//    let n = 2
//    printfn "%A" (task15 arr n)
//    0

//// task27

//let task27 lst =
//    let circularShiftLeft (lst:int list) = lst.Tail @ (lst.Head)::[]
//    circularShiftLeft lst

//[<EntryPoint>]
//let main argv = 
//    let lst = [for i in 1..20 do yield i]
//    printfn "%A" (task27 lst)
//    0

//// task30

//let task30 (lst:int list) n =
//    let rec isLocalMax lst n =
//        match lst with
//        | head::pnt::tail when n = 1 -> if head < pnt && pnt > tail.Head then true else false
//        | head::tail -> isLocalMax tail (n-1)
//    if n = 0 && lst.Head > lst.Tail.Head then true
//    else isLocalMax lst n

//// локальный максимум
//[<EntryPoint>]
//let main argv = 
//    let arr = [5; 3; 2; 7; 9; 1; 16; 25] 
//    let n = 5
//    printfn "%A" (task30 arr n)
//    0

//// task39

//let task39 lst =
//    let rec outEven lst =
//        match lst with
//        | even1::odd::tail -> 
//            printf "%A " even1
//            outEven tail
//            outOdd <| odd::tail
//        | even -> 
//            printf "%A " even
//            ()
//    and outOdd lst  =
//        match lst with
//        | odd1::even::tail -> 
//            printf "%A " odd1
//            outOdd tail
//        | odd ->
//            printf "%A " odd
//            ()
//    outEven lst

//[<EntryPoint>]
//let main argv = 
//    let arr = [5; 3; 2; 7; 9; 1; 16; 25]
//    printfn "%A" <| task39 arr
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
