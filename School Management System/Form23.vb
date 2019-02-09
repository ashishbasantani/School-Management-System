Public Class Form23
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Private Sub Form23_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (Feetype.Text = "" Or Amt.Text = "") Then
            MsgBox("Fee Type or Amount cannot be left blank")
        Else
            Try
                cmd = New SqlClient.SqlCommand("insert into Feemaster values('" & Feetype.Text & "'," & Amt.Text & ")", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlClient.SqlCommand("alter table Student add " & Feetype.Text & " INT ", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlClient.SqlCommand("update Student set " & Feetype.Text & "=" & Amt.Text, con)
                cmd.ExecuteNonQuery()
                Submit.Enabled = False
            Catch ex As Exception
                MsgBox("Fee Type Already Exist")
            End Try
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
        Feetype.Clear()
        Amt.Clear()
        Submit.Enabled = True
    End Sub
End Class