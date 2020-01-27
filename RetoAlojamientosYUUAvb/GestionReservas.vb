Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionReservas
    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Public arrayCampos As Control()
    Dim usuarioBBDD, passwordBBDD As String
    Dim tabla As DataTable

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD)
        adapter = New MySqlDataAdapter("SELECT DISTINCT idReserva 'Id reserva',fechaEntrada 'Fecha entrada', fechaSalida 'fecha salida',idAlojamiento 'Id alojamiento',res.idDni 'Dni',nombre 'Nombre', apellidos 'Apellidos' " &
                                       "FROM reserva res, usuario usu " &
                                       "WHERE res.idDni = usu.idDni " &
                                       "ORDER BY idReserva ASC ", conex)
        arrayCampos = New Control() {tbIdReserva, tbFechaEntrada, tbFechaSalida, tbAlojamiento, tbCategoria, tbDniCliente, tbNombreCliente, tbApellidosCliente}

        tabla = New DataTable()
        tabla.Clear()
        adapter.Fill(tabla)
        dgvReservas.ResetBindings()
        dgvReservas.DataSource = tabla
        dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservas.MultiSelect = False
        dgvReservas.Rows(0).Selected = True

        m.soloLectura(gbDatosReserva)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.CellContentClick

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(GestionReservas.ActiveForm)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class