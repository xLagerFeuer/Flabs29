open System

// 1 OOP

type IPrintable = 
    abstract member Print: unit -> unit

[<AbstractClass>]
type GeometricFigure() =
    abstract member getArea: unit -> float

type Rectangle (
    length:int,
    height:int
    ) =
    inherit GeometricFigure()

    member this.Length = length
    member this.Height = height
    
    override this.getArea() = (float)(this.Length * this.Height)
    override this.ToString() = "Length = " + this.Length.ToString() + ", Height = " + this.Height.ToString() + ", Area = " + this.getArea().ToString()
    interface IPrintable with
        member this.Print() = printfn "%s" (this.ToString())
   
type Square (
    size:int
    ) =
    inherit Rectangle(size, size)
    
    override this.ToString() = "Size = " + this.Length.ToString() + ", Area = " + this.getArea().ToString()
    interface IPrintable with
        member this.Print() = printfn "%s" (this.ToString())

type Circle (
    radius:int
    ) =
    inherit GeometricFigure()

    member this.Radius = radius

    override this.getArea() = Math.PI * (float)this.Radius * (float)this.Radius
    override this.ToString() = "Radius = " + this.Radius.ToString() + ", Area = " + this.getArea().ToString()
    interface IPrintable with
        member this.Print() = printfn "%s" (this.ToString())

// 2 Algebraic types

type round = float
type height = float
type weight = float

type GeometricFigureAlg = 
    | ARectangle of height * weight
    | ASquare of height
    | ACircle of round

let getArea (geomfigure:GeometricFigureAlg) =
    match geomfigure with
    | ARectangle(x, y) -> x * y
    | ASquare(x) -> x * x
    | ACircle(r) -> Math.PI * r * r

// main

[<EntryPoint>]
let main argv =
    // 1
    let rectangle = Rectangle(3, 5)
    (rectangle :> IPrintable).Print()
    let square = Square(4)
    (square :> IPrintable).Print()
    let squareAsRectangle = square :> Rectangle
    (squareAsRectangle :> IPrintable).Print()
    let circle = Circle(3)
    (circle :> IPrintable).Print()

    // 2

    Console.WriteLine(getArea (ARectangle(5.0, 7.0)))
    Console.WriteLine(getArea (ASquare(5.0)))
    Console.WriteLine(getArea (ACircle(5.0)))
    
    0
