Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddAlojamiento
    Dim sUsuario As String = ConfigurationManager.AppSettings.Get("Usuario")
    Dim sPassword As String = ConfigurationManager.AppSettings.Get("Password")
    Dim conex As New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")
    Private adapter As New MySqlDataAdapter("INSERT INTO talojamientos", conex)
    Private adapterTiposAloj As New MySqlDataAdapter("SELECT DISTINCT lodgingtype FROM talojamientos", conex)
    Private Sub AddAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        'Dim tabla As New DataTable()
        'adapter.Fill(tabla)
        'DataGridAlojamientos.DataSource = tabla
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposAloj.SelectedIndexChanged
        Dim lista As New DataSet()
        adapterTiposAloj.Fill(lista)
        cbTiposAloj.DataSource = lista
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is GroupBox Then
                For Each controlText As Windows.Forms.Control In Me.gbTAlojamientos.Controls
                    If TypeOf controlText Is TextBox Then
                        CType(controlText, TextBox).Clear()
                    End If
                Next

                For Each controlText As Windows.Forms.Control In Me.gbTLocalizacion.Controls
                    If TypeOf controlText Is TextBox Then
                        CType(controlText, TextBox).Clear()
                    End If
                Next
            End If
        Next

        Me.Hide()
        GestionAlojamientos.Show()
    End Sub

End Class