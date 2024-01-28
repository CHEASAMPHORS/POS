Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module DB
    Dim dt As New DataTable
    Public connectionString As String = "server=localhost;user=root;password=;database=pos"
    Public Function ExecuteSqlQuery(sqlQuery As String) As DataTable
        Dim dt As New DataTable()

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New MySqlCommand(sqlQuery, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using


            Catch ex As Exception
                MessageBox.Show("Error executing SQL query: " & ex.Message)
            End Try
        End Using

        Return dt
    End Function

End Module
