Public Class GestionAlojamientos
    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class