Imports System.ComponentModel
Imports System.Drawing

Namespace CerebelumLib

    'Designer(GetType(System.Windows.Forms.Design.ControlDesigner)) > PERMITE EDITARLO DESDE FORM HEREDADO.
    <ToolboxItem(True), System.Drawing.ToolboxBitmap(GetType(System.Windows.Forms.ToolStrip)), System.Diagnostics.DebuggerStepThrough()>
    Public Class ClsToolStrip
        Inherits System.Windows.Forms.ToolStrip

        Public Sub New()
            MyBase.New()
            Me.SetConfigInitCustom()
        End Sub

        Public Sub New(ParamArray items() As Windows.Forms.ToolStripItem)
            MyBase.New(items)
            Me.SetConfigInitCustom()
        End Sub

        Private Sub SetConfigInitCustom()
            'CON ESTO ELIMINAMOS EL BORDE QUE AÑADE AL TOOLSTRIP
            Me.Renderer = New ClsToolStripProfessionalRenderer
            Me.BackColor = Color.Transparent
            Me.GripStyle = Windows.Forms.ToolStripGripStyle.Hidden
            Me.Stretch = True
        End Sub


        Public Enum TypeCustomSelected
            typeNormal = 0
            typeCustom = 1
        End Enum


#Region "Propiedades para ToolStripComboBox"

        Private _ComboBoxStyleBorder As TypeCustomSelected = TypeCustomSelected.typeNormal
        <Description("Tipo de Borde que se usara en los ComboBox dentro el ToolStrip."), Browsable(True)>
        Public Property ComboBoxStyleBorder As TypeCustomSelected
            Get
                Return Me._ComboBoxStyleBorder
            End Get
            Set(value As TypeCustomSelected)
                If Me.ComboBoxStyleBorder = value Then Exit Property
                Me._ComboBoxStyleBorder = value
                Me.Invalidate()
            End Set
        End Property

        Private _ComboBoxBorderColor As Color = Color.Gray
        <Description("Color de Borde que se usara en los ComboBox cuando la propiedad ComboBoxStyleBorder este en modo custom."), Browsable(True)>
        Public Property ComboBoxBorderColor As Color
            Get
                Return Me._ComboBoxBorderColor
            End Get
            Set(value As Color)
                If Me.ComboBoxBorderColor = value Then Exit Property
                Me._ComboBoxBorderColor = value
                Me.Invalidate()
            End Set
        End Property

#End Region

#Region "Propiedades para ToolStripTextBox"

        Private _TextBoxStyleBorder As TypeCustomSelected = TypeCustomSelected.typeNormal
        <Description("Tipo de Borde que se usara en los TextBox dentro el ToolStrip."), Browsable(True)>
        Public Property TextBoxStyleBorder As TypeCustomSelected
            Get
                Return Me._TextBoxStyleBorder
            End Get
            Set(value As TypeCustomSelected)
                If Me.TextBoxStyleBorder = value Then Exit Property
                Me._TextBoxStyleBorder = value
                Me.Invalidate()
                Me.Refresh()
            End Set
        End Property

        Private _TextBoxBorderColor As Color = SystemColors.Control
        <Description("Color de Borde que se usara en los TextBox cuando la propiedad TextBoxStyleBorder este en modo custom."), Browsable(True)>
        Public Property TextBoxBorderColor As Color
            Get
                Return Me._TextBoxBorderColor
            End Get
            Set(value As Color)
                If Me.TextBoxBorderColor = value Then Exit Property
                Me._TextBoxBorderColor = value
                Me.Invalidate()
                Me.Refresh()
            End Set
        End Property

        Private _TextBoxBorderDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
        <Description("Definimos que tipo de borde queremos que use el TextBox."), Browsable(True)>
        Public Property TextBoxBorderDashStyle As Drawing2D.DashStyle
            Get
                Return Me._TextBoxBorderDashStyle
            End Get
            Set(value As Drawing2D.DashStyle)
                If value = Drawing2D.DashStyle.Custom Then value = Drawing2D.DashStyle.Solid
                If Me.TextBoxBorderDashStyle = value Then Exit Property
                Me._TextBoxBorderDashStyle = value
                Me.Invalidate()
            End Set
        End Property

