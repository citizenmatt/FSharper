namespace ActiveMesa.FSharper.Feature.Services.FSharp.CodeStructure

open JetBrains.ReSharper.Feature.Services.CodeStructure
open JetBrains.ReSharper.Psi.Services

type FSharpCodeStructureDeclaredElement(parentElement, declaration, state) =
  inherit CodeStructureDeclarationElement(parentElement, declaration)

  let mutable myInheritanceInformation : InheritanceInformation = null

  // todo: lots more stuff