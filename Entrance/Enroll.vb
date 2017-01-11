Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging
Imports System.IO.File
Public Class Enroll
   
#Region "Enrollment"
    'Make sure you have enrolled the fingerprint templates you will save.
    Dim iCanSaveTmp As String = 0
    'Enroll a certain user's specified fingerprint template online.
    'Only TFT screen devices with firmware version Ver 6.60 version later support duress fingerprint.
    'While you are using 9.0 fingerprint arithmetic and your device's firmware version is under ver6.60,you should set 
    'the paremeter flag of function "StartEnrollEx" as an integer 1.
    Private Sub btnStartEnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartEnroll.Click
        cbFlag.Text = "1"
        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        If txtUserID.Text.Trim() = "" Or cbFingerIndex.Text.Trim() = "" Or cbFlag.Text.Trim = "" Then
            MsgBox("UserID,FingerIndex must be inputted first!", MsgBoxStyle.Information, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Dim iUserID As String = Convert.ToInt32(txtUserID.Text.Trim())
        Dim sUserID = txtUserID.Text.Trim()
        Dim iFingerIndex = Convert.ToInt32(cbFingerIndex.Text.Trim())
        Dim iFlag As Integer = Convert.ToInt32(cbFlag.Text.Trim())

        axCZKEM1.CancelOperation()
        axCZKEM1.SSR_DelUserTmpExt(iMachineNumber, sUserID, iFingerIndex)
        If axCZKEM1.StartEnrollEx(sUserID, iFingerIndex, iFlag) = True Then
            MsgBox("Start to Enroll a new User,UserID=" + sUserID + " FingerID=" + iFingerIndex.ToString() + " Flag=" + iFlag.ToString(), MsgBoxStyle.Information, "Start")
            MsgBox("Do not press OK when you're not yet done enrolling.", MsgBoxStyle.Exclamation, "Warning")
            iCanSaveTmp = 1
            If axCZKEM1.StartIdentify() = True Then  'After enrolling templates,you should let the device into the 1:N verification condition
                MsgBox("Enrollment Successful!", MsgBoxStyle.Information, "Message")
            Else
                MsgBox("Enrollment Failed!", MsgBoxStyle.Critical, "Message")
            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region

#Region "Paking shet hindi ko masave yung fingerprint"
    'Save the tempaltes data you have just enrolled.
    'Here we mainly demonstrate how you can get the binary fingerprint templates from the device and save them into the databuse.
    'If you want to save the templates in strings to the database,you can modify the followding codes.
    'Only TFT screen devices with firmware version Ver 6.60 version later support function "GetUserTmpExStr" and "GetUserTmpEx".
    'While you are using 9.0 fingerprint arithmetic and your device's firmware version is under ver6.60,you should use the functions "SSR_GetUserTmp" or 
    '"SSR_GetUserTmpStr" instead of "GetUserTmpExStr" or "GetUserTmpEx" in order to download the fingerprint templates.
    Private Sub btnSaveEnrolledTmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEnrolledTmp.Click
        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        If iCanSaveTmp = 0 Then 'You haven't enrolled the templates.
            MsgBox("Please enroll the fingerprint templates first!", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\data\Templates.mdb"
        Dim conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(connString)

        Dim idwFingerIndex As Double = Convert.ToDouble(cbFingerIndex.Text.Trim())
        Dim iTmpLength As Double
        Dim sdwEnrollNumber As String = txtUserID.Text.Trim()
        Dim iFlag As Integer
        Dim byTmpData(2000) As Byte
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim bEnabled As Boolean = False

        axCZKEM1.EnableDevice(iMachineNumber, False)
        Cursor = Cursors.WaitCursor
        axCZKEM1.ReadAllTemplate(iMachineNumber)

        While axCZKEM1.SSR_GetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True
            If axCZKEM1.GetUserTmpEx(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, byTmpData(0), iTmpLength) = True Then
                ' If you need to select or delete the data in the database ,you can just define the sql sentences by youself
                Dim sql As String
                sql = "insert into Template(UserID,FingerID,Template,TmpLen) values('" & sdwEnrollNumber & "','" & idwFingerIndex & "','" & byTmpData(0) & "','" & iTmpLength & "')"
                Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully save templates to database ! ", MsgBoxStyle.Information, "Success")
            Else
                MsgBox("Saving templates to database failed ! ", MsgBoxStyle.Information, "Error")
            End If
        End While
        axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
        axCZKEM1.EnableDevice(iMachineNumber, True)
        Cursor = Cursors.Default
    End Sub
#End Region
End Class