Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class GestionAlojamientos

    Dim m As Metodos
    Dim conex As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim arrayCampos As Control()
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
                                          "From talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
                                          "Where aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " Order By documentname ASC", conex)

        ' For Each campo As Control In arrayCampos
        'campo.
        'Next
        arrayCampos = New Control() {tbId, tbNombre, cbTiposAloj, tbCapacidad, tbDescripcion, tbTelefono, tbEmail, tbWeb, cbPais, cbTerritorio, cbMunicipio, tbCodPostal, tbDireccion, tbLatitud, tbLongitud}
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
        DataGridAlojamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridAlojamientos.MultiSelect = False

        m.cargarTiposAloj()
        m.cargarDatosAloj("tpais", "country", cbPais)
        m.cargarDatosAloj("tterritorio", "territory", cbTerritorio)
        m.cargarDatosAloj("tmunicipio", "municipality", cbMunicipio)
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
        AddAlojamiento.Show()
    End Sub

    Private Sub TbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        adapter = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',pais.country 'Pais',terri.territory 'Territorio',muni.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "From talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
                                          "Where aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode And lower(documentname) Like " & Chr(34) & "%" & tbBusqueda.Text & "%" & Chr(34) &
                                          " Order By documentname ASC", conex)
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Private Sub DataGridAlojamientos_CambioDeSeleccion(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAlojamientos.RowEnter
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
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim resp = MsgBox("¿Desea realmente borrar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Dim query As New MySqlDataAdapter("DELETE FROM", conex)

        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub CbTiposAloj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposAloj.SelectedIndexChanged

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub
End Class