﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestion
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.btnGestionAlojamientos = New System.Windows.Forms.Button()
        Me.btnGestionUsuarios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGestionReservas = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGestionAlojamientos
        '
        Me.btnGestionAlojamientos.Location = New System.Drawing.Point(228, 180)
        Me.btnGestionAlojamientos.Name = "btnGestionAlojamientos"
        Me.btnGestionAlojamientos.Size = New System.Drawing.Size(329, 41)
        Me.btnGestionAlojamientos.TabIndex = 0
        Me.btnGestionAlojamientos.Text = "Gestionar Alojamientos"
        Me.btnGestionAlojamientos.UseVisualStyleBackColor = True
        '
        'btnGestionUsuarios
        '
        Me.btnGestionUsuarios.Location = New System.Drawing.Point(228, 236)
        Me.btnGestionUsuarios.Name = "btnGestionUsuarios"
        Me.btnGestionUsuarios.Size = New System.Drawing.Size(329, 41)
        Me.btnGestionUsuarios.TabIndex = 1
        Me.btnGestionUsuarios.Text = "Gestionar Usuarios"
        Me.btnGestionUsuarios.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(698, 413)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 25)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGestionReservas
        '
        Me.btnGestionReservas.Location = New System.Drawing.Point(228, 296)
        Me.btnGestionReservas.Name = "btnGestionReservas"
        Me.btnGestionReservas.Size = New System.Drawing.Size(329, 41)
        Me.btnGestionReservas.TabIndex = 3
        Me.btnGestionReservas.Text = "Gestionar Reservas"
        Me.btnGestionReservas.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(688, 74)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 25)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Desconectar"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGestionReservas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGestionUsuarios)
        Me.Controls.Add(Me.btnGestionAlojamientos)
        Me.Name = "MenuGestion"
        Me.Text = "Menú"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGestionAlojamientos As Button
    Friend WithEvents btnGestionUsuarios As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGestionReservas As Button
    Friend WithEvents btnLogout As Button
End Class
