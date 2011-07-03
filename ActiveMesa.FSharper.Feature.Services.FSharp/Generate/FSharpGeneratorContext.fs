namespace ActiveMesa.FSharper.Feature.Services.FSharp.Generate

open System
open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Tree
open JetBrains.ReSharper.Feature.Services.Generate
open JetBrains.ReSharper.Psi.Services
open ActiveMesa.FSharper.Psi.FSharp
open ActiveMesa.FSharper.Psi.FSharp.Tree

type FSharpGeneratorContext =

  [<DefaultValue>] val mutable myAnchor : ITreeNode
  [<DefaultValue>] val mutable classDeclaration : ITreeNode // todo: change type

  public new(kind, anchor:ITreeNode, classDeclaration) =
    {
      inherit GeneratorContextBase(kind, anchor.GetSourceFile())
    }

  inherit GeneratorContextBase

    override this.Language with get() = FSharpLanguage.Instance :> PsiLanguageType

    override this.Root
      with get() = raise <| NotImplementedException()

    override this.PsiModule with get() = this.classDeclaration.GetPsiModule()

    override this.Anchor
      with get() = this.myAnchor
      and set(v) = this.myAnchor <- v

    override this.Project with get() = this.classDeclaration.GetProject()

    override this.GetSelectionTreeRange() =
      TreeTextRange.InvalidRange // todo, obviously
   
  static member CreateContext(kind, solution, textControl) : IGeneratorContext =
    let (declaration, anchor) = TextControlToPsi.GetElement<IClassLikeDeclaration>(solution, textControl)
    if box declaration = null || declaration.DeclaredElement = null
    then Unchecked.defaultof<IGeneratorContext>
    else upcast new FSharpGeneratorContext(kind, anchor, declaration)

  static member CreateContext(kind, declaration:IClassLikeDeclaration, anchor) : IGeneratorContext =
    if box declaration = null || declaration.DeclaredElement = null
    then Unchecked.defaultof<IGeneratorContext>
    else upcast new FSharpGeneratorContext(kind, anchor, declaration)