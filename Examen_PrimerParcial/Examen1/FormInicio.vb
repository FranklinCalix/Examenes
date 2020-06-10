Imports System.ComponentModel

Public Class FormInicio
    Dim usuario, password As String

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        Try
            If TextBoxUsuario.Text = "" Then
                MsgBox("No se ingreso el nombre del Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf TextBoxContrasena.Text = "" Then
                MsgBox("No se ingreso la contraseña del Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf UCase(TextBoxUsuario.Text) <> usuario Or TextBoxContrasena.Text <> password Then
                MsgBox("El Nombre o la Contraseña son incorrectos.", MessageBoxIcon.Error, "Error")
            ElseIf UCase(TextBoxUsuario.Text) = usuario Then
                FormIngresarPruebas.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles ButtonRegistrarse.Click
        Try
            If TextBoxUsuario.Text = "" Then
                MsgBox("No se ingreso un nombre para el Usuario", MessageBoxIcon.Warning, "Advertencia")
            ElseIf TextBoxContrasena.Text = "" Then
                MsgBox("No se ingreso una contraseña para el nuevo Usuario", MessageBoxIcon.Warning, "Advertencia")
            Else
                usuario = UCase(TextBoxUsuario.Text)
                password = TextBoxContrasena.Text
                TextBoxUsuario.Clear()
                TextBoxContrasena.Clear()
                MsgBox("Usuario Registrado", MessageBoxIcon.Information, "Informacion")
                ButtonIniciar.Enabled = True
                ButtonRegistrarse.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'validating
    Private Sub txtPassword_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxContrasena.Validating
        If TextBoxContrasena.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonIniciar.Enabled = False

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxUsuario.Validating
        If TextBoxUsuario.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub
End Class
