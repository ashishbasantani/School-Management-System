Public Class Form10
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim gend, cat As String

    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\Documents\Visual Studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        Panel2.Hide()
        Stream.Hide()
        Label16.Hide()
    End Sub

    Private Sub View_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles View.Click
        If (Scode.Text = "") Then
            MsgBox("Please enter S_Code")
        Else
            Try
                cmd = New SqlClient.SqlCommand("select * from Student where SID= '" & Scode.Text & "'", con)
                dr = cmd.ExecuteReader()
                dr.Read()
                Fname.Text = dr.Item("FName")
                Mname.Text = dr.Item("MName")
                Lname.Text = dr.Item("LName")
                Bdate.Value = dr.Item("BDate")
                Add1.Text = dr.Item("Address1")
                Add2.Text = dr.Item("Address2")
                City.Text = dr.Item("City")
                Zip.Text = dr.Item("Zipcode")
                State.Text = dr.Item("State")
                AdClass.Text = dr.Item("Admissionclass")
                Stream.Text = dr.Item("Stream")
                Email.Text = dr.Item("Email")
                Mobno.Text = dr.Item("Mob")
                PhAr.Text = dr.Item("PhAr")
                PhNo.Text = dr.Item("PhNo")
                If (dr.Item("Admissionclass") = "XI" Or dr.Item("Admissionclass") = "XII") Then
                    Stream.Show()
                    Label6.Show()
                End If


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
                MsgBox("S_Code does'nt exist")
            End Try

        End If
        dr.Close()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Panel2.Hide()
        Scode.Clear()
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        If (Male.Checked = True) Then
            gend = "Male"
        ElseIf (Female.Checked = True) Then
            gend = "Female"
        End If
        If (SC.Checked = True) Then
            cat = "SC"
        ElseIf (ST.Checked = True) Then
            cat = "ST"
        ElseIf (OBC.Checked = True) Then
            cat = "OBC"
        ElseIf (GEN.Checked = True) Then
            cat = "GEN"
        End If
        cmd = New SqlClient.SqlCommand("update Student set FName='" & Fname.Text & "',MName='" & Mname.Text & "',LName='" & Lname.Text & "',BDate='" & Bdate.Value & "',Gender='" & gend & "',Address1='" & Add1.Text & "',Address2='" & Add2.Text & "',City='" & City.Text & "',Zipcode='" & Zip.Text & "',State='" & State.Text & "',Admissionclass='" & AdClass.Text & "',Stream='" & Stream.Text & "',Category='" & cat & "',Email='" & Email.Text & "',Mob='" & Mobno.Text & "',PhAr='" & PhAr.Text & "',PhNo='" & PhNo.Text & "' where SID= '" & Scode.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Student Updation Successfully Completed")
    End Sub

    Private Sub AdClass_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdClass.SelectedIndexChanged
        If (AdClass.Text = "XI" Or AdClass.Text = "XII") Then
            Label16.Show()
            Stream.Show()

        Else
            Label16.Hide()
            Stream.Hide()
            Stream.ResetText()
        End If
    End Sub

    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            View_Click(sender, e)
        End If
    End Sub
End Class