Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btIniciar.Click



        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If



        Try


            'Cadena de conexión a la bd
            conexion = New MySqlConnection("server=localhost; user=root; password=; database=tallerevaepe3")
            conexion.Open()

            ' Aquí puedes abrir el formulario principal y ocultar el login
            ' Me.Hide()
            ' Dim principal As New MainForm(tipoUsuario)
            ' principal.Show()

            'Consulta simple
            Dim sql As String = "SELECT * FROM usuarios WHERE Correo=@correo AND Contraseña=@clave"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@correo", txtUsuario.Text)
            comando.Parameters.AddWithValue("@clave", txtPassword.Text)

            lector = comando.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                Dim tipoUsuario As String = lector("Tipo").ToString()
                MessageBox.Show("Inicio de sesión exitoso")
                'Aquí puedes abrir el siguiente formulario o realizar otra acción
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If

            conexion.Close()



        Catch ex As Exception

            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)

        End Try
    End Sub
End Class
