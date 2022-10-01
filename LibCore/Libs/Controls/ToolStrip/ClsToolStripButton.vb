Imports System.ComponentModel
Imports System.Drawing

Namespace CerebelumLib

    'Designer(GetType(System.ComponentModel.Design.ComponentDesigner))      >> PARA EL TEMA DE FORMULARIO HEREDADO!!!!
    <ToolboxItem(True), System.Drawing.ToolboxBitmap(GetType(Windows.Forms.ToolStripButton)), System.Diagnostics.DebuggerStepThrough()>
    Public Class ClsToolStripButton
        Inherits Windows.Forms.ToolStripButton

        Public Sub New()
            MyBase.New()
        End Sub

        Private _BackColorChecked As Color = Color.Transparent
        Public Property BackColorChecked As Color
            Get
                Return Me._BackColorChecked
            End Get
            Set(value As Color)
                Me._BackColorChecked = value
            End Set
        End Property

    End Class

End Namespace