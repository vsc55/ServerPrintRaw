Imports System.ComponentModel
Imports System.Windows.Forms

Namespace CerebelumLib

    <ToolboxItem(True)>
    <System.Drawing.ToolboxBitmap(GetType(Windows.Forms.ListView))>
    Public Class ListView_Column_AutoSize
        Inherits Windows.Forms.ListView

        Private ReadOnly m_IsInDesignMode As Boolean = True

        Private _ColumnAutoSizeInDesignMode As Boolean = False
        Private _ColumnAutoSize As Boolean = False
        Private _ColumnAutoSizeIndex As Integer = 0
        Private _ColumnAutoSizeMinimal As Integer = 70
        Private _ColumnOrderOnClick As Boolean = True


        Private _vColumnaOrden As ColumnHeader = Nothing
        Private _vOrden As SortOrder = Nothing

        Private _isResizering = False


        Public Sub New()
            MyBase.New()
            Me.m_IsInDesignMode = (LicenseManager.UsageMode = LicenseUsageMode.Designtime)

            'Evitar parpadeos del listview al actulizar
            Dim propiedadListView As System.Reflection.PropertyInfo
            propiedadListView = GetType(ListView_Column_AutoSize).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
            propiedadListView.SetValue(Me, True, Nothing)
        End Sub


        Public ReadOnly Property IsInDesignMode As Boolean
            Get
                Return m_IsInDesignMode
            End Get
        End Property

        <Browsable(True)>
        <DefaultValue(False)>
        <Description("True Se ordenan los elementos de la lista al hacer click en la cabezera de la columna, False no hace nada.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ColumnOrderOnClick As Boolean
            Get
                Return Me._ColumnOrderOnClick
            End Get
            Set(value As Boolean)
                If Me.ColumnOrderOnClick = value Then Exit Property
                Me._ColumnOrderOnClick = value
                'Me.Invalidate()
            End Set
        End Property

        <Browsable(True)>
        <DefaultValue(False)>
        <Description("SOLO EN MODO DISEÑO: True Autosize de Columnas activado, False desactivado.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ColumnAutoSizeInDesignMode As Boolean
            Get
                Return Me._ColumnAutoSizeInDesignMode
            End Get
            Set(value As Boolean)
                If Me.IsInDesignMode = False Then Exit Property
                If Me.ColumnAutoSizeInDesignMode = value Then Exit Property
                Me._ColumnAutoSizeInDesignMode = value
                Me.Invalidate()
            End Set
        End Property

        <Browsable(True)>
        <DefaultValue(False)>
        <Description("True Autosize de Columnas activado, False desactivado.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ColumnAutoSize As Boolean
            Get
                Return Me._ColumnAutoSize
            End Get
            Set(value As Boolean)
                If Me.ColumnAutoSize = value Then Exit Property
                Me._ColumnAutoSize = value
                'Me.Invalidate()
            End Set
        End Property

        <Browsable(True)>
        <DefaultValue(0)>
        <Description("Numero de la columna que se exapandera o cantraera cuando el contro se cambia de tamaño.")>
        <RefreshProperties(RefreshProperties.All)>
        Property ColumnAutoSizeIndex As Integer
            Get
                Return Me._ColumnAutoSizeIndex
            End Get
            Set(value As Integer)
                If Me.ColumnAutoSizeIndex = value Then Exit Property
                If value < 0 Or value > (Me.Columns.Count - 1) Then
                    MsgBox("Indice fuera de intervalo!", MsgBoxStyle.Exclamation, "Error!")
                    Exit Property
                End If
                Me._ColumnAutoSizeIndex = value
                'Me.Invalidate()
            End Set
        End Property


        <Browsable(True)>
        <DefaultValue(70)>
        <Description("Tamaño minimos de la columna cuando se efectua el resize.")>
        <RefreshProperties(RefreshProperties.All)>
        Public Property ColumnAutoSizeMinimal As Integer
            Get
                Return Me._ColumnAutoSizeMinimal
            End Get
            Set(value As Integer)
                If Me.ColumnAutoSizeMinimal = value Then Exit Property
                Me._ColumnAutoSizeMinimal = value
                'Me.Invalidate()
            End Set
        End Property

        Private Sub Rebuil_Column_AutoSize()
            If Me.Disposing Then Exit Sub
            If Me._isResizering = True Then Exit Sub 'Control Loop Resize Columns
            If Me.IsInDesignMode = True AndAlso Me.ColumnAutoSizeInDesignMode = False Then Exit Sub
            If Me.Columns.Count = 0 Then Exit Sub
            If Me.ColumnAutoSize = False Then Exit Sub

            Me.SuspendLayout()
            Me._isResizering = True
            Dim iColumn As Integer = Me.ColumnAutoSizeIndex

            'Si el indice de la columna no existe, obtenemos la ultima columna
            If iColumn < 0 OrElse iColumn > (Me.Columns.Count - 1) Then
                iColumn = Me.Columns.Count - 1
            End If
            Dim iWidth As Integer = Me.Width
            For Each oItem As Windows.Forms.ColumnHeader In Me.Columns
                iWidth -= oItem.Width
            Next
            With Me.Columns.Item(iColumn)
                iWidth += .Width
                If iWidth < Me.ColumnAutoSizeMinimal Then
                    .Width = Me.ColumnAutoSizeMinimal
                ElseIf .Width <> iWidth Then
                    '.Width = iWidth - 4 - IIf(Me.IsVerticalScrollVisible(), SystemInformation.VerticalScrollBarWidth, 0)
                    .Width = iWidth - 4 - SystemInformation.VerticalScrollBarWidth
                End If
            End With
            Me.ResumeLayout()
            Me._isResizering = False

        End Sub

        Private Function IsVerticalScrollVisible() As Boolean
            If Me.View = View.Details And Me.Items.Count > 0 Then
                Try
                    If (Me.Items(0).Bounds.Top - Me.TopItem.Bounds.Top < 0) Or (Me.Items(Me.Items.Count - 1).Bounds.Bottom > Me.ClientSize.Height) Then
                        Return True
                    End If
                Catch ex As Exception
                    logger.Warn(ex.Message, ex)
                End Try
            End If
            Return False
        End Function

        Private Sub OrderItems(ByVal iColumn As Integer)
            Console.WriteLine("Ordenar {0}", iColumn)
            Dim vIndiceColumna As ColumnHeader = Me.Columns(iColumn)
            Dim vTipoOrden As System.Windows.Forms.SortOrder

            If Me._vColumnaOrden Is Nothing Then
                vTipoOrden = SortOrder.Ascending
                Me._vOrden = SortOrder.Ascending
            Else
                If vIndiceColumna.Equals(Me._vColumnaOrden) Then
                    If Me._vOrden = SortOrder.Ascending Then
                        vTipoOrden = SortOrder.Descending
                        Me._vOrden = SortOrder.Descending
                    Else
                        vTipoOrden = SortOrder.Ascending
                        Me._vOrden = SortOrder.Ascending
                    End If
                Else
                    vTipoOrden = SortOrder.Ascending
                    Me._vOrden = SortOrder.Ascending
                End If
            End If

            Me._vColumnaOrden = vIndiceColumna

            Me.ListViewItemSorter = New ListView_Order(iColumn, vTipoOrden)
            Me.Sort()
        End Sub

        Protected Overrides Sub OnColumnClick(e As ColumnClickEventArgs)
            MyBase.OnColumnClick(e)
            If Me.ColumnOrderOnClick Then
                Me.OrderItems(e.Column)
            End If
        End Sub

        Protected Overrides Sub OnColumnWidthChanged(e As ColumnWidthChangedEventArgs)
            MyBase.OnColumnWidthChanged(e)
            Me.Rebuil_Column_AutoSize()
        End Sub

        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            Me.Rebuil_Column_AutoSize()
        End Sub

        Protected Overrides Sub OnControlRemoved(e As ControlEventArgs)
            MyBase.OnControlRemoved(e)
            Me.Rebuil_Column_AutoSize()
        End Sub

        Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
            MyBase.OnInvalidated(e)
            Me.Rebuil_Column_AutoSize()
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Me.Rebuil_Column_AutoSize()
        End Sub

    End Class

End Namespace