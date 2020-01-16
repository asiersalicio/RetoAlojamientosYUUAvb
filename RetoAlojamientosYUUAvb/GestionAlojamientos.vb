Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class GestionAlojamientos
    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Public arrayCampos As Control()
    Dim usuarioBBDD As String
    Dim passwordBBDD As String

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = New Metodos
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD)
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',pais.country 'Pais',terri.territory 'Territorio',muni.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "FROM talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
                                          "WHERE aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " ORDER BY documentname ASC", conex)

        ' For Each campo As Control In arrayCampos
        'campo.
        'Next
        arrayCampos = New Control() {tbId, tbNombre, cbTiposAloj, tbCapacidad, rtbDescripcion, tbTelefono, tbEmail, tbWeb, cbPais, cbTerritorio, cbMunicipio, tbCodPostal, tbDireccion, tbLatitud, tbLongitud}
        rtbDescripcion.Multiline = True
        rtbDescripcion.ScrollBars = ScrollBars.Vertical

        soloLectura()

        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
        DataGridAlojamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridAlojamientos.MultiSelect = False

        'm.cargarTiposAloj(cbTiposAloj)
        'm.cargarDatosAloj("tpais", "country", cbPais)
        'm.cargarDatosAloj("tterritorio", "territory", cbTerritorio)
        'm.cargarDatosAloj("tmunicipio", "municipality", cbMunicipio)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()

        For Each i In Controls
            If TypeOf i Is TextBox Then
                i = ""
            End If
        Next

        AddAlojamiento.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Hide()
        AddAlojamiento.Show()
    End Sub

    Private Sub TbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',pais.country 'Pais',terri.territory 'Territorio',muni.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "FROM talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
                                          "WHERE aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " ORDER BY documentname ASC", conex)
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Public Sub DataGridAlojamientos_CambioDeSeleccion(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAlojamientos.RowEnter
        Dim index As Integer = e.RowIndex
        Dim arrayStrings() As String = New String(14) {}
        For pos = 0 To 14
            Try
                arrayStrings(pos) = DataGridAlojamientos.Rows(index).Cells(pos).Value
            Catch ex As Exception
                arrayStrings(pos) = Nothing
            End Try
        Next
        For pos2 = 0 To 14
            arrayCampos(pos2).Text = arrayStrings(pos2)
        Next

        cargarDatosModificacion()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim resp = MsgBox("¿Desea realmente borrar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Dim query As New MySqlCommand("DELETE FROM talojamientos WHERE idAlojamiento='" & "" & "'", conex)

        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub soloLectura()
        tbId.ReadOnly = True
        tbNombre.ReadOnly = True
        cbTiposAloj.ReadOnly = True
        tbCapacidad.ReadOnly = True
        rtbDescripcion.ReadOnly = True
        tbTelefono.ReadOnly = True
        tbEmail.ReadOnly = True
        tbWeb.ReadOnly = True
        cbPais.ReadOnly = True
        cbTerritorio.ReadOnly = True
        cbMunicipio.ReadOnly = True
        tbCodPostal.ReadOnly = True
        tbDireccion.ReadOnly = True
        tbLatitud.ReadOnly = True
        tbLongitud.ReadOnly = True
    End Sub

    Private Sub cargarDatosModificacion()
        AddAlojamiento.tbId.Text = arrayCampos(0).Text
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
End Class