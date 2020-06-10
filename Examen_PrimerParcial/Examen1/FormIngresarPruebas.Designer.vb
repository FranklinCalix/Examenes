<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresarPruebas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxEdad = New System.Windows.Forms.TextBox()
        Me.TextBoxMunicipio = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ComboBoxResultado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxDepartamento = New System.Windows.Forms.ComboBox()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.ComboBoxReporte = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxFallecidos = New System.Windows.Forms.TextBox()
        Me.TextBoxActivos = New System.Windows.Forms.TextBox()
        Me.TextBoxRecuperados = New System.Windows.Forms.TextBox()
        Me.ListBoxLista = New System.Windows.Forms.ListBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.Red
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Location = New System.Drawing.Point(171, 304)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 0
        Me.ButtonSalir.Text = "&Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Municipio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Resultado"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(95, 22)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxNombre.TabIndex = 6
        '
        'TextBoxEdad
        '
        Me.TextBoxEdad.Location = New System.Drawing.Point(95, 48)
        Me.TextBoxEdad.Name = "TextBoxEdad"
        Me.TextBoxEdad.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxEdad.TabIndex = 7
        '
        'TextBoxMunicipio
        '
        Me.TextBoxMunicipio.Location = New System.Drawing.Point(95, 101)
        Me.TextBoxMunicipio.Name = "TextBoxMunicipio"
        Me.TextBoxMunicipio.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxMunicipio.TabIndex = 9
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(95, 181)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(139, 59)
        Me.TextBoxDescripcion.TabIndex = 10
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ComboBoxResultado
        '
        Me.ComboBoxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxResultado.FormattingEnabled = True
        Me.ComboBoxResultado.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.ComboBoxResultado.Location = New System.Drawing.Point(95, 127)
        Me.ComboBoxResultado.Name = "ComboBoxResultado"
        Me.ComboBoxResultado.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxResultado.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descripcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDepartamento)
        Me.GroupBox1.Controls.Add(Me.ButtonRegistrar)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEstado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxResultado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxMunicipio)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.TextBoxEdad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 286)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Caso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Estado actual"
        '
        'ComboBoxDepartamento
        '
        Me.ComboBoxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDepartamento.FormattingEnabled = True
        Me.ComboBoxDepartamento.Items.AddRange(New Object() {"01 Atlántida", "02 Choluteca", "03 Colón", "04 Comayagua", "05 Copán", "06 Cortés", "07 El Paraíso", "08 Francisco Morazán", "09 Gracias a Dios", "10 Intibucá", "11 Islas de la Bahía", "12 La Paz", "13 Lempira", "14 Ocotepeque", "15 Olancho", "16 Santa Bárbara", "17 Valle", "18 Yoro"})
        Me.ComboBoxDepartamento.Location = New System.Drawing.Point(95, 74)
        Me.ComboBoxDepartamento.Name = "ComboBoxDepartamento"
        Me.ComboBoxDepartamento.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxDepartamento.TabIndex = 16
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Location = New System.Drawing.Point(159, 257)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistrar.TabIndex = 15
        Me.ButtonRegistrar.Text = "&Registrar"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstado.Enabled = False
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Activo", "Recuperado", "Fallecido"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(95, 154)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxEstado.TabIndex = 14
        '
        'ComboBoxReporte
        '
        Me.ComboBoxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReporte.FormattingEnabled = True
        Me.ComboBoxReporte.Items.AddRange(New Object() {"01 Atlántida", "02 Choluteca", "03 Colón", "04 Comayagua", "05 Copán", "06 Cortés", "07 El Paraíso", "08 Francisco Morazán", "09 Gracias a Dios", "10 Intibucá", "11 Islas de la Bahía", "12 La Paz", "13 Lempira", "14 Ocotepeque", "15 Olancho", "16 Santa Bárbara", "17 Valle", "18 Yoro"})
        Me.ComboBoxReporte.Location = New System.Drawing.Point(89, 21)
        Me.ComboBoxReporte.Name = "ComboBoxReporte"
        Me.ComboBoxReporte.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxReporte.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBoxLista)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 164)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ComboBoxReporte)
        Me.GroupBox3.Controls.Add(Me.TextBoxFallecidos)
        Me.GroupBox3.Controls.Add(Me.TextBoxActivos)
        Me.GroupBox3.Controls.Add(Me.TextBoxRecuperados)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 126)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Casos Por Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Activos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Recuperados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fallecidos"
        '
        'TextBoxFallecidos
        '
        Me.TextBoxFallecidos.Location = New System.Drawing.Point(89, 100)
        Me.TextBoxFallecidos.Name = "TextBoxFallecidos"
        Me.TextBoxFallecidos.ReadOnly = True
        Me.TextBoxFallecidos.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxFallecidos.TabIndex = 21
        '
        'TextBoxActivos
        '
        Me.TextBoxActivos.Location = New System.Drawing.Point(89, 48)
        Me.TextBoxActivos.Name = "TextBoxActivos"
        Me.TextBoxActivos.ReadOnly = True
        Me.TextBoxActivos.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxActivos.TabIndex = 17
        '
        'TextBoxRecuperados
        '
        Me.TextBoxRecuperados.Location = New System.Drawing.Point(89, 74)
        Me.TextBoxRecuperados.Name = "TextBoxRecuperados"
        Me.TextBoxRecuperados.ReadOnly = True
        Me.TextBoxRecuperados.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxRecuperados.TabIndex = 20
        '
        'ListBoxLista
        '
        Me.ListBoxLista.FormattingEnabled = True
        Me.ListBoxLista.HorizontalScrollbar = True
        Me.ListBoxLista.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxLista.Name = "ListBoxLista"
        Me.ListBoxLista.ScrollAlwaysVisible = True
        Me.ListBoxLista.Size = New System.Drawing.Size(235, 134)
        Me.ListBoxLista.TabIndex = 23
        '
        'FormIngresarPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Name = "FormIngresarPruebas"
        Me.Text = "Ingresar Pruebas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxMunicipio As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ComboBoxResultado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents ComboBoxDepartamento As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxReporte As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxFallecidos As TextBox
    Friend WithEvents TextBoxRecuperados As TextBox
    Friend WithEvents TextBoxActivos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBoxLista As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolTip As ToolTip
End Class
