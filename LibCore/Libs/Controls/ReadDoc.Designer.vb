<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadDoc
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.sContenidoFile = New System.Windows.Forms.RichTextBox()
        Me.PanelDown = New System.Windows.Forms.Panel()
        Me.sTxtRealzarTexto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sLabelFileLoad = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelDown.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'sContenidoFile
        '
        Me.sContenidoFile.BackColor = System.Drawing.Color.Ivory
        Me.sContenidoFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sContenidoFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sContenidoFile.Location = New System.Drawing.Point(0, 25)
        Me.sContenidoFile.Name = "sContenidoFile"
        Me.sContenidoFile.ReadOnly = True
        Me.sContenidoFile.Size = New System.Drawing.Size(501, 398)
        Me.sContenidoFile.TabIndex = 1
        Me.sContenidoFile.Text = ""
        Me.sContenidoFile.WordWrap = False
        '
        'PanelDown
        '
        Me.PanelDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.PanelDown.Controls.Add(Me.sTxtRealzarTexto)
        Me.PanelDown.Controls.Add(Me.Label4)
        Me.PanelDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDown.ForeColor = System.Drawing.SystemColors.Info
        Me.PanelDown.Location = New System.Drawing.Point(0, 423)
        Me.PanelDown.Name = "PanelDown"
        Me.PanelDown.Size = New System.Drawing.Size(501, 26)
        Me.PanelDown.TabIndex = 2
        '
        'sTxtRealzarTexto
        '
        Me.sTxtRealzarTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sTxtRealzarTexto.BackColor = System.Drawing.Color.Ivory
        Me.sTxtRealzarTexto.Location = New System.Drawing.Point(82, 3)
        Me.sTxtRealzarTexto.Name = "sTxtRealzarTexto"
        Me.sTxtRealzarTexto.Size = New System.Drawing.Size(416, 20)
        Me.sTxtRealzarTexto.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar Texto:"
        '
        'sLabelFileLoad
        '
        Me.sLabelFileLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.sLabelFileLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sLabelFileLoad.ForeColor = System.Drawing.SystemColors.Info
        Me.sLabelFileLoad.Location = New System.Drawing.Point(0, 0)
        Me.sLabelFileLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.sLabelFileLoad.Name = "sLabelFileLoad"
        Me.sLabelFileLoad.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sLabelFileLoad.Size = New System.Drawing.Size(501, 25)
        Me.sLabelFileLoad.TabIndex = 3
        Me.sLabelFileLoad.Text = "Archivo:"
        Me.sLabelFileLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Transparent
        Me.PanelTop.Controls.Add(Me.sLabelFileLoad)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(501, 25)
        Me.PanelTop.TabIndex = 4
        '
        'ReadDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sContenidoFile)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelDown)
        Me.Name = "ReadDoc"
        Me.Size = New System.Drawing.Size(501, 449)
        Me.PanelDown.ResumeLayout(False)
        Me.PanelDown.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sContenidoFile As RichTextBox
    Friend WithEvents PanelDown As Panel
    Friend WithEvents sTxtRealzarTexto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sLabelFileLoad As Label
    Friend WithEvents PanelTop As Panel
End Class
