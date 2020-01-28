Public Class MasProRep

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim MasPro As New MasterProd
        Me.CrystalReportViewer1.ReportSource = MasPro
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "ODBC"
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "ODBC"
    End Sub
End Class
