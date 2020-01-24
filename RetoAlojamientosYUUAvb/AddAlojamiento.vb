Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddAlojamiento
    Dim m As New Metodos
    Dim usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection
    Dim cmd As  MySqlCommand
    Dim da, daInsert, daTipoAloj As MySqlDataAdapter

    Private Sub AddAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

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
        anadirAloj()
        m.limpiarCampos(gbTAlojamientos)
        m.limpiarCampos(gbTLocalizacion)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.limpiarCampos(gbTAlojamientos)
        m.limpiarCampos(gbTLocalizacion)
        m.cambioVentana(Me, GestionAlojamientos)
    End Sub

    Public Sub anadirAloj()
        'Dim cmd As MySqlCommand = conex.CreateCommand
        cmd = conex.CreateCommand
        Try
            conex.Open()
            cmd.CommandType = CommandType.StoredProcedure

            'Datos Alojamiento
            cmd.Parameters.Add(New MySqlParameter("p_capacity", tbCapacidad.Text))
            cmd.Parameters.Add(New MySqlParameter("p_turismdescription", rtbDescripcion.Text))
            cmd.Parameters.Add(New MySqlParameter("p_tourismemail", tbEmail.Text))
            cmd.Parameters.Add(New MySqlParameter("p_documentname", tbNombre.Text))
            cmd.Parameters.Add(New MySqlParameter("p_phone", tbTelefono.Text))
            cmd.Parameters.Add(New MySqlParameter("p_lodgingtype", cbTiposAloj.Text))
            cmd.Parameters.Add(New MySqlParameter("p_web", tbWeb.Text))

            'Datos de localizacion del alojamiento
            cmd.Parameters.Add(New MySqlParameter("p_municipality", cbMunicipio.Text))
            cmd.Parameters.Add(New MySqlParameter("p_address", tbDireccion.Text))
            cmd.Parameters.Add(New MySqlParameter("p_postalcode", tbCodPostal.Text))
            cmd.Parameters.Add(New MySqlParameter("p_territory", cbTerritorio.Text))
            cmd.Parameters.Add(New MySqlParameter("p_country", cbPais.Text))
            cmd.Parameters.Add(New MySqlParameter("p_lat", tbLatitud.Text))
            cmd.Parameters.Add(New MySqlParameter("p_lon", tbLongitud.Text))
            cmd.CommandText = "ingresarReserva"

            cmd.ExecuteNonQuery()
            MsgBox("Se ingresaron correctamente los datos del nuevo usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Éxito!")
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
        End Try
    End Sub

    Sub comprobarCamposAlojBBDD()
        Try
            conex.Open()
            cmd = New MySqlCommand("SELECT DISTINCT country FROM tpais,tmunicipio,tterritorio,tlocalizacion WHERE tpais.countrycode=tlocalizacion.countrycode AND tmunicipio.municipalitycode=tlocalizacion.municipalitycode AND tterritorio.territorycode=tlocalizacion.territorycode")
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
        End Try
    End Sub
End Class