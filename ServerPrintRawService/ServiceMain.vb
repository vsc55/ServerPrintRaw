Imports LibCore
Imports LibCore.modGlobal

Public Class ServiceMain

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf LibCore.CurrentDomain_UnhandledException
        LibCore.AssemblyExe = Reflection.Assembly.GetExecutingAssembly
        AppModeRun = ModeRun.Service
        ServiceName = ProjectInstaller.GetServiceName()

        logger.InfoFormat("Application: {0}", My.Application.Info.ProductName)
        logger.InfoFormat("Version: {0}", My.Application.Info.Version.ToString)


        'Throw New System.Exception("P^rueba")



        'If LibCore.PrevInstance() Then
        '    'MsgBox("Apliacaion ya en ejecucion!", MsgBoxStyle.Information, "Aviso!")
        '    logger.Error("Apliacaion ya en ejecucion!")
        '    Me.ExitCode = 1000
        'End If

    End Sub

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Agregue el código aquí para iniciar el servicio. Este método debería poner
        ' en movimiento los elementos para que el servicio pueda funcionar.
        logger.Debug("OnStart Begin")


        logger.Info("Starging Launcher")
        LibCore.App.RunService()



        logger.Debug("OnStart End")
    End Sub

    Protected Overrides Sub OnStop()
        ' Agregue el código aquí para realizar cualquier anulación necesaria para detener el servicio.
        logger.Debug("OnStop Begin")


        LibCore.App.StopService()


        logger.Debug("OnStop End")
    End Sub



    Friend Sub TestStartupAndStop()
        Dim args() As String = Nothing

        Me.OnStart(args)
        Console.ReadLine()
        Stop
        Me.OnStop()
    End Sub

End Class
