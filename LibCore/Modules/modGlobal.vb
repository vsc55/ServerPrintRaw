Imports System.Reflection
Imports System.Runtime
Imports System.ServiceProcess
Imports System.Threading
Imports LibCore.Core
Imports log4net

Public Module modGlobal

    Public Enum ModeRun
        None = 0
        App = 1
        Service = 2
    End Enum


    Public logger As log4net.ILog = LogManager.GetLogger("Lib")
    Public WithEvents rServer As Server.TCP.Server
    Public rStorePrint As Store.StorePrint
    Public Cfg As New Config
    Public ServiceName As String = ""
    Public KernelF As frmKernel
    Public ConfigF As frmConfig
    Public AppModeRun As ModeRun = ModeRun.None

    Public ReadOnly Property IsRun64 As Boolean
        Get
            Return IIf(System.IntPtr.Size = 8, True, False)
        End Get
    End Property

    Public ReadOnly Property IsRun32 As Boolean
        Get
            Return IIf(System.IntPtr.Size = 4, True, False)
        End Get
    End Property


    Public Property AssemblyExe As Reflection.Assembly = Nothing
    Public Property AssemblyLib As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

    Public Function PrevInstance() As Boolean
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then Return True
        Return False
    End Function

    Public Sub Application_ThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
        logger.Error(e.Exception.Message, e.Exception)
    End Sub

    Public Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        logger.Error((TryCast(e.ExceptionObject, Exception)).Message, e.ExceptionObject)
    End Sub

    Public Function IsServiceRun() As Boolean
        Dim bReturn As Boolean = False
        If (ServiceName <> String.Empty) Then
            For Each service As ServiceController In ServiceController.GetServices()
                If service.ServiceName = ServiceName Then
                    If (service.Status <> ServiceProcess.ServiceControllerStatus.Stopped) Then
                        bReturn = True
                    End If
                    Exit For
                End If
            Next
        End If
        Return bReturn
    End Function

    Public Function IsServiceInstalled() As Boolean
        Dim bReturn As Boolean = False
        If (ServiceName <> String.Empty) Then
            For Each service As ServiceController In ServiceController.GetServices()
                If service.ServiceName = ServiceName Then
                    bReturn = True
                    Exit For
                End If
            Next
        End If
        Return bReturn
    End Function

    Public Function GetService() As ServiceController
        Return IIf(IsServiceInstalled(), New System.ServiceProcess.ServiceController(ServiceName), Nothing)
    End Function

End Module
