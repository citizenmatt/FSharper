namespace ActiveMesa.FSharper.LiveTemplates.FSharp.Context

/// <summary>
/// Possible insertion points for F# live templates.
/// </summary>
[<System.Flags>]
type FSharpInsertionPoint =
  | Everywhere = 1
  | Expression = 2
  | Statement = 4
  | TypeMember = 8
  | TypeAndNamespace = 16
  | QueryClause = 32
 

 
