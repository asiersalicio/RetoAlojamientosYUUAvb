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

        'da = New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre',lodgingtype 'Tipo alojamiento', capacity 'Capacidad',turismdescription 'Descripción',phone 'Teléfono'," &
        '                                  "tourismemail 'eMail',Web 'Web',pais.country 'Pais',terri.territory 'Territorio',muni.municipality 'Municipio',postalcode 'Codigo postal',address 'Dirección',latwgs84 'Latitud'," &
        '                                  "lonwgs84 'Longitud' " &
        '                                  "From talojamientos aloj, tlocalizacion loc, tmunicipio muni, tpais pais, tterritorio terri " &
        '                                  "Where aloj.localizacion_idLocalizacion = Loc.idLocalizacion And Loc.municipalitycode = muni.municipalitycode And Loc.territorycode = terri.territorycode And Loc.countrycode = pais.countrycode Order By documentname ASC", conex)

        rtbDescripcion.Multiline = True
        rtbDescripcion.ScrollBars = ScrollBars.Vertical

        'Dim tabla As New DataTable()
        'da.Fill(tabla)

        m.cargarTipos("talojamientos", "lodgingtype", cbTiposAloj)
        m.cargarDatosAloj("tpais", "country", cbPais)
        m.cargarDatosAloj("tterritorio", "territory", cbTerritorio)
        m.cargarDatosAloj("tmunicipio", "municipality", cbMunicipio)
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        daInsert = New MySqlDataAdapter("INSERT INTO `talojamientos` " &
                                        "(`idAlojamiento`, `capacity`, `turismdescription`, `tourismemail`, `documentname`, `phone`, `lodgingtype`, `web`, `localizacion_idLocalizacion`) " &
                                        "VALUES ('0', '100', 'demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba ', 'email_aloj_prueba@demo.com', 'Demo Alojamiento Prueba', '902202122', 'TipoPrueba', 'www.webPrueba.com', '0');", conex)

        m.limpiarCampos(gbTAlojamientos)
        m.limpiarCampos(gbTLocalizacion)
    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposAloj.SelectedIndexChanged
    '    Try
    '        Dim lista As New DataSet()
    '        daTipoAloj.Fill(lista)
    '        cbTiposAloj.DataSource = lista
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.limpiarCampos(gbTAlojamientos)
        m.limpiarCampos(gbTLocalizacion)

        Me.Hide()

        GestionAlojamientos.Show()
    End Sub

End Class