<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Interface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMaterialLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportMaterialLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.TabLayup = New System.Windows.Forms.TabPage()
        Me.PlyNotation = New System.Windows.Forms.RichTextBox()
        Me.LabelSym = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LayerTable = New System.Windows.Forms.DataGridView()
        Me.Layer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlyAngle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSym = New System.Windows.Forms.Button()
        Me.TabLoads = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabMaterial = New System.Windows.Forms.TabPage()
        Me.MatTable = New System.Windows.Forms.DataGridView()
        Me.MatName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatThickness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatGLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatvLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatThermalA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatThermalA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatMoistB1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatMoistB2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatStrengthXt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatStrengthXc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatStrengthYt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatStrengthYc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatStrengthS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatTWintTerm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoadNX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadNY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadXY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadMX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadMY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadMXY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Analyze = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.MainStatusStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabLayup.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LayerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLoads.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabMaterial.SuspendLayout()
        CType(Me.MatTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.AnalysisToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(995, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDataFileToolStripMenuItem, Me.SaveDataFileToolStripMenuItem, Me.ExportMaterialLibraryToolStripMenuItem, Me.ImportMaterialLibraryToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenDataFileToolStripMenuItem
        '
        Me.OpenDataFileToolStripMenuItem.Name = "OpenDataFileToolStripMenuItem"
        Me.OpenDataFileToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.OpenDataFileToolStripMenuItem.Text = "Open Data File"
        '
        'SaveDataFileToolStripMenuItem
        '
        Me.SaveDataFileToolStripMenuItem.Name = "SaveDataFileToolStripMenuItem"
        Me.SaveDataFileToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SaveDataFileToolStripMenuItem.Text = "Save Data File"
        '
        'ExportMaterialLibraryToolStripMenuItem
        '
        Me.ExportMaterialLibraryToolStripMenuItem.Name = "ExportMaterialLibraryToolStripMenuItem"
        Me.ExportMaterialLibraryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExportMaterialLibraryToolStripMenuItem.Text = "Export Material Library"
        '
        'ImportMaterialLibraryToolStripMenuItem
        '
        Me.ImportMaterialLibraryToolStripMenuItem.Name = "ImportMaterialLibraryToolStripMenuItem"
        Me.ImportMaterialLibraryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImportMaterialLibraryToolStripMenuItem.Text = "Import Material Library"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(192, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'LibraryToolStripMenuItem
        '
        Me.LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        Me.LibraryToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LibraryToolStripMenuItem.Text = "Library"
        '
        'AnalysisToolStripMenuItem
        '
        Me.AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem"
        Me.AnalysisToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AnalysisToolStripMenuItem.Text = "Analysis"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MainStatusStrip
        '
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.MainStatusStrip.Location = New System.Drawing.Point(0, 614)
        Me.MainStatusStrip.Name = "MainStatusStrip"
        Me.MainStatusStrip.Size = New System.Drawing.Size(995, 22)
        Me.MainStatusStrip.TabIndex = 1
        Me.MainStatusStrip.Text = "Status"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Controls.Add(Me.TabLayup)
        Me.TabControl1.Controls.Add(Me.TabLoads)
        Me.TabControl1.Controls.Add(Me.TabMaterial)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(953, 485)
        Me.TabControl1.TabIndex = 2
        '
        'TabSettings
        '
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Size = New System.Drawing.Size(945, 459)
        Me.TabSettings.TabIndex = 2
        Me.TabSettings.Text = "Settings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'TabLayup
        '
        Me.TabLayup.Controls.Add(Me.PlyNotation)
        Me.TabLayup.Controls.Add(Me.LabelSym)
        Me.TabLayup.Controls.Add(Me.TableLayoutPanel1)
        Me.TabLayup.Location = New System.Drawing.Point(4, 22)
        Me.TabLayup.Name = "TabLayup"
        Me.TabLayup.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLayup.Size = New System.Drawing.Size(945, 459)
        Me.TabLayup.TabIndex = 0
        Me.TabLayup.Text = "Layup"
        Me.TabLayup.UseVisualStyleBackColor = True
        '
        'PlyNotation
        '
        Me.PlyNotation.Location = New System.Drawing.Point(6, 124)
        Me.PlyNotation.Name = "PlyNotation"
        Me.PlyNotation.Size = New System.Drawing.Size(162, 140)
        Me.PlyNotation.TabIndex = 3
        Me.PlyNotation.Text = ""
        '
        'LabelSym
        '
        Me.LabelSym.AutoSize = True
        Me.LabelSym.BackColor = System.Drawing.Color.LimeGreen
        Me.LabelSym.Location = New System.Drawing.Point(31, 41)
        Me.LabelSym.Name = "LabelSym"
        Me.LabelSym.Size = New System.Drawing.Size(39, 13)
        Me.LabelSym.TabIndex = 2
        Me.LabelSym.Text = "Label1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LayerTable, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSym, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(198, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.79461!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.20539!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 427)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'LayerTable
        '
        Me.LayerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LayerTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LayerTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.LayerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LayerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Layer, Me.MatID, Me.PlyAngle})
        Me.LayerTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.LayerTable.Location = New System.Drawing.Point(3, 57)
        Me.LayerTable.Name = "LayerTable"
        Me.LayerTable.Size = New System.Drawing.Size(421, 341)
        Me.LayerTable.TabIndex = 0
        '
        'Layer
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Layer.DefaultCellStyle = DataGridViewCellStyle1
        Me.Layer.HeaderText = "Layer"
        Me.Layer.Name = "Layer"
        Me.Layer.ReadOnly = True
        Me.Layer.Width = 58
        '
        'MatID
        '
        Me.MatID.HeaderText = "Material"
        Me.MatID.Name = "MatID"
        Me.MatID.Width = 69
        '
        'PlyAngle
        '
        Me.PlyAngle.HeaderText = "Ply Angle"
        Me.PlyAngle.Name = "PlyAngle"
        Me.PlyAngle.Width = 76
        '
        'BtnSym
        '
        Me.BtnSym.Location = New System.Drawing.Point(3, 3)
        Me.BtnSym.Name = "BtnSym"
        Me.BtnSym.Size = New System.Drawing.Size(75, 23)
        Me.BtnSym.TabIndex = 1
        Me.BtnSym.Text = "Symmetry"
        Me.BtnSym.UseVisualStyleBackColor = True
        '
        'TabLoads
        '
        Me.TabLoads.Controls.Add(Me.DataGridView1)
        Me.TabLoads.Location = New System.Drawing.Point(4, 22)
        Me.TabLoads.Name = "TabLoads"
        Me.TabLoads.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLoads.Size = New System.Drawing.Size(945, 459)
        Me.TabLoads.TabIndex = 1
        Me.TabLoads.Text = "Loads"
        Me.TabLoads.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(995, 590)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Analyze, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 494)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(944, 93)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'TabMaterial
        '
        Me.TabMaterial.Controls.Add(Me.MatTable)
        Me.TabMaterial.Location = New System.Drawing.Point(4, 22)
        Me.TabMaterial.Name = "TabMaterial"
        Me.TabMaterial.Size = New System.Drawing.Size(945, 459)
        Me.TabMaterial.TabIndex = 3
        Me.TabMaterial.Text = "Material"
        Me.TabMaterial.UseVisualStyleBackColor = True
        '
        'MatTable
        '
        Me.MatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MatTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatName, Me.MatThickness, Me.MatEL, Me.MatET, Me.MatGLT, Me.MatvLT, Me.MatThermalA1, Me.MatThermalA2, Me.MatMoistB1, Me.MatMoistB2, Me.MatStrengthXt, Me.MatStrengthXc, Me.MatStrengthYt, Me.MatStrengthYc, Me.MatStrengthS, Me.MatTWintTerm})
        Me.MatTable.Location = New System.Drawing.Point(0, 32)
        Me.MatTable.Name = "MatTable"
        Me.MatTable.Size = New System.Drawing.Size(940, 150)
        Me.MatTable.TabIndex = 0
        '
        'MatName
        '
        Me.MatName.HeaderText = "Name/Description"
        Me.MatName.Name = "MatName"
        '
        'MatThickness
        '
        Me.MatThickness.HeaderText = "Thickness"
        Me.MatThickness.Name = "MatThickness"
        '
        'MatEL
        '
        Me.MatEL.HeaderText = "E1"
        Me.MatEL.Name = "MatEL"
        '
        'MatET
        '
        Me.MatET.HeaderText = "E2"
        Me.MatET.Name = "MatET"
        '
        'MatGLT
        '
        Me.MatGLT.HeaderText = "G12"
        Me.MatGLT.Name = "MatGLT"
        '
        'MatvLT
        '
        Me.MatvLT.HeaderText = "v12"
        Me.MatvLT.Name = "MatvLT"
        '
        'MatThermalA1
        '
        Me.MatThermalA1.HeaderText = "CTE1"
        Me.MatThermalA1.Name = "MatThermalA1"
        '
        'MatThermalA2
        '
        Me.MatThermalA2.HeaderText = "CTE2"
        Me.MatThermalA2.Name = "MatThermalA2"
        '
        'MatMoistB1
        '
        Me.MatMoistB1.HeaderText = "CME1"
        Me.MatMoistB1.Name = "MatMoistB1"
        '
        'MatMoistB2
        '
        Me.MatMoistB2.HeaderText = "CME2"
        Me.MatMoistB2.Name = "MatMoistB2"
        '
        'MatStrengthXt
        '
        Me.MatStrengthXt.HeaderText = "Xt"
        Me.MatStrengthXt.Name = "MatStrengthXt"
        '
        'MatStrengthXc
        '
        Me.MatStrengthXc.HeaderText = "Xc"
        Me.MatStrengthXc.Name = "MatStrengthXc"
        '
        'MatStrengthYt
        '
        Me.MatStrengthYt.HeaderText = "Yt"
        Me.MatStrengthYt.Name = "MatStrengthYt"
        '
        'MatStrengthYc
        '
        Me.MatStrengthYc.HeaderText = "Yc"
        Me.MatStrengthYc.Name = "MatStrengthYc"
        '
        'MatStrengthS
        '
        Me.MatStrengthS.HeaderText = "S"
        Me.MatStrengthS.Name = "MatStrengthS"
        '
        'MatTWintTerm
        '
        Me.MatTWintTerm.HeaderText = "Tsai-Wu Interaction"
        Me.MatTWintTerm.Name = "MatTWintTerm"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoadNX, Me.LoadNY, Me.LoadXY, Me.LoadMX, Me.LoadMY, Me.LoadMXY})
        Me.DataGridView1.Location = New System.Drawing.Point(74, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(711, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'LoadNX
        '
        Me.LoadNX.HeaderText = "NX"
        Me.LoadNX.Name = "LoadNX"
        '
        'LoadNY
        '
        Me.LoadNY.HeaderText = "NY"
        Me.LoadNY.Name = "LoadNY"
        '
        'LoadXY
        '
        Me.LoadXY.HeaderText = "NXY"
        Me.LoadXY.Name = "LoadXY"
        '
        'LoadMX
        '
        Me.LoadMX.HeaderText = "MX"
        Me.LoadMX.Name = "LoadMX"
        '
        'LoadMY
        '
        Me.LoadMY.HeaderText = "MY"
        Me.LoadMY.Name = "LoadMY"
        '
        'LoadMXY
        '
        Me.LoadMXY.HeaderText = "MXY"
        Me.LoadMXY.Name = "LoadMXY"
        '
        'Btn_Analyze
        '
        Me.Btn_Analyze.Location = New System.Drawing.Point(475, 3)
        Me.Btn_Analyze.Name = "Btn_Analyze"
        Me.Btn_Analyze.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Analyze.TabIndex = 0
        Me.Btn_Analyze.Text = "Analyze"
        Me.Btn_Analyze.UseVisualStyleBackColor = True
        '
        'User_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 636)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MainStatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "User_Interface"
        Me.Text = "User_Interface"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MainStatusStrip.ResumeLayout(False)
        Me.MainStatusStrip.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabLayup.ResumeLayout(False)
        Me.TabLayup.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LayerTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLoads.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabMaterial.ResumeLayout(False)
        CType(Me.MatTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDataFileToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDataFileToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMaterialLibraryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportMaterialLibraryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainStatusStrip As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExitToolStripMenuItem As Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalysisToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabLayup As Windows.Forms.TabPage
    Friend WithEvents LayerTable As Windows.Forms.DataGridView
    Friend WithEvents TabLoads As Windows.Forms.TabPage
    Friend WithEvents Layer As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlyAngle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnSym As Windows.Forms.Button
    Friend WithEvents TabSettings As Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelSym As Windows.Forms.Label
    Friend WithEvents PlyNotation As Windows.Forms.RichTextBox
    Friend WithEvents TabMaterial As Windows.Forms.TabPage
    Friend WithEvents MatTable As Windows.Forms.DataGridView
    Friend WithEvents MatName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatThickness As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatEL As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatET As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatGLT As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatvLT As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatThermalA1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatThermalA2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatMoistB1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatMoistB2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatStrengthXt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatStrengthXc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatStrengthYt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatStrengthYc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatStrengthS As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatTWintTerm As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents LoadNX As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadNY As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadXY As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadMX As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadMY As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadMXY As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Analyze As Windows.Forms.Button
End Class
