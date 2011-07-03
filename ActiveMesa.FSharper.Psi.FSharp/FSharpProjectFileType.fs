namespace ActiveMesa.FSharper.Psi.FSharp

open JetBrains.ProjectModel

type FSharpProjectFileType(name, presentableName, extensions) =
  inherit ProjectFileType(name, presentableName, extensions)

  static let langName = "FSHARP"
  static let langPName = "F#"
  static let langExtensions = [|".fs"; ".fsi"; ".ml"; ".mli"; ".fsx"; ".fsscript"|]

  static let instance = lazy(FSharpProjectFileType())
  static member Instance = instance.Value

  private new() = 
    FSharpProjectFileType(langName, langPName, langExtensions)

  public new(name) =
    FSharpProjectFileType(name, langPName, langExtensions)

  public new(name, presentableName) =
    FSharpProjectFileType(name, presentableName, langExtensions)
  