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
task3, task 8, task 16
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
//    let loremipsum8 = "Lorem Ipsum Dolor Ligma Filo Degro Giga Cdfia"
//    let flag = [|
//        "Red";
//        "White";
//        "Blue"
//    |]
    
    //System.Console.WriteLine "Выберите программу 3,8,16:"
    //let task = match System.Console.ReadLine() with
    //| "3" -> task3 loremipsum3
    //| "8" -> task8 loremipsum8
    //| "16" -> task16 flag
    //| _ -> printfn "Неправильный символ"

    //printfn "%A" task
//    0

(*
Variant 3 Alexander Zhdanoff
20.
task 3, 4
*)

// task3

// Внутри F# нет классических датаданных о частоте букв в алфавите, воспользуемся данными со стороннего csv файла
// sourse — https://gist.github.com/randallmorey/dea827d6f1c48374bdea0d2f5a320a16

open FSharp.Data

let String2List (word:string) = Seq.toList word

let getFrequencyList (word:string) = 
    word.Replace(" ", "").ToUpper() |> String2List |> List.countBy id

let solve3 verbose strings = 
    let indexedstr = Array.indexed strings
    let freqWords = strings |> Array.map getFrequencyList
    
    let mostFreq = Array.map (List.maxBy (fun (_, i) -> i)) freqWords
    let cntsLetters = Array.map (List.sumBy (fun (_, i) -> i)) freqWords
    
    let divXY x y = System.Math.Round (((float)x/(float)y), 5)

    let freqmostinword = Array.map2 (fun (letter, q1) q2 -> (letter, divXY q1 q2)) mostFreq cntsLetters
    let freqAlphabet = CsvFile.Load(__SOURCE_DIRECTORY__ + "/alphabetFreq.csv").Cache().Rows
    
    let diffFrqncs index =
        let elem = freqmostinword.[index]
        let letter = fst elem

        let row = freqAlphabet |> Seq.find (fun (x: CsvRow) -> (char)x.["letter"] = letter)
        let frq = (float)row.["frequency"]

        if verbose
        then 
            printf "%A " (snd elem - frq) 
            printfn ""
        snd elem - frq

    if verbose
    then printfn "Rawdata \n %A" (indexedstr, "\n", freqWords, "\n", mostFreq, "\n" , cntsLetters, "\n", freqmostinword, "\n", freqAlphabet)
    
    printf "Result — "
    indexedstr |> Array.sortBy (fun (index, _) -> diffFrqncs index)

// task4

let ASCIIcode (char:char) = (int)char

// TODO: replace string -> seqChars (String2Seq)
let mean length seqChars = (seqChars |> List.sumBy ASCIIcode) / length

let squaresub master slave = (float)((ASCIIcode slave) - master)**2.0 // variables name means how works closure in F#
// let min master = fun slave -> slave - master — same declaration

let SD verbose length mean seqChars =
    let res = (seqChars |> Seq.map (squaresub mean) |> Seq.sum) / (float)length
    if verbose then printfn "%A" res
    res

let solve4 verbose strings =
    let getAvrgWeightASCII (string:string)=
        let seqChars = Seq.toList string
        let res = mean string.Length seqChars
        if verbose then printfn "%A" res
        res

    let stringsweights = (Array.map getAvrgWeightASCII strings) |> Array.zip strings
    if verbose then printfn "%A" stringsweights
    let avrgtarget = snd (stringsweights.[0])
    strings |> Array.sortBy (fun string -> SD verbose string.Length avrgtarget (Seq.toList string))

// Controller

[<EntryPoint>]
let main argv = 
    let task3 = [|"Sosiska v teste"; "Marmelad"; "Donada"|]
    let task4 = [|"Sosiska v teste"; "Marmelad"; "Donada"; "12PO"; "2321"; "Q^4"|]

    System.Console.WriteLine "Выберите программу 3,4:"
    if System.Console.ReadLine() = "3" 
    then printfn "%A" (solve3 true task3) // 
    else printfn "%A" (solve4 true task4)
    0