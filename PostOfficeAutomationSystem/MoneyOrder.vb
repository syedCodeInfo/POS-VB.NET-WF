Imports System.Data.SqlClient
Public Class MoneyOrder
    Dim con As New SqlConnection("Data Source=DESKTOP-FIK5SPH;Initial Catalog=PostOffice;Integrated Security=True")
    Private Sub MOBtn_Click(sender As Object, e As EventArgs) Handles MOBtn.Click
        Dim sName As String = SSenderName.Text
        Dim rName As String = SReceiverName.Text
        Dim sSAddress As String = SSenderAddress.Text
        Dim rAddress As String = SReceiverAddress.Text
        Dim sPhone As String = SSenderPhone.Text
        Dim rPhone As String = Saddress.Text
        Dim sSstate As String = sstate.Text
        Dim state As String = srstate.Text
        Dim sSenderCity As String = sscity.Text
        Dim sReciverCity As String = srcity.Text
        Dim sSenderPinCode As String = sspin.Text
        Dim sReceiverPinCode As String = srpin.Text
        Dim Amount As String = SenderAmount.Text
        con.Open()
        Dim SCode As Char() = sName.ToCharArray()
        Dim RCode As Char() = rName.ToCharArray()
        Dim saddressID As String = sName(0) & "" & rName(0) & sPhone
        Dim raddressID As String = rName(0) & "" & sName(0) & rPhone
        Dim cmd As SqlCommand = New SqlCommand("insert into Addresses(AddressLine1,AddressLine2,AddressLine3,PhoneNumber,PinCode,City,State,mode) values" & "('" & saddressID & "','" + sName & "','" & sSAddress & "','" & sPhone & "','" & sSenderPinCode & "','" & sSenderCity & "','" & sSstate & "','Sender')", con)
        cmd.ExecuteNonQuery()
        Dim cmd1 As SqlCommand = New SqlCommand("insert into Addresses(AddressLine1,AddressLine2,AddressLine3,PhoneNumber,PinCode,City,State,mode) values" & "('" & raddressID & "','" & rName & "','" & rAddress & "','" & rPhone & "','" & sReceiverPinCode & "','" & sReciverCity & "','" & state & "','Receiver')", con)
        cmd1.ExecuteNonQuery()
        Dim dateTime As DateTime = DateTime.Now
        Dim cmd3 As SqlCommand = New SqlCommand("insert into MoneyOrder(SenderAddressId,ReceiverAddressId,Amount,CreatedAt) values" & "('" & saddressID & "','" + raddressID & "','" & Amount.ToString() & "','" & dateTime.ToString() & "')", con)
        cmd3.ExecuteNonQuery()
        MessageBox.Show("Successfully Added")

        LoadGrid()

    End Sub
    Private Sub LoadGrid()
        Dim command As New SqlCommand("Select * from MoneyOrder", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        sda.Fill(dt)
        MoGrid.DataSource = dt


    End Sub

    Private Sub MoneyOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class