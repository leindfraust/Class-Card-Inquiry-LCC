﻿Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "lcc" And TextBox2.Text = "lcc" Then
            Form2.Show()
        Else
            MsgBox("Wrong Credentials")
        End If
    End Sub
End Class
