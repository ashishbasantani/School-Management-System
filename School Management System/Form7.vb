Public Class Form7
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        Panel2.Hide()
    End Sub

    Private Sub View_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles View.Click
        If Ecode.Text = "" Then
            MsgBox("Please Enter E_Code")
        Else
            Try
                cmd = New SqlClient.SqlCommand("select * from Employee where EID='" & Ecode.Text & "'", con)
                dr = cmd.ExecuteReader()
                dr.Read()
                Fname.Text = dr.Item("FName")
                Mname.Text = dr.Item("MName")
                Lname.Text = dr.Item("LName")
                Bdate.Text = dr.Item("BDate")
                Add1.Text = dr.Item("Address1")
                Add2.Text = dr.Item("Address2")
                City.Text = dr.Item("City")
                Zipcode.Text = dr.Item("Zipcode")
                State.Text = dr.Item("State")
                Aadharno.Text = dr.Item("Aadharno")
                PANNo.Text = dr.Item("PANNo")
                Employeedesig.Text = dr.Item("Empdesig")
                Email.Text = dr.Item("Email")
                Mobno.Text = dr.Item("Mobno")
                PhAr.Text = dr.Item("PhAr")
                PhNo.Text = dr.Item("PhNo")
                Basic.Text = dr.Item("Basicsal")
                HA.Text = dr.Item("HA")
                DA.Text = dr.Item("DA")
                Total.Text = dr.Item("Total")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.ImageLocation = dr.Item("Photo")
                If (dr.Item("Gender") = "Male") Then
                    Male.Checked = True
                ElseIf (dr.Item("Gender") = "Female") Then
                    Female.Checked = True
                End If
                If (dr.Item("Category") = "SC") Then
                    SC.Checked = True
                ElseIf (dr.Item("Category") = "ST") Then
                    ST.Checked = True
                ElseIf (dr.Item("Category") = "OBC") Then
                    OBC.Checked = True
                ElseIf (dr.Item("Category") = "GEN") Then
                    GEN.Checked = True
                End If
                Panel2.Show()
            Catch ex As Exception
                MsgBox("E_Code Doesn't Exist")
            End Try
            
        End If
        dr.Close()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Panel2.Hide()
        Ecode.Clear()
    End Sub

    Private Sub Ecode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ecode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            View_Click(sender, e)
        End If
    End Sub
End Class