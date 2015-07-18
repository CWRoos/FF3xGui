<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FF32Gui
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FF32Gui))
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel12 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateHEXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitAFileIn60BytesFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HexToBinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntelHEXToBINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.tbNew = New System.Windows.Forms.ToolStripButton()
        Me.tbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbCut = New System.Windows.Forms.ToolStripButton()
        Me.tbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbZoom = New System.Windows.Forms.ToolStripButton()
        Me.tbZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbRun = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Document = New System.Windows.Forms.RichTextBox()
        Me.rcMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveWork = New System.Windows.Forms.SaveFileDialog()
        Me.openWork = New System.Windows.Forms.OpenFileDialog()
        Me.cmbInValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAboutAddressGet = New System.Windows.Forms.Button()
        Me.cmdAboutAddressSet = New System.Windows.Forms.Button()
        Me.txtAboutAddress = New System.Windows.Forms.TextBox()
        Me.lblAboutAddress = New System.Windows.Forms.Label()
        Me.colInPin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInSelected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmdAboutVendorGet = New System.Windows.Forms.Button()
        Me.cmdAboutVendorSet = New System.Windows.Forms.Button()
        Me.cmdAboutProductGet = New System.Windows.Forms.Button()
        Me.cmdAboutProductSet = New System.Windows.Forms.Button()
        Me.cmdAboutSerialGet = New System.Windows.Forms.Button()
        Me.txtAbout1stDevice = New System.Windows.Forms.TextBox()
        Me.lblAbout1stDevice = New System.Windows.Forms.Label()
        Me.dgwDigiInPinsBlockSettings = New System.Windows.Forms.DataGridView()
        Me.lblDigiOutPinsBlockSettings = New System.Windows.Forms.Label()
        Me.txtAboutNumOfDevices = New System.Windows.Forms.TextBox()
        Me.cmdDigiOutPinsBlockSet = New System.Windows.Forms.Button()
        Me.cmbDigiOutPinsBlock = New System.Windows.Forms.ComboBox()
        Me.lblDigiOutPinsBlock = New System.Windows.Forms.Label()
        Me.cmdDigiOutPinSet = New System.Windows.Forms.Button()
        Me.lblDigiOutPinValue = New System.Windows.Forms.Label()
        Me.cmbDigiOutPinValue = New System.Windows.Forms.ComboBox()
        Me.cmbDigiOutPin = New System.Windows.Forms.ComboBox()
        Me.lblDigiOutPin = New System.Windows.Forms.Label()
        Me.lblAboutNumOfDevices = New System.Windows.Forms.Label()
        Me.tabDigiIn = New System.Windows.Forms.TabPage()
        Me.txtDigiInPinValue = New System.Windows.Forms.TextBox()
        Me.lblDigiInPinValue = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdDigiInPinsBlockGet = New System.Windows.Forms.Button()
        Me.lblDigiInPinsBlockSettings = New System.Windows.Forms.Label()
        Me.cmbDigiInPinsBlock = New System.Windows.Forms.ComboBox()
        Me.lblDigiInPinsBlock = New System.Windows.Forms.Label()
        Me.cmdDigiInPinSet = New System.Windows.Forms.Button()
        Me.cmbDigiInPin = New System.Windows.Forms.ComboBox()
        Me.lblDigiInPin = New System.Windows.Forms.Label()
        Me.cmdAboutSerialSet = New System.Windows.Forms.Button()
        Me.txtAboutSerial = New System.Windows.Forms.TextBox()
        Me.lblAboutSerial = New System.Windows.Forms.Label()
        Me.txtAboutProduct = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grp1WireDirect = New System.Windows.Forms.GroupBox()
        Me.cmd1WireReadBit = New System.Windows.Forms.Button()
        Me.cmd1WireWriteBit0 = New System.Windows.Forms.Button()
        Me.cmd1WireWriteBit1 = New System.Windows.Forms.Button()
        Me.cmd1WireReset = New System.Windows.Forms.Button()
        Me.cmd1WireDQPinSet = New System.Windows.Forms.Button()
        Me.cmb1WireDQPin = New System.Windows.Forms.ComboBox()
        Me.lbl1WireDQPin = New System.Windows.Forms.Label()
        Me.rtbStatus = New System.Windows.Forms.RichTextBox()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdStatusClear = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.tabPWM = New System.Windows.Forms.TabPage()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.txtPWMPinValue3 = New System.Windows.Forms.TextBox()
        Me.trbPWMPinValue3 = New System.Windows.Forms.TrackBar()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.cmbPWMPin3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPWMPinValue2 = New System.Windows.Forms.TextBox()
        Me.trbPWMPinValue2 = New System.Windows.Forms.TrackBar()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.cmbPWMPin2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPWMPinValue1 = New System.Windows.Forms.TextBox()
        Me.trbPWMPinValue1 = New System.Windows.Forms.TrackBar()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.cmbPWMPin1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPWMPinValue = New System.Windows.Forms.TextBox()
        Me.trbPWMPinValue = New System.Windows.Forms.TrackBar()
        Me.cmdPWMPinSet = New System.Windows.Forms.Button()
        Me.cmbPWMPin = New System.Windows.Forms.ComboBox()
        Me.lblPWMPin = New System.Windows.Forms.Label()
        Me.tab1Wire = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt1WireResponse = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Radio1Hex = New System.Windows.Forms.RadioButton()
        Me.Radio1asc = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt1WireData = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.txt1WireLen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabAnalogIn = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.txtAnalogInPinValue = New System.Windows.Forms.TextBox()
        Me.lblAnalogInPinValue = New System.Windows.Forms.Label()
        Me.cmdAnalogInPinGet = New System.Windows.Forms.Button()
        Me.cmbAnalogInPin = New System.Windows.Forms.ComboBox()
        Me.lblAnalogInPin = New System.Windows.Forms.Label()
        Me.lblAboutProduct = New System.Windows.Forms.Label()
        Me.tabSPI = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultSPI = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioHex = New System.Windows.Forms.RadioButton()
        Me.RadioAscii = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSPIData = New System.Windows.Forms.TextBox()
        Me.cmdSPIExecute = New System.Windows.Forms.Button()
        Me.txtSPIDataLen = New System.Windows.Forms.TextBox()
        Me.lblSPIDataLen = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbSPIPinsSet = New System.Windows.Forms.Button()
        Me.cmbSPIMISOPin = New System.Windows.Forms.ComboBox()
        Me.lblSPIMISOPin = New System.Windows.Forms.Label()
        Me.cmbSPIMOSIPin = New System.Windows.Forms.ComboBox()
        Me.lblSPIMOSIPin = New System.Windows.Forms.Label()
        Me.cmbSPISCKPin = New System.Windows.Forms.ComboBox()
        Me.lblSPISCKPin = New System.Windows.Forms.Label()
        Me.cmbSPICSPin = New System.Windows.Forms.ComboBox()
        Me.lblSPICSPin = New System.Windows.Forms.Label()
        Me.txtI2CData = New System.Windows.Forms.TextBox()
        Me.txtI2CDataLen = New System.Windows.Forms.TextBox()
        Me.lblI2CData = New System.Windows.Forms.Label()
        Me.cmdI2CExecute = New System.Windows.Forms.Button()
        Me.lblI2CDataLen = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmdI2CPinsSet = New System.Windows.Forms.Button()
        Me.cmbI2CSDAPin = New System.Windows.Forms.ComboBox()
        Me.lblI2CSDAPin = New System.Windows.Forms.Label()
        Me.cmbI2CSCLPin = New System.Windows.Forms.ComboBox()
        Me.lblI2CSCLPin = New System.Windows.Forms.Label()
        Me.tabI2C = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.I2CResult = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.RadioIHex = New System.Windows.Forms.RadioButton()
        Me.RadioIAsc = New System.Windows.Forms.RadioButton()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwDigiOutPinsBlockSettings = New System.Windows.Forms.DataGridView()
        Me.txtAboutVendor = New System.Windows.Forms.TextBox()
        Me.lblAboutVendor = New System.Windows.Forms.Label()
        Me.txtAboutVersion = New System.Windows.Forms.TextBox()
        Me.lblAboutVersion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.ErrOut = New System.Windows.Forms.Label()
        Me.tabDigiOut = New System.Windows.Forms.TabPage()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TotBytes = New System.Windows.Forms.TextBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.mainMenu.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.rcMenu.SuspendLayout()
        CType(Me.dgwDigiInPinsBlockSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDigiIn.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.grp1WireDirect.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.tabPWM.SuspendLayout()
        CType(Me.trbPWMPinValue3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbPWMPinValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbPWMPinValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbPWMPinValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1Wire.SuspendLayout()
        Me.tabAnalogIn.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSPI.SuspendLayout()
        Me.tabI2C.SuspendLayout()
        CType(Me.dgwDigiOutPinsBlockSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        Me.tabDigiOut.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(946, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMNew, Me.mMOpen, Me.toolStripSeparator, Me.mMSave, Me.toolStripSeparator2, Me.mMExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mMNew
        '
        Me.mMNew.Image = CType(resources.GetObject("mMNew.Image"), System.Drawing.Image)
        Me.mMNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMNew.Name = "mMNew"
        Me.mMNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMNew.Size = New System.Drawing.Size(140, 22)
        Me.mMNew.Text = "&New"
        '
        'mMOpen
        '
        Me.mMOpen.Image = CType(resources.GetObject("mMOpen.Image"), System.Drawing.Image)
        Me.mMOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMOpen.Name = "mMOpen"
        Me.mMOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mMOpen.Size = New System.Drawing.Size(140, 22)
        Me.mMOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(137, 6)
        '
        'mMSave
        '
        Me.mMSave.Image = CType(resources.GetObject("mMSave.Image"), System.Drawing.Image)
        Me.mMSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMSave.Name = "mMSave"
        Me.mMSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMSave.Size = New System.Drawing.Size(140, 22)
        Me.mMSave.Text = "&Save"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'mMExit
        '
        Me.mMExit.Name = "mMExit"
        Me.mMExit.Size = New System.Drawing.Size(140, 22)
        Me.mMExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMUndo, Me.mMRedo, Me.toolStripSeparator3, Me.mMCut, Me.mMCopy, Me.mMPaste, Me.toolStripSeparator4, Me.mMSelectAll})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mMUndo
        '
        Me.mMUndo.Image = CType(resources.GetObject("mMUndo.Image"), System.Drawing.Image)
        Me.mMUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMUndo.Name = "mMUndo"
        Me.mMUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mMUndo.Size = New System.Drawing.Size(139, 22)
        Me.mMUndo.Text = "&Undo"
        '
        'mMRedo
        '
        Me.mMRedo.Image = CType(resources.GetObject("mMRedo.Image"), System.Drawing.Image)
        Me.mMRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMRedo.Name = "mMRedo"
        Me.mMRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mMRedo.Size = New System.Drawing.Size(139, 22)
        Me.mMRedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(136, 6)
        '
        'mMCut
        '
        Me.mMCut.Image = CType(resources.GetObject("mMCut.Image"), System.Drawing.Image)
        Me.mMCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCut.Name = "mMCut"
        Me.mMCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mMCut.Size = New System.Drawing.Size(139, 22)
        Me.mMCut.Text = "Cu&t"
        '
        'mMCopy
        '
        Me.mMCopy.Image = CType(resources.GetObject("mMCopy.Image"), System.Drawing.Image)
        Me.mMCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMCopy.Name = "mMCopy"
        Me.mMCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mMCopy.Size = New System.Drawing.Size(139, 22)
        Me.mMCopy.Text = "&Copy"
        '
        'mMPaste
        '
        Me.mMPaste.Image = CType(resources.GetObject("mMPaste.Image"), System.Drawing.Image)
        Me.mMPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mMPaste.Name = "mMPaste"
        Me.mMPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mMPaste.Size = New System.Drawing.Size(139, 22)
        Me.mMPaste.Text = "Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(136, 6)
        '
        'mMSelectAll
        '
        Me.mMSelectAll.Name = "mMSelectAll"
        Me.mMSelectAll.Size = New System.Drawing.Size(139, 22)
        Me.mMSelectAll.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.StopToolStripMenuItem, Me.SetFontToolStripMenuItem, Me.CreateHEXFileToolStripMenuItem, Me.SplitAFileIn60BytesFilesToolStripMenuItem, Me.HexToBinToolStripMenuItem, Me.IntelHEXToBINToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Enabled = False
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'SetFontToolStripMenuItem
        '
        Me.SetFontToolStripMenuItem.Image = CType(resources.GetObject("SetFontToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetFontToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SetFontToolStripMenuItem.Name = "SetFontToolStripMenuItem"
        Me.SetFontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SetFontToolStripMenuItem.Text = "Set Font"
        '
        'CreateHEXFileToolStripMenuItem
        '
        Me.CreateHEXFileToolStripMenuItem.Name = "CreateHEXFileToolStripMenuItem"
        Me.CreateHEXFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreateHEXFileToolStripMenuItem.Text = "Create HEX File"
        '
        'SplitAFileIn60BytesFilesToolStripMenuItem
        '
        Me.SplitAFileIn60BytesFilesToolStripMenuItem.Name = "SplitAFileIn60BytesFilesToolStripMenuItem"
        Me.SplitAFileIn60BytesFilesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SplitAFileIn60BytesFilesToolStripMenuItem.Text = "Split a File"
        '
        'HexToBinToolStripMenuItem
        '
        Me.HexToBinToolStripMenuItem.Name = "HexToBinToolStripMenuItem"
        Me.HexToBinToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HexToBinToolStripMenuItem.Text = "Hex to Bin"
        '
        'IntelHEXToBINToolStripMenuItem
        '
        Me.IntelHEXToBINToolStripMenuItem.Name = "IntelHEXToBINToolStripMenuItem"
        Me.IntelHEXToBINToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IntelHEXToBINToolStripMenuItem.Text = "Intel HEX to BIN"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.HelpIndexToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = CType(resources.GetObject("HelpToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'HelpIndexToolStripMenuItem
        '
        Me.HelpIndexToolStripMenuItem.Image = CType(resources.GetObject("HelpIndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpIndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpIndexToolStripMenuItem.Name = "HelpIndexToolStripMenuItem"
        Me.HelpIndexToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.HelpIndexToolStripMenuItem.Text = "Help Index"
        '
        'Tools
        '
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbNew, Me.tbOpen, Me.tbSave, Me.toolStripSeparator1, Me.tbCut, Me.tbCopy, Me.tbPaste, Me.toolStripSeparator5, Me.tbZoom, Me.tbZoomOut, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator8, Me.tbRun, Me.ToolStripSeparator7})
        Me.Tools.Location = New System.Drawing.Point(0, 24)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(946, 25)
        Me.Tools.TabIndex = 1
        Me.Tools.Text = "ToolStrip1"
        '
        'tbNew
        '
        Me.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbNew.Image = CType(resources.GetObject("tbNew.Image"), System.Drawing.Image)
        Me.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbNew.Name = "tbNew"
        Me.tbNew.Size = New System.Drawing.Size(23, 22)
        Me.tbNew.Text = "&New"
        '
        'tbOpen
        '
        Me.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbOpen.Image = CType(resources.GetObject("tbOpen.Image"), System.Drawing.Image)
        Me.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbOpen.Name = "tbOpen"
        Me.tbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tbOpen.Text = "&Open"
        '
        'tbSave
        '
        Me.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbSave.Image = CType(resources.GetObject("tbSave.Image"), System.Drawing.Image)
        Me.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(23, 22)
        Me.tbSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbCut
        '
        Me.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCut.Image = CType(resources.GetObject("tbCut.Image"), System.Drawing.Image)
        Me.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCut.Name = "tbCut"
        Me.tbCut.Size = New System.Drawing.Size(23, 22)
        Me.tbCut.Text = "C&ut"
        '
        'tbCopy
        '
        Me.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbCopy.Image = CType(resources.GetObject("tbCopy.Image"), System.Drawing.Image)
        Me.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbCopy.Name = "tbCopy"
        Me.tbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tbCopy.Text = "&Copy"
        '
        'tbPaste
        '
        Me.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbPaste.Image = CType(resources.GetObject("tbPaste.Image"), System.Drawing.Image)
        Me.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbPaste.Name = "tbPaste"
        Me.tbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tbPaste.Text = "&Paste"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tbZoom
        '
        Me.tbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.tbZoom.Image = CType(resources.GetObject("tbZoom.Image"), System.Drawing.Image)
        Me.tbZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoom.Name = "tbZoom"
        Me.tbZoom.Size = New System.Drawing.Size(23, 22)
        Me.tbZoom.Text = "+"
        '
        'tbZoomOut
        '
        Me.tbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tbZoomOut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!)
        Me.tbZoomOut.Image = CType(resources.GetObject("tbZoomOut.Image"), System.Drawing.Image)
        Me.tbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbZoomOut.Name = "tbZoomOut"
        Me.tbZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.tbZoomOut.Text = "-"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "Run"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tbRun
        '
        Me.tbRun.Enabled = False
        Me.tbRun.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRun.Image = CType(resources.GetObject("tbRun.Image"), System.Drawing.Image)
        Me.tbRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbRun.Name = "tbRun"
        Me.tbRun.Size = New System.Drawing.Size(53, 22)
        Me.tbRun.Text = "Stop"
        Me.tbRun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Document
        '
        Me.Document.ContextMenuStrip = Me.rcMenu
        Me.Document.Dock = System.Windows.Forms.DockStyle.Left
        Me.Document.Font = New System.Drawing.Font("Source Code Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Document.Location = New System.Drawing.Point(0, 49)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(556, 524)
        Me.Document.TabIndex = 3
        Me.Document.Text = ""
        '
        'rcMenu
        '
        Me.rcMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.rcMenu.Name = "rcMenu"
        Me.rcMenu.Size = New System.Drawing.Size(102, 114)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'saveWork
        '
        Me.saveWork.Filter = "FF3x files|*.ff3;*.txt|All fFiles|*.*"
        Me.saveWork.Title = "Save Work"
        '
        'openWork
        '
        Me.openWork.Filter = "FF3x files|*.ff3;*.txt|All fFiles|*.*"
        Me.openWork.Title = "Open Work"
        '
        'cmbInValue
        '
        DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control
        Me.cmbInValue.DefaultCellStyle = DataGridViewCellStyle45
        Me.cmbInValue.HeaderText = "Value"
        Me.cmbInValue.Name = "cmbInValue"
        Me.cmbInValue.ReadOnly = True
        Me.cmbInValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cmbInValue.Width = 50
        '
        'cmdAboutAddressGet
        '
        Me.cmdAboutAddressGet.Location = New System.Drawing.Point(224, 90)
        Me.cmdAboutAddressGet.Name = "cmdAboutAddressGet"
        Me.cmdAboutAddressGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutAddressGet.TabIndex = 40
        Me.cmdAboutAddressGet.Text = "Get"
        Me.cmdAboutAddressGet.UseVisualStyleBackColor = True
        '
        'cmdAboutAddressSet
        '
        Me.cmdAboutAddressSet.Location = New System.Drawing.Point(305, 90)
        Me.cmdAboutAddressSet.Name = "cmdAboutAddressSet"
        Me.cmdAboutAddressSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutAddressSet.TabIndex = 39
        Me.cmdAboutAddressSet.Text = "Set"
        Me.cmdAboutAddressSet.UseVisualStyleBackColor = True
        '
        'txtAboutAddress
        '
        Me.txtAboutAddress.Location = New System.Drawing.Point(92, 92)
        Me.txtAboutAddress.MaxLength = 3
        Me.txtAboutAddress.Name = "txtAboutAddress"
        Me.txtAboutAddress.Size = New System.Drawing.Size(40, 20)
        Me.txtAboutAddress.TabIndex = 38
        Me.txtAboutAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAboutAddress
        '
        Me.lblAboutAddress.AutoSize = True
        Me.lblAboutAddress.Location = New System.Drawing.Point(8, 95)
        Me.lblAboutAddress.Name = "lblAboutAddress"
        Me.lblAboutAddress.Size = New System.Drawing.Size(73, 13)
        Me.lblAboutAddress.TabIndex = 37
        Me.lblAboutAddress.Text = "USB Address:"
        '
        'colInPin
        '
        DataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control
        Me.colInPin.DefaultCellStyle = DataGridViewCellStyle46
        Me.colInPin.HeaderText = "Pin"
        Me.colInPin.Name = "colInPin"
        Me.colInPin.ReadOnly = True
        Me.colInPin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colInPin.Width = 30
        '
        'colInSelected
        '
        Me.colInSelected.HeaderText = "Enabled"
        Me.colInSelected.Name = "colInSelected"
        Me.colInSelected.ReadOnly = True
        Me.colInSelected.Width = 50
        '
        'cmdAboutVendorGet
        '
        Me.cmdAboutVendorGet.Location = New System.Drawing.Point(224, 116)
        Me.cmdAboutVendorGet.Name = "cmdAboutVendorGet"
        Me.cmdAboutVendorGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutVendorGet.TabIndex = 36
        Me.cmdAboutVendorGet.Text = "Get"
        Me.cmdAboutVendorGet.UseVisualStyleBackColor = True
        '
        'cmdAboutVendorSet
        '
        Me.cmdAboutVendorSet.Location = New System.Drawing.Point(305, 116)
        Me.cmdAboutVendorSet.Name = "cmdAboutVendorSet"
        Me.cmdAboutVendorSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutVendorSet.TabIndex = 35
        Me.cmdAboutVendorSet.Text = "Set"
        Me.cmdAboutVendorSet.UseVisualStyleBackColor = True
        '
        'cmdAboutProductGet
        '
        Me.cmdAboutProductGet.Location = New System.Drawing.Point(224, 142)
        Me.cmdAboutProductGet.Name = "cmdAboutProductGet"
        Me.cmdAboutProductGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutProductGet.TabIndex = 34
        Me.cmdAboutProductGet.Text = "Get"
        Me.cmdAboutProductGet.UseVisualStyleBackColor = True
        '
        'cmdAboutProductSet
        '
        Me.cmdAboutProductSet.Location = New System.Drawing.Point(305, 142)
        Me.cmdAboutProductSet.Name = "cmdAboutProductSet"
        Me.cmdAboutProductSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutProductSet.TabIndex = 33
        Me.cmdAboutProductSet.Text = "Set"
        Me.cmdAboutProductSet.UseVisualStyleBackColor = True
        '
        'cmdAboutSerialGet
        '
        Me.cmdAboutSerialGet.Location = New System.Drawing.Point(224, 168)
        Me.cmdAboutSerialGet.Name = "cmdAboutSerialGet"
        Me.cmdAboutSerialGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutSerialGet.TabIndex = 32
        Me.cmdAboutSerialGet.Text = "Get"
        Me.cmdAboutSerialGet.UseVisualStyleBackColor = True
        '
        'txtAbout1stDevice
        '
        Me.txtAbout1stDevice.Location = New System.Drawing.Point(92, 35)
        Me.txtAbout1stDevice.Name = "txtAbout1stDevice"
        Me.txtAbout1stDevice.ReadOnly = True
        Me.txtAbout1stDevice.Size = New System.Drawing.Size(40, 20)
        Me.txtAbout1stDevice.TabIndex = 29
        Me.txtAbout1stDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAbout1stDevice
        '
        Me.lblAbout1stDevice.AutoSize = True
        Me.lblAbout1stDevice.Location = New System.Drawing.Point(8, 38)
        Me.lblAbout1stDevice.Name = "lblAbout1stDevice"
        Me.lblAbout1stDevice.Size = New System.Drawing.Size(59, 13)
        Me.lblAbout1stDevice.TabIndex = 28
        Me.lblAbout1stDevice.Text = "1st device:"
        '
        'dgwDigiInPinsBlockSettings
        '
        Me.dgwDigiInPinsBlockSettings.AllowUserToAddRows = False
        Me.dgwDigiInPinsBlockSettings.AllowUserToDeleteRows = False
        Me.dgwDigiInPinsBlockSettings.AllowUserToResizeColumns = False
        Me.dgwDigiInPinsBlockSettings.AllowUserToResizeRows = False
        Me.dgwDigiInPinsBlockSettings.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwDigiInPinsBlockSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwDigiInPinsBlockSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwDigiInPinsBlockSettings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInPin, Me.colInSelected, Me.cmbInValue})
        Me.dgwDigiInPinsBlockSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgwDigiInPinsBlockSettings.Location = New System.Drawing.Point(75, 68)
        Me.dgwDigiInPinsBlockSettings.Name = "dgwDigiInPinsBlockSettings"
        Me.dgwDigiInPinsBlockSettings.ReadOnly = True
        Me.dgwDigiInPinsBlockSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgwDigiInPinsBlockSettings.RowHeadersVisible = False
        Me.dgwDigiInPinsBlockSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgwDigiInPinsBlockSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwDigiInPinsBlockSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwDigiInPinsBlockSettings.Size = New System.Drawing.Size(148, 163)
        Me.dgwDigiInPinsBlockSettings.TabIndex = 21
        '
        'lblDigiOutPinsBlockSettings
        '
        Me.lblDigiOutPinsBlockSettings.AutoSize = True
        Me.lblDigiOutPinsBlockSettings.Location = New System.Drawing.Point(8, 74)
        Me.lblDigiOutPinsBlockSettings.Name = "lblDigiOutPinsBlockSettings"
        Me.lblDigiOutPinsBlockSettings.Size = New System.Drawing.Size(48, 13)
        Me.lblDigiOutPinsBlockSettings.TabIndex = 9
        Me.lblDigiOutPinsBlockSettings.Text = "Settings:"
        '
        'txtAboutNumOfDevices
        '
        Me.txtAboutNumOfDevices.Location = New System.Drawing.Point(92, 8)
        Me.txtAboutNumOfDevices.Name = "txtAboutNumOfDevices"
        Me.txtAboutNumOfDevices.ReadOnly = True
        Me.txtAboutNumOfDevices.Size = New System.Drawing.Size(40, 20)
        Me.txtAboutNumOfDevices.TabIndex = 27
        Me.txtAboutNumOfDevices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdDigiOutPinsBlockSet
        '
        Me.cmdDigiOutPinsBlockSet.Location = New System.Drawing.Point(305, 208)
        Me.cmdDigiOutPinsBlockSet.Name = "cmdDigiOutPinsBlockSet"
        Me.cmdDigiOutPinsBlockSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdDigiOutPinsBlockSet.TabIndex = 11
        Me.cmdDigiOutPinsBlockSet.Text = "Set"
        Me.cmdDigiOutPinsBlockSet.UseVisualStyleBackColor = True
        '
        'cmbDigiOutPinsBlock
        '
        Me.cmbDigiOutPinsBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDigiOutPinsBlock.FormattingEnabled = True
        Me.cmbDigiOutPinsBlock.Items.AddRange(New Object() {"A", "B"})
        Me.cmbDigiOutPinsBlock.Location = New System.Drawing.Point(75, 39)
        Me.cmbDigiOutPinsBlock.Name = "cmbDigiOutPinsBlock"
        Me.cmbDigiOutPinsBlock.Size = New System.Drawing.Size(50, 21)
        Me.cmbDigiOutPinsBlock.TabIndex = 8
        '
        'lblDigiOutPinsBlock
        '
        Me.lblDigiOutPinsBlock.AutoSize = True
        Me.lblDigiOutPinsBlock.Location = New System.Drawing.Point(8, 42)
        Me.lblDigiOutPinsBlock.Name = "lblDigiOutPinsBlock"
        Me.lblDigiOutPinsBlock.Size = New System.Drawing.Size(60, 13)
        Me.lblDigiOutPinsBlock.TabIndex = 7
        Me.lblDigiOutPinsBlock.Text = "Pins Block:"
        '
        'cmdDigiOutPinSet
        '
        Me.cmdDigiOutPinSet.Location = New System.Drawing.Point(305, 6)
        Me.cmdDigiOutPinSet.Name = "cmdDigiOutPinSet"
        Me.cmdDigiOutPinSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdDigiOutPinSet.TabIndex = 6
        Me.cmdDigiOutPinSet.Text = "Set"
        Me.cmdDigiOutPinSet.UseVisualStyleBackColor = True
        '
        'lblDigiOutPinValue
        '
        Me.lblDigiOutPinValue.AutoSize = True
        Me.lblDigiOutPinValue.Location = New System.Drawing.Point(150, 11)
        Me.lblDigiOutPinValue.Name = "lblDigiOutPinValue"
        Me.lblDigiOutPinValue.Size = New System.Drawing.Size(37, 13)
        Me.lblDigiOutPinValue.TabIndex = 5
        Me.lblDigiOutPinValue.Text = "Value:"
        '
        'cmbDigiOutPinValue
        '
        Me.cmbDigiOutPinValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDigiOutPinValue.FormattingEnabled = True
        Me.cmbDigiOutPinValue.Items.AddRange(New Object() {"0", "1"})
        Me.cmbDigiOutPinValue.Location = New System.Drawing.Point(200, 8)
        Me.cmbDigiOutPinValue.Name = "cmbDigiOutPinValue"
        Me.cmbDigiOutPinValue.Size = New System.Drawing.Size(40, 21)
        Me.cmbDigiOutPinValue.TabIndex = 4
        '
        'cmbDigiOutPin
        '
        Me.cmbDigiOutPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDigiOutPin.FormattingEnabled = True
        Me.cmbDigiOutPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbDigiOutPin.Location = New System.Drawing.Point(75, 8)
        Me.cmbDigiOutPin.Name = "cmbDigiOutPin"
        Me.cmbDigiOutPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbDigiOutPin.TabIndex = 3
        '
        'lblDigiOutPin
        '
        Me.lblDigiOutPin.AutoSize = True
        Me.lblDigiOutPin.Location = New System.Drawing.Point(8, 11)
        Me.lblDigiOutPin.Name = "lblDigiOutPin"
        Me.lblDigiOutPin.Size = New System.Drawing.Size(56, 13)
        Me.lblDigiOutPin.TabIndex = 2
        Me.lblDigiOutPin.Text = "Pin Name:"
        '
        'lblAboutNumOfDevices
        '
        Me.lblAboutNumOfDevices.AutoSize = True
        Me.lblAboutNumOfDevices.Location = New System.Drawing.Point(8, 11)
        Me.lblAboutNumOfDevices.Name = "lblAboutNumOfDevices"
        Me.lblAboutNumOfDevices.Size = New System.Drawing.Size(86, 13)
        Me.lblAboutNumOfDevices.TabIndex = 26
        Me.lblAboutNumOfDevices.Text = "Num of Devices:"
        '
        'tabDigiIn
        '
        Me.tabDigiIn.Controls.Add(Me.txtDigiInPinValue)
        Me.tabDigiIn.Controls.Add(Me.lblDigiInPinValue)
        Me.tabDigiIn.Controls.Add(Me.Panel2)
        Me.tabDigiIn.Controls.Add(Me.cmdDigiInPinsBlockGet)
        Me.tabDigiIn.Controls.Add(Me.dgwDigiInPinsBlockSettings)
        Me.tabDigiIn.Controls.Add(Me.lblDigiInPinsBlockSettings)
        Me.tabDigiIn.Controls.Add(Me.cmbDigiInPinsBlock)
        Me.tabDigiIn.Controls.Add(Me.lblDigiInPinsBlock)
        Me.tabDigiIn.Controls.Add(Me.cmdDigiInPinSet)
        Me.tabDigiIn.Controls.Add(Me.cmbDigiInPin)
        Me.tabDigiIn.Controls.Add(Me.lblDigiInPin)
        Me.tabDigiIn.Location = New System.Drawing.Point(4, 22)
        Me.tabDigiIn.Name = "tabDigiIn"
        Me.tabDigiIn.Size = New System.Drawing.Size(382, 246)
        Me.tabDigiIn.TabIndex = 2
        Me.tabDigiIn.Text = "Digi IN"
        Me.tabDigiIn.UseVisualStyleBackColor = True
        '
        'txtDigiInPinValue
        '
        Me.txtDigiInPinValue.Location = New System.Drawing.Point(200, 8)
        Me.txtDigiInPinValue.Name = "txtDigiInPinValue"
        Me.txtDigiInPinValue.ReadOnly = True
        Me.txtDigiInPinValue.Size = New System.Drawing.Size(40, 20)
        Me.txtDigiInPinValue.TabIndex = 25
        Me.txtDigiInPinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDigiInPinValue
        '
        Me.lblDigiInPinValue.AutoSize = True
        Me.lblDigiInPinValue.Location = New System.Drawing.Point(150, 11)
        Me.lblDigiInPinValue.Name = "lblDigiInPinValue"
        Me.lblDigiInPinValue.Size = New System.Drawing.Size(37, 13)
        Me.lblDigiInPinValue.TabIndex = 24
        Me.lblDigiInPinValue.Text = "Value:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 1)
        Me.Panel2.TabIndex = 23
        '
        'cmdDigiInPinsBlockGet
        '
        Me.cmdDigiInPinsBlockGet.Location = New System.Drawing.Point(305, 208)
        Me.cmdDigiInPinsBlockGet.Name = "cmdDigiInPinsBlockGet"
        Me.cmdDigiInPinsBlockGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdDigiInPinsBlockGet.TabIndex = 22
        Me.cmdDigiInPinsBlockGet.Text = "Get"
        Me.cmdDigiInPinsBlockGet.UseVisualStyleBackColor = True
        '
        'lblDigiInPinsBlockSettings
        '
        Me.lblDigiInPinsBlockSettings.AutoSize = True
        Me.lblDigiInPinsBlockSettings.Location = New System.Drawing.Point(8, 74)
        Me.lblDigiInPinsBlockSettings.Name = "lblDigiInPinsBlockSettings"
        Me.lblDigiInPinsBlockSettings.Size = New System.Drawing.Size(48, 13)
        Me.lblDigiInPinsBlockSettings.TabIndex = 20
        Me.lblDigiInPinsBlockSettings.Text = "Settings:"
        '
        'cmbDigiInPinsBlock
        '
        Me.cmbDigiInPinsBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDigiInPinsBlock.FormattingEnabled = True
        Me.cmbDigiInPinsBlock.Items.AddRange(New Object() {"A", "B"})
        Me.cmbDigiInPinsBlock.Location = New System.Drawing.Point(75, 39)
        Me.cmbDigiInPinsBlock.Name = "cmbDigiInPinsBlock"
        Me.cmbDigiInPinsBlock.Size = New System.Drawing.Size(50, 21)
        Me.cmbDigiInPinsBlock.TabIndex = 19
        '
        'lblDigiInPinsBlock
        '
        Me.lblDigiInPinsBlock.AutoSize = True
        Me.lblDigiInPinsBlock.Location = New System.Drawing.Point(8, 42)
        Me.lblDigiInPinsBlock.Name = "lblDigiInPinsBlock"
        Me.lblDigiInPinsBlock.Size = New System.Drawing.Size(60, 13)
        Me.lblDigiInPinsBlock.TabIndex = 18
        Me.lblDigiInPinsBlock.Text = "Pins Block:"
        '
        'cmdDigiInPinSet
        '
        Me.cmdDigiInPinSet.Location = New System.Drawing.Point(305, 6)
        Me.cmdDigiInPinSet.Name = "cmdDigiInPinSet"
        Me.cmdDigiInPinSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdDigiInPinSet.TabIndex = 17
        Me.cmdDigiInPinSet.Text = "Get"
        Me.cmdDigiInPinSet.UseVisualStyleBackColor = True
        '
        'cmbDigiInPin
        '
        Me.cmbDigiInPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDigiInPin.FormattingEnabled = True
        Me.cmbDigiInPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbDigiInPin.Location = New System.Drawing.Point(75, 8)
        Me.cmbDigiInPin.Name = "cmbDigiInPin"
        Me.cmbDigiInPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbDigiInPin.TabIndex = 14
        '
        'lblDigiInPin
        '
        Me.lblDigiInPin.AutoSize = True
        Me.lblDigiInPin.Location = New System.Drawing.Point(8, 11)
        Me.lblDigiInPin.Name = "lblDigiInPin"
        Me.lblDigiInPin.Size = New System.Drawing.Size(56, 13)
        Me.lblDigiInPin.TabIndex = 13
        Me.lblDigiInPin.Text = "Pin Name:"
        '
        'cmdAboutSerialSet
        '
        Me.cmdAboutSerialSet.Location = New System.Drawing.Point(305, 168)
        Me.cmdAboutSerialSet.Name = "cmdAboutSerialSet"
        Me.cmdAboutSerialSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAboutSerialSet.TabIndex = 5
        Me.cmdAboutSerialSet.Text = "Set"
        Me.cmdAboutSerialSet.UseVisualStyleBackColor = True
        '
        'txtAboutSerial
        '
        Me.txtAboutSerial.Location = New System.Drawing.Point(92, 170)
        Me.txtAboutSerial.MaxLength = 32
        Me.txtAboutSerial.Name = "txtAboutSerial"
        Me.txtAboutSerial.Size = New System.Drawing.Size(126, 20)
        Me.txtAboutSerial.TabIndex = 7
        '
        'lblAboutSerial
        '
        Me.lblAboutSerial.AutoSize = True
        Me.lblAboutSerial.Location = New System.Drawing.Point(8, 173)
        Me.lblAboutSerial.Name = "lblAboutSerial"
        Me.lblAboutSerial.Size = New System.Drawing.Size(76, 13)
        Me.lblAboutSerial.TabIndex = 6
        Me.lblAboutSerial.Text = "Serial Number:"
        '
        'txtAboutProduct
        '
        Me.txtAboutProduct.Location = New System.Drawing.Point(92, 144)
        Me.txtAboutProduct.MaxLength = 32
        Me.txtAboutProduct.Name = "txtAboutProduct"
        Me.txtAboutProduct.Size = New System.Drawing.Size(126, 20)
        Me.txtAboutProduct.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(0, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(384, 1)
        Me.Panel4.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(0, -54)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(384, 1)
        Me.Panel6.TabIndex = 27
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.Location = New System.Drawing.Point(0, -54)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(384, 1)
        Me.Panel7.TabIndex = 26
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Window
        Me.Panel5.Location = New System.Drawing.Point(0, -54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(384, 1)
        Me.Panel5.TabIndex = 26
        '
        'grp1WireDirect
        '
        Me.grp1WireDirect.Controls.Add(Me.cmd1WireReadBit)
        Me.grp1WireDirect.Controls.Add(Me.cmd1WireWriteBit0)
        Me.grp1WireDirect.Controls.Add(Me.cmd1WireWriteBit1)
        Me.grp1WireDirect.Controls.Add(Me.cmd1WireReset)
        Me.grp1WireDirect.Location = New System.Drawing.Point(2, 195)
        Me.grp1WireDirect.Name = "grp1WireDirect"
        Me.grp1WireDirect.Size = New System.Drawing.Size(384, 55)
        Me.grp1WireDirect.TabIndex = 64
        Me.grp1WireDirect.TabStop = False
        Me.grp1WireDirect.Text = "Direct Bus Commands"
        '
        'cmd1WireReadBit
        '
        Me.cmd1WireReadBit.Location = New System.Drawing.Point(303, 19)
        Me.cmd1WireReadBit.Name = "cmd1WireReadBit"
        Me.cmd1WireReadBit.Size = New System.Drawing.Size(75, 23)
        Me.cmd1WireReadBit.TabIndex = 68
        Me.cmd1WireReadBit.Text = "Read bit"
        Me.cmd1WireReadBit.UseVisualStyleBackColor = True
        '
        'cmd1WireWriteBit0
        '
        Me.cmd1WireWriteBit0.Location = New System.Drawing.Point(204, 19)
        Me.cmd1WireWriteBit0.Name = "cmd1WireWriteBit0"
        Me.cmd1WireWriteBit0.Size = New System.Drawing.Size(75, 23)
        Me.cmd1WireWriteBit0.TabIndex = 67
        Me.cmd1WireWriteBit0.Text = "Write bit '0'"
        Me.cmd1WireWriteBit0.UseVisualStyleBackColor = True
        '
        'cmd1WireWriteBit1
        '
        Me.cmd1WireWriteBit1.Location = New System.Drawing.Point(105, 19)
        Me.cmd1WireWriteBit1.Name = "cmd1WireWriteBit1"
        Me.cmd1WireWriteBit1.Size = New System.Drawing.Size(75, 23)
        Me.cmd1WireWriteBit1.TabIndex = 66
        Me.cmd1WireWriteBit1.Text = "Write bit '1'"
        Me.cmd1WireWriteBit1.UseVisualStyleBackColor = True
        '
        'cmd1WireReset
        '
        Me.cmd1WireReset.Location = New System.Drawing.Point(6, 19)
        Me.cmd1WireReset.Name = "cmd1WireReset"
        Me.cmd1WireReset.Size = New System.Drawing.Size(75, 23)
        Me.cmd1WireReset.TabIndex = 65
        Me.cmd1WireReset.Text = "Reset"
        Me.cmd1WireReset.UseVisualStyleBackColor = True
        '
        'cmd1WireDQPinSet
        '
        Me.cmd1WireDQPinSet.Location = New System.Drawing.Point(295, 6)
        Me.cmd1WireDQPinSet.Name = "cmd1WireDQPinSet"
        Me.cmd1WireDQPinSet.Size = New System.Drawing.Size(75, 23)
        Me.cmd1WireDQPinSet.TabIndex = 51
        Me.cmd1WireDQPinSet.Text = "Set"
        Me.cmd1WireDQPinSet.UseVisualStyleBackColor = True
        '
        'cmb1WireDQPin
        '
        Me.cmb1WireDQPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb1WireDQPin.FormattingEnabled = True
        Me.cmb1WireDQPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmb1WireDQPin.Location = New System.Drawing.Point(77, 8)
        Me.cmb1WireDQPin.Name = "cmb1WireDQPin"
        Me.cmb1WireDQPin.Size = New System.Drawing.Size(50, 21)
        Me.cmb1WireDQPin.TabIndex = 48
        '
        'lbl1WireDQPin
        '
        Me.lbl1WireDQPin.AutoSize = True
        Me.lbl1WireDQPin.Location = New System.Drawing.Point(8, 11)
        Me.lbl1WireDQPin.Name = "lbl1WireDQPin"
        Me.lbl1WireDQPin.Size = New System.Drawing.Size(44, 13)
        Me.lbl1WireDQPin.TabIndex = 47
        Me.lbl1WireDQPin.Text = "DQ Pin:"
        '
        'rtbStatus
        '
        Me.rtbStatus.Location = New System.Drawing.Point(0, 40)
        Me.rtbStatus.Name = "rtbStatus"
        Me.rtbStatus.ReadOnly = True
        Me.rtbStatus.Size = New System.Drawing.Size(386, 210)
        Me.rtbStatus.TabIndex = 0
        Me.rtbStatus.Text = ""
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.Label1)
        Me.grpStatus.Controls.Add(Me.rtbStatus)
        Me.grpStatus.Controls.Add(Me.cmdStatusClear)
        Me.grpStatus.Location = New System.Drawing.Point(559, 323)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(390, 250)
        Me.grpStatus.TabIndex = 8
        Me.grpStatus.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Output"
        '
        'cmdStatusClear
        '
        Me.cmdStatusClear.Location = New System.Drawing.Point(305, 13)
        Me.cmdStatusClear.Name = "cmdStatusClear"
        Me.cmdStatusClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdStatusClear.TabIndex = 2
        Me.cmdStatusClear.Text = "Clear"
        Me.cmdStatusClear.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel9.Location = New System.Drawing.Point(0, 33)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(384, 1)
        Me.Panel9.TabIndex = 52
        '
        'tabPWM
        '
        Me.tabPWM.Controls.Add(Me.Button17)
        Me.tabPWM.Controls.Add(Me.Button16)
        Me.tabPWM.Controls.Add(Me.txtPWMPinValue3)
        Me.tabPWM.Controls.Add(Me.trbPWMPinValue3)
        Me.tabPWM.Controls.Add(Me.Button15)
        Me.tabPWM.Controls.Add(Me.cmbPWMPin3)
        Me.tabPWM.Controls.Add(Me.Label10)
        Me.tabPWM.Controls.Add(Me.txtPWMPinValue2)
        Me.tabPWM.Controls.Add(Me.trbPWMPinValue2)
        Me.tabPWM.Controls.Add(Me.Button14)
        Me.tabPWM.Controls.Add(Me.cmbPWMPin2)
        Me.tabPWM.Controls.Add(Me.Label9)
        Me.tabPWM.Controls.Add(Me.txtPWMPinValue1)
        Me.tabPWM.Controls.Add(Me.trbPWMPinValue1)
        Me.tabPWM.Controls.Add(Me.Button13)
        Me.tabPWM.Controls.Add(Me.cmbPWMPin1)
        Me.tabPWM.Controls.Add(Me.Label8)
        Me.tabPWM.Controls.Add(Me.txtPWMPinValue)
        Me.tabPWM.Controls.Add(Me.trbPWMPinValue)
        Me.tabPWM.Controls.Add(Me.cmdPWMPinSet)
        Me.tabPWM.Controls.Add(Me.cmbPWMPin)
        Me.tabPWM.Controls.Add(Me.lblPWMPin)
        Me.tabPWM.Location = New System.Drawing.Point(4, 22)
        Me.tabPWM.Name = "tabPWM"
        Me.tabPWM.Size = New System.Drawing.Size(382, 246)
        Me.tabPWM.TabIndex = 3
        Me.tabPWM.Text = "PWM"
        Me.tabPWM.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(297, 209)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(75, 23)
        Me.Button17.TabIndex = 30
        Me.Button17.Text = "Set All"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(41, 209)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 29
        Me.Button16.Text = "Stop All"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'txtPWMPinValue3
        '
        Me.txtPWMPinValue3.Location = New System.Drawing.Point(243, 160)
        Me.txtPWMPinValue3.Name = "txtPWMPinValue3"
        Me.txtPWMPinValue3.ReadOnly = True
        Me.txtPWMPinValue3.Size = New System.Drawing.Size(42, 20)
        Me.txtPWMPinValue3.TabIndex = 28
        Me.txtPWMPinValue3.Text = "50%"
        Me.txtPWMPinValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'trbPWMPinValue3
        '
        Me.trbPWMPinValue3.Location = New System.Drawing.Point(98, 153)
        Me.trbPWMPinValue3.Maximum = 100
        Me.trbPWMPinValue3.Name = "trbPWMPinValue3"
        Me.trbPWMPinValue3.Size = New System.Drawing.Size(143, 42)
        Me.trbPWMPinValue3.TabIndex = 27
        Me.trbPWMPinValue3.TickFrequency = 10
        Me.trbPWMPinValue3.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trbPWMPinValue3.Value = 50
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(298, 160)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 26
        Me.Button15.Text = "Set"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'cmbPWMPin3
        '
        Me.cmbPWMPin3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPWMPin3.FormattingEnabled = True
        Me.cmbPWMPin3.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6"})
        Me.cmbPWMPin3.Location = New System.Drawing.Point(41, 160)
        Me.cmbPWMPin3.Name = "cmbPWMPin3"
        Me.cmbPWMPin3.Size = New System.Drawing.Size(50, 21)
        Me.cmbPWMPin3.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Pin:"
        '
        'txtPWMPinValue2
        '
        Me.txtPWMPinValue2.Location = New System.Drawing.Point(243, 109)
        Me.txtPWMPinValue2.Name = "txtPWMPinValue2"
        Me.txtPWMPinValue2.ReadOnly = True
        Me.txtPWMPinValue2.Size = New System.Drawing.Size(42, 20)
        Me.txtPWMPinValue2.TabIndex = 23
        Me.txtPWMPinValue2.Text = "50%"
        Me.txtPWMPinValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'trbPWMPinValue2
        '
        Me.trbPWMPinValue2.Location = New System.Drawing.Point(98, 102)
        Me.trbPWMPinValue2.Maximum = 100
        Me.trbPWMPinValue2.Name = "trbPWMPinValue2"
        Me.trbPWMPinValue2.Size = New System.Drawing.Size(143, 42)
        Me.trbPWMPinValue2.TabIndex = 22
        Me.trbPWMPinValue2.TickFrequency = 10
        Me.trbPWMPinValue2.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trbPWMPinValue2.Value = 50
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(298, 109)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 21
        Me.Button14.Text = "Set"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'cmbPWMPin2
        '
        Me.cmbPWMPin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPWMPin2.FormattingEnabled = True
        Me.cmbPWMPin2.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6"})
        Me.cmbPWMPin2.Location = New System.Drawing.Point(41, 109)
        Me.cmbPWMPin2.Name = "cmbPWMPin2"
        Me.cmbPWMPin2.Size = New System.Drawing.Size(50, 21)
        Me.cmbPWMPin2.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Pin:"
        '
        'txtPWMPinValue1
        '
        Me.txtPWMPinValue1.Location = New System.Drawing.Point(242, 59)
        Me.txtPWMPinValue1.Name = "txtPWMPinValue1"
        Me.txtPWMPinValue1.ReadOnly = True
        Me.txtPWMPinValue1.Size = New System.Drawing.Size(42, 20)
        Me.txtPWMPinValue1.TabIndex = 18
        Me.txtPWMPinValue1.Text = "50%"
        Me.txtPWMPinValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'trbPWMPinValue1
        '
        Me.trbPWMPinValue1.Location = New System.Drawing.Point(97, 52)
        Me.trbPWMPinValue1.Maximum = 100
        Me.trbPWMPinValue1.Name = "trbPWMPinValue1"
        Me.trbPWMPinValue1.Size = New System.Drawing.Size(143, 42)
        Me.trbPWMPinValue1.TabIndex = 17
        Me.trbPWMPinValue1.TickFrequency = 10
        Me.trbPWMPinValue1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trbPWMPinValue1.Value = 50
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(297, 59)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "Set"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'cmbPWMPin1
        '
        Me.cmbPWMPin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPWMPin1.FormattingEnabled = True
        Me.cmbPWMPin1.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6"})
        Me.cmbPWMPin1.Location = New System.Drawing.Point(40, 59)
        Me.cmbPWMPin1.Name = "cmbPWMPin1"
        Me.cmbPWMPin1.Size = New System.Drawing.Size(50, 21)
        Me.cmbPWMPin1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Pin:"
        '
        'txtPWMPinValue
        '
        Me.txtPWMPinValue.Location = New System.Drawing.Point(242, 11)
        Me.txtPWMPinValue.Name = "txtPWMPinValue"
        Me.txtPWMPinValue.ReadOnly = True
        Me.txtPWMPinValue.Size = New System.Drawing.Size(42, 20)
        Me.txtPWMPinValue.TabIndex = 13
        Me.txtPWMPinValue.Text = "50%"
        Me.txtPWMPinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'trbPWMPinValue
        '
        Me.trbPWMPinValue.Location = New System.Drawing.Point(97, 4)
        Me.trbPWMPinValue.Maximum = 100
        Me.trbPWMPinValue.Name = "trbPWMPinValue"
        Me.trbPWMPinValue.Size = New System.Drawing.Size(143, 42)
        Me.trbPWMPinValue.TabIndex = 12
        Me.trbPWMPinValue.TickFrequency = 10
        Me.trbPWMPinValue.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trbPWMPinValue.Value = 50
        '
        'cmdPWMPinSet
        '
        Me.cmdPWMPinSet.Location = New System.Drawing.Point(297, 11)
        Me.cmdPWMPinSet.Name = "cmdPWMPinSet"
        Me.cmdPWMPinSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdPWMPinSet.TabIndex = 11
        Me.cmdPWMPinSet.Text = "Set"
        Me.cmdPWMPinSet.UseVisualStyleBackColor = True
        '
        'cmbPWMPin
        '
        Me.cmbPWMPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPWMPin.FormattingEnabled = True
        Me.cmbPWMPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6"})
        Me.cmbPWMPin.Location = New System.Drawing.Point(40, 11)
        Me.cmbPWMPin.Name = "cmbPWMPin"
        Me.cmbPWMPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbPWMPin.TabIndex = 8
        '
        'lblPWMPin
        '
        Me.lblPWMPin.AutoSize = True
        Me.lblPWMPin.Location = New System.Drawing.Point(8, 15)
        Me.lblPWMPin.Name = "lblPWMPin"
        Me.lblPWMPin.Size = New System.Drawing.Size(25, 13)
        Me.lblPWMPin.TabIndex = 7
        Me.lblPWMPin.Text = "Pin:"
        '
        'tab1Wire
        '
        Me.tab1Wire.Controls.Add(Me.Label5)
        Me.tab1Wire.Controls.Add(Me.txt1WireResponse)
        Me.tab1Wire.Controls.Add(Me.Button7)
        Me.tab1Wire.Controls.Add(Me.Button8)
        Me.tab1Wire.Controls.Add(Me.Button9)
        Me.tab1Wire.Controls.Add(Me.Radio1Hex)
        Me.tab1Wire.Controls.Add(Me.Radio1asc)
        Me.tab1Wire.Controls.Add(Me.Label6)
        Me.tab1Wire.Controls.Add(Me.txt1WireData)
        Me.tab1Wire.Controls.Add(Me.Button10)
        Me.tab1Wire.Controls.Add(Me.txt1WireLen)
        Me.tab1Wire.Controls.Add(Me.Label7)
        Me.tab1Wire.Controls.Add(Me.grp1WireDirect)
        Me.tab1Wire.Controls.Add(Me.Panel9)
        Me.tab1Wire.Controls.Add(Me.cmd1WireDQPinSet)
        Me.tab1Wire.Controls.Add(Me.cmb1WireDQPin)
        Me.tab1Wire.Controls.Add(Me.lbl1WireDQPin)
        Me.tab1Wire.Location = New System.Drawing.Point(4, 22)
        Me.tab1Wire.Name = "tab1Wire"
        Me.tab1Wire.Size = New System.Drawing.Size(382, 246)
        Me.tab1Wire.TabIndex = 7
        Me.tab1Wire.Text = "1-Wire"
        Me.tab1Wire.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Result:"
        '
        'txt1WireResponse
        '
        Me.txt1WireResponse.Location = New System.Drawing.Point(14, 81)
        Me.txt1WireResponse.MaxLength = 60
        Me.txt1WireResponse.Multiline = True
        Me.txt1WireResponse.Name = "txt1WireResponse"
        Me.txt1WireResponse.ReadOnly = True
        Me.txt1WireResponse.Size = New System.Drawing.Size(354, 30)
        Me.txt1WireResponse.TabIndex = 75
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(293, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 74
        Me.Button7.Text = "Save"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(200, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 73
        Me.Button8.Text = "Load"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(107, 39)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 72
        Me.Button9.Text = "Write"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Radio1Hex
        '
        Me.Radio1Hex.AutoSize = True
        Me.Radio1Hex.Location = New System.Drawing.Point(323, 138)
        Me.Radio1Hex.Name = "Radio1Hex"
        Me.Radio1Hex.Size = New System.Drawing.Size(47, 17)
        Me.Radio1Hex.TabIndex = 71
        Me.Radio1Hex.Text = "HEX"
        Me.Radio1Hex.UseVisualStyleBackColor = True
        '
        'Radio1asc
        '
        Me.Radio1asc.AutoSize = True
        Me.Radio1asc.Checked = True
        Me.Radio1asc.Location = New System.Drawing.Point(255, 138)
        Me.Radio1asc.Name = "Radio1asc"
        Me.Radio1asc.Size = New System.Drawing.Size(52, 17)
        Me.Radio1asc.TabIndex = 70
        Me.Radio1asc.TabStop = True
        Me.Radio1asc.Text = "ASCII" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Radio1asc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Data To Write or to Write before Read"
        '
        'txt1WireData
        '
        Me.txt1WireData.Location = New System.Drawing.Point(16, 156)
        Me.txt1WireData.MaxLength = 60
        Me.txt1WireData.Multiline = True
        Me.txt1WireData.Name = "txt1WireData"
        Me.txt1WireData.Size = New System.Drawing.Size(352, 32)
        Me.txt1WireData.TabIndex = 68
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(14, 39)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 67
        Me.Button10.Text = "Read"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'txt1WireLen
        '
        Me.txt1WireLen.Location = New System.Drawing.Point(82, 117)
        Me.txt1WireLen.MaxLength = 2
        Me.txt1WireLen.Name = "txt1WireLen"
        Me.txt1WireLen.Size = New System.Drawing.Size(35, 20)
        Me.txt1WireLen.TabIndex = 66
        Me.txt1WireLen.Text = "60"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Data Length:"
        '
        'tabAnalogIn
        '
        Me.tabAnalogIn.Controls.Add(Me.Button12)
        Me.tabAnalogIn.Controls.Add(Me.Chart1)
        Me.tabAnalogIn.Controls.Add(Me.Button11)
        Me.tabAnalogIn.Controls.Add(Me.txtAnalogInPinValue)
        Me.tabAnalogIn.Controls.Add(Me.lblAnalogInPinValue)
        Me.tabAnalogIn.Controls.Add(Me.cmdAnalogInPinGet)
        Me.tabAnalogIn.Controls.Add(Me.cmbAnalogInPin)
        Me.tabAnalogIn.Controls.Add(Me.lblAnalogInPin)
        Me.tabAnalogIn.Location = New System.Drawing.Point(4, 22)
        Me.tabAnalogIn.Name = "tabAnalogIn"
        Me.tabAnalogIn.Size = New System.Drawing.Size(382, 246)
        Me.tabAnalogIn.TabIndex = 4
        Me.tabAnalogIn.Text = "Analog IN"
        Me.tabAnalogIn.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(112, 49)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 30
        Me.Button12.Text = "Stop"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea12.AxisX.CustomLabels.Add(CustomLabel12)
        ChartArea12.AxisX.IsLabelAutoFit = False
        ChartArea12.AxisX.IsMarginVisible = False
        ChartArea12.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None
        ChartArea12.AxisX.MajorGrid.Enabled = False
        ChartArea12.AxisX.MajorTickMark.Enabled = False
        ChartArea12.AxisX.ScrollBar.Enabled = False
        ChartArea12.AxisX2.IsMarginVisible = False
        ChartArea12.AxisX2.MajorGrid.Enabled = False
        ChartArea12.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea12.AxisY.MajorTickMark.Enabled = False
        ChartArea12.AxisY.Maximum = 5.0R
        ChartArea12.AxisY.Minimum = 0.0R
        ChartArea12.AxisY.ScrollBar.Enabled = False
        ChartArea12.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea12)
        Me.Chart1.Location = New System.Drawing.Point(-4, 78)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series12.Name = "Series1"
        Me.Chart1.Series.Add(Series12)
        Me.Chart1.Size = New System.Drawing.Size(390, 165)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart2"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(16, 49)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 29
        Me.Button11.Text = "Plot"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtAnalogInPinValue
        '
        Me.txtAnalogInPinValue.Location = New System.Drawing.Point(200, 8)
        Me.txtAnalogInPinValue.Name = "txtAnalogInPinValue"
        Me.txtAnalogInPinValue.ReadOnly = True
        Me.txtAnalogInPinValue.Size = New System.Drawing.Size(60, 20)
        Me.txtAnalogInPinValue.TabIndex = 27
        Me.txtAnalogInPinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnalogInPinValue
        '
        Me.lblAnalogInPinValue.AutoSize = True
        Me.lblAnalogInPinValue.Location = New System.Drawing.Point(150, 11)
        Me.lblAnalogInPinValue.Name = "lblAnalogInPinValue"
        Me.lblAnalogInPinValue.Size = New System.Drawing.Size(37, 13)
        Me.lblAnalogInPinValue.TabIndex = 26
        Me.lblAnalogInPinValue.Text = "Value:"
        '
        'cmdAnalogInPinGet
        '
        Me.cmdAnalogInPinGet.Location = New System.Drawing.Point(301, 6)
        Me.cmdAnalogInPinGet.Name = "cmdAnalogInPinGet"
        Me.cmdAnalogInPinGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnalogInPinGet.TabIndex = 11
        Me.cmdAnalogInPinGet.Text = "Get"
        Me.cmdAnalogInPinGet.UseVisualStyleBackColor = True
        '
        'cmbAnalogInPin
        '
        Me.cmbAnalogInPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnalogInPin.FormattingEnabled = True
        Me.cmbAnalogInPin.Items.AddRange(New Object() {"B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbAnalogInPin.Location = New System.Drawing.Point(75, 8)
        Me.cmbAnalogInPin.Name = "cmbAnalogInPin"
        Me.cmbAnalogInPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbAnalogInPin.TabIndex = 8
        '
        'lblAnalogInPin
        '
        Me.lblAnalogInPin.AutoSize = True
        Me.lblAnalogInPin.Location = New System.Drawing.Point(8, 11)
        Me.lblAnalogInPin.Name = "lblAnalogInPin"
        Me.lblAnalogInPin.Size = New System.Drawing.Size(56, 13)
        Me.lblAnalogInPin.TabIndex = 7
        Me.lblAnalogInPin.Text = "Pin Name:"
        '
        'lblAboutProduct
        '
        Me.lblAboutProduct.AutoSize = True
        Me.lblAboutProduct.Location = New System.Drawing.Point(8, 147)
        Me.lblAboutProduct.Name = "lblAboutProduct"
        Me.lblAboutProduct.Size = New System.Drawing.Size(47, 13)
        Me.lblAboutProduct.TabIndex = 4
        Me.lblAboutProduct.Text = "Product:"
        '
        'tabSPI
        '
        Me.tabSPI.Controls.Add(Me.Label3)
        Me.tabSPI.Controls.Add(Me.txtResultSPI)
        Me.tabSPI.Controls.Add(Me.Button3)
        Me.tabSPI.Controls.Add(Me.Button2)
        Me.tabSPI.Controls.Add(Me.Button1)
        Me.tabSPI.Controls.Add(Me.RadioHex)
        Me.tabSPI.Controls.Add(Me.RadioAscii)
        Me.tabSPI.Controls.Add(Me.Label2)
        Me.tabSPI.Controls.Add(Me.txtSPIData)
        Me.tabSPI.Controls.Add(Me.cmdSPIExecute)
        Me.tabSPI.Controls.Add(Me.txtSPIDataLen)
        Me.tabSPI.Controls.Add(Me.lblSPIDataLen)
        Me.tabSPI.Controls.Add(Me.Panel3)
        Me.tabSPI.Controls.Add(Me.cmbSPIPinsSet)
        Me.tabSPI.Controls.Add(Me.cmbSPIMISOPin)
        Me.tabSPI.Controls.Add(Me.lblSPIMISOPin)
        Me.tabSPI.Controls.Add(Me.cmbSPIMOSIPin)
        Me.tabSPI.Controls.Add(Me.lblSPIMOSIPin)
        Me.tabSPI.Controls.Add(Me.cmbSPISCKPin)
        Me.tabSPI.Controls.Add(Me.lblSPISCKPin)
        Me.tabSPI.Controls.Add(Me.cmbSPICSPin)
        Me.tabSPI.Controls.Add(Me.lblSPICSPin)
        Me.tabSPI.Location = New System.Drawing.Point(4, 22)
        Me.tabSPI.Name = "tabSPI"
        Me.tabSPI.Size = New System.Drawing.Size(382, 246)
        Me.tabSPI.TabIndex = 5
        Me.tabSPI.Text = "SPI"
        Me.tabSPI.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Result:"
        '
        'txtResultSPI
        '
        Me.txtResultSPI.Location = New System.Drawing.Point(14, 114)
        Me.txtResultSPI.MaxLength = 60
        Me.txtResultSPI.Multiline = True
        Me.txtResultSPI.Name = "txtResultSPI"
        Me.txtResultSPI.ReadOnly = True
        Me.txtResultSPI.Size = New System.Drawing.Size(354, 42)
        Me.txtResultSPI.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(293, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Write"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioHex
        '
        Me.RadioHex.AutoSize = True
        Me.RadioHex.Location = New System.Drawing.Point(323, 183)
        Me.RadioHex.Name = "RadioHex"
        Me.RadioHex.Size = New System.Drawing.Size(47, 17)
        Me.RadioHex.TabIndex = 38
        Me.RadioHex.Text = "HEX"
        Me.RadioHex.UseVisualStyleBackColor = True
        '
        'RadioAscii
        '
        Me.RadioAscii.AutoSize = True
        Me.RadioAscii.Checked = True
        Me.RadioAscii.Location = New System.Drawing.Point(255, 183)
        Me.RadioAscii.Name = "RadioAscii"
        Me.RadioAscii.Size = New System.Drawing.Size(52, 17)
        Me.RadioAscii.TabIndex = 37
        Me.RadioAscii.TabStop = True
        Me.RadioAscii.Text = "ASCII" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioAscii.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Data To Write or to Write before Read"
        '
        'txtSPIData
        '
        Me.txtSPIData.Location = New System.Drawing.Point(16, 201)
        Me.txtSPIData.MaxLength = 60
        Me.txtSPIData.Multiline = True
        Me.txtSPIData.Name = "txtSPIData"
        Me.txtSPIData.Size = New System.Drawing.Size(352, 45)
        Me.txtSPIData.TabIndex = 35
        '
        'cmdSPIExecute
        '
        Me.cmdSPIExecute.Location = New System.Drawing.Point(14, 67)
        Me.cmdSPIExecute.Name = "cmdSPIExecute"
        Me.cmdSPIExecute.Size = New System.Drawing.Size(75, 23)
        Me.cmdSPIExecute.TabIndex = 31
        Me.cmdSPIExecute.Text = "Read"
        Me.cmdSPIExecute.UseVisualStyleBackColor = True
        '
        'txtSPIDataLen
        '
        Me.txtSPIDataLen.Location = New System.Drawing.Point(82, 162)
        Me.txtSPIDataLen.MaxLength = 2
        Me.txtSPIDataLen.Name = "txtSPIDataLen"
        Me.txtSPIDataLen.Size = New System.Drawing.Size(35, 20)
        Me.txtSPIDataLen.TabIndex = 30
        Me.txtSPIDataLen.Text = "60"
        '
        'lblSPIDataLen
        '
        Me.lblSPIDataLen.AutoSize = True
        Me.lblSPIDataLen.Location = New System.Drawing.Point(13, 165)
        Me.lblSPIDataLen.Name = "lblSPIDataLen"
        Me.lblSPIDataLen.Size = New System.Drawing.Size(69, 13)
        Me.lblSPIDataLen.TabIndex = 29
        Me.lblSPIDataLen.Text = "Data Length:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 1)
        Me.Panel3.TabIndex = 24
        '
        'cmbSPIPinsSet
        '
        Me.cmbSPIPinsSet.Location = New System.Drawing.Point(293, 28)
        Me.cmbSPIPinsSet.Name = "cmbSPIPinsSet"
        Me.cmbSPIPinsSet.Size = New System.Drawing.Size(75, 23)
        Me.cmbSPIPinsSet.TabIndex = 23
        Me.cmbSPIPinsSet.Text = "Set"
        Me.cmbSPIPinsSet.UseVisualStyleBackColor = True
        '
        'cmbSPIMISOPin
        '
        Me.cmbSPIMISOPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSPIMISOPin.FormattingEnabled = True
        Me.cmbSPIMISOPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbSPIMISOPin.Location = New System.Drawing.Point(210, 35)
        Me.cmbSPIMISOPin.Name = "cmbSPIMISOPin"
        Me.cmbSPIMISOPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbSPIMISOPin.TabIndex = 22
        '
        'lblSPIMISOPin
        '
        Me.lblSPIMISOPin.AutoSize = True
        Me.lblSPIMISOPin.Location = New System.Drawing.Point(143, 38)
        Me.lblSPIMISOPin.Name = "lblSPIMISOPin"
        Me.lblSPIMISOPin.Size = New System.Drawing.Size(55, 13)
        Me.lblSPIMISOPin.TabIndex = 21
        Me.lblSPIMISOPin.Text = "MISO Pin:"
        '
        'cmbSPIMOSIPin
        '
        Me.cmbSPIMOSIPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSPIMOSIPin.FormattingEnabled = True
        Me.cmbSPIMOSIPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbSPIMOSIPin.Location = New System.Drawing.Point(75, 35)
        Me.cmbSPIMOSIPin.Name = "cmbSPIMOSIPin"
        Me.cmbSPIMOSIPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbSPIMOSIPin.TabIndex = 20
        '
        'lblSPIMOSIPin
        '
        Me.lblSPIMOSIPin.AutoSize = True
        Me.lblSPIMOSIPin.Location = New System.Drawing.Point(8, 38)
        Me.lblSPIMOSIPin.Name = "lblSPIMOSIPin"
        Me.lblSPIMOSIPin.Size = New System.Drawing.Size(55, 13)
        Me.lblSPIMOSIPin.TabIndex = 19
        Me.lblSPIMOSIPin.Text = "MOSI Pin:"
        '
        'cmbSPISCKPin
        '
        Me.cmbSPISCKPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSPISCKPin.FormattingEnabled = True
        Me.cmbSPISCKPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbSPISCKPin.Location = New System.Drawing.Point(210, 8)
        Me.cmbSPISCKPin.Name = "cmbSPISCKPin"
        Me.cmbSPISCKPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbSPISCKPin.TabIndex = 18
        '
        'lblSPISCKPin
        '
        Me.lblSPISCKPin.AutoSize = True
        Me.lblSPISCKPin.Location = New System.Drawing.Point(143, 11)
        Me.lblSPISCKPin.Name = "lblSPISCKPin"
        Me.lblSPISCKPin.Size = New System.Drawing.Size(49, 13)
        Me.lblSPISCKPin.TabIndex = 17
        Me.lblSPISCKPin.Text = "SCK Pin:"
        '
        'cmbSPICSPin
        '
        Me.cmbSPICSPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSPICSPin.FormattingEnabled = True
        Me.cmbSPICSPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbSPICSPin.Location = New System.Drawing.Point(75, 8)
        Me.cmbSPICSPin.Name = "cmbSPICSPin"
        Me.cmbSPICSPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbSPICSPin.TabIndex = 16
        '
        'lblSPICSPin
        '
        Me.lblSPICSPin.AutoSize = True
        Me.lblSPICSPin.Location = New System.Drawing.Point(8, 11)
        Me.lblSPICSPin.Name = "lblSPICSPin"
        Me.lblSPICSPin.Size = New System.Drawing.Size(42, 13)
        Me.lblSPICSPin.TabIndex = 15
        Me.lblSPICSPin.Text = "CS Pin:"
        '
        'txtI2CData
        '
        Me.txtI2CData.Location = New System.Drawing.Point(16, 201)
        Me.txtI2CData.MaxLength = 60
        Me.txtI2CData.Multiline = True
        Me.txtI2CData.Name = "txtI2CData"
        Me.txtI2CData.Size = New System.Drawing.Size(352, 45)
        Me.txtI2CData.TabIndex = 46
        '
        'txtI2CDataLen
        '
        Me.txtI2CDataLen.Location = New System.Drawing.Point(82, 162)
        Me.txtI2CDataLen.MaxLength = 2
        Me.txtI2CDataLen.Name = "txtI2CDataLen"
        Me.txtI2CDataLen.Size = New System.Drawing.Size(34, 20)
        Me.txtI2CDataLen.TabIndex = 41
        Me.txtI2CDataLen.Text = "60"
        '
        'lblI2CData
        '
        Me.lblI2CData.AutoSize = True
        Me.lblI2CData.Location = New System.Drawing.Point(13, 185)
        Me.lblI2CData.Name = "lblI2CData"
        Me.lblI2CData.Size = New System.Drawing.Size(188, 13)
        Me.lblI2CData.TabIndex = 45
        Me.lblI2CData.Text = "Data To Write or to Write before Read"
        '
        'cmdI2CExecute
        '
        Me.cmdI2CExecute.Location = New System.Drawing.Point(14, 49)
        Me.cmdI2CExecute.Name = "cmdI2CExecute"
        Me.cmdI2CExecute.Size = New System.Drawing.Size(75, 23)
        Me.cmdI2CExecute.TabIndex = 42
        Me.cmdI2CExecute.Text = "Read"
        Me.cmdI2CExecute.UseVisualStyleBackColor = True
        '
        'lblI2CDataLen
        '
        Me.lblI2CDataLen.AutoSize = True
        Me.lblI2CDataLen.Location = New System.Drawing.Point(13, 165)
        Me.lblI2CDataLen.Name = "lblI2CDataLen"
        Me.lblI2CDataLen.Size = New System.Drawing.Size(69, 13)
        Me.lblI2CDataLen.TabIndex = 40
        Me.lblI2CDataLen.Text = "Data Length:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel8.Location = New System.Drawing.Point(0, 33)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(384, 1)
        Me.Panel8.TabIndex = 29
        '
        'cmdI2CPinsSet
        '
        Me.cmdI2CPinsSet.Location = New System.Drawing.Point(305, 6)
        Me.cmdI2CPinsSet.Name = "cmdI2CPinsSet"
        Me.cmdI2CPinsSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdI2CPinsSet.TabIndex = 28
        Me.cmdI2CPinsSet.Text = "Set"
        Me.cmdI2CPinsSet.UseVisualStyleBackColor = True
        '
        'cmbI2CSDAPin
        '
        Me.cmbI2CSDAPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbI2CSDAPin.FormattingEnabled = True
        Me.cmbI2CSDAPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbI2CSDAPin.Location = New System.Drawing.Point(210, 8)
        Me.cmbI2CSDAPin.Name = "cmbI2CSDAPin"
        Me.cmbI2CSDAPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbI2CSDAPin.TabIndex = 27
        '
        'lblI2CSDAPin
        '
        Me.lblI2CSDAPin.AutoSize = True
        Me.lblI2CSDAPin.Location = New System.Drawing.Point(143, 11)
        Me.lblI2CSDAPin.Name = "lblI2CSDAPin"
        Me.lblI2CSDAPin.Size = New System.Drawing.Size(50, 13)
        Me.lblI2CSDAPin.TabIndex = 26
        Me.lblI2CSDAPin.Text = "SDA Pin:"
        '
        'cmbI2CSCLPin
        '
        Me.cmbI2CSCLPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbI2CSCLPin.FormattingEnabled = True
        Me.cmbI2CSCLPin.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12"})
        Me.cmbI2CSCLPin.Location = New System.Drawing.Point(75, 8)
        Me.cmbI2CSCLPin.Name = "cmbI2CSCLPin"
        Me.cmbI2CSCLPin.Size = New System.Drawing.Size(50, 21)
        Me.cmbI2CSCLPin.TabIndex = 25
        '
        'lblI2CSCLPin
        '
        Me.lblI2CSCLPin.AutoSize = True
        Me.lblI2CSCLPin.Location = New System.Drawing.Point(8, 11)
        Me.lblI2CSCLPin.Name = "lblI2CSCLPin"
        Me.lblI2CSCLPin.Size = New System.Drawing.Size(48, 13)
        Me.lblI2CSCLPin.TabIndex = 24
        Me.lblI2CSCLPin.Text = "SCL Pin:"
        '
        'tabI2C
        '
        Me.tabI2C.Controls.Add(Me.Label4)
        Me.tabI2C.Controls.Add(Me.I2CResult)
        Me.tabI2C.Controls.Add(Me.Button4)
        Me.tabI2C.Controls.Add(Me.Button5)
        Me.tabI2C.Controls.Add(Me.Button6)
        Me.tabI2C.Controls.Add(Me.RadioIHex)
        Me.tabI2C.Controls.Add(Me.RadioIAsc)
        Me.tabI2C.Controls.Add(Me.txtI2CData)
        Me.tabI2C.Controls.Add(Me.txtI2CDataLen)
        Me.tabI2C.Controls.Add(Me.lblI2CData)
        Me.tabI2C.Controls.Add(Me.cmdI2CExecute)
        Me.tabI2C.Controls.Add(Me.lblI2CDataLen)
        Me.tabI2C.Controls.Add(Me.Panel8)
        Me.tabI2C.Controls.Add(Me.cmdI2CPinsSet)
        Me.tabI2C.Controls.Add(Me.cmbI2CSDAPin)
        Me.tabI2C.Controls.Add(Me.lblI2CSDAPin)
        Me.tabI2C.Controls.Add(Me.cmbI2CSCLPin)
        Me.tabI2C.Controls.Add(Me.lblI2CSCLPin)
        Me.tabI2C.Location = New System.Drawing.Point(4, 22)
        Me.tabI2C.Name = "tabI2C"
        Me.tabI2C.Size = New System.Drawing.Size(382, 246)
        Me.tabI2C.TabIndex = 6
        Me.tabI2C.Text = "I2C"
        Me.tabI2C.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Result:"
        '
        'I2CResult
        '
        Me.I2CResult.Location = New System.Drawing.Point(14, 104)
        Me.I2CResult.MaxLength = 60
        Me.I2CResult.Multiline = True
        Me.I2CResult.Name = "I2CResult"
        Me.I2CResult.ReadOnly = True
        Me.I2CResult.Size = New System.Drawing.Size(354, 42)
        Me.I2CResult.TabIndex = 52
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(293, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(200, 49)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 50
        Me.Button5.Text = "Load"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(107, 49)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Write"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'RadioIHex
        '
        Me.RadioIHex.AutoSize = True
        Me.RadioIHex.Location = New System.Drawing.Point(323, 173)
        Me.RadioIHex.Name = "RadioIHex"
        Me.RadioIHex.Size = New System.Drawing.Size(47, 17)
        Me.RadioIHex.TabIndex = 48
        Me.RadioIHex.Text = "HEX"
        Me.RadioIHex.UseVisualStyleBackColor = True
        '
        'RadioIAsc
        '
        Me.RadioIAsc.AutoSize = True
        Me.RadioIAsc.Checked = True
        Me.RadioIAsc.Location = New System.Drawing.Point(255, 173)
        Me.RadioIAsc.Name = "RadioIAsc"
        Me.RadioIAsc.Size = New System.Drawing.Size(52, 17)
        Me.RadioIAsc.TabIndex = 47
        Me.RadioIAsc.TabStop = True
        Me.RadioIAsc.Text = "ASCII" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioIAsc.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle47
        Me.DataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Enabled"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle48
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pin"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'dgwDigiOutPinsBlockSettings
        '
        Me.dgwDigiOutPinsBlockSettings.AllowUserToAddRows = False
        Me.dgwDigiOutPinsBlockSettings.AllowUserToDeleteRows = False
        Me.dgwDigiOutPinsBlockSettings.AllowUserToResizeColumns = False
        Me.dgwDigiOutPinsBlockSettings.AllowUserToResizeRows = False
        Me.dgwDigiOutPinsBlockSettings.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwDigiOutPinsBlockSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwDigiOutPinsBlockSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwDigiOutPinsBlockSettings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgwDigiOutPinsBlockSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgwDigiOutPinsBlockSettings.Location = New System.Drawing.Point(75, 68)
        Me.dgwDigiOutPinsBlockSettings.Name = "dgwDigiOutPinsBlockSettings"
        Me.dgwDigiOutPinsBlockSettings.ReadOnly = True
        Me.dgwDigiOutPinsBlockSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgwDigiOutPinsBlockSettings.RowHeadersVisible = False
        Me.dgwDigiOutPinsBlockSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgwDigiOutPinsBlockSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwDigiOutPinsBlockSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwDigiOutPinsBlockSettings.Size = New System.Drawing.Size(148, 163)
        Me.dgwDigiOutPinsBlockSettings.TabIndex = 22
        '
        'txtAboutVendor
        '
        Me.txtAboutVendor.Location = New System.Drawing.Point(92, 118)
        Me.txtAboutVendor.MaxLength = 32
        Me.txtAboutVendor.Name = "txtAboutVendor"
        Me.txtAboutVendor.Size = New System.Drawing.Size(126, 20)
        Me.txtAboutVendor.TabIndex = 3
        '
        'lblAboutVendor
        '
        Me.lblAboutVendor.AutoSize = True
        Me.lblAboutVendor.Location = New System.Drawing.Point(8, 121)
        Me.lblAboutVendor.Name = "lblAboutVendor"
        Me.lblAboutVendor.Size = New System.Drawing.Size(44, 13)
        Me.lblAboutVendor.TabIndex = 2
        Me.lblAboutVendor.Text = "Vendor:"
        '
        'txtAboutVersion
        '
        Me.txtAboutVersion.Location = New System.Drawing.Point(92, 61)
        Me.txtAboutVersion.Name = "txtAboutVersion"
        Me.txtAboutVersion.ReadOnly = True
        Me.txtAboutVersion.Size = New System.Drawing.Size(40, 20)
        Me.txtAboutVersion.TabIndex = 1
        Me.txtAboutVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAboutVersion
        '
        Me.lblAboutVersion.AutoSize = True
        Me.lblAboutVersion.Location = New System.Drawing.Point(8, 64)
        Me.lblAboutVersion.Name = "lblAboutVersion"
        Me.lblAboutVersion.Size = New System.Drawing.Size(78, 13)
        Me.lblAboutVersion.TabIndex = 0
        Me.lblAboutVersion.Text = "Silicon version:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 1)
        Me.Panel1.TabIndex = 12
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.ErrOut)
        Me.tabAbout.Controls.Add(Me.cmdAboutAddressGet)
        Me.tabAbout.Controls.Add(Me.cmdAboutAddressSet)
        Me.tabAbout.Controls.Add(Me.txtAboutAddress)
        Me.tabAbout.Controls.Add(Me.lblAboutAddress)
        Me.tabAbout.Controls.Add(Me.cmdAboutVendorGet)
        Me.tabAbout.Controls.Add(Me.cmdAboutVendorSet)
        Me.tabAbout.Controls.Add(Me.cmdAboutProductGet)
        Me.tabAbout.Controls.Add(Me.cmdAboutProductSet)
        Me.tabAbout.Controls.Add(Me.cmdAboutSerialGet)
        Me.tabAbout.Controls.Add(Me.txtAbout1stDevice)
        Me.tabAbout.Controls.Add(Me.lblAbout1stDevice)
        Me.tabAbout.Controls.Add(Me.txtAboutNumOfDevices)
        Me.tabAbout.Controls.Add(Me.lblAboutNumOfDevices)
        Me.tabAbout.Controls.Add(Me.Panel4)
        Me.tabAbout.Controls.Add(Me.cmdAboutSerialSet)
        Me.tabAbout.Controls.Add(Me.txtAboutSerial)
        Me.tabAbout.Controls.Add(Me.lblAboutSerial)
        Me.tabAbout.Controls.Add(Me.txtAboutProduct)
        Me.tabAbout.Controls.Add(Me.lblAboutProduct)
        Me.tabAbout.Controls.Add(Me.txtAboutVendor)
        Me.tabAbout.Controls.Add(Me.lblAboutVendor)
        Me.tabAbout.Controls.Add(Me.txtAboutVersion)
        Me.tabAbout.Controls.Add(Me.lblAboutVersion)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(382, 246)
        Me.tabAbout.TabIndex = 0
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'ErrOut
        '
        Me.ErrOut.AutoSize = True
        Me.ErrOut.ForeColor = System.Drawing.Color.Red
        Me.ErrOut.Location = New System.Drawing.Point(169, 15)
        Me.ErrOut.Name = "ErrOut"
        Me.ErrOut.Size = New System.Drawing.Size(0, 13)
        Me.ErrOut.TabIndex = 43
        '
        'tabDigiOut
        '
        Me.tabDigiOut.Controls.Add(Me.dgwDigiOutPinsBlockSettings)
        Me.tabDigiOut.Controls.Add(Me.Panel1)
        Me.tabDigiOut.Controls.Add(Me.cmdDigiOutPinsBlockSet)
        Me.tabDigiOut.Controls.Add(Me.lblDigiOutPinsBlockSettings)
        Me.tabDigiOut.Controls.Add(Me.cmbDigiOutPinsBlock)
        Me.tabDigiOut.Controls.Add(Me.lblDigiOutPinsBlock)
        Me.tabDigiOut.Controls.Add(Me.cmdDigiOutPinSet)
        Me.tabDigiOut.Controls.Add(Me.lblDigiOutPinValue)
        Me.tabDigiOut.Controls.Add(Me.cmbDigiOutPinValue)
        Me.tabDigiOut.Controls.Add(Me.cmbDigiOutPin)
        Me.tabDigiOut.Controls.Add(Me.lblDigiOutPin)
        Me.tabDigiOut.Location = New System.Drawing.Point(4, 22)
        Me.tabDigiOut.Name = "tabDigiOut"
        Me.tabDigiOut.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDigiOut.Size = New System.Drawing.Size(382, 246)
        Me.tabDigiOut.TabIndex = 1
        Me.tabDigiOut.Text = "Digi OUT"
        Me.tabDigiOut.UseVisualStyleBackColor = True
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabAbout)
        Me.tabMain.Controls.Add(Me.tabDigiOut)
        Me.tabMain.Controls.Add(Me.tabDigiIn)
        Me.tabMain.Controls.Add(Me.tabPWM)
        Me.tabMain.Controls.Add(Me.tabAnalogIn)
        Me.tabMain.Controls.Add(Me.tabSPI)
        Me.tabMain.Controls.Add(Me.tabI2C)
        Me.tabMain.Controls.Add(Me.tab1Wire)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabMain.ItemSize = New System.Drawing.Size(32, 18)
        Me.tabMain.Location = New System.Drawing.Point(556, 49)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(390, 272)
        Me.tabMain.TabIndex = 6
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowScriptChange = False
        Me.FontDialog1.AllowVectorFonts = False
        Me.FontDialog1.ShowColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TotBytes)
        Me.Panel10.Controls.Add(Me.Start)
        Me.Panel10.Location = New System.Drawing.Point(444, 56)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(106, 43)
        Me.Panel10.TabIndex = 9
        Me.Panel10.Visible = False
        '
        'TotBytes
        '
        Me.TotBytes.Location = New System.Drawing.Point(5, 12)
        Me.TotBytes.Name = "TotBytes"
        Me.TotBytes.Size = New System.Drawing.Size(36, 20)
        Me.TotBytes.TabIndex = 1
        Me.TotBytes.Text = "60"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(47, 11)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(55, 23)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'FF32Gui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 573)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.Document)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.mainMenu)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(954, 600)
        Me.MinimumSize = New System.Drawing.Size(954, 550)
        Me.Name = "FF32Gui"
        Me.Text = "FF3xGui"
        Me.TransparencyKey = System.Drawing.Color.Firebrick
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.rcMenu.ResumeLayout(False)
        CType(Me.dgwDigiInPinsBlockSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDigiIn.ResumeLayout(False)
        Me.tabDigiIn.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.grp1WireDirect.ResumeLayout(False)
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.tabPWM.ResumeLayout(False)
        Me.tabPWM.PerformLayout()
        CType(Me.trbPWMPinValue3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbPWMPinValue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbPWMPinValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbPWMPinValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1Wire.ResumeLayout(False)
        Me.tab1Wire.PerformLayout()
        Me.tabAnalogIn.ResumeLayout(False)
        Me.tabAnalogIn.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSPI.ResumeLayout(False)
        Me.tabSPI.PerformLayout()
        Me.tabI2C.ResumeLayout(False)
        Me.tabI2C.PerformLayout()
        CType(Me.dgwDigiOutPinsBlockSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.tabDigiOut.ResumeLayout(False)
        Me.tabDigiOut.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents Tools As System.Windows.Forms.ToolStrip
    Friend WithEvents Document As System.Windows.Forms.RichTextBox
    Friend WithEvents rcMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents saveWork As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openWork As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbRun As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbZoom As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbInValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAboutAddressGet As System.Windows.Forms.Button
    Friend WithEvents cmdAboutAddressSet As System.Windows.Forms.Button
    Friend WithEvents txtAboutAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAboutAddress As System.Windows.Forms.Label
    Friend WithEvents colInPin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInSelected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmdAboutVendorGet As System.Windows.Forms.Button
    Friend WithEvents cmdAboutVendorSet As System.Windows.Forms.Button
    Friend WithEvents cmdAboutProductGet As System.Windows.Forms.Button
    Friend WithEvents cmdAboutProductSet As System.Windows.Forms.Button
    Friend WithEvents cmdAboutSerialGet As System.Windows.Forms.Button
    Friend WithEvents txtAbout1stDevice As System.Windows.Forms.TextBox
    Friend WithEvents lblAbout1stDevice As System.Windows.Forms.Label
    Friend WithEvents dgwDigiInPinsBlockSettings As System.Windows.Forms.DataGridView
    Friend WithEvents lblDigiOutPinsBlockSettings As System.Windows.Forms.Label
    Friend WithEvents txtAboutNumOfDevices As System.Windows.Forms.TextBox
    Friend WithEvents cmdDigiOutPinsBlockSet As System.Windows.Forms.Button
    Friend WithEvents cmbDigiOutPinsBlock As System.Windows.Forms.ComboBox
    Friend WithEvents lblDigiOutPinsBlock As System.Windows.Forms.Label
    Friend WithEvents cmdDigiOutPinSet As System.Windows.Forms.Button
    Friend WithEvents lblDigiOutPinValue As System.Windows.Forms.Label
    Friend WithEvents cmbDigiOutPinValue As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDigiOutPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblDigiOutPin As System.Windows.Forms.Label
    Friend WithEvents lblAboutNumOfDevices As System.Windows.Forms.Label
    Friend WithEvents tabDigiIn As System.Windows.Forms.TabPage
    Friend WithEvents txtDigiInPinValue As System.Windows.Forms.TextBox
    Friend WithEvents lblDigiInPinValue As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdDigiInPinsBlockGet As System.Windows.Forms.Button
    Friend WithEvents lblDigiInPinsBlockSettings As System.Windows.Forms.Label
    Friend WithEvents cmbDigiInPinsBlock As System.Windows.Forms.ComboBox
    Friend WithEvents lblDigiInPinsBlock As System.Windows.Forms.Label
    Friend WithEvents cmdDigiInPinSet As System.Windows.Forms.Button
    Friend WithEvents cmbDigiInPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblDigiInPin As System.Windows.Forms.Label
    Friend WithEvents cmdAboutSerialSet As System.Windows.Forms.Button
    Friend WithEvents txtAboutSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblAboutSerial As System.Windows.Forms.Label
    Friend WithEvents txtAboutProduct As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents grp1WireDirect As System.Windows.Forms.GroupBox
    Friend WithEvents cmd1WireReadBit As System.Windows.Forms.Button
    Friend WithEvents cmd1WireWriteBit0 As System.Windows.Forms.Button
    Friend WithEvents cmd1WireWriteBit1 As System.Windows.Forms.Button
    Friend WithEvents cmd1WireReset As System.Windows.Forms.Button
    Friend WithEvents cmd1WireDQPinSet As System.Windows.Forms.Button
    Friend WithEvents cmb1WireDQPin As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1WireDQPin As System.Windows.Forms.Label
    Friend WithEvents rtbStatus As System.Windows.Forms.RichTextBox
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents cmdStatusClear As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tabPWM As System.Windows.Forms.TabPage
    Friend WithEvents txtPWMPinValue As System.Windows.Forms.TextBox
    Friend WithEvents trbPWMPinValue As System.Windows.Forms.TrackBar
    Friend WithEvents cmdPWMPinSet As System.Windows.Forms.Button
    Friend WithEvents cmbPWMPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblPWMPin As System.Windows.Forms.Label
    Friend WithEvents tab1Wire As System.Windows.Forms.TabPage
    Friend WithEvents tabAnalogIn As System.Windows.Forms.TabPage
    Friend WithEvents txtAnalogInPinValue As System.Windows.Forms.TextBox
    Friend WithEvents lblAnalogInPinValue As System.Windows.Forms.Label
    Friend WithEvents cmdAnalogInPinGet As System.Windows.Forms.Button
    Friend WithEvents cmbAnalogInPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblAnalogInPin As System.Windows.Forms.Label
    Friend WithEvents lblAboutProduct As System.Windows.Forms.Label
    Friend WithEvents tabSPI As System.Windows.Forms.TabPage
    Friend WithEvents txtSPIData As System.Windows.Forms.TextBox
    Friend WithEvents cmdSPIExecute As System.Windows.Forms.Button
    Friend WithEvents txtSPIDataLen As System.Windows.Forms.TextBox
    Friend WithEvents lblSPIDataLen As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbSPIPinsSet As System.Windows.Forms.Button
    Friend WithEvents cmbSPIMISOPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblSPIMISOPin As System.Windows.Forms.Label
    Friend WithEvents cmbSPIMOSIPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblSPIMOSIPin As System.Windows.Forms.Label
    Friend WithEvents cmbSPISCKPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblSPISCKPin As System.Windows.Forms.Label
    Friend WithEvents cmbSPICSPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblSPICSPin As System.Windows.Forms.Label
    Friend WithEvents txtI2CData As System.Windows.Forms.TextBox
    Friend WithEvents txtI2CDataLen As System.Windows.Forms.TextBox
    Friend WithEvents lblI2CData As System.Windows.Forms.Label
    Friend WithEvents cmdI2CExecute As System.Windows.Forms.Button
    Friend WithEvents lblI2CDataLen As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmdI2CPinsSet As System.Windows.Forms.Button
    Friend WithEvents cmbI2CSDAPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblI2CSDAPin As System.Windows.Forms.Label
    Friend WithEvents cmbI2CSCLPin As System.Windows.Forms.ComboBox
    Friend WithEvents lblI2CSCLPin As System.Windows.Forms.Label
    Friend WithEvents tabI2C As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgwDigiOutPinsBlockSettings As System.Windows.Forms.DataGridView
    Friend WithEvents txtAboutVendor As System.Windows.Forms.TextBox
    Friend WithEvents lblAboutVendor As System.Windows.Forms.Label
    Friend WithEvents txtAboutVersion As System.Windows.Forms.TextBox
    Friend WithEvents lblAboutVersion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents tabDigiOut As System.Windows.Forms.TabPage
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrOut As System.Windows.Forms.Label
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioHex As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAscii As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResultSPI As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents I2CResult As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents RadioIHex As System.Windows.Forms.RadioButton
    Friend WithEvents RadioIAsc As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt1WireResponse As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Radio1Hex As System.Windows.Forms.RadioButton
    Friend WithEvents Radio1asc As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt1WireData As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents txt1WireLen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents txtPWMPinValue3 As System.Windows.Forms.TextBox
    Friend WithEvents trbPWMPinValue3 As System.Windows.Forms.TrackBar
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents cmbPWMPin3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPWMPinValue2 As System.Windows.Forms.TextBox
    Friend WithEvents trbPWMPinValue2 As System.Windows.Forms.TrackBar
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents cmbPWMPin2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPWMPinValue1 As System.Windows.Forms.TextBox
    Friend WithEvents trbPWMPinValue1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents cmbPWMPin1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents SplitAFileIn60BytesFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntelHEXToBINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HexToBinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SetFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents CreateHEXFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpIndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents TotBytes As System.Windows.Forms.TextBox
    Friend WithEvents Start As System.Windows.Forms.Button

End Class
