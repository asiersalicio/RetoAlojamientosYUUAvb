Public Class MenuGestion
    Dim m As New Metodos
    Private Sub BtnGestionAlojamientos_Click(sender As Object, e As EventArgs) Handles btnGestionAlojamientos.Click
        m.cambioVentana(Me, GestionAlojamientos)
    End Sub

    Private Sub BtnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        m.cambioVentana(Me, GestionUsuarios)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        m.desconectar(MenuGestion.ActiveForm)
    End Sub

    Private Sub MenuGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabIndex = 0
    End Sub
End Class