Public Class Form21
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim olpass As String
    Private Sub Form21_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from userauthenticaton", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        olpass = dr.Item("Pass")
        dr.Close()
        Label6.Text = "Password Mismatched"
        Label6.Hide()
    End Sub

    Private Sub Changepass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Changepass.Click
        If (Oldpass.Text = "" Or Newpass.Text = "" Or Confirmpass.Text = "") Then
            MsgBox("Please fill all fields")
        ElseIf Oldpass.Text <> olpass Then
            MsgBox("Old Password is not correct")
        ElseIf Newpass.Text <> Confirmpass.Text Then
            MsgBox("Password mismatch between New Password & Confirm Password")
        Else
            cmd = New SqlClient.SqlCommand("update userauthenticaton set Pass='" & Newpass.Text & "' where User_ID='Admin'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Password Changed Successfully")
            Me.Close()
        End If
    End Sub

    Private Sub Confirmpass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Confirmpass.Click
        Label6.Show()
    End Sub

    Private Sub Confirmpass_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Confirmpass.Enter
        Label6.Show()
    End Sub

    Private Sub Confirmpass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Confirmpass.TextChanged
        If (Confirmpass.Text = Newpass.Text) Then
            Label6.ForeColor = Color.Green
            Label6.Text = "Password Matched"
        Else
            Label6.ForeColor = Color.Red
            Label6.Text = "Password Mismatched"
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class