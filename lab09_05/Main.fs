module WinformsFs.Main

open System
open System.Windows.Forms

let forms = 
    let Form1 = new Form(Text = "Menu" , Width = 400, Height = 300)
    Form1

let edits = 
    let Edit1 = new TextBox(Text="10")
    let Edit2 = new TextBox(Top=20, Text="5")
    (Edit1, Edit2)

let buttons =
    let button1 = new Button(Text="+", Top=50, Width=25, Height=25)
    let button2 = new Button(Text="-", Top=50, Left=30, Width=25, Height=25)
    let button3 = new Button(Text="*", Top=50, Left=60, Width=25, Height=25)
    let button4 = new Button(Text="/", Top=50, Left=90, Width=25, Height=25)
    (button1, button2, button3, button4)

[<EntryPoint; STAThread>]
let main argv =
    let Form1 = forms
    let Edit1, Edit2 = edits
    let button1, button2, button3, button4 = buttons
    
    Form1.Controls.Add(Edit1)
    Form1.Controls.Add(Edit2)
    Form1.Controls.Add(button1)
    Form1.Controls.Add(button2)
    Form1.Controls.Add(button3)
    Form1.Controls.Add(button4)

    let Summ_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) + (int(Edit2.Text))), "Сумма") |>ignore
    let Minus_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) - (int(Edit2.Text))), "Разность") |>ignore
    let Umnoj_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) * (int(Edit2.Text))), "Умножение") |>ignore
    let Del_ = fun _ -> 
        try 
            let calculus = int(Edit1.Text)/ (int(Edit2.Text))
            MessageBox.Show(string(calculus), "Деление") |> ignore
        with ex -> (
            printfn "%A" ex;
            MessageBox.Show(ex.ToString(), "Div error:") |> ignore
            )

    let _ = button1.Click.Add(Summ_)
    let _ = button2.Click.Add(Minus_)
    let _ = button3.Click.Add(Umnoj_)
    let _ = button4.Click.Add(Del_)

    do Application.Run(Form1)
    0