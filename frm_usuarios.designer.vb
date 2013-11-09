<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
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
        Me.btAgregarUsuario = New System.Windows.Forms.Button
        Me.gbFiltroUsuario = New System.Windows.Forms.GroupBox
        Me.cbTiposDeUsuarios = New System.Windows.Forms.ComboBox
        Me.lbTipoDeUsuario = New System.Windows.Forms.Label
        Me.tbPalabraClaveUsuario = New System.Windows.Forms.TextBox
        Me.dgUsuarios = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipo_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipo_usuario_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbAccionesUsuarios = New System.Windows.Forms.GroupBox
        Me.btEliminarUsuario = New System.Windows.Forms.Button
        Me.btEditarUsuario = New System.Windows.Forms.Button
        Me.btImprimirUsuario = New System.Windows.Forms.Button
        Me.gbFiltroUsuario.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAccionesUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btAgregarUsuario
        '
        Me.btAgregarUsuario.Location = New System.Drawing.Point(466, 12)
        Me.btAgregarUsuario.Name = "btAgregarUsuario"
        Me.btAgregarUsuario.Size = New System.Drawing.Size(112, 23)
        Me.btAgregarUsuario.TabIndex = 0
        Me.btAgregarUsuario.Text = "Agregar Usuario"
        Me.btAgregarUsuario.UseVisualStyleBackColor = True
        '
        'gbFiltroUsuario
        '
        Me.gbFiltroUsuario.Controls.Add(Me.cbTiposDeUsuarios)
        Me.gbFiltroUsuario.Controls.Add(Me.lbTipoDeUsuario)
        Me.gbFiltroUsuario.Controls.Add(Me.tbPalabraClaveUsuario)
        Me.gbFiltroUsuario.Location = New System.Drawing.Point(23, 41)
        Me.gbFiltroUsuario.Name = "gbFiltroUsuario"
        Me.gbFiltroUsuario.Size = New System.Drawing.Size(555, 61)
        Me.gbFiltroUsuario.TabIndex = 1
        Me.gbFiltroUsuario.TabStop = False
        Me.gbFiltroUsuario.Text = "Buscar Usuarios"
        '
        'cbTiposDeUsuarios
        '
        Me.cbTiposDeUsuarios.DisplayMember = "0"
        Me.cbTiposDeUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposDeUsuarios.FormattingEnabled = True
        Me.cbTiposDeUsuarios.Items.AddRange(New Object() {"Todos", "Administrador", "Gerente", "Usuario"})
        Me.cbTiposDeUsuarios.Location = New System.Drawing.Point(423, 25)
        Me.cbTiposDeUsuarios.Name = "cbTiposDeUsuarios"
        Me.cbTiposDeUsuarios.Size = New System.Drawing.Size(121, 24)
        Me.cbTiposDeUsuarios.TabIndex = 2
        '
        'lbTipoDeUsuario
        '
        Me.lbTipoDeUsuario.AutoSize = True
        Me.lbTipoDeUsuario.Location = New System.Drawing.Point(315, 28)
        Me.lbTipoDeUsuario.Name = "lbTipoDeUsuario"
        Me.lbTipoDeUsuario.Size = New System.Drawing.Size(100, 16)
        Me.lbTipoDeUsuario.TabIndex = 1
        Me.lbTipoDeUsuario.Text = "Tipo de Usuario"
        '
        'tbPalabraClaveUsuario
        '
        Me.tbPalabraClaveUsuario.Location = New System.Drawing.Point(12, 25)
        Me.tbPalabraClaveUsuario.Name = "tbPalabraClaveUsuario"
        Me.tbPalabraClaveUsuario.Size = New System.Drawing.Size(284, 26)
        Me.tbPalabraClaveUsuario.TabIndex = 0
        Me.tbPalabraClaveUsuario.Text = "Palabra Clave"
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AllowUserToResizeColumns = False
        Me.dgUsuarios.AllowUserToResizeRows = False
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.usuario, Me.nombre, Me.tipo_usuario, Me.tipo_usuario_id, Me.password})
        Me.dgUsuarios.Location = New System.Drawing.Point(23, 109)
        Me.dgUsuarios.MultiSelect = False
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(555, 257)
        Me.dgUsuarios.TabIndex = 2
        '
        'id
        '
        Me.id.Frozen = True
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id.Width = 30
        '
        'usuario
        '
        Me.usuario.Frozen = True
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.MinimumWidth = 100
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usuario.Width = 160
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre.Frozen = True
        Me.nombre.HeaderText = "Nombre Completo"
        Me.nombre.MinimumWidth = 100
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombre.Width = 240
        '
        'tipo_usuario
        '
        Me.tipo_usuario.Frozen = True
        Me.tipo_usuario.HeaderText = "Tipo"
        Me.tipo_usuario.MinimumWidth = 50
        Me.tipo_usuario.Name = "tipo_usuario"
        Me.tipo_usuario.ReadOnly = True
        Me.tipo_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tipo_usuario.Width = 125
        '
        'tipo_usuario_id
        '
        Me.tipo_usuario_id.Frozen = True
        Me.tipo_usuario_id.HeaderText = "Tipo Usuario Id"
        Me.tipo_usuario_id.Name = "tipo_usuario_id"
        Me.tipo_usuario_id.ReadOnly = True
        Me.tipo_usuario_id.Visible = False
        '
        'password
        '
        Me.password.Frozen = True
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Visible = False
        '
        'gbAccionesUsuarios
        '
        Me.gbAccionesUsuarios.Controls.Add(Me.btImprimirUsuario)
        Me.gbAccionesUsuarios.Controls.Add(Me.btEliminarUsuario)
        Me.gbAccionesUsuarios.Controls.Add(Me.btEditarUsuario)
        Me.gbAccionesUsuarios.Location = New System.Drawing.Point(23, 373)
        Me.gbAccionesUsuarios.Name = "gbAccionesUsuarios"
        Me.gbAccionesUsuarios.Size = New System.Drawing.Size(555, 55)
        Me.gbAccionesUsuarios.TabIndex = 3
        Me.gbAccionesUsuarios.TabStop = False
        Me.gbAccionesUsuarios.Text = "Acciones"
        '
        'btEliminarUsuario
        '
        Me.btEliminarUsuario.Enabled = False
        Me.btEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btEliminarUsuario.Location = New System.Drawing.Point(98, 23)
        Me.btEliminarUsuario.Name = "btEliminarUsuario"
        Me.btEliminarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btEliminarUsuario.TabIndex = 1
        Me.btEliminarUsuario.Text = "Eliminar"
        Me.btEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btEditarUsuario
        '
        Me.btEditarUsuario.Enabled = False
        Me.btEditarUsuario.Location = New System.Drawing.Point(12, 23)
        Me.btEditarUsuario.Name = "btEditarUsuario"
        Me.btEditarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btEditarUsuario.TabIndex = 0
        Me.btEditarUsuario.Text = "Editar"
        Me.btEditarUsuario.UseVisualStyleBackColor = True
        '
        'btImprimirUsuario
        '
        Me.btImprimirUsuario.Location = New System.Drawing.Point(211, 23)
        Me.btImprimirUsuario.Name = "btImprimirUsuario"
        Me.btImprimirUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btImprimirUsuario.TabIndex = 2
        Me.btImprimirUsuario.Text = "Imprimir"
        Me.btImprimirUsuario.UseVisualStyleBackColor = True
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 434)
        Me.Controls.Add(Me.gbAccionesUsuarios)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.gbFiltroUsuario)
        Me.Controls.Add(Me.btAgregarUsuario)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_usuarios"
        Me.Text = "Administrador de Usuarios"
        Me.gbFiltroUsuario.ResumeLayout(False)
        Me.gbFiltroUsuario.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAccionesUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btAgregarUsuario As System.Windows.Forms.Button
    Friend WithEvents gbFiltroUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents tbPalabraClaveUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lbTipoDeUsuario As System.Windows.Forms.Label
    Friend WithEvents cbTiposDeUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents gbAccionesUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents btEditarUsuario As System.Windows.Forms.Button
    Friend WithEvents btEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_usuario_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btImprimirUsuario As System.Windows.Forms.Button
End Class
