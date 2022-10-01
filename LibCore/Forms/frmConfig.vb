Imports System.Net
Imports System.Security

Public Class frmConfig

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsServiceRun() Then
            Dim altura As Integer = TableLayoutMain.RowStyles.Item(1).Height
            TableLayoutMain.RowStyles.Item(1).Height = 0
            Me.Height = Me.Height - altura
        End If

        Call RefreshListAddress()
        Call LoadConfig()
        Call UpdateStatusButton()
    End Sub

    Private Sub LoadConfig()
        Me.sTxtIPAddress.Text = Cfg.Address
        Me.iTxtPort.Value = Cfg.Port
        Me.sTxtPath.Text = Cfg.Path
        Me.chkAutoStart.Checked = Cfg.AutoStart
        Me.sRegExGetID.Text = Cfg.RegexSearchID
    End Sub

    Private Sub SaveConfig()
        Cfg.Address = CType(sTxtIPAddress.Text, String)
        Cfg.Port = CType(iTxtPort.Value, Integer)
        Cfg.Path = CType(sTxtPath.Text, String)
        Cfg.AutoStart = CType(chkAutoStart.Checked, Boolean)
        Cfg.RegexSearchID = CType(sRegExGetID.Text, String)
        Cfg.Save()
    End Sub

    Private Sub RefreshListAddress()
        Dim obj As ComboBox = Me.sTxtIPAddress

        Dim strHostName As String = Dns.GetHostName()
        Dim addresses As IPAddress() = Dns.GetHostEntry(strHostName).AddressList
        obj.Items.Clear()
        obj.Items.Add(IPAddress.Any.ToString)
        For Each address As IPAddress In addresses
            If address.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                obj.Items.Add(address)
            End If
            logger.Debug(String.Format("{0} = {1} ({2})", strHostName, address, address.AddressFamily))
        Next
    End Sub

    Private Sub SelectFolder()
        Dim obj As TextBox = Me.sTxtPath

        Try
            Dim sFolderActual As String = Cfg.Path
            Dim sFoler As New FolderBrowserDialog()
            With sFoler
                .Reset()
                .Description = " Seleccionar una carpeta para guardar los archivos "
                If (IO.Directory.Exists(sFolderActual)) Then
                    .SelectedPath = sFolderActual
                Else
                    .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
                End If
                .ShowNewFolderButton = True
                '.RootFolder = Environment.SpecialFolder.Desktop

                Dim ret As DialogResult = .ShowDialog
                If ret = Windows.Forms.DialogResult.OK Then
                    obj.Text = .SelectedPath
                End If
                .Dispose()
            End With

        Catch oe As Exception
            logger.Error(oe.Message, oe)
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StartStopService(ByVal bAction As Boolean, Optional ByVal bForce As Boolean = False)
        If Not IsServiceRun() Then
            If bAction Then
                If rServer.IsListening = True And bForce = True Then
                    Call StartStopService(False)
                End If
                If bForce Or rServer.IsListening = False Then
                    Call App.ConfigureServer()
                    If App.StartService() = False Then
                        MsgBox("Error al iniciar el servicio!", MsgBoxStyle.Exclamation, "Error!")
                    End If
                End If
            Else
                If bForce Or rServer.IsListening = True Then
                    App.StopService()
                End If
            End If
        End If
        Call UpdateStatusButton()
    End Sub

    Private Sub UpdateStatusButton()
        Call SetStatusButton(0)
        If Not IsServiceRun() Then
            If rServer.IsListening Then
                Call SetStatusButton(2)
            Else
                Call SetStatusButton(1)
            End If
        End If
    End Sub

    Private Sub SetStatusButton(ByVal sNewStatus As Integer)
        Select Case sNewStatus
            Case 0
                Me.btnServiceStart.Enabled = False
                Me.btnServiceStop.Enabled = False
                Me.btnServiceReload.Enabled = False
            Case 1
                Me.btnServiceStart.Enabled = True
                Me.btnServiceStop.Enabled = False
                Me.btnServiceReload.Enabled = False

            Case 2
                Me.btnServiceStart.Enabled = False
                Me.btnServiceStop.Enabled = True
                Me.btnServiceReload.Enabled = True

            Case Else
                Call SetStatusButton(0)

        End Select
    End Sub


    Private Sub btnSelectPath_Click(sender As Object, e As EventArgs) Handles btnSelectPath.Click
        Call SelectFolder()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
        Call SaveConfig()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Call LoadConfig()
    End Sub

    Private Sub sTxtPath_TextChanged(sender As Object, e As EventArgs) Handles sTxtPath.TextChanged
        Dim obj As TextBox = Me.sTxtPath
        With obj
            If IO.Directory.Exists(.Text) Then
                .BackColor = System.Drawing.SystemColors.Window
                .ForeColor = System.Drawing.SystemColors.WindowText
            Else
                .BackColor = System.Drawing.Color.Salmon
                .ForeColor = System.Drawing.Color.Indigo
            End If
        End With
    End Sub

    Private Sub btnServiceStart_Click(sender As Object, e As EventArgs) Handles btnServiceStart.Click
        Call StartStopService(True)
    End Sub

    Private Sub btnServiceStop_Click(sender As Object, e As EventArgs) Handles btnServiceStop.Click
        Call StartStopService(False)
    End Sub

    Private Sub btnServiceReload_Click(sender As Object, e As EventArgs) Handles btnServiceReload.Click
        Call StartStopService(False)
        Call StartStopService(True)
    End Sub

    Private Sub btnTestRegExGetID_Click(sender As Object, e As EventArgs) Handles btnTestRegExGetID.Click
        Dim inputTest As String = InputBox("Texto Prueba:", "RegEx Test", "")
        Dim returnTest As String = rStorePrint.FindID(Me.sRegExGetID.Text, inputTest)
        Me.lResultTestRegEx.Text = String.Format("Resultado: {0}", IIf(returnTest = String.Empty, "Vacia", returnTest))
    End Sub




    Private Sub btnDefaultPort_Click(sender As Object, e As EventArgs) Handles btnDefaultPort.Click
        Me.iTxtPort.Value = Cfg.DefaultPort
    End Sub

    Private Sub btnDefaultIP_Click(sender As Object, e As EventArgs) Handles btnDefaultIP.Click
        Me.sTxtIPAddress.Text = Cfg.DefaultAddress
    End Sub

    Private Sub btnDefaultAutoStart_Click(sender As Object, e As EventArgs) Handles btnDefaultAutoStart.Click
        Me.chkAutoStart.Checked = Cfg.DefaultAutoStart
    End Sub

    Private Sub btnDefaultPath_Click(sender As Object, e As EventArgs) Handles btnDefaultPath.Click
        Me.sTxtPath.Text = Cfg.DefaultPath
    End Sub

    Private Sub btnDefaultRegEx_Click(sender As Object, e As EventArgs) Handles btnDefaultRegEx.Click
        Me.sRegExGetID.Text = Cfg.DefaultRegexSearchID
    End Sub

End Class