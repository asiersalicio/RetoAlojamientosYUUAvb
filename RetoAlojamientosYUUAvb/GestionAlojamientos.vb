Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Public Class GestionAlojamientos
    Dim m As New Metodos
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")
    Private adapter As New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre alojamiento',municipality 'Localidad',address 'Dirección', lodgingtype 'Tipo alojamiento',turismdescription 'Descripción',capacity 'Capacidad',phone 'Teléfono',tourismemail 'eMail' FROM talojamientos aloj, tlocalizacion loc, tmunicipio muni WHERE aloj.localizacion_idLocalizacion=loc.idLocalizacion AND loc.municipalitycode=muni.municipalitycode ORDER BY documentname ASC", conex)
    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("Usuario")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("Password")
    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
		DataGridAlojamientos.DataSource = tabla
		DataGridAlojamientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		DataGridAlojamientos.MultiSelect = False
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
        Dim query As New MySqlDataAdapter("SELECT DISTINCT idAlojamiento 'Identificador',documentname 'Nombre alojamiento',municipality 'Localidad',address 'Dirección', lodgingtype 'Tipo alojamiento',turismdescription 'Descripción',capacity 'Capacidad',phone 'Teléfono',tourismemail 'eMail'" &
                                              "FROM talojamientos aloj, tlocalizacion loc, tmunicipio muni " &
                                              "WHERE aloj.localizacion_idLocalizacion=loc.idLocalizacion AND loc.municipalitycode=muni.municipalitycode AND lower(documentname) like " & Chr(34) & "%" & tbBusqueda.Text.ToLower & "%" & Chr(34) & " ORDER BY documentname ASC ", conex)
        Dim tabla As New DataTable()
        query.Fill(tabla)
        DataGridAlojamientos.DataSource = tabla
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        m.limpiarBusqueda()
    End Sub

    Private Sub DataGridAlojamientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(0)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(1)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(2)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(3)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(4)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(5)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(6)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(7)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(8)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(9)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(10)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(11)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(12)
        tbId.Text = DataGridAlojamientos.SelectedCells(0).Value(13)
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim resp = MsgBox("¿Desea realmente borrar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        Dim query As New MySqlDataAdapter("DELETE FROM", conex)


        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class