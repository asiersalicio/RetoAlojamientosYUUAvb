Public Class Metodos
    Public Sub Acceder()
        Login.Hide()
        MenuGestion.Show()
    End Sub

    Public Sub pantallaCompleta()
        'Pantalla Login
        Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Login.WindowState = FormWindowState.Maximized

        'Pantalla Menu de Gestion
        MenuGestion.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MenuGestion.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Alojamientos
        GestionAlojamientos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        GestionAlojamientos.WindowState = FormWindowState.Maximized

        'Pantalla Gestion de Usuarios
        GestionUsuarios.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        GestionUsuarios.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub salir()
        Dim resp = MsgBox("¿Desea realmente salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Sub addNuevoAlojamiento()

    End Sub
End Class
