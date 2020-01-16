Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddAlojamiento
    Dim m As New Metodos
    Dim usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection
    Dim da, daInsert, daTipoAloj As MySqlDataAdapter

    Private Sub AddAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        da = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
                                          "tourismemail 'eMail',Web 'Web',pais.country 'Pais',terri.territory 'Territorio',muni.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
                                          "lonwgs84 'Longitud' " &
                                          "From talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
                                          "Where aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode Order By documentname ASC", conex)

        ''Limpiar datos del groupbox
        'For Each control In Me.Controls
        '    If TypeOf control Is GroupBox Then
        '        For Each groupbox In control.controls
        '            CType(groupbox, TextBox).Clear()
        '        Next
        '    End If
        'Next

        rtbDescripcion.Multiline = True
        rtbDescripcion.ScrollBars = ScrollBars.Vertical

        Dim tabla As New DataTable()
        da.Fill(tabla)

        m.cargarTiposAloj(cbTiposAloj)

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        daInsert = New MySqlDataAdapter("INSERT INTO `talojamientos` " &
                                        "(`idAlojamiento`, `capacity`, `turismdescription`, `tourismemail`, `documentname`, `phone`, `lodgingtype`, `web`, `localizacion_idLocalizacion`) " &
                                        "VALUES ('0', '100', 'demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba ', 'email_aloj_prueba@demo.com', 'Demo Alojamiento Prueba', '902202122', 'TipoPrueba', 'www.webPrueba.com', '0');", conex)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposAloj.SelectedIndexChanged
        Try
            Dim lista As New DataSet()
            daTipoAloj.Fill(lista)
            cbTiposAloj.DataSource = lista
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'For Each control As Control In Me.Controls
        '    If TypeOf control Is GroupBox Then
        '        For Each controlText As Control In Me.gbTAlojamientos.Controls
        '            If TypeOf controlText Is TextBox Then
        '                CType(controlText, TextBox).Clear()
        '            End If
        '        Next

        '        For Each controlText As Control In Me.gbTLocalizacion.Controls
        '            If TypeOf controlText Is TextBox Then
        '                CType(controlText, TextBox).Clear()
        '            End If
        '        Next
        '    End If
        'Next

        tbId.Clear()
        tbNombre.Clear()
        cbTiposAloj.Items.Clear()
        tbCapacidad.Clear()
        rtbDescripcion.Clear()
        tbTelefono.Clear()
        tbEmail.Clear()
        tbWeb.Clear()
        cbPais.Items.Clear()
        cbTerritorio.Items.Clear()
        cbMunicipio.Items.Clear()
        tbCodPostal.Clear()
        tbDireccion.Clear()
        tbLatitud.Clear()
        tbLongitud.Clear()

        Me.Hide()

        m.cargarTiposAloj(cbTiposAloj)
        m.cargarDatosAloj("tpais", "country", cbPais)
        m.cargarDatosAloj("tterritorio", "territory", cbTerritorio)
        m.cargarDatosAloj("tmunicipio", "municipality", cbMunicipio)

        GestionAlojamientos.Show()
    End Sub

End Class