namespace ActiveMesa.FSharper.Feature.Services.FSharp.CodeStructure

open System
open System.Collections.Generic
open JetBrains.ReSharper.Feature.Services.CodeStructure
open JetBrains.DocumentModel
open ActiveMesa.FSharper.Psi.FSharp

type FSharpCodeStuctureAttribute(parentElement, attribute) =
  inherit CodeStructureElement(parentElement)
    override this.TreeNode = raise <| NotImplementedException()
    override this.Language = upcast FSharpLanguage.Instance
    override this.GetFileStructureAspect() = upcast this
    override this.GetGotoMemberAspect() = null
    override this.GetMemberNavigationAspect() = upcast this
    override this.GetTextRange() = raise <| NotImplementedException()
    override this.DumpSelf(builder) = raise <| NotImplementedException()

  interface IMemberNavigationAspect with
    member this.GetNavigationRanges() = [||]

  interface IFileStructureAspect with
    member this.CanMoveElements(location, dropElements) = false
    member this.CanRemove() = false
    member this.CanRename() = false
    member this.Present(presenter, item, modelNode, state) = ()
    member this.NavigationRange = raise <| NotImplementedException()
    member this.InitiallyExpanded = false
    member this.GetQuickSearchTexts() =
      upcast List<String>()
    member this.MoveElements(location, dropElements) = ()
    member this.Remove() = ()
    member this.InitialName() = raise <| NotSupportedException()
    member this.Rename(newName) = raise <| NotSupportedException()


