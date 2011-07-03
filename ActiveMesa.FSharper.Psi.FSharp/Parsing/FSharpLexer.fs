namespace ActiveMesa.FSharper.Psi.FSharp.Parsing

open System
open JetBrains.ReSharper.Psi.Parsing

type FSharpLexer =
  interface ILexer with
    member this.Advance() = raise <| NotImplementedException()

    member this.Start() = raise <| NotImplementedException()

    member this.SaveState() = raise <| NotImplementedException()

    member this.RestoreState(state) = raise <| NotImplementedException()

    member this.TokenType = raise <| NotImplementedException()

    member this.TokenStart = raise <| NotImplementedException()

    member this.TokenEnd = raise <| NotImplementedException()

    member this.Buffer = raise <| NotImplementedException()

