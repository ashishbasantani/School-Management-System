<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDatabaseLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromoteStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueryEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedSalaryReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetBooksIssueDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FineEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSubjectsClassWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StudentToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.WindowToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ChangeDatabaseLocationToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ChangeDatabaseLocationToolStripMenuItem
        '
        Me.ChangeDatabaseLocationToolStripMenuItem.Name = "ChangeDatabaseLocationToolStripMenuItem"
        Me.ChangeDatabaseLocationToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ChangeDatabaseLocationToolStripMenuItem.Text = "Change Database Location"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateStudentToolStripMenuItem, Me.ViewStudentToolStripMenuItem, Me.FeeEntryToolStripMenuItem, Me.ModifyStudentToolStripMenuItem, Me.ViewAllStudentsToolStripMenuItem, Me.PromoteStudentToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'CreateStudentToolStripMenuItem
        '
        Me.CreateStudentToolStripMenuItem.Name = "CreateStudentToolStripMenuItem"
        Me.CreateStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CreateStudentToolStripMenuItem.Text = "Create Student"
        '
        'ViewStudentToolStripMenuItem
        '
        Me.ViewStudentToolStripMenuItem.Name = "ViewStudentToolStripMenuItem"
        Me.ViewStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewStudentToolStripMenuItem.Text = "View Student"
        '
        'FeeEntryToolStripMenuItem
        '
        Me.FeeEntryToolStripMenuItem.Name = "FeeEntryToolStripMenuItem"
        Me.FeeEntryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FeeEntryToolStripMenuItem.Text = "Fee Entry"
        '
        'ModifyStudentToolStripMenuItem
        '
        Me.ModifyStudentToolStripMenuItem.Name = "ModifyStudentToolStripMenuItem"
        Me.ModifyStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ModifyStudentToolStripMenuItem.Text = "Modify Student"
        '
        'ViewAllStudentsToolStripMenuItem
        '
        Me.ViewAllStudentsToolStripMenuItem.Name = "ViewAllStudentsToolStripMenuItem"
        Me.ViewAllStudentsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewAllStudentsToolStripMenuItem.Text = "Query Students"
        '
        'PromoteStudentToolStripMenuItem
        '
        Me.PromoteStudentToolStripMenuItem.Name = "PromoteStudentToolStripMenuItem"
        Me.PromoteStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PromoteStudentToolStripMenuItem.Text = "Promote Student"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateEmployeeToolStripMenuItem, Me.ViewEmployeeToolStripMenuItem, Me.ModifyEmployeeToolStripMenuItem, Me.QueryEmployeeToolStripMenuItem, Me.FeedSalaryReceiptToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'CreateEmployeeToolStripMenuItem
        '
        Me.CreateEmployeeToolStripMenuItem.Name = "CreateEmployeeToolStripMenuItem"
        Me.CreateEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CreateEmployeeToolStripMenuItem.Text = "Create Employee"
        '
        'ViewEmployeeToolStripMenuItem
        '
        Me.ViewEmployeeToolStripMenuItem.Name = "ViewEmployeeToolStripMenuItem"
        Me.ViewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ViewEmployeeToolStripMenuItem.Text = "View Employee"
        '
        'ModifyEmployeeToolStripMenuItem
        '
        Me.ModifyEmployeeToolStripMenuItem.Name = "ModifyEmployeeToolStripMenuItem"
        Me.ModifyEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ModifyEmployeeToolStripMenuItem.Text = "Modify Employee"
        '
        'QueryEmployeeToolStripMenuItem
        '
        Me.QueryEmployeeToolStripMenuItem.Name = "QueryEmployeeToolStripMenuItem"
        Me.QueryEmployeeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.QueryEmployeeToolStripMenuItem.Text = "Query Employee"
        '
        'FeedSalaryReceiptToolStripMenuItem
        '
        Me.FeedSalaryReceiptToolStripMenuItem.Name = "FeedSalaryReceiptToolStripMenuItem"
        Me.FeedSalaryReceiptToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FeedSalaryReceiptToolStripMenuItem.Text = "Feed Salary Receipt"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBooksToolStripMenuItem, Me.IssueBooksToolStripMenuItem, Me.RemoveBooksToolStripMenuItem, Me.GetBooksIssueDetailToolStripMenuItem, Me.FineEntryToolStripMenuItem, Me.ReturnBooksToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ReportsToolStripMenuItem.Text = "Library"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddBooksToolStripMenuItem.Text = "Add Books"
        '
        'IssueBooksToolStripMenuItem
        '
        Me.IssueBooksToolStripMenuItem.Name = "IssueBooksToolStripMenuItem"
        Me.IssueBooksToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.IssueBooksToolStripMenuItem.Text = "Issue Books"
        '
        'RemoveBooksToolStripMenuItem
        '
        Me.RemoveBooksToolStripMenuItem.Name = "RemoveBooksToolStripMenuItem"
        Me.RemoveBooksToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RemoveBooksToolStripMenuItem.Text = "Modify Books"
        '
        'GetBooksIssueDetailToolStripMenuItem
        '
        Me.GetBooksIssueDetailToolStripMenuItem.Name = "GetBooksIssueDetailToolStripMenuItem"
        Me.GetBooksIssueDetailToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GetBooksIssueDetailToolStripMenuItem.Text = "Get Books Issue Detail"
        '
        'FineEntryToolStripMenuItem
        '
        Me.FineEntryToolStripMenuItem.Name = "FineEntryToolStripMenuItem"
        Me.FineEntryToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.FineEntryToolStripMenuItem.Text = "Fine Entry"
        '
        'ReturnBooksToolStripMenuItem
        '
        Me.ReturnBooksToolStripMenuItem.Name = "ReturnBooksToolStripMenuItem"
        Me.ReturnBooksToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReturnBooksToolStripMenuItem.Text = "Return Books"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSupplierToolStripMenuItem, Me.AddSubjectsClassWiseToolStripMenuItem, Me.FeeTypeToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.WindowToolStripMenuItem.Text = "Master"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AddSupplierToolStripMenuItem.Text = "Add Supplier"
        '
        'AddSubjectsClassWiseToolStripMenuItem
        '
        Me.AddSubjectsClassWiseToolStripMenuItem.Name = "AddSubjectsClassWiseToolStripMenuItem"
        Me.AddSubjectsClassWiseToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AddSubjectsClassWiseToolStripMenuItem.Text = "Add Subjects Class Wise"
        '
        'FeeTypeToolStripMenuItem
        '
        Me.FeeTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewToolStripMenuItem, Me.ModifyToolStripMenuItem})
        Me.FeeTypeToolStripMenuItem.Name = "FeeTypeToolStripMenuItem"
        Me.FeeTypeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FeeTypeToolStripMenuItem.Text = "Fee Type"
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CreateNewToolStripMenuItem.Text = "Create New Fee Type"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ModifyToolStripMenuItem.Text = "Modify Fee Type"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Mistral", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(278, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM"
        '
        'Timer1
        '
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "School  Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QueryEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetBooksIssueDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSubjectsClassWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedSalaryReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FineEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PromoteStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeDatabaseLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeeTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
