namespace ActiveMesa.FSharper.Psi.FSharp.Tree

open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Tree

type IClassLikeDeclaration =
  inherit ITypeDeclarationWithRangeContainer
  inherit IDeclarationsRangeContainer
  inherit IFSharpTypeDeclaration
  inherit ITypeDeclaration
