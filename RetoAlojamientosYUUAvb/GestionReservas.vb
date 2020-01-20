Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionReservas
    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Public arrayCampos As Control()
    Dim usuarioBBDD As String
    Dim passwordBBDD As String

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD)
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Id Alojamiento',documentname 'Nombre Alojamiento', idReserva 'Id Reserva',idDni 'DNI',nombre 'Nombre',apellidos 'Apellidos'" &
                                          "FROM talojamientos aloj, reserva res, usuario usu " &
                                          "WHERE " &
                                          " ORDER BY documentname ASC", conex)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        m.limpiarCampos(gbDatosReserva)
        MenuGestion.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(GestionReservas.ActiveForm)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        m.limpiarCampos(gbDatosReserva)
        MenuGestion.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class