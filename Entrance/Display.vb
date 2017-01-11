Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging
Public Class Display
    
    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLog(Me.DGVlogs, 0)
    End Sub
End Class