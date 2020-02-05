Imports System.Configuration
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Metodos
    Dim server = ConfigurationManager.AppSettings.Get("Server")
    Dim database = ConfigurationManager.AppSettings.Get("Database")
    Dim usuarioBBDD As String = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
    Dim passwordBBDD As String = ConfigurationManager.AppSettings.Get("PasswordBBDD")
    Dim conex As New MySqlConnection("Server=" & server & "; Database=" & database & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

    Public Sub Acceder()
        MenuGestion.Show()
        Login.tbUsuario.Clear()
        Login.tbPassword.Clear()
        Login.Hide()
    End Sub

    Public Sub desconectar(c As Form)
        Dim resp = MsgBox("¿Desea cerrar la sesión actual?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención! Va a cerrar sesión")
        If resp = MsgBoxResult.Yes Then
            Try
                conex.Close()
                cambioVentana(c, Login)
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

    Public Sub cargarTiposUsuarioTxt(item As TextBox)
        Dim idDni = MD5EncryptPass(GestionUsuarios.tbDNI.Text)
        Dim ds = New DataSet
        Dim da = New MySqlDataAdapter
        Dim query As New MySqlCommand("SELECT tipoUsuario FROM usuarios WHERE idDni=" &
                                      idDni, conex)

        ds.Clear()
        da = New MySqlDataAdapter(query)
        'item.Text = da.Fill(ds, "tiposUsuario")
    End Sub

    Public Sub cargarTipos(tabla As String, campo As String, item As ComboBox)
        item.Items.Add("Elegir una opción")
        Dim query As New MySqlDataAdapter("SELECT DISTINCT " & campo &
                                          " FROM " & tabla &
                                          " ORDER BY " & campo & " ASC", conex)
        Dim campoTexto As New DataTable()
        query.Fill(campoTexto)

        Dim numero As Integer = campoTexto.Rows.Count
        For i = 0 To campoTexto.Rows.Count - 1
            item.Items.Add(campoTexto.Rows(i).Item(0))
        Next
        item.SelectedIndex = 0
    End Sub

    Public Sub cambioVentana(origen As Form, destino As Form)
        origen.Close()
        destino.Show()
    End Sub

    Public Sub borrarReg(tabla As String, campoBBDD As String, x As String, dgv As DataGridView)
        Dim resp = MsgBox("¿Desea realmente borrar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Dim cmd As MySqlCommand

        If resp = MsgBoxResult.Yes Then
            Try
                conex.Open()
                cmd = New MySqlCommand("DELETE FROM " & tabla &
                                              " WHERE " &
                                              campoBBDD & "= '" & x & "';", conex)
                cmd.ExecuteNonQuery()
                MsgBox("Se borrarron correctamente los datos de usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Éxito!")
                conex.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
            End Try
        End If
    End Sub

    Public Sub salir()
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Try
                conex.Close()
                Application.Exit()
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
                Application.Exit()
            End Try
        End If
    End Sub

    Public Sub limpiarBusqueda()
        GestionAlojamientos.tbBusqueda.Clear()
        GestionUsuarios.tbBusqueda.Clear()
    End Sub

    Public Sub limpiarCampos(gb As GroupBox)
        For Each control In gb.Controls
            If TypeOf control Is TextBox Then
                control.Clear
            ElseIf TypeOf control Is RichTextBox Then
                control.Clear
            ElseIf TypeOf control Is ComboBox Then
                'control.SelectIndex(0)
            End If
        Next
    End Sub

    Public Sub soloLectura(gb As GroupBox)
        For Each control In gb.Controls
            If TypeOf control Is TextBox Then
                control.ReadOnly = True
            ElseIf TypeOf control Is RichTextBox Then
                control.ReadOnly = True
            End If
        Next
    End Sub

    Sub soloLetras(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se pueden ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se pueden ingresar valores de tipo numérico", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
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

End Class