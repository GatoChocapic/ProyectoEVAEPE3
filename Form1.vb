Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    ' Opcional: mantener la cadena de conexión en app.config y leerla con ConfigurationManager.
    Private ReadOnly ConnectionString As String = "server=localhost; user=root; password=; database=tallerevaepe3"

    Private Sub btIniciar_Click(sender As Object, e As EventArgs) Handles btIniciar.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        Try
            ' Usar Using para garantizar cierre y liberación de recursos
            Using conexion As New MySqlConnection(ConnectionString)
                conexion.Open()

                ' Seleccionar solo la columna que se necesita
                Dim sql As String = "SELECT `Tipo`, `Contraseña` FROM `usuarios` WHERE `Correo` = @correo LIMIT 1"
                Using comando As New MySqlCommand(sql, conexion)
                    comando.Parameters.Add("@correo", MySqlDbType.VarChar).Value = txtUsuario.Text.Trim()

                    Using lector As MySqlDataReader = comando.ExecuteReader()
                        If lector.Read() Then
                            ' Si guardas contraseñas en texto plano (no recomendable), compara directamente.
                            Dim passwordEnBd As String = If(lector("Contraseña") IsNot DBNull.Value, lector("Contraseña").ToString(), String.Empty)

                            ' Recomendación: comparar hashes. Aquí se muestra la comparación directa (temporal).
                            If passwordEnBd = txtPassword.Text Then
                                Dim tipoUsuario As String = If(lector("Tipo") IsNot DBNull.Value, lector("Tipo").ToString(), String.Empty)
                                MessageBox.Show("Inicio de sesión exitoso")

                                ' Abrir el formulario principal tras validar credenciales
                                Me.Hide()
                                Dim principal As New MainForm(tipoUsuario)
                                principal.Show()
                            Else
                                MessageBox.Show("Usuario o contraseña incorrectos")
                            End If
                        Else
                            MessageBox.Show("Usuario o contraseña incorrectos")
                        End If

                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error de base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
