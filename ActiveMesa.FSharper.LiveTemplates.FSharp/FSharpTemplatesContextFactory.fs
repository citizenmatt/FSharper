namespace ActiveMesa.FSharper.LiveTemplates.FSharp.Context

open System
open JetBrains.ReSharper.Feature.Services.LiveTemplates.Context
open JetBrains.Application

[<ShellComponent>]
type FSharpTemplateContextFactory =
  interface ITemplateContextFactory with
    member this.ReadFromXml element =
      match element with
      | null -> raise <| ArgumentNullException("element")
      | _ -> upcast FSharpTemplateContext.ReadFromXml(element)