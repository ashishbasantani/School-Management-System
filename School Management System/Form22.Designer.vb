<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form22))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Currlocation = New System.Windows.Forms.TextBox()
        Me.Newlocation = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Close1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(285, -7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Database Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(396, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "                                                                                 " & _
            "                   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Currect Database Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Database Location"
        '
        'Currlocation
        '
        Me.Currlocation.Location = New System.Drawing.Point(166, 112)
        Me.Currlocation.Name = "Currlocation"
        Me.Currlocation.Size = New System.Drawing.Size(702, 20)
        Me.Currlocation.TabIndex = 0
        '
        'Newlocation
        '
        Me.Newlocation.Location = New System.Drawing.Point(166, 180)
        Me.Newlocation.Name = "Newlocation"
        Me.Newlocation.Size = New System.Drawing.Size(702, 20)
        Me.Newlocation.TabIndex = 1
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(241, 265)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 2
        Me.Submit.Text = "Change"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(555, 265)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(75, 23)
        Me.Close1.TabIndex = 3
        Me.Close1.Text = "Close"
        Me.Close1.UseVisualStyleBackColor = True
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Newlocation)
        Me.Controls.Add(Me.Currlocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form22"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Currlocation As System.Windows.Forms.TextBox
    Friend WithEvents Newlocation As System.Windows.Forms.TextBox
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Close1 As System.Windows.Forms.Button
End Class
