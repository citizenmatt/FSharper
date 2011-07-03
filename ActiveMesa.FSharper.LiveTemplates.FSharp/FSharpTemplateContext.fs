namespace ActiveMesa.FSharper.LiveTemplates.FSharp.Context

open System
open System.Xml
open System.Collections.Generic
open JetBrains
open JetBrains.ReSharper.Feature.Services.LiveTemplates.Context

type FSharpTemplateContext(insertionContext, minimumLanguageVersion) =
  inherit TemplateContext()

  static let contextAttributeName = "context"
  static let minimumLanguageVersionAttributeName = "minimumLanguageVersion"
  
  let myInsertionPoint:FSharpInsertionPoint = insertionContext
  let myMinimumLanguageVersion:Version = minimumLanguageVersion

  public new(insertionContext) = FSharpTemplateContext(insertionContext, System.Version(2,0))

  override this.WriteToXml(element) =
    raise <| NotImplementedException()

  static member ReadFromXml (element:XmlElement) : FSharpTemplateContext =
    match element with
    | null -> raise <| ArgumentNullException("element")
    | _ -> match element.Name with
      | "FSharpContext" -> Unchecked.defaultof<FSharpTemplateContext> // null
      | _ ->
        let insertionPoint = element.Attributes.[contextAttributeName].Value.ToEnum<FSharpInsertionPoint>()
        match element.HasAttribute(minimumLanguageVersionAttributeName) with
        | false -> new FSharpTemplateContext(insertionPoint)
        | true -> new FSharpTemplateContext(insertionPoint, new Version(element.Attributes.[minimumLanguageVersionAttributeName].Value))

  override this.ScopePoints = Seq.empty