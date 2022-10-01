
Namespace Core

    Public Class TrayIcon
        Inherits ApplicationContext

#Region " Storage "

        Private WithEvents Tray As NotifyIcon
        Private WithEvents MainMenu As ContextMenuStrip
        Private WithEvents MnuDisplayForm As ToolStripMenuItem
        Private WithEvents MnuDisplayFrmConfig As ToolStripMenuItem
        Private WithEvents MnuDisplayFrmAboutBox As ToolStripMenuItem
        Private WithEvents MnuStatus As ToolStripMenuItem
        Private WithEvents MnuExit As ToolStripMenuItem

#End Region

#Region " Constructor "

        Public Sub New()

            AddHandler rServer.OnChangeListening, AddressOf UpdateIcon

            MnuDisplayForm = New ToolStripMenuItem("Gestión Archivos")
            MnuDisplayFrmConfig = New ToolStripMenuItem("Configuración")
            MnuDisplayFrmAboutBox = New ToolStripMenuItem("Acerca de...")
            MnuStatus = New ToolStripMenuItem("Status")
            MnuExit = New ToolStripMenuItem("Cerrar Servidor")

            MainMenu = New ContextMenuStrip
            MainMenu.Items.AddRange(New ToolStripItem() {
                                        MnuDisplayForm,
                                        New ToolStripSeparator(),
                                        MnuDisplayFrmConfig,
                                        New ToolStripSeparator(),
                                        MnuStatus,
                                        New ToolStripSeparator(),
                                        MnuDisplayFrmAboutBox,
                                        New ToolStripSeparator(),
                                        MnuExit
                                    })

            Tray = New NotifyIcon With {
                .Icon = My.Resources.TrayIcon,
                .ContextMenuStrip = MainMenu,
                .Text = "Servidor Impresora Raw",
                .Visible = True
            }

            Call CallUpdateInfo()
            logger.Debug("Inicio TrayIcon Completo.")
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
            RemoveHandler rServer.OnChangeListening, AddressOf UpdateIcon
        End Sub

        Public Sub CallUpdateInfo()
            Call Me.UpdateIcon(rServer, IIf(IsNothing(rServer), False, rServer.IsListening))
        End Sub

        Public Sub UpdateIcon(server As LibCore.Core.Server.TCP.Server, newStatus As Boolean)

            If IsNothing(server) Then
                Tray.Icon = My.Resources.TrayIcon
            Else
                If IsServiceRun() Then
                    Tray.Icon = My.Resources.TrayIcon_Service
                Else
                    If newStatus Then
                        Tray.Icon = My.Resources.TrayIcon_Run
                    Else
                        Tray.Icon = My.Resources.TrayIcon_Stop
                    End If
                End If
            End If
        End Sub

#End Region

#Region " Event handlers "

        Private Sub MainMenu_Open(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainMenu.Opening
            Call CallUpdateInfo()

            Dim sNewTxt As String
            Dim bIsEnabled As Boolean = True
            Dim bIsRun As Boolean = True

            If IsServiceRun() Then
                sNewTxt = "Iniciado - Modo Servicio"
                bIsEnabled = False
            Else
                If rServer.IsListening Then
                    sNewTxt = "Iniciado"
                Else
                    sNewTxt = "Detenido"
                    bIsRun = False
                End If
            End If

            MnuStatus.Text = String.Format("Estado: {0}", sNewTxt)
            MnuStatus.Enabled = bIsEnabled
            MnuStatus.Checked = bIsRun
        End Sub

        Private Sub AppContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ThreadExit
            'Guarantees that the icon will not linger.
            Tray.Visible = False
        End Sub

        Private Sub MnuStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuStatus.Click
            If Not IsServiceRun() Then
                If rServer.IsListening Then
                    App.StopService()
                Else
                    App.StartService()
                End If
            End If
        End Sub

        Private Sub MnuDisplayForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDisplayForm.Click
            App.ShowDialog()
        End Sub

        Private Sub MnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuExit.Click
            App.ExitApplication()
        End Sub

        Private Sub Tray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.DoubleClick
            App.ShowDialog()
        End Sub

        Private Sub MnuDisplayFrmConfig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDisplayFrmConfig.Click
            App.ShowDialogConfig()
        End Sub

        Private Sub MnuDisplayFrmAboutBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDisplayFrmAboutBox.Click
            App.ShowDialogAboutBox()
        End Sub

#End Region

    End Class

End Namespace