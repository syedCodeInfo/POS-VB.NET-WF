Imports System.Data.SqlClient
Public Class SaveMoney
    Dim con As New SqlConnection("Data Source=DESKTOP-FIK5SPH;Initial Catalog=PostOffice;Integrated Security=True")
    Private Sub MOBtn_Click(sender As Object, e As EventArgs) Handles MOBtn.Click
        Dim sName As String = saveMoneyname.Text
        Dim semail As String = email.Text
        Dim sphone As String = phone.Text
        Dim samount As String = amount.Text
        con.Open()
        Dim dateTime As DateTime = DateTime.Now
        Dim Response As Integer
        Dim dbCommand As New SqlCommand("select * from tbl_saveMoney where email='" & semail & "'", con)
        Dim outResponse As Integer = 0
        Dim myAmount As Integer
        Dim reader As SqlDataReader
        reader = dbCommand.ExecuteReader
        Using reader
            With reader
                If .HasRows Then
                    'Read the 1st Record
                    reader.Read()
                    myAmount = reader.Item("amount").ToString()

                    outResponse = 1


                Else
                    outResponse = 0
                End If

            End With

        End Using

        If (outResponse = 0) Then

            Dim cmd3 As SqlCommand = New SqlCommand("insert into tbl_saveMoney(Name,email,phone,amount,created_at) values" & "('" & sName & "','" + semail & "','" & sphone & "','" & samount & "','" & dateTime.ToString() & "')", con)
            cmd3.ExecuteNonQuery()
            MessageBox.Show("Successfully Added")
        ElseIf (outResponse = 1) Then
            Dim finalAmount As Integer = myAmount + Integer.Parse(samount)


            Dim cmd2 As SqlCommand = New SqlCommand("update tbl_saveMoney set amount= '" & finalAmount.ToString() & "' where email='" + semail & "'", con)
            cmd2.ExecuteNonQuery()

        End If


        con.Close()

        saveMoneyname.Text = ""
        email.Text = ""
        phone.Text = ""
        amount.Text = ""
        LoadGrid()
    End Sub

    Private Sub MoneySave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim command As New SqlCommand("Select * from tbl_saveMoney", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        sda.Fill(dt)
        MSGrid.DataSource = dt
    End Sub

    Private Sub DashboardMenu_Click(sender As Object, e As EventArgs) Handles DashboardMenu.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub SalesMenu_Click(sender As Object, e As EventArgs) Handles SalesMenu.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub PostMenu_Click(sender As Object, e As EventArgs) Handles PostMenu.Click
        Post.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MoneyOrder.Show()
        Me.Hide()

    End Sub

    Private Sub MoneySaveMenu_Click(sender As Object, e As EventArgs) Handles MoneySaveMenu.Click
        Me.Show()
    End Sub

    Private Sub LogoutMenu_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        PostOffice.Show()
        Me.Hide()
    End Sub
End Class