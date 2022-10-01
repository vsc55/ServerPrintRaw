Option Strict On

Imports System.ComponentModel
Imports System.IO
Imports System.Net.Sockets
Imports System.Reflection

Namespace Core.Server.TCP

    Public Class Client
        Implements IDisposable

        Public Event OnAllGetString(sender As Client, strData As String)
        Public Event OnGetString(sender As Client, strData As String)
        Public Event OnComplete(sender As Client, e As RunWorkerCompletedEventArgs, srtData As String)
        Public Event OnStartRead(sender As Client)
        Public Event OnStopRead(sender As Client)
        Public Event OnDisposeBegin(sender As Client, disposing As Boolean)
        Public Event OnDisposeEnd(sender As Client, disposing As Boolean)

        Private WithEvents BWReadClient As New BackgroundWorker

        Private Status As Boolean = False
        Private Client As TcpClient = Nothing
        Private ClientData As NetworkStream = Nothing
        Private DataGet As String = ""


        Private IDCliente As String
        Private PublicIP As String

        Public ReadOnly Property GetID As String
            Get
                Return IDCliente
            End Get
        End Property

        Public ReadOnly Property PublicIPAddress() As String
            Get
                If PublicIP = String.Empty Then
                    Try
                        ' Get the clients IP address using Client property
                        Dim ipend As Net.IPEndPoint = CType(Client.Client.RemoteEndPoint, Net.IPEndPoint)
                        If Not ipend Is Nothing Then
                            PublicIP = ipend.Address.ToString
                        End If
                    Catch ex As System.ObjectDisposedException
                        PublicIP = String.Empty
                    Catch ex As SocketException
                        PublicIP = String.Empty
                    End Try
                End If
                Return PublicIP
            End Get
        End Property


        Public Sub New(ByVal newClient As TcpClient)
            If newClient Is Nothing Then
                Throw New ArgumentNullException("client")
            End If

            IDCliente = Guid.NewGuid().ToString("N")
            Try
                Client = newClient
                'logger.InfoFormat("{0} : Create Connection with {1}", Me.GetID, Me.PublicIP)
            Catch ex As Exception
                logger.Error(ex.Message, ex)
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub

        Public Sub StartRead()
            logger.DebugFormat("{0} : Start Read...", Me.GetID)
            RaiseEvent OnStartRead(Me)
            Try
                ClientData = Client.GetStream()

            Catch ex As Exception
                logger.Error(ex.Message, ex)
                Throw New Exception(ex.Message, ex)
            End Try

            If Not ClientData.CanRead Then
                Throw New Exception("Socket not allow read!!!")
            End If
            Status = True
            MyClass.BWReadClient.RunWorkerAsync()
        End Sub

        Public Sub StopRead()
            logger.DebugFormat("{0} : Stop Read...", Me.GetID)
            RaiseEvent OnStopRead(Me)
            Status = False
            If Not ClientData Is Nothing Then
                ClientData.Close()
                ClientData = Nothing
            End If
        End Sub

        Private Sub ClientRead(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BWReadClient.DoWork
            logger.DebugFormat("{0} : Reading...", Me.GetID)
            Dim bytes(1024) As Byte
            Dim i As Int32
            Try
                i = ClientData.Read(bytes, 0, bytes.Length)
                While (i <> 0 And Status = True)
                    Dim strData As String = System.Text.Encoding.Default.GetString(bytes, 0, i)
                    DataGet = DataGet & strData
                    RaiseEvent OnGetString(Me, strData)
                    i = ClientData.Read(bytes, 0, bytes.Length)
                    'logger.DebugFormat("{0}: i >> {1}", Me.GetID, i.ToString)
                End While
                RaiseEvent OnAllGetString(Me, DataGet)
            Catch ex As Exception
                logger.Error(ex.Message, ex)
            Finally
                logger.DebugFormat("{0} : Reading end", Me.GetID)
            End Try
        End Sub

        Private Sub ClientRead(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BWReadClient.RunWorkerCompleted
            RaiseEvent OnComplete(Me, e, DataGet)
            MyClass.Dispose()
        End Sub


        Private disposedValue As Boolean ' To detect redundant calls
        Private Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                logger.DebugFormat("{0} : Disposed Begin...", Me.GetID)
                RaiseEvent OnDisposeBegin(Me, disposing)
                If disposing Then
                    ' TODO: free unmanaged resources here

                    Call StopRead()
                    If Not Client Is Nothing Then
                        Client.Close()
                        Client = Nothing
                    End If

                End If
                ' TODO: free shared unmanaged resources
                RaiseEvent OnDisposeEnd(Me, disposing)
                logger.DebugFormat("{0} : Disposed End", Me.GetID)
            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code 
            ' in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

    End Class

End Namespace