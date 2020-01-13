<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAlojamiento
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.gbTAlojamientos = New System.Windows.Forms.GroupBox()
        Me.cbTiposAloj = New System.Windows.Forms.ComboBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbWeb = New System.Windows.Forms.TextBox()
        Me.tbCapacidad = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.gbTLocalizacion = New System.Windows.Forms.GroupBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbCodMunicipio = New System.Windows.Forms.TextBox()
        Me.tbCodPostal = New System.Windows.Forms.TextBox()
        Me.tbAltitud = New System.Windows.Forms.TextBox()
        Me.tbLocalidad = New System.Windows.Forms.TextBox()
        Me.tbLatitud = New System.Windows.Forms.TextBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCodPostal = New System.Windows.Forms.Label()
        Me.lblLatitud = New System.Windows.Forms.Label()
        Me.lblAltitud = New System.Windows.Forms.Label()
        Me.lblCodMunicipio = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.ConexionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbTAlojamientos.SuspendLayout()
        Me.gbTLocalizacion.SuspendLayout()
        CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(12, 84)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(101, 20)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Identificador:"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidad.Location = New System.Drawing.Point(12, 214)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(89, 20)
        Me.lblCapacidad.TabIndex = 1
        Me.lblCapacidad.Text = "Capacidad:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 246)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(11, 310)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(142, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(11, 278)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(11, 182)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(150, 20)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "Tipo de alojamiento:"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(11, 342)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(46, 20)
        Me.lblWeb.TabIndex = 7
        Me.lblWeb.Text = "Web:"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(6, 19)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(200, 26)
        Me.tbId.TabIndex = 9
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(6, 51)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(200, 26)
        Me.tbNombre.TabIndex = 10
        '
        'gbTAlojamientos
        '
        Me.gbTAlojamientos.Controls.Add(Me.cbTiposAloj)
        Me.gbTAlojamientos.Controls.Add(Me.tbDescripcion)
        Me.gbTAlojamientos.Controls.Add(Me.tbWeb)
        Me.gbTAlojamientos.Controls.Add(Me.tbCapacidad)
        Me.gbTAlojamientos.Controls.Add(Me.tbEmail)
        Me.gbTAlojamientos.Controls.Add(Me.tbTelefono)
        Me.gbTAlojamientos.Controls.Add(Me.tbId)
        Me.gbTAlojamientos.Controls.Add(Me.tbNombre)
        Me.gbTAlojamientos.Location = New System.Drawing.Point(167, 62)
        Me.gbTAlojamientos.Name = "gbTAlojamientos"
        Me.gbTAlojamientos.Size = New System.Drawing.Size(212, 320)
        Me.gbTAlojamientos.TabIndex = 11
        Me.gbTAlojamientos.TabStop = False
        '
        'cbTiposAloj
        '
        Me.cbTiposAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiposAloj.FormattingEnabled = True
        Me.cbTiposAloj.Location = New System.Drawing.Point(6, 120)
        Me.cbTiposAloj.Name = "cbTiposAloj"
        Me.cbTiposAloj.Size = New System.Drawing.Size(200, 28)
        Me.cbTiposAloj.TabIndex = 20
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(6, 186)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(200, 26)
        Me.tbDescripcion.TabIndex = 14
        '
        'tbWeb
        '
        Me.tbWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWeb.Location = New System.Drawing.Point(6, 282)
        Me.tbWeb.Name = "tbWeb"
        Me.tbWeb.Size = New System.Drawing.Size(200, 26)
        Me.tbWeb.TabIndex = 14
        '
        'tbCapacidad
        '
        Me.tbCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCapacidad.Location = New System.Drawing.Point(6, 154)
        Me.tbCapacidad.Name = "tbCapacidad"
        Me.tbCapacidad.Size = New System.Drawing.Size(200, 26)
        Me.tbCapacidad.TabIndex = 13
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(6, 250)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(200, 26)
        Me.tbEmail.TabIndex = 13
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(6, 218)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(200, 26)
        Me.tbTelefono.TabIndex = 12
        '
        'gbTLocalizacion
        '
        Me.gbTLocalizacion.Controls.Add(Me.tbDireccion)
        Me.gbTLocalizacion.Controls.Add(Me.tbCodMunicipio)
        Me.gbTLocalizacion.Controls.Add(Me.tbCodPostal)
        Me.gbTLocalizacion.Controls.Add(Me.tbAltitud)
        Me.gbTLocalizacion.Controls.Add(Me.tbLocalidad)
        Me.gbTLocalizacion.Controls.Add(Me.tbLatitud)
        Me.gbTLocalizacion.Location = New System.Drawing.Point(583, 62)
        Me.gbTLocalizacion.Name = "gbTLocalizacion"
        Me.gbTLocalizacion.Size = New System.Drawing.Size(212, 320)
        Me.gbTLocalizacion.TabIndex = 12
        Me.gbTLocalizacion.TabStop = False
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(6, 83)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(200, 26)
        Me.tbDireccion.TabIndex = 14
        '
        'tbCodMunicipio
        '
        Me.tbCodMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodMunicipio.Location = New System.Drawing.Point(6, 179)
        Me.tbCodMunicipio.Name = "tbCodMunicipio"
        Me.tbCodMunicipio.Size = New System.Drawing.Size(200, 26)
        Me.tbCodMunicipio.TabIndex = 14
        '
        'tbCodPostal
        '
        Me.tbCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodPostal.Location = New System.Drawing.Point(6, 51)
        Me.tbCodPostal.Name = "tbCodPostal"
        Me.tbCodPostal.Size = New System.Drawing.Size(200, 26)
        Me.tbCodPostal.TabIndex = 13
        '
        'tbAltitud
        '
        Me.tbAltitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAltitud.Location = New System.Drawing.Point(6, 147)
        Me.tbAltitud.Name = "tbAltitud"
        Me.tbAltitud.Size = New System.Drawing.Size(200, 26)
        Me.tbAltitud.TabIndex = 13
        '
        'tbLocalidad
        '
        Me.tbLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocalidad.Location = New System.Drawing.Point(6, 19)
        Me.tbLocalidad.Name = "tbLocalidad"
        Me.tbLocalidad.Size = New System.Drawing.Size(200, 26)
        Me.tbLocalidad.TabIndex = 12
        '
        'tbLatitud
        '
        Me.tbLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLatitud.Location = New System.Drawing.Point(6, 115)
        Me.tbLatitud.Name = "tbLatitud"
        Me.tbLatitud.Size = New System.Drawing.Size(200, 26)
        Me.tbLatitud.TabIndex = 12
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(426, 84)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(81, 20)
        Me.lblLocalidad.TabIndex = 13
        Me.lblLocalidad.Text = "Localidad:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(426, 148)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(79, 20)
        Me.lblDireccion.TabIndex = 14
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCodPostal
        '
        Me.lblCodPostal.AutoSize = True
        Me.lblCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPostal.Location = New System.Drawing.Point(426, 116)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(111, 20)
        Me.lblCodPostal.TabIndex = 15
        Me.lblCodPostal.Text = "Código Postal:"
        '
        'lblLatitud
        '
        Me.lblLatitud.AutoSize = True
        Me.lblLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatitud.Location = New System.Drawing.Point(426, 180)
        Me.lblLatitud.Name = "lblLatitud"
        Me.lblLatitud.Size = New System.Drawing.Size(62, 20)
        Me.lblLatitud.TabIndex = 16
        Me.lblLatitud.Text = "Latitud:"
        '
        'lblAltitud
        '
        Me.lblAltitud.AutoSize = True
        Me.lblAltitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltitud.Location = New System.Drawing.Point(426, 214)
        Me.lblAltitud.Name = "lblAltitud"
        Me.lblAltitud.Size = New System.Drawing.Size(58, 20)
        Me.lblAltitud.TabIndex = 17
        Me.lblAltitud.Text = "Altitud:"
        '
        'lblCodMunicipio
        '
        Me.lblCodMunicipio.AutoSize = True
        Me.lblCodMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMunicipio.Location = New System.Drawing.Point(426, 246)
        Me.lblCodMunicipio.Name = "lblCodMunicipio"
        Me.lblCodMunicipio.Size = New System.Drawing.Size(155, 20)
        Me.lblCodMunicipio.TabIndex = 19
        Me.lblCodMunicipio.Text = "Código de Municipio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(708, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(627, 408)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 30)
        Me.btnAñadir.TabIndex = 21
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'ConexionBindingSource
        '
        Me.ConexionBindingSource.DataSource = GetType(RetoAlojamientosYUUAvb.Conexion)
        '
        'AddAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblCodMunicipio)
        Me.Controls.Add(Me.lblAltitud)
        Me.Controls.Add(Me.lblLatitud)
        Me.Controls.Add(Me.lblCodPostal)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.gbTLocalizacion)
        Me.Controls.Add(Me.gbTAlojamientos)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCapacidad)
        Me.Controls.Add(Me.lblId)
        Me.Name = "AddAlojamiento"
        Me.Text = "Añadir Nuevo Alojamiento"
        Me.gbTAlojamientos.ResumeLayout(False)
        Me.gbTAlojamientos.PerformLayout()
        Me.gbTLocalizacion.ResumeLayout(False)
        Me.gbTLocalizacion.PerformLayout()
        CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblWeb As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents gbTAlojamientos As GroupBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbCapacidad As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbWeb As TextBox
    Friend WithEvents gbTLocalizacion As GroupBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbCodMunicipio As TextBox
    Friend WithEvents tbCodPostal As TextBox
    Friend WithEvents tbAltitud As TextBox
    Friend WithEvents tbLocalidad As TextBox
    Friend WithEvents tbLatitud As TextBox
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblCodPostal As Label
    Friend WithEvents lblLatitud As Label
    Friend WithEvents lblAltitud As Label
    Friend WithEvents lblCodMunicipio As Label
    Friend WithEvents cbTiposAloj As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents ConexionBindingSource As BindingSource
End Class
