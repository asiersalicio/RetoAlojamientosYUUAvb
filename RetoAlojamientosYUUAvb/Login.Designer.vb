<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.lablUsuario = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPassword = New MaterialSkin.Controls.MaterialLabel()
        Me.tbUsuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnAcceder = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'lablUsuario
        '
        Me.lablUsuario.AutoSize = True
        Me.lablUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.lablUsuario.Depth = 0
        Me.lablUsuario.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lablUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lablUsuario.Location = New System.Drawing.Point(169, 186)
        Me.lablUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.lablUsuario.Name = "lablUsuario"
        Me.lablUsuario.Size = New System.Drawing.Size(61, 19)
        Me.lablUsuario.TabIndex = 1
        Me.lablUsuario.Text = "Usuario"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Window
        Me.lblPassword.Depth = 0
        Me.lblPassword.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(168, 231)
        Me.lblPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 19)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Contraseña"
        '
        'tbUsuario
        '
        Me.tbUsuario.Depth = 0
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.tbUsuario.Hint = ""
        Me.tbUsuario.Location = New System.Drawing.Point(320, 180)
        Me.tbUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsuario.SelectedText = ""
        Me.tbUsuario.SelectionLength = 0
        Me.tbUsuario.SelectionStart = 0
        Me.tbUsuario.Size = New System.Drawing.Size(224, 23)
        Me.tbUsuario.TabIndex = 0
        Me.tbUsuario.TabStop = False
        Me.tbUsuario.UseSystemPasswordChar = False
        '
        'tbPassword
        '
        Me.tbPassword.Depth = 0
        Me.tbPassword.Font = New System.Drawing.Font("Garamond", 11.0!)
        Me.tbPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbPassword.Hint = ""
        Me.tbPassword.Location = New System.Drawing.Point(320, 227)
        Me.tbPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.SelectionLength = 0
        Me.tbPassword.SelectionStart = 0
        Me.tbPassword.Size = New System.Drawing.Size(224, 23)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.TabStop = False
        Me.tbPassword.UseSystemPasswordChar = False
        '
        'btnAcceder
        '
        Me.btnAcceder.AutoSize = True
        Me.btnAcceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAcceder.Depth = 0
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Font = New System.Drawing.Font("Garamond", 11.0!)
        Me.btnAcceder.Location = New System.Drawing.Point(242, 294)
        Me.btnAcceder.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAcceder.MinimumSize = New System.Drawing.Size(250, 0)
        Me.btnAcceder.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Primary = False
        Me.btnAcceder.Size = New System.Drawing.Size(250, 36)
        Me.btnAcceder.TabIndex = 2
        Me.btnAcceder.TabStop = False
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lablUsuario)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lablUsuario As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPassword As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbUsuario As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnAcceder As MaterialSkin.Controls.MaterialFlatButton
End Class
