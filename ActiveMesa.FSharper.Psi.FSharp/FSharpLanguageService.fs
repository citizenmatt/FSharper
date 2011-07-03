namespace ActiveMesa.FSharper.Psi.FSharp

open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.CodeStyle

[<AbstractClass>]
type FSharpLanguageService =
  inherit LanguageService

  public new (fsharpLanguage:FSharpLanguage) = { inherit LanguageService(fsharpLanguage) }

  abstract XmlDocFormatter:ICodeFormatter with get