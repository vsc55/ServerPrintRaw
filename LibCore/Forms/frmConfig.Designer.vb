<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.TableLayoutMain = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnServiceReload = New System.Windows.Forms.Button()
        Me.btnServiceStop = New System.Windows.Forms.Button()
        Me.btnServiceStart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelInfoService = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lResultTestRegEx = New System.Windows.Forms.Label()
        Me.sRegExGetID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnTestRegExGetID = New System.Windows.Forms.Button()
        Me.btnDefaultRegEx = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDefaultPath = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sTxtPath = New System.Windows.Forms.TextBox()
        Me.btnSelectPath = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDefaultAutoStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDefaultPort = New System.Windows.Forms.Button()
        Me.sTxtIPAddress = New System.Windows.Forms.ComboBox()
        Me.btnDefaultIP = New System.Windows.Forms.Button()
        Me.chkAutoStart = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.iTxtPort = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.BoxInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutMain.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfoService.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.iTxtPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutMain
        '
        Me.TableLayoutMain.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutMain.ColumnCount = 1
        Me.TableLayoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMain.Controls.Add(Me.PanelTop, 0, 0)
        Me.TableLayoutMain.Controls.Add(Me.PanelInfoService, 0, 1)
        Me.TableLayoutMain.Controls.Add(Me.PanelMain, 0, 2)
        Me.TableLayoutMain.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutMain.Name = "TableLayoutMain"
        Me.TableLayoutMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayoutMain.RowCount = 4
        Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutMain.Size = New System.Drawing.Size(780, 297)
        Me.TableLayoutMain.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTop.Location = New System.Drawing.Point(3, 3)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(774, 50)
        Me.PanelTop.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 50)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnServiceReload)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnServiceStop)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnServiceStart)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(321, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(453, 50)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnServiceReload
        '
        Me.btnServiceReload.AutoSize = True
        Me.btnServiceReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnServiceReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnServiceReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServiceReload.ForeColor = System.Drawing.SystemColors.Info
        Me.btnServiceReload.Image = Global.LibCore.My.Resources.Resources.refresh_reload_all_tabs_icone_4270_32
        Me.btnServiceReload.Location = New System.Drawing.Point(358, 3)
        Me.btnServiceReload.Name = "btnServiceReload"
        Me.btnServiceReload.Size = New System.Drawing.Size(92, 44)
        Me.btnServiceReload.TabIndex = 10
        Me.btnServiceReload.Text = "&Reiniciar"
        Me.btnServiceReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnServiceReload, "Reinicia el Servidor")
        Me.btnServiceReload.UseVisualStyleBackColor = False
        '
        'btnServiceStop
        '
        Me.btnServiceStop.AutoSize = True
        Me.btnServiceStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnServiceStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnServiceStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServiceStop.ForeColor = System.Drawing.SystemColors.Info
        Me.btnServiceStop.Image = Global.LibCore.My.Resources.Resources.no_icone_6912_32
        Me.btnServiceStop.Location = New System.Drawing.Point(263, 3)
        Me.btnServiceStop.Name = "btnServiceStop"
        Me.btnServiceStop.Size = New System.Drawing.Size(89, 44)
        Me.btnServiceStop.TabIndex = 9
        Me.btnServiceStop.Text = "&Detener"
        Me.btnServiceStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnServiceStop, "Detiene el Servidor")
        Me.btnServiceStop.UseVisualStyleBackColor = False
        '
        'btnServiceStart
        '
        Me.btnServiceStart.AutoSize = True
        Me.btnServiceStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnServiceStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnServiceStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServiceStart.ForeColor = System.Drawing.SystemColors.Info
        Me.btnServiceStart.Image = Global.LibCore.My.Resources.Resources.cache_icone_8420_32
        Me.btnServiceStart.Location = New System.Drawing.Point(178, 3)
        Me.btnServiceStart.Name = "btnServiceStart"
        Me.btnServiceStart.Size = New System.Drawing.Size(79, 44)
        Me.btnServiceStart.TabIndex = 8
        Me.btnServiceStart.Text = "&Iniciar"
        Me.btnServiceStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnServiceStart, "Inicia el Servidor")
        Me.btnServiceStart.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 50)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Calibri", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(60, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label5.Size = New System.Drawing.Size(241, 45)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Configuración"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.LibCore.My.Resources.Resources.folder_settings_tools_22597
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.LibCore.My.Resources.Resources.aboutbox_gradian
        Me.PictureBox3.Location = New System.Drawing.Point(301, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 50)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PanelInfoService
        '
        Me.PanelInfoService.BackColor = System.Drawing.Color.Coral
        Me.PanelInfoService.Controls.Add(Me.Label1)
        Me.PanelInfoService.Controls.Add(Me.PictureBox1)
        Me.PanelInfoService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInfoService.Location = New System.Drawing.Point(3, 53)
        Me.PanelInfoService.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelInfoService.Name = "PanelInfoService"
        Me.PanelInfoService.Size = New System.Drawing.Size(774, 39)
        Me.PanelInfoService.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(724, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Servidor iniciado como servicio. Hay que reiniciar el servicio manualmente para q" &
    "ue los cambios se apliquen correctamente."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.LibCore.My.Resources.Resources.onebit_icone_3921_32
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.Ivory
        Me.PanelMain.Controls.Add(Me.TableLayoutPanel4)
        Me.PanelMain.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelMain.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(3, 92)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(774, 152)
        Me.PanelMain.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lResultTestRegEx, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.sRegExGetID, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnTestRegExGetID, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnDefaultRegEx, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 88)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(774, 64)
        Me.TableLayoutPanel4.TabIndex = 10
        '
        'lResultTestRegEx
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.lResultTestRegEx, 3)
        Me.lResultTestRegEx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lResultTestRegEx.Location = New System.Drawing.Point(88, 44)
        Me.lResultTestRegEx.Name = "lResultTestRegEx"
        Me.lResultTestRegEx.Size = New System.Drawing.Size(683, 20)
        Me.lResultTestRegEx.TabIndex = 1
        Me.lResultTestRegEx.Text = "Resultado:"
        '
        'sRegExGetID
        '
        Me.sRegExGetID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sRegExGetID.Location = New System.Drawing.Point(88, 12)
        Me.sRegExGetID.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.sRegExGetID.Name = "sRegExGetID"
        Me.sRegExGetID.Size = New System.Drawing.Size(569, 20)
        Me.sRegExGetID.TabIndex = 0
        Me.BoxInfo.SetToolTip(Me.sRegExGetID, "Regla que se usa para localizar el ID del documento. Este resultado se usara como" &
        " nombre del archivo.")
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 44)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Regex Get ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTestRegExGetID
        '
        Me.btnTestRegExGetID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTestRegExGetID.Image = Global.LibCore.My.Resources.Resources.iconfinder_document03_1622833_121957_16
        Me.btnTestRegExGetID.Location = New System.Drawing.Point(697, 8)
        Me.btnTestRegExGetID.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnTestRegExGetID.Name = "btnTestRegExGetID"
        Me.btnTestRegExGetID.Size = New System.Drawing.Size(74, 28)
        Me.btnTestRegExGetID.TabIndex = 1
        Me.BoxInfo.SetToolTip(Me.btnTestRegExGetID, "Comprueba si la regla se ejecuta correctamente.")
        Me.btnTestRegExGetID.UseVisualStyleBackColor = True
        '
        'btnDefaultRegEx
        '
        Me.btnDefaultRegEx.AutoSize = True
        Me.btnDefaultRegEx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefaultRegEx.FlatAppearance.BorderSize = 0
        Me.btnDefaultRegEx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnDefaultRegEx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDefaultRegEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultRegEx.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_16
        Me.btnDefaultRegEx.Location = New System.Drawing.Point(663, 8)
        Me.btnDefaultRegEx.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnDefaultRegEx.Name = "btnDefaultRegEx"
        Me.btnDefaultRegEx.Size = New System.Drawing.Size(28, 28)
        Me.btnDefaultRegEx.TabIndex = 2
        Me.BoxInfo.SetToolTip(Me.btnDefaultRegEx, "Restablece el valor predeterminado")
        Me.btnDefaultRegEx.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnDefaultPath, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.sTxtPath, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSelectPath, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 44)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(774, 44)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'btnDefaultPath
        '
        Me.btnDefaultPath.AutoSize = True
        Me.btnDefaultPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefaultPath.FlatAppearance.BorderSize = 0
        Me.btnDefaultPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnDefaultPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDefaultPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultPath.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_16
        Me.btnDefaultPath.Location = New System.Drawing.Point(663, 8)
        Me.btnDefaultPath.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnDefaultPath.Name = "btnDefaultPath"
        Me.btnDefaultPath.Size = New System.Drawing.Size(28, 28)
        Me.btnDefaultPath.TabIndex = 11
        Me.BoxInfo.SetToolTip(Me.btnDefaultPath, "Restablece el valor predeterminado")
        Me.btnDefaultPath.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 44)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ruta Archivos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sTxtPath
        '
        Me.sTxtPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sTxtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sTxtPath.Location = New System.Drawing.Point(88, 12)
        Me.sTxtPath.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.sTxtPath.Name = "sTxtPath"
        Me.sTxtPath.Size = New System.Drawing.Size(569, 20)
        Me.sTxtPath.TabIndex = 3
        Me.BoxInfo.SetToolTip(Me.sTxtPath, "Ruta donde se guardarán los archivos que se reciban en el servidor.")
        '
        'btnSelectPath
        '
        Me.btnSelectPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectPath.Image = Global.LibCore.My.Resources.Resources.magnifier_icone_7459_16
        Me.btnSelectPath.Location = New System.Drawing.Point(697, 8)
        Me.btnSelectPath.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(74, 28)
        Me.btnSelectPath.TabIndex = 4
        Me.BoxInfo.SetToolTip(Me.btnSelectPath, "Selecciona la ubicación donde se guardan los archivos impresos.")
        Me.btnSelectPath.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnDefaultAutoStart, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDefaultPort, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.sTxtIPAddress, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDefaultIP, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkAutoStart, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(774, 44)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'btnDefaultAutoStart
        '
        Me.btnDefaultAutoStart.AccessibleDescription = ""
        Me.btnDefaultAutoStart.AutoSize = True
        Me.btnDefaultAutoStart.FlatAppearance.BorderSize = 0
        Me.btnDefaultAutoStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnDefaultAutoStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDefaultAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultAutoStart.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_16
        Me.btnDefaultAutoStart.Location = New System.Drawing.Point(663, 8)
        Me.btnDefaultAutoStart.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnDefaultAutoStart.Name = "btnDefaultAutoStart"
        Me.btnDefaultAutoStart.Size = New System.Drawing.Size(28, 28)
        Me.btnDefaultAutoStart.TabIndex = 14
        Me.BoxInfo.SetToolTip(Me.btnDefaultAutoStart, "Restablece el valor predeterminado")
        Me.btnDefaultAutoStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección IP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDefaultPort
        '
        Me.btnDefaultPort.AutoSize = True
        Me.btnDefaultPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefaultPort.FlatAppearance.BorderSize = 0
        Me.btnDefaultPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnDefaultPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDefaultPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultPort.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_16
        Me.btnDefaultPort.Location = New System.Drawing.Point(518, 8)
        Me.btnDefaultPort.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnDefaultPort.Name = "btnDefaultPort"
        Me.btnDefaultPort.Size = New System.Drawing.Size(28, 28)
        Me.btnDefaultPort.TabIndex = 13
        Me.BoxInfo.SetToolTip(Me.btnDefaultPort, "Restablece el valor predeterminado")
        Me.btnDefaultPort.UseVisualStyleBackColor = True
        '
        'sTxtIPAddress
        '
        Me.sTxtIPAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sTxtIPAddress.FormattingEnabled = True
        Me.sTxtIPAddress.Location = New System.Drawing.Point(88, 12)
        Me.sTxtIPAddress.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.sTxtIPAddress.Name = "sTxtIPAddress"
        Me.sTxtIPAddress.Size = New System.Drawing.Size(217, 21)
        Me.sTxtIPAddress.TabIndex = 0
        Me.BoxInfo.SetToolTip(Me.sTxtIPAddress, "IP en la que se pondrá a escuchar el servidor de impresoras.")
        '
        'btnDefaultIP
        '
        Me.btnDefaultIP.AutoSize = True
        Me.btnDefaultIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefaultIP.FlatAppearance.BorderSize = 0
        Me.btnDefaultIP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnDefaultIP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnDefaultIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaultIP.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_16
        Me.btnDefaultIP.Location = New System.Drawing.Point(311, 8)
        Me.btnDefaultIP.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btnDefaultIP.Name = "btnDefaultIP"
        Me.btnDefaultIP.Size = New System.Drawing.Size(28, 28)
        Me.btnDefaultIP.TabIndex = 12
        Me.BoxInfo.SetToolTip(Me.btnDefaultIP, "Restablece el valor predeterminado")
        Me.btnDefaultIP.UseVisualStyleBackColor = True
        '
        'chkAutoStart
        '
        Me.chkAutoStart.AutoSize = True
        Me.chkAutoStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAutoStart.Location = New System.Drawing.Point(552, 3)
        Me.chkAutoStart.Name = "chkAutoStart"
        Me.chkAutoStart.Size = New System.Drawing.Size(105, 38)
        Me.chkAutoStart.TabIndex = 2
        Me.chkAutoStart.Text = "Inicio &Automático"
        Me.chkAutoStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAutoStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.chkAutoStart, "Indica si queremos que el servidor se inicie automáticamente al arrancar le progr" &
        "ama.")
        Me.chkAutoStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(350, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 44)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Puerto TCP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.iTxtPort)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(415, 12)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 32)
        Me.Panel3.TabIndex = 1
        '
        'iTxtPort
        '
        Me.iTxtPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iTxtPort.Location = New System.Drawing.Point(0, 0)
        Me.iTxtPort.Maximum = New Decimal(New Integer() {65575, 0, 0, 0})
        Me.iTxtPort.Name = "iTxtPort"
        Me.iTxtPort.Size = New System.Drawing.Size(100, 20)
        Me.iTxtPort.TabIndex = 1
        Me.BoxInfo.SetToolTip(Me.iTxtPort, "Puerto TCP de escucha para el servidor de impresora.")
        Me.iTxtPort.Value = New Decimal(New Integer() {9100, 0, 0, 0})
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnReload)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSaveExit)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 244)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(774, 50)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Info
        Me.btnCancel.Image = Global.LibCore.My.Resources.Resources.stop_icone_9406_32
        Me.btnCancel.Location = New System.Drawing.Point(678, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 44)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnCancel, "Cancela los cambios y cierra la ventana de configuración")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.AutoSize = True
        Me.btnReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.ForeColor = System.Drawing.SystemColors.Info
        Me.btnReload.Image = Global.LibCore.My.Resources.Resources.undo_icone_4366_32
        Me.btnReload.Location = New System.Drawing.Point(577, 3)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(95, 44)
        Me.btnReload.TabIndex = 7
        Me.btnReload.Text = "R&ecargar"
        Me.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnReload, "Recarga los ajustes")
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Info
        Me.btnSave.Image = Global.LibCore.My.Resources.Resources.exportacion_icono_5880_32
        Me.btnSave.Location = New System.Drawing.Point(466, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 44)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Guardar"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnSave, "Guarda los cambios y cierra la ventana de configuración")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSaveExit
        '
        Me.btnSaveExit.AutoSize = True
        Me.btnSaveExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveExit.ForeColor = System.Drawing.SystemColors.Info
        Me.btnSaveExit.Image = Global.LibCore.My.Resources.Resources.aceptar_verde_ok_si_icono_8925_32
        Me.btnSaveExit.Location = New System.Drawing.Point(340, 3)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(120, 44)
        Me.btnSaveExit.TabIndex = 8
        Me.btnSaveExit.Text = "Guardar y &Salir"
        Me.btnSaveExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BoxInfo.SetToolTip(Me.btnSaveExit, "Guarda los cambios y cierra la ventana de configuración")
        Me.btnSaveExit.UseVisualStyleBackColor = True
        '
        'BoxInfo
        '
        Me.BoxInfo.IsBalloon = True
        Me.BoxInfo.ShowAlways = True
        Me.BoxInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.BoxInfo.ToolTipTitle = "Info"
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(780, 297)
        Me.Controls.Add(Me.TableLayoutMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.TableLayoutMain.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfoService.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.iTxtPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutMain As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnServiceStart As Button
    Friend WithEvents btnServiceStop As Button
    Friend WithEvents btnServiceReload As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnReload As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelInfoService As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents iTxtPort As NumericUpDown
    Friend WithEvents sTxtPath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelectPath As Button
    Friend WithEvents chkAutoStart As CheckBox
    Friend WithEvents sTxtIPAddress As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lResultTestRegEx As Label
    Friend WithEvents sRegExGetID As TextBox
    Friend WithEvents btnTestRegExGetID As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDefaultRegEx As Button
    Friend WithEvents btnDefaultPath As Button
    Friend WithEvents btnDefaultAutoStart As Button
    Friend WithEvents btnDefaultPort As Button
    Friend WithEvents btnDefaultIP As Button
    Friend WithEvents BoxInfo As ToolTip
    Friend WithEvents btnSaveExit As Button
End Class
