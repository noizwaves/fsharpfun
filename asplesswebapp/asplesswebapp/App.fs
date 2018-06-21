open Suave
open System

[<EntryPoint>]
let main _ =
    let port = Environment.GetEnvironmentVariable "PORT"
    let local = Suave.Http.HttpBinding.createSimple HTTP "0.0.0.0" (int port)
    let config = {defaultConfig with bindings = [local]}
    startWebServer config (Successful.OK "Hello World!")
    0
