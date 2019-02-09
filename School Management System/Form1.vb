Public Class Login
    Dim con, con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim filenum As Integer = FreeFile()
    Public constring As String

    
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim un As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        TextBox2.Text = "                                                                     "
        If (un = "" Or pass = "") Then
            MsgBox("User Name or Password cannot be left blank")
        Else

            If un = dr.Item("User_ID") Then
                If pass = dr.Item("Pass") Then
                    Me.Hide()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    dr.Close()
                    Form20.Show()
                Else
                    MsgBox("!Wrong Password")
                    TextBox2.Clear()
                    TextBox2.Focus()
                End If
            Else
                MsgBox("!Wrong User Name")
                TextBox2.Clear()
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con1 = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\School Management System\Connection.mdf;Integrated Security=True;User Instance=True")
        'con1.Open()
        'cmd = New SqlClient.SqlCommand("select * from Connectioninfo", con1)
        'dr = cmd.ExecuteReader()
        'dr.Read()
        'constring = dr.Item("ConnectionString")
        'dr.Close()
        FileOpen(filenum, "connection.txt", OpenMode.Input)
        constring = LineInput(filenum)
        constring = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & constring & ";Integrated Security=True;User Instance=True"
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from userauthenticaton where User_ID='Admin'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
