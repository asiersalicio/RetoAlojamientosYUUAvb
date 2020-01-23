Imports System.Configuration
Imports System.Text.RegularExpressions
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

        m.limpiarCampos(gbLogin)
        m.limpiarCampos(gbDatosUsuario)
        cbTipoUsuario.Text = "Elegir una opción"
        'm.cargarTipos("usuario", "tipoUsuario", cbTipoUsuario)
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
        m.limpiarCampos(gbLogin)
        m.limpiarCampos(gbDatosUsuario)

        Me.Close()

        GestionUsuarios.Show()
    End Sub

    Private Sub registrarUsuario()
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        Dim claveEncriptada As String = ""
        Dim tipoUsuario As String = cbTipoUsuario.GetItemText(cbTipoUsuario.SelectedItem)

        If (tbNick.Text = "") Then
            MsgBox("Debe establecer su Nick", MsgBoxStyle.Exclamation, "Ingresar Nick")
        ElseIf (tbPassword1.TextLength < 6) Then
            MsgBox("El registro debe contener una contraseña válida", MsgBoxStyle.Exclamation, "Ingresar contraseña")
        ElseIf (tbPassword2.Text <> tbPassword1.Text) Then
            MsgBox("Las contraseña introducida debe coincidir en los dos campos", MsgBoxStyle.Exclamation, "Confirmar contraseña")
        ElseIf (tbNombre.Text = "") Then
            MsgBox("Indique su nombre", MsgBoxStyle.Exclamation, "Ingresar nombre")
        ElseIf (tbApellidos.Text = "") Then
            MsgBox("Indique sus apellidos", MsgBoxStyle.Exclamation, "Ingresar apellidos")
        ElseIf (tbDNI.Text = "" Or tbDNI.TextLength < 9) Then
            MsgBox("Debe completar el campo de DNI", MsgBoxStyle.Exclamation, "Ingresar DNI")
        ElseIf (dtpFechaNac.Text = "") Then
            MsgBox("Indique su fecha de nacimiento", MsgBoxStyle.Exclamation, "Ingresar fecha de nacimiento")
        ElseIf (tbTelefono.TextLength <> 9) Then
            MsgBox("Indique teléfono de contacto", MsgBoxStyle.Exclamation, "Ingresar teléfono")
        ElseIf (tbEmail.Text = "") Then
            MsgBox("Indique un correo electrónico de contacto", MsgBoxStyle.Exclamation, "Ingresar email")
        ElseIf (tipoUsuario = "" Or (tipoUsuario <> "administrador" And tipoUsuario <> "cliente")) Then
            MsgBox("Indique el tipo de usuario", MsgBoxStyle.Exclamation, "Indicar Tipo de Usuario")
            'ElseIf Not (cbTipoUsuario.SelectedText = "administrador" Or cbTipoUsuario.SelectedText = "cliente") Then
            '    MsgBox("Indique un tipo de usuario válido", MsgBoxStyle.Exclamation, "Indicar Tipo de Usuario")
        Else
            Try
                conex.Open()
                'Dim dateTime As DateTime = Convert.ToDateTime(dtpFechaNac.Value)
                claveEncriptada = m.MD5EncryptPass(tbPassword1.Text)
                Dim cmd As New MySqlCommand("INSERT INTO `usuario` " &
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
                conex.Close()
                MsgBox("Se ingresaron correctamente los datos del nuevo usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Éxito!")

                m.limpiarCampos(gbLogin)
                m.limpiarCampos(gbDatosUsuario)

                Me.Close()
                GestionUsuarios.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
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