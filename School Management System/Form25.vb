Public Class Form25

    Private Sub Form25_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ob As New CrystalReport2
        ob.SetParameterValue("recno", Form4.Recno.Text)
        ob.SetParameterValue("feetype", Form4.Feetype.Text)
        ob.SetParameterValue("scode", Form4.Scode.Text)
        ob.SetParameterValue("name", Form4.Name1.Text)
        ob.SetParameterValue("amt", Form4.Amount.Text)
        CrystalReportViewer1.ReportSource = ob
    End Sub
End Class