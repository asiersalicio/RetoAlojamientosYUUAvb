﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionAlojamientos
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.tbBusqueda = New System.Windows.Forms.TextBox()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnVer = New System.Windows.Forms.Button()
		Me.btnVolver = New System.Windows.Forms.Button()
		Me.DataGridAlojamientos = New System.Windows.Forms.DataGridView()
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
		Me.tbPais = New System.Windows.Forms.ComboBox()
		Me.tbDireccion = New System.Windows.Forms.TextBox()
		Me.tbMunicipio = New System.Windows.Forms.ComboBox()
		Me.tbCodPostal = New System.Windows.Forms.TextBox()
		Me.tbLongitud = New System.Windows.Forms.TextBox()
		Me.tbTerritorio = New System.Windows.Forms.ComboBox()
		Me.tbLatitud = New System.Windows.Forms.TextBox()
		Me.lblTerritorio = New System.Windows.Forms.Label()
		Me.lblDireccion = New System.Windows.Forms.Label()
		Me.lblCodPostal = New System.Windows.Forms.Label()
		Me.lblLatitud = New System.Windows.Forms.Label()
		Me.lblLongitud = New System.Windows.Forms.Label()
		Me.lblMunicipio = New System.Windows.Forms.Label()
		Me.btnAñadir = New System.Windows.Forms.Button()
		Me.ConexionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.lblPais = New System.Windows.Forms.Label()
		CType(Me.DataGridAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbTAlojamientos.SuspendLayout()
		Me.gbTLocalizacion.SuspendLayout()
		CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(713, 415)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(75, 23)
		Me.btnSalir.TabIndex = 1
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = True
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(619, 110)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(88, 20)
		Me.btnBuscar.TabIndex = 11
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'tbBusqueda
		'
		Me.tbBusqueda.Location = New System.Drawing.Point(13, 110)
		Me.tbBusqueda.Name = "tbBusqueda"
		Me.tbBusqueda.Size = New System.Drawing.Size(600, 20)
		Me.tbBusqueda.TabIndex = 10
		'
		'btnBorrar
		'
		Me.btnBorrar.Location = New System.Drawing.Point(713, 194)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
		Me.btnBorrar.TabIndex = 9
		Me.btnBorrar.Text = "Borrar"
		Me.btnBorrar.UseVisualStyleBackColor = True
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(713, 165)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 8
		Me.btnModificar.Text = "Modificar"
		Me.btnModificar.UseVisualStyleBackColor = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(713, 136)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 7
		Me.btnAdd.Text = "Añadir"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'btnVer
		'
		Me.btnVer.Location = New System.Drawing.Point(94, 415)
		Me.btnVer.Name = "btnVer"
		Me.btnVer.Size = New System.Drawing.Size(613, 23)
		Me.btnVer.TabIndex = 12
		Me.btnVer.Text = "Ver"
		Me.btnVer.UseVisualStyleBackColor = True
		'
		'btnVolver
		'
		Me.btnVolver.Location = New System.Drawing.Point(13, 415)
		Me.btnVolver.Name = "btnVolver"
		Me.btnVolver.Size = New System.Drawing.Size(75, 23)
		Me.btnVolver.TabIndex = 13
		Me.btnVolver.Text = "Volver"
		Me.btnVolver.UseVisualStyleBackColor = True
		'
		'DataGridAlojamientos
		'
		Me.DataGridAlojamientos.AllowUserToAddRows = False
		Me.DataGridAlojamientos.AllowUserToDeleteRows = False
		Me.DataGridAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.NullValue = "-"
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridAlojamientos.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridAlojamientos.Location = New System.Drawing.Point(13, 135)
		Me.DataGridAlojamientos.MultiSelect = False
		Me.DataGridAlojamientos.Name = "DataGridAlojamientos"
		Me.DataGridAlojamientos.ReadOnly = True
		Me.DataGridAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridAlojamientos.Size = New System.Drawing.Size(694, 273)
		Me.DataGridAlojamientos.TabIndex = 14
		'
		'lblId
		'
		Me.lblId.AutoSize = True
		Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblId.Location = New System.Drawing.Point(826, 135)
		Me.lblId.Name = "lblId"
		Me.lblId.Size = New System.Drawing.Size(68, 13)
		Me.lblId.TabIndex = 0
		Me.lblId.Text = "Identificador:"
		'
		'lblCapacidad
		'
		Me.lblCapacidad.AutoSize = True
		Me.lblCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblCapacidad.Location = New System.Drawing.Point(826, 265)
		Me.lblCapacidad.Name = "lblCapacidad"
		Me.lblCapacidad.Size = New System.Drawing.Size(61, 13)
		Me.lblCapacidad.TabIndex = 1
		Me.lblCapacidad.Text = "Capacidad:"
		'
		'lblDescripcion
		'
		Me.lblDescripcion.AutoSize = True
		Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblDescripcion.Location = New System.Drawing.Point(826, 297)
		Me.lblDescripcion.Name = "lblDescripcion"
		Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
		Me.lblDescripcion.TabIndex = 2
		Me.lblDescripcion.Text = "Descripción:"
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblEmail.Location = New System.Drawing.Point(825, 361)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(96, 13)
		Me.lblEmail.TabIndex = 3
		Me.lblEmail.Text = "Correo electrónico:"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblName.Location = New System.Drawing.Point(826, 167)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(47, 13)
		Me.lblName.TabIndex = 4
		Me.lblName.Text = "Nombre:"
		'
		'lblTelefono
		'
		Me.lblTelefono.AutoSize = True
		Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblTelefono.Location = New System.Drawing.Point(825, 329)
		Me.lblTelefono.Name = "lblTelefono"
		Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
		Me.lblTelefono.TabIndex = 5
		Me.lblTelefono.Text = "Teléfono:"
		'
		'lblTipo
		'
		Me.lblTipo.AutoSize = True
		Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblTipo.Location = New System.Drawing.Point(825, 233)
		Me.lblTipo.Name = "lblTipo"
		Me.lblTipo.Size = New System.Drawing.Size(102, 13)
		Me.lblTipo.TabIndex = 6
		Me.lblTipo.Text = "Tipo de alojamiento:"
		'
		'lblWeb
		'
		Me.lblWeb.AutoSize = True
		Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblWeb.Location = New System.Drawing.Point(825, 393)
		Me.lblWeb.Name = "lblWeb"
		Me.lblWeb.Size = New System.Drawing.Size(33, 13)
		Me.lblWeb.TabIndex = 7
		Me.lblWeb.Text = "Web:"
		'
		'tbId
		'
		Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbId.Location = New System.Drawing.Point(0, 10)
		Me.tbId.Name = "tbId"
		Me.tbId.Size = New System.Drawing.Size(200, 26)
		Me.tbId.TabIndex = 9
		'
		'tbNombre
		'
		Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbNombre.Location = New System.Drawing.Point(0, 42)
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
		Me.gbTAlojamientos.Location = New System.Drawing.Point(929, 119)
		Me.gbTAlojamientos.Name = "gbTAlojamientos"
		Me.gbTAlojamientos.Size = New System.Drawing.Size(217, 307)
		Me.gbTAlojamientos.TabIndex = 11
		Me.gbTAlojamientos.TabStop = False
		Me.gbTAlojamientos.Text = "GroupBox1"
		'
		'cbTiposAloj
		'
		Me.cbTiposAloj.FormattingEnabled = True
		Me.cbTiposAloj.Location = New System.Drawing.Point(0, 111)
		Me.cbTiposAloj.Name = "cbTiposAloj"
		Me.cbTiposAloj.Size = New System.Drawing.Size(200, 21)
		Me.cbTiposAloj.TabIndex = 20
		'
		'tbDescripcion
		'
		Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbDescripcion.Location = New System.Drawing.Point(0, 172)
		Me.tbDescripcion.Name = "tbDescripcion"
		Me.tbDescripcion.Size = New System.Drawing.Size(200, 26)
		Me.tbDescripcion.TabIndex = 14
		'
		'tbWeb
		'
		Me.tbWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbWeb.Location = New System.Drawing.Point(0, 268)
		Me.tbWeb.Name = "tbWeb"
		Me.tbWeb.Size = New System.Drawing.Size(200, 26)
		Me.tbWeb.TabIndex = 14
		'
		'tbCapacidad
		'
		Me.tbCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbCapacidad.Location = New System.Drawing.Point(0, 140)
		Me.tbCapacidad.Name = "tbCapacidad"
		Me.tbCapacidad.Size = New System.Drawing.Size(200, 26)
		Me.tbCapacidad.TabIndex = 13
		'
		'tbEmail
		'
		Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbEmail.Location = New System.Drawing.Point(0, 236)
		Me.tbEmail.Name = "tbEmail"
		Me.tbEmail.Size = New System.Drawing.Size(200, 26)
		Me.tbEmail.TabIndex = 13
		'
		'tbTelefono
		'
		Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbTelefono.Location = New System.Drawing.Point(0, 204)
		Me.tbTelefono.Name = "tbTelefono"
		Me.tbTelefono.Size = New System.Drawing.Size(200, 26)
		Me.tbTelefono.TabIndex = 12
		'
		'gbTLocalizacion
		'
		Me.gbTLocalizacion.Controls.Add(Me.tbPais)
		Me.gbTLocalizacion.Controls.Add(Me.tbDireccion)
		Me.gbTLocalizacion.Controls.Add(Me.tbMunicipio)
		Me.gbTLocalizacion.Controls.Add(Me.tbCodPostal)
		Me.gbTLocalizacion.Controls.Add(Me.tbLongitud)
		Me.gbTLocalizacion.Controls.Add(Me.tbTerritorio)
		Me.gbTLocalizacion.Controls.Add(Me.tbLatitud)
		Me.gbTLocalizacion.Location = New System.Drawing.Point(1256, 119)
		Me.gbTLocalizacion.Name = "gbTLocalizacion"
		Me.gbTLocalizacion.Size = New System.Drawing.Size(208, 230)
		Me.gbTLocalizacion.TabIndex = 12
		Me.gbTLocalizacion.TabStop = False
		Me.gbTLocalizacion.Text = "GroupBox1"
		'
		'tbPais
		'
		Me.tbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbPais.Location = New System.Drawing.Point(2, 13)
		Me.tbPais.Name = "tbPais"
		Me.tbPais.Size = New System.Drawing.Size(200, 28)
		Me.tbPais.TabIndex = 15
		'
		'tbDireccion
		'
		Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbDireccion.Location = New System.Drawing.Point(2, 137)
		Me.tbDireccion.Name = "tbDireccion"
		Me.tbDireccion.Size = New System.Drawing.Size(200, 26)
		Me.tbDireccion.TabIndex = 14
		'
		'tbMunicipio
		'
		Me.tbMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbMunicipio.Location = New System.Drawing.Point(2, 75)
		Me.tbMunicipio.Name = "tbMunicipio"
		Me.tbMunicipio.Size = New System.Drawing.Size(200, 28)
		Me.tbMunicipio.TabIndex = 14
		'
		'tbCodPostal
		'
		Me.tbCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbCodPostal.Location = New System.Drawing.Point(2, 106)
		Me.tbCodPostal.Name = "tbCodPostal"
		Me.tbCodPostal.Size = New System.Drawing.Size(200, 26)
		Me.tbCodPostal.TabIndex = 13
		'
		'tbLongitud
		'
		Me.tbLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbLongitud.Location = New System.Drawing.Point(2, 199)
		Me.tbLongitud.Name = "tbLongitud"
		Me.tbLongitud.Size = New System.Drawing.Size(200, 26)
		Me.tbLongitud.TabIndex = 13
		'
		'tbTerritorio
		'
		Me.tbTerritorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbTerritorio.Location = New System.Drawing.Point(2, 44)
		Me.tbTerritorio.Name = "tbTerritorio"
		Me.tbTerritorio.Size = New System.Drawing.Size(200, 28)
		Me.tbTerritorio.TabIndex = 12
		'
		'tbLatitud
		'
		Me.tbLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbLatitud.Location = New System.Drawing.Point(2, 168)
		Me.tbLatitud.Name = "tbLatitud"
		Me.tbLatitud.Size = New System.Drawing.Size(200, 26)
		Me.tbLatitud.TabIndex = 12
		'
		'lblTerritorio
		'
		Me.lblTerritorio.AutoSize = True
		Me.lblTerritorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblTerritorio.Location = New System.Drawing.Point(1175, 168)
		Me.lblTerritorio.Name = "lblTerritorio"
		Me.lblTerritorio.Size = New System.Drawing.Size(51, 13)
		Me.lblTerritorio.TabIndex = 13
		Me.lblTerritorio.Text = "Territorio:"
		'
		'lblDireccion
		'
		Me.lblDireccion.AutoSize = True
		Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblDireccion.Location = New System.Drawing.Point(1175, 267)
		Me.lblDireccion.Name = "lblDireccion"
		Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
		Me.lblDireccion.TabIndex = 14
		Me.lblDireccion.Text = "Dirección:"
		'
		'lblCodPostal
		'
		Me.lblCodPostal.AutoSize = True
		Me.lblCodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblCodPostal.Location = New System.Drawing.Point(1175, 234)
		Me.lblCodPostal.Name = "lblCodPostal"
		Me.lblCodPostal.Size = New System.Drawing.Size(75, 13)
		Me.lblCodPostal.TabIndex = 15
		Me.lblCodPostal.Text = "Código Postal:"
		'
		'lblLatitud
		'
		Me.lblLatitud.AutoSize = True
		Me.lblLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblLatitud.Location = New System.Drawing.Point(1175, 300)
		Me.lblLatitud.Name = "lblLatitud"
		Me.lblLatitud.Size = New System.Drawing.Size(42, 13)
		Me.lblLatitud.TabIndex = 16
		Me.lblLatitud.Text = "Latitud:"
		'
		'lblLongitud
		'
		Me.lblLongitud.AutoSize = True
		Me.lblLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblLongitud.Location = New System.Drawing.Point(1175, 333)
		Me.lblLongitud.Name = "lblLongitud"
		Me.lblLongitud.Size = New System.Drawing.Size(51, 13)
		Me.lblLongitud.TabIndex = 17
		Me.lblLongitud.Text = "Longitud:"
		'
		'lblMunicipio
		'
		Me.lblMunicipio.AutoSize = True
		Me.lblMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblMunicipio.Location = New System.Drawing.Point(1175, 201)
		Me.lblMunicipio.Name = "lblMunicipio"
		Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
		Me.lblMunicipio.TabIndex = 19
		Me.lblMunicipio.Text = "Municipio:"
		'
		'btnAñadir
		'
		Me.btnAñadir.Location = New System.Drawing.Point(1061, 462)
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
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(1185, 462)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
		Me.btnCancelar.TabIndex = 20
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'lblPais
		'
		Me.lblPais.AutoSize = True
		Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.lblPais.Location = New System.Drawing.Point(1175, 135)
		Me.lblPais.Name = "lblPais"
		Me.lblPais.Size = New System.Drawing.Size(30, 13)
		Me.lblPais.TabIndex = 22
		Me.lblPais.Text = "Pais:"
		'
		'GestionAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.ClientSize = New System.Drawing.Size(1533, 504)
		Me.Controls.Add(Me.lblPais)
		Me.Controls.Add(Me.DataGridAlojamientos)
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnVer)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.tbBusqueda)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnAñadir)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.lblMunicipio)
		Me.Controls.Add(Me.lblLongitud)
		Me.Controls.Add(Me.lblLatitud)
		Me.Controls.Add(Me.lblCodPostal)
		Me.Controls.Add(Me.lblDireccion)
		Me.Controls.Add(Me.lblTerritorio)
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
		Me.Name = "GestionAlojamientos"
		Me.Text = "Añadir Nuevo Alojamiento"
		CType(Me.DataGridAlojamientos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbTAlojamientos.ResumeLayout(False)
		Me.gbTAlojamientos.PerformLayout()
		Me.gbTLocalizacion.ResumeLayout(False)
		Me.gbTLocalizacion.PerformLayout()
		CType(Me.ConexionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tbBusqueda As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnVolver As Button
	Friend WithEvents DataGridAlojamientos As DataGridView
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
	Friend WithEvents tbMunicipio As ComboBox
	Friend WithEvents tbCodPostal As TextBox
	Friend WithEvents tbLongitud As TextBox
	Friend WithEvents tbTerritorio As ComboBox
	Friend WithEvents tbLatitud As TextBox
	Friend WithEvents lblTerritorio As Label
	Friend WithEvents lblDireccion As Label
	Friend WithEvents lblCodPostal As Label
	Friend WithEvents lblLatitud As Label
	Friend WithEvents lblLongitud As Label
	Friend WithEvents lblMunicipio As Label
	Friend WithEvents cbTiposAloj As ComboBox
	Friend WithEvents btnAñadir As Button
	Friend WithEvents ConexionBindingSource As BindingSource
	Friend WithEvents btnCancelar As Button
	Friend WithEvents lblPais As Label
	Friend WithEvents tbPais As ComboBox
End Class
