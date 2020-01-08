Imports MySql.Data.MySqlClient

Public Class Conexion
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=retoaloj; Pwd=elchapas23")

    Public Sub Conectar()
        ':::Utilizamos el try para capturar posibles errores
        Try
            ':::Abrimos la conexión
            conex.Open()
            ':::Si se estableció conexión correctamente dirá "Conectado"
            MsgBox("Conectado")
        Catch ex As Exception
            ':::Si no se conecta nos mostrara el posible fallo en la conexión
            MsgBox("No se pudo conectar a la BD por: " & ex.Message)
            Application.ExitThread()
        End Try
    End Sub
End Class
