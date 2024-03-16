Imports MySql.Data.MySqlClient

Public Class User
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
   String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If


        Dim connectionString As String = "Server=localhost;Database=info_registration;User Id=root;Password=archie_02;"
        Dim connection As New MySqlConnection(connectionString)

        Dim query As String = "SELECT * FROM Registrants WHERE Username = @Username AND Password = @Password"
        Dim command As New MySqlCommand(query, connection)


        command.Parameters.AddWithValue("@Username", txtUsername.Text)
        command.Parameters.AddWithValue("@Password", txtPassword.Text)

        connection.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login successful!")
        Else
            MessageBox.Show("Invalid credentials. Please try again.")
        End If
    End Sub
End Class