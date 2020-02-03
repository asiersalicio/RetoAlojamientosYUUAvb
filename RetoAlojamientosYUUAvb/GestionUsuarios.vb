Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionUsuarios
    Dim metodos As New Metodos
    Dim conex As New MySqlConnection
    Public adapterUsuarios As New MySqlDataAdapter
    Public adapterReserva As New MySqlDataAdapter
    Public arrayCamposUsuario, arrayCamposReserva As Control()
    Dim usuarioBBDD, passwordBBDD As String
    Dim tablaUsuarios, tablaReservas As DataTable

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        adapterUsuarios = New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                           "FROM usuario WHERE NOT nombreUsuario='root'", conex)

        arrayCamposUsuario = New Control() {tbDNI, tbNick, tbPassword, tbEmail, tbNombre, tbApellidos, dtpFechaNac, tbTelefono, tbTipoUsuario}
        arrayCamposReserva = New Control() {tbIdReserva, dtpEntrada, dtpSalida, tbAlojamiento, tbCategoria}

        tablaUsuarios = New DataTable()
        tablaUsuarios.Clear()
        adapterUsuarios.Fill(tablaUsuarios)
        dgvUsuarios.ResetBindings()
        dgvUsuarios.DataSource = tablaUsuarios
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.Rows(0).Selected = True
        dgvUsuarios.ClearSelection()

        metodos.cargarTiposUsuarioTxt(tbTipoUsuario)
        metodos.soloLectura(gbLogin)
        metodos.soloLectura(gbDatosUsuario)
        metodos.soloLectura(gbDatosReserva)
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
            arrayCamposUsuario(pos2).Text = arrayStrings(pos2)
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
        metodos.limpiarBusqueda()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAddUsuario.Click, cmAddUsuario.Click
        metodos.cambioVentana(GestionUsuarios.ActiveForm, AddUsuario)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnEditUsuario.Click, cmEditUsuario.Click
        If (dgvUsuarios.SelectedRows.Count <> 1) Then
            MsgBox("Debe tener al menos un usuario seleccionado para poder modificarlo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Else
            datosModUsuario()
            metodos.cambioVentana(Me, AddUsuario)
        End If
    End Sub

    Private Sub BtnEditReserva_Click(sender As Object, e As EventArgs) Handles btnEditReserva.Click
        If (dgvReservasUsuario.SelectedRows.Count <> 1) Then
            MsgBox("Debe tener al menos una reserva seleccionada para poder modificarla", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Else
            datosModReserva()
            metodos.cambioVentana(Me, AddReserva)
        End If
    End Sub


    Private Sub datosModUsuario()
        AddUsuario.tbDNI.Text = arrayCamposUsuario(0).Text
        AddUsuario.tbNick.Text = arrayCamposUsuario(1).Text
        AddUsuario.tbPassword1.Text = arrayCamposUsuario(2).Text
        AddUsuario.tbEmail.Text = arrayCamposUsuario(3).Text
        AddUsuario.tbNombre.Text = arrayCamposUsuario(4).Text
        AddUsuario.tbApellidos.Text = arrayCamposUsuario(5).Text
        AddUsuario.dtpFechaNac.Text = CType(arrayCamposUsuario(6), DateTimePicker).Value.Date.ToString
        AddUsuario.tbTelefono.Text = arrayCamposUsuario(7).Text
        AddUsuario.cbTipoUsuario.Text = arrayCamposUsuario(8).Text
    End Sub

    Private Sub datosModReserva()
        'AddReserva.tbIdReserva.Text = arrayCampos(0).Text
        'AddReserva.dtpEntrada.Text = CType(arrayCampos(1), DateTimePicker).Value.Date.ToString
        'AddReserva.dtpSalida.Text = CType(arrayCampos(2), DateTimePicker).Value.Date.ToString
        'AddReserva.cbAlojamiento.Text = arrayCampos(3).Text
        'AddReserva.cbTipoAlojamiento.Text = arrayCampos(4).Text
        'AddReserva.tbDni.Text = arrayCampos(5).Text
        'AddReserva.tbNombreUser.Text = arrayCampos(6).Text
        'AddReserva.tbApellidosUser.Text = arrayCampos(7).Text

        'm.cargarRvaDatosCliente(arrayCampos(5).Text)
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrarUsuario.Click, cmBorrarUsuario.Click
        metodos.borrarReg("usuario", "idDni", Me.tbDNI.Text, dgvUsuarios)
        tablaUsuarios.Clear()
        adapterUsuarios.Fill(tablaUsuarios)
        dgvUsuarios.ResetBindings()
    End Sub

    Private Sub BtnBorrarReserva_Click(sender As Object, e As EventArgs) Handles btnBorrarReserva.Click
        metodos.borrarReg("reserva", "idDni", Me.tbDNI.Text, dgvUsuarios)
        tablaUsuarios.Clear()
        adapterUsuarios.Fill(tablaUsuarios)
        dgvUsuarios.ResetBindings()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        metodos.desconectar(GestionUsuarios.ActiveForm)
    End Sub

    Private Sub dgvReservasUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservasUsuario.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(4) {}
        For pos = 0 To 4
            Try
                arrayStrings(pos) = dgvReservasUsuario.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 4
            arrayCamposReserva(pos2).Text = arrayStrings(pos2)
        Next

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        metodos.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        adapterReserva = New MySqlDataAdapter("SELECT DISTINCT idReserva 'Id reserva',fechaEntrada 'Fecha entrada', fechaSalida 'fecha salida', aloj.documentname 'Alojamiento', aloj.lodgingtype 'Categoria', res.idDni 'Dni',usu.nombre 'Nombre', usu.apellidos 'Apellidos' " &
                                      "FROM reserva res, usuario usu, talojamientos aloj " &
                                      "WHERE res.idDni=usu.idDni AND aloj.idAlojamiento=res.idAlojamiento AND res.idDni='" & dgvUsuarios.SelectedRows(0).Cells(0).Value & "'" &
                                      "ORDER BY idReserva ASC", conex)

        tablaReservas = New DataTable()
        tablaReservas.Clear()
        adapterReserva.Fill(tablaReservas)
        dgvReservasUsuario.ResetBindings()
        dgvReservasUsuario.DataSource = tablaReservas
        dgvReservasUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservasUsuario.MultiSelect = False
    End Sub



    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        metodos.salir()
    End Sub
End Class