﻿Imports System.Net
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strComputer = "."
Set objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\CIMV2") 
Set colItems = objWMIService.ExecQuery("SELECT * FROM Win32_Process" & _
           " WHERE Name = 'cscript.exe'" & " OR Name = 'wscript.exe'",,48) 
For Each objItem In colItems
            Wscript.Echo "-------------------------------------------"
    Wscript.Echo "CommandLine: " & objItem.CommandLine
    Wscript.Echo "Name: " & objItem.Name
Next
    End Sub
End Class
