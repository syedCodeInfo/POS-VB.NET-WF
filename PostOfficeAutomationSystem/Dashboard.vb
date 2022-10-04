Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=DESKTOP-FIK5SPH;Initial Catalog=PostOffice;Integrated Security=True")
    Dim myCmd As SqlCommand

    Private Sub DashboardMenu_Click(sender As Object, e As EventArgs) Handles DashboardMenu.Click
        TotalPost()
        TotalSales()
        TotalMoneyOrder()
        TotalMoneySaving()
        Me.Show()
    End Sub

    Private Sub LogoutMenu_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        PostOffice.Show()
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

    Private Sub MSMenu_Click(sender As Object, e As EventArgs) Handles MSMenu.Click
        SaveMoney.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalPost()
        TotalSales()
        TotalMoneyOrder()
        TotalMoneySaving()
    End Sub
    Private Sub TotalPost()
        myCmd = con.CreateCommand
        myCmd.CommandText = "select count(*)as totalPost from Post"
        con.Open()
        Dim reader As SqlDataReader
        reader = myCmd.ExecuteReader
        Using reader
            With reader
                If .HasRows Then
                    'Read the 1st Record
                    reader.Read()
                    Label2.Text = reader.Item("totalPost").ToString()
                End If

            End With

        End Using
    End Sub
    Private Sub TotalSales()
        myCmd = con.CreateCommand
        myCmd.CommandText = "select count(*)as totalSales from tbl_sales"

        Dim reader As SqlDataReader
        reader = myCmd.ExecuteReader
        Using reader
            With reader
                If .HasRows Then
                    'Read the 1st Record
                    reader.Read()
                    Label3.Text = reader.Item("totalSales").ToString()




                End If

            End With

        End Using
    End Sub

    Private Sub TotalMoneySaving()
        myCmd = con.CreateCommand
        myCmd.CommandText = "select count(*)as totalMoney from tbl_saveMoney"

        Dim reader As SqlDataReader
        reader = myCmd.ExecuteReader
        Using reader
            With reader
                If .HasRows Then
                    'Read the 1st Record
                    reader.Read()
                    Label5.Text = reader.Item("totalMoney").ToString()




                End If

            End With

        End Using
    End Sub
    Private Sub TotalMoneyOrder()
        myCmd = con.CreateCommand
        myCmd.CommandText = "select count(*)as MOrder from MoneyOrder"

        Dim reader As SqlDataReader
        reader = myCmd.ExecuteReader
        Using reader
            With reader
                If .HasRows Then
                    'Read the 1st Record
                    reader.Read()
                    Label7.Text = reader.Item("MOrder").ToString()




                End If

            End With

        End Using
    End Sub
End Class