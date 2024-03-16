Imports MySql.Data.MySqlClient


Public Class Accounts
    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "server=localhost;user=root;password=archie_02;database=info_registration"
        Dim query As String = "SELECT * FROM Registrants"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class