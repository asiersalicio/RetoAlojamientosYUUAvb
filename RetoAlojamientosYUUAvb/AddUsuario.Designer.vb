﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUsuario
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
        Me.gbDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.cbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.tbPassword2 = New System.Windows.Forms.TextBox()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.tbNick = New System.Windows.Forms.TextBox()
        Me.tbPassword1 = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbDatosUsuario.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosUsuario
        '
        Me.gbDatosUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.gbDatosUsuario.Controls.Add(Me.cbTipoUsuario)
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
        Me.gbDatosUsuario.Location = New System.Drawing.Point(71, 207)
        Me.gbDatosUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDatosUsuario.Name = "gbDatosUsuario"
        Me.gbDatosUsuario.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDatosUsuario.Size = New System.Drawing.Size(932, 249)
        Me.gbDatosUsuario.TabIndex = 35
        Me.gbDatosUsuario.TabStop = False
        '
        'cbTipoUsuario
        '
        Me.cbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoUsuario.FormattingEnabled = True
        Me.cbTipoUsuario.Items.AddRange(New Object() {"administrador", "cliente"})
        Me.cbTipoUsuario.Location = New System.Drawing.Point(420, 182)
        Me.cbTipoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTipoUsuario.Name = "cbTipoUsuario"
        Me.cbTipoUsuario.Size = New System.Drawing.Size(265, 28)
        Me.cbTipoUsuario.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Window
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 46)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.SystemColors.Window
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDni.Location = New System.Drawing.Point(8, 127)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(31, 17)
        Me.lblDni.TabIndex = 39
        Me.lblDni.Text = "DNI"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(591, 37)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaNac.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNac.Size = New System.Drawing.Size(150, 26)
        Me.dtpFechaNac.TabIndex = 5
        Me.dtpFechaNac.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
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
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(591, 118)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(332, 26)
        Me.tbEmail.TabIndex = 7
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.SystemColors.Window
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFechaNac.Location = New System.Drawing.Point(464, 46)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(119, 17)
        Me.lblFechaNac.TabIndex = 36
        Me.lblFechaNac.Text = "Fecha nacimiento"
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(79, 79)
        Me.tbApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(332, 26)
        Me.tbApellidos.TabIndex = 3
        Me.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(464, 82)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 35
        Me.lblTelefono.Text = "Teléfono"
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(79, 39)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(332, 26)
        Me.tbNombre.TabIndex = 2
        Me.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.BackColor = System.Drawing.SystemColors.Window
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(8, 86)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(65, 17)
        Me.lblApellidos.TabIndex = 34
        Me.lblApellidos.Text = "Apellidos"
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(591, 76)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(332, 26)
        Me.tbTelefono.TabIndex = 6
        Me.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDNI
        '
        Me.tbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDNI.Location = New System.Drawing.Point(79, 118)
        Me.tbDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(332, 26)
        Me.tbDNI.TabIndex = 4
        Me.tbDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.SystemColors.Window
        Me.gbLogin.Controls.Add(Me.tbPassword2)
        Me.gbLogin.Controls.Add(Me.lblPassword2)
        Me.gbLogin.Controls.Add(Me.tbNick)
        Me.gbLogin.Controls.Add(Me.tbPassword1)
        Me.gbLogin.Controls.Add(Me.lblNick)
        Me.gbLogin.Controls.Add(Me.lblPassword)
        Me.gbLogin.Location = New System.Drawing.Point(71, 37)
        Me.gbLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbLogin.Size = New System.Drawing.Size(932, 162)
        Me.gbLogin.TabIndex = 34
        Me.gbLogin.TabStop = False
        '
        'tbPassword2
        '
        Me.tbPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword2.Location = New System.Drawing.Point(384, 105)
        Me.tbPassword2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword2.Name = "tbPassword2"
        Me.tbPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword2.Size = New System.Drawing.Size(399, 26)
        Me.tbPassword2.TabIndex = 29
        Me.tbPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword2.Location = New System.Drawing.Point(147, 108)
        Me.lblPassword2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(197, 20)
        Me.lblPassword2.TabIndex = 30
        Me.lblPassword2.Text = "Confirmar contraseña:"
        Me.lblPassword2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbNick
        '
        Me.tbNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNick.Location = New System.Drawing.Point(384, 23)
        Me.tbNick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNick.Name = "tbNick"
        Me.tbNick.Size = New System.Drawing.Size(399, 26)
        Me.tbNick.TabIndex = 0
        Me.tbNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPassword1
        '
        Me.tbPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword1.Location = New System.Drawing.Point(384, 63)
        Me.tbPassword1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword1.Name = "tbPassword1"
        Me.tbPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword1.Size = New System.Drawing.Size(399, 26)
        Me.tbPassword1.TabIndex = 1
        Me.tbPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.BackColor = System.Drawing.SystemColors.Window
        Me.lblNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNick.Location = New System.Drawing.Point(147, 27)
        Me.lblNick.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(52, 20)
        Me.lblNick.TabIndex = 24
        Me.lblNick.Text = "Nick:"
        Me.lblNick.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(147, 66)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(111, 20)
        Me.lblPassword.TabIndex = 28
        Me.lblPassword.Text = "Contraseña:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(477, 480)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(133, 49)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(917, 508)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 31)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AddUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbDatosUsuario)
        Me.Controls.Add(Me.gbLogin)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddUsuario"
        Me.Text = "Añadir / Modificar Usuario"
        Me.gbDatosUsuario.ResumeLayout(False)
        Me.gbDatosUsuario.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosUsuario As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents tbNick As TextBox
    Friend WithEvents tbPassword1 As TextBox
    Friend WithEvents lblNick As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents cbTipoUsuario As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents tbPassword2 As TextBox
    Friend WithEvents lblPassword2 As Label
End Class
