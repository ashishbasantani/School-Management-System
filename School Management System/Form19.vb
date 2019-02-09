Public Class Form19
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim issuedate As Date
    Dim validation As Boolean
    Private Sub Form19_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        validation = False
    End Sub

    Private Sub Issueno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Issueno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If (Issueno.Text = "") Then
                MsgBox("Please enter Book ssue No")
            Else
                cmd = New SqlClient.SqlCommand("select * from Issuebooks where Issueno='" & Issueno.Text & "'", con)
                dr = cmd.ExecuteReader()
                dr.Read()
                Try
                    Scode.Text = dr.Item("SID")
                    Bookno.Text = dr.Item("Bookno")
                    issuedate = dr.Item("Issuedate")
                    dr.Close()
                    cmd = New SqlClient.SqlCommand("select FName,MName,LName,Admissionclass from Student where SID='" & Scode.Text & "'", con)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Sname.Text = dr.Item("FName") + " " + dr.Item("MName") + " " + dr.Item("LName")
                    Sclass.Text = dr.Item("Admissionclass")
                    dr.Close()
                    cmd = New SqlClient.SqlCommand("select Bookname,Publishername,Authorname from Books where Bookno='" & Bookno.Text & "'", con)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Bname.Text = dr.Item("Bookname")
                    Pubname.Text = dr.Item("Publishername")
                    Autname.Text = dr.Item("Authorname")
                    dr.Close()
                    validation = True
                Catch ex As Exception
                    MsgBox("Book Issue No doesn't exist")
                    dr.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (validation = False) Then
            MsgBox("Please Validate Book Issue No.")
        Else
            cmd = New SqlClient.SqlCommand("insert into Returnbooks values('" & Issueno.Text & "','" & Scode.Text & "','" & Bookno.Text & "','" & issuedate & "','" & Returndate.Value & "','" & Remark.Text & "')", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlClient.SqlCommand("delete from Issuebooks where Issueno='" & Issueno.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Returned Successfully")
            Submit.Enabled = False
            Bookno.Enabled = False
            Returndate.Enabled = False
            Remark.Enabled = False
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
        Scode.Clear()
        Sname.Clear()
        Sclass.Clear()
        Bookno.Clear()
        Bname.Clear()
        Pubname.Clear()
        Autname.Clear()
        Remark.Clear()
        Issueno.Clear()
        validation = False
        Submit.Enabled = True
        Bookno.Enabled = True
        Returndate.Enabled = True
        Remark.Enabled = True
    End Sub
End Class