Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1
    Dim dsPessoas = New Pessoas()
    Dim dt = dsPessoas.DSTesteCrystalReports
    Dim rptSelected As String
    
    Private Sub rdbRpt_CheckedChanged2(sender As Object, e As EventArgs) Handles rdbRpt2.CheckedChanged 
        If rdbRpt1.Checked
            rptSelected = "TesteCrystalReports"
            Reload()
        End If
    End Sub 'Ok
    
    Private Sub rdbRpt_CheckedChanged1(sender As Object, e As EventArgs) Handles rdbRpt1.CheckedChanged
        If rdbRpt2.Checked
           rptSelected = "DSTesteCrystalReports"
           ReportDocumentView()
        End If
    End Sub 'Ok

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click 
            CrystalReportViewer.SelectionFormula = "{" & rptSelected & ".First Name}='" & txtKeyword.Text.ToString().Trim() & "'"
            Reload()
       
    End Sub 'Ok

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click 
        If rdbRpt2.Checked
            DSReport.ReportDocumentDefine(dsPessoas).Close()
            ReportDocumentView()
        Else
            Reload()
        End If
    End Sub 'Ok

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown 
         If e.KeyCode = Keys.Enter Then
             btnSearch.PerformClick()
         end if
    End Sub  'Ok
           
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 
        SetDsReportVariables()

        CrystalReportViewer.ReportSource = DSReport.ReportDocumentDefine(dsPessoas)
        DSReport.DataTransfer(dt, 1)

        rdbRpt1.Checked = True
    End Sub 'Ok
    
    #Region "Methods"
    Private Sub Reload()
        If rdbRpt1.Checked
            CrystalReportViewer.ReportSource = DSReport.SetSubreportDoc(dsPessoas)
            CrystalReportViewer.Refresh()
            CrystalReportViewer.RefreshReport()
        ElseIf rdbRpt2.Checked
            CrystalReportViewer.ReportSource = DSReport.ReportDocumentDefine(dsPessoas)
            ReportDocumentView()
        End If
     End Sub  'Ok
      
    Private Sub ReportDocumentView() 
        CrystalReportViewer.ReportSource = DSReport.ReportDocumentDefine(dsPessoas)
        CrystalReportViewer.DisplayToolbar = True
    End Sub 'Ok

    Private Sub SetDsReportVariables()
        DSReport.pathDB = "C:\Users\admin\source\repos\Estudo_CrystalReports\Crystal Reports\CrystalReport1.rpt"
        DSReport.pathDS = "C:\Users\admin\source\repos\Estudo_CrystalReports\Crystal Reports\CrystalReport2.rpt"
       ' MessageBox.Show(rm.GetString("prompt"))
    End Sub
    #End Region
   
    
End Class
