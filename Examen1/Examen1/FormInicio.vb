Public Class FormInicio
    Dim usuario, password As String

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        Try
            If TextBoxUsuario.Text <> usuario Or TextBoxContrasena.Text <> password Then
                MsgBox("El Nombre o la Contraseña son incorrectos.", MessageBoxIcon.Error)
            Else
                FormIngresarPruebas.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarse.Click
        Try
            usuario = TextBoxUsuario.Text
            password = TextBoxContrasena.Text
            TextBoxUsuario.Clear()
            TextBoxContrasena.Clear()
            MsgBox("Usuario Registrado", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
