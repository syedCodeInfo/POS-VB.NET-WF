<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostOffice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.oo = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 220)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email Address"
        '
        'UserName
        '
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(431, 213)
        Me.UserName.Margin = New System.Windows.Forms.Padding(4)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(344, 38)
        Me.UserName.TabIndex = 1
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(431, 317)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(344, 38)
        Me.Password.TabIndex = 3
        Me.Password.UseSystemPasswordChar = True
        '
        'oo
        '
        Me.oo.AutoSize = True
        Me.oo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oo.Location = New System.Drawing.Point(208, 317)
        Me.oo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.oo.Name = "oo"
        Me.oo.Size = New System.Drawing.Size(142, 31)
        Me.oo.TabIndex = 2
        Me.oo.Text = "Password"
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoginBtn.Location = New System.Drawing.Point(330, 471)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(362, 78)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(257, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Post Office Automation System"
        '
        'PostOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1150, 715)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.oo)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PostOffice"
        Me.Text = "PostOffice Automation System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents oo As System.Windows.Forms.Label
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
End Class
