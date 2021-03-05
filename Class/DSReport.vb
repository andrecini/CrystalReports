Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource

Public Class DSReport
    Inherits Connection
    
    Public Shared Dim provider = "Provider=Microsoft.Jet.OLEDB.4.0;" &
    "Data Source=C:\Users\admin\source\repos\Estudo_CrystalReports\DataSets\TesteCR1.mdb;Persist Security Info=True"
    Public Shared Dim pathDB 
    Public Shared Dim pathDS 
    public Shared Dim ReportDoc As ReportDocument = New ReportDocument()
    Private Shared Dim drDataSet As OleDbDataReader

    Public Shared Function ReportDocumentDefine(ByVal ds As DataSet) As ReportDocument
        ReportDoc.Load(pathDS)
        ReportDoc.SetDataSource(ds)
        Return ReportDoc
    End Function

    Public Shared Sub DataTransfer(ByRef dt As Object, ReadBlockNum As Int16)
        
        connectionString = provider
        Open()

        If ReadBlockNum = 1 
            BlockReader1(dt)
        ElseIf ReadBlockNum = 2
            BlockReader2(dt)
        End If
   
        Close()
    End Sub

    Public Shared Sub BlockReader1(dt As Object)
        Dim str As String = "SELECT * FROM TesteCrystalReports"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cn)
        drDataSet = cmd.ExecuteReader()
        Dim dr As Object
        
        While drDataSet.Read()
            dr = dt.NewDSTesteCrystalReportsRow

            dr.ID = Convert.ToInt16(drDataSet("ID"))
            dr.First_Name = drDataSet("First Name")
            dr.Last_Name = drDataSet("Last Name")
            dr.Birthday = Convert.ToDateTime(drDataSet("Birthday"))
            dr.Phone = drDataSet("Phone")
            dr.Facebook = drDataSet("Facebook")
            dr.Email = drDataSet("Email")
            dr.Job_Title = drDataSet("Job Title")
           
            dt.AddDSTesteCrystalReportsRow(dr)
        End While
     End Sub

    Public Shared Sub BlockReader2(dt As Object)
        Dim str As String = "SELECT * FROM TesteFormulas"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cn)
        drDataSet = cmd.ExecuteReader()
        Dim dr As Object
        
        While drDataSet.Read()
            dr = dt.NewTesteFormulasRow

            dr.Nome = drDataSet("Nome")
            dr.Deposito = drDataSet("Deposito")
            dr.Saque = drDataSet("Saque")
            dr.Liquido = drDataSet("Salario Liquido")
            dr.Bruto = drDataSet("Salario bruto")
           
            dt.AddTesteFormulasRow(dr)
        End While
    End Sub

    Public Shared Function SetSubreportDoc(ByVal ds As DataSet) As Object
        Dim Doc As ReportDocument = New ReportDocument()
        
        Doc.Load(pathDB) 
        Doc.Subreports(0).SetDataSource(ds)
        
        Return Doc 
      End Function                     
            
End Class


