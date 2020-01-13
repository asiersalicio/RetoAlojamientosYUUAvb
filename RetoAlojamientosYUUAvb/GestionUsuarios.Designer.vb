<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionUsuarios
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.gbTLocalizacion = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.gbTAlojamientos = New System.Windows.Forms.GroupBox()
        Me.tbNick = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblNick = New System.Windows.Forms.Label()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTLocalizacion.SuspendLayout()
        Me.gbTAlojamientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(13, 414)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(94, 414)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(613, 23)
        Me.btnVer.TabIndex = 21
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(619, 110)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(88, 20)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "X"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'tbBusqueda
        '
        Me.tbBusqueda.Location = New System.Drawing.Point(13, 110)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(600, 20)
        Me.tbBusqueda.TabIndex = 19
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(713, 194)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 18
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(713, 165)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(713, 136)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 414)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.AllowUserToResizeRows = False
        Me.DataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.Location = New System.Drawing.Point(13, 136)
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUsuarios.Size = New System.Drawing.Size(694, 272)
        Me.DataGridUsuarios.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Window
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(1160, 141)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.SystemColors.Window
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDni.Location = New System.Drawing.Point(1160, 207)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(29, 13)
        Me.lblDni.TabIndex = 39
        Me.lblDni.Text = "DNI:"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTipoUsuario.Location = New System.Drawing.Point(1160, 337)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(68, 13)
        Me.lblTipoUsuario.TabIndex = 38
        Me.lblTipoUsuario.Text = "Tipo usuario:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Window
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblEmail.Location = New System.Drawing.Point(1160, 305)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.SystemColors.Window
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFechaNac.Location = New System.Drawing.Point(1160, 241)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(94, 13)
        Me.lblFechaNac.TabIndex = 36
        Me.lblFechaNac.Text = "Fecha nacimiento:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(1160, 271)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 35
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.BackColor = System.Drawing.SystemColors.Window
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(1160, 174)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lblApellidos.TabIndex = 34
        Me.lblApellidos.Text = "Apellidos:"
        '
        'gbTLocalizacion
        '
        Me.gbTLocalizacion.BackColor = System.Drawing.SystemColors.Window
        Me.gbTLocalizacion.Controls.Add(Me.dtpFechaNac)
        Me.gbTLocalizacion.Controls.Add(Me.cbTipoUsuario)
        Me.gbTLocalizacion.Controls.Add(Me.tbEmail)
        Me.gbTLocalizacion.Controls.Add(Me.tbApellidos)
        Me.gbTLocalizacion.Controls.Add(Me.tbNombre)
        Me.gbTLocalizacion.Controls.Add(Me.tbTelefono)
        Me.gbTLocalizacion.Controls.Add(Me.tbDNI)
        Me.gbTLocalizacion.Location = New System.Drawing.Point(1272, 125)
        Me.gbTLocalizacion.Name = "gbTLocalizacion"
        Me.gbTLocalizacion.Size = New System.Drawing.Size(212, 313)
        Me.gbTLocalizacion.TabIndex = 33
        Me.gbTLocalizacion.TabStop = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(6, 106)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNac.Size = New System.Drawing.Size(200, 26)
        Me.dtpFechaNac.TabIndex = 11
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoUsuario.Location = New System.Drawing.Point(6, 204)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(200, 28)
        Me.cbTipoUsuario.TabIndex = 42
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(6, 172)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(200, 26)
        Me.tbEmail.TabIndex = 41
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(6, 42)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(200, 26)
        Me.tbApellidos.TabIndex = 14
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(6, 10)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(200, 26)
        Me.tbNombre.TabIndex = 13
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(6, 138)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(200, 26)
        Me.tbTelefono.TabIndex = 13
        '
        'tbDNI
        '
        Me.tbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNI.Location = New System.Drawing.Point(6, 74)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(200, 26)
        Me.tbDNI.TabIndex = 12
        '
        'gbTAlojamientos
        '
        Me.gbTAlojamientos.BackColor = System.Drawing.SystemColors.Window
        Me.gbTAlojamientos.Controls.Add(Me.tbNick)
        Me.gbTAlojamientos.Controls.Add(Me.tbPassword)
        Me.gbTAlojamientos.Location = New System.Drawing.Point(910, 125)
        Me.gbTAlojamientos.Name = "gbTAlojamientos"
        Me.gbTAlojamientos.Size = New System.Drawing.Size(212, 313)
        Me.gbTAlojamientos.TabIndex = 32
        Me.gbTAlojamientos.TabStop = False
        '
        'tbNick
        '
        Me.tbNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.Location = New System.Drawing.Point(6, 108)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.Size = New System.Drawing.Size(200, 26)
        Me.tbNick.TabIndex = 9
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(6, 140)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(200, 26)
        Me.tbPassword.TabIndex = 10
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPassword.Location = New System.Drawing.Point(829, 273)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 13)
        Me.lblPassword.TabIndex = 28
        Me.lblPassword.Text = "Contraseña:"
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.SystemColors.Window
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNick.Location = New System.Drawing.Point(829, 241)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(32, 13)
        Me.lblNick.TabIndex = 24
        Me.lblNick.Text = "Nick:"
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 504)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.gbTLocalizacion)
        Me.Controls.Add(Me.gbTAlojamientos)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblNick)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "GestionUsuarios"
        Me.Text = "Gestión de Usuarios"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTLocalizacion.ResumeLayout(False)
        Me.gbTLocalizacion.PerformLayout()
        Me.gbTAlojamientos.ResumeLayout(False)
        Me.gbTAlojamientos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents tbBusqueda As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents gbTLocalizacion As GroupBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents gbTAlojamientos As GroupBox
    Friend WithEvents tbNick As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblNick As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents cbTipoUsuario As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
End Class
