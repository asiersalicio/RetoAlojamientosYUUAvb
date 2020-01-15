Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionUsuarios
    Dim m As New Metodos
    Dim conex As New MySqlConnection
    Public adapter As New MySqlDataAdapter
    Dim arrayCampos As Control()
    Dim usuarioBBDD, passwordBBDD As String
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        adapter = New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                           "FROM usuario", conex)

        arrayCampos = New Control() {tbDNI, tbNick, tbPassword, tbEmail, tbNombre, tbApellidos, dtpFechaNac, tbTelefono, cbTipoUsuario}

        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridUsuarios.DataSource = tabla
        DataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridUsuarios.MultiSelect = False

        m.cargarTipoUsuario()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub TbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim query As New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                              "FROM usuario " &
                                              "WHERE idDni AND lower(idDni) AND lower(nombreUsuario) like " & Chr(34) & "%" & tbBusqueda.Text.ToLower & "%" & Chr(34), conex)
        Dim tabla As New DataTable()
        query.Fill(tabla)
        DataGridUsuarios.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Private Sub DataGridAlojamientos_CambioDeSeleccion(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(8) {}
        For pos = 0 To 8
            Try
                arrayStrings(pos) = DataGridUsuarios.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 8
            arrayCampos(pos2).Text = arrayStrings(pos2)
        Next
    End Sub
End Class