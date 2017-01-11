<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enroll))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFlag = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStartEnroll = New System.Windows.Forms.Button()
        Me.cbFingerIndex = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnSaveEnrolledTmp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFlag)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnStartEnroll)
        Me.GroupBox1.Controls.Add(Me.cbFingerIndex)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 91)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrollment Form"
        '
        'cbFlag
        '
        Me.cbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFlag.FormattingEnabled = True
        Me.cbFlag.Items.AddRange(New Object() {"0", "1", "3"})
        Me.cbFlag.Location = New System.Drawing.Point(372, 26)
        Me.cbFlag.Name = "cbFlag"
        Me.cbFlag.Size = New System.Drawing.Size(42, 21)
        Me.cbFlag.TabIndex = 61
        Me.cbFlag.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Flag"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(40, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "(Save enrolled fingerprint templates to database)"
        Me.Label3.Visible = False
        '
        'btnStartEnroll
        '
        Me.btnStartEnroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartEnroll.Image = Global.IPIC.My.Resources.Resources.enroll
        Me.btnStartEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartEnroll.Location = New System.Drawing.Point(183, 29)
        Me.btnStartEnroll.Name = "btnStartEnroll"
        Me.btnStartEnroll.Size = New System.Drawing.Size(85, 48)
        Me.btnStartEnroll.TabIndex = 57
        Me.btnStartEnroll.Text = "StartEnroll"
        Me.btnStartEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStartEnroll.UseVisualStyleBackColor = True
        '
        'cbFingerIndex
        '
        Me.cbFingerIndex.FormattingEnabled = True
        Me.cbFingerIndex.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbFingerIndex.Location = New System.Drawing.Point(90, 61)
        Me.cbFingerIndex.Name = "cbFingerIndex"
        Me.cbFingerIndex.Size = New System.Drawing.Size(69, 21)
        Me.cbFingerIndex.TabIndex = 56
        Me.cbFingerIndex.Text = "0"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(6, 64)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 13)
        Me.label9.TabIndex = 55
        Me.label9.Text = "FingerIndex"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(90, 26)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(69, 20)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "1"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(6, 29)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(78, 18)
        Me.label8.TabIndex = 40
        Me.label8.Text = "Employee No"
        '
        'btnSaveEnrolledTmp
        '
        Me.btnSaveEnrolledTmp.Location = New System.Drawing.Point(154, 115)
        Me.btnSaveEnrolledTmp.Name = "btnSaveEnrolledTmp"
        Me.btnSaveEnrolledTmp.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveEnrolledTmp.TabIndex = 58
        Me.btnSaveEnrolledTmp.Tag = "Save Enrolled Tmp to Database"
        Me.btnSaveEnrolledTmp.Text = "SaveTmpToDB"
        Me.btnSaveEnrolledTmp.UseVisualStyleBackColor = True
        '
        'Enroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 159)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveEnrolledTmp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Enroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enroll User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFlag As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnSaveEnrolledTmp As System.Windows.Forms.Button
    Private WithEvents btnStartEnroll As System.Windows.Forms.Button
    Private WithEvents cbFingerIndex As System.Windows.Forms.ComboBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
End Class
