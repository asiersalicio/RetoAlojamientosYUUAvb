Imports MySql.Data.MySqlClient

Public Class AddAlojamiento
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=retoaloj; Pwd=elchapas23")
    Private adapter As New MySqlDataAdapter("INSERT INTO talojamientos", conex)
    Private Sub AddAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        'DataGridAlojamientos.DataSource = tabla
    End Sub
End Class