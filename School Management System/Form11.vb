Public Class Form11

    Dim con, con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr, dr1 As SqlClient.SqlDataReader
    Dim val As Boolean
    Dim row, j, totfee As Integer
    Private Sub Form11_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        con1 = New SqlClient.SqlConnection(Login.constring)
        con1.Open()
        Panel1.Enabled = False
        Panel2.Enabled = False
        val = False
    End Sub

    Private Sub Promote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Promote.Click
        If val = True Then
            If totfee > 0 Then
                j = MsgBox("There is some pending fees for the student to be promoted (pending fees = " & totfee & " ). Do you still want to continue by ignoring this message", 4)
                If (j = MsgBoxResult.Yes) Then
A:
                    If (CClass.Text = "Nursery") Then
                        PClass.Text = "LKG"
                    ElseIf (CClass.Text = "LKG") Then
                        PClass.Text = "UKG"
                    ElseIf (CClass.Text = "UKG") Then
                        PClass.Text = "I"
                    ElseIf (CClass.Text = "I") Then
                        PClass.Text = "II"
                    ElseIf (CClass.Text = "II") Then
                        PClass.Text = "III"
                    ElseIf (CClass.Text = "III") Then
                        PClass.Text = "IV"
                    ElseIf (CClass.Text = "IV") Then
                        PClass.Text = "V"
                    ElseIf (CClass.Text = "V") Then
                        PClass.Text = "VI"
                    ElseIf (CClass.Text = "VI") Then
                        PClass.Text = "VII"
                    ElseIf (CClass.Text = "VII") Then
                        PClass.Text = "VIII"
                    ElseIf (CClass.Text = "VIII") Then
                        PClass.Text = "IX"
                    ElseIf (CClass.Text = "IX") Then
                        PClass.Text = "X"
                    ElseIf (CClass.Text = "X") Then
                        PClass.Text = "XI"
                    ElseIf (CClass.Text = "XI") Then
                        PClass.Text = "XII"
                    ElseIf (CClass.Text = "XII") Then
                        MsgBox("Student Passed out From School")
                        PClass.Text = "Passed Out"
                    End If
                    cmd = New SqlClient.SqlCommand("update student set Admissionclass='" & PClass.Text & "' where SID='" & Scode.Text & "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student Promoted Successsfully")
                Else
                    Me.Close()
                End If
            Else
                GoTo A
            End If
        Else
            MsgBox("Please Validate S_Code")
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reset.Click
        Scode.Clear()
        Name1.Clear()
        CClass.Clear()
        PClass.Clear()
        val = False
        Scode.ReadOnly = False
        totfee = 0
    End Sub

    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            PClass.Clear()
            If (Scode.Text = "") Then
                MsgBox("Please Enter Scode of Student")
            Else
                Try
                    cmd = New SqlClient.SqlCommand("select FName,MName,LName,Admissionclass from Student where SID='" & Scode.Text & "'", con)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    CClass.Text = dr.Item("Admissionclass")
                    Name1.Text = dr.Item("FName") & " " & dr.Item("MName") & " " & dr.Item("LName")
                    val = True
                    Scode.ReadOnly = True
                    Try
                        dr.Close()
                        cmd = New SqlClient.SqlCommand("select count(*) from Feemaster", con)
                        row = cmd.ExecuteScalar()
                        cmd = New SqlClient.SqlCommand("select * from Feemaster", con)
                        dr = cmd.ExecuteReader()
                        j = 0
                        While (j < row)
                            dr.Read()
                            cmd = New SqlClient.SqlCommand("select " & dr.Item("Feetype") & " from Student where SID='" & Scode.Text & "'", con1)
                            dr1 = cmd.ExecuteReader()
                            dr1.Read()
                            totfee = totfee + (dr1.Item(dr.Item("Feetype")))
                            dr1.Close()
                            j = j + 1
                        End While
                        dr.Close()
                    Catch ex As Exception

                    End Try
                Catch ex As Exception
                    MsgBox("S_Code Doesn't Exist")
                    dr.Close()
                    val = False
                End Try
                dr.Close()
            End If
        End If
    End Sub
End Class