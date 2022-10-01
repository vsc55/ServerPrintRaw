Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace Core.Server.TCP

    Public Class Server
        Public Event OnGetString(sender As Server, client As Client, strData As String)
        Public Event OnAddClient(sender As Server, client As Client)
        Public Event OnDelClientBefore(sender As Server, client As Client)
        Public Event OnDelClientAfter(sender As Server, clientID As String)
        Public Event OnChangeListening(sender As Server, bNewStatus As Boolean)

        Private Socket As TcpListener = Nothing
        Private SocketThread As Thread = Nothing

        Public Port As Integer = 9100
        Public Addres As IPAddress = IPAddress.Any

        Private PoolClients As New Dictionary(Of String, Client)

#Region "Start"
        Public Function StartService() As Boolean
            Return MyClass.StartService(MyClass.Port)
        End Function

        Public Function StartService(nPort As Integer) As Boolean
            Return MyClass.StartService(nPort, MyClass.Addres)
        End Function

        Public Function StartService(nPort As Integer, addr As IPAddress)
            logger.Info("Starting...")
            MyClass.Port = nPort
            MyClass.Addres = addr
            Try
                Dim TcpSocket As TcpListener = New TcpListener(MyClass.Addres, MyClass.Port)
                Return MyClass.StartService(TcpSocket)
            Catch ex As Exception
                logger.Error(ex.Message, ex)
            End Try
            Return False
        End Function

        Private Function StartService(serverSocket As TcpListener) As Boolean
            Try
                MyClass.SocketThread = New Thread(New ThreadStart(AddressOf Listening)) With {
                    .IsBackground = True
                }
                MyClass.PoolClients.Clear()
                MyClass.Socket = serverSocket
                MyClass.Socket.Start()
                MyClass.IsListening = True
                MyClass.SocketThread.Start()

            Catch exSocket As System.Net.Sockets.SocketException
                Select Case exSocket.ErrorCode
                    Case 10048
                        logger.ErrorFormat("El puerto ({0}:{1}) ya esta en uso por otro programa!", Cfg.Address, Cfg.Port)
                        logger.Error("Starting Failed!")
                    Case Else
                        logger.Error(exSocket.Message, exSocket)
                        logger.Error("Starting Failed!")
                End Select
                MyClass.IsListening = False
                Return False

            Catch ex As Exception
                logger.Error(ex.Message, ex)
                logger.Info("Starting Failed!")
                MyClass.IsListening = False
                Return False
            End Try

            logger.Info("Starting Completed")
            Return True
        End Function
#End Region

#Region "Listenging"

        Public _IsListening As Boolean = False
        Public Property IsListening As Boolean
            Get
                Return Me._IsListening
            End Get
            Set(value As Boolean)
                If Me.IsListening = value Then Exit Property
                Me._IsListening = value
                RaiseEvent OnChangeListening(Me, value)
            End Set
        End Property


        Private Sub Listening()
            logger.InfoFormat("TcpListener ({0}:{1})", MyClass.Addres.ToString, MyClass.Port.ToString)
            'Try
            '    MyClass.Socket.Start()

            'Catch exSocket As System.Net.Sockets.SocketException
            '    logger.Error(exSocket.Message, exSocket)
            '    Return

            'Catch ex As Exception
            '    logger.Error(ex.Message, ex)
            '    Return

            'End Try


            Do Until MyClass.IsListening = False
                If MyClass.Socket.Pending = True Then
                    Try
                        Dim Client As New Client(Socket.AcceptTcpClient())
                        AddHandler Client.OnAllGetString, AddressOf OnGetStringClient
                        AddHandler Client.OnDisposeEnd, AddressOf OnDisposeEndClient
                        logger.InfoFormat("Conexion Accepted from {0}, id ({1})", Client.PublicIPAddress, Client.GetID)
                        Me.PoolClients.Add(Client.GetID, Client)
                        RaiseEvent OnAddClient(Me, Client)
                        Client.StartRead()
                    Catch ex As Exception
                        logger.Error(ex.Message, ex)
                    End Try
                Else
                    Thread.Sleep(100)
                End If
                Application.DoEvents()
            Loop
            'TODO: Mirar si hay clientes activos y cerrar las conexiones.
            'MyClass.StopService()
        End Sub

        Private Sub OnDisposeEndClient(ByVal sender As Client, ByVal disposing As Boolean)
            RemoveHandler sender.OnAllGetString, AddressOf OnGetStringClient
            RemoveHandler sender.OnDisposeEnd, AddressOf OnDisposeEndClient

            RaiseEvent OnDelClientBefore(Me, sender)
            Dim sID As String = sender.GetID
            PoolClients.Remove(sID)
            RaiseEvent OnDelClientAfter(Me, sID)
        End Sub

        Private Sub OnGetStringClient(ByVal sender As Client, ByVal msg As String)
            RaiseEvent OnGetString(Me, sender, msg)
        End Sub

#End Region


#Region "Stop"
        Public Function StopService()
            logger.Info("Stopping Service Begin...")
            MyClass.IsListening = False
            If Not IsNothing(MyClass.Socket) Then
                Try
                    Socket.Stop()
                Catch ex As Exception
                    logger.Error(ex.Message, ex)
                Finally
                    Socket = Nothing
                    SocketThread = Nothing
                End Try
            End If
            logger.Info("Stopping Service Completed")
            Return True
        End Function
#End Region


        Public Function GetClientCount() As Integer
            Return Me.PoolClients.Keys.Count
        End Function

        Public Function GetClientList() As Dictionary(Of String, Client)
            Return Me.PoolClients
        End Function

        Public Function GetClientListKeys() As List(Of String)
            Return New List(Of String)(Me.PoolClients.Keys)
        End Function

        Public Function GetClient(ByVal sKey As String) As Client
            If Me.PoolClients.ContainsKey(sKey) Then
                Return Me.PoolClients.Item(sKey)
            End If
            Return Nothing
        End Function

    End Class

End Namespace

'https://www.vbforums.com/showthread.php?784165-RESOLVED-Need-help-with-TCP-Server-Client-Simple-Chat-Application!!!
'https://stackoverflow.com/questions/29946469/how-to-politely-stop-a-tcplistener