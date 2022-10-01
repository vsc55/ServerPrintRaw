Public Class ReadDoc

    Private _Highlight_BackColor As Color = Nothing
    Private _Highlight_ForeColor As Color = Color.LimeGreen
    Private _Highlight_Font As Font = Nothing
    Private _Highlight_IgnoreCase As Boolean = False


    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.UpdateLabelFile("")
    End Sub




    Public Sub LoadFile(ByVal sFile As String)
        Me.sContenidoFile.LoadFile(sFile)
        Me.UpdateLabelFile(sFile)
    End Sub

    Public Sub LoadFile(ByVal sFile As String, ByVal fileType As RichTextBoxStreamType)
        Me.sContenidoFile.LoadFile(sFile, fileType)
        Me.UpdateLabelFile(sFile)
    End Sub

    Private Sub UpdateLabelFile(ByVal sName As String)
        If sName = String.Empty Then
            sName = "Desconocido"
        End If
        Me.sLabelFileLoad.Text = String.Format("Archivo: {0}", sName)
    End Sub

    Public Overloads Property Text As String
        Get
            Return Me.sContenidoFile.Text
        End Get
        Set(value As String)
            Me.sContenidoFile.Text = value
        End Set
    End Property

    Public Property BackColorText As Color
        Get
            Return Me.sContenidoFile.BackColor
        End Get
        Set(value As Color)
            Me.sContenidoFile.BackColor = value
        End Set
    End Property

    Public Property ForeColorText As Color
        Get
            Return Me.sContenidoFile.ForeColor
        End Get
        Set(value As Color)
            Me.sContenidoFile.ForeColor = value
        End Set
    End Property

    Public Overloads Property Font As Font
        Get
            Return Me.sContenidoFile.Font
        End Get
        Set(value As Font)
            Me.sContenidoFile.Font = value
        End Set
    End Property

    Public Overloads Property TextHighlight As String
        Get
            Return Me.sTxtRealzarTexto.Text
        End Get
        Set(value As String)
            Me.sTxtRealzarTexto.Text = value
        End Set
    End Property

    Public Property WordWrap As Boolean
        Get
            Return Me.sContenidoFile.WordWrap
        End Get
        Set(value As Boolean)
            Me.sContenidoFile.WordWrap = value
        End Set
    End Property

    Public Property Lines As String()
        Get
            Return Me.sContenidoFile.Lines
        End Get
        Set(value As String())
            Me.sContenidoFile.Lines = value
        End Set
    End Property

    Public Sub Clear()
        Me.sContenidoFile.Clear()
        Me.sTxtRealzarTexto.Clear()
        Call Me.UpdateLabelFile("")
    End Sub

#Region "Acceso directo a Objetos"

    Private Function GetRtb() As RichTextBox
        Return Me.sContenidoFile
    End Function

    Public Property RichTextBox As RichTextBox
        Get
            Return Me.sContenidoFile
        End Get
        Set(value As RichTextBox)
            Me.sContenidoFile = value
        End Set
    End Property

    Public Property Highlight As TextBox
        Get
            Return Me.sTxtRealzarTexto
        End Get
        Set(value As TextBox)
            Me.sTxtRealzarTexto = value
        End Set
    End Property

    Public Property LabelFile As Label
        Get
            Return Me.sLabelFileLoad
        End Get
        Set(value As Label)
            Me.sLabelFileLoad = value
        End Set
    End Property

#End Region

#Region "Highlight"

    Public Property Highlight_BackColor As Color
        Get
            Dim cReturn As Color = _Highlight_BackColor
            If IsNothing(cReturn) Then
                cReturn = Me.GetRtb().SelectionBackColor
            End If
            Return cReturn

        End Get
        Set(value As Color)
            _Highlight_BackColor = value
        End Set
    End Property

    Public Property Highlight_ForeColor As Color
        Get
            Return _Highlight_ForeColor
        End Get
        Set(value As Color)
            _Highlight_ForeColor = value
        End Set
    End Property

    Public Property Highlight_Font As Font
        Get
            Dim fReturn As Font = _Highlight_Font
            If IsNothing(fReturn) Then
                fReturn = New Font(Me.GetRtb().SelectionFont, FontStyle.Bold)
            End If
            Return fReturn
        End Get
        Set(value As Font)
            _Highlight_Font = value
        End Set
    End Property

    Public Property Highlight_IgnoreCase As Boolean
        Get
            Return _Highlight_IgnoreCase
        End Get
        Set(value As Boolean)
            _Highlight_IgnoreCase = value
        End Set
    End Property


    Private Sub sTxtRealzarTexto_TextChanged(sender As Object, e As EventArgs) Handles sTxtRealzarTexto.TextChanged
        Dim rtb As RichTextBox = Me.GetRtb()

        ' Reset selection.
        With rtb
            .SelectAll()
            .SelectionColor = .ForeColor
            .SelectionBackColor = .BackColor
            .SelectionFont = .Font
            .Select(0, 0)
        End With

        ' Perform a new selection.
        Dim Find As String = Me.TextHighlight
        Dim IgnoreCase As Boolean = Me.Highlight_IgnoreCase
        Dim ForeColor As Color = Me.Highlight_ForeColor
        Dim BackColor As Color = Me.Highlight_BackColor
        Dim Font As Font = Me.Highlight_Font


        'Dim BackColor As Color = IIf(IsNothing(Me.Highlight_BackColor), rtb.SelectionBackColor, Me.Highlight_BackColor)
        'Dim fStyle As FontStyle = FontStyle.Regular
        'fStyle = FontStyle.Bold
        'Dim font As Font = New Font(rtb.SelectionFont, fStyle)

        Me.InternalColorizeMatches(rtb, Find, IgnoreCase, ForeColor, BackColor, Font)
    End Sub

    'Fuente: https://foro.elhacker.net/net/ayuda_buscar_y_resaltar_la_palabras_de_un_richtextbox-t477445.0.html;msg2147390
    <DebuggerStepThrough>
    Private Function InternalColorizeMatches(ByVal rtb As RichTextBox,
                                               ByVal find As String,
                                               ByVal ignoreCase As Boolean,
                                               ByVal foreColor As Color,
                                               ByVal backColor As Color,
                                               ByVal font As Font) As Integer

        If String.IsNullOrEmpty(find) Then
            Return 0
        End If

        ' Set letter-case criteria.
        Dim richTextBoxFinds As RichTextBoxFinds =
            If(ignoreCase, RichTextBoxFinds.None, RichTextBoxFinds.MatchCase)
        Dim stringComparison As StringComparison =
            If(ignoreCase, StringComparison.OrdinalIgnoreCase, StringComparison.Ordinal)

        ' Save the current caret position to restore it at the end.
        Dim caretPosition As Integer = rtb.SelectionStart

        Dim successCount As Integer = 0
        Dim textLength As Integer = rtb.TextLength
        Dim firstIndex As Integer = 0
        Dim lastIndex As Integer = rtb.Text.LastIndexOf(find, stringComparison)

        While (firstIndex <= lastIndex)
            Dim findIndex As Integer = rtb.Find(find, firstIndex, textLength, richTextBoxFinds)
            If (findIndex <> -1) Then
                successCount += 1
            Else
                Continue While
            End If

            rtb.SelectionColor = foreColor
            rtb.SelectionBackColor = backColor
            rtb.SelectionFont = font

            firstIndex = (rtb.Text.IndexOf(find, findIndex, stringComparison) + 1)
        End While ' (firstIndex <= lastIndex)

        ' Restore the caret position. Reset selection length to zero.
        rtb.Select(caretPosition, length:=0)

        Return successCount

    End Function

#End Region

End Class
