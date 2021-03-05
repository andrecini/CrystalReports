Imports CrystalDecisions.CrystalReports.Engine

Public Class Language
    Private Shared Dim ReportObjects As ReportObjects
    Private Shared Dim ReportObject As ReportObject
    Private Shared Dim TextObject As TextObject
    Private Shared Dim cont = 0

    Private Shared Sub SetEnglish()
        Dim fieldsText = New String() {"Name", "Balance", "Discount", "Average Liquidity:", "Average Discount:"}
        
        ScanTextObjects(fieldsText)
    End Sub

    Private Shared Sub SetPortuguese()
        Dim fieldsText = New String() {"Nome", "Saldo", "Desconto", "Liquidez Média:", "Desconto Médio:"}
        
        ScanTextObjects(fieldsText)
    End Sub

    Private Shared Sub ScanTextObjects(Byval fieldsText As String())
        ReportObjects = DSReport.ReportDoc.ReportDefinition.ReportObjects()

        For Each ReportObject In ReportObjects
            If ReportObject.Kind = CrystalDecisions.[Shared].ReportObjectKind.TextObject Then
                Try
                    TextObject = ReportObject
                    TextObject.Text = fieldsText(cont)
                    cont+=1
                Catch ex As Exception
                        
                End Try
            End If
        Next

        cont = 0
    End Sub

    Public Shared Sub SetLanguage(ByVal language As String)
        If language = "English"
            SetEnglish()
        ElseIf language = "Portuguese"
            SetPortuguese()
        End If
    End Sub
End Class
