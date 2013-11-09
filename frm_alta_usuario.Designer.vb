<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_usuario))
        Me.b_cancelar = New System.Windows.Forms.Button
        Me.b_guardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Combo_Perfil = New System.Windows.Forms.ComboBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumeroF = New System.Windows.Forms.Label
        Me.Combo_País = New System.Windows.Forms.ComboBox
        Me.Carac = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Combo_Loc = New System.Windows.Forms.ComboBox
        Me.Combo_Prov = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Combo_Perfil1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_cancelar
        '
        Me.b_cancelar.BackgroundImage = CType(resources.GetObject("b_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.b_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.b_cancelar.Location = New System.Drawing.Point(533, 339)
        Me.b_cancelar.Name = "b_cancelar"
        Me.b_cancelar.Size = New System.Drawing.Size(73, 27)
        Me.b_cancelar.TabIndex = 24
        Me.b_cancelar.Text = "Cancelar"
        Me.b_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_cancelar.UseVisualStyleBackColor = True
        '
        'b_guardar
        '
        Me.b_guardar.BackgroundImage = CType(resources.GetObject("b_guardar.BackgroundImage"), System.Drawing.Image)
        Me.b_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.b_guardar.Location = New System.Drawing.Point(409, 339)
        Me.b_guardar.Name = "b_guardar"
        Me.b_guardar.Size = New System.Drawing.Size(118, 27)
        Me.b_guardar.TabIndex = 22
        Me.b_guardar.Text = "Guardar cambios"
        Me.b_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Combo_Perfil)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumeroF)
        Me.GroupBox1.Controls.Add(Me.Combo_País)
        Me.GroupBox1.Controls.Add(Me.Carac)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Combo_Loc)
        Me.GroupBox1.Controls.Add(Me.Combo_Prov)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(109, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 335)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(302, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Password"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(304, 301)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox8.Size = New System.Drawing.Size(126, 20)
        Me.TextBox8.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(302, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Login"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(304, 257)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(126, 20)
        Me.TextBox7.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Perfil"
        '
        'Combo_Perfil
        '
        Me.Combo_Perfil.FormattingEnabled = True
        Me.Combo_Perfil.Location = New System.Drawing.Point(304, 201)
        Me.Combo_Perfil.Name = "Combo_Perfil"
        Me.Combo_Perfil.Size = New System.Drawing.Size(132, 21)
        Me.Combo_Perfil.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(390, 145)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(90, 20)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(305, 145)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(48, 20)
        Me.TextBox5.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "País"
        '
        'NumeroF
        '
        Me.NumeroF.AutoSize = True
        Me.NumeroF.Location = New System.Drawing.Point(387, 124)
        Me.NumeroF.Name = "NumeroF"
        Me.NumeroF.Size = New System.Drawing.Size(44, 13)
        Me.NumeroF.TabIndex = 21
        Me.NumeroF.Text = "Numero"
        '
        'Combo_País
        '
        Me.Combo_País.FormattingEnabled = True
        Me.Combo_País.Location = New System.Drawing.Point(58, 202)
        Me.Combo_País.Name = "Combo_País"
        Me.Combo_País.Size = New System.Drawing.Size(131, 21)
        Me.Combo_País.TabIndex = 14
        '
        'Carac
        '
        Me.Carac.AutoSize = True
        Me.Carac.Location = New System.Drawing.Point(302, 124)
        Me.Carac.Name = "Carac"
        Me.Carac.Size = New System.Drawing.Size(68, 13)
        Me.Carac.TabIndex = 20
        Me.Carac.Text = "Cod. de area"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(305, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(111, 20)
        Me.TextBox4.TabIndex = 13
        '
        'Combo_Loc
        '
        Me.Combo_Loc.FormattingEnabled = True
        Me.Combo_Loc.Location = New System.Drawing.Point(305, 36)
        Me.Combo_Loc.Name = "Combo_Loc"
        Me.Combo_Loc.Size = New System.Drawing.Size(131, 21)
        Me.Combo_Loc.TabIndex = 12
        '
        'Combo_Prov
        '
        Me.Combo_Prov.FormattingEnabled = True
        Me.Combo_Prov.Location = New System.Drawing.Point(58, 257)
        Me.Combo_Prov.Name = "Combo_Prov"
        Me.Combo_Prov.Size = New System.Drawing.Size(131, 21)
        Me.Combo_Prov.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "D.N.I"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(58, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(58, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(58, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Combo_Perfil1
        '
        Me.Combo_Perfil1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Combo_Perfil1.Location = New System.Drawing.Point(744, 378)
        Me.Combo_Perfil1.Name = "Combo_Perfil1"
        Me.Combo_Perfil1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Combo_Perfil1.Size = New System.Drawing.Size(10, 20)
        Me.Combo_Perfil1.TabIndex = 28
        Me.Combo_Perfil1.Visible = False
        '
        'ABM_usu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(756, 410)
        Me.Controls.Add(Me.Combo_Perfil1)
        Me.Controls.Add(Me.b_cancelar)
        Me.Controls.Add(Me.b_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ABM_usu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_cancelar As System.Windows.Forms.Button
    Friend WithEvents b_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Combo_Perfil As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumeroF As System.Windows.Forms.Label
    Friend WithEvents Combo_País As System.Windows.Forms.ComboBox
    Friend WithEvents Carac As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Combo_Loc As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_Prov As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Combo_Perfil1 As System.Windows.Forms.TextBox
End Class
