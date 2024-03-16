Public Class Admin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "adminacc" And txtPassword.Text = "adminpass" Then
            Equipments.Show()
        Else
            MessageBox.Show("Invalid Credentials.")
        End If

    End Sub
End Class