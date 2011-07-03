namespace ActiveMesa.FSharper.Intentions.FSharp.DataProviders

open ActiveMesa.FSharper.Psi.FSharp
open ActiveMesa.FSharper.Psi.FSharp.Tree
open JetBrains.ReSharper.Feature.Services.Bulbs
open JetBrains.ReSharper.Psi.Caches
open JetBrains.ReSharper.Psi

type FSharpContextActionDataBuilder =
  interface IContextActionDataBuilder with
    member this.Build(solution, textControl) =
      if CacheManager.GetInstance(solution).IsIdle then 
        begin
          let projectFile = textControl.Document.GetPsiSourceFile(solution)
          if (projectFile = null) || (not(projectFile.IsValid())) then null
          else
            begin
              match projectFile.GetPsiFile(FSharpLanguage.Instance) with
              | :? IFSharpFile as psiFile ->
                if psiFile.IsValid() && psiFile.Language.Equals(FSharpLanguage.Instance)
                then upcast FSharpContextActionDataProvider(solution, textControl, psiFile)
                else null
              | _ -> null
            end
        end
      else null
