Public Class Form15

    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim i, j As Integer
    Dim issueno As String
    Dim validatestud, validatebook As Boolean
    Private Sub Form15_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select ino from Issuebooks order by ino desc", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            i = dr.Item("ino")
        Catch ex As Exception
            i = 0
        End Try
        dr.Close()
        validatestud = False
        validatebook = False
    End Sub

    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select FName,MName,LName,Admissionclass from Student where SID='" & Scode.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                Sname.Text = dr.Item("FName") & " " & dr.Item("MName") & " " & dr.Item("LName")
                Sclass.Text = dr.Item("Admissionclass")
                validatestud = True
            Catch ex As Exception
                MsgBox("S_Code doesn't Exist")
            End Try
            dr.Close()
            cmd = New SqlClient.SqlCommand("select Bookissued from Booksissued where SID='" & Scode.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                j = dr.Item("Bookissued")
            Catch ex As Exception
                j = 0
            End Try
            Issuedbooks.Text = j
            dr.Close()
        End If
    End Sub

    Private Sub Bookno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Bookno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select Bookname,Publishername,Authorname from Books where Bookno='" & Bookno.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                Bname.Text = dr.Item("Bookname")
                Pubname.Text = dr.Item("Publishername")
                Autname.Text = dr.Item("Authorname")
                validatebook = True
            Catch ex As Exception
                MsgBox("Book No doesn't exists")
            End Try
        End If
        dr.Close()
    End Sub

    Private Sub Uploadsign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Uploadsign.Click
        UploadSignature.ShowDialog()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.ImageLocation = UploadSignature.FileName
    End Sub

    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (Scode.Text = "") Then
            MsgBox("Please fill S_Code")
        ElseIf (Bookno.Text = "") Then
            MsgBox("Please fill Book No.")
        ElseIf (validatestud = False) Then
            MsgBox("Please Validate Student Details")
        ElseIf (validatebook = False) Then
            MsgBox("Please Validate Book Details")
        Else
            i = i + 1
            issueno = "BISSN-" & i
            cmd = New SqlClient.SqlCommand("insert into Issuebooks values('" & issueno & "','" & Scode.Text & "','" & Bookno.Text & "','" & Issuedate.Value & "','" & UploadSignature.FileName & "'," & i & ")", con)
            cmd.ExecuteNonQuery()
            validatebook = False
            validatestud = False
            If (j = 0) Then
                j = j + 1
                cmd = New SqlClient.SqlCommand("insert into Booksissued values('" & Scode.Text & "'," & j & ")", con)
                cmd.ExecuteNonQuery()
            Else
                j = j + 1
                cmd = New SqlClient.SqlCommand("update Booksissued set Bookissued=" & j & " where SID='" & Scode.Text & "'", con)
                cmd.ExecuteNonQuery()

            End If
            Submit.Enabled = False
            MsgBox("Book Issued Successfully Book_No = " & issueno)
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
        validatebook = False
        validatestud = False
        Scode.Clear()
        Sname.Clear()
        Sclass.Clear()
        Issuedbooks.Clear()
        Bookno.Clear()
        Bname.Clear()
        Autname.Clear()
        Pubname.Clear()
        PictureBox1.ImageLocation = ""
        Submit.Enabled = True
    End Sub
End Class