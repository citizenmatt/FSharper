namespace ActiveMesa.FSharper.LiveTemplates.FSharp

open System
open System.Collections.Generic
open ActiveMesa.FSharper.LiveTemplates.FSharp.Context
open JetBrains.ReSharper.Feature.Services.LiveTemplates.Support
open JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder

/// Support for F# live templates.
type FSharpLiveTemplatesSupport() =
  let mutable mySurroundQuickListSupport = lazy(QuickListSupport("F# files", FSharpTemplateContext(FSharpInsertionPoint.Everywhere)))