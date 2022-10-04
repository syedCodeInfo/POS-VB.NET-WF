<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoneyOrder
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
        Me.SenderAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.srpin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.srcity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.srstate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Saddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sspin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sscity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sstate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SSenderPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SReceiverAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SReceiverName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SSenderAddress = New System.Windows.Forms.TextBox()
        Me.SSenderName = New System.Windows.Forms.TextBox()
        Me.ItemType = New System.Windows.Forms.Label()
        Me.MOBtn = New System.Windows.Forms.Button()
        Me.MoGrid = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.MoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SenderAmount
        '
        Me.SenderAmount.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SenderAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenderAmount.Location = New System.Drawing.Point(204, 506)
        Me.SenderAmount.Name = "SenderAmount"
        Me.SenderAmount.Size = New System.Drawing.Size(218, 34)
        Me.SenderAmount.TabIndex = 111
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 29)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Amount"
        '
        'srpin
        '
        Me.srpin.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.srpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srpin.Location = New System.Drawing.Point(653, 438)
        Me.srpin.Name = "srpin"
        Me.srpin.Size = New System.Drawing.Size(251, 34)
        Me.srpin.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(479, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 29)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Pin Code"
        '
        'srcity
        '
        Me.srcity.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.srcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srcity.Location = New System.Drawing.Point(653, 355)
        Me.srcity.Name = "srcity"
        Me.srcity.Size = New System.Drawing.Size(251, 34)
        Me.srcity.TabIndex = 107
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(490, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 29)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "City"
        '
        'srstate
        '
        Me.srstate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.srstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srstate.Location = New System.Drawing.Point(653, 288)
        Me.srstate.Name = "srstate"
        Me.srstate.Size = New System.Drawing.Size(251, 34)
        Me.srstate.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(481, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 29)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "State"
        '
        'Saddress
        '
        Me.Saddress.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Saddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saddress.Location = New System.Drawing.Point(653, 224)
        Me.Saddress.Name = "Saddress"
        Me.Saddress.Size = New System.Drawing.Size(251, 34)
        Me.Saddress.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(460, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 29)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Phone Number"
        '
        'sspin
        '
        Me.sspin.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.sspin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sspin.Location = New System.Drawing.Point(204, 443)
        Me.sspin.Name = "sspin"
        Me.sspin.Size = New System.Drawing.Size(218, 34)
        Me.sspin.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 29)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Pin Code"
        '
        'sscity
        '
        Me.sscity.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.sscity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sscity.Location = New System.Drawing.Point(204, 368)
        Me.sscity.Name = "sscity"
        Me.sscity.Size = New System.Drawing.Size(218, 34)
        Me.sscity.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 29)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "City"
        '
        'sstate
        '
        Me.sstate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.sstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstate.Location = New System.Drawing.Point(204, 288)
        Me.sstate.Name = "sstate"
        Me.sstate.Size = New System.Drawing.Size(218, 34)
        Me.sstate.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "State"
        '
        'SSenderPhone
        '
        Me.SSenderPhone.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SSenderPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderPhone.Location = New System.Drawing.Point(204, 224)
        Me.SSenderPhone.Name = "SSenderPhone"
        Me.SSenderPhone.Size = New System.Drawing.Size(218, 34)
        Me.SSenderPhone.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 29)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Address"
        '
        'SReceiverAddress
        '
        Me.SReceiverAddress.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SReceiverAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SReceiverAddress.Location = New System.Drawing.Point(653, 106)
        Me.SReceiverAddress.Multiline = True
        Me.SReceiverAddress.Name = "SReceiverAddress"
        Me.SReceiverAddress.Size = New System.Drawing.Size(251, 90)
        Me.SReceiverAddress.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Address"
        '
        'SReceiverName
        '
        Me.SReceiverName.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SReceiverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SReceiverName.Location = New System.Drawing.Point(653, 50)
        Me.SReceiverName.Name = "SReceiverName"
        Me.SReceiverName.Size = New System.Drawing.Size(251, 34)
        Me.SReceiverName.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Reciever Name"
        '
        'SSenderAddress
        '
        Me.SSenderAddress.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SSenderAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderAddress.Location = New System.Drawing.Point(204, 109)
        Me.SSenderAddress.Multiline = True
        Me.SSenderAddress.Name = "SSenderAddress"
        Me.SSenderAddress.Size = New System.Drawing.Size(218, 90)
        Me.SSenderAddress.TabIndex = 88
        '
        'SSenderName
        '
        Me.SSenderName.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SSenderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderName.Location = New System.Drawing.Point(204, 47)
        Me.SSenderName.Name = "SSenderName"
        Me.SSenderName.Size = New System.Drawing.Size(218, 34)
        Me.SSenderName.TabIndex = 87
        '
        'ItemType
        '
        Me.ItemType.AutoSize = True
        Me.ItemType.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemType.Location = New System.Drawing.Point(11, 47)
        Me.ItemType.Name = "ItemType"
        Me.ItemType.Size = New System.Drawing.Size(163, 29)
        Me.ItemType.TabIndex = 86
        Me.ItemType.Text = "Sender Name"
        '
        'MOBtn
        '
        Me.MOBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.MOBtn.Location = New System.Drawing.Point(392, 580)
        Me.MOBtn.Name = "MOBtn"
        Me.MOBtn.Size = New System.Drawing.Size(232, 70)
        Me.MOBtn.TabIndex = 85
        Me.MOBtn.Text = "Add MoneyOrder"
        Me.MOBtn.UseVisualStyleBackColor = False
        '
        'MoGrid
        '
        Me.MoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MoGrid.Location = New System.Drawing.Point(12, 671)
        Me.MoGrid.Name = "MoGrid"
        Me.MoGrid.RowHeadersWidth = 51
        Me.MoGrid.RowTemplate.Height = 24
        Me.MoGrid.Size = New System.Drawing.Size(980, 150)
        Me.MoGrid.TabIndex = 112
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(861, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 29)
        Me.LinkLabel1.TabIndex = 113
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Dashboard"
        '
        'MoneyOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1004, 833)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MoGrid)
        Me.Controls.Add(Me.SenderAmount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.srpin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.srcity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.srstate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Saddress)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.sspin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sscity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sstate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SSenderPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SReceiverAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SReceiverName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SSenderAddress)
        Me.Controls.Add(Me.SSenderName)
        Me.Controls.Add(Me.ItemType)
        Me.Controls.Add(Me.MOBtn)
        Me.Name = "MoneyOrder"
        Me.Text = "MoneyOrder"
        CType(Me.MoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SenderAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents srpin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents srcity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents srstate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Saddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sspin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sscity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents sstate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SSenderPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SReceiverAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SReceiverName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SSenderAddress As TextBox
    Friend WithEvents SSenderName As TextBox
    Friend WithEvents ItemType As Label
    Friend WithEvents MOBtn As Button
    Friend WithEvents MoGrid As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
