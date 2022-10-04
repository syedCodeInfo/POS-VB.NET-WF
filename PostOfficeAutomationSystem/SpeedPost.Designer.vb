<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedPost
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
        Me.PostBtn = New System.Windows.Forms.Button()
        Me.ItemType = New System.Windows.Forms.Label()
        Me.SSenderName = New System.Windows.Forms.TextBox()
        Me.SSenderAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SReceiverName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SReceiverAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SSenderPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sstate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sscity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sspin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Saddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.srstate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.srcity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.srpin = New System.Windows.Forms.TextBox()
        Me.sextra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ssweightage = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.scomission = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PostBtn
        '
        Me.PostBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PostBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.PostBtn.Location = New System.Drawing.Point(380, 633)
        Me.PostBtn.Name = "PostBtn"
        Me.PostBtn.Size = New System.Drawing.Size(232, 70)
        Me.PostBtn.TabIndex = 26
        Me.PostBtn.Text = "Add Speed Post"
        Me.PostBtn.UseVisualStyleBackColor = False
        '
        'ItemType
        '
        Me.ItemType.AutoSize = True
        Me.ItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemType.Location = New System.Drawing.Point(12, 31)
        Me.ItemType.Name = "ItemType"
        Me.ItemType.Size = New System.Drawing.Size(163, 29)
        Me.ItemType.TabIndex = 27
        Me.ItemType.Text = "Sender Name"
        '
        'SSenderName
        '
        Me.SSenderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderName.Location = New System.Drawing.Point(205, 31)
        Me.SSenderName.Name = "SSenderName"
        Me.SSenderName.Size = New System.Drawing.Size(218, 34)
        Me.SSenderName.TabIndex = 28
        '
        'SSenderAddress
        '
        Me.SSenderAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderAddress.Location = New System.Drawing.Point(205, 93)
        Me.SSenderAddress.Multiline = True
        Me.SSenderAddress.Name = "SSenderAddress"
        Me.SSenderAddress.Size = New System.Drawing.Size(218, 90)
        Me.SSenderAddress.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Reciever Name"
        '
        'SReceiverName
        '
        Me.SReceiverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SReceiverName.Location = New System.Drawing.Point(654, 34)
        Me.SReceiverName.Name = "SReceiverName"
        Me.SReceiverName.Size = New System.Drawing.Size(251, 34)
        Me.SReceiverName.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Address"
        '
        'SReceiverAddress
        '
        Me.SReceiverAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SReceiverAddress.Location = New System.Drawing.Point(654, 90)
        Me.SReceiverAddress.Multiline = True
        Me.SReceiverAddress.Name = "SReceiverAddress"
        Me.SReceiverAddress.Size = New System.Drawing.Size(251, 90)
        Me.SReceiverAddress.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Phone Number"
        '
        'SSenderPhone
        '
        Me.SSenderPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSenderPhone.Location = New System.Drawing.Point(205, 208)
        Me.SSenderPhone.Name = "SSenderPhone"
        Me.SSenderPhone.Size = New System.Drawing.Size(218, 34)
        Me.SSenderPhone.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "State"
        '
        'sstate
        '
        Me.sstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sstate.Location = New System.Drawing.Point(205, 272)
        Me.sstate.Name = "sstate"
        Me.sstate.Size = New System.Drawing.Size(218, 34)
        Me.sstate.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 29)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "City"
        '
        'sscity
        '
        Me.sscity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sscity.Location = New System.Drawing.Point(205, 352)
        Me.sscity.Name = "sscity"
        Me.sscity.Size = New System.Drawing.Size(218, 34)
        Me.sscity.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 432)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 29)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Pin Code"
        '
        'sspin
        '
        Me.sspin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sspin.Location = New System.Drawing.Point(205, 427)
        Me.sspin.Name = "sspin"
        Me.sspin.Size = New System.Drawing.Size(218, 34)
        Me.sspin.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(461, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 29)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Phone Number"
        '
        'Saddress
        '
        Me.Saddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saddress.Location = New System.Drawing.Point(654, 208)
        Me.Saddress.Name = "Saddress"
        Me.Saddress.Size = New System.Drawing.Size(251, 34)
        Me.Saddress.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(482, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 29)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "State"
        '
        'srstate
        '
        Me.srstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srstate.Location = New System.Drawing.Point(654, 272)
        Me.srstate.Name = "srstate"
        Me.srstate.Size = New System.Drawing.Size(251, 34)
        Me.srstate.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(491, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 29)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "City"
        '
        'srcity
        '
        Me.srcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srcity.Location = New System.Drawing.Point(654, 339)
        Me.srcity.Name = "srcity"
        Me.srcity.Size = New System.Drawing.Size(251, 34)
        Me.srcity.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 29)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Pin Code"
        '
        'srpin
        '
        Me.srpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srpin.Location = New System.Drawing.Point(654, 422)
        Me.srpin.Name = "srpin"
        Me.srpin.Size = New System.Drawing.Size(251, 34)
        Me.srpin.TabIndex = 50
        '
        'sextra
        '
        Me.sextra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sextra.Location = New System.Drawing.Point(654, 490)
        Me.sextra.Name = "sextra"
        Me.sextra.Size = New System.Drawing.Size(251, 34)
        Me.sextra.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(480, 495)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 29)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Extra Amount"
        '
        'ssweightage
        '
        Me.ssweightage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssweightage.Location = New System.Drawing.Point(205, 490)
        Me.ssweightage.Name = "ssweightage"
        Me.ssweightage.Size = New System.Drawing.Size(218, 34)
        Me.ssweightage.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 495)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 29)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Weightage"
        '
        'scomission
        '
        Me.scomission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scomission.Location = New System.Drawing.Point(252, 548)
        Me.scomission.Name = "scomission"
        Me.scomission.Size = New System.Drawing.Size(171, 34)
        Me.scomission.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 565)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(234, 29)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Commission Amount"
        '
        'SpeedPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(985, 715)
        Me.Controls.Add(Me.scomission)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.sextra)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ssweightage)
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
        Me.Controls.Add(Me.PostBtn)
        Me.Name = "SpeedPost"
        Me.Text = "Speed Post"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PostBtn As Button
    Friend WithEvents ItemType As Label
    Friend WithEvents SSenderName As TextBox
    Friend WithEvents SSenderAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SReceiverName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SReceiverAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SSenderPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sstate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents sscity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sspin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Saddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents srstate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents srcity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents srpin As TextBox
    Friend WithEvents sextra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ssweightage As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents scomission As TextBox
    Friend WithEvents Label14 As Label
End Class
