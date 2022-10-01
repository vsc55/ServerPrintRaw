Namespace Core

    Public Class Config

        Public Sub Reload()
            logger.Debug("Reload Config")
            My.Settings.Reload()
        End Sub

        Public Sub Save()
            logger.Debug("Save Config")
            My.Settings.Save()
        End Sub

        Public Sub ResetDefault()
            logger.Debug("Set Default Config")
            Me.Address = Me.DefaultAddress
            Me.Port = Me.DefaultPort
            Me.AutoStart = Me.DefaultAutoStart
            Me.Path = Me.DefaultPath
            Me.StorePrintTemplateID = Me.DefaultStorePrintTemplateID
            Me.RegexSearchID = Me.DefaultRegexSearchID
        End Sub


#Region "Prop::Address"
        Public Property Address As String
            Get
                Me.Reload()
                Dim sAddress As String = Trim(My.Settings.Address)

                If Not IsNothing(sAddress) OrElse sAddress <> String.Empty Then
                    Try
                        'Validamos si es una IP valdia
                        Net.IPAddress.Parse(sAddress)
                    Catch ex As Exception
                        logger.Error(String.Format("Error al cargar la ip ({0}): {1}", sAddress, ex.Message), ex)
                        sAddress = Nothing
                    End Try
                End If

                If IsNothing(sAddress) OrElse Not sAddress.GetType.Equals(GetType(String)) OrElse sAddress = String.Empty Then
                    sAddress = Me.DefaultAddress
                End If
                Return sAddress
            End Get
            Set(value As String)
                value = IIf(IsNothing(value), "", Trim(value))
                My.Settings.Address = IIf(value = "", Me.DefaultAddress, value)
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultAddress As String
            Get
                Return My.Settings.DefaultAddress
            End Get
        End Property
        Public Function GetAddress() As Net.IPAddress
            Return Net.IPAddress.Parse(Me.Address())
        End Function
        Public Sub SetAddress(value As Net.IPAddress)
            Me.Address = IIf(IsNothing(value), "", value.ToString)
        End Sub
#End Region

#Region "Prop::Port"
        Public Property Port As Integer
            Get
                Me.Reload()
                Dim iPort As Integer = My.Settings.Port
                If IsNothing(iPort) OrElse Not iPort.GetType.Equals(GetType(Integer)) OrElse iPort < 0 OrElse iPort > 65535 Then
                    iPort = Me.DefaultPort
                End If
                Return iPort
            End Get
            Set(value As Integer)
                My.Settings.Port = IIf(IsNothing(value), Me.DefaultPort, value)
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultPort As Integer
            Get
                Return My.Settings.DefaultPort
            End Get
        End Property
#End Region

#Region "Prop::AutoStart"
        Public Property AutoStart As Boolean
            Get
                Me.Reload()
                Dim bAutoStart As Boolean = My.Settings.AutoStart
                If IsNothing(bAutoStart) OrElse Not bAutoStart.GetType.Equals(GetType(Boolean)) Then
                    bAutoStart = Me.DefaultAutoStart
                End If
                Return bAutoStart
            End Get
            Set(value As Boolean)
                My.Settings.AutoStart = IIf(IsNothing(value), Me.DefaultAutoStart, value)
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultAutoStart As Boolean
            Get
                Return My.Settings.DefaultAutoStart
            End Get
        End Property
#End Region

#Region "Prop::Path"
        Public Property Path As String
            Get
                Me.Reload()
                Return My.Settings.Path
            End Get
            Set(value As String)
                My.Settings.Path = IIf(IsNothing(value), Me.DefaultPath, Trim(value))
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultPath As String
            Get
                Return String.Format("{0}\store", My.Application.Info.DirectoryPath)
            End Get
        End Property
#End Region

#Region "Prop::StorePrintTemplateID"
        Public Property StorePrintTemplateID As String
            Get
                Me.Reload()
                Dim sID As String = Trim(My.Settings.StorePrintTemplateID)
                If IsNothing(sID) OrElse Not sID.GetType.Equals(GetType(String)) OrElse sID = String.Empty Then
                    sID = Me.DefaultStorePrintTemplateID
                End If
                Return sID
            End Get
            Set(value As String)
                value = IIf(IsNothing(value), "", Trim(value))
                My.Settings.StorePrintTemplateID = IIf(value = String.Empty, Me.DefaultStorePrintTemplateID, value)
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultStorePrintTemplateID As String
            Get
                Return My.Settings.DefaultStorePrintTemplateID
            End Get
        End Property
#End Region

#Region "Prop::RegexSearchID"
        Public Property RegexSearchID As String
            Get
                Me.Reload()
                Dim sRegex As String = My.Settings.RegexSearchID
                If IsNothing(sRegex) OrElse Not sRegex.GetType.Equals(GetType(String)) Then
                    sRegex = Me.DefaultRegexSearchID
                End If
                Return sRegex
            End Get
            Set(value As String)
                value = IIf(IsNothing(value), "", value)
                My.Settings.RegexSearchID = value
                Me.Save()
            End Set
        End Property
        Public ReadOnly Property DefaultRegexSearchID As String
            Get
                Return My.Settings.DefaultRegexSearchID
            End Get
        End Property
#End Region

    End Class

End Namespace