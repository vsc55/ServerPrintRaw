<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RtbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RtbOutput
        '
        Me.RtbOutput.Location = New System.Drawing.Point(51, 63)
        Me.RtbOutput.Name = "RtbOutput"
        Me.RtbOutput.Size = New System.Drawing.Size(888, 381)
        Me.RtbOutput.TabIndex = 0
        Me.RtbOutput.Text = ""
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 498)
        Me.Controls.Add(Me.RtbOutput)
        Me.Name = "frmDebug"
        Me.Text = "frmDebug"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RtbOutput As RichTextBox
End Class
