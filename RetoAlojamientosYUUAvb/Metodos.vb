Imports System.Configuration
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Metodos
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")
    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("Usuario")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("Password")

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
        bytValue = Text.Encoding.UTF8.GetBytes(StrPass)
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            contraEncriptada &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return contraEncriptada
    End Function

    Public Sub cargarTiposAloj()
        Dim query As New MySqlDataAdapter("SELECT DISTINCT lodgingtype 'Tipo alojamiento' " &
                                          "FROM talojamientos ORDER BY lodgingtype ASC", conex)
        Dim campoTexto As New DataTable()
        query.Fill(campoTexto)

        Dim numero As Integer = campoTexto.Rows.Count
        For p = 0 To campoTexto.Rows.Count - 1
            GestionAlojamientos.cbTiposAloj.Items.Add(campoTexto.Rows(p).Item(0))
        Next
    End Sub

    Public Sub cargarDatosAloj(tabla As String, campo As String, item As ComboBox)
        Dim query As New MySqlDataAdapter("SELECT DISTINCT " & campo &
                                          " FROM talojamientos aloj, tlocalizacion loc, " & tabla &
                                          " WHERE aloj.localizacion_idLocalizacion=loc.idLocalizacion AND  loc." & campo & "code=" & tabla & "." & campo & "code " &
                                          "ORDER BY " & campo & " ASC", conex)

        Dim campoTexto As New DataTable()
        query.Fill(campoTexto)

        Dim numero As Integer = campoTexto.Rows.Count
        For p = 0 To campoTexto.Rows.Count - 1
            item.Items.Add(campoTexto.Rows(p).Item(0))
        Next
    End Sub

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

    Public Sub limpiarBusqueda()
        GestionAlojamientos.tbBusqueda.Clear()
        GestionUsuarios.tbBusqueda.Clear()
    End Sub

End Class