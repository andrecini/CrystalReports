Imports System
Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms

Public Class FormMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Me.Button1, " Teste do Crystal Report com Banco de dados e com DataSet, com utilização de SubReports e com multiplos relatórios.")
        ToolTip1.SetToolTip(Me.Button2, " Teste do Crystal Report com com utilização de Formulas e 'Tradução'.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim screen As New Form1()
        screen.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim screen As New TesteFormulas()
        screen.ShowDialog()
    End Sub
End Class

Public Class Main
    Public Shared Sub Main()
        Dim current As CultureInfo = Thread.CurrentThread.CurrentUICulture
        If current.TwoLetterISOLanguageName <> "es"
            Dim newCulture As CultureInfo = CultureInfo.CreateSpecificCulture("en-US")
            Thread.CurrentThread.CurrentUICulture = newCulture
            ' Make current UI culture consistent with current culture.
            Thread.CurrentThread.CurrentCulture = newCulture
        End If
        Application.Run(New FormMain())
    End Sub
End Class