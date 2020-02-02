Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class GestionReservas
    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapterTabla As MySqlDataAdapter
    Dim ds As DataSet
    Dim cmd As New MySqlCommand
    Public arrayCampos As Control()
    Public modoVision As String
    Dim usuarioBBDD, passwordBBDD, servidor, baseDatos As String
    Dim tabla As DataTable

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        servidor = ConfigurationManager.AppSettings.Get("Servidor")
        baseDatos = ConfigurationManager.AppSettings.Get("BaseDatos")
        'conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        conex = New MySqlConnection("Server=" & servidor & "; Database=" & baseDatos & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        adapterTabla = New MySqlDataAdapter("SELECT idReserva 'Nº reserva', fechaEntrada 'Fecha entrada', fechaSalida 'Fecha salida', aloj.documentname 'Alojamiento', aloj.lodgingtype 'Tipo', usu.idDni 'Dni',usu.nombre 'Nombre', usu.apellidos 'Apellidos' " &
                                                       "FROM reserva res, usuario usu, talojamientos aloj " &
                                                       "WHERE res.idDni=usu.idDni AND aloj.idAlojamiento=res.idAlojamiento " &
                                                       "ORDER BY idReserva ASC", conex)

        tabla = New DataTable()
        tabla.Clear()
        adapterTabla.Fill(tabla)

        dgvReservas.ResetBindings()
        dgvReservas.DataSource = tabla
        dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservas.MultiSelect = False
        'dgvReservas.Rows(0).Selected = True

        m.soloLectura(gbDatosReserva)
        arrayCampos = New Control() {tbIdReserva, dtpEntrada, dtpSalida, tbAlojamiento, tbCategoria, tbDniCliente, tbNombreCliente, tbApellidosCliente}
    End Sub

    Private Sub DgvReservas_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(7) {}
        For pos = 0 To 7
            Try
                arrayStrings(pos) = dgvReservas.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 7
            arrayCampos(pos2).Text = arrayStrings(pos2)
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddReserva.modoRva = "insert"
        m.cambioVentana(Me, AddReserva)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (dgvReservas.SelectedRows.Count <> 1) Then
            MsgBox("Debe tener un usuario seleccionado para poder modificarlo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Else
            cargarDatosModificacion()
            AddReserva.modoRva = "update"
            m.cambioVentana(Me, AddReserva)
        End If
    End Sub

    Private Sub cargarDatosModificacion()
        AddReserva.tbIdReserva.Text = arrayCampos(0).Text
        AddReserva.dtpEntrada.Text = CType(arrayCampos(1), DateTimePicker).Value.Date.ToString
        AddReserva.dtpSalida.Text = CType(arrayCampos(2), DateTimePicker).Value.Date.ToString
        AddReserva.cbAlojamiento.Text = arrayCampos(3).Text
        AddReserva.cbTipoAlojamiento.Text = arrayCampos(4).Text
        AddReserva.tbDni.Text = arrayCampos(5).Text
        AddReserva.tbNombreUser.Text = arrayCampos(6).Text
        AddReserva.tbApellidosUser.Text = arrayCampos(7).Text

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        m.borrarReg("reserva", Me.tbIdReserva.Text, dgvReservas)
        tabla.Clear()
        adapterTabla.Fill(tabla)
        dgvReservas.ResetBindings()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(GestionReservas.ActiveForm)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class