﻿Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Login
    Dim m As New Metodos
    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("UsuarioApp")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("PasswordApp")
    ''' <summary>
    ''' Usuario y Contraseña de la app
    ''' </summary>
    ''' 
    'Private usuario As String = "root"
    'Private password As String = "123"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'm.pantallaCompleta()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Try
            If (tbUsuario.Text = "") Then
                MsgBox("Debe introducir un nombre de usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            ElseIf (tbPassword.Text = "") Then
                MsgBox("Debe introducir una contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            Else
                Dim contraEncriptada As String = m.MD5EncryptPass(tbPassword.Text)
                Dim sPasswordEncriptada As String = m.MD5EncryptPass(sPassword)
                Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")
                Dim adapterUsuario As New MySqlCommand("SELECT nombreUsuario FROM usuario WHERE nombreUsuario=" & tbUsuario.Text & " AND tipoUsuario='administrador'", conex)
                Dim adapterPassword As New MySqlCommand("SELECT contrasena FROM usuario WHERE contrasena=" & contraEncriptada & " AND tipoUsuario='administrador'", conex)

                If (tbUsuario.Text = sUsuario And contraEncriptada = sPasswordEncriptada) Then
                    m.Acceder()
                Else
                    MsgBox("Los datos introducidos no son correctos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "¡Atención!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try
    End Sub
End Class