Public Class Form17
    Dim con, con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr, dr1 As SqlClient.SqlDataReader
    Dim adt As SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim i, j As Integer
    Dim sno As String
    Private Sub Form17_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        'con1 = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con1 = New SqlClient.SqlConnection(Login.constring)
        con1.Open()
        DataGridView1.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd = New SqlClient.SqlCommand("select count(*) from issuebooks where bookno='" & TextBox1.Text & "'", con)
            i = cmd.ExecuteScalar()
            cmd = New SqlClient.SqlCommand("select sid from issuebooks where bookno='" & TextBox1.Text & "'", con)
            dr = cmd.ExecuteReader()
            j = 0
            While (j < i)
                dr.Read()
                sno = dr.Item("sid")
                adt = New SqlClient.SqlDataAdapter("select sid S_Code,FName+' '+MName+' '+LName Name,Admissionclass Class,Bookno,Bookname,Publishername,Authorname from Student,Books where sid='" & sno & "' and books.bookno='" & TextBox1.Text & "'", con1)
                adt.Fill(ds, "Query")
                DataGridView1.DataSource = ds.Tables("Query").DefaultView
                DataGridView1.Show()
                j = j + 1
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Book No doesn't exist")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        DataGridView1.DataSource = "NULL"
        DataGridView1.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class