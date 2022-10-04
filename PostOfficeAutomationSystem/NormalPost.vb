Imports System.Data.SqlClient
Public Class NormalPost
    Dim con As New SqlConnection("Data Source=DESKTOP-FIK5SPH;Initial Catalog=PostOffice;Integrated Security=True")
    Private Sub PostBtn_Click(sender As Object, e As EventArgs) Handles PostBtn.Click
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
        Dim sWeightage As String = ssweightage.Text
        Dim sCommissionAmount As String = scomission.Text
        con.Open()
        Dim SCode As Char() = sName.ToCharArray()
        Dim RCode As Char() = rName.ToCharArray()
        Dim saddressID As String = sName(0) & "" & rName(0) & sPhone
        Dim raddressID As String = rName(0) & "" & sName(0) & rPhone
        Dim cmd As SqlCommand = New SqlCommand("insert into Addresses(AddressLine1,AddressLine2,AddressLine3,PhoneNumber,PinCode,City,State,mode) values" & "('" & saddressID & "','" + sName & "','" & sSAddress & "','" & sPhone & "','" & sSenderPinCode & "','" & sSenderCity & "','" & sSstate & "','Sender')", con)
        cmd.ExecuteNonQuery()
        Dim camount As Integer = Convert.ToInt32(sCommissionAmount)
        Dim totalAmount As Integer = 0
        totalAmount = camount
        Dim cmd1 As SqlCommand = New SqlCommand("insert into Addresses(AddressLine1,AddressLine2,AddressLine3,PhoneNumber,PinCode,City,State,mode) values" & "('" & raddressID & "','" & rName & "','" & rAddress & "','" & rPhone & "','" & sReceiverPinCode & "','" & sReciverCity & "','" & state & "','Receiver')", con)
        cmd1.ExecuteNonQuery()
        Dim dateTime As DateTime = DateTime.Now
        Dim cmd3 As SqlCommand = New SqlCommand("insert into Post(SenderAddressId,ReceiverAddressId,Acknowlegment,CommissionAmount,WeightAge,TotalAmount,ExtraAmount,CreatedAt,postType) values" & "('" & saddressID & "','" & raddressID & "','true','" & sCommissionAmount.ToString() & "','" & sWeightage & "','" & totalAmount.ToString() & "','0','" & dateTime.ToString() & "','Normal')", con)
        cmd3.ExecuteNonQuery()
        MessageBox.Show("Successfully Added")
        SSenderName.Text = ""
        SReceiverName.Text = ""
        SReceiverAddress.Text = ""
        Post.Show()
        Me.Hide()
    End Sub
End Class