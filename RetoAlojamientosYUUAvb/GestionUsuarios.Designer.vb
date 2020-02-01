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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.gbDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.tbTipoUsuario = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.tbNick = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnVerReservas = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosUsuario.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(825, 135)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(117, 25)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "X"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'tbBusqueda
        '
        Me.tbBusqueda.Location = New System.Drawing.Point(17, 135)
        Me.tbBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(799, 22)
        Me.tbBusqueda.TabIndex = 19
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(17, 167)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(925, 335)
        Me.dgvUsuarios.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Window
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 46)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.SystemColors.Window
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDni.Location = New System.Drawing.Point(8, 127)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(35, 17)
        Me.lblDni.TabIndex = 39
        Me.lblDni.Text = "DNI:"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTipoUsuario.Location = New System.Drawing.Point(321, 188)
        Me.lblTipoUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(91, 17)
        Me.lblTipoUsuario.TabIndex = 38
        Me.lblTipoUsuario.Text = "Tipo usuario:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Window
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblEmail.Location = New System.Drawing.Point(464, 124)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.SystemColors.Window
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFechaNac.Location = New System.Drawing.Point(464, 46)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(123, 17)
        Me.lblFechaNac.TabIndex = 36
        Me.lblFechaNac.Text = "Fecha nacimiento:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(464, 82)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefono.TabIndex = 35
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.BackColor = System.Drawing.SystemColors.Window
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(8, 86)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(69, 17)
        Me.lblApellidos.TabIndex = 34
        Me.lblApellidos.Text = "Apellidos:"
        '
        'gbDatosUsuario
        '
        Me.gbDatosUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.gbDatosUsuario.Controls.Add(Me.tbTipoUsuario)
        Me.gbDatosUsuario.Controls.Add(Me.lblNombre)
        Me.gbDatosUsuario.Controls.Add(Me.lblDni)
        Me.gbDatosUsuario.Controls.Add(Me.dtpFechaNac)
        Me.gbDatosUsuario.Controls.Add(Me.lblTipoUsuario)
        Me.gbDatosUsuario.Controls.Add(Me.lblEmail)
        Me.gbDatosUsuario.Controls.Add(Me.tbEmail)
        Me.gbDatosUsuario.Controls.Add(Me.lblFechaNac)
        Me.gbDatosUsuario.Controls.Add(Me.tbApellidos)
        Me.gbDatosUsuario.Controls.Add(Me.lblTelefono)
        Me.gbDatosUsuario.Controls.Add(Me.tbNombre)
        Me.gbDatosUsuario.Controls.Add(Me.lblApellidos)
        Me.gbDatosUsuario.Controls.Add(Me.tbTelefono)
        Me.gbDatosUsuario.Controls.Add(Me.tbDNI)
        Me.gbDatosUsuario.Location = New System.Drawing.Point(1096, 254)
        Me.gbDatosUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDatosUsuario.Name = "gbDatosUsuario"
        Me.gbDatosUsuario.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDatosUsuario.Size = New System.Drawing.Size(932, 249)
        Me.gbDatosUsuario.TabIndex = 33
        Me.gbDatosUsuario.TabStop = False
        '
        'tbTipoUsuario
        '
        Me.tbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoUsuario.Location = New System.Drawing.Point(420, 182)
        Me.tbTipoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTipoUsuario.Name = "tbTipoUsuario"
        Me.tbTipoUsuario.Size = New System.Drawing.Size(265, 26)
        Me.tbTipoUsuario.TabIndex = 43
        Me.tbTipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Enabled = False
        Me.dtpFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Location = New System.Drawing.Point(591, 37)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaNac.MaxDate = New Date(2020, 1, 20, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNac.Size = New System.Drawing.Size(332, 26)
        Me.dtpFechaNac.TabIndex = 11
        Me.dtpFechaNac.Value = New Date(2020, 1, 16, 12, 44, 46, 0)
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(591, 118)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(332, 26)
        Me.tbEmail.TabIndex = 41
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(79, 79)
        Me.tbApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(332, 26)
        Me.tbApellidos.TabIndex = 14
        Me.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(79, 39)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(332, 26)
        Me.tbNombre.TabIndex = 13
        Me.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(591, 76)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(332, 26)
        Me.tbTelefono.TabIndex = 13
        Me.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDNI
        '
        Me.tbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNI.Location = New System.Drawing.Point(79, 118)
        Me.tbDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(332, 26)
        Me.tbDNI.TabIndex = 12
        Me.tbDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.SystemColors.Window
        Me.gbLogin.Controls.Add(Me.tbNick)
        Me.gbLogin.Controls.Add(Me.tbPassword)
        Me.gbLogin.Controls.Add(Me.lblNick)
        Me.gbLogin.Controls.Add(Me.lblPassword)
        Me.gbLogin.Location = New System.Drawing.Point(1096, 135)
        Me.gbLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogin.Size = New System.Drawing.Size(932, 111)
        Me.gbLogin.TabIndex = 32
        Me.gbLogin.TabStop = False
        '
        'tbNick
        '
        Me.tbNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.Location = New System.Drawing.Point(321, 23)
        Me.tbNick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.Size = New System.Drawing.Size(399, 26)
        Me.tbNick.TabIndex = 9
        Me.tbNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(321, 63)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(399, 26)
        Me.tbPassword.TabIndex = 10
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.SystemColors.Window
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNick.Location = New System.Drawing.Point(171, 27)
        Me.lblNick.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(52, 20)
        Me.lblNick.TabIndex = 24
        Me.lblNick.Text = "Nick:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(171, 66)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(111, 20)
        Me.lblPassword.TabIndex = 28
        Me.lblPassword.Text = "Contraseña:"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(951, 396)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 106)
        Me.btnBorrar.TabIndex = 46
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(951, 281)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 106)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(951, 167)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 106)
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(17, 575)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(133, 31)
        Me.btnVolver.TabIndex = 48
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1895, 575)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 31)
        Me.btnSalir.TabIndex = 47
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1895, 91)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(133, 31)
        Me.btnLogout.TabIndex = 49
        Me.btnLogout.Text = "Desconectar"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnVerReservas
        '
        Me.btnVerReservas.Location = New System.Drawing.Point(17, 510)
        Me.btnVerReservas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerReservas.Name = "btnVerReservas"
        Me.btnVerReservas.Size = New System.Drawing.Size(925, 31)
        Me.btnVerReservas.TabIndex = 50
        Me.btnVerReservas.Text = "Ver Reservas"
        Me.btnVerReservas.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 620)
        Me.Controls.Add(Me.btnVerReservas)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.gbDatosUsuario)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GestionUsuarios"
        Me.Text = "Gestión de Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosUsuario.ResumeLayout(False)
        Me.gbDatosUsuario.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents tbBusqueda As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents gbDatosUsuario As GroupBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents tbNick As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblNick As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents tbTipoUsuario As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnVerReservas As Button
End Class
