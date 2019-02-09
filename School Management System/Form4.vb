Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class Form4
    Dim con As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Dim i, row, j, fees As Integer
    Dim rno, particular As String
    Dim validation As Boolean
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd = New SqlClient.SqlCommand("select count(*) from Feemaster", con)
        row = cmd.ExecuteScalar()
        cmd = New SqlClient.SqlCommand("select * from Feemaster", con)
        dr = cmd.ExecuteReader()
        j = 0
        While (j < row)
            dr.Read()
            Feetype.Items.Add(dr.Item("Feetype"))
            j = j + 1
        End While
        Label19.Hide()
        validation = False
        dr.Close()
        Report.Hide()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If (Scode.Text = "") Then
            MsgBox("Please Enter S_Code")
        ElseIf fees <= 0 Then
            MsgBox("Fees Already Paid")
        Else
            i = i + 1
            rno = "REC-" & i
            fees = fees - Val(Amount.Text)
            particular = "Being Fee Paid By Student S_Code = " & Scode.Text
            cmd = New SqlClient.SqlCommand("insert into Cashbook values('" & particular & "','" & rno & "','" & Transdate.Value & "'," & Amount.Text & ",0," & i & ",0,'" & Remark.Text & "')", con)
            cmd.ExecuteNonQuery()
            Recno.Text = rno
            cmd = New SqlClient.SqlCommand("update Student set " & Feetype.Text & "= " & fees & "where SID='" & Scode.Text & "'", con)
            cmd.ExecuteNonQuery()
            Label19.Text = "Remaining fees : " & fees
            MsgBox("Transaction Completed Successfully Receipt No. = " & rno)
            Submit.Enabled = False
            Report.Show()
        End If
    End Sub

    Private Sub Scode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Scode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd = New SqlClient.SqlCommand("select FName,MName,LName from Student where SID='" & Scode.Text & "'", con)
            dr = cmd.ExecuteReader()
            dr.Read()
            Try
                Name1.Text = dr.Item("FName") & " " & dr.Item("MName") & " " & dr.Item("LName")
                validation = True
                Feetype.Enabled = True
            Catch ex As Exception
                MsgBox("S_Code doesn't Exist")
                validation = False
            End Try
            dr.Close()
        End If
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        Recno.Clear()
        Scode.Clear()
        Name1.Clear()
        Amount.Clear()
        Remark.Clear()
        Label19.Hide()
        validation = False
        Submit.Enabled = True
        Report.Hide()
    End Sub

    Private Sub Feetype_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Feetype.Click
        If validation = False Then
            MsgBox("Please Validate S_Code")
            Feetype.Enabled = False
        End If
    End Sub

    Private Sub Feetype_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Feetype.Enter
        If validation = False Then
            MsgBox("Please Validate S_Code")
            Feetype.Enabled = False
        End If
    End Sub

    Private Sub Feetype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Feetype.SelectedIndexChanged
        cmd = New SqlClient.SqlCommand("select " & Feetype.Text & " from Student where SID='" & Scode.Text & "'", con)
        dr = cmd.ExecuteReader()
        dr.Read()
        fees = dr.Item(Feetype.Text)
        Label19.Text = "Remaining fees : " & fees
        Label19.Show()
        dr.Close()
    End Sub

    Private Sub Report_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Report.Click
        Form25.Show()
    End Sub
End Class