open FParsec
open System

type Expr =
    | Num of float
    | Plus of Expr * Expr
    | Minus of Expr * Expr

let pstring_trim s = spaces >>. pstring s .>> spaces
let float_ws = spaces >>. pfloat .>> spaces


let parseExpression, implementation = createParserForwardedToRef<Expr, unit>()

let parsePlus = tuple2 (parseExpression .>> pstring_trim "+") parseExpression |>> Plus
let parseSub = tuple2 (parseExpression .>> pstring_trim "-") parseExpression |>> Minus

let parseOp = between (pstring_trim "(") (pstring_trim ")") (attempt parsePlus <|> parseSub)

let parseNum = float_ws |>> Num

implementation := parseNum <|> parseOp

let rec EvalExpr (e:Expr): float =
    match e with
    | Num(num) -> num
    | Plus(a,b) ->
        let left = EvalExpr(a)
        let right = EvalExpr(b)
        let result = left + right
        result
    | Minus(a,b) ->
        let left = EvalExpr(a)
        let right = EvalExpr(b)
        let result = left - right
        result



[<EntryPoint>]
let main argv =
    let input = Console.ReadLine() 
    let expr = run parseExpression input

    match expr with
    | Success (result, _, _) -> Console.WriteLine(EvalExpr result)
    | Failure (errorMsg, _, _) -> Console.WriteLine(errorMsg)

    0