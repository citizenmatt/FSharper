namespace ActiveMesa.FSharper.ProjectModel

open System
open JetBrains.ProjectModel
open JetBrains.Util

type IFSharpProjectConfiguration =
  inherit IManagedProjectConfiguration
  inherit IProjectConfiguration
  inherit IDisposable
  inherit IUserDataHolder