﻿Public Class MenuGestion
    Dim m As New Metodos
    Private Sub BtnGestionAlojamientos_Click(sender As Object, e As EventArgs) Handles btnGestionAlojamientos.Click
        Me.Hide()
        GestionAlojamientos.Show()
    End Sub

    Private Sub BtnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        Me.Hide()
        GestionUsuarios.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        m.salir()
    End Sub
End Class