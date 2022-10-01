Imports System.ServiceProcess

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceMain
    Inherits System.ServiceProcess.ServiceBase

    'UserService reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Punto de entrada principal del proceso
    <MTAThread()>
    <System.Diagnostics.DebuggerNonUserCode()>
    Shared Sub Main()
        'If Environment.UserInteractive Then
        '    Dim servideDebug As ServiceMain = New ServiceMain
        '    servideDebug.TestStartupAndStop()
        'Else

        '   <<< Codigo predetermindado del objeto >>>

        'End If

        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' Puede que más de un servicio de NT se ejecute con el mismo proceso. Para agregar
        ' otro servicio a este proceso, cambie la siguiente línea para
        ' crear un segundo objeto de servicio. Por ejemplo,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New ServiceMain}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)

    End Sub

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    ' NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    ' Se puede modificar usando el Diseñador de componentes.
    ' No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AppService = New System.Diagnostics.Process()
        '
        'AppService
        '
        Me.AppService.EnableRaisingEvents = True
        Me.AppService.StartInfo.CreateNoWindow = True
        Me.AppService.StartInfo.Domain = ""
        Me.AppService.StartInfo.LoadUserProfile = False
        Me.AppService.StartInfo.Password = Nothing
        Me.AppService.StartInfo.RedirectStandardError = True
        Me.AppService.StartInfo.RedirectStandardOutput = True
        Me.AppService.StartInfo.StandardErrorEncoding = Nothing
        Me.AppService.StartInfo.StandardOutputEncoding = Nothing
        Me.AppService.StartInfo.UserName = ""
        Me.AppService.StartInfo.UseShellExecute = False
        Me.AppService.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        '
        'ServiceMain
        '
        Me.CanShutdown = True
        Me.ServiceName = "ServiceMain"

    End Sub

    Private WithEvents AppService As Process
End Class
