Imports Mysql.Data.MySqlClient

Module Conexion
    Public conexion As MySqlConnection


    Public Sub conectar()
        Try
            conexion = New MySqlConnection("server=localhost; user=root; password=; database=tallerevaepe3")
            conexion.Open()
            'MsgBox("Conexion Exitosa")
        Catch ex As MySqlException
            MsgBox("Error de Conexion: " & ex.Message)
        End Try
    End Sub
End Module
