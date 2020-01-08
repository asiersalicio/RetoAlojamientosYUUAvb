Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class GestionAlojamientos
    Dim m As New Metodos

    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("Usuario")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("Password")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")
    'Public conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=retoaloj; Pwd=elchapas23")
    'Public adapter As New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre alojamiento',marks 'Localidad',address 'Dirección', lodgingtype 'Tipo alojamiento',turismdescription 'Descripción',capacity 'Capacidad',phone 'Teléfono',tourismemail 'eMail' FROM talojamientos aloj, tlocalizacion loc WHERE aloj.localizacion_idLocalizacion=loc.idLocalizacion", conex)
    Private adapter As New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre alojamiento',municipality 'Localidad',address 'Dirección', lodgingtype 'Tipo alojamiento',turismdescription 'Descripción',capacity 'Capacidad',phone 'Teléfono',tourismemail 'eMail' FROM talojamientos aloj, tlocalizacion loc, tmunicipio muni WHERE aloj.localizacion_idLocalizacion=loc.idLocalizacion AND loc.municipalitycode=muni.municipalitycode ORDER BY documentname ASC ", conex)

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class