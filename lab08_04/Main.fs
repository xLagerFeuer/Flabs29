open System

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


[<EntryPoint>]
let main argv =
    let rectangle = Rectangle(3, 5)
    (rectangle :> IPrintable).Print()
    let square = Square(4)
    (square :> IPrintable).Print()
    let squareAsRectangle = square :> Rectangle
    (squareAsRectangle :> IPrintable).Print()
    let circle = Circle(3)
    (circle :> IPrintable).Print()
    0
