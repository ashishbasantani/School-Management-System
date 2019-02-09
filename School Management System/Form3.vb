Public Class Form3

    Dim con, con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim P As Integer = 0
    Dim x, i, flag, j, row As Integer
    Dim sid, gend, cat, name1 As String
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        con1 = New SqlClient.SqlConnection(Login.constring)
        con1.Open()
        'cmd = New SqlClient.SqlCommand("select * from Student", con)
        'x = cmd.ExecuteNonQuery()
        cmd = New SqlClient.SqlCommand("select sno from Student order by sno desc", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            i = dr.Item("sno")
        Catch ex As Exception
            i = 0
        End Try
        dr.Close()
        flag = 1
        Label16.Hide()
        Stream.Hide()
    End Sub


    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (Fname.Text = "" Or Lname.Text = "" Or Add1.Text = "" Or City.Text = "" Or Zip.Text = "" Or Mobno.Text = "" Or State.Text = "") Then
            MsgBox("Please fill all mandotory (*) fields")
        ElseIf (P = 0) Then
            MsgBox("Please Add Photo")
        Else
            If (Male.Checked = True) Then
                gend = "Male"
                flag = 1
            ElseIf (Female.Checked = True) Then
                gend = "Female"
                flag = 1
            Else
                MsgBox("Please Select Gender")
                flag = 0
            End If
            If (SC.Checked = True) Then
                cat = "SC"
                flag = 1
            ElseIf (ST.Checked = True) Then
                cat = "ST"
                flag = 1
            ElseIf (OBC.Checked = True) Then
                cat = "OBC"
                flag = 1
            ElseIf (GEN.Checked = True) Then
                cat = "GEN"
                flag = 1
            Else
                MsgBox("Please Select Category")
                flag = 0
            End If
            If (flag = 1) Then

                i = i + 1
                sid = "SMSS-" & i
                Scode.Text = sid
                If (Mname.Text = "") Then
                    name1 = Fname.Text & " " & Lname.Text
                Else
                    name1 = Fname.Text & " " & Mname.Text & " " & Lname.Text
                End If

                cmd = New SqlClient.SqlCommand("insert into Student (SID,FName,MName,LName,BDate,Gender,Address1,Address2,City,Zipcode,State,Admissionclass,Stream,Category,Email,Mob,PhAr,PhNo,sno,Photo,Fullname) values('" & sid & "','" & Fname.Text & "','" & Mname.Text & "','" & Lname.Text & "','" & Bdate.Value & "', '" & gend & "','" & Add1.Text & "','" & Add2.Text & "','" & City.Text & "','" & Zip.Text & "','" & State.Text & "','" & Adclass.Text & "','" & Stream.Text & "','" & cat & "','" & Email.Text & "','" & Mobno.Text & "','" & PhAr.Text & "','" & PhNo.Text & "'," & i & ",'" & PictureDialog.FileName & "','" & name1 & "')", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlClient.SqlCommand("select count(*) from Feemaster", con)
                row = cmd.ExecuteScalar()
                cmd = New SqlClient.SqlCommand("select * from Feemaster", con)
                dr = cmd.ExecuteReader()
                j = 0
                While (j < row)
                    dr.Read()
                    cmd = New SqlClient.SqlCommand("update  Student set " & dr.Item("Feetype") & "=" & dr.Item("Amount") & " where SID='" & sid & "'", con1)
                    cmd.ExecuteNonQuery()
                    j = j + 1
                End While
                MsgBox("Student Registered Successfully S_Code= " & sid)
            End If
        End If

    End Sub

    Private Sub Addphoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Addphoto.Click
        PictureDialog.Title = "Add Photo"
        PictureDialog.FileName = ""
        PictureDialog.ShowDialog()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.ImageLocation = PictureDialog.FileName
        P = 1
    End Sub

    Private Sub Adclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adclass.SelectedIndexChanged
        If (Adclass.Text = "XI" Or Adclass.Text = "XII") Then
            Label16.Show()
            Stream.Show()
        Else
            Label16.Hide()
            Stream.Hide()
        End If

    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Fname.Clear()
        Mname.Clear()
        Lname.Clear()
        Add1.Clear()
        Add2.Clear()
        City.Clear()
        Zip.Clear()
        State.ResetText()
        Adclass.ResetText()
        Stream.ResetText()
        Email.Clear()
        Mobno.Clear()
        PhAr.Clear()
        PhNo.Clear()
        Scode.Clear()
        PictureBox1.ImageLocation = ""
        Male.Checked = False
        Female.Checked = False
        SC.Checked = False
        ST.Checked = False
        OBC.Checked = False
        GEN.Checked = False
    End Sub
End Class