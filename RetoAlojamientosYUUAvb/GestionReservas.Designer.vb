<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionReservas
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ConexionReservasBS = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnVer = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.tbIdAlojamiento = New System.Windows.Forms.TextBox()
		Me.tbNombreAlojamiento = New System.Windows.Forms.TextBox()
		Me.lblIdAlojamiento = New System.Windows.Forms.Label()
		Me.lblNombreAlojamiento = New System.Windows.Forms.Label()
		Me.lblIdReserva = New System.Windows.Forms.Label()
		Me.tbIdReserva = New System.Windows.Forms.TextBox()
		Me.lblDniCliente = New System.Windows.Forms.Label()
		Me.tbDniCliente = New System.Windows.Forms.TextBox()
		Me.tbFechaEntrada = New System.Windows.Forms.TextBox()
		Me.tbFechaSalida = New System.Windows.Forms.TextBox()
		Me.lblFechaEntrada = New System.Windows.Forms.Label()
		Me.lblFechaSalida = New System.Windows.Forms.Label()
		Me.lblNombreCliente = New System.Windows.Forms.Label()
		Me.tbNombreCliente = New System.Windows.Forms.TextBox()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnVolver = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ConexionReservasBS, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(13, 135)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(694, 273)
		Me.DataGridView1.TabIndex = 0
		'
		'btnVer
		'
		Me.btnVer.Location = New System.Drawing.Point(732, 135)
		Me.btnVer.Name = "btnVer"
		Me.btnVer.Size = New System.Drawing.Size(75, 23)
		Me.btnVer.TabIndex = 1
		Me.btnVer.Text = "Ver"
		Me.btnVer.UseVisualStyleBackColor = True
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(732, 195)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 2
		Me.btnModificar.Text = "Modificar"
		Me.btnModificar.UseVisualStyleBackColor = True
		'
		'btnBorrar
		'
		Me.btnBorrar.Location = New System.Drawing.Point(732, 258)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
		Me.btnBorrar.TabIndex = 3
		Me.btnBorrar.Text = "Borrar"
		Me.btnBorrar.UseVisualStyleBackColor = True
		'
		'tbIdAlojamiento
		'
		Me.tbIdAlojamiento.Location = New System.Drawing.Point(964, 132)
		Me.tbIdAlojamiento.Name = "tbIdAlojamiento"
		Me.tbIdAlojamiento.Size = New System.Drawing.Size(100, 20)
		Me.tbIdAlojamiento.TabIndex = 4
		'
		'tbNombreAlojamiento
		'
		Me.tbNombreAlojamiento.Location = New System.Drawing.Point(964, 162)
		Me.tbNombreAlojamiento.Name = "tbNombreAlojamiento"
		Me.tbNombreAlojamiento.Size = New System.Drawing.Size(100, 20)
		Me.tbNombreAlojamiento.TabIndex = 5
		'
		'lblIdAlojamiento
		'
		Me.lblIdAlojamiento.AutoSize = True
		Me.lblIdAlojamiento.Location = New System.Drawing.Point(841, 135)
		Me.lblIdAlojamiento.Name = "lblIdAlojamiento"
		Me.lblIdAlojamiento.Size = New System.Drawing.Size(76, 13)
		Me.lblIdAlojamiento.TabIndex = 6
		Me.lblIdAlojamiento.Text = "Id Alojamiento:"
		'
		'lblNombreAlojamiento
		'
		Me.lblNombreAlojamiento.AutoSize = True
		Me.lblNombreAlojamiento.Location = New System.Drawing.Point(841, 164)
		Me.lblNombreAlojamiento.Name = "lblNombreAlojamiento"
		Me.lblNombreAlojamiento.Size = New System.Drawing.Size(104, 13)
		Me.lblNombreAlojamiento.TabIndex = 7
		Me.lblNombreAlojamiento.Text = "Nombre Alojamiento:"
		'
		'lblIdReserva
		'
		Me.lblIdReserva.AutoSize = True
		Me.lblIdReserva.Location = New System.Drawing.Point(841, 204)
		Me.lblIdReserva.Name = "lblIdReserva"
		Me.lblIdReserva.Size = New System.Drawing.Size(62, 13)
		Me.lblIdReserva.TabIndex = 8
		Me.lblIdReserva.Text = "Id Reserva:"
		'
		'tbIdReserva
		'
		Me.tbIdReserva.Location = New System.Drawing.Point(964, 197)
		Me.tbIdReserva.Name = "tbIdReserva"
		Me.tbIdReserva.Size = New System.Drawing.Size(100, 20)
		Me.tbIdReserva.TabIndex = 9
		'
		'lblDniCliente
		'
		Me.lblDniCliente.AutoSize = True
		Me.lblDniCliente.Location = New System.Drawing.Point(841, 237)
		Me.lblDniCliente.Name = "lblDniCliente"
		Me.lblDniCliente.Size = New System.Drawing.Size(64, 13)
		Me.lblDniCliente.TabIndex = 10
		Me.lblDniCliente.Text = "DNI Cliente:"
		'
		'tbDniCliente
		'
		Me.tbDniCliente.Location = New System.Drawing.Point(964, 233)
		Me.tbDniCliente.Name = "tbDniCliente"
		Me.tbDniCliente.Size = New System.Drawing.Size(100, 20)
		Me.tbDniCliente.TabIndex = 11
		'
		'tbFechaEntrada
		'
		Me.tbFechaEntrada.Location = New System.Drawing.Point(964, 298)
		Me.tbFechaEntrada.Name = "tbFechaEntrada"
		Me.tbFechaEntrada.Size = New System.Drawing.Size(100, 20)
		Me.tbFechaEntrada.TabIndex = 12
		'
		'tbFechaSalida
		'
		Me.tbFechaSalida.Location = New System.Drawing.Point(964, 333)
		Me.tbFechaSalida.Name = "tbFechaSalida"
		Me.tbFechaSalida.Size = New System.Drawing.Size(100, 20)
		Me.tbFechaSalida.TabIndex = 13
		'
		'lblFechaEntrada
		'
		Me.lblFechaEntrada.AutoSize = True
		Me.lblFechaEntrada.Location = New System.Drawing.Point(841, 298)
		Me.lblFechaEntrada.Name = "lblFechaEntrada"
		Me.lblFechaEntrada.Size = New System.Drawing.Size(80, 13)
		Me.lblFechaEntrada.TabIndex = 14
		Me.lblFechaEntrada.Text = "Fecha Entrada:"
		'
		'lblFechaSalida
		'
		Me.lblFechaSalida.AutoSize = True
		Me.lblFechaSalida.Location = New System.Drawing.Point(841, 336)
		Me.lblFechaSalida.Name = "lblFechaSalida"
		Me.lblFechaSalida.Size = New System.Drawing.Size(72, 13)
		Me.lblFechaSalida.TabIndex = 15
		Me.lblFechaSalida.Text = "Fecha Salida:"
		'
		'lblNombreCliente
		'
		Me.lblNombreCliente.AutoSize = True
		Me.lblNombreCliente.Location = New System.Drawing.Point(841, 266)
		Me.lblNombreCliente.Name = "lblNombreCliente"
		Me.lblNombreCliente.Size = New System.Drawing.Size(82, 13)
		Me.lblNombreCliente.TabIndex = 16
		Me.lblNombreCliente.Text = "Nombre Cliente:"
		'
		'tbNombreCliente
		'
		Me.tbNombreCliente.Location = New System.Drawing.Point(964, 263)
		Me.tbNombreCliente.Name = "tbNombreCliente"
		Me.tbNombreCliente.Size = New System.Drawing.Size(100, 20)
		Me.tbNombreCliente.TabIndex = 17
		'
		'btnGuardar
		'
		Me.btnGuardar.Location = New System.Drawing.Point(848, 407)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
		Me.btnGuardar.TabIndex = 18
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = True
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(989, 407)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 19
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'btnVolver
		'
		Me.btnVolver.Location = New System.Drawing.Point(47, 466)
		Me.btnVolver.Name = "btnVolver"
		Me.btnVolver.Size = New System.Drawing.Size(75, 23)
		Me.btnVolver.TabIndex = 20
		Me.btnVolver.Text = "Volver"
		Me.btnVolver.UseVisualStyleBackColor = True
		'
		'GestionReservas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.ClientSize = New System.Drawing.Size(1132, 504)
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.tbNombreCliente)
		Me.Controls.Add(Me.lblNombreCliente)
		Me.Controls.Add(Me.lblFechaSalida)
		Me.Controls.Add(Me.lblFechaEntrada)
		Me.Controls.Add(Me.tbFechaSalida)
		Me.Controls.Add(Me.tbFechaEntrada)
		Me.Controls.Add(Me.tbDniCliente)
		Me.Controls.Add(Me.lblDniCliente)
		Me.Controls.Add(Me.tbIdReserva)
		Me.Controls.Add(Me.lblIdReserva)
		Me.Controls.Add(Me.lblNombreAlojamiento)
		Me.Controls.Add(Me.lblIdAlojamiento)
		Me.Controls.Add(Me.tbNombreAlojamiento)
		Me.Controls.Add(Me.tbIdAlojamiento)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnVer)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "GestionReservas"
		Me.Text = "Gestión Reserva"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ConexionReservasBS, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents ConexionReservasBS As BindingSource
	Friend WithEvents btnVer As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents btnBorrar As Button
	Friend WithEvents tbIdAlojamiento As TextBox
	Friend WithEvents tbNombreAlojamiento As TextBox
	Friend WithEvents lblIdAlojamiento As Label
	Friend WithEvents lblNombreAlojamiento As Label
	Friend WithEvents lblIdReserva As Label
	Friend WithEvents tbIdReserva As TextBox
	Friend WithEvents lblDniCliente As Label
	Friend WithEvents tbDniCliente As TextBox
	Friend WithEvents tbFechaEntrada As TextBox
	Friend WithEvents tbFechaSalida As TextBox
	Friend WithEvents lblFechaEntrada As Label
	Friend WithEvents lblFechaSalida As Label
	Friend WithEvents lblNombreCliente As Label
	Friend WithEvents tbNombreCliente As TextBox
	Friend WithEvents btnGuardar As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents btnVolver As Button
End Class
