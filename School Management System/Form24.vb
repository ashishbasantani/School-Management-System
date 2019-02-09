Public Class Form24
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim row, j As Integer
    Private Sub Form24_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select count(*) from Feemaster", con)
        row = cmd.ExecuteScalar()
        cmd = New SqlClient.SqlCommand("select * from Feemaster", con)
        dr = cmd.ExecuteReader()
        j = 0
        While (j < row)
            dr.Read()
            Feetype.Items.Add(dr.Item("Feetype"))
            j = j + 1
        End While
        dr.Close()
    End Sub

    Private Sub Feetype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Feetype.SelectedIndexChanged
        cmd = New SqlClient.SqlCommand("select Amount from Feemaster where Feetype='" & Feetype.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Curramt.Text = dr.Item("Amount")
        dr.Close()
    End Sub

    Private Sub Modify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modify.Click
        If Feetype.Text = "" Or Amt.Text = "" Then
            MsgBox("Fee Type or Amount cannot be left blank")
        Else
            cmd = New SqlClient.SqlCommand("update Feemaster set Amount=" & Amt.Text & " where Feetype='" & Feetype.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Fee Type Updated Successfully")
            Feetype_SelectedIndexChanged(sender, e)
        End If
    End Sub
End Class