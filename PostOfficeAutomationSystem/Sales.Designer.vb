<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Me.LogoutMenu = New System.Windows.Forms.Button()
        Me.MSMenu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PostMenu = New System.Windows.Forms.Button()
        Me.SalesMenu = New System.Windows.Forms.Button()
        Me.DashboardMenu = New System.Windows.Forms.Button()
        Me.MOMenu = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sprice = New System.Windows.Forms.TextBox()
        Me.stype = New System.Windows.Forms.TextBox()
        Me.ItemPrice = New System.Windows.Forms.Label()
        Me.ItemType = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.salesGrid = New System.Windows.Forms.DataGridView()
        Me.MOMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.salesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.Color.Lavender
        Me.MSMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSMenu.Location = New System.Drawing.Point(13, 455)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(176, 59)
        Me.MSMenu.TabIndex = 4
        Me.MSMenu.Text = "Money Save"
        Me.MSMenu.UseVisualStyleBackColor = False
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
        Me.MOMenu.Controls.Add(Me.MSMenu)
        Me.MOMenu.Controls.Add(Me.Button1)
        Me.MOMenu.Controls.Add(Me.PostMenu)
        Me.MOMenu.Controls.Add(Me.SalesMenu)
        Me.MOMenu.Controls.Add(Me.DashboardMenu)
        Me.MOMenu.Location = New System.Drawing.Point(12, 12)
        Me.MOMenu.Name = "MOMenu"
        Me.MOMenu.Size = New System.Drawing.Size(218, 691)
        Me.MOMenu.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.sprice)
        Me.GroupBox1.Controls.Add(Me.stype)
        Me.GroupBox1.Controls.Add(Me.ItemPrice)
        Me.GroupBox1.Controls.Add(Me.ItemType)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(252, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 323)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Sales Item"
        '
        'sprice
        '
        Me.sprice.Location = New System.Drawing.Point(275, 145)
        Me.sprice.Name = "sprice"
        Me.sprice.Size = New System.Drawing.Size(300, 34)
        Me.sprice.TabIndex = 4
        '
        'stype
        '
        Me.stype.Location = New System.Drawing.Point(275, 72)
        Me.stype.Name = "stype"
        Me.stype.Size = New System.Drawing.Size(300, 34)
        Me.stype.TabIndex = 3
        '
        'ItemPrice
        '
        Me.ItemPrice.AutoSize = True
        Me.ItemPrice.Location = New System.Drawing.Point(85, 145)
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(115, 29)
        Me.ItemPrice.TabIndex = 2
        Me.ItemPrice.Text = "ItemPrice"
        '
        'ItemType
        '
        Me.ItemType.AutoSize = True
        Me.ItemType.Location = New System.Drawing.Point(80, 72)
        Me.ItemType.Name = "ItemType"
        Me.ItemType.Size = New System.Drawing.Size(120, 29)
        Me.ItemType.TabIndex = 1
        Me.ItemType.Text = "Item Type"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(343, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 70)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Add Product"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'salesGrid
        '
        Me.salesGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salesGrid.Location = New System.Drawing.Point(252, 376)
        Me.salesGrid.Name = "salesGrid"
        Me.salesGrid.RowHeadersWidth = 51
        Me.salesGrid.RowTemplate.Height = 24
        Me.salesGrid.Size = New System.Drawing.Size(708, 327)
        Me.salesGrid.TabIndex = 3
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(985, 715)
        Me.Controls.Add(Me.salesGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MOMenu)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.MOMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.salesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutMenu As Button
    Friend WithEvents MSMenu As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PostMenu As Button
    Friend WithEvents SalesMenu As Button
    Friend WithEvents DashboardMenu As Button
    Friend WithEvents MOMenu As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sprice As TextBox
    Friend WithEvents stype As TextBox
    Friend WithEvents ItemPrice As Label
    Friend WithEvents ItemType As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents salesGrid As DataGridView
End Class
