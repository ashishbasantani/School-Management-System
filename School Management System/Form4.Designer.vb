<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Recno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Scode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Transdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Remark = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Feetype = New System.Windows.Forms.ComboBox()
        Me.SMSDataSet = New School_Management_System.SMSDataSet()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Report = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No. :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 737)
        Me.Panel1.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(120, 520)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 76)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Y"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(120, 430)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 76)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "R"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(120, 340)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 76)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "T"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(120, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 76)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "N"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(120, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 76)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "E"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(20, 340)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 76)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "S"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(20, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 76)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "E"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(20, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 76)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "E"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(20, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 76)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "F"
        '
        'Recno
        '
        Me.Recno.Enabled = False
        Me.Recno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recno.Location = New System.Drawing.Point(507, 186)
        Me.Recno.Name = "Recno"
        Me.Recno.Size = New System.Drawing.Size(160, 26)
        Me.Recno.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "S_Code :"
        '
        'Scode
        '
        Me.Scode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scode.Location = New System.Drawing.Point(507, 230)
        Me.Scode.Name = "Scode"
        Me.Scode.Size = New System.Drawing.Size(171, 26)
        Me.Scode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(878, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date :"
        '
        'Transdate
        '
        Me.Transdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transdate.Location = New System.Drawing.Point(882, 326)
        Me.Transdate.Name = "Transdate"
        Me.Transdate.Size = New System.Drawing.Size(303, 26)
        Me.Transdate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Student Name :"
        '
        'Name1
        '
        Me.Name1.Enabled = False
        Me.Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(507, 276)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(258, 26)
        Me.Name1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount :"
        '
        'Amount
        '
        Me.Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount.Location = New System.Drawing.Point(507, 343)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(152, 26)
        Me.Amount.TabIndex = 2
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(560, 577)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(96, 33)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(846, 577)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(96, 33)
        Me.Reset.TabIndex = 6
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Handwriting", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(416, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(710, 83)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Student Fees Entry"
        Me.Label6.UseMnemonic = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1167, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(331, 415)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 24)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Remark"
        '
        'Remark
        '
        Me.Remark.Location = New System.Drawing.Point(507, 420)
        Me.Remark.Multiline = True
        Me.Remark.Name = "Remark"
        Me.Remark.Size = New System.Drawing.Size(221, 89)
        Me.Remark.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(897, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 24)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Fees Type"
        '
        'Feetype
        '
        Me.Feetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Feetype.FormattingEnabled = True
        Me.Feetype.Location = New System.Drawing.Point(1044, 190)
        Me.Feetype.Name = "Feetype"
        Me.Feetype.Size = New System.Drawing.Size(162, 21)
        Me.Feetype.TabIndex = 1
        '
        'SMSDataSet
        '
        Me.SMSDataSet.DataSetName = "SMSDataSet"
        Me.SMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1212, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Label19"
        '
        'Report
        '
        Me.Report.Location = New System.Drawing.Point(1275, 113)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(75, 23)
        Me.Report.TabIndex = 19
        Me.Report.Text = "Print Report"
        Me.Report.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Feetype)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Remark)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Transdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Scode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Recno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Fees Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Recno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Scode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Transdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Amount As System.Windows.Forms.TextBox
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Remark As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Feetype As System.Windows.Forms.ComboBox
    Friend WithEvents SMSDataSet As School_Management_System.SMSDataSet
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Report As System.Windows.Forms.Button
End Class
