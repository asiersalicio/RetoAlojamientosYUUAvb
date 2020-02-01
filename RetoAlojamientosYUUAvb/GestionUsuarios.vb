Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionUsuarios
    Dim m As New Metodos
    Dim conex As New MySqlConnection
    Public adapter As New MySqlDataAdapter
    Public arrayCampos As Control()
    Dim usuarioBBDD, passwordBBDD, servidor, baseDatos As String
    Dim tabla As DataTable

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        servidor = ConfigurationManager.AppSettings.Get("Servidor")
        baseDatos = ConfigurationManager.AppSettings.Get("BaseDatos")
        'conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        conex = New MySqlConnection("Server=" & servidor & "; Database=" & baseDatos & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        adapter = New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                           "FROM usuario", conex)
        arrayCampos = New Control() {tbDNI, tbNick, tbPassword, tbEmail, tbNombre, tbApellidos, dtpFechaNac, tbTelefono, tbTipoUsuario}

        tabla = New DataTable()
        tabla.Clear()
        adapter.Fill(tabla)
        dgvUsuarios.ResetBindings()
        dgvUsuarios.DataSource = tabla
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.Rows(0).Selected = True
        dgvUsuarios.ClearSelection()

        m.cargarTiposUsuarioTxt(tbTipoUsuario)
        m.soloLectura(gbLogin)
        m.soloLectura(gbDatosUsuario)
    End Sub

    Private Sub DataGridAlojamientos_CambioDeSeleccion(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(8) {}
        For pos = 0 To 8
            Try
                arrayStrings(pos) = dgvUsuarios.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 8
            arrayCampos(pos2).Text = arrayStrings(pos2)
        Next
    End Sub

    Private Sub TbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim query As New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                              "FROM usuario " &
                                              "WHERE idDni AND lower(idDni) AND lower(nombreUsuario) like " & Chr(34) & "%" & tbBusqueda.Text.ToLower & "%" & Chr(34), conex)
        Dim tabla As New DataTable()
        query.Fill(tabla)
        dgvUsuarios.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        m.cambioVentana(GestionUsuarios.ActiveForm, AddUsuario)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (dgvUsuarios.SelectedRows.Count <> 1) Then
            MsgBox("Debe tener un usuario seleccionado para poder modificarlo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            'ElseIf (dgvUsuarios.SelectedColumns(0) Is Nothing) Then
            '    MsgBox("Debe seleccionar un usuario válido", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Else
            cargarDatosModificacion()
            m.cambioVentana(Me, AddUsuario)
        End If
    End Sub
    Private Sub cargarDatosModificacion()
        AddUsuario.tbDNI.Text = arrayCampos(0).Text
        AddUsuario.tbNick.Text = arrayCampos(1).Text
        AddUsuario.tbPassword1.Text = arrayCampos(2).Text
        AddUsuario.tbEmail.Text = arrayCampos(3).Text
        AddUsuario.tbNombre.Text = arrayCampos(4).Text
        AddUsuario.tbApellidos.Text = arrayCampos(5).Text
        AddUsuario.dtpFechaNac.Text = CType(arrayCampos(6), DateTimePicker).Value.Date.ToString
        AddUsuario.tbTelefono.Text = arrayCampos(7).Text
        AddUsuario.cbTipoUsuario.Text = arrayCampos(8).Text
    End Sub

    Private Sub btnVerReservas_Click(sender As Object, e As EventArgs) Handles btnVerReservas.Click
        m.cambioVentana(Me, GestionReservas)

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        m.borrarReg("usuario", Me.tbDNI.Text, dgvUsuarios)
        tabla.Clear()
        adapter.Fill(tabla)
        dgvUsuarios.ResetBindings()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(GestionUsuarios.ActiveForm)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class