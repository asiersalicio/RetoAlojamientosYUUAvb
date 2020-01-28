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
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.ConexionReservasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.tbCategoria = New System.Windows.Forms.TextBox()
        Me.lblNombreAlojamiento = New System.Windows.Forms.Label()
        Me.lblIdReserva = New System.Windows.Forms.Label()
        Me.tbIdReserva = New System.Windows.Forms.TextBox()
        Me.lblDniCliente = New System.Windows.Forms.Label()
        Me.tbDniCliente = New System.Windows.Forms.TextBox()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbDatosReserva = New System.Windows.Forms.GroupBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.tbApellidosCliente = New System.Windows.Forms.TextBox()
        Me.lblApellidosCliente = New System.Windows.Forms.Label()
        Me.lblIdAlojamiento = New System.Windows.Forms.Label()
        Me.tbAlojamiento = New System.Windows.Forms.TextBox()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConexionReservasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosReserva.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReservas
        '
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.AllowUserToResizeRows = False
        Me.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Location = New System.Drawing.Point(13, 135)
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.Size = New System.Drawing.Size(694, 273)
        Me.dgvReservas.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(713, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 86)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(713, 229)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 86)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(713, 322)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 86)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'tbCategoria
        '
        Me.tbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCategoria.Location = New System.Drawing.Point(120, 139)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.Size = New System.Drawing.Size(200, 23)
        Me.tbCategoria.TabIndex = 5
        Me.tbCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombreAlojamiento
        '
        Me.lblNombreAlojamiento.AutoSize = True
        Me.lblNombreAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAlojamiento.Location = New System.Drawing.Point(6, 142)
        Me.lblNombreAlojamiento.Name = "lblNombreAlojamiento"
        Me.lblNombreAlojamiento.Size = New System.Drawing.Size(73, 17)
        Me.lblNombreAlojamiento.TabIndex = 7
        Me.lblNombreAlojamiento.Text = "Categoría:"
        '
        'lblIdReserva
        '
        Me.lblIdReserva.AutoSize = True
        Me.lblIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdReserva.Location = New System.Drawing.Point(6, 16)
        Me.lblIdReserva.Name = "lblIdReserva"
        Me.lblIdReserva.Size = New System.Drawing.Size(103, 17)
        Me.lblIdReserva.TabIndex = 8
        Me.lblIdReserva.Text = "Identificador:"
        '
        'tbIdReserva
        '
        Me.tbIdReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdReserva.Location = New System.Drawing.Point(120, 13)
        Me.tbIdReserva.Name = "tbIdReserva"
        Me.tbIdReserva.Size = New System.Drawing.Size(200, 23)
        Me.tbIdReserva.TabIndex = 9
        Me.tbIdReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDniCliente
        '
        Me.lblDniCliente.AutoSize = True
        Me.lblDniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniCliente.Location = New System.Drawing.Point(6, 186)
        Me.lblDniCliente.Name = "lblDniCliente"
        Me.lblDniCliente.Size = New System.Drawing.Size(82, 17)
        Me.lblDniCliente.TabIndex = 10
        Me.lblDniCliente.Text = "DNI Cliente:"
        '
        'tbDniCliente
        '
        Me.tbDniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDniCliente.Location = New System.Drawing.Point(120, 183)
        Me.tbDniCliente.Name = "tbDniCliente"
        Me.tbDniCliente.Size = New System.Drawing.Size(200, 23)
        Me.tbDniCliente.TabIndex = 11
        Me.tbDniCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.AutoSize = True
        Me.lblFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrada.Location = New System.Drawing.Point(6, 45)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(105, 17)
        Me.lblFechaEntrada.TabIndex = 14
        Me.lblFechaEntrada.Text = "Fecha Entrada:"
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalida.Location = New System.Drawing.Point(6, 74)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(94, 17)
        Me.lblFechaSalida.TabIndex = 15
        Me.lblFechaSalida.Text = "Fecha Salida:"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(6, 215)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreCliente.TabIndex = 16
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreCliente.Location = New System.Drawing.Point(120, 212)
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(200, 23)
        Me.tbNombreCliente.TabIndex = 17
        Me.tbNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 467)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 25)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1020, 74)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 25)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "Desconectar"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1020, 467)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 25)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbDatosReserva
        '
        Me.gbDatosReserva.BackColor = System.Drawing.SystemColors.Window
        Me.gbDatosReserva.Controls.Add(Me.dtpSalida)
        Me.gbDatosReserva.Controls.Add(Me.dtpEntrada)
        Me.gbDatosReserva.Controls.Add(Me.tbApellidosCliente)
        Me.gbDatosReserva.Controls.Add(Me.lblApellidosCliente)
        Me.gbDatosReserva.Controls.Add(Me.lblIdAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.tbAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.tbCategoria)
        Me.gbDatosReserva.Controls.Add(Me.lblNombreAlojamiento)
        Me.gbDatosReserva.Controls.Add(Me.lblIdReserva)
        Me.gbDatosReserva.Controls.Add(Me.tbIdReserva)
        Me.gbDatosReserva.Controls.Add(Me.tbNombreCliente)
        Me.gbDatosReserva.Controls.Add(Me.lblDniCliente)
        Me.gbDatosReserva.Controls.Add(Me.lblNombreCliente)
        Me.gbDatosReserva.Controls.Add(Me.tbDniCliente)
        Me.gbDatosReserva.Controls.Add(Me.lblFechaSalida)
        Me.gbDatosReserva.Controls.Add(Me.lblFechaEntrada)
        Me.gbDatosReserva.Location = New System.Drawing.Point(794, 128)
        Me.gbDatosReserva.Name = "gbDatosReserva"
        Me.gbDatosReserva.Size = New System.Drawing.Size(326, 280)
        Me.gbDatosReserva.TabIndex = 34
        Me.gbDatosReserva.TabStop = False
        '
        'dtpSalida
        '
        Me.dtpSalida.Enabled = False
        Me.dtpSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalida.Location = New System.Drawing.Point(120, 74)
        Me.dtpSalida.MaxDate = New Date(2100, 12, 31, 23, 59, 0, 0)
        Me.dtpSalida.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpSalida.Size = New System.Drawing.Size(200, 23)
        Me.dtpSalida.TabIndex = 38
        Me.dtpSalida.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Enabled = False
        Me.dtpEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntrada.Location = New System.Drawing.Point(120, 42)
        Me.dtpEntrada.MaxDate = New Date(2020, 1, 28, 11, 57, 43, 0)
        Me.dtpEntrada.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpEntrada.Size = New System.Drawing.Size(200, 23)
        Me.dtpEntrada.TabIndex = 37
        Me.dtpEntrada.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'tbApellidosCliente
        '
        Me.tbApellidosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidosCliente.Location = New System.Drawing.Point(120, 241)
        Me.tbApellidosCliente.Name = "tbApellidosCliente"
        Me.tbApellidosCliente.Size = New System.Drawing.Size(200, 23)
        Me.tbApellidosCliente.TabIndex = 36
        Me.tbApellidosCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblApellidosCliente
        '
        Me.lblApellidosCliente.AutoSize = True
        Me.lblApellidosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosCliente.Location = New System.Drawing.Point(6, 244)
        Me.lblApellidosCliente.Name = "lblApellidosCliente"
        Me.lblApellidosCliente.Size = New System.Drawing.Size(65, 17)
        Me.lblApellidosCliente.TabIndex = 35
        Me.lblApellidosCliente.Text = "Apellidos"
        '
        'lblIdAlojamiento
        '
        Me.lblIdAlojamiento.AutoSize = True
        Me.lblIdAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAlojamiento.Location = New System.Drawing.Point(6, 113)
        Me.lblIdAlojamiento.Name = "lblIdAlojamiento"
        Me.lblIdAlojamiento.Size = New System.Drawing.Size(85, 17)
        Me.lblIdAlojamiento.TabIndex = 6
        Me.lblIdAlojamiento.Text = "Alojamiento:"
        '
        'tbAlojamiento
        '
        Me.tbAlojamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlojamiento.Location = New System.Drawing.Point(120, 110)
        Me.tbAlojamiento.Name = "tbAlojamiento"
        Me.tbAlojamiento.Size = New System.Drawing.Size(200, 23)
        Me.tbAlojamiento.TabIndex = 4
        Me.tbAlojamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GestionReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1132, 504)
        Me.Controls.Add(Me.gbDatosReserva)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvReservas)
        Me.Name = "GestionReservas"
        Me.Text = "Gestión de Reservas"
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConexionReservasBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosReserva.ResumeLayout(False)
        Me.gbDatosReserva.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReservas As DataGridView
	Friend WithEvents ConexionReservasBS As BindingSource
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents btnBorrar As Button
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents lblNombreAlojamiento As Label
    Friend WithEvents lblIdReserva As Label
    Friend WithEvents tbIdReserva As TextBox
    Friend WithEvents lblDniCliente As Label
    Friend WithEvents tbDniCliente As TextBox
    Friend WithEvents lblFechaEntrada As Label
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents tbNombreCliente As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbDatosReserva As GroupBox
    Friend WithEvents lblIdAlojamiento As Label
    Friend WithEvents tbAlojamiento As TextBox
    Friend WithEvents tbApellidosCliente As TextBox
    Friend WithEvents lblApellidosCliente As Label
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
End Class
