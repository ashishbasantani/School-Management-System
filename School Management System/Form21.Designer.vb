<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form21))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Oldpass = New System.Windows.Forms.TextBox()
        Me.Newpass = New System.Windows.Forms.TextBox()
        Me.Confirmpass = New System.Windows.Forms.TextBox()
        Me.Changepass = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(201, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(295, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "                                                                                 " & _
            "                        "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Old Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirm Password"
        '
        'Oldpass
        '
        Me.Oldpass.Location = New System.Drawing.Point(173, 127)
        Me.Oldpass.Name = "Oldpass"
        Me.Oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9830)
        Me.Oldpass.Size = New System.Drawing.Size(149, 20)
        Me.Oldpass.TabIndex = 0
        '
        'Newpass
        '
        Me.Newpass.Location = New System.Drawing.Point(173, 187)
        Me.Newpass.Name = "Newpass"
        Me.Newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9830)
        Me.Newpass.Size = New System.Drawing.Size(149, 20)
        Me.Newpass.TabIndex = 1
        '
        'Confirmpass
        '
        Me.Confirmpass.Location = New System.Drawing.Point(173, 247)
        Me.Confirmpass.Name = "Confirmpass"
        Me.Confirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9830)
        Me.Confirmpass.Size = New System.Drawing.Size(149, 20)
        Me.Confirmpass.TabIndex = 2
        '
        'Changepass
        '
        Me.Changepass.Location = New System.Drawing.Point(209, 293)
        Me.Changepass.Name = "Changepass"
        Me.Changepass.Size = New System.Drawing.Size(88, 41)
        Me.Changepass.TabIndex = 3
        Me.Changepass.Text = "Change Password"
        Me.Changepass.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(404, 293)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 41)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(373, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Changepass)
        Me.Controls.Add(Me.Confirmpass)
        Me.Controls.Add(Me.Newpass)
        Me.Controls.Add(Me.Oldpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form21"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Oldpass As System.Windows.Forms.TextBox
    Friend WithEvents Newpass As System.Windows.Forms.TextBox
    Friend WithEvents Confirmpass As System.Windows.Forms.TextBox
    Friend WithEvents Changepass As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
