namespace ActiveMesa.FSharper.Intentions.FSharp.DataProviders

open JetBrains.ReSharper.Feature.Services.Bulbs
open ActiveMesa.FSharper.Psi.FSharp.Tree

type IFSharpContextActionDataProvider =
  inherit IContextActionDataProvider<IFSharpFile>