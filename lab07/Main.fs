(*
Variant 3 Alexander Zhdanoff
tasks: 3, 13, 23, 33, 43, 53
16.
*)

//// task3

let task3 lst index = 
    let max = List.max lst

    if lst.Item index = max
    then true
    else false

[<EntryPoint>]
let main argv = 
    let lst = [5;11;3;21;17;19;14]
    let ind = 3
    printfn "%A" (task3 lst ind)
    0

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
//        let lstseq = List.toSeq lst
//        let siqnseq = seq {for i in 1..2..lst.Length do yield! seq {sign first; sign scnd}}
//        Seq.forall2 (fun x y -> if x*y > 0 then true else false) lstseq siqnseq
//    else false
        
    
//[<EntryPoint>]
//let main argv = 
//    let lst = [-3; 2; 1; 1; -1]
//    printfn "%A" (task33 lst)
//    0

//// task43

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;17;19;14]
//    let ind = 3
//    printfn "%A" (task3 lst ind)
//    0

//// task53

//[<EntryPoint>]
//let main argv = 
//    let lst = [5;11;3;21;17;19;14]
//    let ind = 3
//    printfn "%A" (task3 lst ind)
//    0