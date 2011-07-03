namespace ActiveMesa.FSharper.Feature.Services.FSharp.Generate

open JetBrains.ReSharper.Feature.Services.Generate
open JetBrains.ProjectModel
open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Tree
open JetBrains.IDE
open JetBrains.TextControl
open JetBrains.ActionManagement
open ActiveMesa.FSharper.Psi.FSharp.Tree
open ActiveMesa.FSharper.Psi.FSharp
open JetBrains.Application.DataContext

[<Language (typeof<FSharpLanguage>)>]
type FSharpGeneratorContextFactory =  
  interface IGeneratorContextFactory with

    member this.Create(kind, solution, textControl:ITextControl) =
      FSharpGeneratorContext.CreateContext(kind, solution, textControl)

    member this.Create(kind, declaration:ITypeDeclaration, anchor:ITreeNode) =
      FSharpGeneratorContext.CreateContext(kind, declaration :?> IClassLikeDeclaration, anchor)

    member this.Create(kind:string, context:IDataContext) = 
      let solution = context.GetData<ISolution>(JetBrains.ProjectModel.DataContext.DataConstants.SOLUTION)
      if solution = null then null
      else
        begin
          let textControl = context.GetData<ITextControl>(JetBrains.TextControl.DataContext.DataConstants.TEXT_CONTROL)
          if textControl = null then null
          else (this :> IGeneratorContextFactory).Create(kind, solution, textControl)
        end

    member this.IsKindAllowed(kind) = false
    
    