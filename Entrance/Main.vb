Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Public Class Main
    Private elapsedTime As Integer = 0
    Private idletime As Integer = 0
    
    Public Sub InsertLog(ByVal employee, ByVal machine_number, ByVal machine_sn)
        Dim cmd As New SqlCommand

        With cmd
            .Connection = conn
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO employee_timelog_history(employee_id, actual_time, log_type, machine_number,machine_sn) " &
                " SELECT @employee, @actualtime, case when @machine_number =1 then 'i'  when @machine_number =2 then 'o' end , @machine_number,@machine_sn"
            .Parameters.AddWithValue("@employee", employee)
            .Parameters.AddWithValue("@actualtime", DateTime.Now.ToString())
            .Parameters.AddWithValue("@machine_number", machine_number)
            .Parameters.AddWithValue("@machine_sn", machine_sn)
        End With

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    '* There are 3 communication ways: "TCP/IP","Serial Port" and "USB Client".*
    '* The communication way which you can use duing to the model of the device.                                                                 *
#Region "Communication"
     'If your device supports the TCP/IP communications, you can refer to this.
    'when you are using the tcp/ip communication,you can distinguish different devices by their IP address.
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        lblState.Text = "Device Current State:Connecting... Please Wait..."
        If txtIP.Text.Trim() = "" Or txtPort.Text.Trim() = "" Then
            MsgBox("IP and Port cannot be null", MsgBoxStyle.Exclamation, "Error")
            lblState.Text = "Device Current State:Disconnected"
            Return
        End If

        If txtMachineno.Text.Trim() = "0" Or txtMachineno.Text.Trim() = "" Then
            MsgBox("Machine number cannot be null", MsgBoxStyle.Exclamation, "Error")
            lblState.Text = "Device Current State:Disconnected"
            Return
        End If

        Dim idwErrorCode As Integer
        Cursor = Cursors.WaitCursor

        If btnConnect.Text = "Disconnect" Then
            axCZKEM1.Disconnect()
            RemoveHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
            RemoveHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
            RemoveHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
            RemoveHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
            RemoveHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
            RemoveHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
            RemoveHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
            RemoveHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
            RemoveHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
            RemoveHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
            RemoveHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
            RemoveHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            bIsConnected = False
            btnConnect.Text = "Connect"
            lblState.Text = "Device Current State:Disconnected"
            Cursor = Cursors.Default
            Return
        End If

        bIsConnected = axCZKEM1.Connect_Net(txtIP.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()))
        If bIsConnected = True Then
            btnConnect.Text = "Disconnect"
            btnConnect.Image = My.Resources.disconnect
            btnConnect.Refresh()
            lblState.Text = "Device Current State:Connected"
            iMachineNumber = txtMachineSN.Text

            'Get the machine serial number
            If bIsConnected = False Then
                MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
                Return
            End If


            Dim sdwSerialNumber As String = ""

            If axCZKEM1.GetSerialNumber(iMachineNumber, sdwSerialNumber) = True Then
                txtMSN.Text = sdwSerialNumber
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If


            If axCZKEM1.RegEvent(iMachineNumber, 65535) = True Then 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)

                AddHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
                AddHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
                AddHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
                AddHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
                AddHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
                AddHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
                AddHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
                AddHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
                AddHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
                AddHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
                AddHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
                AddHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default


    End Sub
    'If your device supports the SerialPort communications, you can refer to this.
    Private Sub btnRsConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRsConnect.Click
        If cbPort.Text.Trim() = "" Or cbBaudRate.Text.Trim() = "" Or txtMachineSN.Text.Trim() = "" Then
            MsgBox("Port,BaudRate and MachineSN cannot be null", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        'accept serialport number from string like "COMi"
        Dim iPort As Integer
        'Dim sPort = cbPort.Text.Trim()
        Dim sPort As String = cbPort.Text.Trim()
        For iPort = 1 To 9
            If sPort.IndexOf(iPort.ToString()) > -1 Then
                Exit For
            End If
        Next

        Cursor = Cursors.WaitCursor
        If btnRsConnect.Text = "Disconnect" Then
            axCZKEM1.Disconnect()

            RemoveHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
            RemoveHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
            RemoveHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
            RemoveHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
            RemoveHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
            RemoveHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
            RemoveHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
            RemoveHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
            RemoveHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
            RemoveHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
            RemoveHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
            RemoveHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            bIsConnected = False
            btnRsConnect.Text = "Connect"
            lblState.Text = "Current State:Disconnected"
            Cursor = Cursors.Default
            Return
        End If

        iMachineNumber = Convert.ToInt32(txtMachineSN.Text.Trim()) '//when you are using the serial port communication,you can distinguish different devices by their serial port number.
        bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, Convert.ToInt32(cbBaudRate.Text.Trim()))

        If bIsConnected = True Then
            btnRsConnect.Text = "Disconnect"
            btnRsConnect.Refresh()
            lblState.Text = "Current State:Connected"

            If axCZKEM1.RegEvent(iMachineNumber, 65535) = True Then 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)

                AddHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
                AddHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
                AddHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
                AddHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
                AddHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
                AddHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
                AddHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
                AddHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
                AddHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
                AddHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
                AddHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
                AddHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub
    'If your device supports the USBCLient, you can refer to this.
    'Not all series devices can support this kind of connection.Please make sure your device supports USBClient.
    'Connect the device via the virtual serial port created by USBClient
    Private Sub btnUSBConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUSBConnect.Click
        Dim idwErrorCode As Integer
        Cursor = Cursors.WaitCursor
        If btnUSBConnect.Text = "Disconnect" Then
            axCZKEM1.Disconnect()

            RemoveHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
            RemoveHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
            RemoveHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
            RemoveHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
            RemoveHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
            RemoveHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
            RemoveHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
            RemoveHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
            RemoveHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
            RemoveHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
            RemoveHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
            RemoveHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            bIsConnected = False
            btnUSBConnect.Text = "Connect"
            lblState.Text = "Current State:Disconnected"
            Cursor = Cursors.Default
            Return
        End If

        Dim sCom As String = ""
        Dim bSearch As Boolean
        Dim usbcom As New SearchforUSBCom 'new
        bSearch = usbcom.SearchforCom(sCom)

        If bSearch = False Then
            MsgBox("Can not find the virtual serial port that can be used", MsgBoxStyle.Exclamation, "Error")
            Cursor = Cursors.Default
            Return
        End If

        Dim iPort As Integer
        For iPort = 1 To 9
            If sCom.IndexOf(iPort.ToString()) > -1 Then
                Exit For
            End If
        Next

        iMachineNumber = Convert.ToInt32(txtMachineSN2.Text.Trim())
        If iMachineNumber = 0 Or iMachineNumber > 255 Then
            MsgBox("The Machine Number is invalid!", MsgBoxStyle.Exclamation, "Error")
            Cursor = Cursors.Default
            Return
        End If

        Dim iBaudRate = 115200 '115200 is one possible baudrate value(its value cannot be 0)
        bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, iBaudRate)

        If bIsConnected = True Then
            btnUSBConnect.Text = "Disconnect"
            btnUSBConnect.Refresh()
            lblState.Text = "Current State:Connected"

            If axCZKEM1.RegEvent(iMachineNumber, 65535) = True Then 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)

                AddHandler axCZKEM1.OnFinger, AddressOf AxCZKEM1_OnFinger
                AddHandler axCZKEM1.OnFingerFeature, AddressOf AxCZKEM1_OnFingerFeature
                AddHandler axCZKEM1.OnVerify, AddressOf AxCZKEM1_OnVerify
                AddHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx
                AddHandler axCZKEM1.OnEnrollFingerEx, AddressOf AxCZKEM1_OnEnrollFingerEx
                AddHandler axCZKEM1.OnDeleteTemplate, AddressOf AxCZKEM1_OnDeleteTemplate
                AddHandler axCZKEM1.OnNewUser, AddressOf AxCZKEM1_OnNewUser
                AddHandler axCZKEM1.OnAlarm, AddressOf AxCZKEM1_OnAlarm
                AddHandler axCZKEM1.OnDoor, AddressOf AxCZKEM1_OnDoor
                AddHandler axCZKEM1.OnWriteCard, AddressOf AxCZKEM1_OnWriteCard
                AddHandler axCZKEM1.OnEmptyCard, AddressOf AxCZKEM1_OnEmptyCard
                AddHandler axCZKEM1.OnHIDNum, AddressOf AxCZKEM1_OnHIDNum

            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub
