namespace ActiveMesa.FSharper.Daemon.FSharp.Stages

open System
open JetBrains.ReSharper.Psi
open JetBrains.ReSharper.Daemon.Stages
open JetBrains.Util
open ActiveMesa.FSharper.Psi.FSharp
open ActiveMesa.FSharper.Psi.FSharp.Tree

type retType = Pair<IgnoreWarningsRegionsInfo, Object>

[<FileStructureCollector>]
type FSharpFileStructureCollector =
  interface IFileStructureCollector with 
    member this.Run(theProcess, psiSourceFile) =
      let file = psiSourceFile.GetPsiFile(FSharpLanguage.Instance) :?> IFSharpFile
      let mutable result:Nullable<retType> = Unchecked.defaultof<Nullable<retType>>
      if file <> Unchecked.defaultof<IFSharpFile> then
        let collector = FSharpFileStructure(theProcess, file)
        result <- Nullable<retType>(retType(collector.IgnoreWarningsRegionsInfo, collector))
      result

  public new() = {}