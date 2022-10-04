Imports System.Data.SqlClient
Public Class Post
    Dim con As New SqlConnection("Data Source=DESKTOP-FIK5SPH;Initial Catalog=PostOffice;Integrated Security=True")
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem = "Speed") Then
            SpeedPost.Show()
            Me.Hide()
        ElseIf (ComboBox1.SelectedItem = "Normal") Then
            NormalPost.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Post_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim command As New SqlCommand("select * from Post ", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        sda.Fill(dt)
        SalesGrid.DataSource = dt
    End Sub

    Private Sub MoneySaveMenu_Click(sender As Object, e As EventArgs) Handles MoneySaveMenu.Click
        SaveMoney.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MoneyOrder.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardMenu_Click(sender As Object, e As EventArgs) Handles DashboardMenu.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub SalesMenu_Click(sender As Object, e As EventArgs) Handles SalesMenu.Click
        Sales.Show()
        Me.Hide()
    End Sub

    Private Sub MyPostMenu_Click(sender As Object, e As EventArgs) Handles MyPostMenu.Click

        Me.Show()
    End Sub

    Private Sub LogoutMenu_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        PostOffice.Show()
        Me.Hide()
    End Sub
End Class