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
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.tbBusqueda = New System.Windows.Forms.TextBox()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
		CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(268, 110)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(31, 20)
		Me.btnBuscar.TabIndex = 20
		Me.btnBuscar.Text = "B"
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'tbBusqueda
		'
		Me.tbBusqueda.Location = New System.Drawing.Point(13, 110)
		Me.tbBusqueda.Name = "tbBusqueda"
		Me.tbBusqueda.Size = New System.Drawing.Size(249, 20)
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
		Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridUsuarios.Location = New System.Drawing.Point(13, 136)
		Me.DataGridUsuarios.Name = "DataGridUsuarios"
		Me.DataGridUsuarios.Size = New System.Drawing.Size(694, 272)
		Me.DataGridUsuarios.TabIndex = 23
		'
		'GestionUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.DataGridUsuarios)
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnVer)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.tbBusqueda)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnSalir)
		Me.Name = "GestionUsuarios"
		Me.Text = "Gestión de Usuarios"
		CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnVolver As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tbBusqueda As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridUsuarios As DataGridView
End Class
