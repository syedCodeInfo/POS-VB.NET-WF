<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaveMoney
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saveMoneyname = New System.Windows.Forms.TextBox()
        Me.ItemType = New System.Windows.Forms.Label()
        Me.MOBtn = New System.Windows.Forms.Button()
        Me.MSGrid = New System.Windows.Forms.DataGridView()
        Me.DashboardMenu = New System.Windows.Forms.Button()
        Me.MOMenu = New System.Windows.Forms.Panel()
        Me.LogoutMenu = New System.Windows.Forms.Button()
        Me.MoneySaveMenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PostMenu = New System.Windows.Forms.Button()
        Me.SalesMenu = New System.Windows.Forms.Button()
        CType(Me.MSGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MOMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(463, 93)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(462, 34)
        Me.amount.TabIndex = 84
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 29)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Amount"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(463, 218)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(462, 34)
        Me.phone.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Phone Number"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(463, 160)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(462, 34)
        Me.email.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 29)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Email Address"
        '
        'saveMoneyname
        '
        Me.saveMoneyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveMoneyname.Location = New System.Drawing.Point(463, 33)
        Me.saveMoneyname.Name = "saveMoneyname"
        Me.saveMoneyname.Size = New System.Drawing.Size(462, 34)
        Me.saveMoneyname.TabIndex = 60
        '
        'ItemType
        '
        Me.ItemType.AutoSize = True
        Me.ItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemType.Location = New System.Drawing.Point(300, 33)
        Me.ItemType.Name = "ItemType"
        Me.ItemType.Size = New System.Drawing.Size(78, 29)
        Me.ItemType.TabIndex = 59
        Me.ItemType.Text = "Name"
        '
        'MOBtn
        '
        Me.MOBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.MOBtn.Location = New System.Drawing.Point(549, 271)
        Me.MOBtn.Name = "MOBtn"
        Me.MOBtn.Size = New System.Drawing.Size(232, 70)
        Me.MOBtn.TabIndex = 58
        Me.MOBtn.Text = "Save Money"
        Me.MOBtn.UseVisualStyleBackColor = False
        '
        'MSGrid
        '
        Me.MSGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MSGrid.Location = New System.Drawing.Point(236, 377)
        Me.MSGrid.Name = "MSGrid"
        Me.MSGrid.RowHeadersWidth = 51
        Me.MSGrid.RowTemplate.Height = 24
        Me.MSGrid.Size = New System.Drawing.Size(715, 326)
        Me.MSGrid.TabIndex = 85
        '
        'DashboardMenu
        '
        Me.DashboardMenu.BackColor = System.Drawing.Color.Lavender
        Me.DashboardMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardMenu.Location = New System.Drawing.Point(13, 17)
        Me.DashboardMenu.Name = "DashboardMenu"
        Me.DashboardMenu.Size = New System.Drawing.Size(176, 59)
        Me.DashboardMenu.TabIndex = 0
        Me.DashboardMenu.Text = "Dashboard"
        Me.DashboardMenu.UseVisualStyleBackColor = False
        '
        'MOMenu
        '
        Me.MOMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.MOMenu.Controls.Add(Me.LogoutMenu)
        Me.MOMenu.Controls.Add(Me.MoneySaveMenu)
        Me.MOMenu.Controls.Add(Me.Button1)
        Me.MOMenu.Controls.Add(Me.PostMenu)
        Me.MOMenu.Controls.Add(Me.SalesMenu)
        Me.MOMenu.Controls.Add(Me.DashboardMenu)
        Me.MOMenu.Location = New System.Drawing.Point(12, 1)
        Me.MOMenu.Name = "MOMenu"
        Me.MOMenu.Size = New System.Drawing.Size(218, 691)
        Me.MOMenu.TabIndex = 86
        '
        'LogoutMenu
        '
        Me.LogoutMenu.BackColor = System.Drawing.Color.Lavender
        Me.LogoutMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutMenu.Location = New System.Drawing.Point(13, 563)
        Me.LogoutMenu.Name = "LogoutMenu"
        Me.LogoutMenu.Size = New System.Drawing.Size(176, 59)
        Me.LogoutMenu.TabIndex = 5
        Me.LogoutMenu.Text = "Logout"
        Me.LogoutMenu.UseVisualStyleBackColor = False
        '
        'MoneySaveMenu
        '
        Me.MoneySaveMenu.BackColor = System.Drawing.Color.Lavender
        Me.MoneySaveMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneySaveMenu.Location = New System.Drawing.Point(13, 455)
        Me.MoneySaveMenu.Name = "MoneySaveMenu"
        Me.MoneySaveMenu.Size = New System.Drawing.Size(176, 59)
        Me.MoneySaveMenu.TabIndex = 4
        Me.MoneySaveMenu.Text = "Money Save"
        Me.MoneySaveMenu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Money Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PostMenu
        '
        Me.PostMenu.BackColor = System.Drawing.Color.Lavender
        Me.PostMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostMenu.Location = New System.Drawing.Point(13, 247)
        Me.PostMenu.Name = "PostMenu"
        Me.PostMenu.Size = New System.Drawing.Size(176, 59)
        Me.PostMenu.TabIndex = 2
        Me.PostMenu.Text = "Post"
        Me.PostMenu.UseVisualStyleBackColor = False
        '
        'SalesMenu
        '
        Me.SalesMenu.BackColor = System.Drawing.Color.Lavender
        Me.SalesMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesMenu.Location = New System.Drawing.Point(13, 132)
        Me.SalesMenu.Name = "SalesMenu"
        Me.SalesMenu.Size = New System.Drawing.Size(176, 59)
        Me.SalesMenu.TabIndex = 1
        Me.SalesMenu.Text = "Sales"
        Me.SalesMenu.UseVisualStyleBackColor = False
        '
        'SaveMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(985, 715)
        Me.Controls.Add(Me.MOMenu)
        Me.Controls.Add(Me.MSGrid)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.saveMoneyname)
        Me.Controls.Add(Me.ItemType)
        Me.Controls.Add(Me.MOBtn)
        Me.Name = "SaveMoney"
        Me.Text = "Money"
        CType(Me.MSGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MOMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents amount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents saveMoneyname As TextBox
    Friend WithEvents ItemType As Label
    Friend WithEvents MOBtn As Button
    Friend WithEvents MSGrid As DataGridView
    Friend WithEvents DashboardMenu As Button
    Friend WithEvents MOMenu As Panel
    Friend WithEvents LogoutMenu As Button
    Friend WithEvents MoneySaveMenu As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PostMenu As Button
    Friend WithEvents SalesMenu As Button
End Class
