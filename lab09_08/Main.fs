open System
open System.Windows.Forms
open System.Drawing

Application.EnableVisualStyles()
let form = new Form(Text="Работа с массивами")


let label1 = new Label()
label1.Location <- new Point(100,0)
label1.Text <-"1 массив"
label1.Width <- 60
label1.Height <- 12

let label2 = new Label()
label2.Location <- new Point(100,25)
label2.Text <-"2 массив"
label2.Width <- 60
label2.Height <- 12

let label3 = new Label()
label3.Location <- new Point(100,50)
label3.Text <-"Result"
label3.Width <- 60
label3.Height <- 12

let array1 = new TextBox()
array1.Location<-new Point(170, 0)
array1.Width<-100
array1.Height<-25
array1.Text<-"1;4;6;8"

let array2 = new TextBox()
array2.Location<-new Point(170, 25)
array2.Width<-100
array2.Height<-25
array2.Text<-"3;3;3;3"

let result = new TextBox()
result.Location<-new Point(170, 50)
result.Width<-100
result.Height<-25
result.Text<-""

let outbutton = new Button(Text="Вывести")
outbutton.Location<-new Point(15,50)

outbutton.Click.AddHandler(
    fun _ _ ->
        let resconcat = (array1.Text + ";" + array2.Text)
        result.Text <- resconcat
    )

form.Controls.Add(outbutton)
form.Controls.Add(label1)
form.Controls.Add(label2)
form.Controls.Add(label3)
form.Controls.Add(array1)
form.Controls.Add(array2)
form.Controls.Add(result)

Application.Run(form)


[<EntryPoint>]
let main argv =
    0
