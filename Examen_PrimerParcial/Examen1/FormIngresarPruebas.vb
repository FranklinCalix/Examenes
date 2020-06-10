Imports System.ComponentModel

Public Class FormIngresarPruebas
    Dim activos(18), recuperados(18), muertos(18), opcion, departamento As Integer

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try
            If TextBoxNombre.Text = "" Then
                MsgBox("No se introdujo un Nombre", MessageBoxIcon.Error, "Error")
            ElseIf TextBoxEdad.Text = "" Then
                MsgBox("No se ha especificado la edad", MessageBoxIcon.Error, "Error")
            ElseIf Not IsNumeric(TextBoxEdad.Text) Then
                MsgBox("Edad debe ser un numero", MessageBoxIcon.Error, "Error")
                TextBoxEdad.Text = ""
            ElseIf ComboBoxDepartamento.Text = "" Then
                MsgBox("No se ha seleccionado un departamento", MessageBoxIcon.Error, "Error")
            ElseIf TextBoxMunicipio.Text = "" Then
                MsgBox("No ha especificado Municipio", MessageBoxIcon.Error, "Error")
            ElseIf ComboBoxResultado.Text = "" Then
                MsgBox("No se ha seleccionado un resultado de la prueba", MessageBoxIcon.Error, "Error")
            ElseIf ComboBoxResultado.Text = "Positivo" And ComboBoxEstado.Text = "" Then
                MsgBox("No se ha seleccionado el estado del caso", MessageBoxIcon.Error, "Error")
            Else
                opcion = Mid(Val(ComboBoxDepartamento.Text), 1, 2)
                Select Case opcion
                    Case 1
                        departamento = 1
                    Case 2
                        departamento = 2
                    Case 3
                        departamento = 3
                    Case 4
                        departamento = 4
                    Case 5
                        departamento = 5
                    Case 6
                        departamento = 6
                    Case 7
                        departamento = 7
                    Case 8
                        departamento = 8
                    Case 9
                        departamento = 9
                    Case 10
                        departamento = 10
                    Case 11
                        departamento = 11
                    Case 12
                        departamento = 12
                    Case 13
                        departamento = 13
                    Case 14
                        departamento = 14
                    Case 15
                        departamento = 15
                    Case 16
                        departamento = 16
                    Case 17
                        departamento = 17
                    Case 18
                        departamento = 18
                End Select

                If ComboBoxResultado.Text = "Positivo" Then
                    If ComboBoxEstado.Text = "Activo" Then
                        activos(departamento) += 1
                    ElseIf ComboBoxEstado.Text = "Recuperado" Then
                        recuperados(departamento) += 1
                    ElseIf ComboBoxEstado.Text = "Fallecido" Then
                        muertos(departamento) += 1
                    End If
                    MsgBox("Registro Completo", MessageBoxIcon.Information, "Hecho")
                End If
                TextBoxEdad.Clear()
                TextBoxNombre.Clear()
                TextBoxMunicipio.Clear()
                TextBoxDescripcion.Clear()
                ComboBoxDepartamento.Refresh()



                ListBoxLista.Items.Add(TextBoxNombre.Text & " | " & TextBoxEdad.Text & " | " & Mid(ComboBoxDepartamento.Text, 4, 10) & " | " & TextBoxMunicipio.Text & " | " & ComboBoxResultado.Text & " | " & TextBoxDescripcion.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxNombre_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxNombre.Validating
        If TextBoxNombre.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub TextBoxEdad_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxEdad.Validating
        If TextBoxEdad.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        ElseIf Not IsNumeric(TextBoxEdad.Text) Then
            Me.ErrorProvider1.SetError(sender, "Debe ser un valor numerico")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub TextBoxMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxMunicipio.Validating
        If TextBoxMunicipio.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub TextBoxNombre_MouseHover(sender As Object, e As EventArgs) Handles TextBoxNombre.MouseHover
        ToolTip.SetToolTip(TextBoxNombre, "Ingrese el nombre del paciente")
    End Sub

    Private Sub TextBoxEdad_MouseHover(sender As Object, e As EventArgs) Handles TextBoxEdad.MouseHover
        ToolTip.SetToolTip(TextBoxEdad, "Ingrese la edad del paciente (enteros)")
    End Sub

    Private Sub TextBoxMunicipio_MouseHover(sender As Object, e As EventArgs) Handles TextBoxMunicipio.MouseHover
        ToolTip.SetToolTip(TextBoxMunicipio, "Ingrese el nombre del municipio al que pertenece el paciente")
    End Sub

    Private Sub TextBoxDescripcion_MouseHover(sender As Object, e As EventArgs) Handles TextBoxDescripcion.MouseHover
        ToolTip.SetToolTip(TextBoxDescripcion, "Ingrese una descripcion sobre el estado del paciente")
    End Sub

    Private Sub ComboBoxReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReporte.SelectedIndexChanged
        departamento = Mid(Val(ComboBoxReporte.Text), 1, 2)
        TextBoxActivos.Text = activos(departamento)
        TextBoxRecuperados.Text = recuperados(departamento)
        TextBoxFallecidos.Text = muertos(departamento)
    End Sub

    Private Sub ComboBoxResultado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxResultado.SelectedIndexChanged
        If ComboBoxResultado.Text = "Positivo" Then
            ComboBoxEstado.Enabled = True
        Else
            ComboBoxEstado.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxDepartamento.Validating
        If ComboBoxDepartamento.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub ComboBoxResultado_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxResultado.Validating
        If ComboBoxResultado.Text = "" Then
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub ComboBoxDepartamento_MouseHover(sender As Object, e As EventArgs) Handles ComboBoxDepartamento.MouseHover
        ToolTip.SetToolTip(ComboBoxDepartamento, "Seleccione el departamento al que pertenece el paciente")
    End Sub

    Private Sub ComboBoxResultado_MouseHover(sender As Object, e As EventArgs) Handles ComboBoxResultado.MouseHover
        ToolTip.SetToolTip(ComboBoxResultado, "Seleccione el resultado de la prueba en el paciente")
    End Sub

    Private Sub ComboBoxEstado_MouseHover(sender As Object, e As EventArgs) Handles ComboBoxEstado.MouseHover
        ToolTip.SetToolTip(ComboBoxEstado, "Estado en el que se encuentra el paciente")
    End Sub

    Private Sub ComboBoxReporte_MouseHover(sender As Object, e As EventArgs) Handles ComboBoxReporte.MouseHover
        ToolTip.SetToolTip(ComboBoxReporte, "Seleccione un departamento ver el reporte")
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Dim salir As MsgBoxResult = MsgBox("Esta seguro de querer salir?", MsgBoxStyle.YesNo, "Salir")
        If salir = MsgBoxResult.Yes Then
            End
        End If
    End Sub

End Class