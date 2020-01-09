Imports System.Security.Cryptography

Public Class Metodos
    Public Sub Acceder()
        Login.Hide()
        MenuGestion.Show()
    End Sub

    Public Function MD5EncryptPass(ByVal StrPass As String)

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim contraEncriptada As String
        Dim i As Integer
        contraEncriptada = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            contraEncriptada &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return contraEncriptada
    End Function

    Public Sub pantallaCompleta()
        'Pantalla Login
        Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Login.WindowState = FormWindowState.Maximized

        'Pantalla Menu de Gestion
        MenuGestion.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MenuGestion.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Alojamientos
        GestionAlojamientos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        GestionAlojamientos.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Usuarios
        GestionUsuarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        GestionUsuarios.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub salir()
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
