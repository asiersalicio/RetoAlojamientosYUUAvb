Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class Conexion
    Dim usuarioBBDD As String = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
    Dim passwordBBDD As String = ConfigurationManager.AppSettings.Get("PasswordBBDD")
    'Dim servidor As String = ConfigurationManager.AppSettings.Get("Servidor")
    Dim servidor As String = ConfigurationManager.AppSettings.Get("Servidor2")
    Dim baseDatos As String = ConfigurationManager.AppSettings.Get("BaseDatos")
    Dim conex As New MySqlConnection("Server=" & servidor & "; Database=" & baseDatos & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
    'Public modo As String = ""

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
