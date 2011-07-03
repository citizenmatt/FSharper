namespace ActiveMesa.FSharper.Feature.Services.FSharp.CodeCompletion.Infrastructure

open JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure

[<AbstractClass>]
type FSharpItemsProviderBase =
  inherit ItemsProviderOfSpecificContext<FSharpCodeCompletionContext>