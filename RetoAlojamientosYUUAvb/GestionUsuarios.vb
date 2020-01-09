Imports MySql.Data.MySqlClient

Public Class GestionUsuarios
    Dim m As New Metodos
    Public conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=retoaloj; Pwd=elchapas23")
    Public adapter As New MySqlDataAdapter("SELECT * FROM USUARIOS", conex)
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridUsuarios.DataSource = tabla
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub

	Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
		Me.Hide()
		MenuGestion.Show()
	End Sub
End Class