<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agregar_usuario
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
        Me.lyGridUsuario = New System.Windows.Forms.TableLayoutPanel
        Me.lbTipoDeUsuarioAgregarUsuario = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbIdUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbUsuarioAgregar = New System.Windows.Forms.TextBox
        Me.tbClaveUsuarioAgregar = New System.Windows.Forms.TextBox
        Me.tbNombreCompleto = New System.Windows.Forms.TextBox
        Me.cbTipoDeUsuarioAgregarUsuario = New System.Windows.Forms.ComboBox
        Me.lbIdUsuario = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btGuardarUsuario = New System.Windows.Forms.Button
        Me.btCancelarAgregarUsuario = New System.Windows.Forms.Button
        Me.lyGridUsuario.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lyGridUsuario
        '
        Me.lyGridUsuario.AutoSize = True
        Me.lyGridUsuario.ColumnCount = 2
        Me.lyGridUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.lyGridUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.lyGridUsuario.Controls.Add(Me.lbTipoDeUsuarioAgregarUsuario, 0, 4)
        Me.lyGridUsuario.Controls.Add(Me.Label3, 0, 3)
        Me.lyGridUsuario.Controls.Add(Me.Label2, 0, 2)
        Me.lyGridUsuario.Controls.Add(Me.tbIdUsuario, 1, 0)
        Me.lyGridUsuario.Controls.Add(Me.Label1, 0, 1)
        Me.lyGridUsuario.Controls.Add(Me.tbUsuarioAgregar, 1, 1)
        Me.lyGridUsuario.Controls.Add(Me.tbClaveUsuarioAgregar, 1, 2)
        Me.lyGridUsuario.Controls.Add(Me.tbNombreCompleto, 1, 3)
        Me.lyGridUsuario.Controls.Add(Me.cbTipoDeUsuarioAgregarUsuario, 1, 4)
        Me.lyGridUsuario.Controls.Add(Me.lbIdUsuario, 0, 0)
        Me.lyGridUsuario.Location = New System.Drawing.Point(12, 21)
        Me.lyGridUsuario.Name = "lyGridUsuario"
        Me.lyGridUsuario.RowCount = 5
        Me.lyGridUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyGridUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyGridUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyGridUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyGridUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.lyGridUsuario.Size = New System.Drawing.Size(298, 162)
        Me.lyGridUsuario.TabIndex = 0
        '
        'lbTipoDeUsuarioAgregarUsuario
        '
        Me.lbTipoDeUsuarioAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbTipoDeUsuarioAgregarUsuario.AutoSize = True
        Me.lbTipoDeUsuarioAgregarUsuario.Location = New System.Drawing.Point(17, 137)
        Me.lbTipoDeUsuarioAgregarUsuario.Name = "lbTipoDeUsuarioAgregarUsuario"
        Me.lbTipoDeUsuarioAgregarUsuario.Size = New System.Drawing.Size(100, 16)
        Me.lbTipoDeUsuarioAgregarUsuario.TabIndex = 8
        Me.lbTipoDeUsuarioAgregarUsuario.Text = "Tipo de Usuario"
        Me.lbTipoDeUsuarioAgregarUsuario.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clave"
        '
        'tbIdUsuario
        '
        Me.tbIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbIdUsuario.Enabled = False
        Me.tbIdUsuario.Location = New System.Drawing.Point(123, 3)
        Me.tbIdUsuario.Name = "tbIdUsuario"
        Me.tbIdUsuario.Size = New System.Drawing.Size(156, 26)
        Me.tbIdUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'tbUsuarioAgregar
        '
        Me.tbUsuarioAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbUsuarioAgregar.Location = New System.Drawing.Point(123, 35)
        Me.tbUsuarioAgregar.Name = "tbUsuarioAgregar"
        Me.tbUsuarioAgregar.Size = New System.Drawing.Size(156, 26)
        Me.tbUsuarioAgregar.TabIndex = 3
        '
        'tbClaveUsuarioAgregar
        '
        Me.tbClaveUsuarioAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbClaveUsuarioAgregar.Location = New System.Drawing.Point(123, 67)
        Me.tbClaveUsuarioAgregar.Name = "tbClaveUsuarioAgregar"
        Me.tbClaveUsuarioAgregar.Size = New System.Drawing.Size(156, 26)
        Me.tbClaveUsuarioAgregar.TabIndex = 5
        Me.tbClaveUsuarioAgregar.UseSystemPasswordChar = True
        '
        'tbNombreCompleto
        '
        Me.tbNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbNombreCompleto.Location = New System.Drawing.Point(123, 99)
        Me.tbNombreCompleto.Name = "tbNombreCompleto"
        Me.tbNombreCompleto.Size = New System.Drawing.Size(156, 26)
        Me.tbNombreCompleto.TabIndex = 7
        '
        'cbTipoDeUsuarioAgregarUsuario
        '
        Me.cbTipoDeUsuarioAgregarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDeUsuarioAgregarUsuario.FormattingEnabled = True
        Me.cbTipoDeUsuarioAgregarUsuario.Items.AddRange(New Object() {"Tipo de Usuario", "Administrador", "Gerente", "Usuario"})
        Me.cbTipoDeUsuarioAgregarUsuario.Location = New System.Drawing.Point(123, 131)
        Me.cbTipoDeUsuarioAgregarUsuario.Name = "cbTipoDeUsuarioAgregarUsuario"
        Me.cbTipoDeUsuarioAgregarUsuario.Size = New System.Drawing.Size(156, 24)
        Me.cbTipoDeUsuarioAgregarUsuario.TabIndex = 9
        Me.cbTipoDeUsuarioAgregarUsuario.Visible = False
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbIdUsuario.AutoSize = True
        Me.lbIdUsuario.Location = New System.Drawing.Point(98, 8)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(19, 16)
        Me.lbIdUsuario.TabIndex = 0
        Me.lbIdUsuario.Text = "Id"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btGuardarUsuario, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btCancelarAgregarUsuario, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 198)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(298, 38)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btGuardarUsuario
        '
        Me.btGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btGuardarUsuario.Location = New System.Drawing.Point(186, 7)
        Me.btGuardarUsuario.Name = "btGuardarUsuario"
        Me.btGuardarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btGuardarUsuario.TabIndex = 0
        Me.btGuardarUsuario.Text = "Guardar"
        Me.btGuardarUsuario.UseVisualStyleBackColor = True
        '
        'btCancelarAgregarUsuario
        '
        Me.btCancelarAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btCancelarAgregarUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelarAgregarUsuario.Location = New System.Drawing.Point(37, 7)
        Me.btCancelarAgregarUsuario.Name = "btCancelarAgregarUsuario"
        Me.btCancelarAgregarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btCancelarAgregarUsuario.TabIndex = 1
        Me.btCancelarAgregarUsuario.Text = "Cancelar"
        Me.btCancelarAgregarUsuario.UseVisualStyleBackColor = True
        '
        'frm_agregar_usuario
        '
        Me.AcceptButton = Me.btGuardarUsuario
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancelarAgregarUsuario
        Me.ClientSize = New System.Drawing.Size(322, 250)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.lyGridUsuario)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_agregar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Agregar Usuario"
        Me.lyGridUsuario.ResumeLayout(False)
        Me.lyGridUsuario.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lyGridUsuario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbIdUsuario As System.Windows.Forms.Label
    Friend WithEvents tbIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbUsuarioAgregar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbClaveUsuarioAgregar As System.Windows.Forms.TextBox
    Friend WithEvents lbTipoDeUsuarioAgregarUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDeUsuarioAgregarUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btGuardarUsuario As System.Windows.Forms.Button
    Friend WithEvents btCancelarAgregarUsuario As System.Windows.Forms.Button
End Class
