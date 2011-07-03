namespace ActiveMesa.FSharper.ProjectModel.Impl.Build

open JetBrains.ProjectModel.Impl.Build

type FSharpProjectConfiguration(project) =
  inherit ManagedProjectConfiguration(project)