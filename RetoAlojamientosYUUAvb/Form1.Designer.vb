<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGestionAloj = New System.Windows.Forms.Button()
        Me.btnGestionClientes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGestionAloj
        '
        Me.btnGestionAloj.Location = New System.Drawing.Point(136, 148)
        Me.btnGestionAloj.Name = "btnGestionAloj"
        Me.btnGestionAloj.Size = New System.Drawing.Size(516, 52)
        Me.btnGestionAloj.TabIndex = 0
        Me.btnGestionAloj.Text = "Gestión de alojamientos"
        Me.btnGestionAloj.UseVisualStyleBackColor = True
        '
        'btnGestionClientes
        '
        Me.btnGestionClientes.Location = New System.Drawing.Point(136, 231)
        Me.btnGestionClientes.Name = "btnGestionClientes"
        Me.btnGestionClientes.Size = New System.Drawing.Size(516, 52)
        Me.btnGestionClientes.TabIndex = 1
        Me.btnGestionClientes.Text = "Gestión de clientes"
        Me.btnGestionClientes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGestionClientes)
        Me.Controls.Add(Me.btnGestionAloj)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGestionAloj As Button
    Friend WithEvents btnGestionClientes As Button
    Friend WithEvents btnSalir As Button
End Class
