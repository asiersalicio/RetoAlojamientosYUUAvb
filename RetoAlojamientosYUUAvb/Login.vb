﻿Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Login
    Dim m As New Metodos
    Dim usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection

    Dim cmdUsuario, cmdPassword As New MySqlCommand
    Dim daUsuario, daPassword As New MySqlDataAdapter
    Dim dsUsuario, dsPassword As New DataSet

    'Private Sub TbUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUsuario.KeyDown, tbPassword.KeyDown, btnAcceder.KeyDown
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        e.Handled = TrueSendKeys.Send("{TAB}")
    '    End If
    'End Sub

    Dim passwordEncriptada, bbddUsuarioGet, bbddPasswordGet As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'm.pantallaCompleta()
        'Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        'Me.Size = Screen.PrimaryScreen.WorkingArea.Size

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles tbUsuario.KeyPress, tbPassword.KeyPress, btnAcceder.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
5:          e.Handled = True
6:          SendKeys.Send("{TAB}")
7:      End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        passwordEncriptada = m.MD5EncryptPass(tbPassword.Text)
        Try
            If (tbUsuario.Text = "") Then
                MsgBox("Debe introducir un nombre de usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            ElseIf (tbPassword.Text = "") Then
                MsgBox("Debe introducir una contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            Else
                usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
                passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
                conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
                dsUsuario.Clear()
                dsPassword.Clear()
                conex.Open()

                cmdUsuario = New MySqlCommand("SELECT nombreUsuario FROM usuario WHERE nombreUsuario='" & tbUsuario.Text & "' AND tipoUsuario='administrador'", conex)
                cmdPassword = New MySqlCommand("SELECT contrasena FROM usuario WHERE contrasena='" & passwordEncriptada & "' AND tipoUsuario='administrador'", conex)

                daUsuario = New MySqlDataAdapter(cmdUsuario)
                daPassword = New MySqlDataAdapter(cmdPassword)

                daUsuario.Fill(dsUsuario, "usuario")
                daPassword.Fill(dsPassword, "contrasena")
                Try
                    bbddUsuarioGet = dsUsuario.Tables(0).Rows(0).Item(0)
                    bbddPasswordGet = dsPassword.Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    conex.Close()
                    MsgBox("Los datos introducidos no son correctos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "¡Atención!")
                End Try

                If (tbUsuario.Text <> bbddUsuarioGet And passwordEncriptada <> bbddPasswordGet) Then
                    MsgBox("Los datos introducidos no son correctos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "¡Atención!")
                ElseIf (tbUsuario.Text = bbddUsuarioGet And passwordEncriptada = bbddPasswordGet) Then
                    m.Acceder()
                End If
            End If
        Catch ex As Exception
            conex.Close()
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try
    End Sub
End Class