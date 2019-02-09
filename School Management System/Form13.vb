Public Class Form13
    Dim con As SqlClient.SqlConnection
    Dim adp As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub Form13_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        Querytable.Hide()
        Go.Enabled = False
        Reset.Enabled = False
        DataGridView1.Hide()
        Mode.Hide()
        Label21.Hide()
    End Sub

    Private Sub Query_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Query.Click
        Querytable.Show()
        Go.Enabled = True
        Mode.Show()
    End Sub

    Private Sub Go_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Go.Click
        If (Name1.Text = "" And Gender.Text = "" And City.Text = "" And State.Text = "" And Employeedesig.Text = "" And Category.Text = "" And Mobno.Text = "") Then
            MsgBox("Please fill atleast one field")
        ElseIf (chAND.Checked = False And chOR.Checked = False) Then
            MsgBox("Please Select Query Mode")
        Else
            Reset.Enabled = True
            Label21.Show()
            If (chAND.Checked = True) Then
                adp = New SqlClient.SqlDataAdapter("select Fullname Name,BDate Date_Of_Birth,Gender,Address1+','+Address2 Address,City,State,Empdesig,Category,Mobno,Total Total_Salary,Email from Employee where Fullname= '" & Name1.Text & "'and Gender='" & Gender.Text & "' and City='" & City.Text & "' and State='" & State.Text & "' and Empdesig='" & Employeedesig.Text & "' and Category='" & Category.Text & "' and Mobno='" & Mobno.Text & "'", con)
            ElseIf (chOR.Checked = True) Then
                adp = New SqlClient.SqlDataAdapter("select Fullname Name,BDate Date_Of_Birth,Gender,Address1+','+Address2 Address,City,State,Empdesig,Category,Mobno,Total Total_Salary,Email from Employee where Fullname= '" & Name1.Text & "'or Gender='" & Gender.Text & "' or City='" & City.Text & "' or State='" & State.Text & "' or Empdesig='" & Employeedesig.Text & "' or Category='" & Category.Text & "' or Mobno='" & Mobno.Text & "'", con)
            End If
            adp.Fill(ds, "Query")
            DataGridView1.DataSource = ds.Tables("Query").DefaultView
            DataGridView1.Show()
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
        Querytable.Hide()
        Go.Enabled = False
        Label21.Hide()
        DataGridView1.DataSource = "Null"
        DataGridView1.Hide()
        Mode.Hide()
        ds.Clear()
        Name1.Clear()
        City.Clear()
        Gender.Text = " "
        Mobno.Clear()
        Category.Text = " "
        State.Text = " "
        Reset.Enabled = False
        Employeedesig.Clear()
    End Sub
End Class