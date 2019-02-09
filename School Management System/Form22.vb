Public Class Form22
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim constr As String
    Private Sub Form22_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\School Management System\Connection.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from Connectioninfo", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Currlocation.Text = dr.Item("ConnectionString")
        dr.Close()
    End Sub

    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (Newlocation.Text = "") Then
            MsgBox("Please provide new location of Database")
        Else
            constr = "Data Source=.\SQLEXPRESS;AttachDbFilename=" + Newlocation.Text + ";Integrated Security=True;User Instance=True"
            cmd = New SqlClient.SqlCommand("update Connectioninfo set ConnectionString='" & constr & "'", con)
            cmd.ExecuteNonQuery()
            Login.constring = constr
            MsgBox("Database Location Updation Succussfully Completed")
            Me.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()
            Form13.Close()
            Form14.Close()
            Form15.Close()
            Form16.Close()
            Form17.Close()
            Form18.Close()
            Form19.Close()
            Form20.Close()
            Form21.Close()
            Home.Home_Load(sender, e)
        End If
    End Sub

    Private Sub Close1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Close1.Click
        Me.Close()
    End Sub
End Class