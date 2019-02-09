Public Class Form16
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim validation As Boolean
    Private Sub Form16_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        validation = False
    End Sub

    Private Sub Bookno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Bookno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select * from Books where Bookno='" & Bookno.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                Bookname.Text = dr.Item("Bookname")
                Publishername.Text = dr.Item("Publishername")
                Authorname.Text = dr.Item("Authorname")
                Price.Text = dr.Item("Bookprice")
                Quantity.Text = dr.Item("Bookqty")
                Date1.Value = dr.Item("Date")
                Loc1.Text = dr.Item("Loc1")
                Loc2.Text = dr.Item("Loc2")
                Loc3.Text = dr.Item("Loc3")
                Remark.Text = dr.Item("Remark")
                dr.Close()
                validation = True
            Catch ex As Exception
                MsgBox("Book No doesn't exist")
                dr.Close()
                validation = False
            End Try
        End If
    End Sub

    Private Sub Update_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Update.Click
        If (Bookno.Text = "") Then
            MsgBox("Please enter Book No")
        ElseIf (validation = False) Then
            MsgBox("Please Validate Book no")
        Else
            cmd = New SqlClient.SqlCommand("update Books set Bookname='" & Bookname.Text & "',Publishername='" & Publishername.Text & "',Authorname='" & Authorname.Text & "',Bookprice=" & Price.Text & ",Bookqty=" & Quantity.Text & ",Date='" & Date1.Value & "',Loc1='" & Loc1.Text & "',Loc2='" & Loc2.Text & "',Loc3='" & Loc3.Text & "',Remark='" & Remark.Text & "'where Bookno='" & Bookno.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Updataion successfully completed")
            validation = False
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
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
    End Sub
End Class