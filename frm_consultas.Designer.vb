<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consultas))
        Me.LV_Consulta = New System.Windows.Forms.ListView
        Me.T_Cliente = New System.Windows.Forms.TextBox
        Me.T_Usuario = New System.Windows.Forms.TextBox
        Me.b_editar = New System.Windows.Forms.Button
        Me.b_nuevo = New System.Windows.Forms.Button
        Me.b_eliminar = New System.Windows.Forms.Button
        Me.Combo_campo = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tex_busqueda = New System.Windows.Forms.TextBox
        Me.Consulta = New System.Windows.Forms.Label
        Me.Combo_busqueda = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV_Consulta
        '
        Me.LV_Consulta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LV_Consulta.Location = New System.Drawing.Point(21, 107)
        Me.LV_Consulta.Name = "LV_Consulta"
        Me.LV_Consulta.Size = New System.Drawing.Size(634, 384)
        Me.LV_Consulta.TabIndex = 5
        Me.LV_Consulta.UseCompatibleStateImageBehavior = False
        '
        'T_Cliente
        '
        Me.T_Cliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.T_Cliente.Location = New System.Drawing.Point(602, 442)
        Me.T_Cliente.Name = "T_Cliente"
        Me.T_Cliente.Size = New System.Drawing.Size(11, 20)
        Me.T_Cliente.TabIndex = 8
        Me.T_Cliente.Visible = False
        '
        'T_Usuario
        '
        Me.T_Usuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.T_Usuario.Location = New System.Drawing.Point(612, 442)
        Me.T_Usuario.Name = "T_Usuario"
        Me.T_Usuario.Size = New System.Drawing.Size(11, 20)
        Me.T_Usuario.TabIndex = 9
        Me.T_Usuario.Visible = False
        '
        'b_editar
        '
        Me.b_editar.BackgroundImage = CType(resources.GetObject("b_editar.BackgroundImage"), System.Drawing.Image)
        Me.b_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.b_editar.Location = New System.Drawing.Point(294, 75)
        Me.b_editar.Name = "b_editar"
        Me.b_editar.Size = New System.Drawing.Size(83, 26)
        Me.b_editar.TabIndex = 33
        Me.b_editar.Text = "Editar"
        Me.b_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_editar.UseVisualStyleBackColor = True
        '
        'b_nuevo
        '
        Me.b_nuevo.BackgroundImage = CType(resources.GetObject("b_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.b_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.b_nuevo.Location = New System.Drawing.Point(205, 75)
        Me.b_nuevo.Name = "b_nuevo"
        Me.b_nuevo.Size = New System.Drawing.Size(83, 27)
        Me.b_nuevo.TabIndex = 31
        Me.b_nuevo.Text = "Nuevo"
        Me.b_nuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_nuevo.UseVisualStyleBackColor = True
        '
        'b_eliminar
        '
        Me.b_eliminar.BackgroundImage = CType(resources.GetObject("b_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.b_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.b_eliminar.Location = New System.Drawing.Point(383, 75)
        Me.b_eliminar.Name = "b_eliminar"
        Me.b_eliminar.Size = New System.Drawing.Size(83, 26)
        Me.b_eliminar.TabIndex = 30
        Me.b_eliminar.Text = "Eliminar"
        Me.b_eliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_eliminar.UseVisualStyleBackColor = True
        '
        'Combo_campo
        '
        Me.Combo_campo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Combo_campo.FormattingEnabled = True
        Me.Combo_campo.Location = New System.Drawing.Point(88, 12)
        Me.Combo_campo.Name = "Combo_campo"
        Me.Combo_campo.Size = New System.Drawing.Size(146, 21)
        Me.Combo_campo.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(639, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 27)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tex_busqueda
        '
        Me.tex_busqueda.Location = New System.Drawing.Point(487, 11)
        Me.tex_busqueda.Name = "tex_busqueda"
        Me.tex_busqueda.Size = New System.Drawing.Size(146, 20)
        Me.tex_busqueda.TabIndex = 38
        '
        'Consulta
        '
        Me.Consulta.AutoSize = True
        Me.Consulta.Location = New System.Drawing.Point(6, 14)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(63, 13)
        Me.Consulta.TabIndex = 37
        Me.Consulta.Text = "Consulta de"
        '
        'Combo_busqueda
        '
        Me.Combo_busqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Combo_busqueda.FormattingEnabled = True
        Me.Combo_busqueda.Location = New System.Drawing.Point(317, 11)
        Me.Combo_busqueda.Name = "Combo_busqueda"
        Me.Combo_busqueda.Size = New System.Drawing.Size(146, 21)
        Me.Combo_busqueda.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Buscar por"
        '
        'Frm_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combo_busqueda)
        Me.Controls.Add(Me.Combo_campo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tex_busqueda)
        Me.Controls.Add(Me.Consulta)
        Me.Controls.Add(Me.b_editar)
        Me.Controls.Add(Me.b_nuevo)
        Me.Controls.Add(Me.b_eliminar)
        Me.Controls.Add(Me.LV_Consulta)
        Me.Controls.Add(Me.T_Cliente)
        Me.Controls.Add(Me.T_Usuario)
        Me.Name = "Frm_Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV_Consulta As System.Windows.Forms.ListView
    Friend WithEvents T_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents T_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents b_editar As System.Windows.Forms.Button
    Friend WithEvents b_nuevo As System.Windows.Forms.Button
    Friend WithEvents b_eliminar As System.Windows.Forms.Button
    Friend WithEvents Combo_campo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tex_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Consulta As System.Windows.Forms.Label
    Friend WithEvents Combo_busqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
