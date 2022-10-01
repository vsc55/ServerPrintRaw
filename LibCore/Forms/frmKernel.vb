Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports LibCore.CerebelumLib
Imports LibCore.Core.Server.TCP

Public Class frmKernel

    Private vColumnaOrden As ColumnHeader
    Private vOrden As SortOrder

    Public Sub New()
        MyBase.New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        'https://www.elguille.info/net/vs2005/trucos/acceder_a_un_control_desde_otro_hilo.htm
        'Desactivamos error que se produce al acceder a los controles desde otro hilo que no es el del formulario.
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Kernel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler rServer.OnAddClient, AddressOf UpdateCount
        AddHandler rServer.OnDelClientAfter, AddressOf UpdateCount
        Call LoadConfig()
    End Sub

    Private Sub Kernel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler rServer.OnAddClient, AddressOf UpdateCount
        RemoveHandler rServer.OnDelClientAfter, AddressOf UpdateCount
    End Sub


#Region "Sub/Functions"
    Private Sub UpdateCount(sender As Object, e As Object)
        Me.lClientesActivos.Text = String.Format("Clientes: {0}", rServer.GetClientCount())

        'Me.lDebugTest.Items.Clear()
        ''Dim list As Dictionary(Of String, Client) = rServer.GetClientList
        'For Each value As String In rServer.GetClientListKeys
        '    lDebugTest.Items.Add(String.Format("{0} - ", value))
        'Next
    End Sub

    Private Sub LoadConfig()
        Me.sPathLista.Text = Cfg.Path

        Call RecargarListaArchivos("", True)
        Call ReadFile(False)
    End Sub

    Private Sub FindFiles()
        Dim oFind As ToolStripTextBox = Me.sFind
        Dim sFind As String = oFind.Text
        Me.RecargarListaArchivos(sFind)
    End Sub

    Public Sub RecargarListaArchivos(Optional ByVal sFind As String = "", Optional ByVal HideError As Boolean = False)
        Dim sPath As String = Me.sPathLista.Text

        With Me.ListFiles
            .Items.Clear()

            If sPath = "" Or Not IO.Directory.Exists(sPath) Then
                If Not HideError Then
                    MsgBox("Invalid directory!!", MsgBoxStyle.Exclamation, "Error!")
                End If
                Return
            End If

            .BeginUpdate()
            Me.lCountFiles.Text = String.Format("{0} archivos", 0)
            Me.LoadPrograssBar.Value = 0
            Me.LoadPrograssBar.Visible = True
            Dim di As New IO.DirectoryInfo(sPath)
            Dim ls As FileInfo() = di.GetFiles("*.txt")

            Me.LoadPrograssBar.Maximum = ls.Count
            For Each fi As IO.FileInfo In ls
                'Dim strFileSize As String = (Math.Round(fi.Length / 1024)).ToString()
                Me.LoadPrograssBar.Value += 1
                Me.lCountFiles.Text = String.Format("{0} archivos", Me.LoadPrograssBar.Value)

                If sFind <> String.Empty Then
                    If InStr(fi.Name, sFind) = 0 Then
                        Application.DoEvents()
                        Continue For
                    End If
                End If

                Dim li As New ListViewItem With {
                    .Text = fi.Name
                }
                li.SubItems.Add(fi.CreationTimeUtc)
                Me.ListFiles.Items.Add(li)
                Application.DoEvents()
            Next
            Me.lCountFiles.Text = String.Format("{0} archivos", ls.Count)
            Me.LoadPrograssBar.Visible = False
            .EndUpdate()
        End With
    End Sub

    Private Function ReadFile(Optional ShowError As Boolean = True) As Boolean
        ReadDoc1.Clear()

        Dim sPath As String = Me.sPathLista.Text
        If Not IO.Directory.Exists(sPath) Then
            If ShowError Then
                MsgBox("El directorio seleccionado no existe!", MsgBoxStyle.Exclamation, "Error!")
            End If
            Return False
        End If
        If (ListFiles.SelectedItems.Count = 0) Then
            If ShowError Then
                MsgBox("No hay nada seleccionado en la lista!", MsgBoxStyle.Exclamation, "Error!")
            End If
            Return False
        End If

        Dim sFileName As String = ListFiles.SelectedItems.Item(0).Text
        If sFileName = String.Empty Then
            If ShowError Then
                MsgBox("Nombre de archivo Nulo!", MsgBoxStyle.Exclamation, "Error!")
            End If
            Return False
        End If

        Dim sFullPath As String = IO.Path.Combine(sPath, sFileName)
        If Not IO.File.Exists(sFullPath) Then
            If ShowError Then
                MsgBox(String.Format("El archivo ({0}) no existe!", sFullPath), MsgBoxStyle.Exclamation, "Error!")
            End If
            Return False
        End If
        Me.ReadDoc1.LoadFile(sFullPath, RichTextBoxStreamType.PlainText)
        Return True
    End Function

    Private Sub SelectFolder()
        Dim obj As ToolStripTextBox = Me.sPathLista

        Dim sInitFolder As String = Me.sPathLista.Text
        If sInitFolder = String.Empty OrElse Not IO.Directory.Exists(sInitFolder) Then
            sInitFolder = Cfg.Path
        End If

        Try
            Dim sFolderActual As String = sInitFolder
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
            Call RecargarListaArchivos()

        Catch oe As Exception
            logger.Error(oe.Message, oe)
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

