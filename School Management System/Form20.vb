Public Class Form20
    Dim i As Integer
    Private Sub Form20_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Interval = 100
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 1
        ProgressBar1.Value = i
        If (i >= 100) Then
            Timer1.Stop()
            Me.Hide()
            Home.Show()
        End If
    End Sub
End Class