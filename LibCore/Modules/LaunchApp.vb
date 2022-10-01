Imports LibCore.Core
Namespace App
    Public Module LaunchApp

        Public Sub Run()
            logger.InfoFormat("Core: {0} ({1})", AssemblyLib.GetName().Name, AssemblyLib.GetName().Version.ToString)
            Call App.InitServer()

            If IsServiceRun() Then
                logger.Info("Service Print is Running, start mode GUI")
            Else
                logger.InfoFormat("AutoStart: {0}", IIf(Cfg.AutoStart, "ON", "OFF"))
                If Cfg.AutoStart Then
                    Call App.StartService()
                End If
            End If

            logger.Info("Starging TrayIcon")
            Application.Run(New TrayIcon)
        End Sub

        Public Sub RunService()
            logger.InfoFormat("Core: {0} ({1})", AssemblyLib.GetName().Name, AssemblyLib.GetName().Version.ToString)
            Call App.InitServer()
            Call App.StartService()
        End Sub

        Private Sub InitServer()
            logger.Info("Preparing service...")
            rServer = New Server.TCP.Server()
            AddHandler rServer.OnGetString, AddressOf ProcesarDatos

            logger.Info("Preparing Store...")
            rStorePrint = New Store.StorePrint()

            logger.Info("Configuring service...")
            Call App.ConfigureServer()
        End Sub


        Public Sub ConfigureServer()
            rServer.Port = Cfg.Port()
            rServer.Addres = Cfg.GetAddress()

            rStorePrint.PathStore = Cfg.Path()
            rStorePrint.TemplateID = Cfg.StorePrintTemplateID()
            rStorePrint.IDRefSearch = Cfg.RegexSearchID()
        End Sub

        Public Sub ShowDialog()
            If KernelF IsNot Nothing AndAlso Not KernelF.IsDisposed Then Exit Sub

            Dim CloseApp As Boolean = False

            KernelF = New frmKernel
            KernelF.ShowDialog()
            CloseApp = (KernelF.DialogResult = DialogResult.Abort)
            KernelF = Nothing

            If CloseApp Then ExitApplication()
        End Sub

        Public Sub ShowDialogConfig()
            If ConfigF IsNot Nothing AndAlso Not ConfigF.IsDisposed Then Exit Sub
            ConfigF = New frmConfig
            ConfigF.ShowDialog()
            Select Case ConfigF.DialogResult
                Case DialogResult.OK

                Case DialogResult.Cancel

                Case Else

            End Select
            ConfigF = Nothing
        End Sub

        Public Sub ShowDialogAboutBox()
            Using AboutBoxF As New frmAboutBox
                'Using AboutBoxF As New frmPruebas
                AboutBoxF.ShowDialog()
            End Using
        End Sub

        Public Sub ExitApplication()
            Cfg.Save()
            Application.Exit()
        End Sub

        Public Sub ProcesarDatos(server As Server.TCP.Server, client As Server.TCP.Client, msg As String)
            logger.DebugFormat("{0} - Se envia a procesar a Store...", client.GetID)
            rStorePrint.SavePrint(msg, client.GetID)

            If KernelF IsNot Nothing AndAlso Not KernelF.IsDisposed Then
                KernelF.RecargarListaArchivos()
            End If

        End Sub

        Public Function StartService() As Boolean
            If Not IsServiceRun() Then
                If Not IO.Directory.Exists(Cfg.Path) Then
                    logger.ErrorFormat("No se ha podido iniciar servidor, directorio no valido ({0})!", Cfg.Path)
                    Return False
                End If
                Return rServer.StartService()
            End If
            Return True
        End Function

        Public Function StopService() As Boolean
            rServer.StopService()
            Return True
        End Function

    End Module
End Namespace