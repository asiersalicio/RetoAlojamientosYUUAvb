Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class Conexion
    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("Usuario")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("Password")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")


    Public Sub Conectar()
        Try
            conex.Open()
            MsgBox("Conexión establecida con éxito")
        Catch ex As Exception
            MsgBox("¡Error! No pudo establecerse la conexión a la base de datos." & vbLf & ex.Message)
            Application.ExitThread()
        End Try
    End Sub
End Class
