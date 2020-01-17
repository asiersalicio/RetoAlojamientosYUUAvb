﻿Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddUsuario
    Dim m As New Metodos
    Dim usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection
    Dim da, daInsert, daTipoUsuario As MySqlDataAdapter
    Private Sub AddUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        m.cargarTipos("usuario", "tipoUsuario", cbTipoUsuario)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.limpiarCampos(gbLogin)
        m.limpiarCampos(gbDatosUsuario)

        Me.Hide()

        GestionUsuarios.Show()
    End Sub
End Class