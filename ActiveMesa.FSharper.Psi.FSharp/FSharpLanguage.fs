namespace ActiveMesa.FSharper.Psi.FSharp

open JetBrains.ReSharper.Psi
open JetBrains.Annotations

/// F# language definition. Nothing useful here.
[<LanguageDefinition("FSHARP", Edition="Csharp")>]
// todo: check what Edition actually does
type FSharpLanguage(name, presentableName) =
  inherit KnownLanguage(name, presentableName)

  static let instance = lazy(FSharpLanguage())
  static member Instance = instance.Value

  public new([<NotNull>]name) = FSharpLanguage(name, "F#")
  public new() = FSharpLanguage("FSHARP", "F#")