#Region "btn_Click"
    Private Sub btnRefreshList_Click(sender As Object, e As EventArgs) Handles btnRefreshList.Click
        Call RecargarListaArchivos()
    End Sub

    Private Sub ListFiles_DoubleClick(sender As Object, e As EventArgs) Handles ListFiles.DoubleClick
        Call ReadFile()
    End Sub

    Private Sub cmdShowHideContenido_Click(sender As Object, e As EventArgs) Handles cmdShowHideContenido.Click
        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed
        If SplitContainer1.Panel2Collapsed Then
            cmdShowHideContenido.Image = LibCore.My.Resources.Resources.view_full_list_icone_6722_32
        Else
            cmdShowHideContenido.Image = LibCore.My.Resources.Resources.seleccione_ver_icono_5723_32
        End If
    End Sub

    Private Sub btnFindFolder_Click(sender As Object, e As EventArgs) Handles btnFindFolder.Click
        Call SelectFolder()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Call FindFiles()
    End Sub

    Private Sub sPathLista_DoubleClick(sender As Object, e As EventArgs) Handles sPathLista.DoubleClick
        Dim sPathFile As String = ""
        Dim sPath As String = Me.sPathLista.Text
        If IO.Directory.Exists(sPath) Then
            If (ListFiles.SelectedItems.Count > 0) Then
                Dim sFileName As String = ListFiles.SelectedItems.Item(0).Text
                If sFileName <> String.Empty Then
                    sPathFile = IO.Path.Combine(sPath, sFileName)
                    If Not IO.File.Exists(sPathFile) Then
                        sPathFile = ""
                    End If
                End If
            End If
            If sPathFile = String.Empty Then
                Process.Start("explorer.exe", String.Format("/root, {0}", sPath))
            Else
                Process.Start("explorer.exe", String.Format("/select, {0}", sPathFile))
            End If
        End If
    End Sub
