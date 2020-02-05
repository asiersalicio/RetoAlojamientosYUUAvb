<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReserva
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbRvaAlojamiento = New System.Windows.Forms.GroupBox()
        Me.tbWeb = New System.Windows.Forms.TextBox()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.tbTelefonoAloj = New System.Windows.Forms.TextBox()
        Me.lblTelefonoAloj = New System.Windows.Forms.Label()
        Me.cbAlojamiento = New System.Windows.Forms.ComboBox()
        Me.cbTipoAlojamiento = New System.Windows.Forms.ComboBox()
        Me.lblIdAlojamiento = New System.Windows.Forms.Label()
        Me.lblTipoAloj = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.tbLocalidad = New System.Windows.Forms.TextBox()
        Me.gbReserva = New System.Windows.Forms.GroupBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.lblIdReserva = New System.Windows.Forms.Label()
        Me.tbIdReserva = New System.Windows.Forms.TextBox()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.gbRvaCliente = New System.Windows.Forms.GroupBox()
        Me.tbNick = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbTelefonoUser = New System.Windows.Forms.TextBox()
        Me.lblTelefonoUser = New System.Windows.Forms.Label()
        Me.tbApellidosUser = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.tbNombreUser = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.gbRvaAlojamiento.SuspendLayout()
        Me.gbReserva.SuspendLayout()
        Me.gbRvaCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(338, 389)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(668, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbRvaAlojamiento
        '
        Me.gbRvaAlojamiento.BackColor = System.Drawing.SystemColors.Window
        Me.gbRvaAlojamiento.Controls.Add(Me.tbWeb)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblWeb)
        Me.gbRvaAlojamiento.Controls.Add(Me.tbTelefonoAloj)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblTelefonoAloj)
        Me.gbRvaAlojamiento.Controls.Add(Me.cbAlojamiento)
        Me.gbRvaAlojamiento.Controls.Add(Me.cbTipoAlojamiento)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblIdAlojamiento)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblTipoAloj)
        Me.gbRvaAlojamiento.Controls.Add(Me.tbDireccion)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblMunicipio)
        Me.gbRvaAlojamiento.Controls.Add(Me.lblDireccion)
        Me.gbRvaAlojamiento.Controls.Add(Me.tbLocalidad)
        Me.gbRvaAlojamiento.Location = New System.Drawing.Point(12, 163)
        Me.gbRvaAlojamiento.Name = "gbRvaAlojamiento"
        Me.gbRvaAlojamiento.Size = New System.Drawing.Size(383, 220)
        Me.gbRvaAlojamiento.TabIndex = 38
        Me.gbRvaAlojamiento.TabStop = False
        '
        'tbWeb
        '
        Me.tbWeb.BackColor = System.Drawing.SystemColors.Window
        Me.tbWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWeb.Location = New System.Drawing.Point(120, 173)
        Me.tbWeb.Name = "tbWeb"
        Me.tbWeb.ReadOnly = True
        Me.tbWeb.Size = New System.Drawing.Size(250, 23)
        Me.tbWeb.TabIndex = 8
        Me.tbWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(6, 176)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(37, 17)
        Me.lblWeb.TabIndex = 24
        Me.lblWeb.Text = "Web"
        '
        'tbTelefonoAloj
        '
        Me.tbTelefonoAloj.BackColor = System.Drawing.SystemColors.Window
        Me.tbTelefonoAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefonoAloj.Location = New System.Drawing.Point(120, 140)
        Me.tbTelefonoAloj.Name = "tbTelefonoAloj"
        Me.tbTelefonoAloj.ReadOnly = True
        Me.tbTelefonoAloj.Size = New System.Drawing.Size(250, 23)
        Me.tbTelefonoAloj.TabIndex = 7
        Me.tbTelefonoAloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTelefonoAloj
        '
        Me.lblTelefonoAloj.AutoSize = True
        Me.lblTelefonoAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoAloj.Location = New System.Drawing.Point(6, 143)
        Me.lblTelefonoAloj.Name = "lblTelefonoAloj"
        Me.lblTelefonoAloj.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefonoAloj.TabIndex = 22
        Me.lblTelefonoAloj.Text = "Teléfono"
        '
        'cbAlojamiento
        '
        Me.cbAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlojamiento.FormattingEnabled = True
        Me.cbAlojamiento.Location = New System.Drawing.Point(120, 45)
        Me.cbAlojamiento.Name = "cbAlojamiento"
        Me.cbAlojamiento.Size = New System.Drawing.Size(250, 24)
        Me.cbAlojamiento.TabIndex = 3
        '
        'cbTipoAlojamiento
        '
        Me.cbTipoAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoAlojamiento.FormattingEnabled = True
        Me.cbTipoAlojamiento.Location = New System.Drawing.Point(120, 13)
        Me.cbTipoAlojamiento.Name = "cbTipoAlojamiento"
        Me.cbTipoAlojamiento.Size = New System.Drawing.Size(250, 24)
        Me.cbTipoAlojamiento.TabIndex = 4
        '
        'lblIdAlojamiento
        '
        Me.lblIdAlojamiento.AutoSize = True
        Me.lblIdAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAlojamiento.Location = New System.Drawing.Point(6, 48)
        Me.lblIdAlojamiento.Name = "lblIdAlojamiento"
        Me.lblIdAlojamiento.Size = New System.Drawing.Size(81, 17)
        Me.lblIdAlojamiento.TabIndex = 6
        Me.lblIdAlojamiento.Text = "Alojamiento"
        '
        'lblTipoAloj
        '
        Me.lblTipoAloj.AutoSize = True
        Me.lblTipoAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAloj.Location = New System.Drawing.Point(6, 16)
        Me.lblTipoAloj.Name = "lblTipoAloj"
        Me.lblTipoAloj.Size = New System.Drawing.Size(69, 17)
        Me.lblTipoAloj.TabIndex = 7
        Me.lblTipoAloj.Text = "Categoría"
        '
        'tbDireccion
        '
        Me.tbDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(120, 109)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.ReadOnly = True
        Me.tbDireccion.Size = New System.Drawing.Size(250, 23)
        Me.tbDireccion.TabIndex = 6
        Me.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipio.Location = New System.Drawing.Point(6, 80)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(69, 17)
        Me.lblMunicipio.TabIndex = 10
        Me.lblMunicipio.Text = "Localidad"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(6, 112)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblDireccion.TabIndex = 16
        Me.lblDireccion.Text = "Dirección"
        '
        'tbLocalidad
        '
        Me.tbLocalidad.BackColor = System.Drawing.SystemColors.Window
        Me.tbLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocalidad.Location = New System.Drawing.Point(120, 77)
        Me.tbLocalidad.Name = "tbLocalidad"
        Me.tbLocalidad.ReadOnly = True
        Me.tbLocalidad.Size = New System.Drawing.Size(250, 23)
        Me.tbLocalidad.TabIndex = 5
        Me.tbLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbReserva
        '
        Me.gbReserva.BackColor = System.Drawing.SystemColors.Window
        Me.gbReserva.Controls.Add(Me.dtpSalida)
        Me.gbReserva.Controls.Add(Me.dtpEntrada)
        Me.gbReserva.Controls.Add(Me.lblIdReserva)
        Me.gbReserva.Controls.Add(Me.tbIdReserva)
        Me.gbReserva.Controls.Add(Me.lblSalida)
        Me.gbReserva.Controls.Add(Me.lblEntrada)
        Me.gbReserva.Location = New System.Drawing.Point(12, 12)
        Me.gbReserva.Name = "gbReserva"
        Me.gbReserva.Size = New System.Drawing.Size(776, 145)
        Me.gbReserva.TabIndex = 39
        Me.gbReserva.TabStop = False
        '
        'dtpSalida
        '
        Me.dtpSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSalida.Location = New System.Drawing.Point(367, 92)
        Me.dtpSalida.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpSalida.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpSalida.Size = New System.Drawing.Size(150, 23)
        Me.dtpSalida.TabIndex = 2
        Me.dtpSalida.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrada.Location = New System.Drawing.Point(367, 66)
        Me.dtpEntrada.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpEntrada.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpEntrada.Size = New System.Drawing.Size(150, 23)
        Me.dtpEntrada.TabIndex = 1
        Me.dtpEntrada.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'lblIdReserva
        '
        Me.lblIdReserva.AutoSize = True
        Me.lblIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdReserva.Location = New System.Drawing.Point(175, 22)
        Me.lblIdReserva.Name = "lblIdReserva"
        Me.lblIdReserva.Size = New System.Drawing.Size(138, 24)
        Me.lblIdReserva.TabIndex = 8
        Me.lblIdReserva.Text = "Nº de reserva"
        '
        'tbIdReserva
        '
        Me.tbIdReserva.BackColor = System.Drawing.SystemColors.Window
        Me.tbIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdReserva.Location = New System.Drawing.Point(326, 19)
        Me.tbIdReserva.Name = "tbIdReserva"
        Me.tbIdReserva.ReadOnly = True
        Me.tbIdReserva.Size = New System.Drawing.Size(250, 29)
        Me.tbIdReserva.TabIndex = 0
        Me.tbIdReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.Location = New System.Drawing.Point(217, 97)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(90, 17)
        Me.lblSalida.TabIndex = 15
        Me.lblSalida.Text = "Fecha Salida"
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.Location = New System.Drawing.Point(217, 71)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(101, 17)
        Me.lblEntrada.TabIndex = 14
        Me.lblEntrada.Text = "Fecha Entrada"
        '
        'gbRvaCliente
        '
        Me.gbRvaCliente.BackColor = System.Drawing.SystemColors.Window
        Me.gbRvaCliente.Controls.Add(Me.tbNick)
        Me.gbRvaCliente.Controls.Add(Me.lblNick)
        Me.gbRvaCliente.Controls.Add(Me.tbEmail)
        Me.gbRvaCliente.Controls.Add(Me.lblEmail)
        Me.gbRvaCliente.Controls.Add(Me.tbTelefonoUser)
        Me.gbRvaCliente.Controls.Add(Me.lblTelefonoUser)
        Me.gbRvaCliente.Controls.Add(Me.tbApellidosUser)
        Me.gbRvaCliente.Controls.Add(Me.lblApellidos)
        Me.gbRvaCliente.Controls.Add(Me.tbNombreUser)
        Me.gbRvaCliente.Controls.Add(Me.lblDni)
        Me.gbRvaCliente.Controls.Add(Me.Label5)
        Me.gbRvaCliente.Controls.Add(Me.tbDni)
        Me.gbRvaCliente.Location = New System.Drawing.Point(405, 163)
        Me.gbRvaCliente.Name = "gbRvaCliente"
        Me.gbRvaCliente.Size = New System.Drawing.Size(383, 220)
        Me.gbRvaCliente.TabIndex = 39
        Me.gbRvaCliente.TabStop = False
        '
        'tbNick
        '
        Me.tbNick.BackColor = System.Drawing.SystemColors.Window
        Me.tbNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.Location = New System.Drawing.Point(127, 13)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.ReadOnly = True
        Me.tbNick.Size = New System.Drawing.Size(250, 23)
        Me.tbNick.TabIndex = 9
        Me.tbNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNick.Location = New System.Drawing.Point(13, 16)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(35, 17)
        Me.lblNick.TabIndex = 22
        Me.lblNick.Text = "Nick"
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.SystemColors.Window
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(127, 45)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.ReadOnly = True
        Me.tbEmail.Size = New System.Drawing.Size(250, 23)
        Me.tbEmail.TabIndex = 10
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(12, 48)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 22
        Me.lblEmail.Text = "Email"
        '
        'tbTelefonoUser
        '
        Me.tbTelefonoUser.BackColor = System.Drawing.SystemColors.Window
        Me.tbTelefonoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefonoUser.Location = New System.Drawing.Point(127, 171)
        Me.tbTelefonoUser.Name = "tbTelefonoUser"
        Me.tbTelefonoUser.ReadOnly = True
        Me.tbTelefonoUser.Size = New System.Drawing.Size(250, 23)
        Me.tbTelefonoUser.TabIndex = 14
        Me.tbTelefonoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTelefonoUser
        '
        Me.lblTelefonoUser.AutoSize = True
        Me.lblTelefonoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoUser.Location = New System.Drawing.Point(13, 174)
        Me.lblTelefonoUser.Name = "lblTelefonoUser"
        Me.lblTelefonoUser.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefonoUser.TabIndex = 20
        Me.lblTelefonoUser.Text = "Teléfono"
        '
        'tbApellidosUser
        '
        Me.tbApellidosUser.BackColor = System.Drawing.SystemColors.Window
        Me.tbApellidosUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidosUser.Location = New System.Drawing.Point(127, 139)
        Me.tbApellidosUser.Name = "tbApellidosUser"
        Me.tbApellidosUser.ReadOnly = True
        Me.tbApellidosUser.Size = New System.Drawing.Size(250, 23)
        Me.tbApellidosUser.TabIndex = 13
        Me.tbApellidosUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(13, 142)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(65, 17)
        Me.lblApellidos.TabIndex = 18
        Me.lblApellidos.Text = "Apellidos"
        '
        'tbNombreUser
        '
        Me.tbNombreUser.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombreUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreUser.Location = New System.Drawing.Point(127, 107)
        Me.tbNombreUser.Name = "tbNombreUser"
        Me.tbNombreUser.ReadOnly = True
        Me.tbNombreUser.Size = New System.Drawing.Size(250, 23)
        Me.tbNombreUser.TabIndex = 12
        Me.tbNombreUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(13, 80)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(78, 17)
        Me.lblDni.TabIndex = 10
        Me.lblDni.Text = "DNI Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nombre"
        '
        'tbDni
        '
        Me.tbDni.BackColor = System.Drawing.SystemColors.Window
        Me.tbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDni.Location = New System.Drawing.Point(127, 77)
        Me.tbDni.Name = "tbDni"
        Me.tbDni.ReadOnly = True
        Me.tbDni.Size = New System.Drawing.Size(250, 23)
        Me.tbDni.TabIndex = 11
        Me.tbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbRvaCliente)
        Me.Controls.Add(Me.gbReserva)
        Me.Controls.Add(Me.gbRvaAlojamiento)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "AddReserva"
        Me.Text = "Añadir / Modificar Reserva"
        Me.gbRvaAlojamiento.ResumeLayout(False)
        Me.gbRvaAlojamiento.PerformLayout()
        Me.gbReserva.ResumeLayout(False)
        Me.gbReserva.PerformLayout()
        Me.gbRvaCliente.ResumeLayout(False)
        Me.gbRvaCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbRvaAlojamiento As GroupBox
    Friend WithEvents lblIdAlojamiento As Label
    Friend WithEvents lblTipoAloj As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents tbLocalidad As TextBox
    Friend WithEvents cbAlojamiento As ComboBox
    Friend WithEvents cbTipoAlojamiento As ComboBox
    Friend WithEvents gbReserva As GroupBox
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents lblIdReserva As Label
    Friend WithEvents tbIdReserva As TextBox
    Friend WithEvents lblSalida As Label
    Friend WithEvents lblEntrada As Label
    Friend WithEvents gbRvaCliente As GroupBox
    Friend WithEvents tbNombreUser As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDni As TextBox
    Friend WithEvents tbApellidosUser As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents tbWeb As TextBox
    Friend WithEvents lblWeb As Label
    Friend WithEvents tbTelefonoAloj As TextBox
    Friend WithEvents lblTelefonoAloj As Label
    Friend WithEvents tbNick As TextBox
    Friend WithEvents lblNick As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbTelefonoUser As TextBox
    Friend WithEvents lblTelefonoUser As Label
End Class
