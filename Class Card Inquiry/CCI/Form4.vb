﻿Imports System.IO
Imports System.Data.OleDb
Public Class Form4
    Dim provider As String
    Dim dataFile As String
    Dim conString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        dataFile = "../../db/Database.accdb"
        conString = provider & dataFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim cardAvailable As String = "Available"

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE StudentList SET[ClassCard] = '" & cardAvailable & "' WHERE [BarCode] = '" & TextBox1.Text & "' AND [Subject] = '" & TextBox2.Text & "' ", myConnection)
        Dim dm As OleDbDataReader = cmd.ExecuteReader

        myConnection.Close()
        MsgBox("sucessfully updated to AVAILABLE")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        dataFile = "../../db/Database.accdb"
        conString = provider & dataFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim cardNotAvailable As String = "Not Available"

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE StudentList SET[ClassCard] = '" & cardNotAvailable & "' WHERE [BarCode] = '" & TextBox1.Text & "' AND [Subject] = '" & TextBox2.Text & "' ", myConnection)
        Dim dm As OleDbDataReader = cmd.ExecuteReader

        myConnection.Close()
        MsgBox("sucessfully updated to NOT AVAILABLE")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        dataFile = "../../db/Database.accdb"
        conString = provider & dataFile
        myConnection.ConnectionString = conString
        myConnection.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM [StudentList] WHERE [BarCode] = '" & TextBox1.Text & "' AND [Subject] = '" & TextBox2.Text & "' ", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim Name As String = ""
        Dim Course As String = ""
        Dim ClassCard As String = ""

        While dr.Read
            Name = dr("Names").ToString
            Course = dr("YearandCourse").ToString
            ClassCard = dr("ClassCard").ToString

        End While
        myConnection.Close()

        Label3.Text = Name
        Label4.Text = Course
        Label5.Text = ClassCard
    End Sub
End Class