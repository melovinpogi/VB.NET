﻿Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim Mainx As New Main()
        If TextBox1.Text = "1p1c@s3rv3r" Then
            ' Make it a child of this MDI form before showing it.
            'Main.MdiParent = Base
            'Main.Show()
            Main.tabControl1.Enabled = True
        Else
            MsgBox("Invalid Password", MsgBoxStyle.Critical, "Error")
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Focus()
    End Sub
End Class