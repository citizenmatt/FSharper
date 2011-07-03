namespace ActiveMesa.FSharper.Psi.FSharp.Tree

open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Psi.Tree

type IFSharpFile =
  inherit IFile
  inherit IFSharpTypeAndNamespaceHolderDeclaration
  inherit ITypeAndNamespaceHolderDeclaration
  inherit ITypeDeclarationHolder
  inherit INamespaceDeclarationHolder
  inherit IDeclarationsRangeContainer
  inherit IFSharpTreeNode
  inherit ITreeNode