namespace ActiveMesa.FSharper.Daemon.FSharp.Stages

open JetBrains.ReSharper.Daemon
open JetBrains.ReSharper.Daemon.Stages
open ActiveMesa.FSharper.Psi.FSharp.Tree

type FSharpFileStructure(daemonProcess, file) =
  let myDaemonProcess:IDaemonProcess = daemonProcess
  let myFile:IFSharpFile = file

  member this.IgnoreWarningsRegionsInfo
    with get():IgnoreWarningsRegionsInfo = null // todo