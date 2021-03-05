<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdbRpt2 = New System.Windows.Forms.RadioButton()
        Me.rdbRpt1 = New System.Windows.Forms.RadioButton()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 65)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.rdbRpt2)
        Me.Panel2.Controls.Add(Me.rdbRpt1)
        Me.Panel2.Controls.Add(Me.btnReload)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtKeyword)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(571, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 65)
        Me.Panel2.TabIndex = 4
        '
        'rdbRpt2
        '
        Me.rdbRpt2.AutoSize = true
        Me.rdbRpt2.Checked = true
        Me.rdbRpt2.Location = New System.Drawing.Point(396, 35)
        Me.rdbRpt2.Name = "rdbRpt2"
        Me.rdbRpt2.Size = New System.Drawing.Size(51, 17)
        Me.rdbRpt2.TabIndex = 5
        Me.rdbRpt2.TabStop = true
        Me.rdbRpt2.Text = "Rpt 2"
        Me.rdbRpt2.UseVisualStyleBackColor = true
        '
        'rdbRpt1
        '
        Me.rdbRpt1.AutoSize = true
        Me.rdbRpt1.Location = New System.Drawing.Point(396, 12)
        Me.rdbRpt1.Name = "rdbRpt1"
        Me.rdbRpt1.Size = New System.Drawing.Size(51, 17)
        Me.rdbRpt1.TabIndex = 4
        Me.rdbRpt1.Text = "Rpt 1"
        Me.rdbRpt1.UseVisualStyleBackColor = true
        '
        'btnReload
        '
        Me.btnReload.BackgroundImage = Global.Estudo_CrystalReports.My.Resources.Resources.iconfinder_reload_172536
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReload.Location = New System.Drawing.Point(351, 17)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(30, 30)
        Me.btnReload.TabIndex = 3
        Me.btnReload.UseVisualStyleBackColor = true
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearch.Location = New System.Drawing.Point(239, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 31)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = true
        '
        'txtKeyword
        '
        Me.txtKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtKeyword.Location = New System.Drawing.Point(12, 18)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(221, 29)
        Me.txtKeyword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VB.Net - Crystal Reports"
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 65)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.Size = New System.Drawing.Size(1036, 429)
        Me.CrystalReportViewer.TabIndex = 1
        Me.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 494)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(732, 533)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crystal RePorts"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnReload As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdbRpt2 As RadioButton
    Friend WithEvents rdbRpt1 As RadioButton
End Class
