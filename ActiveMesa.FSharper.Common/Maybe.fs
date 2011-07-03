module ActiveMesa.FSharper.Common.Monads

open System

type Maybe<'a> = option<'a>
 
let succeed x = Some(x)
let fail = None
//let bind p rest =
//  match p with
//    | None -> fail
//    | Some r -> rest r
let bind p rest =
  match p with
  | null -> null
  | r -> 
    try rest r
    with _ -> null
let delay f = f()
 
type MaybeBuilder() =
    member b.Return(x)  = succeed x
    member b.Bind(p, rest) = bind p rest
    member b.Delay(f)   = delay f
    member b.Let(p,rest) : Maybe<'a> = rest p
   
let maybe = MaybeBuilder()