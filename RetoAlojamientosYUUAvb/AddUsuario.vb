﻿Imports System.Configuration
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AddUsuario
    Dim m As New Metodos
    Dim database, server, usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection
    Dim cmd As MySqlCommand
    Public modo As String
    Private Sub AddUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        server = ConfigurationManager.AppSettings.Get("Server")
        database = ConfigurationManager.AppSettings.Get("Database")
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=" & server & "; Database=" & database & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        'cbTipoUsuario.Text = "Elegir una opción"
        'dtpFechaNac.Value = Today.AddYears(-18)
    End Sub

    Private Sub TbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress, tbApellidos.KeyPress
        m.soloLetras(e)
    End Sub

    Private Sub TbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTelefono.KeyPress
        m.soloNumeros(e)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        registrarUsuario()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.cambioVentana(Me, GestionUsuarios)
    End Sub

    Private Sub registrarUsuario()
        Dim claveEncriptada As String = ""
        Dim tipoUsuario As String = cbTipoUsuario.GetItemText(cbTipoUsuario.SelectedItem)

        If (tbNick.Text = "") Then
            MsgBox("Debe establecer su Nick", MsgBoxStyle.Information, "Ingresar Nick")

        ElseIf (tbPassword1.TextLength < 6) Then
            MsgBox("El registro debe contener una contraseña válida", MsgBoxStyle.Exclamation, "Ingresar contraseña")
        ElseIf (tbPassword2.Text <> tbPassword1.Text) Then
            MsgBox("Las contraseña introducida debe coincidir en los dos campos", MsgBoxStyle.Exclamation, "Confirmar contraseña")
        ElseIf (tbNombre.Text = "") Then
            MsgBox("Indique su nombre", MsgBoxStyle.Information, "Ingresar nombre")
        ElseIf (tbApellidos.Text = "") Then
            MsgBox("Indique sus apellidos", MsgBoxStyle.Information, "Ingresar apellidos")
        ElseIf (tbDNI.Text = "" Or tbDNI.TextLength <> 9) Then
            MsgBox("Debe completar el campo de DNI", MsgBoxStyle.Information, "Ingresar DNI")
            If (m.nifValido(tbDNI.Text)) Then
                MsgBox("Debe introducir un DNI/NIE válido", MsgBoxStyle.Exclamation, "DNI incorrecto")
            End If
        ElseIf (dtpFechaNac.Text = "") Then
            MsgBox("Indique su fecha de nacimiento", MsgBoxStyle.Information, "Ingresar fecha de nacimiento")
            If (dtpFechaNac.Value < Today.AddYears(-18)) Then
                MsgBox("El usuario debe ser mayor de edad", MsgBoxStyle.Exclamation, "Establecer fecha de nacimiento")
            End If
        ElseIf (tbTelefono.TextLength <> 9) Then
            MsgBox("Indique teléfono de contacto válido con 9 dígitos", MsgBoxStyle.Exclamation, "Ingresar teléfono")
        ElseIf (tbEmail.Text = "" Or m.validarMail(tbEmail.Text) = False) Then
            MsgBox("Indique un correo electrónico de contacto válido", MsgBoxStyle.Exclamation, "Ingresar email")
        ElseIf (tipoUsuario = "" Or (tipoUsuario <> "administrador" And tipoUsuario <> "cliente")) Then
            MsgBox("Indique el tipo de usuario", MsgBoxStyle.Exclamation, "Indicar Tipo de Usuario")
            'ElseIf Not (cbTipoUsuario.SelectedText = "administrador" Or cbTipoUsuario.SelectedText = "cliente") Then
            '    MsgBox("Indique un tipo de usuario válido", MsgBoxStyle.Exclamation, "Indicar Tipo de Usuario")
        Else
            Try
                conex.Open()
                'Dim dateTime As DateTime = Convert.ToDateTime(dtpFechaNac.Value)
                claveEncriptada = m.MD5EncryptPass(tbPassword1.Text)
                cmd = New MySqlCommand("INSERT INTO `usuario` " &
                                                      "(`idDni`, `apellidos`, `contrasena`, `correo`, `fechaNacimiento`, `nombre`, `nombreUsuario`, `telefono`, `tipoUsuario`) " &
                                                      "VALUES " &
                                                      "(@idDNi, @Apellidos, @contrasena, @correo, @fechaNacimiento, @nombre, @nombreUsuario, @telefono, @tipoUsuario);", conex)
                cmd.Parameters.AddWithValue("@idDni", tbDNI.Text)
                cmd.Parameters.AddWithValue("@Apellidos", tbApellidos.Text)
                cmd.Parameters.AddWithValue("@contrasena", claveEncriptada)
                cmd.Parameters.AddWithValue("@correo", tbEmail.Text)
                cmd.Parameters.AddWithValue("@fechaNacimiento", dtpFechaNac.Value)
                cmd.Parameters.AddWithValue("@nombre", tbNombre.Text)
                cmd.Parameters.AddWithValue("@nombreUsuario", tbNick.Text)
                cmd.Parameters.AddWithValue("@telefono", tbTelefono.Text)
                cmd.Parameters.AddWithValue("@tipoUsuario", cbTipoUsuario.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Se ingresaron correctamente los datos del nuevo usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Éxito!")
                conex.Close()

                m.limpiarCampos(gbLogin)
                m.limpiarCampos(gbDatosUsuario)
                m.cambioVentana(Me, GestionUsuarios)
            Catch ex As Exception
                MsgBox(ex.Message)
                conex.Close()
            End Try
        End If
    End Sub

    'Private Sub TbDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDNI.KeyPress
    '    ' Verificamos la longitud del control TextBox
    '    Dim l As Int32 = tbDNI.TextLength

    '    If (l < 8) Then
    '        ' Solamente abandonamos el procedimiento
    '        Return

    '    ElseIf (l >= 9) Then
    '        ' Cancelamos el evento y abandonamos el procedimiento
    '        e.Handled = True
    '        Return

    '    End If

    '    ' Llegado a éste punto, se comprende que se está
    '    ' intentando introducir el Dígito de Control
    '    ' del NIF.
    '    '
    '    ' Verificamos si el carácter presionado se encuentra
    '    ' en el modelo de expresión regular definido.
    '    '
    '    Dim re As New Regex("[TRWAGMYFPDXBNJZSQVHLCKE]", RegexOptions.IgnoreCase)
    '    e.Handled = (Not (re.IsMatch(e.KeyChar)))
    'End Sub
End Class