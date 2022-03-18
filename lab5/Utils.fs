module Utils

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