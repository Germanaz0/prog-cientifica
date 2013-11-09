<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Log_salir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Log_ingr = New System.Windows.Forms.Button
        Me.Log_usuario = New System.Windows.Forms.TextBox
        Me.Log_contra = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Log_salir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Log_ingr)
        Me.GroupBox1.Controls.Add(Me.Log_usuario)
        Me.GroupBox1.Controls.Add(Me.Log_contra)
        Me.GroupBox1.Location = New System.Drawing.Point(247, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 203)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña"
        '
        'Log_salir
        '
        Me.Log_salir.Location = New System.Drawing.Point(55, 135)
        Me.Log_salir.Name = "Log_salir"
        Me.Log_salir.Size = New System.Drawing.Size(92, 32)
        Me.Log_salir.TabIndex = 9
        Me.Log_salir.Text = "Salir"
        Me.Log_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario"
        '
        'Log_ingr
        '
        Me.Log_ingr.Location = New System.Drawing.Point(153, 135)
        Me.Log_ingr.Name = "Log_ingr"
        Me.Log_ingr.Size = New System.Drawing.Size(92, 32)
        Me.Log_ingr.TabIndex = 8
        Me.Log_ingr.Text = "Ingresar"
        Me.Log_ingr.UseVisualStyleBackColor = True
        '
        'Log_usuario
        '
        Me.Log_usuario.Location = New System.Drawing.Point(107, 46)
        Me.Log_usuario.Name = "Log_usuario"
        Me.Log_usuario.Size = New System.Drawing.Size(124, 20)
        Me.Log_usuario.TabIndex = 1
        '
        'Log_contra
        '
        Me.Log_contra.Location = New System.Drawing.Point(107, 92)
        Me.Log_contra.Name = "Log_contra"
        Me.Log_contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Log_contra.Size = New System.Drawing.Size(124, 20)
        Me.Log_contra.TabIndex = 2
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(759, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar - Sistema de Cajas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Log_salir As System.Windows.Forms.Button
    Friend WithEvents Log_ingr As System.Windows.Forms.Button
    Friend WithEvents Log_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Log_contra As System.Windows.Forms.TextBox

End Class
