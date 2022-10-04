<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Post
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
        Me.LogoutMenu = New System.Windows.Forms.Button()
        Me.MoneySaveMenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPostMenu = New System.Windows.Forms.Button()
        Me.SalesMenu = New System.Windows.Forms.Button()
        Me.DashboardMenu = New System.Windows.Forms.Button()
        Me.MOMenu = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ItemPrice = New System.Windows.Forms.Label()
        Me.SalesGrid = New System.Windows.Forms.DataGridView()
        Me.MOMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'MyPostMenu
        '
        Me.MyPostMenu.BackColor = System.Drawing.Color.Lavender
        Me.MyPostMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyPostMenu.Location = New System.Drawing.Point(13, 247)
        Me.MyPostMenu.Name = "MyPostMenu"
        Me.MyPostMenu.Size = New System.Drawing.Size(176, 59)
        Me.MyPostMenu.TabIndex = 2
        Me.MyPostMenu.Text = "Post"
        Me.MyPostMenu.UseVisualStyleBackColor = False
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
        Me.MOMenu.Controls.Add(Me.MyPostMenu)
        Me.MOMenu.Controls.Add(Me.SalesMenu)
        Me.MOMenu.Controls.Add(Me.DashboardMenu)
        Me.MOMenu.Location = New System.Drawing.Point(12, 12)
        Me.MOMenu.Name = "MOMenu"
        Me.MOMenu.Size = New System.Drawing.Size(218, 691)
        Me.MOMenu.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ItemPrice)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(236, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 210)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Post"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "Speed"})
        Me.ComboBox1.Location = New System.Drawing.Point(302, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 37)
        Me.ComboBox1.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(133, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 29)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Post Type"
        '
        'ItemPrice
        '
        Me.ItemPrice.AutoSize = True
        Me.ItemPrice.Location = New System.Drawing.Point(24, 145)
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(0, 29)
        Me.ItemPrice.TabIndex = 2
        '
        'SalesGrid
        '
        Me.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesGrid.Location = New System.Drawing.Point(236, 228)
        Me.SalesGrid.Name = "SalesGrid"
        Me.SalesGrid.RowHeadersWidth = 51
        Me.SalesGrid.RowTemplate.Height = 24
        Me.SalesGrid.Size = New System.Drawing.Size(727, 475)
        Me.SalesGrid.TabIndex = 4
        '
        'Post
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(985, 715)
        Me.Controls.Add(Me.SalesGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MOMenu)
        Me.Name = "Post"
        Me.Text = "Post"
        Me.MOMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutMenu As Button
    Friend WithEvents MoneySaveMenu As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MyPostMenu As Button
    Friend WithEvents SalesMenu As Button
    Friend WithEvents DashboardMenu As Button
    Friend WithEvents MOMenu As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ItemPrice As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SalesGrid As DataGridView
End Class
