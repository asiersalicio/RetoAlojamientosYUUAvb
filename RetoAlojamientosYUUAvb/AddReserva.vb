Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddReserva
    Dim m As New Metodos
    Dim database, server, usuarioBBDD, passwordBBDD As String
    Dim conex As New MySqlConnection
    Dim cmd As MySqlCommand
    Public modo As String

    Private Sub AddReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server = ConfigurationManager.AppSettings.Get("Server")
        database = ConfigurationManager.AppSettings.Get("Database")
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        conex = New MySqlConnection("Server=" & server & "; Database=" & database & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        m.cargarTipos("talojamientos", "lodgingtype", cbTipoAlojamiento)

        da = New MySqlDataAdapter("SELECT DISTINCT lodgingtype FROM talojamientos WHERE idAlojamiento=(SELECT idAlojamiento FROM reserva WHERE idReserva=" & tbIdReserva.Text & ")", conex)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.cambioVentana(Me, GestionUsuarios)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        registrarReserva()
    End Sub

    Private Sub registrarReserva()
        Dim alojamiento As String = cbAlojamiento.GetItemText(cbAlojamiento.SelectedItem)
        Dim tipoAloj As String = cbTipoAlojamiento.GetItemText(cbTipoAlojamiento.SelectedItem)

        If (dtpEntrada.Text = "") Then
            MsgBox("Debe establecer una fecha de entrada/llegada", MsgBoxStyle.Information, "Ingresar fecha de entrada")
        ElseIf (dtpSalida.Text = "") Then
            MsgBox("Debe establecer una fecha de salida", MsgBoxStyle.Information, "Ingresar fecha de salida")
        ElseIf (cbAlojamiento.Text = "") Then
            MsgBox("Seleccione un alojamiento", MsgBoxStyle.Information, "Selección de alojamiento")
        ElseIf (cbTipoAlojamiento.Text = "") Then
            MsgBox("Seleccione el tipo de alojamiento", MsgBoxStyle.Information, "Selección de categoría")
        ElseIf (tbNombreUser.Text = "") Then
            MsgBox("Se debe indicar el nombre del cliente que realiza la reserva", MsgBoxStyle.Information, "Ingresar nombre")
        ElseIf (tbApellidosUser.Text = "") Then
            MsgBox("Se deben indicar los apellidos del cliente que realiza la reserva", MsgBoxStyle.Information, "Ingresar apellidos")
        ElseIf (tbTelefonoUser.TextLength <> 9 Or tbTelefonoAloj.TextLength <> 9) Then
            MsgBox("Se debe indicar un número de teléfono de contacto correcto", MsgBoxStyle.Information, "Ingresar teléfono")
        ElseIf (tbEmail.Text = "") Then
            MsgBox("Indique un correo electrónico de contacto", MsgBoxStyle.Information, "Ingresar email")
        Else
        End If
        cmd = conex.CreateCommand
        Try
            conex.Open()
            cmd.CommandType = CommandType.StoredProcedure

            'Datos de la Reserva
            cmd.Parameters.Add(New MySqlParameter("p_capacity", dtpEntrada.Text))
            cmd.Parameters.Add(New MySqlParameter("p_capacity", dtpSalida.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Se ingresaron correctamente los datos de la reserva ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Éxito!")
            conex.Close()

            m.limpiarCampos(gbReserva)
            m.limpiarCampos(gbRvaAlojamiento)
            m.limpiarCampos(gbRvaCliente)
            m.cambioVentana(Me, GestionUsuarios)
        Catch ex As Exception
            MsgBox(ex.Message)
            conex.Close()
        End Try
    End Sub
End Class