Public Class Form14
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim i As Integer
    Dim bno As String
    Private Sub Form14_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select bno from Books order by bno desc", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            i = dr.Item("bno")
        Catch ex As Exception
            i = 0
        End Try
        dr.Close()
    End Sub

    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If ((Bookname.Text = "") Or (Publishername.Text = "") Or (Authorname.Text = "") Or (Price.Text = "") Or (Quantity.Text = "")) Then
            MsgBox("Please fill all Mandotary (*) fields")
        Else
            i = i + 1
            bno = "LIB-" & i
            Bookno.Text = bno
            cmd = New SqlClient.SqlCommand("insert into Books values('" & bno & "','" & Bookname.Text & "','" & Publishername.Text & "','" & Authorname.Text & "'," & Price.Text & "," & Quantity.Text & ",'" & Date1.Value & "','" & Loc1.Text & "','" & Loc2.Text & "','" & Loc3.Text & "','" & Remark.Text & "'," & i & ")", con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Added Successfully Book No.= " & bno)
            Submit.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Bookno.Clear()
        Bookname.Clear()
        Publishername.Clear()
        Authorname.Clear()
        Price.Clear()
        Quantity.Clear()
        Loc1.Clear()
        Loc2.Clear()
        Loc3.Clear()
        Remark.Clear()
        Submit.Enabled = True
    End Sub
End Class