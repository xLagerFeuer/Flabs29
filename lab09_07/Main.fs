open System.Drawing
open System.Windows.Forms

let form = 
    let Form1 = new Form(Text = "Кортежи в F#", Width = 400, Height = 300, Menu = new MainMenu())
    Form1
 
let edits = 
    let Edit1 = new TextBox(Text="", Left=0, Top=30, Width=40, Height=20)
    let Edit2 = new TextBox(Text="", Left=50, Top=30, Width=40, Height=20)
    (Edit1, Edit2)
 
let buttons =
    let button5 = new Button(Text="=", Left=140, Top=30, Width=32, Height=23)
    button5

let labels =
    let label1 = new Label(Text="pressRCM", Left=100, Top=30, Width=25, Height=13)
    let label2 = new Label(Text="x1", Left=15, Top=10, Width=20, Height=13)
    let label3 = new Label(Text="x2", Left=55, Top=10, Width=20, Height=13)
    let label4 = new Label(Text="result", Left=140, Top=10, Width=60, Height=13)
    (label1, label2, label3, label4)

let Form1 = form
let x1, x2 = edits
let equal = buttons
let siqn, labelx1, labelx2, result = labels

Form1.Controls.Add(x1)
Form1.Controls.Add(x2)
Form1.Controls.Add(equal)
Form1.Controls.Add(siqn)
Form1.Controls.Add(labelx1)
Form1.Controls.Add(labelx2)
Form1.Controls.Add(result)

let strip =
    let contextMenuStrip = new ContextMenuStrip()
    let toolStrip1 = new ToolStripMenuItem("+")
    let toolStrip2 = new ToolStripMenuItem("-")
    let toolStrip3 = new ToolStripMenuItem("*")
    let toolStrip4 = new ToolStripMenuItem("/")
    contextMenuStrip.Items.Add(toolStrip1) |> ignore
    contextMenuStrip.Items.Add(toolStrip2) |> ignore
    contextMenuStrip.Items.Add(toolStrip3) |> ignore
    contextMenuStrip.Items.Add(toolStrip4) |> ignore
    siqn.ContextMenuStrip <- contextMenuStrip
    (toolStrip1, toolStrip2, toolStrip3, toolStrip4)

let toolStrip1, toolStrip2, toolStrip3, toolStrip4 = strip

let Summ_ = fun _ -> MessageBox.Show(string(int(x1.Text) + (int(x2.Text))), "Сумма") |>ignore
let Minus_ = fun _ -> MessageBox.Show(string(int(x1.Text) - (int(x2.Text))), "Разность") |>ignore
let Umnoj_ = fun _ -> MessageBox.Show(string(int(x1.Text) * (int(x2.Text))), "Умножение") |>ignore
let Del_ = fun _ -> 
    try 
        let calculus = int(x1.Text)/ (int(x2.Text))
        MessageBox.Show(string(calculus), "Деление") |> ignore
    with ex -> (
        printfn "%A" ex;
        MessageBox.Show(ex.ToString(), "Div error:") |> ignore
        )




let sum _ = siqn.Text <- "+"
let _ = toolStrip1.Click.Add(sum)
let sub _ = siqn.Text <- "-"
let _ = toolStrip2.Click.Add(sub)
let prod _ = siqn.Text <- "*"
let _ = toolStrip3.Click.Add(prod)
let div _ = siqn.Text <- "/"
let _ = toolStrip4.Click.Add(div)

let ravno _ = 
    if fst ( x1.Text, x2.Text) = "" || snd (x1.Text,x2.Text) = "" then result.Text <- "Ошибка" 
    else
        match siqn.Text with
        |"/" ->
            let del (a:double, b:double) =
                let res = 
                    if b = 0.0 then 0.0 else System.Convert.ToDouble(a/b)
                res
            let d1 = (double x1.Text, double x2.Text)
            let d3 = del d1  
            result.Text <- string d3
        |"+" ->
            let sum (a, b) =
                let res = a+b
                res
            let d1 = (float x1.Text, float x2.Text)
            let d3 = sum d1  
            result.Text <- string d3
        |"-" ->
            let raznost (a, b) =
                let res = a - b
                res
            let r1 = (float x1.Text, float x2.Text)
            let r3 = raznost r1 
            result.Text <- string r3
        |"*" ->
            let umnoj (a, b) =
                let res = a * b
                res
            let u1 = (float x1.Text, float x2.Text)
            let u3 = umnoj u1 
            result.Text <- string u3

let _ = equal.Click.Add(ravno)


do Application.Run(form)