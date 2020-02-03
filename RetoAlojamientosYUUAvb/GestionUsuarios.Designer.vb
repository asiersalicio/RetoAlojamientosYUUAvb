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
        Me.components = New System.ComponentModel.Container()
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
        Me.btnBorrarUsuario = New System.Windows.Forms.Button()
        Me.btnEditUsuario = New System.Windows.Forms.Button()
        Me.btnAddUsuario = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvReservasUsuario = New System.Windows.Forms.DataGridView()
        Me.lblReservasUsuario = New System.Windows.Forms.Label()
        Me.btnBorrarReserva = New System.Windows.Forms.Button()
        Me.btnEditReserva = New System.Windows.Forms.Button()
        Me.btnAddReserva = New System.Windows.Forms.Button()
        Me.gbDatosReserva = New System.Windows.Forms.GroupBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.lblIdAlojamiento = New System.Windows.Forms.Label()
        Me.tbAlojamiento = New System.Windows.Forms.TextBox()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.lblNombreAlojamiento = New System.Windows.Forms.Label()
        Me.lblIdReserva = New System.Windows.Forms.Label()
        Me.tbIdReserva = New System.Windows.Forms.TextBox()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmAddUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmEditUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmBorrarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosUsuario.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        CType(Me.dgvReservasUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosReserva.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvUsuarios.Location = New System.Drawing.Point(13, 136)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(694, 272)
        Me.dgvUsuarios.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Window
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(6, 37)
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
        Me.lblDni.Location = New System.Drawing.Point(6, 103)
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
        Me.lblTipoUsuario.Location = New System.Drawing.Point(241, 153)
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
        Me.lblEmail.Location = New System.Drawing.Point(348, 101)
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
        Me.lblFechaNac.Location = New System.Drawing.Point(348, 37)
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
        Me.lblTelefono.Location = New System.Drawing.Point(348, 67)
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
        Me.lblApellidos.Location = New System.Drawing.Point(6, 70)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(52, 13)
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
        Me.gbDatosUsuario.Location = New System.Drawing.Point(822, 206)
        Me.gbDatosUsuario.Name = "gbDatosUsuario"
        Me.gbDatosUsuario.Size = New System.Drawing.Size(699, 202)
        Me.gbDatosUsuario.TabIndex = 33
        Me.gbDatosUsuario.TabStop = False
        '
        'tbTipoUsuario
        '
        Me.tbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoUsuario.Location = New System.Drawing.Point(315, 148)
        Me.tbTipoUsuario.Name = "tbTipoUsuario"
        Me.tbTipoUsuario.Size = New System.Drawing.Size(200, 23)
        Me.tbTipoUsuario.TabIndex = 43
        Me.tbTipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Enabled = False
        Me.dtpFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Location = New System.Drawing.Point(443, 30)
        Me.dtpFechaNac.MaxDate = New Date(2020, 1, 20, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNac.Size = New System.Drawing.Size(250, 23)
        Me.dtpFechaNac.TabIndex = 11
        Me.dtpFechaNac.Value = New Date(2020, 1, 16, 12, 44, 46, 0)
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(443, 96)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(250, 23)
        Me.tbEmail.TabIndex = 41
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(59, 64)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(250, 23)
        Me.tbApellidos.TabIndex = 14
        Me.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(59, 32)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(250, 23)
        Me.tbNombre.TabIndex = 13
        Me.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(443, 62)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(250, 23)
        Me.tbTelefono.TabIndex = 13
        Me.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDNI
        '
        Me.tbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNI.Location = New System.Drawing.Point(59, 96)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(250, 23)
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
        Me.gbLogin.Location = New System.Drawing.Point(822, 110)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(699, 90)
        Me.gbLogin.TabIndex = 32
        Me.gbLogin.TabStop = False
        '
        'tbNick
        '
        Me.tbNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.Location = New System.Drawing.Point(241, 19)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.Size = New System.Drawing.Size(300, 23)
        Me.tbNick.TabIndex = 9
        Me.tbNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(241, 51)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(300, 23)
        Me.tbPassword.TabIndex = 10
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.SystemColors.Window
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNick.Location = New System.Drawing.Point(128, 22)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(44, 17)
        Me.lblNick.TabIndex = 24
        Me.lblNick.Text = "Nick:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(128, 54)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(96, 17)
        Me.lblPassword.TabIndex = 28
        Me.lblPassword.Text = "Contraseña:"
        '
        'btnBorrarUsuario
        '
        Me.btnBorrarUsuario.Location = New System.Drawing.Point(713, 322)
        Me.btnBorrarUsuario.Name = "btnBorrarUsuario"
        Me.btnBorrarUsuario.Size = New System.Drawing.Size(75, 86)
        Me.btnBorrarUsuario.TabIndex = 46
        Me.btnBorrarUsuario.Text = "Borrar"
        Me.btnBorrarUsuario.UseVisualStyleBackColor = True
        '
        'btnEditUsuario
        '
        Me.btnEditUsuario.Location = New System.Drawing.Point(713, 228)
        Me.btnEditUsuario.Name = "btnEditUsuario"
        Me.btnEditUsuario.Size = New System.Drawing.Size(75, 86)
        Me.btnEditUsuario.TabIndex = 45
        Me.btnEditUsuario.Text = "Modificar"
        Me.btnEditUsuario.UseVisualStyleBackColor = True
        '
        'btnAddUsuario
        '
        Me.btnAddUsuario.Location = New System.Drawing.Point(713, 136)
        Me.btnAddUsuario.Name = "btnAddUsuario"
        Me.btnAddUsuario.Size = New System.Drawing.Size(75, 86)
        Me.btnAddUsuario.TabIndex = 44
        Me.btnAddUsuario.Text = "Añadir"
        Me.btnAddUsuario.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 758)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 25)
        Me.btnVolver.TabIndex = 48
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1421, 758)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 25)
        Me.btnSalir.TabIndex = 47
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1421, 74)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 25)
        Me.btnLogout.TabIndex = 49
        Me.btnLogout.Text = "Desconectar"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvReservasUsuario
        '
        Me.dgvReservasUsuario.AllowUserToAddRows = False
        Me.dgvReservasUsuario.AllowUserToDeleteRows = False
        Me.dgvReservasUsuario.AllowUserToResizeRows = False
        Me.dgvReservasUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReservasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservasUsuario.Location = New System.Drawing.Point(12, 457)
        Me.dgvReservasUsuario.MultiSelect = False
        Me.dgvReservasUsuario.Name = "dgvReservasUsuario"
        Me.dgvReservasUsuario.ReadOnly = True
        Me.dgvReservasUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasUsuario.Size = New System.Drawing.Size(694, 272)
        Me.dgvReservasUsuario.TabIndex = 50
        '
        'lblReservasUsuario
        '
        Me.lblReservasUsuario.AutoSize = True
        Me.lblReservasUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservasUsuario.Location = New System.Drawing.Point(12, 424)
        Me.lblReservasUsuario.Name = "lblReservasUsuario"
        Me.lblReservasUsuario.Size = New System.Drawing.Size(201, 24)
        Me.lblReservasUsuario.TabIndex = 51
        Me.lblReservasUsuario.Text = "Reservas de usuario"
        '
        'btnBorrarReserva
        '
        Me.btnBorrarReserva.Location = New System.Drawing.Point(713, 643)
        Me.btnBorrarReserva.Name = "btnBorrarReserva"
        Me.btnBorrarReserva.Size = New System.Drawing.Size(75, 86)
        Me.btnBorrarReserva.TabIndex = 54
        Me.btnBorrarReserva.Text = "Borrar"
        Me.btnBorrarReserva.UseVisualStyleBackColor = True
        '
        'btnEditReserva
        '
        Me.btnEditReserva.Location = New System.Drawing.Point(713, 549)
        Me.btnEditReserva.Name = "btnEditReserva"
        Me.btnEditReserva.Size = New System.Drawing.Size(75, 86)
        Me.btnEditReserva.TabIndex = 53
        Me.btnEditReserva.Text = "Modificar"
        Me.btnEditReserva.UseVisualStyleBackColor = True
        '
        'btnAddReserva
        '
        Me.btnAddReserva.Location = New System.Drawing.Point(713, 457)
        Me.btnAddReserva.Name = "btnAddReserva"
        Me.btnAddReserva.Size = New System.Drawing.Size(75, 86)
        Me.btnAddReserva.TabIndex = 52
        Me.btnAddReserva.Text = "Añadir"
        Me.btnAddReserva.UseVisualStyleBackColor = True
        '
        'gbDatosReserva
        '
        Me.gbDatosReserva.BackColor = System.Drawing.SystemColors.Window
        Me.gbDatosReserva.Controls.Add(Me.dtpSalida)
        Me.gbDatosReserva.Controls.Add(Me.dtpEntrada)
        Me.gbDatosReserva.Controls.Add(Me.lblIdAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.tbAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.tbCategoria)
        Me.gbDatosReserva.Controls.Add(Me.lblNombreAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.lblIdReserva)
        Me.gbDatosReserva.Controls.Add(Me.tbIdReserva)
        Me.gbDatosReserva.Controls.Add(Me.lblFechaSalida)
        Me.gbDatosReserva.Controls.Add(Me.lblFechaEntrada)
        Me.gbDatosReserva.Location = New System.Drawing.Point(822, 457)
        Me.gbDatosReserva.Name = "gbDatosReserva"
        Me.gbDatosReserva.Size = New System.Drawing.Size(699, 280)
        Me.gbDatosReserva.TabIndex = 55
        Me.gbDatosReserva.TabStop = False
        '
        'dtpSalida
        '
        Me.dtpSalida.Enabled = False
        Me.dtpSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalida.Location = New System.Drawing.Point(241, 124)
        Me.dtpSalida.MaxDate = New Date(2100, 12, 31, 23, 59, 0, 0)
        Me.dtpSalida.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpSalida.Size = New System.Drawing.Size(300, 23)
        Me.dtpSalida.TabIndex = 38
        Me.dtpSalida.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Enabled = False
        Me.dtpEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntrada.Location = New System.Drawing.Point(241, 92)
        Me.dtpEntrada.MaxDate = New Date(2020, 1, 28, 11, 57, 43, 0)
        Me.dtpEntrada.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpEntrada.Size = New System.Drawing.Size(300, 23)
        Me.dtpEntrada.TabIndex = 37
        Me.dtpEntrada.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'lblIdAlojamiento
        '
        Me.lblIdAlojamiento.AutoSize = True
        Me.lblIdAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAlojamiento.Location = New System.Drawing.Point(130, 189)
        Me.lblIdAlojamiento.Name = "lblIdAlojamiento"
        Me.lblIdAlojamiento.Size = New System.Drawing.Size(81, 17)
        Me.lblIdAlojamiento.TabIndex = 6
        Me.lblIdAlojamiento.Text = "Alojamiento"
        '
        'tbAlojamiento
        '
        Me.tbAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlojamiento.Location = New System.Drawing.Point(244, 186)
        Me.tbAlojamiento.Name = "tbAlojamiento"
        Me.tbAlojamiento.Size = New System.Drawing.Size(300, 23)
        Me.tbAlojamiento.TabIndex = 4
        Me.tbAlojamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCategoria
        '
        Me.tbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCategoria.Location = New System.Drawing.Point(244, 215)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.Size = New System.Drawing.Size(300, 23)
        Me.tbCategoria.TabIndex = 5
        Me.tbCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombreAlojamiento
        '
        Me.lblNombreAlojamiento.AutoSize = True
        Me.lblNombreAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAlojamiento.Location = New System.Drawing.Point(130, 218)
        Me.lblNombreAlojamiento.Name = "lblNombreAlojamiento"
        Me.lblNombreAlojamiento.Size = New System.Drawing.Size(69, 17)
        Me.lblNombreAlojamiento.TabIndex = 7
        Me.lblNombreAlojamiento.Text = "Categoría"
        '
        'lblIdReserva
        '
        Me.lblIdReserva.AutoSize = True
        Me.lblIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdReserva.Location = New System.Drawing.Point(128, 22)
        Me.lblIdReserva.Name = "lblIdReserva"
        Me.lblIdReserva.Size = New System.Drawing.Size(113, 17)
        Me.lblIdReserva.TabIndex = 8
        Me.lblIdReserva.Text = "Nº de Reserva"
        '
        'tbIdReserva
        '
        Me.tbIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdReserva.Location = New System.Drawing.Point(241, 19)
        Me.tbIdReserva.Name = "tbIdReserva"
        Me.tbIdReserva.Size = New System.Drawing.Size(300, 23)
        Me.tbIdReserva.TabIndex = 9
        Me.tbIdReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalida.Location = New System.Drawing.Point(127, 124)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(90, 17)
        Me.lblFechaSalida.TabIndex = 15
        Me.lblFechaSalida.Text = "Fecha Salida"
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(127, 95)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(101, 17)
        Me.lblFechaEntrada.TabIndex = 14
        Me.lblFechaEntrada.Text = "Fecha Entrada"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmAddUsuario, Me.cmEditUsuario, Me.cmBorrarUsuario})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 70)
        '
        'cmAddUsuario
        '
        Me.cmAddUsuario.Name = "cmAddUsuario"
        Me.cmAddUsuario.Size = New System.Drawing.Size(189, 22)
        Me.cmAddUsuario.Text = "Añadir usuario"
        '
        'cmEditUsuario
        '
        Me.cmEditUsuario.Name = "cmEditUsuario"
        Me.cmEditUsuario.Size = New System.Drawing.Size(189, 22)
        Me.cmEditUsuario.Text = "Modificar usuario"
        '
        'cmBorrarUsuario
        '
        Me.cmBorrarUsuario.Name = "cmBorrarUsuario"
        Me.cmBorrarUsuario.Size = New System.Drawing.Size(189, 22)
        Me.cmBorrarUsuario.Text = "Borrar usuario"
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 795)
        Me.Controls.Add(Me.gbDatosReserva)
        Me.Controls.Add(Me.btnBorrarReserva)
        Me.Controls.Add(Me.btnEditReserva)
        Me.Controls.Add(Me.btnAddReserva)
        Me.Controls.Add(Me.lblReservasUsuario)
        Me.Controls.Add(Me.dgvReservasUsuario)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrarUsuario)
        Me.Controls.Add(Me.gbDatosUsuario)
        Me.Controls.Add(Me.btnEditUsuario)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.btnAddUsuario)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Name = "GestionUsuarios"
        Me.Text = "Gestión de Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosUsuario.ResumeLayout(False)
        Me.gbDatosUsuario.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.dgvReservasUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosReserva.ResumeLayout(False)
        Me.gbDatosReserva.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents btnBorrarUsuario As Button
    Friend WithEvents btnEditUsuario As Button
    Friend WithEvents btnAddUsuario As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvReservasUsuario As DataGridView
    Friend WithEvents lblReservasUsuario As Label
    Friend WithEvents btnBorrarReserva As Button
    Friend WithEvents btnEditReserva As Button
    Friend WithEvents btnAddReserva As Button
    Friend WithEvents gbDatosReserva As GroupBox
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents lblIdAlojamiento As Label
    Friend WithEvents tbAlojamiento As TextBox
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents lblNombreAlojamiento As Label
    Friend WithEvents lblIdReserva As Label
    Friend WithEvents tbIdReserva As TextBox
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents lblFechaEntrada As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cmAddUsuario As ToolStripMenuItem
    Friend WithEvents cmEditUsuario As ToolStripMenuItem
    Friend WithEvents cmBorrarUsuario As ToolStripMenuItem
End Class
