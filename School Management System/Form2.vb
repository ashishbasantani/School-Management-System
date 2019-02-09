Public Class Home
    Dim i, j As Integer
    Private Sub CreateStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateStudentToolStripMenuItem.Click
        Form3.MdiParent = Me
        Label1.Hide()
        Form5.Close()
        Form4.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form3.Show()
    End Sub

    Private Sub ViewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentToolStripMenuItem.Click
        Form5.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form5.Show()
    End Sub

    Private Sub FeeEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeEntryToolStripMenuItem.Click
        Form4.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form4.Show()

    End Sub

    Private Sub CreateEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateEmployeeToolStripMenuItem.Click
        Form6.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form6.Show()
    End Sub

    Private Sub ViewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmployeeToolStripMenuItem.Click
        Form7.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form7.Show()
    End Sub

    Private Sub CalculateSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form8.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form8.Show()
    End Sub

    Private Sub ModifyStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyStudentToolStripMenuItem.Click
        Form10.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form10.Show()
    End Sub

    Private Sub ViewAllStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllStudentsToolStripMenuItem.Click
        Form9.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form9.Show()
    End Sub

    Private Sub PromoteStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromoteStudentToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub ModifyEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyEmployeeToolStripMenuItem.Click
        Form12.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form12.Show()
    End Sub

    Private Sub QueryEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryEmployeeToolStripMenuItem.Click
        Form13.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form13.Show()
    End Sub

    Private Sub AddBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBooksToolStripMenuItem.Click
        Form14.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form14.Show()
    End Sub

    Private Sub IssueBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBooksToolStripMenuItem.Click
        Form15.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form15.Show()
    End Sub

    Private Sub RemoveBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBooksToolStripMenuItem.Click
        Form16.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form17.Close()
        Form19.Close()
        Form16.Show()
    End Sub

    Private Sub GetBooksIssueDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBooksIssueDetailToolStripMenuItem.Click
        Form17.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form19.Close()
        Form17.Show()
    End Sub

    Private Sub FineEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FineEntryToolStripMenuItem.Click
        Form18.Show()
    End Sub

    Private Sub ReturnBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBooksToolStripMenuItem.Click
        Form19.MdiParent = Me
        Label1.Hide()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Form21.Show()
    End Sub

    Private Sub ChangeDatabaseLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDatabaseLocationToolStripMenuItem.Click
        Form22.Show()
    End Sub

    Public Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Show()
        Timer1.Enabled = True
        Timer1.Interval = 1
        i = 1365
        j = 50
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i - 1
        If i = -450 Then
            i = 1365
        End If
        Label1.Location = New Point(i, j)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form8.Close()
        Form10.Close()
        Form9.Close()
        Form12.Close()
        Form13.Close()
        Form14.Close()
        Form15.Close()
        Form16.Close()
        Form17.Close()
        Form19.Close()
        Form11.Close()
        Form18.Close()
        Form23.Close()
        Form24.Close()
        Home_Load(sender, e)
    End Sub

    Private Sub CreateNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewToolStripMenuItem.Click
        Form23.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Form24.Show()
    End Sub
End Class