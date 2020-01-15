Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddAlojamiento
    Dim sUsuario, sPassword As String
    Dim conex As New MySqlConnection
    Private daInsert As New MySqlDataAdapter
    Private daTipoAloj As New MySqlDataAdapter

    Private Sub AddAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sUsuario = ConfigurationManager.AppSettings.Get("Usuario")
        sPassword = ConfigurationManager.AppSettings.Get("Password")
        conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos; Uid=" & sUsuario & "; Pwd=" & sPassword & "")

        daInsert = New MySqlDataAdapter("INSERT INTO `talojamientos` " &
                                        "(`idAlojamiento`, `capacity`, `turismdescription`, `tourismemail`, `documentname`, `phone`, `lodgingtype`, `web`, `localizacion_idLocalizacion`) " &
                                        "VALUES ('0', '100', 'demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba demo - prueba ', 'email_aloj_prueba@demo.com', 'Demo Alojamiento Prueba', '902202122', 'TipoPrueba', 'www.webPrueba.com', '0');", conex)

        'Limpiar datos del groupbox
        For Each control In Me.Controls
            If TypeOf control Is GroupBox Then
                For Each groubox In control.controls
                    CType(groubox, TextBox).Clear()
                Next
            End If
        Next
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        'Dim tabla As New DataTable()
        'adapter.Fill(tabla)
        'DataGridAlojamientos.DataSource = tabla
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiposAloj.SelectedIndexChanged
        Dim lista As New DataSet()
        daTipoAloj.Fill(lista)
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