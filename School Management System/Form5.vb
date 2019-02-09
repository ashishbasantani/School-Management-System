Public Class Form5
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\Documents\Visual Studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        Panel2.Hide()
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
                MsgBox("S_Code does'nt exist")
                Scode.Clear()
            End Try

        End If
        dr.Close()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Panel2.Hide()
        Scode.Clear()
    End Sub

    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            View_Click(sender, e)
        End If
    End Sub
End Class