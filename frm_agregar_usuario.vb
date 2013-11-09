Public Class frm_agregar_usuario
    Public edit_mode As Boolean = False
    Public from_settings As Boolean = False

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTipoDeUsuarioAgregarUsuario.Click

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub frm_agregar_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lbIdUsuario.Hide()
        'tbIdUsuario.Hide()

        '' NO LO TENEMOS '' limpiarFormAltaUsuario()

        'If (frm_usuarios.dgUsuarios.SelectedRows.Count > 0 And edit_mode = True) Then
        '    'Si se selecciono un item entonces podemos editarlo
        '    tbIdUsuario.Text = frm_usuarios.dgUsuarios.Item("id", frm_usuarios.dgUsuarios.SelectedRows(0).Index).Value.ToString
        '    tbUsuarioAgregar.Text = frm_usuarios.dgUsuarios.Item("usuario", frm_usuarios.dgUsuarios.SelectedRows(0).Index).Value.ToString
        '    tbClaveUsuarioAgregar.Text = frm_usuarios.dgUsuarios.Item("password", frm_usuarios.dgUsuarios.SelectedRows(0).Index).Value.ToString
        '    tbNombreCompleto.Text = frm_usuarios.dgUsuarios.Item("nombre", frm_usuarios.dgUsuarios.SelectedRows(0).Index).Value.ToString
        '    If (loggedin_user.isAdmin Or loggedin_user.isGerente) Then
        '        lbTipoDeUsuarioAgregarUsuario.Visible = True
        '        cbTipoDeUsuarioAgregarUsuario.Visible = True
        '        cbTipoDeUsuarioAgregarUsuario.SelectedIndex = frm_usuarios.dgUsuarios.Item("tipo_usuario_id", frm_usuarios.dgUsuarios.SelectedRows(0).Index).Value
        '    End If
        'Else
        '    If (from_settings = True And edit_mode = True) Then
        '        tbIdUsuario.Text = loggedin_user.id.ToString
        '        tbUsuarioAgregar.Text = loggedin_user.usuario
        '        tbClaveUsuarioAgregar.Text = loggedin_user.clave
        '        tbNombreCompleto.Text = loggedin_user.nombre
        '    Else
        '        tbIdUsuario.Text = getLastUserId.ToString()
        '    End If
        'End If
    End Sub

    Private Sub btCancelarAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarAgregarUsuario.Click
        Me.Close()
    End Sub

    Private Sub lyGridUsuario_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lyGridUsuario.Paint

    End Sub

    Private Sub btGuardarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardarUsuario.Click
        '    Dim data_user As New Hashtable()
        '    data_user.Add("usuario", tbUsuarioAgregar.Text)
        '    data_user.Add("password", tbClaveUsuarioAgregar.Text)
        '    data_user.Add("nombre", tbNombreCompleto.Text)
        '    If (from_settings = False) Then
        '        data_user.Add("tipo_usuario_id", cbTipoDeUsuarioAgregarUsuario.SelectedIndex)
        '    End If
        '    data_user.Add("activo", 1)
        '    If (edit_mode = True) Then
        '        data_user.Add("id", tbIdUsuario.Text)
        '        If (editarUsuario(Convert.ToInt32(tbIdUsuario.Text), data_user)) Then
        '            refreshGridUsuarios(getUsuarios())
        '            If (from_settings = True) Then
        '                MsgBox("Sus nuevos datos ya fueron actualizados.")
        '            End If
        '            refreshStatusBar()
        '            Me.Close()
        '        End If
        '    Else
        '        If (validarUsuario(data_user)) Then
        '            If (agregarUsuario(data_user)) Then
        '                refreshGridUsuarios(getUsuarios())
        '                Me.Close()
        '            End If
        '        End If
        '    End If


        'End Sub

        'Private Sub frm_agregar_usuario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        '    If (from_settings = True) Then
        '        cbTipoDeUsuarioAgregarUsuario.Visible = False
        '        lbTipoDeUsuarioAgregarUsuario.Visible = False
        '    Else
        '        cbTipoDeUsuarioAgregarUsuario.Visible = True
        '        lbTipoDeUsuarioAgregarUsuario.Visible = True
        '    End If
    End Sub

    Private Sub TableLayoutPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class