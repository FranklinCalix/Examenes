﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxContrasena = New System.Windows.Forms.TextBox()
        Me.ButtonIniciar = New System.Windows.Forms.Button()
        Me.ButtonRegistrarse = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(101, 35)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxContrasena
        '
        Me.TextBoxContrasena.Location = New System.Drawing.Point(101, 61)
        Me.TextBoxContrasena.Name = "TextBoxContrasena"
        Me.TextBoxContrasena.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxContrasena.TabIndex = 3
        '
        'ButtonIniciar
        '
        Me.ButtonIniciar.Location = New System.Drawing.Point(109, 96)
        Me.ButtonIniciar.Name = "ButtonIniciar"
        Me.ButtonIniciar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIniciar.TabIndex = 4
        Me.ButtonIniciar.Text = "&Iniciar"
        Me.ButtonIniciar.UseVisualStyleBackColor = True
        '
        'ButtonRegistrarse
        '
        Me.ButtonRegistrarse.Location = New System.Drawing.Point(109, 125)
        Me.ButtonRegistrarse.Name = "ButtonRegistrarse"
        Me.ButtonRegistrarse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistrarse.TabIndex = 5
        Me.ButtonRegistrarse.Text = "&Registrarse"
        Me.ButtonRegistrarse.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 183)
        Me.Controls.Add(Me.ButtonRegistrarse)
        Me.Controls.Add(Me.ButtonIniciar)
        Me.Controls.Add(Me.TextBoxContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInicio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxContrasena As TextBox
    Friend WithEvents ButtonIniciar As Button
    Friend WithEvents ButtonRegistrarse As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
