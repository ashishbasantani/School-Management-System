Public Class Form6

    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim i, flag, P As Integer
    Dim gend, cat, eid, name1 As String

    Private Sub Form6_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select eno from Employee order by eno DESC", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            i = dr.Item("eno")
        Catch ex As Exception
            i = 0
        End Try
        dr.Close()
        flag = 0
        P = 0
    End Sub

    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If Fname.Text = "" Or Lname.Text = "" Or Add1.Text = "" Or City.Text = "" Or Empdesig.Text = "" Or Mobno.Text = "" Or Basicsal.Text = "" Or Totalsal.Text = "" Then
            MsgBox("Please fill all mandotary (*) fields")
        ElseIf P = 0 Then
            MsgBox("Please add Photo")
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
            If flag = 1 Then
                i = i + 1
                eid = "SMSE-" & i
                Ecode.Text = eid
                If (Mname.Text = "") Then
                    name1 = Fname.Text & " " & Lname.Text
                Else
                    name1 = Fname.Text & " " & Mname.Text & " " & Lname.Text
                End If
                Totalsal.Text = Val(Basicsal.Text) + Val(HA.Text) + Val(DA.Text)
                cmd = New SqlClient.SqlCommand("insert into Employee values('" & eid & "','" & Fname.Text & "','" & Mname.Text & "','" & Lname.Text & "','" & Bdate.Value & "','" & gend & "','" & Add1.Text & "','" & Add2.Text & "','" & City.Text & "','" & Zip.Text & "','" & Empdesig.Text & "','" & Jdate.Value & "','" & cat & "','" & Email.Text & "','" & Mobno.Text & "','" & PhAr.Text & "','" & PhNo.Text & "','" & Aadharno.Text & "','" & PANNo.Text & "'," & Basicsal.Text & "," & HA.Text & "," & DA.Text & "," & Totalsal.Text & ",'" & PictureDialog.FileName & "'," & i & ",'" & State.Text & "','" & name1 & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Created Successfully E_Code= " & eid)
            End If
        End If
    End Sub

    Private Sub Addphoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Addphoto.Click
        PictureDialog.Title = "Add Photo"
        PictureDialog.ShowDialog()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.ImageLocation = PictureDialog.FileName
        P = 1
    End Sub

    Private Sub Basicsal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Basicsal.TextChanged
        Totalsal.Text = Val(Basicsal.Text) + Val(HA.Text) + Val(DA.Text)
    End Sub


    Private Sub HA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HA.TextChanged
        Totalsal.Text = Val(Basicsal.Text) + Val(HA.Text) + Val(DA.Text)
    End Sub

    Private Sub DA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DA.TextChanged
        Totalsal.Text = Val(Basicsal.Text) + Val(HA.Text) + Val(DA.Text)
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Fname.Clear()
        Mname.Clear()
        Lname.Clear()
        Add1.Clear()
        Add2.Clear()
        City.Clear()
        Zip.Clear()
        Empdesig.Clear()
        Email.Clear()
        Mobno.Clear()
        PhAr.Clear()
        PhNo.Clear()
        Aadharno.Clear()
        PANNo.Clear()
        Basicsal.Clear()
        HA.Clear()
        DA.Clear()
        Totalsal.Clear()
        PictureBox1.ImageLocation = ""
        State.Text = " "
        Male.Checked = Female.Checked = False
        SC.Checked = ST.Checked = OBC.Checked = GEN.Checked = False
        Ecode.Clear()
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

    End Sub
End Class