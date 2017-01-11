<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReconDB = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMachineno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMSN = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnRsConnect = New System.Windows.Forms.Button()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.label29 = New System.Windows.Forms.Label()
        Me.txtMachineSN2 = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.btnUSBConnect = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbRTShow = New System.Windows.Forms.ListBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rtTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblServerConn = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.DGVlogs = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.log_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.machine_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.machine_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.txtMachineSN = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cbBaudRate = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.tabControl1)
        Me.groupBox2.Location = New System.Drawing.Point(292, 19)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(447, 168)
        Me.groupBox2.TabIndex = 9
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Communication with Device"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tabControl1.Enabled = False
        Me.tabControl1.Location = New System.Drawing.Point(3, 16)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(440, 149)
        Me.tabControl1.TabIndex = 7
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabPage1.Controls.Add(Me.btnConnect)
        Me.tabPage1.Controls.Add(Me.Button1)
        Me.tabPage1.Controls.Add(Me.btnReconDB)
        Me.tabPage1.Controls.Add(Me.Label8)
        Me.tabPage1.Controls.Add(Me.txtMachineno)
        Me.tabPage1.Controls.Add(Me.Label4)
        Me.tabPage1.Controls.Add(Me.txtMSN)
        Me.tabPage1.Controls.Add(Me.txtIP)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.txtPort)
        Me.tabPage1.Controls.Add(Me.label1)
        Me.tabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabPage1.ForeColor = System.Drawing.Color.DarkBlue
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(432, 123)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "TCP/IP"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConnect.Image = Global.IPIC.My.Resources.Resources.connect_icon
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnect.Location = New System.Drawing.Point(328, 14)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 39)
        Me.btnConnect.TabIndex = 27
        Me.btnConnect.Text = "   Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.IPIC.My.Resources.Resources.enroll
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(328, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 39)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Enroll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnReconDB
        '
        Me.btnReconDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReconDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnReconDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReconDB.Image = Global.IPIC.My.Resources.Resources.database
        Me.btnReconDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReconDB.Location = New System.Drawing.Point(12, 72)
        Me.btnReconDB.Name = "btnReconDB"
        Me.btnReconDB.Size = New System.Drawing.Size(145, 45)
        Me.btnReconDB.TabIndex = 17
        Me.btnReconDB.Text = "Connect to Database"
        Me.btnReconDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReconDB.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(146, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Machine No."
        '
        'txtMachineno
        '
        Me.txtMachineno.Location = New System.Drawing.Point(215, 42)
        Me.txtMachineno.Name = "txtMachineno"
        Me.txtMachineno.Size = New System.Drawing.Size(30, 20)
        Me.txtMachineno.TabIndex = 15
        Me.txtMachineno.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "MachineSN"
        '
        'txtMSN
        '
        Me.txtMSN.Enabled = False
        Me.txtMSN.Location = New System.Drawing.Point(215, 11)
        Me.txtMSN.Name = "txtMSN"
        Me.txtMSN.Size = New System.Drawing.Size(107, 20)
        Me.txtMSN.TabIndex = 13
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(42, 14)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtIP.Size = New System.Drawing.Size(95, 20)
        Me.txtIP.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(42, 46)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPort.Size = New System.Drawing.Size(53, 20)
        Me.txtPort.TabIndex = 7
        Me.txtPort.Text = "4370"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(17, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "IP"
        '
        'tabPage2
        '
        Me.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabPage2.Controls.Add(Me.groupBox5)
        Me.tabPage2.Controls.Add(Me.btnRsConnect)
        Me.tabPage2.ForeColor = System.Drawing.Color.DarkBlue
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(432, 123)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "RS232/485"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Location = New System.Drawing.Point(18, 3)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(408, 38)
        Me.groupBox5.TabIndex = 12
        Me.groupBox5.TabStop = False
        '
        'btnRsConnect
        '
        Me.btnRsConnect.Location = New System.Drawing.Point(183, 47)
        Me.btnRsConnect.Name = "btnRsConnect"
        Me.btnRsConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnRsConnect.TabIndex = 11
        Me.btnRsConnect.Text = "Connect"
        Me.btnRsConnect.UseVisualStyleBackColor = True
        '
        'tabPage3
        '
        Me.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabPage3.Controls.Add(Me.label29)
        Me.tabPage3.Controls.Add(Me.txtMachineSN2)
        Me.tabPage3.Controls.Add(Me.label18)
        Me.tabPage3.Controls.Add(Me.btnUSBConnect)
        Me.tabPage3.ForeColor = System.Drawing.Color.DarkBlue
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(432, 123)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "USBClient"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(233, 18)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(63, 13)
        Me.label29.TabIndex = 14
        Me.label29.Text = "MachineSN"
        '
        'txtMachineSN2
        '
        Me.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue
        Me.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMachineSN2.Location = New System.Drawing.Point(294, 13)
        Me.txtMachineSN2.Name = "txtMachineSN2"
        Me.txtMachineSN2.Size = New System.Drawing.Size(27, 20)
        Me.txtMachineSN2.TabIndex = 13
        Me.txtMachineSN2.Text = "1"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.ForeColor = System.Drawing.Color.Crimson
        Me.label18.Location = New System.Drawing.Point(120, 18)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(87, 13)
        Me.label18.TabIndex = 12
        Me.label18.Text = "Virtual USBClient"
        '
        'btnUSBConnect
        '
        Me.btnUSBConnect.Location = New System.Drawing.Point(183, 40)
        Me.btnUSBConnect.Name = "btnUSBConnect"
        Me.btnUSBConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnUSBConnect.TabIndex = 11
        Me.btnUSBConnect.Text = "Connect"
        Me.btnUSBConnect.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDisplay.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnDisplay.Location = New System.Drawing.Point(80, 135)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(115, 23)
        Me.btnDisplay.TabIndex = 12
        Me.btnDisplay.Text = "Show Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        Me.btnDisplay.Visible = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.ForeColor = System.Drawing.Color.Red
        Me.lblState.Location = New System.Drawing.Point(300, 190)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(175, 13)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "Device Current State:Disconnected"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lbRTShow)
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(543, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 207)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'lbRTShow
        '
        Me.lbRTShow.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbRTShow.FormattingEnabled = True
        Me.lbRTShow.Location = New System.Drawing.Point(7, 16)
        Me.lbRTShow.Name = "lbRTShow"
        Me.lbRTShow.Size = New System.Drawing.Size(356, 188)
        Me.lbRTShow.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(441, 207)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        '
        'rtTimer
        '
        Me.rtTimer.Enabled = True
        '
        'pingTimer
        '
        Me.pingTimer.Enabled = True
        Me.pingTimer.Interval = 1000
        '
        'lblServerConn
        '
        Me.lblServerConn.AutoSize = True
        Me.lblServerConn.Location = New System.Drawing.Point(677, 207)
        Me.lblServerConn.Name = "lblServerConn"
        Me.lblServerConn.Size = New System.Drawing.Size(0, 13)
        Me.lblServerConn.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblValidation)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.lblServerConn)
        Me.GroupBox3.Controls.Add(Me.btnSettings)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Controls.Add(Me.groupBox2)
        Me.GroupBox3.Controls.Add(Me.lblState)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 226)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'lblValidation
        '
        Me.lblValidation.AutoSize = True
        Me.lblValidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidation.ForeColor = System.Drawing.Color.DarkRed
        Me.lblValidation.Location = New System.Drawing.Point(12, 103)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(0, 25)
        Me.lblValidation.TabIndex = 27
        Me.lblValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 207)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettings.Image = Global.IPIC.My.Resources.Resources.setting1
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(627, 186)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(98, 37)
        Me.btnSettings.TabIndex = 10
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'DGVlogs
        '
        Me.DGVlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.day, Me.actual_time, Me.log_type, Me.machine_number, Me.machine_sn})
        Me.DGVlogs.Dock = System.Windows.Forms.DockStyle.Right
        Me.DGVlogs.Location = New System.Drawing.Point(234, 226)
        Me.DGVlogs.Name = "DGVlogs"
        Me.DGVlogs.Size = New System.Drawing.Size(678, 153)
        Me.DGVlogs.TabIndex = 14
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id.FillWeight = 23.55192!
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'day
        '
        Me.day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.day.FillWeight = 158.0184!
        Me.day.HeaderText = "Day"
        Me.day.Name = "day"
        '
        'actual_time
        '
        Me.actual_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.actual_time.FillWeight = 114.0122!
        Me.actual_time.HeaderText = "Actual Time"
        Me.actual_time.Name = "actual_time"
        '
        'log_type
        '
        Me.log_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.log_type.FillWeight = 106.599!
        Me.log_type.HeaderText = "Log"
        Me.log_type.Name = "log_type"
        '
        'machine_number
        '
        Me.machine_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.machine_number.FillWeight = 101.2805!
        Me.machine_number.HeaderText = "Machine Number"
        Me.machine_number.Name = "machine_number"
        Me.machine_number.Visible = False
        '
        'machine_sn
        '
        Me.machine_sn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.machine_sn.FillWeight = 96.53792!
        Me.machine_sn.HeaderText = "Machine SN"
        Me.machine_sn.Name = "machine_sn"
        Me.machine_sn.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 31)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Employee No.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 31)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Firstname:"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(195, 471)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(0, 31)
        Me.lblDept.TabIndex = 25
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(195, 292)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(0, 31)
        Me.lblFname.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 31)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Department:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 31)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Middlename:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(195, 424)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(0, 31)
        Me.lblPosition.TabIndex = 23
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.Location = New System.Drawing.Point(195, 337)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(0, 31)
        Me.lblMname.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 31)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Position:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 31)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Lastname:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(195, 379)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(0, 31)
        Me.lblLname.TabIndex = 21
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp.Location = New System.Drawing.Point(195, 241)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(0, 31)
        Me.lblEmp.TabIndex = 20
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(121, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(55, 13)
        Me.label6.TabIndex = 8
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(265, 18)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(63, 13)
        Me.label7.TabIndex = 9
        '
        'cbPort
        '
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.cbPort.Location = New System.Drawing.Point(52, 14)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(56, 21)
        Me.cbPort.TabIndex = 5
        '
        'txtMachineSN
        '
        Me.txtMachineSN.Location = New System.Drawing.Point(183, 47)
        Me.txtMachineSN.Name = "txtMachineSN"
        Me.txtMachineSN.Size = New System.Drawing.Size(56, 20)
        Me.txtMachineSN.TabIndex = 10
        Me.txtMachineSN.Text = "1"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(10, 18)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 7
        '
        'cbBaudRate
        '
        Me.cbBaudRate.FormattingEnabled = True
        Me.cbBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "115200"})
        Me.cbBaudRate.Location = New System.Drawing.Point(187, 14)
        Me.cbBaudRate.Name = "cbBaudRate"
        Me.cbBaudRate.Size = New System.Drawing.Size(65, 21)
        Me.cbBaudRate.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(912, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.DGVlogs)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Device Management / Entrance Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.groupBox2.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents lblState As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lbRTShow As System.Windows.Forms.ListBox
    Friend WithEvents rtTimer As System.Windows.Forms.Timer
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents txtMachineSN2 As System.Windows.Forms.TextBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents btnUSBConnect As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents tabControl1 As System.Windows.Forms.TabControl
    Public WithEvents txtIP As System.Windows.Forms.TextBox
    Public WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtMSN As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtMachineno As System.Windows.Forms.TextBox
    Public WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents pingTimer As System.Windows.Forms.Timer
    Friend WithEvents lblServerConn As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVlogs As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblMname As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents lblValidation As System.Windows.Forms.Label
    Friend WithEvents btnReconDB As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents day As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actual_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents log_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents machine_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents machine_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents btnRsConnect As System.Windows.Forms.Button
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents cbPort As System.Windows.Forms.ComboBox
    Private WithEvents txtMachineSN As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
