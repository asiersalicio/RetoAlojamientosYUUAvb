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
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.cbTiposAloj = New System.Windows.Forms.ComboBox()
        Me.tbWeb = New System.Windows.Forms.TextBox()
        Me.tbCapacidad = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.gbTLocalizacion = New System.Windows.Forms.GroupBox()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.cbTerritorio = New System.Windows.Forms.ComboBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbCodMunicipio = New System.Windows.Forms.TextBox()
        Me.tbCodPostal = New System.Windows.Forms.TextBox()
        Me.tbLongitud = New System.Windows.Forms.TextBox()
        Me.tbLatitud = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCodPostal = New System.Windows.Forms.Label()
        Me.lblLatitud = New System.Windows.Forms.Label()
        Me.lblLongitud = New System.Windows.Forms.Label()
        Me.lblCodMunicipio = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ConexionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTerritorio = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
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
        Me.lblEmail.Location = New System.Drawing.Point(11, 360)
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
        Me.lblTelefono.Location = New System.Drawing.Point(11, 328)
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
        Me.lblWeb.Location = New System.Drawing.Point(11, 392)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(46, 20)
        Me.lblWeb.TabIndex = 7
        Me.lblWeb.Text = "Web:"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(6, 19)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(200, 23)
        Me.tbId.TabIndex = 9
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(6, 51)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(200, 23)
        Me.tbNombre.TabIndex = 10
        '
        'gbTAlojamientos
        '
        Me.gbTAlojamientos.Controls.Add(Me.rtbDescripcion)
        Me.gbTAlojamientos.Controls.Add(Me.cbTiposAloj)
        Me.gbTAlojamientos.Controls.Add(Me.tbWeb)
        Me.gbTAlojamientos.Controls.Add(Me.tbCapacidad)
        Me.gbTAlojamientos.Controls.Add(Me.tbEmail)
        Me.gbTAlojamientos.Controls.Add(Me.tbTelefono)
        Me.gbTAlojamientos.Controls.Add(Me.tbId)
        Me.gbTAlojamientos.Controls.Add(Me.tbNombre)
        Me.gbTAlojamientos.Location = New System.Drawing.Point(167, 62)
        Me.gbTAlojamientos.Name = "gbTAlojamientos"
        Me.gbTAlojamientos.Size = New System.Drawing.Size(212, 362)
        Me.gbTAlojamientos.TabIndex = 11
        Me.gbTAlojamientos.TabStop = False
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescripcion.Location = New System.Drawing.Point(6, 186)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(200, 61)
        Me.rtbDescripcion.TabIndex = 26
        Me.rtbDescripcion.Text = ""
        '
        'cbTiposAloj
        '
        Me.cbTiposAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiposAloj.FormattingEnabled = True
        Me.cbTiposAloj.Location = New System.Drawing.Point(6, 120)
        Me.cbTiposAloj.Name = "cbTiposAloj"
        Me.cbTiposAloj.Size = New System.Drawing.Size(200, 24)
        Me.cbTiposAloj.TabIndex = 20
        '
        'tbWeb
        '
        Me.tbWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWeb.Location = New System.Drawing.Point(6, 317)
        Me.tbWeb.Name = "tbWeb"
        Me.tbWeb.Size = New System.Drawing.Size(200, 23)
        Me.tbWeb.TabIndex = 14
        '
        'tbCapacidad
        '
        Me.tbCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCapacidad.Location = New System.Drawing.Point(6, 154)
        Me.tbCapacidad.Name = "tbCapacidad"
        Me.tbCapacidad.Size = New System.Drawing.Size(200, 23)
        Me.tbCapacidad.TabIndex = 13
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(6, 285)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(200, 23)
        Me.tbEmail.TabIndex = 13
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(6, 253)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(200, 23)
        Me.tbTelefono.TabIndex = 12
        '
        'gbTLocalizacion
        '
        Me.gbTLocalizacion.Controls.Add(Me.cbPais)
        Me.gbTLocalizacion.Controls.Add(Me.cbMunicipio)
        Me.gbTLocalizacion.Controls.Add(Me.cbTerritorio)
        Me.gbTLocalizacion.Controls.Add(Me.tbDireccion)
        Me.gbTLocalizacion.Controls.Add(Me.tbCodMunicipio)
        Me.gbTLocalizacion.Controls.Add(Me.tbCodPostal)
        Me.gbTLocalizacion.Controls.Add(Me.tbLongitud)
        Me.gbTLocalizacion.Controls.Add(Me.tbLatitud)
        Me.gbTLocalizacion.Location = New System.Drawing.Point(583, 62)
        Me.gbTLocalizacion.Name = "gbTLocalizacion"
        Me.gbTLocalizacion.Size = New System.Drawing.Size(212, 320)
        Me.gbTLocalizacion.TabIndex = 12
        Me.gbTLocalizacion.TabStop = False
        '
        'cbPais
        '
        Me.cbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPais.Location = New System.Drawing.Point(6, 165)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(200, 24)
        Me.cbPais.TabIndex = 17
        '
        'cbMunicipio
        '
        Me.cbMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipio.Location = New System.Drawing.Point(6, 18)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(200, 24)
        Me.cbMunicipio.TabIndex = 16
        '
        'cbTerritorio
        '
        Me.cbTerritorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTerritorio.Location = New System.Drawing.Point(6, 135)
        Me.cbTerritorio.Name = "cbTerritorio"
        Me.cbTerritorio.Size = New System.Drawing.Size(200, 24)
        Me.cbTerritorio.TabIndex = 15
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(6, 77)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(200, 23)
        Me.tbDireccion.TabIndex = 14
        '
        'tbCodMunicipio
        '
        Me.tbCodMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodMunicipio.Location = New System.Drawing.Point(6, 48)
        Me.tbCodMunicipio.Name = "tbCodMunicipio"
        Me.tbCodMunicipio.Size = New System.Drawing.Size(200, 23)
        Me.tbCodMunicipio.TabIndex = 14
        '
        'tbCodPostal
        '
        Me.tbCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodPostal.Location = New System.Drawing.Point(6, 106)
        Me.tbCodPostal.Name = "tbCodPostal"
        Me.tbCodPostal.Size = New System.Drawing.Size(200, 23)
        Me.tbCodPostal.TabIndex = 13
        '
        'tbLongitud
        '
        Me.tbLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLongitud.Location = New System.Drawing.Point(6, 195)
        Me.tbLongitud.Name = "tbLongitud"
        Me.tbLongitud.Size = New System.Drawing.Size(200, 23)
        Me.tbLongitud.TabIndex = 13
        '
        'tbLatitud
        '
        Me.tbLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLatitud.Location = New System.Drawing.Point(6, 224)
        Me.tbLatitud.Name = "tbLatitud"
        Me.tbLatitud.Size = New System.Drawing.Size(200, 23)
        Me.tbLatitud.TabIndex = 12
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipio.Location = New System.Drawing.Point(424, 84)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(79, 20)
        Me.lblMunicipio.TabIndex = 13
        Me.lblMunicipio.Text = "Municipio:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(424, 139)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(79, 20)
        Me.lblDireccion.TabIndex = 14
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCodPostal
        '
        Me.lblCodPostal.AutoSize = True
        Me.lblCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPostal.Location = New System.Drawing.Point(424, 168)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(111, 20)
        Me.lblCodPostal.TabIndex = 15
        Me.lblCodPostal.Text = "Código Postal:"
        '
        'lblLatitud
        '
        Me.lblLatitud.AutoSize = True
        Me.lblLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatitud.Location = New System.Drawing.Point(424, 257)
        Me.lblLatitud.Name = "lblLatitud"
        Me.lblLatitud.Size = New System.Drawing.Size(62, 20)
        Me.lblLatitud.TabIndex = 16
        Me.lblLatitud.Text = "Latitud:"
        '
        'lblLongitud
        '
        Me.lblLongitud.AutoSize = True
        Me.lblLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitud.Location = New System.Drawing.Point(424, 286)
        Me.lblLongitud.Name = "lblLongitud"
        Me.lblLongitud.Size = New System.Drawing.Size(75, 20)
        Me.lblLongitud.TabIndex = 17
        Me.lblLongitud.Text = "Longitud:"
        '
        'lblCodMunicipio
        '
        Me.lblCodMunicipio.AutoSize = True
        Me.lblCodMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMunicipio.Location = New System.Drawing.Point(424, 110)
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
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(627, 408)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 30)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ConexionBindingSource
        '
        Me.ConexionBindingSource.DataSource = GetType(RetoAlojamientosYUUAvb.Conexion)
        '
        'lblTerritorio
        '
        Me.lblTerritorio.AutoSize = True
        Me.lblTerritorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerritorio.Location = New System.Drawing.Point(424, 197)
        Me.lblTerritorio.Name = "lblTerritorio"
        Me.lblTerritorio.Size = New System.Drawing.Size(75, 20)
        Me.lblTerritorio.TabIndex = 23
        Me.lblTerritorio.Text = "Territorio:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(424, 227)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(43, 20)
        Me.lblPais.TabIndex = 24
        Me.lblPais.Text = "Pais:"
        '
        'AddAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblTerritorio)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblCodMunicipio)
        Me.Controls.Add(Me.lblLongitud)
        Me.Controls.Add(Me.lblLatitud)
        Me.Controls.Add(Me.lblCodPostal)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblMunicipio)
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
    Friend WithEvents tbCapacidad As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbWeb As TextBox
    Friend WithEvents gbTLocalizacion As GroupBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbCodMunicipio As TextBox
    Friend WithEvents tbCodPostal As TextBox
    Friend WithEvents tbLongitud As TextBox
    Friend WithEvents tbLatitud As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblCodPostal As Label
    Friend WithEvents lblLatitud As Label
    Friend WithEvents lblLongitud As Label
    Friend WithEvents lblCodMunicipio As Label
    Friend WithEvents cbTiposAloj As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents ConexionBindingSource As BindingSource
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents lblTerritorio As Label
    Friend WithEvents cbMunicipio As ComboBox
    Friend WithEvents cbTerritorio As ComboBox
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents lblPais As Label
End Class
