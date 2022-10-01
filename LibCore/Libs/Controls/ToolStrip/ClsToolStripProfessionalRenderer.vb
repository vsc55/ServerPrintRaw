Imports System.Drawing

Namespace CerebelumLib

    Public Class ClsToolStripProfessionalRenderer
        Inherits Windows.Forms.ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderToolStripBorder(e As Windows.Forms.ToolStripRenderEventArgs)
            'MyBase.OnRenderToolStripBorder(e)
        End Sub


        Protected Overrides Sub OnRenderButtonBackground(e As Windows.Forms.ToolStripItemRenderEventArgs)

            'Dim btn As ToolStripButton = DirectCast(e.Item, ToolStripButton)
            'If (btn IsNot Nothing AndAlso btn.CheckOnClick And btn.Checked) Then
            '    MyBase.OnRenderButtonBackground(e)
            '    Dim bounds As Rectangle = New Rectangle(Point.Empty, e.Item.Size)
            '    e.Graphics.FillRectangle(Brushes.Transparent, bounds)
            'Else
            '    MyBase.OnRenderButtonBackground(e)
            'End If


            If TypeOf e.Item Is ClsToolStripButton Then
                If DirectCast(e.Item, ClsToolStripButton).Checked Then
                    Dim clientRect = New Rectangle(0, 0, e.Item.Width, e.Item.Height)
                    e.Graphics.FillRectangle(New SolidBrush(DirectCast(e.Item, ClsToolStripButton).BackColorChecked), clientRect)
                End If
            End If

            MyBase.OnRenderButtonBackground(e)

        End Sub

    End Class

End Namespace