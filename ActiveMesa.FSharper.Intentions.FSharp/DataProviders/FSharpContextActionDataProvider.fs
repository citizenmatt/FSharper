namespace ActiveMesa.FSharper.Intentions.FSharp.DataProviders

open ActiveMesa.FSharper.Psi.FSharp.Tree
open JetBrains.ReSharper.Intentions
open JetBrains.ReSharper.Feature.Services.Bulbs

type FSharpContextActionDataProvider(solution, textControl, file) =
  inherit CachedContextActionDataProviderBase<IFSharpFile>(solution, textControl, file)
  interface IFSharpContextActionDataProvider
