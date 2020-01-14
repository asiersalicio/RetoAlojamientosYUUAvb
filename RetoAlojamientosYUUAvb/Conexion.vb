Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class Conexion
    Dim usuarioBBDD As String = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
    Dim passwordBBDD As String = ConfigurationManager.AppSettings.Get("PasswordBBDD")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

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
