open System

open Gjallarhorn.Avalonia
open Avalonia

[<CompiledName "BuildAvaloniaApp">] 
let buildAvaloniaApp () = AppBuilder.Configure<Views.App>().UsePlatformDetect()

let app () = buildAvaloniaApp().SetupWithoutStarting().Instance

[<EntryPoint>]
let main _ = 
    Framework.RunApplication (Navigation.singleView app Views.MainWindow, Program.applicationCore)
    1
