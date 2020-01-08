Public Class Login
    Dim m As New Metodos
    Private usuario As String = "admin"
    Private password As String = "123"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'm.pantallaCompleta()

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Try
            If (tbUsuario.Text = "") Then
                MsgBox("Debe introducir un nombre de usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            ElseIf (tbPassword.Text = "") Then
                MsgBox("Debe introducir una contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Atención!")
            Else
                If (tbUsuario.Text = usuario And tbPassword.Text = password) Then
                    m.Acceder()
                Else
                    MsgBox("Los datos introducidos no son correctos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "¡Atención!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub TbUsuario_Click(sender As Object, e As EventArgs) Handles tbUsuario.Click

    End Sub
End Class
