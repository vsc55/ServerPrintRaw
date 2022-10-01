Imports LibCore

Module Programa

    Public Sub Main()
        Windows.Forms.Application.EnableVisualStyles()
        Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)

        AddHandler Application.ThreadException, AddressOf LibCore.Application_ThreadException
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf LibCore.CurrentDomain_UnhandledException

        AssemblyExe = Reflection.Assembly.GetExecutingAssembly
        AppModeRun = ModeRun.App
        ServiceName = ServerPrintRawService.ProjectInstaller.GetServiceName()

        logger.InfoFormat("Application: {0}", My.Application.Info.ProductName)
        logger.InfoFormat("Version: {0}", My.Application.Info.Version.ToString)

        If LibCore.PrevInstance() Then
            MsgBox("Apliacaion ya en ejecucion!", MsgBoxStyle.Information, "Aviso!")
            logger.Error("Apliacaion ya en ejecucion!")
            Application.Exit()
        Else
            'Throw New System.Exception("P^rueba")
            logger.Info("Starging Launcher")
            LibCore.App.Run()
        End If
    End Sub

End Module
