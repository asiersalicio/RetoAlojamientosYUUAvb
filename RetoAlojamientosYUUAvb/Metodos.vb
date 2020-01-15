Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Metodos
    Dim usuarioBBDD As String = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
    Dim passwordBBDD As String = ConfigurationManager.AppSettings.Get("PasswordBBDD")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

    Public Sub Acceder()
        Login.Hide()
        MenuGestion.Show()
        Login.tbUsuario.Clear()
        Login.tbPassword.Clear()
    End Sub

    Public Sub desconectar()
        Dim resp = MsgBox("¿Desea cerrar la sesión actual?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención! Va a cerrar sesión")
        If resp = MsgBoxResult.Yes Then
            Try
                conex.Close()
                MenuGestion.Hide()
                Login.Show()
            Catch ex As Exception
                conex.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Function MD5EncryptPass(ByVal StrPass As String)
        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim txtEncriptado As String
        Dim i As Integer
        txtEncriptado = ""

        md5 = New MD5CryptoServiceProvider
        bytValue = Text.Encoding.UTF8.GetBytes(StrPass)
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            txtEncriptado &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return txtEncriptado
    End Function

    'Public Function DesencriptarMD5(ByVal StrPass As String) As String
    '    Return
    'End Function

    Public Sub cargarTipoUsuario()
        Dim query As New MySqlDataAdapter("SELECT DISTINCT tipoUsuario " &
                                          "FROM usuario ORDER BY tipoUsuario ASC", conex)
        Dim campoTexto As New DataTable()
        query.Fill(campoTexto)

        Dim numero As Integer = campoTexto.Rows.Count
        For i = 0 To campoTexto.Rows.Count - 1
            GestionUsuarios.cbTipoUsuario.Items.Add(campoTexto.Rows(i).Item(0))
        Next
    End Sub

    Public Sub cargarTiposAloj()
        Dim query As New MySqlDataAdapter("SELECT DISTINCT lodgingtype 'Tipo alojamiento' " &
                                          "FROM talojamientos ORDER BY lodgingtype ASC", conex)
        Dim campoTexto As New DataTable()
        query.Fill(campoTexto)

        Dim numero As Integer = campoTexto.Rows.Count
        For i = 0 To campoTexto.Rows.Count - 1
            GestionAlojamientos.cbTiposAloj.Items.Add(campoTexto.Rows(i).Item(0))
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
        For i = 0 To campoTexto.Rows.Count - 1
            item.Items.Add(campoTexto.Rows(i).Item(0))
        Next
    End Sub

    Public Sub pantallaCompleta()
        'Pantalla Login
        Login.FormBorderStyle = FormBorderStyle.None
        Login.WindowState = FormWindowState.Maximized

        'Pantalla Menu de Gestion
        MenuGestion.FormBorderStyle = FormBorderStyle.None
        MenuGestion.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Alojamientos
        GestionAlojamientos.FormBorderStyle = FormBorderStyle.None
        GestionAlojamientos.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Usuarios
        GestionUsuarios.FormBorderStyle = FormBorderStyle.None
        GestionUsuarios.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub salir()
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Try
                conex.Close()
                Application.Exit()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub limpiarBusqueda()
        GestionAlojamientos.tbBusqueda.Clear()
        GestionUsuarios.tbBusqueda.Clear()
    End Sub

End Class