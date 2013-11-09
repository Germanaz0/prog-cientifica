Public Class frm_abrir_caja
    'Dim the_last_one As class_cajas

    Private Sub frm_abrir_caja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.btDetalleCheques.Visible = True

        'Obtenemos información de la última caja que se haya cerrado y mostramos la Info.
        Dim UltimaCaja As System.Data.DataRow
        UltimaCaja = Obtenercierrecaja()

        If UltimaCaja Is Nothing Then
            'Nos aseguramos antes de mostrar información de limpiar todas las variables.}
            Me.lbHoraCierreAnterior.Text = "Nunca antes abierta"
            Me.lbCajeroAnterior.Text = "Nadie"
            Me.lbEfectivo.Text = "0"
            Me.lbValores.Text = "0"
            Me.lbTotal.Text = "0"

            'Significa que nunca se abrio/cerro ninguna caja
            Me.btDetalleCheques.Visible = False
        Else
            'Cargamos la info de la última vez que se cerro una caja
            Me.lbFechaCierreAnterior.Text = UltimaCaja.Item("cierre_fecha").ToShortDateString
            Me.lbHoraCierreAnterior.Text = UltimaCaja.Item("cierre_fecha").ToShortTimeString
            Me.lbCajeroAnterior.Text = UltimaCaja.Item("nombre_usuario_cierre").ToString
            Me.lbEfectivo.Text = UltimaCaja.Item("cierre_efectivo") 'FORMATO_IMPORTE
            Me.lbValores.Text = UltimaCaja.Item("cierre_cheques").ToString() 'FORMATO_IMPORTE
            Me.lbTotal.Text = UltimaCaja.Item("cierre_total").ToString() 'FORMATO_IMPORTE
        End If

        'Me.lbHoraApertura.Text = Now.ToShortTimeString
        'Me.lbCajeroActual.Text = loggedin_user.nombre
    End Sub

    Private Sub btAbrirCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAbrirCaja.Click
        'Dim dialog_text = "¿Está seguro que desea abrir la caja?"

        'ventana_opcion = MessageBox.Show(dialog_text, "Consulta del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        'If ventana_opcion = DialogResult.Yes Then
        '    caja_opened = New class_cajas()
        '    If Not the_last_one Is Nothing Then
        '        caja_opened.open(the_last_one.efectivo_cierre, the_last_one.valores_cierre)
        '    Else
        '        caja_opened.open(0, 0)
        '    End If


        '    loggedin_user.refreshMenu()
        '    refreshStatusBar()
        '    Me.Close()
        'End If
    End Sub

    Private Sub btDetalleCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDetalleCheques.Click
        'frm_cartera.select_mode = False
        'centrarVentanaHija(MDIUsuario, frm_cartera)
        'frm_cartera.ShowDialog()
    End Sub

End Class