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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lblLocalizacion = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.gbLocalizacion = New System.Windows.Forms.GroupBox()
        Me.tbCP = New System.Windows.Forms.TextBox()
        Me.tbMunicipio = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.gbLocalizacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(125, 78)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(101, 20)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Identificador:"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidad.Location = New System.Drawing.Point(124, 209)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(89, 20)
        Me.lblCapacidad.TabIndex = 1
        Me.lblCapacidad.Text = "Capacidad:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(124, 241)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(124, 299)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(142, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(125, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(124, 270)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(124, 176)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(150, 20)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "Tipo de alojamiento:"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(124, 330)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(46, 20)
        Me.lblWeb.TabIndex = 7
        Me.lblWeb.Text = "Web:"
        '
        'lblLocalizacion
        '
        Me.lblLocalizacion.AutoSize = True
        Me.lblLocalizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalizacion.Location = New System.Drawing.Point(125, 354)
        Me.lblLocalizacion.Name = "lblLocalizacion"
        Me.lblLocalizacion.Size = New System.Drawing.Size(100, 20)
        Me.lblLocalizacion.TabIndex = 8
        Me.lblLocalizacion.Text = "Localización:"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(389, 75)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(293, 26)
        Me.tbId.TabIndex = 9
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(389, 107)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(293, 26)
        Me.tbNombre.TabIndex = 10
        '
        'gbLocalizacion
        '
        Me.gbLocalizacion.Controls.Add(Me.tbCP)
        Me.gbLocalizacion.Controls.Add(Me.tbMunicipio)
        Me.gbLocalizacion.Controls.Add(Me.tbDireccion)
        Me.gbLocalizacion.Location = New System.Drawing.Point(389, 176)
        Me.gbLocalizacion.Name = "gbLocalizacion"
        Me.gbLocalizacion.Size = New System.Drawing.Size(361, 74)
        Me.gbLocalizacion.TabIndex = 11
        Me.gbLocalizacion.TabStop = False
        Me.gbLocalizacion.Text = "GroupBox1"
        '
        'tbCP
        '
        Me.tbCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCP.Location = New System.Drawing.Point(0, 52)
        Me.tbCP.Name = "tbCP"
        Me.tbCP.Size = New System.Drawing.Size(293, 26)
        Me.tbCP.TabIndex = 14
        '
        'tbMunicipio
        '
        Me.tbMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMunicipio.Location = New System.Drawing.Point(0, 26)
        Me.tbMunicipio.Name = "tbMunicipio"
        Me.tbMunicipio.Size = New System.Drawing.Size(293, 26)
        Me.tbMunicipio.TabIndex = 13
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(0, 0)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(293, 26)
        Me.tbDireccion.TabIndex = 12
        '
        'AddAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbLocalizacion)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lblLocalizacion)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCapacidad)
        Me.Controls.Add(Me.lblId)
        Me.Name = "AddAlojamiento"
        Me.Text = "AddAlojamiento"
        Me.gbLocalizacion.ResumeLayout(False)
        Me.gbLocalizacion.PerformLayout()
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
    Friend WithEvents lblLocalizacion As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents gbLocalizacion As GroupBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbCP As TextBox
    Friend WithEvents tbMunicipio As TextBox
End Class
