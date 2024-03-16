Imports System.Text.RegularExpressions
Imports Mysqlx
Imports MySql.Data.MySqlClient

Public Class Register
    Dim connectionString As String = "Server=localhost;Database=info_registration;User ID=root;Password=archie_02;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub ClearRegistrationForm()
        txtName.Clear()
        txtPosition.Clear()
        txtClub.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
        String.IsNullOrWhiteSpace(txtPosition.Text) OrElse
        String.IsNullOrWhiteSpace(txtClub.Text) OrElse
        String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
        String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
        String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
        String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Validate name (no numbers allowed)
        If Regex.IsMatch(txtName.Text, "\d") Then
            MessageBox.Show("Invalid name.")
            Return
        End If

        ' Check if passwords match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter.")
            Return
        End If

        Try
            connection.Open()

            ' Insert new user into the "users" table
            Dim query As String = "INSERT INTO Registrants (Name, Position, Club, Email, Username, Password) VALUES (@name, @position, @club, @email, @username, @password)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@name", txtName.Text)
            command.Parameters.AddWithValue("@position", txtPosition.Text)
            command.Parameters.AddWithValue("@club", txtClub.Text)
            command.Parameters.AddWithValue("@email", txtClub.Text)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)

            command.ExecuteNonQuery()
            Message.Show()

            ' Clear form after successful registration
            ClearRegistrationForm()

        Catch ex As MySqlException
            ' Handle specific MySQL exception for duplicate entry
            If ex.Number = 1062 AndAlso ex.Message.ToLower().Contains("duplicate entry for key 'username'") Then
                MessageBox.Show("Error: Username already exists. Please choose a different username.")
            Else
                MessageBox.Show("MySQL Error: " & ex.Number & " - " & ex.Message)
            End If
        Finally
            connection.Close()
        End Try
    End Sub
End Class