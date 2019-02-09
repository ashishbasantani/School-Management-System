<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Scode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.Sclass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Reason = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Close1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "S_Code"
        '
        'Scode
        '
        Me.Scode.Location = New System.Drawing.Point(118, 184)
        Me.Scode.Name = "Scode"
        Me.Scode.Size = New System.Drawing.Size(129, 20)
        Me.Scode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Name"
        '
        'Sname
        '
        Me.Sname.Enabled = False
        Me.Sname.Location = New System.Drawing.Point(118, 249)
        Me.Sname.Name = "Sname"
        Me.Sname.ReadOnly = True
        Me.Sname.Size = New System.Drawing.Size(153, 20)
        Me.Sname.TabIndex = 3
        '
        'Sclass
        '
        Me.Sclass.Enabled = False
        Me.Sclass.Location = New System.Drawing.Point(408, 184)
        Me.Sclass.Name = "Sclass"
        Me.Sclass.ReadOnly = True
        Me.Sclass.Size = New System.Drawing.Size(121, 20)
        Me.Sclass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Class"
        '
        'Date1
        '
        Me.Date1.Location = New System.Drawing.Point(528, 99)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(200, 20)
        Me.Date1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fine Amt."
        '
        'Amount
        '
        Me.Amount.Location = New System.Drawing.Point(118, 320)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(129, 20)
        Me.Amount.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Reason for Fine"
        '
        'Reason
        '
        Me.Reason.Location = New System.Drawing.Point(408, 253)
        Me.Reason.Multiline = True
        Me.Reason.Name = "Reason"
        Me.Reason.Size = New System.Drawing.Size(121, 98)
        Me.Reason.TabIndex = 3
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(231, 378)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 4
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(413, 378)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(75, 23)
        Me.Close1.TabIndex = 5
        Me.Close1.Text = "Close"
        Me.Close1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mistral", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(209, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 57)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Library Fine Entry"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Tomato
        Me.Label8.Location = New System.Drawing.Point(330, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(322, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "                                                                                 " & _
            "                        "
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Reason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sclass)
        Me.Controls.Add(Me.Sname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Scode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form18"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Scode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sname As System.Windows.Forms.TextBox
    Friend WithEvents Sclass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Reason As System.Windows.Forms.TextBox
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Close1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
