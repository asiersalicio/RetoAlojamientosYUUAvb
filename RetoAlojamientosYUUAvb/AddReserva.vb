Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AddReserva
    Dim m As New Metodos
    Dim usuarioBBDD, passwordBBDD, servidor, baseDatos, modo As String
    Public modoRva As String
    Dim conex As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim campo As Control

    Private Sub AddReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioBBDD = ConfigurationManager.AppSettings.Get("UsuarioBBDD")
        passwordBBDD = ConfigurationManager.AppSettings.Get("PasswordBBDD")
        servidor = ConfigurationManager.AppSettings.Get("Servidor")
        baseDatos = ConfigurationManager.AppSettings.Get("BaseDatos")
        'conex = New MySqlConnection("Server=192.168.101.21; Database=retoalojamientos2; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")
        conex = New MySqlConnection("Server=" & servidor & "; Database=" & baseDatos & "; Uid=" & usuarioBBDD & "; Pwd=" & passwordBBDD & "")

        m.cargarTipos("talojamientos", "lodgingtype", cbTipoAlojamiento)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        m.cambioVentana(Me, GestionReservas)
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

    Private Sub CbTipoAlojamiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoAlojamiento.SelectedIndexChanged

    End Sub

    Private Sub datosAloj(campo As String)
        ds = New DataSet
        da = New MySqlDataAdapter
        cmd = New MySqlCommand("SELECT DISTINCT documentname, municipality, address, phone, web FROM talojamientos WHERE lodgingtype=" & campo, conex)
        Dim arrayCampos = New Control() {cbAlojamiento, tbLocalidad, tbDireccion, tbTelefonoAloj, tbWeb}
        ds.Clear()
        da = New MySqlDataAdapter(cmd)

        cbAlojamiento.Text = arrayCampos(0).Text
        tbLocalidad.Text = arrayCampos(1).Text
        tbDireccion.Text = arrayCampos(2).Text
        tbTelefonoAloj.Text = arrayCampos(3).Text
        tbWeb.Text = arrayCampos(4).Text
    End Sub

    Public Sub datosCliente(campo As String)
        ds = New DataSet
        da = New MySqlDataAdapter
        Try
            conex.Open()
            cmd = New MySqlCommand("SELECT nombreUsuario, correo, telefono FROM usuario WHERE idDni='" & campo & "'", conex)
            cmd.ExecuteNonQuery()
            Dim arrayCampos2 = New Control() {tbNick, tbEmail, tbTelefonoUser}

            tbNick.Text = arrayCampos2(0).Text
            tbEmail.Text = arrayCampos2(1).Text
            tbTelefonoUser.Text = arrayCampos2(2).Text
            conex.Close()
        Catch ex As Exception
            conex.Close()
        End Try
    End Sub
End Class