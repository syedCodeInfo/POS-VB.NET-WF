Public Class PostOffice
    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        Dim email As String = UserName.Text
        Dim pwd As String = Password.Text

        If (email = "admin@gmail.com" And pwd = "admin") Then
            MessageBox.Show("Welcome Admin")
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password")
            UserName.Text = ""
            Password.Text = ""
        End If

    End Sub


End Class
