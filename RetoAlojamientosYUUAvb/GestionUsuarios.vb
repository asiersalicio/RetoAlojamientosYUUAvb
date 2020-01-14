Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionUsuarios
    Dim m As New Metodos
    Dim usuarioBBDD As String = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
    Dim passwordBBDD As String = ConfigurationManager.AppSettings.Get("PasswordBBDD")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
    Public adapter As New MySqlDataAdapter("SELECT idDni 'DNI',nombreUsuario 'Nombre Usuario',contrasena 'Contraseña', correo 'email',nombre 'Nombre',apellidos 'Apellidos',fechaNacimiento 'Fecha Nacimiento',telefono 'Teléfono',tipoUsuario 'Tipo Usuario' " &
                                           "FROM usuario", conex)
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridUsuarios.DataSource = tabla
        DataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridUsuarios.MultiSelect = False

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

    'Private Sub DataGridUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.CellContentClick
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(1)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(2)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(3)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(4)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(0)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(5)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(6)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(7)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(8)
    '    tbNick.Text = DataGridUsuarios.SelectedCells(0).Value(9)
    'End Sub
End Class