namespace ActiveMesa.FSharper.Psi.FSharp.Impl

open System
open JetBrains.ReSharper.Psi
open ActiveMesa.FSharper.Psi.FSharp

[<Language (typeof<FSharpLanguage>)>]
type FSharpLanguageServiceImpl =
  inherit FSharpLanguageService

  new (fsharpLanguage) = { inherit FSharpLanguageService(fsharpLanguage) }

  override this.XmlDocFormatter = raise <| NotImplementedException()
  
  override this.CreateFilteringLexer lexer =
    raise <| NotImplementedException()

  override this.GetTokenReprByTokenType token =
    raise <| NotImplementedException()

  override this.GetTokenContentsText (tokenText, tokenType) =
    raise <| NotImplementedException()

  override this.CreateParser(lexer, solution, ``module``, sourceFile) =
    raise <| NotImplementedException()

  override this.IsFilteredNode node =
    raise <| NotImplementedException()

  override this.CacheProvider = raise <| NotImplementedException()

  override this.TypePresenter = raise <| NotImplementedException()

  override this.GetPrimaryLexerFactory() =
    raise <| NotImplementedException()

  override this.WordIndexLanguageProvider = null