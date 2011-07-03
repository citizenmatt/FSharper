namespace ActiveMesa.FSharper.Psi.FSharp.Tree

open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Tree

type IFSharpTypeAndNamespaceHolderDeclaration =
  inherit ITypeAndNamespaceHolderDeclaration
  inherit ITypeDeclarationHolder
  inherit INamespaceDeclarationHolder
  inherit IDeclarationsRangeContainer
  inherit IFSharpTreeNode
  inherit ITreeNode
