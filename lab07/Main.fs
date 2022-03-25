(*
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

let task13 lst =
    let min = List.min lst
    let minindex = List.findIndex (fun x -> x = min) lst
    let lst1, lst2 = List.splitAt minindex lst
    lst2 @ lst1

[<EntryPoint>]
let main argv = 
    let lst = [5;11;3;21;17;19;14]
    printfn "%A" (task13 lst)
    0

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

//let getmincounts (lst, min) =
//    List.filter (fun x -> x = min) lst |> List.length

//let task43 lst =
//     (lst, List.min lst) |> getmincounts
    

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;3;17;19;14]
//    let ind = 3
//    printfn "%A" (task43 lst)
//    0

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