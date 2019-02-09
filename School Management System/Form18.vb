Public Class Form18
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim i As Integer
    Dim validation As Boolean
    Dim vno, particular As String
    Private Sub Form18_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'con = New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mohit\documents\visual studio 2010\Projects\School Management System\School Management System\SMS.mdf;Integrated Security=True;User Instance=True")
        con = New SqlClient.SqlConnection(Login.constring)
        con.Open()
        cmd = New SqlClient.SqlCommand("select rno from Cashbook order by rno desc", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        Try
            i = dr.Item("rno")
        Catch ex As Exception
            i = 0
        End Try
        dr.Close()
        validation = False
    End Sub
    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select FName,MName,LName,Admissionclass from Student where SID='" & Scode.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                Sname.Text = dr.Item("FName") + " " + dr.Item("MName") + " " + dr.Item("LName")
                Sclass.Text = dr.Item("Admissionclass")
                validation = True
                dr.Close()
            Catch ex As Exception
                MsgBox("S_Code doesn't exist")
                dr.Close()
            End Try
        End If
    End Sub
    Private Sub Submit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (validation = False) Then
            MsgBox("Please validate S_Code")
        ElseIf (Reason.Text = "") Then
            MsgBox("Please Provide Reason")
        Else
            i = i + 1
            vno = "REC-" & i
            particular = "Being Library Fine Paid for S_Code= " & Scode.Text & "Reason= " & Reason.Text
            cmd = New SqlClient.SqlCommand("insert into Cashbook values('" & particular & "','" & vno & "','" & Date1.Value & "'," & Amount.Text & ",0," & i & ",0,'S_Code = " & Scode.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Transaction Completed Successfully Receipt No. = " & vno)
        End If
    End Sub
    Private Sub Close_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Close1.Click
        Me.Close()
    End Sub
End Class