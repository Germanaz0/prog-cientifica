<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cartera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cartera))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Cbo_opcion = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Lv_efectivo = New System.Windows.Forms.ListView
        Me.Tb_num_fac = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RB_efec_egr = New System.Windows.Forms.RadioButton
        Me.RB_efec_ing = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija Opcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Cbo_opcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Empresa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(389, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(309, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Cbo_opcion
        '
        Me.Cbo_opcion.FormattingEnabled = True
        Me.Cbo_opcion.Location = New System.Drawing.Point(96, 19)
        Me.Cbo_opcion.Name = "Cbo_opcion"
        Me.Cbo_opcion.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_opcion.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Lv_efectivo)
        Me.GroupBox2.Controls.Add(Me.Tb_num_fac)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.RB_efec_egr)
        Me.GroupBox2.Controls.Add(Me.RB_efec_ing)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 292)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Efectivo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(123, 151)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Monto Factura"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(102, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(572, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 11
        '
        'Lv_efectivo
        '
        Me.Lv_efectivo.Location = New System.Drawing.Point(418, 79)
        Me.Lv_efectivo.Name = "Lv_efectivo"
        Me.Lv_efectivo.Size = New System.Drawing.Size(430, 163)
        Me.Lv_efectivo.TabIndex = 10
        Me.Lv_efectivo.UseCompatibleStateImageBehavior = False
        '
        'Tb_num_fac
        '
        Me.Tb_num_fac.Location = New System.Drawing.Point(123, 102)
        Me.Tb_num_fac.Name = "Tb_num_fac"
        Me.Tb_num_fac.Size = New System.Drawing.Size(143, 20)
        Me.Tb_num_fac.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Numero de Factura"
        '
        'RB_efec_egr
        '
        Me.RB_efec_egr.AutoSize = True
        Me.RB_efec_egr.Location = New System.Drawing.Point(87, 29)
        Me.RB_efec_egr.Name = "RB_efec_egr"
        Me.RB_efec_egr.Size = New System.Drawing.Size(58, 17)
        Me.RB_efec_egr.TabIndex = 1
        Me.RB_efec_egr.TabStop = True
        Me.RB_efec_egr.Text = "Egreso"
        Me.RB_efec_egr.UseVisualStyleBackColor = True
        '
        'RB_efec_ing
        '
        Me.RB_efec_ing.AutoSize = True
        Me.RB_efec_ing.Location = New System.Drawing.Point(6, 29)
        Me.RB_efec_ing.Name = "RB_efec_ing"
        Me.RB_efec_ing.Size = New System.Drawing.Size(60, 17)
        Me.RB_efec_ing.TabIndex = 0
        Me.RB_efec_ing.TabStop = True
        Me.RB_efec_ing.Text = "Ingreso"
        Me.RB_efec_ing.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(29, 441)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(874, 73)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cheques"
        '
        'frm_Cartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(959, 569)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Cartera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Cartera"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_opcion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_efec_egr As System.Windows.Forms.RadioButton
    Friend WithEvents RB_efec_ing As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lv_efectivo As System.Windows.Forms.ListView
    Friend WithEvents Tb_num_fac As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
