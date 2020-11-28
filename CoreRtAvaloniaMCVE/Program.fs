module Program

open Gjallarhorn.Bindable
open Gjallarhorn.Bindable.Framework

type Model = { Value : int }
    
let initModel i = { Value = i }

type Msg = 
    | Increment 
    | Decrement

let update msg model =
    match msg with
    | Increment -> { Value = min 10 (model.Value + 1) }
    | Decrement -> { Value = max 0 (model.Value - 1) }

type ViewModel = 
    {
        Current : int 
        Increment : VmCmd<Msg>
        Decrement : VmCmd<Msg>
    }    

let d = { Current = 5 ; Increment = Vm.cmd Increment; Decrement = Vm.cmd Decrement }
         
let bindToSource =           
    Component.create [
        <@ d.Current    @> |> Bind.oneWay (fun m -> m.Value)
        <@ d.Increment  @> |> Bind.cmdIf (fun m -> m.Value < 10)
        <@ d.Decrement  @> |> Bind.cmdIf (fun m -> m.Value > 0)
    ]         

let applicationCore = Framework.application (initModel 5) update bindToSource Nav.empty
