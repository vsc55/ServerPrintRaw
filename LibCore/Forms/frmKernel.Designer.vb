<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKernel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKernel))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"File1", "10k"}, -1)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lCountFiles = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lClientesActivos = New System.Windows.Forms.Label()
        Me.LoadPrograssBar = New System.Windows.Forms.ProgressBar()
        Me.ListFiles = New LibCore.CerebelumLib.ListView_Column_AutoSize()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReadDoc1 = New LibCore.ReadDoc()
        Me.ToolStrip2 = New LibCore.CerebelumLib.ClsToolStrip()
        Me.btnPrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint1 = New System.Windows.Forms.ToolStripButton()
        Me.btnDirectPrint70 = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintRawFromFile = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintRawFromString = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New LibCore.CerebelumLib.ClsToolStrip()
        Me.btnRefreshList = New LibCore.CerebelumLib.ClsToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdShowHideContenido = New LibCore.CerebelumLib.ClsToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.sPathLista = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFindFolder = New LibCore.CerebelumLib.ClsToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.sFind = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFind = New LibCore.CerebelumLib.ClsToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListFiles)
        Me.SplitContainer1.Panel1MinSize = 100
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReadDoc1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(1062, 436)
        Me.SplitContainer1.SplitterDistance = 473
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 26)
        Me.Panel1.TabIndex = 2
        '
        'lCountFiles
        '
        Me.lCountFiles.AutoSize = True
        Me.lCountFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lCountFiles.ForeColor = System.Drawing.SystemColors.Info
        Me.lCountFiles.Location = New System.Drawing.Point(412, 0)
        Me.lCountFiles.Name = "lCountFiles"
        Me.lCountFiles.Size = New System.Drawing.Size(56, 26)
        Me.lCountFiles.TabIndex = 0
        Me.lCountFiles.Text = "0 archivos"
        Me.lCountFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1062, 436)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ToolStripContainer1.LeftToolStripPanel.Enabled = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ToolStripContainer1.RightToolStripPanel.Enabled = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1062, 486)
        Me.ToolStripContainer1.TabIndex = 10
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lClientesActivos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lCountFiles, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LoadPrograssBar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(471, 26)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lClientesActivos
        '
        Me.lClientesActivos.AutoSize = True
        Me.lClientesActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lClientesActivos.ForeColor = System.Drawing.SystemColors.Info
        Me.lClientesActivos.Location = New System.Drawing.Point(3, 0)
        Me.lClientesActivos.Name = "lClientesActivos"
        Me.lClientesActivos.Size = New System.Drawing.Size(56, 26)
        Me.lClientesActivos.TabIndex = 1
        Me.lClientesActivos.Text = "Clientes: 0"
        Me.lClientesActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoadPrograssBar
        '
        Me.LoadPrograssBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoadPrograssBar.Location = New System.Drawing.Point(65, 3)
        Me.LoadPrograssBar.Name = "LoadPrograssBar"
        Me.LoadPrograssBar.Size = New System.Drawing.Size(341, 20)
        Me.LoadPrograssBar.TabIndex = 2
        Me.LoadPrograssBar.Visible = False
        '
        'ListFiles
        '
        Me.ListFiles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListFiles.BackColor = System.Drawing.Color.Ivory
        Me.ListFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListFiles.ColumnAutoSize = True
        Me.ListFiles.ColumnAutoSizeInDesignMode = True
        Me.ListFiles.ColumnOrderOnClick = True
        Me.ListFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColFecha})
        Me.ListFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListFiles.FullRowSelect = True
        Me.ListFiles.GridLines = True
        Me.ListFiles.HideSelection = False
        Me.ListFiles.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.ListFiles.LabelEdit = True
        Me.ListFiles.Location = New System.Drawing.Point(0, 0)
        Me.ListFiles.Name = "ListFiles"
        Me.ListFiles.ShowItemToolTips = True
        Me.ListFiles.Size = New System.Drawing.Size(471, 434)
        Me.ListFiles.TabIndex = 1
        Me.ListFiles.UseCompatibleStateImageBehavior = False
        Me.ListFiles.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Nombre"
        Me.ColName.Width = 291
        '
        'ColFecha
        '
        Me.ColFecha.Text = "Fecha"
        Me.ColFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColFecha.Width = 159
        '
        'ReadDoc1
        '
        Me.ReadDoc1.BackColor = System.Drawing.SystemColors.Control
        Me.ReadDoc1.BackColorText = System.Drawing.Color.Ivory
        Me.ReadDoc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReadDoc1.ForeColorText = System.Drawing.SystemColors.WindowText
        Me.ReadDoc1.Highlight_BackColor = System.Drawing.Color.Empty
        Me.ReadDoc1.Highlight_Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ReadDoc1.Highlight_ForeColor = System.Drawing.Color.LimeGreen
        Me.ReadDoc1.Highlight_IgnoreCase = True
        Me.ReadDoc1.Lines = New String(-1) {}
        Me.ReadDoc1.Location = New System.Drawing.Point(0, 25)
        Me.ReadDoc1.Name = "ReadDoc1"
        Me.ReadDoc1.Size = New System.Drawing.Size(583, 409)
        Me.ReadDoc1.TabIndex = 3
        Me.ReadDoc1.TextHighlight = ""
        Me.ReadDoc1.WordWrap = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ComboBoxBorderColor = System.Drawing.Color.Gray
        Me.ToolStrip2.ComboBoxStyleBorder = LibCore.CerebelumLib.ClsToolStrip.TypeCustomSelected.typeNormal
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrintPreview, Me.btnPrint1, Me.btnDirectPrint70, Me.btnPrintRawFromFile, Me.btnPrintRawFromString})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(583, 25)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.TextBoxBorderColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.TextBoxBorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.ToolStrip2.TextBoxStyleBorder = LibCore.CerebelumLib.ClsToolStrip.TypeCustomSelected.typeNormal
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.ForeColor = System.Drawing.SystemColors.Info
        Me.btnPrintPreview.Image = CType(resources.GetObject("btnPrintPreview.Image"), System.Drawing.Image)
        Me.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(68, 22)
        Me.btnPrintPreview.Text = "Preview"
        '
        'btnPrint1
        '
        Me.btnPrint1.ForeColor = System.Drawing.SystemColors.Info
        Me.btnPrint1.Image = CType(resources.GetObject("btnPrint1.Image"), System.Drawing.Image)
        Me.btnPrint1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint1.Text = "Print"
        '
        'btnDirectPrint70
        '
        Me.btnDirectPrint70.ForeColor = System.Drawing.SystemColors.Info
        Me.btnDirectPrint70.Image = CType(resources.GetObject("btnDirectPrint70.Image"), System.Drawing.Image)
        Me.btnDirectPrint70.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDirectPrint70.Name = "btnDirectPrint70"
        Me.btnDirectPrint70.Size = New System.Drawing.Size(95, 22)
        Me.btnDirectPrint70.Text = "DirectPrint70"
        '
        'btnPrintRawFromFile
        '
        Me.btnPrintRawFromFile.ForeColor = System.Drawing.SystemColors.Info
        Me.btnPrintRawFromFile.Image = CType(resources.GetObject("btnPrintRawFromFile.Image"), System.Drawing.Image)
        Me.btnPrintRawFromFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintRawFromFile.Name = "btnPrintRawFromFile"
        Me.btnPrintRawFromFile.Size = New System.Drawing.Size(120, 22)
        Me.btnPrintRawFromFile.Text = "PrintRawFromFile"
        '
        'btnPrintRawFromString
        '
        Me.btnPrintRawFromString.ForeColor = System.Drawing.SystemColors.Info
        Me.btnPrintRawFromString.Image = CType(resources.GetObject("btnPrintRawFromString.Image"), System.Drawing.Image)
        Me.btnPrintRawFromString.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintRawFromString.Name = "btnPrintRawFromString"
        Me.btnPrintRawFromString.Size = New System.Drawing.Size(133, 22)
        Me.btnPrintRawFromString.Text = "PrintRawFormString"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ComboBoxBorderColor = System.Drawing.Color.Gray
        Me.ToolStrip1.ComboBoxStyleBorder = LibCore.CerebelumLib.ClsToolStrip.TypeCustomSelected.typeNormal
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefreshList, Me.ToolStripSeparator2, Me.cmdShowHideContenido, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.sPathLista, Me.btnFindFolder, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.sFind, Me.btnFind})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 6)
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 50)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.TextBoxBorderColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.TextBoxBorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.ToolStrip1.TextBoxStyleBorder = LibCore.CerebelumLib.ClsToolStrip.TypeCustomSelected.typeNormal
        '
        'btnRefreshList
        '
        Me.btnRefreshList.BackColor = System.Drawing.Color.Transparent
        Me.btnRefreshList.BackColorChecked = System.Drawing.Color.Transparent
        Me.btnRefreshList.ForeColor = System.Drawing.SystemColors.Info
        Me.btnRefreshList.Image = Global.LibCore.My.Resources.Resources.refresh_reload_all_tabs_icone_4270_32
        Me.btnRefreshList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefreshList.Name = "btnRefreshList"
        Me.btnRefreshList.Size = New System.Drawing.Size(89, 36)
        Me.btnRefreshList.Text = "Recargar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdShowHideContenido
        '
        Me.cmdShowHideContenido.BackColorChecked = System.Drawing.Color.Transparent
        Me.cmdShowHideContenido.ForeColor = System.Drawing.SystemColors.Info
        Me.cmdShowHideContenido.Image = Global.LibCore.My.Resources.Resources.seleccione_ver_icono_5723_32
        Me.cmdShowHideContenido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdShowHideContenido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdShowHideContenido.Name = "cmdShowHideContenido"
        Me.cmdShowHideContenido.Size = New System.Drawing.Size(103, 36)
        Me.cmdShowHideContenido.Text = "Vista Previa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.Info
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(31, 36)
        Me.ToolStripLabel2.Text = "Ruta"
        '
        'sPathLista
        '
        Me.sPathLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sPathLista.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sPathLista.Name = "sPathLista"
        Me.sPathLista.Size = New System.Drawing.Size(200, 39)
        '
        'btnFindFolder
        '
        Me.btnFindFolder.BackColorChecked = System.Drawing.Color.Transparent
        Me.btnFindFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFindFolder.ForeColor = System.Drawing.SystemColors.Info
        Me.btnFindFolder.Image = Global.LibCore.My.Resources.Resources.Folder_Explore
        Me.btnFindFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFindFolder.Name = "btnFindFolder"
        Me.btnFindFolder.Size = New System.Drawing.Size(36, 36)
        Me.btnFindFolder.Text = "Seleccionar Carpeta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Info
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 36)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'sFind
        '
        Me.sFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sFind.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sFind.Name = "sFind"
        Me.sFind.Size = New System.Drawing.Size(200, 39)
        '
        'btnFind
        '
        Me.btnFind.BackColorChecked = System.Drawing.Color.Transparent
        Me.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFind.ForeColor = System.Drawing.SystemColors.Info
        Me.btnFind.Image = Global.LibCore.My.Resources.Resources.magnifier_icone_7459_32
        Me.btnFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(36, 36)
        Me.btnFind.Text = "Buscar"
        '
        'frmKernel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1062, 486)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKernel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Server Raw"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListFiles As CerebelumLib.ListView_Column_AutoSize
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents ColFecha As ColumnHeader
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ToolStrip2 As CerebelumLib.ClsToolStrip
    Friend WithEvents btnPrintPreview As ToolStripButton
    Friend WithEvents btnPrint1 As ToolStripButton
    Friend WithEvents btnDirectPrint70 As ToolStripButton
    Friend WithEvents btnPrintRawFromFile As ToolStripButton
    Friend WithEvents btnPrintRawFromString As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReadDoc1 As ReadDoc
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStrip1 As CerebelumLib.ClsToolStrip
    Friend WithEvents btnRefreshList As CerebelumLib.ClsToolStripButton
    Friend WithEvents btnFind As CerebelumLib.ClsToolStripButton
    Friend WithEvents cmdShowHideContenido As CerebelumLib.ClsToolStripButton
    Friend WithEvents sPathLista As ToolStripTextBox
    Friend WithEvents sFind As ToolStripTextBox
    Friend WithEvents btnFindFolder As CerebelumLib.ClsToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lCountFiles As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lClientesActivos As Label
    Friend WithEvents LoadPrograssBar As ProgressBar
End Class