#End Region

    '**************************************************************************************************
    '* Before you refer to this demo,we strongly suggest you read the development manual deeply first.*
    '* This part is for demonstrating the RealTime Events that triggered  by your operations          *
    '**************************************************************************************************
#Region "RealTime Events"
    'When you place your finger on sensor of the device,this event will be triggered

    Private Sub AxCZKEM1_OnFinger()
        If bIsConnected = False Then
            MsgBox("Device disconnected. Please contact System Administrator.", MsgBoxStyle.Critical)
            Return
        End If
        lbRTShow.Items.Add("UserActivity OnFinger Has been Triggered")
        lbRTShow.TopIndex = lbRTShow.Items.Count - 1
    End Sub

    'After you have placed your finger on the sensor(or swipe your card to the device),this event will be triggered.
    'If you passes the verification,the returned value userid will be the user enrollnumber,or else the value will be -1;
    Private Sub AxCZKEM1_OnVerify(ByVal iUserID As Integer)
        If bIsConnected = False Then
            MsgBox("Device disconnected. Please contact System Administrator.", MsgBoxStyle.Critical)
            Return
        End If
        lbRTShow.Items.Add("UserActivity OnVerify Has been Triggered,Verifying...")
        If iUserID <> -1 Then
            lbRTShow.Items.Add("Verified OK,the UserID is " & iUserID.ToString())
        Else
            lbRTShow.Items.Add("Verified Failed... ")
            lblValidation.Text = "Invalid user."
        End If
        lbRTShow.TopIndex = lbRTShow.Items.Count - 1
    End Sub

    'If your fingerprint(or your card) passes the verification,this event will be triggered
    Private Sub AxCZKEM1_OnAttTransactionEx(ByVal sEnrollNumber As String, ByVal iIsInValid As Integer, ByVal iAttState As Integer, ByVal iVerifyMethod As Integer, _
                      ByVal iYear As Integer, ByVal iMonth As Integer, ByVal iDay As Integer, ByVal iHour As Integer, ByVal iMinute As Integer, ByVal iSecond As Integer, ByVal iWorkCode As Integer)

        If bIsConnected = False Then
            MsgBox("Device disconnected. Please contact System Administrator.", MsgBoxStyle.Critical)
            Return
        End If

        lbRTShow.Items.Add("UserActivity OnAttTrasactionEx Has been Triggered,Verified OK")
        lbRTShow.Items.Add("...UserID:" & sEnrollNumber)
        lbRTShow.Items.Add("...isInvalid:" & iIsInValid.ToString())
        lbRTShow.Items.Add("...attState:" & iAttState.ToString())
        lbRTShow.Items.Add("...VerifyMethod:" & iVerifyMethod.ToString())
        lbRTShow.Items.Add("...Workcode:" & iWorkCode.ToString()) 'the difference between the event OnAttTransaction and OnAttTransactionEx
        lbRTShow.Items.Add("...Time:" & iYear.ToString() & "-" & iMonth.ToString() & "-" & iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & ":" & iSecond.ToString())
        lbRTShow.TopIndex = lbRTShow.Items.Count - 1
        'Insert into database
        Try
            dbcon()
            sql = "SELECT employeeid,lastname,firstname,middlename,isnull(dbo.fn_manpower_group(employeeid,1),'') as dept,isnull(dbo.fn_manpower_group(employeeid,2),'') as pos,picture FROM Employees where employeeno = '" & sEnrollNumber & "'"
            Dim cmd As New SqlCommand(sql, conn)
            Dim employeeid As Long
            Dim stream As New MemoryStream()

            cmd.CommandType = CommandType.Text

            dreader = cmd.ExecuteReader
            While dreader.Read()
                DGVlogs.Rows.Clear()
                employeeid = dreader.GetValue(0)
                lblEmp.Text = sEnrollNumber
                lblLname.Text = dreader.GetValue(1)
                lblFname.Text = dreader.GetValue(2)
                lblMname.Text = dreader.GetValue(3)
                lblDept.Text = dreader.GetValue(4)
                lblPosition.Text = dreader.GetValue(5)
            End While
            dreader.Close()

            If employeeid <> 0 Then
                If CheckInOut(employeeid, "i") > 0 Then
                    lblValidation.Text = "Employee already entered."
                    lblEmp.Text = ""
                    lblLname.Text = ""
                    lblFname.Text = ""
                    lblMname.Text = ""
                    lblDept.Text = ""
                    lblPosition.Text = ""
                    Return
                ElseIf CheckInOut(employeeid, "o") > 0 Then
                    lblValidation.Text = "Employee already out."
                    lblEmp.Text = ""
                    lblLname.Text = ""
                    lblFname.Text = ""
                    lblMname.Text = ""
                    lblDept.Text = ""
                    lblPosition.Text = ""
                    Return
                ElseIf CheckInOut(employeeid, "i") = -1 Or CheckInOut(employeeid, "o") = -1 Then
                    lblEmp.Text = ""
                    lblLname.Text = ""
                    lblFname.Text = ""
                    lblMname.Text = ""
                    lblDept.Text = ""
                    lblPosition.Text = ""
                    Return
                End If

                lblValidation.Text = ""
                InsertLog(employeeid, txtMachineno.Text, txtMSN.Text)
                GetLog(DGVlogs, employeeid)
                PictureBox1.BackgroundImage = GetImage(employeeid)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    'When you have enrolled your finger,this event will be triggered and return the quality of the fingerprint you have enrolled
    Private Sub AxCZKEM1_OnFingerFeature(ByVal iScore As Integer)
        If iScore < 0 Then
            lbRTShow.Items.Add("The quality of your fingerprint is poor")
        Else
            lbRTShow.Items.Add("UserActivity OnFingerFeature Has been Triggered...Score:" & iScore.ToString())
        End If
    End Sub

    'When you have deleted one one fingerprint template,this event will be triggered.
    Private Sub AxCZKEM1_OnDeleteTemplate(ByVal iEnrollNumber As Integer, ByVal iFingerIndex As Integer)
        lbRTShow.Items.Add("UserActivity OnDeleteTemplate Has been Triggered...")
        lbRTShow.Items.Add("...UserID=" & iEnrollNumber.ToString() & " FingerIndex=" & iFingerIndex.ToString())
    End Sub
    'When you have enrolled a new user,this event will be triggered.
    Private Sub AxCZKEM1_OnNewUser(ByVal iEnrollNumber As Integer)
        lbRTShow.Items.Add("UserActivity OnNewUser Has been Triggered...")
        lbRTShow.Items.Add("...NewUserID=" & iEnrollNumber.ToString())
    End Sub

    'When you swipe a card to the device, this event will be triggered to show you the card number.
    Private Sub AxCZKEM1_OnHIDNum(ByVal iCardNumber As Integer)
        If bIsConnected = False Then
            MsgBox("Device disconnected. Please contact System Administrator.", MsgBoxStyle.Critical)
            Return
        End If
        lbRTShow.Items.Add("UserActivity OnHIDNum Has been Triggered...")
        lbRTShow.Items.Add("...Cardnumber=" & iCardNumber.ToString())
    End Sub
    'When you are enrolling your finger,this event will be triggered.
    Private Sub AxCZKEM1_OnEnrollFingerEx(ByVal sEnrollNumber As String, ByVal iFingerIndex As Integer, ByVal iActionResult As Integer, ByVal iTemplateLength As Integer)
        If iActionResult = 0 Then
            lbRTShow.Items.Add("UserActivity OnEnrollFigerEx Has been Triggered....")
            lbRTShow.Items.Add(".....UserID: " & sEnrollNumber & " Index: " & iFingerIndex.ToString() & " tmpLen: " & iTemplateLength.ToString())
        Else
            lbRTShow.Items.Add("UserActivity OnEnrollFigerEx Has been Triggered Error,actionResult=" + iActionResult.ToString())
        End If
    End Sub
    '/When the dismantling machine or duress alarm occurs, trigger this event.
    Private Sub AxCZKEM1_OnAlarm(ByVal iAlarmType As Integer, ByVal iEnrollNumber As Integer, ByVal iVerified As Integer)
        lbRTShow.Items.Add("UserActivity OnAlarm Has been Triggered...")
        lbRTShow.Items.Add("...alarmType=" & iAlarmType.ToString())
        lbRTShow.Items.Add("...enrollNumber=" & iEnrollNumber.ToString())
        lbRTShow.Items.Add("...verified=" & iVerified.ToString())
    End Sub
    'Door sensor event
    Private Sub AxCZKEM1_OnDoor(ByVal iEventType As Integer)
        lbRTShow.Items.Add("UserActivity Ondoor Has been Triggered...")
        lbRTShow.Items.Add("...EventType=" & iEventType.ToString())
    End Sub
    'When you have emptyed the Mifare card,this event will be triggered.
    Private Sub AxCZKEM1_OnEmptyCard(ByVal iActionResult As Integer)
        lbRTShow.Items.Add("UserActivity OnEmptyCard Has been Triggered...")
        If iActionResult = 0 Then
            lbRTShow.Items.Add("...Empty Mifare Card OK")
        Else
            lbRTShow.Items.Add("...Empty Failed")
        End If
    End Sub
    'When you have written into the Mifare card ,this event will be triggered.
    Private Sub AxCZKEM1_OnWriteCard(ByVal iEnrollNumber As Integer, ByVal iActionResult As Integer, ByVal iLength As Integer)
        lbRTShow.Items.Add("UserActivity OnWriteCard Has been Triggered...")
        If iActionResult = 0 Then
            lbRTShow.Items.Add("...Write Mifare Card OK")
            lbRTShow.Items.Add("...EnrollNumber=" & iEnrollNumber.ToString())
            lbRTShow.Items.Add("...TmpLength=" & iLength.ToString())
        Else
            lbRTShow.Items.Add("...Write Failed")
        End If
    End Sub
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        dbcon()


        'Display Database Connection
        If conn.State = ConnectionState.Open Then
            btnReconDB.Visible = False
            Base.statusDB.Text = "Connected"
            Base.statusDB.ForeColor = Color.Blue
        Else
            btnSettings.Enabled = False
            btnReconDB.Visible = False
        End If

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If txtIP.Enabled = True Then
            txtIP.PasswordChar = "*"
            txtPort.PasswordChar = "*"
            txtMSN.PasswordChar = "*"
            txtMachineno.PasswordChar = "*"

            txtIP.Enabled = False
            txtPort.Enabled = False
            txtMachineno.Enabled = False
            tabControl1.Enabled = False
            btnSettings.Text = "Settings"
        Else
            txtIP.PasswordChar = ""
            txtPort.PasswordChar = ""
            txtMSN.PasswordChar = ""
            txtMachineno.PasswordChar = ""

            txtIP.Enabled = True
            txtPort.Enabled = True
            txtMachineno.Enabled = True
            tabControl1.Enabled = True
            btnSettings.Text = "Close Settings"
        End If
    End Sub



    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim display As New Display
        If txtMSN.Text.Trim() = "" Then
            MsgBox("Please Connect the machine/device.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Display.Show()
    End Sub

    Private Sub pingTimer_Tick(sender As Object, e As EventArgs) Handles pingTimer.Tick
        ' Check the time that has elapsed so far
        If elapsedTime >= 5 And txtIP.Text.Trim <> "" Then
            ' It has been 5 secs, so reset the elapsed time count
            elapsedTime = 0

            Try
                ' And do the ping
                If My.Computer.Network.Ping(txtIP.Text) Then
                    Base.statusServer.Text = "Connected"
                    Base.statusServer.ForeColor = Color.Blue
                    btnConnect.Enabled = True
                    idletime = 0
                Else
                    Base.statusServer.Text = "Ping Request Timeout. Please inform System Administrator."
                    Base.statusServer.ForeColor = Color.Red
                    btnConnect.Enabled = False

                    idletime += 1
                    If idletime = 4 Then '20 secs
                        MsgBox("Program cannot connect to the device. Please inform System Administrator. Kindly re-open the module and re-connect the device/machine.", MsgBoxStyle.Critical)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        Else
            ' It has not yet been 5 secs, so increment the elapsed time count
            elapsedTime += 1
        End If
    End Sub

    Private Sub btnReconDB_Click(sender As Object, e As EventArgs) Handles btnReconDB.Click
        'InitializeComponent()
        dbcon()

        'Display Database Connection
        If conn.State = ConnectionState.Open Then
            btnReconDB.Visible = False
            Base.statusDB.Text = "Connected"
            Base.statusDB.ForeColor = Color.Blue
        Else
            btnSettings.Enabled = True
            btnReconDB.Visible = True
        End If

    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Enroll.Show()
    End Sub

  
End Class
