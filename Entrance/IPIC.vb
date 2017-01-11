Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging
Imports System.IO.File
Module IPIC
    Public conn As SqlConnection
    Public dreader As SqlDataReader
    Public cmd As SqlCommand
    Public sql As String
    Public axCZKEM1 As New zkemkeeper.CZKEM 'Device SDK
    Public bIsConnected As Boolean = False 'the boolean value identifies whether the device is connected
    Public iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.


    'Connection to database
    Public Sub dbcon()


        Dim conn_server As String = "192.168.1.254"
        Dim conn_user As String = "sa"
        Dim conn_pass As String = "1p1cdbs3rv3r@2016"
        Dim conn_db As String = "erp"

        conn = New SqlConnection("server=" & conn_server & ";User Id=" & conn_user & ";password=" & conn_pass & ";database=" & conn_db)
        Try
            With conn
                If .State = Data.ConnectionState.Open Then .Close()
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub GetLog(ByRef tblLog As DataGridView, ByVal employee As Long)
        Try
            dbcon()
            Dim sql As String = "SELECT id,datename(weekday, actual_time),actual_time,case when log_type ='i' then 'IN' when log_type ='o' then 'OUT' end,machine_number,machine_sn  FROM employee_timelog_history WHERE employee_id = " & employee & " ORDER BY id"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.CommandType = CommandType.Text

            dreader = cmd.ExecuteReader()
            tblLog.Rows.Clear()
            While dreader.Read
                With tblLog.Rows.Add(dreader.GetValue(0).ToString,
                                        dreader.GetValue(1).ToString,
                                        dreader.GetValue(2).ToString,
                                        dreader.GetValue(3).ToString,
                                        dreader.GetValue(4).ToString,
                                        dreader.GetValue(5).ToString)
                End With
            End While
            tblLog.AutoResizeColumns()
            tblLog.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dreader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function CheckInOut(ByVal employeeid As Long, ByVal log As String) As Integer
        Try
            dbcon()
            Dim count As Integer
            Dim sql As String = "SELECT count(*) FROM employee_timelog_history WHERE employee_id = " & employeeid & " and datename(weekday, actual_time) = datename(weekday, getdate()) and log_type = '" & log & "'"
            Dim cmd As New SqlCommand(sql, conn)

            cmd.CommandType = CommandType.Text
            dreader = cmd.ExecuteReader()
            While dreader.Read
                count = dreader(0)
            End While
            dreader.Close()

            Return count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            Return -1
        End Try


    End Function

    Public Function GetImage(ByVal employee As Long) As Image
        Try
            dbcon()
            Dim sql As String = "SELECT picture FROM employees (NOLOCK) WHERE employeeid = " & employee
            Dim cmd As New SqlCommand(sql, conn)
            Dim stream As New MemoryStream()

            Dim image As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            stream.Write(image, 0, image.Length)
            Dim bitmap As New Bitmap(stream)
            Return bitmap
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Image.FromFile("C:\Users\Public\Pictures\Sample Pictures\Koala.jpg")

        End Try

    End Function
    Public Sub GetInfo(ByVal sample As String)
        Try
            Display.lblFname.Text = sample
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Public Sub ProgressBar(ByVal ParamArray filenames As String())
    '    ' Display the ProgressBar control.
    '    Display.ProgressBar1.Visible = True
    '    Display.ProgressBar1.Minimum = 1
    '    Display.ProgressBar1.Maximum = filenames.Length
    '    Display.ProgressBar1.Value = 1
    '    ' Set the Step property to a value of 1 to represent each file being copied.
    '    Display.ProgressBar1.Step = 1


    '    ' Loop through all files to copy.
    '    Dim x As Integer
    '    For x = 1 To filenames.Length
    '        Display.ProgressBar1.PerformStep()
    '    Next x
    'End Sub
End Module
