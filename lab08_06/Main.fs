open FParsec
open System
 
let MailBoxAgent = MailboxProcessor.Start(
    fun inbox ->
        let rec messageLoop() = async{
            let! msg = inbox.Receive()
            if msg % 15 = 0 then Console.WriteLine($"{msg} - YES")
            else Console.WriteLine($"{msg} - NO")
            return! messageLoop()
        }
        messageLoop()
    )


[<EntryPoint>]
let main argv =
    for i in [1..150] do
        MailBoxAgent.Post(i)
    0 