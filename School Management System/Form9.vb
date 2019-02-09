Public Class Form9

    Dim con As SqlClient.SqlConnection
    Dim adp As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Querytable.Hide()
        DataGridView1.Hide()
        Go.Enabled = False
        Label21.Hide()
        Mode.Hide()
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        Stream.Enabled = False
        Reset.Enabled = False
    End Sub

    Private Sub Query_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Query.Click
        Querytable.Show()
        Go.Enabled = True
        Mode.Show()
    End Sub

    Private Sub Go_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Go.Click
        If ((Name1.Text = "") And (Gender.Text = "") And (City.Text = "") And (State.Text = "") And (Class1.Text = "") And (Stream.Text = "") And (Category.Text = "") And (Mobno.Text = "")) Then
            MsgBox("Please fill atleast one field")
        ElseIf (chAND.Checked = False And chOR.Checked = False) Then
            MsgBox("Please Select Query Mode")
        Else
            Reset.Enabled = True
            Label21.Show()
            If chAND.Checked = True Then
                adp = New SqlClient.SqlDataAdapter("select SID,Fullname Name,BDate,Gender,Address1+','+Address2 Address,City,Zipcode,State,Admissionclass Class,Category,Mob,Email from Student where Gender='" & Gender.Text & "' and City='" & City.Text & "' and State='" & State.Text & "' and Admissionclass='" & Class1.Text & "' and Stream='" & Stream.Text & "' and Category='" & Category.Text & "' and Mob='" & Mobno.Text & "'and Fullname='" & Name1.Text & "'", con)
            ElseIf (Class1.Text = "XI" Or Class1.Text = "XII") Then
                adp = New SqlClient.SqlDataAdapter("select SID,Fullname Name,BDate,Gender,Address1+','+Address2 Address,City,Zipcode,State,Admissionclass Class,Category,Mob,Email from Student where Gender='" & Gender.Text & "' or City='" & City.Text & "' or State='" & State.Text & "' or Admissionclass='" & Class1.Text & "' or Stream='" & Stream.Text & "' or Category='" & Category.Text & "' or Mob='" & Mobno.Text & "'or Fullname='" & Name1.Text & "'", con)
            Else
                adp = New SqlClient.SqlDataAdapter("select SID,Fullname Name,BDate,Gender,Address1+','+Address2 Address,City,Zipcode,State,Admissionclass Class,Category,Mob,Email from Student where Gender='" & Gender.Text & "' or City='" & City.Text & "' or State='" & State.Text & "' or Admissionclass='" & Class1.Text & "' or Category='" & Category.Text & "' or Mob='" & Mobno.Text & "'or Fullname='" & Name1.Text & "'", con)
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
        Class1.Text = " "
        Stream.Text = " "
        Reset.Enabled = False
    End Sub

    Private Sub Class1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class1.SelectedIndexChanged
        If (Class1.Text = "XI" Or Class1.Text = "XII") Then
            Stream.Enabled = True
        Else
            Stream.Enabled = False
        End If
    End Sub
End Class