#End Region


        Private cbBorderPen As Pen = New Pen(SystemColors.Window)
        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)

            Dim oLocation As Point = Nothing
            Dim oSize As Size = Nothing
            Dim r As Rectangle = Nothing

            For Each oItem As Object In Me.Items
                If oItem Is Nothing Then Continue For

                oLocation = Nothing
                oSize = Nothing
                r = Nothing

                Select Case oItem.GetType
                    'Case GetType(ClsToolStripComboBox)
                    '    'CON ESTO MODIFICAMOS EL BORDE QUE EL TOOLSTRIP AÑADE A LOS COMBOBOX.
                    '    Dim cb As ClsToolStripComboBox = DirectCast(oItem, ClsToolStripComboBox)
                    '    oLocation = cb.ComboBox.Location
                    '    oSize = cb.ComboBox.Size
                    '    cbBorderPen.Color = Me.ComboBoxBorderColor


                    '    'r = New Rectangle(oLocation.X, oLocation.Y, oSize.Width, oSize.Height)
                    '    'e.Graphics.DrawRectangle(New Pen(Me.ComboBoxBorderColor, 8), r)
                    '    'e.Graphics.DrawRectangle(New Pen(cb.ComboBox.BackColor, 6), r)
                    '    'Continue For



                    Case GetType(ClsToolStripTextBox)
                        'CON ESTO MODIFICAMOS EL BORDE QUE EL TOOLSTRIP AÑADE A LOS TEXTBOX.
                        Dim tb As ClsToolStripTextBox = DirectCast(oItem, ClsToolStripTextBox)
                        oLocation = tb.TextBox.Location
                        oSize = tb.TextBox.Size
                        tb.TextBox.BorderStyle = Windows.Forms.BorderStyle.None
                        cbBorderPen.Color = Me.TextBoxBorderColor

                        'IGUALA EL TAMAÑAO AL DEL COMBOBOX
                        r = New Rectangle(oLocation.X, oLocation.Y, oSize.Width, oSize.Height)

                        Dim StyleLineaR As Pen = New Pen(Me.TextBoxBorderColor, 8)
                        StyleLineaR.DashStyle = Me.TextBoxBorderDashStyle

                        'Select Case StyleLineaR.DashStyle
                        '    Case Drawing2D.DashStyle.Solid
                        '    Case Drawing2D.DashStyle.Dot
                        '    Case Drawing2D.DashStyle.DashDotDot
                        '    Case Drawing2D.DashStyle.DashDot
                        '    Case Drawing2D.DashStyle.Dash
                        '    Case Drawing2D.DashStyle.Custom
                        'End Select

                        e.Graphics.DrawRectangle(StyleLineaR, r)
                        e.Graphics.DrawRectangle(New Pen(tb.TextBox.BackColor, 6), r)

                        Continue For


                    'Case GetType(ClsToolStripSplitButton),
                    '     GetType(ClsToolStripCheckBox),
                    '     GetType(ClsToolStripNumericUpDown)

                    '    Continue For


                    Case GetType(ClsToolStripButton)
                        Continue For

                    Case GetType(Windows.Forms.ToolStripComboBox),
                        GetType(Windows.Forms.ToolStripSplitButton),
                        GetType(Windows.Forms.ToolStripLabel),
                        GetType(Windows.Forms.ToolStripButton),
                        GetType(Windows.Forms.ToolStripTextBox),
                        GetType(Windows.Forms.ToolStripSeparator),
                        GetType(Windows.Forms.ToolStripProgressBar)
                        Continue For

                    Case Else
                        If oItem.GetType.ToString <> "System.Windows.Forms.Design.DesignerToolStripControlHost" Then
                            InputBox("Objeto No Controlado:", "Designer", oItem.GetType.ToString)
                        End If
                        Continue For
                End Select

                r = New Rectangle(oLocation.X - 1, oLocation.Y - 1, oSize.Width + 1, oSize.Height + 1)
                e.Graphics.DrawRectangle(cbBorderPen, r)
            Next

            MyBase.OnPaint(e)
        End Sub

        Protected Overrides Sub OnPaintBackground(e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaintBackground(e)
        End Sub

    End Class

End Namespace