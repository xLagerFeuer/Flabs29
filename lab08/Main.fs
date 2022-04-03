(*
Variant 3 Alexander Zhdanoff
tasks: 3, 6, 9
Права на вождение
*)

open System
open System.Text.RegularExpressions
open System.Diagnostics

// 5
type DriverLicence(
    name:string,
    surname:string,
    birthday:DateTime
    ) =

    // 8 Regex matching
    
    let namespattern = @"^[a-zA-Z]+$" 
    do if (
        Regex(namespattern).IsMatch(name) &&
        Regex(namespattern).IsMatch(surname)) 
        then ()
        else raise <| new System.ArgumentException("Wrong name, surname")
        
    static let mutable counts = 0
    do counts <- counts + 1
    
    // 7
    // TODO: оператор приведения к интерфейсу
    interface IEquatable<DriverLicence> with
        member this.Equals other = other.index.Equals this.index
    interface IComparable with
        member this.CompareTo other =
            match other with
            | :? DriverLicence as DL -> (this :> IComparable<_>).CompareTo DL
            | _ -> -1
    interface IComparable<DriverLicence> with
        member this.CompareTo other = other.index.CompareTo this.index
    override this.Equals obj =
        match obj with
        | :? DriverLicence as DL -> (this :> IEquatable<_>).Equals DL
        | _ -> false
    override this.GetHashCode () = this.index.GetHashCode()
    static member (>) (operand1: DriverLicence, operand2: DriverLicence) =
        operand1.index - operand2.index > 0
    static member (<) (operand1: DriverLicence, operand2: DriverLicence) =
        operand1.index - operand2.index < 0
    
    
    member this.id = counts
    member this.series = 
        match this.id with
        | _ when this.id < pown 10 2 -> 1
        | _ when this.id < pown 10 4 -> 2
        | _ when this.id < pown 10 6 -> 3
        | _ -> 0
    member this.index = this.id + (pown this.series 6)
    member this.name = name
    member this.surname = surname
    member this.birthday = birthday 
    member this.ext = System.DateTime.Now
    member this.exp = System.DateTime.Now.AddYears(2)
    // 6
    member this.out =
        printfn "%A" (this.name, this.surname, this.birthday, this.ext, this.exp)
    override this.ToString() =
        $"Name — {this.name} \n Surname — {this.surname} \n Birthday — {this.birthday} \n Extend date — {this.ext} \n Expire date — {this.exp}"


// 9 , 10

//let timeWrapeer func = func

let timeWrapper func =
    printfn "Function — %A" System.Reflection.MethodInfo.GetCurrentMethod
    let stpwatch = new Stopwatch()
    stpwatch.Start()
    let startTime = stpwatch.ElapsedTicks
    let res = func
    let endTime = stpwatch.ElapsedTicks
    stpwatch.Stop()
    printfn "%A" (startTime, endTime, endTime - startTime)
    res

[<AbstractClass>]
type AbstractDoc() =
    abstract member searchDoc: DriverLicence -> bool

type ArrayUtil(arr: DriverLicence [])=
    inherit AbstractDoc()
    member this.arr = arr

    override this.searchDoc doc = 
        (Array.exists (fun x -> x = doc) >> timeWrapper) this.arr


type ListUtil(lst: DriverLicence list)=
    inherit AbstractDoc()
    member this.lst = lst

    override this.searchDoc doc = 
        (List.exists (fun x -> x = doc) >> timeWrapper) this.lst


type BT<'T> =
    | Empty
    | Node of 'T * BT<'T> * BT<'T>


// binary tree implementation
type BTS(tree: BT<DriverLicence>)=
    inherit AbstractDoc()
    member this.tree = tree

    static member exists doc tree =
        let rec NLR tree = 
            match tree with
            | Node (head, left, right) when head = doc -> true
            | Node (head, left, right) when head < doc -> left |> NLR
            | Node (head, left, right) when head > doc -> right |> NLR
            | Empty -> false
        NLR tree
        
    override this.searchDoc(doc) = 
        (doc |> BTS.exists >> timeWrapper) this.tree


type SetUtil(set:DriverLicence Set)=
    inherit AbstractDoc()

    member this.set = set
    override this.searchDoc doc = 
        (doc |> Set.contains >> timeWrapper) this.set


[<EntryPoint>]
let main argv = 
    // 6
    let Test1 = DriverLicence("Ara", "BB", System.DateTime.Parse("16/02/2008 12:15:12"))
    let Test2 = DriverLicence("Ara", "BB", System.DateTime.Parse("16/02/2008 12:15:12")) // same fields, diff index

    // 7
    //printfn "%A" (Test1.Equals Test1) // true
    //printfn "%A" (Test1.Equals Test2) // false

    //// 10
    //let another = DriverLicence("geg", "gegovich", System.DateTime.Parse("16/02/2008 12:15:12"))
    
    //let arr = ArrayUtil([|Test1; Test2|])
    //let lst = ListUtil([Test1; Test2])

    //let tree :BT<DriverLicence> = (Node)(Test1, (Node)(Test2, Empty, Empty), Empty)
    //let bt = BTS(tree)
    
    //let set = SetUtil(Set [Test1; Test2])


    //arr.searchDoc another


    0
