Public Class MenuGestion
    Private Sub BtnGestionAlojamientos_Click(sender As Object, e As EventArgs) Handles btnGestionAlojamientos.Click
        Me.Hide()
        GestionAlojamientos.Show()
    End Sub

    Private Sub BtnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        Me.Hide()
        GestionUsuarios.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class