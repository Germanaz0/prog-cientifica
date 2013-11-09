Public Class frm_usuarios
    Dim data_usuarios As DataTable
    

    Private Sub frm_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cbTiposDeUsuarios.SelectedIndex = 0

        ' ''Traemos todos los usuarios de la DB
        'data_usuarios = getUsuarios()
        'refreshGridUsuarios(data_usuarios)

        ''Ponemos a la busqueda como foco
        'tbPalabraClaveUsuario.Focus()
    End Sub

    Private Sub gbAccionesUsuarios_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbAccionesUsuarios.Enter

    End Sub

    Private Sub dgUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.CellContentClick

    End Sub

    Private Sub dgUsuarios_CellContextMenuStripNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dgUsuarios.CellContextMenuStripNeeded

    End Sub

    Private Sub dgUsuarios_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.CellEnter
    End Sub

    Private Sub dgUsuarios_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.RowEnter
        'Activamos los botones de Eliminar y Editar
        'btEliminarUsuario.Enabled = True
        'btEditarUsuario.Enabled = True
    End Sub

    Private Sub dgUsuarios_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.RowLeave
        'btEliminarUsuario.Enabled = False
        'btEditarUsuario.Enabled = False
    End Sub

    Private Sub cbTiposDeUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTiposDeUsuarios.SelectedIndexChanged
        'data_usuarios = getUsuarios("", cbTiposDeUsuarios.SelectedIndex)
        'refreshGridUsuarios(data_usuarios)
    End Sub

    Private Sub tbPalabraClaveUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPalabraClaveUsuario.GotFocus
        'tbPalabraClaveUsuario.Text = ""
    End Sub

    Private Sub tbPalabraClaveUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPalabraClaveUsuario.TextChanged
        'If (tbPalabraClaveUsuario.Text <> "Palabra Clave") Then
        '    data_usuarios = getUsuarios(tbPalabraClaveUsuario.Text, cbTiposDeUsuarios.SelectedIndex)
        '    refreshGridUsuarios(data_usuarios)
        'End If
    End Sub

    Private Sub btEditarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditarUsuario.Click
        'Revisamos de que una fila este seleccionada
        'Utilizamos el mismo formulario para cargar un nuevo usuario
        'frm_agregar_usuario.edit_mode = True
        'frm_agregar_usuario.from_settings = False
        'If (dgUsuarios.SelectedRows.Count > 0) Then
        '    centrarVentanaHija(MDIUsuario, frm_agregar_usuario)
        '    frm_agregar_usuario.ShowDialog()
        'Else
        '    MsgBox("Debe seleccionar al menos una fila")
        'End If
    End Sub

    Private Sub btEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminarUsuario.Click
        'Revisamos de que una fila este seleccionada
        'Preguntamos a el usuario si esta seguro que desea eliminar dicho usuario
        'Revisamos de que el usuario seleccionado no seamos nosotros mismos.
        'If (dgUsuarios.SelectedRows.Count > 0) Then
        '    Dim dialog_text = "¿Esta seguro que desea borrar el usuario seleccionado?"

        '    ventana_opcion = MessageBox.Show(dialog_text, "Consulta del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        '    If ventana_opcion = DialogResult.Yes Then
        '        Dim user_id_selected = Me.dgUsuarios.Item("id", Me.dgUsuarios.SelectedRows(0).Index).Value
        '        If (borrarUsuario(user_id_selected)) Then
        '            data_usuarios = getUsuarios()
        '            refreshGridUsuarios(getUsuarios())
        '        End If
        '    End If

        'Else
        '    MsgBox("Debe seleccionar al menos una fila")
        'End If
    End Sub

    Private Sub btAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregarUsuario.Click
        'frm_agregar_usuario.edit_mode = False
        'frm_agregar_usuario.from_settings = False
        'centrarVentanaHija(MDIUsuario, frm_agregar_usuario)
        'frm_agregar_usuario.ShowDialog()
    End Sub

    Private Sub gbFiltroUsuario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbFiltroUsuario.Enter

    End Sub

    Private Sub btImprimirUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimirUsuario.Click
        'Dim s As New class_impresion()
        'Dim titulos As ArrayList = New ArrayList()

        ''Clave,Titulo,Ancho,Alineacion
        'titulos.Add("id,Id,20,Left")
        'titulos.Add("usuario,Nombre de Usuario,250,Left")
        'titulos.Add("nombre,Nombre Completo,250,Left")
        'titulos.Add("rol,Tipo de Usuario,100,Left")

        'Me.Cursor = Cursors.WaitCursor
        's.imprimirListados("Listado de Usuarios", titulos, data_usuarios)
        'Me.Cursor = Cursors.Default
    End Sub
End Class