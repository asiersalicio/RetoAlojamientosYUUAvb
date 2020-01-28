﻿Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class GestionAlojamientos
    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Public arrayCampos As Control()
    Dim usuarioBBDD, passwordBBDD As String
    Dim tabla As DataTable

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles Me.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD)
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',loc.country 'Pais',loc.territory 'Territorio',loc.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "FROM talojamientos aloj, tlocalizacion loc " &
                                          "WHERE aloj.localizacion_idLocalizacion = Loc.idLocalizacion And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " ORDER BY documentname ASC", conex)

        arrayCampos = New Control() {tbId, tbNombre, cbTiposAloj, tbCapacidad, rtbDescripcion, tbTelefono, tbEmail, tbWeb, cbPais, cbTerritorio, cbMunicipio, tbCodPostal, tbDireccion, tbLatitud, tbLongitud}
        rtbDescripcion.Multiline = True
        rtbDescripcion.ScrollBars = ScrollBars.Vertical

        tabla = New DataTable()
        tabla.Clear()
        adapter.Fill(tabla)
        dgvAlojamientos.ResetBindings()
        dgvAlojamientos.DataSource = tabla
        dgvAlojamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlojamientos.MultiSelect = False
        dgvAlojamientos.Rows(0).Selected = True
        dgvAlojamientos.ClearSelection()
        'm.cargarTiposAloj(cbTiposAloj)
        'm.cargarDatosAloj("tpais", "country", cbPais)
        'm.cargarDatosAloj("tterritorio", "territory", cbTerritorio)
        'm.cargarDatosAloj("tmunicipio", "municipality", cbMunicipio)

        m.soloLectura(gbTAlojamientos)
        m.soloLectura(gbTLocalizacion)
    End Sub

    Public Sub DataGridAlojamientos_CambioDeSeleccion(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlojamientos.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(14) {}
        For pos = 0 To 14
            Try
                arrayStrings(pos) = dgvAlojamientos.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 14
            arrayCampos(pos2).Text = arrayStrings(pos2)
        Next
    End Sub

    Private Sub TbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',loc.country 'Pais',loc.territory 'Territorio',loc.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "FROM talojamientos aloj, tlocalizacion loc " &
                                          "WHERE aloj.localizacion_idLocalizacion = Loc.idLocalizacion And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " ORDER BY documentname ASC", conex)
        tabla = New DataTable()
        adapter.Fill(tabla)
        dgvAlojamientos.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Private Sub cargarDatosModificacion()
        AddAlojamiento.tbNombre.Text = arrayCampos(1).Text
        AddAlojamiento.cbTiposAloj.Text = arrayCampos(2).Text
        AddAlojamiento.tbCapacidad.Text = arrayCampos(3).Text
        AddAlojamiento.rtbDescripcion.Text = arrayCampos(4).Text
        AddAlojamiento.tbTelefono.Text = arrayCampos(5).Text
        AddAlojamiento.tbEmail.Text = arrayCampos(6).Text
        AddAlojamiento.tbWeb.Text = arrayCampos(7).Text
        AddAlojamiento.cbPais.Text = arrayCampos(8).Text
        AddAlojamiento.cbTerritorio.Text = arrayCampos(9).Text
        AddAlojamiento.cbMunicipio.Text = arrayCampos(10).Text
        AddAlojamiento.tbCodPostal.Text = arrayCampos(11).Text
        AddAlojamiento.tbDireccion.Text = arrayCampos(12).Text
        AddAlojamiento.tbLatitud.Text = arrayCampos(13).Text
        AddAlojamiento.tbLongitud.Text = arrayCampos(14).Text
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        m.cambioVentana(GestionAlojamientos.ActiveForm, AddAlojamiento)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (dgvAlojamientos.SelectedRows.Count <> 1) Then
            MsgBox("Debe tener un alojamiento seleccionado para poder modificarlo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Else
            cargarDatosModificacion()
            m.cambioVentana(GestionAlojamientos.ActiveForm, AddAlojamiento)
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        m.borrarReg("talojamientos", tbId.Text, dgvAlojamientos)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(GestionAlojamientos.ActiveForm)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        m.cambioVentana(Me, MenuGestion)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class