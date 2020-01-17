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

    Private Sub lblIdReserva_Click(sender As Object, e As EventArgs) Handles lblIdReserva.Click

    End Sub

    Private Sub lblFechaEntrada_Click(sender As Object, e As EventArgs) Handles lblFechaEntrada.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class