<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DGVlogs = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.log_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.machine_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.machine_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Firstname:"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(184, 46)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(54, 24)
        Me.lblFname.TabIndex = 2
        Me.lblFname.Text = "none"
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.Location = New System.Drawing.Point(184, 77)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(54, 24)
        Me.lblMname.TabIndex = 4
        Me.lblMname.Text = "none"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Middlename:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lastname:"
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp.Location = New System.Drawing.Point(184, 18)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(54, 24)
        Me.lblEmp.TabIndex = 7
        Me.lblEmp.Text = "none"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(184, 107)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(54, 24)
        Me.lblLname.TabIndex = 8
        Me.lblLname.Text = "none"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(184, 173)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(54, 24)
        Me.lblDept.TabIndex = 12
        Me.lblDept.Text = "none"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Department:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(184, 142)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(54, 24)
        Me.lblPosition.TabIndex = 10
        Me.lblPosition.Text = "none"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Position:"
        '
        'DGVlogs
        '
        Me.DGVlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.day, Me.actual_time, Me.log_type, Me.machine_number, Me.machine_sn})
        Me.DGVlogs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVlogs.Location = New System.Drawing.Point(0, 284)
        Me.DGVlogs.Name = "DGVlogs"
        Me.DGVlogs.Size = New System.Drawing.Size(960, 234)
        Me.DGVlogs.TabIndex = 13
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
        '
        'machine_sn
        '
        Me.machine_sn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.machine_sn.FillWeight = 96.53792!
        Me.machine_sn.HeaderText = "Machine SN"
        Me.machine_sn.Name = "machine_sn"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lblValidation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDept)
        Me.GroupBox1.Controls.Add(Me.lblFname)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPosition)
        Me.GroupBox1.Controls.Add(Me.lblMname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblLname)
        Me.GroupBox1.Controls.Add(Me.lblEmp)
        Me.GroupBox1.Location = New System.Drawing.Point(344, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 442)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'lblValidation
        '
        Me.lblValidation.AutoSize = True
        Me.lblValidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidation.ForeColor = System.Drawing.Color.DarkRed
        Me.lblValidation.Location = New System.Drawing.Point(43, 229)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(23, 25)
        Me.lblValidation.TabIndex = 15
        Me.lblValidation.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Employee No.:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(83, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(960, 518)
        Me.Controls.Add(Me.DGVlogs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Display"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Display"
        CType(Me.DGVlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents lblMname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DGVlogs As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents day As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actual_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents log_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents machine_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents machine_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblValidation As System.Windows.Forms.Label
End Class
