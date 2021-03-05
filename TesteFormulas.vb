Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class TesteFormulas
    Dim ds = New Formulas()
    Dim dt = ds.TesteFormulas

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CrystalReportViewer.SelectionFormula = "{TesteFormulas.Nome}='" & txtKeyword.Text.ToString().Trim().ToUpper() & "'"
        Reload()
        txtKeyword.Text = ""
    End Sub

    Public Sub ReportDocumentView() 
        CrystalReportViewer.ReportSource = DSReport.ReportDocumentDefine(ds)
        CrystalReportViewer.DisplayToolbar = True
    End Sub

    Private Sub Reload()
        CrystalReportViewer.ReportSource = DSReport.ReportDocumentDefine(ds)
        ReportDocumentView()
     End Sub

    Private Sub TesteFormulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DSReport.pathDS = "C:\Users\admin\source\repos\Estudo_CrystalReports\Crystal Reports\CrystalReport3.rpt"        
        DSReport.DataTransfer(dt, 2)
        
        ReportDocumentView()
        Language.SetLanguage("Portuguese")
        Reload()
    End Sub

    Private Sub btnBr_Click(sender As Object, e As EventArgs) Handles btnBr.Click
        Language.SetLanguage("Portuguese")
        Reload()

        btnBr.Enabled = False
        btnEn.Enabled = True
    End Sub

    Private Sub btnEn_Click(sender As Object, e As EventArgs) Handles btnEn.Click
        Language.SetLanguage("English")
        Reload()
        btnBr.Enabled = True
        btnEn.Enabled = False
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
            'Reload()
    End Sub
End Class

