namespace ActiveMesa.FSharper.Feature.Services.FSharp.CodeCompletion.Infrastructure

open JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure

type FSharpCodeCompletionContext =
  inherit SpecificCodeCompletionContext

  override this.ContextId = "FSharpCompletionContext"