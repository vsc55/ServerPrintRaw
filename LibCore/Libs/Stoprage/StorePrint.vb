Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions

Namespace Core.Store

    Public Class StorePrint

        Private _PathStore As String
        Public Property PathStore As String
            Get
                Return _PathStore
            End Get
            Set(value As String)
                _PathStore = value
            End Set
        End Property

        Public ReadOnly Property IsPathExist As Boolean
            Get
                Return IO.Directory.Exists(Me.PathStore)
            End Get
        End Property


        Private _IDRefSearch As String = Nothing
        Public Property IDRefSearch As String
            Get
                Return _IDRefSearch
            End Get
            Set(value As String)
                _IDRefSearch = value
            End Set
        End Property

        Private _TemplateID As String = ""
        Public Property TemplateID As String
            Get
                Dim sTmp = Trim(Me._TemplateID)
                Return IIf(sTmp = "", "File", sTmp)
            End Get
            Set(value As String)
                Me._TemplateID = IIf(IsNothing(value), "", Trim(value))
            End Set
        End Property



        Public Sub New()

        End Sub



        Private Function GenerarID() As String
            Return Format(Now, Me.TemplateID()).ToString
        End Function

        Public Function FindID(sRegEx As String, strData As String) As String
            Return Me.FindID(sRegEx, strData, Nothing)
        End Function

        Public Function FindID(sRegEx As String, strData As String, clientID As String) As String
            Dim dReturn As String = ""

            'Constant   Value               Description
            ' ----------------------------------------------------------------
            'vbCr       Chr(13)             Carriage return
            'vbCrLf     Chr(13) & Chr(10)   Carriage return–linefeed combination
            'vbLf       Chr(10)             Line feed

            'Muestra:
            'Tipo de         Tipo 3: modo usuario



            'Dim data() As String = Split(strData, vbLf)
            'Dim i As Integer
            'Dim RefSearch As String = "Tipo de"
            'If RefSearch <> "" Then
            '    For i = 0 To UBound(data)
            '        Dim line = data(i).Replace(Chr(13), String.Empty)
            '        If Trim(line) = "" Then Continue For

            '        If InStr(line, RefSearch) Then
            '            Dim iniPost As Integer = InStr(line, RefSearch) + Len(RefSearch)
            '            Dim endPost As Integer = InStr(line, ": modo usuario")
            '            dReturn = Trim(Mid(line, iniPost, endPost - iniPost))
            '            Exit For
            '        End If
            '        'Console.WriteLine(line)
            '    Next i
            'End If


            If Not IsNothing(sRegEx) AndAlso sRegEx.GetType.Equals(GetType(String)) AndAlso sRegEx <> String.Empty Then
                Dim m As Match = Regex.Match(strData, IDRefSearch, RegexOptions.IgnoreCase)
                If (m.Success) Then
                    Dim key As String = m.Groups(1).Value
                    dReturn = Trim(key)
                End If
            End If
            Return dReturn
        End Function

        Public Sub SavePrint(strData As String, Optional clientID As String = "?")
            If Me.IsPathExist() = False Then
                logger.ErrorFormat("{0} - ¡No se puede guardar el documento ya que la ruta de saldia no existe ({1})!", clientID, Me.PathStore)
                Exit Sub
            End If

            logger.DebugFormat("{0} - Buscando ID en documento...", clientID)
            Dim id As String = ""
            Dim sRegEx As String = Me.IDRefSearch

            'If Not IsNothing(sRegEx) AndAlso sRegEx.GetType.Equals(GetType(String)) AndAlso sRegEx <> String.Empty Then
            id = Me.FindID(sRegEx, strData, clientID)
            'End If

            If id = String.Empty Then
                id = Me.GenerarID()
                logger.WarnFormat("{0} - ¡No se ha localizado el ID en el documento, se ha generado uno automaticamente!", clientID)
            End If
            logger.InfoFormat("{0} - ID Doc: {1}", clientID, id)

            'Limpiar el ID de caracteres no soportados en el nombre del archivo.
            id = Me.CleanFileNameInvalidChars(id, Cfg.CharInvalidRemplace())

            Dim sNameFile As String = ""
            Dim sFullPath As String = ""
            Dim iCount As Integer = 0
            Do
                sNameFile = String.Format("{0}{1}.txt", id, IIf(iCount > 0, "_" & iCount, ""))
                sFullPath = String.Format("{0}\{1}", Me.PathStore, sNameFile)
                iCount += 1
            Loop Until Not IO.File.Exists(sFullPath)

            If (iCount > 1) Then
                logger.DebugFormat("{0} - El archivo ya existe, se ha buscado otro nombre: {1}", clientID, sNameFile)
            End If

            Try
                My.Computer.FileSystem.WriteAllText(sFullPath, strData, False)
                logger.InfoFormat("{0} - Impresion Guardada: {1}", clientID, sFullPath)
            Catch ex As Exception
                logger.Error(ex.Message, ex)
            End Try
        End Sub

        Private Function CleanFileNameInvalidChars(ByVal sFileName As String, Optional ByVal charRemplace As String = "") As String
            Dim charsInvalid() As Char = Path.GetInvalidFileNameChars()
            Dim sReutn As String = sFileName
            For Each c As Char In charsInvalid
                sReutn = sReutn.Replace(c, charRemplace)
            Next
            Return sReutn
        End Function

    End Class

End Namespace