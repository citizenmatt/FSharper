namespace ActiveMesa.FSharper.Psi.FSharp.Impl

open System
open ActiveMesa.FSharper.ProjectModel
open ActiveMesa.FSharper.Psi
open ActiveMesa.FSharper.Psi.FSharp
open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Impl
open JetBrains.ReSharper.Psi.Parsing
open JetBrains.ProjectModel
open JetBrains.Util

type FSharpPsiProperties(projectFile, sourceFile) =
  inherit DefaultPsiProjectFileProperties(projectFile, sourceFile)

  override this.IsNonUserFile = 
    base.ProjectFile.GetProperties().BuildAction <> BuildAction.COMPILE

  override this.ProvidesCodeModel = 
    base.ProjectFile.GetProperties().BuildAction = BuildAction.COMPILE

[<ProjectFileType(typeof<FSharpProjectFileType>)>]
type FSharpProjectFileLanguageService() =
  interface IProjectFileLanguageService with
    member this.LanguageType = FSharpProjectFileType.Instance :> ProjectFileType

    member this.Icon = null // todo

    member this.GetPsiLanguageType(languageType:ProjectFileType) : PsiLanguageType =
      if languageType.Is<FSharpProjectFileType>()
      then upcast FSharpLanguage.Instance
      else upcast UnknownLanguage.Instance

    member this.GetPsiLanguageType(projectFile:IProjectFile) : PsiLanguageType =
      if projectFile.LanguageType.Is<FSharpProjectFileType>()
      then upcast FSharpLanguage.Instance
      else upcast UnknownLanguage.Instance

    member this.GetPsiProperties(projectFile, sourceFile) =
      upcast FSharpPsiProperties(projectFile, sourceFile)
    
    member this.GetPreprocessorDefines(project) =
      let instance = Array.empty<PreProcessingDirective>
      match project.ActiveConfiguration with
      | :? IFSharpProjectConfiguration as activeConfiguration ->
        let conditionalCompilationConstants = activeConfiguration.ConditionalCompilationConstants
        match String.IsNullOrEmpty(conditionalCompilationConstants) with
        | true -> instance
        | false ->
          let strArray = conditionalCompilationConstants.Split([|';'; ','; ' '|])
          [|for i in 0..strArray.Length-1 -> 
            PreProcessingDirective(strArray.[i].Trim(), String.Empty)|]
      | _ -> instance

    member this.GetMixedLexerFactory(buffer, sourceFile, manager) =
      LanguageManager.Instance.GetService<ILexerFactory>(FSharpLanguage.Instance)
