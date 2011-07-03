namespace ActiveMesa.FSharper.Psi.FSharp.Parsing

open ActiveMesa.FSharper.Psi.FSharp.Tree
open JetBrains.ReSharper.Psi.Parsing
open JetBrains.ReSharper.Psi.Tree

type IFSharpParser =
  inherit IParser

  abstract member ParseCodeBlock : unit -> IBlock

  abstract member ParseExpression : unit -> IFSharpExpression

  abstract member ParseMemberDeclaration : unit -> ITreeNode

  abstract member ParseStatement : unit -> IFSharpStatement