Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class Connection
    Public Shared Dim cn As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Public Shared Dim connectionString As String

    Public Shared Sub Open()
        cn.ConnectionString = connectionString
        cn.Open()
    End Sub

    Public Shared Sub Close()
        cn.Close()
    End Sub

End Class