#End Region


    Private Sub sPathLista_TextChanged(sender As Object, e As EventArgs) Handles sPathLista.TextChanged
        Dim obj As ToolStripTextBox = Me.sPathLista
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

    Private Sub sPathLista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sPathLista.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call RecargarListaArchivos()
            e.Handled = True
        End If
    End Sub

    Private Sub sFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sFind.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call FindFiles()
            e.Handled = True
        End If
    End Sub

    Private Sub ListFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFiles.SelectedIndexChanged
        Call ReadFile(False)
    End Sub

















    'Fuente: https://gist.github.com/KRIPT4/3382ee3ca890f46f76a838b778e5ae83
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Static currentLine As Integer
        Dim textfont As Font = Me.ReadDoc1.Font
        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            w = .PaperSize.Width - .Margins.Left - .Margins.Right
            left = PrintDocument1.DefaultPageSettings.Margins.Left
            top = PrintDocument1.DefaultPageSettings.Margins.Top
        End With
        'Optional Rectangle Blue.
        'e.Graphics.DrawRectangle(Pens.Blue, New Rectangle(left, top, w, h))
        If PrintDocument1.DefaultPageSettings.Landscape Then
            Dim a As Integer
            a = h
            h = w
            w = a
        End If
        Dim lines As Integer = CInt(Math.Round(h / textfont.Height))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        If Not Me.ReadDoc1.WordWrap Then
            format = New StringFormat(StringFormatFlags.NoWrap)
            format.Trimming = StringTrimming.EllipsisWord
            Dim i As Integer
            For i = currentLine To Math.Min(currentLine + lines, Me.ReadDoc1.Lines.Length - 1)
                e.Graphics.DrawString(Me.ReadDoc1.Lines(i), textfont, Brushes.Black, New RectangleF(left, top + textfont.Height * (i - currentLine), w, textfont.Height), format)
            Next
            currentLine += lines
            If currentLine >= Me.ReadDoc1.Lines.Length Then
                e.HasMorePages = False
                currentLine = 0
            Else
                e.HasMorePages = True
            End If
            Exit Sub
        End If
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer
        e.Graphics.MeasureString(Mid(Me.ReadDoc1.Text, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        If currentChar + chars < Me.ReadDoc1.Text.Length Then
            If Me.ReadDoc1.Text.Substring(currentChar + chars, 1) <> " " And Me.ReadDoc1.Text.Substring(currentChar + chars, 1) <> vbLf Then
                While chars > 0
                    Me.ReadDoc1.Text.Substring(currentChar + chars, 1)
                    Me.ReadDoc1.Text.Substring(currentChar + chars, 1)
                    chars -= 1
                End While
                chars += 1
            End If
        End If
        e.Graphics.DrawString(Me.ReadDoc1.Text.Substring(currentChar, chars), textfont, Brushes.Black, b, format)
        currentChar = currentChar + chars
        If currentChar < Me.ReadDoc1.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub







    Private Sub btnPrintRawFromString_Click(sender As Object, e As EventArgs) Handles btnPrintRawFromString.Click
        Dim s As String
        Dim pd As New PrintDialog()

        ' You need a string to send.
        s = Me.ReadDoc1.Text
        ' Open the printer dialog box, and then allow the user to select a printer.
        pd.PrinterSettings = New PrinterSettings()
        If (pd.ShowDialog() = DialogResult.OK) Then
            RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s)
        End If
    End Sub

    Private Sub btnPrintRaw_Click(sender As Object, e As EventArgs) Handles btnPrintRawFromFile.Click
        ' Allow the user to select a file.
        Dim ofd As New OpenFileDialog()
        If ofd.ShowDialog(Me) Then
            ' Allow the user to select a printer.
            Dim pd As New PrintDialog()
            pd.PrinterSettings = New PrinterSettings()
            If (pd.ShowDialog() = DialogResult.OK) Then
                ' Print the file to the printer.
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName)
            End If
        End If
    End Sub

    Private Sub btnDirectPrint70_Click(sender As Object, e As EventArgs) Handles btnDirectPrint70.Click
        Dim op As New PrintHelper
        For index As Integer = 1 To 70
            If index Mod 2 = 0 Then
                op.Prt(Me.ReadDoc1.Text, "Generic / Text Only")
            Else
                op.Prt(Me.ReadDoc1.Text, "Generic / Text Only (Copiar 1)")
            End If
            Application.DoEvents()
        Next
    End Sub

    Private Sub btnPrint1_Click(sender As Object, e As EventArgs) Handles btnPrint1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    'Fuente: https://www.javatpoint.com/vb-net-print-dialog-box
    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        If Me.ReadDoc1.Text = String.Empty Then
            MsgBox("Please write some text...")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub


End Class
