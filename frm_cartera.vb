Public Class frm_Cartera

    Private Mysql As New Mysql



    Private Sub frm_Cartera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        GroupBox2.Visible = False
        GroupBox3.Visible = False

        Dim sql As New Mysql

        Dim Dt As System.Data.DataTable
        Dt = sql.LEER("select descrip_cdv from cartera_de_valores ")
        Dim cartval As String

        If Dt.Rows.Count = 0 Then
            MsgBox("Registro NO ENCONTRADO")

            Exit Sub
        Else

            For x = 0 To Dt.Rows.Count - 1
                cartval = Dt.Rows(x).ItemArray(0).ToString
                Cbo_opcion.Items.Add(cartval)
            Next x
        End If
    End Sub




    Private Sub Cbo_opcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_opcion.SelectedIndexChanged
        If Cbo_opcion.Text = "Efectivo" Then
            GroupBox2.Visible = True

            GroupBox3.Visible = False
        End If

        If Cbo_opcion.Text = "Cheque" Then
            GroupBox3.Visible = True

            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_num_fac.KeyPress
        If e.KeyChar = Chr(13) Then

            If RB_efec_ing.Checked = True Then
                'SIRVE PARA MAS ADELANTE GUAMPAAAAA!!!!!!!!!!!!!
                'Dtu = sql.LEER("select facturas_emitidas.Id_FE, articulo.descripcion_art, facturas_emitidas.Precio_uni, facturas_emitidas.Cant_Art, facturas_emitidas.Monto_FE from articulo, facturas_emitidas where facturas_emitidas.Id_FE = '" & Tb_num_fac.Text & "' and articulo.Id_Articulo = facturas_emitidas.Id_art  ")
                'se pone asi xq es una variable '" & Log_usuario.Text & "'
                'Dim A As String
                Dim var2 As String
                var2 = "EFECTIVO ING"
                Lv_efectivo.Clear()
                Lv_efectivo.View = View.Details
                Dim Dtc, Dtd, dt As System.Data.DataTable
                Dim Str As String = ("SELECT facturas_emitidas.Id_FE, facturas_emitidas.Monto_FE FROM facturas_emitidas where Id_FE = '" & Tb_num_fac.Text & "'")
                Dim SubItem() As Windows.Forms.ListViewItem.ListViewSubItem
                Dtc = Mysql.LEER(Str)

                If Dtc.Rows.Count = 0 Then
                    MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                    Exit Sub
                Else
                    Str = ("SELECT * FROM detalle_cartera where nombre_consulta = '" & var2 & "'")
                    Dtd = Mysql.LEER(Str)
                    If Dtd.Rows.Count = 0 Then
                        MsgBox("NO HAY ESTRUCTURA PARA CONSULTAR")
                        Exit Sub
                    Else
                        For i As Integer = 0 To Dtd.Rows.Count - 1
                            'Título de la columna
                            'El texto y  el ancho
                            Dim ancho As Integer = Dtd.Rows(i).Item("longitud").ToString
                            Lv_efectivo.Columns.Add(Dtd.Rows(i).Item("titulo").ToString, ancho) ' texto y ancho

                            'Alineación de la Columna
                            Select Case Dtd.Rows(i).Item("alineacion").ToString
                                Case "izquierda"
                                    Lv_efectivo.Columns(i).TextAlign = HorizontalAlignment.Left
                                Case "derecha"
                                    Lv_efectivo.Columns(i).TextAlign = HorizontalAlignment.Right
                                Case "centrada"
                                    Lv_efectivo.Columns(i).TextAlign = HorizontalAlignment.Center
                            End Select
                        Next
                        Application.DoEvents()
                    End If
                    dt = Nothing
                    dt = Mysql.LEER("SELECT facturas_emitidas.Id_FE, facturas_emitidas.Monto_FE FROM facturas_emitidas where Id_FE = '" & Tb_num_fac.Text & "'")
                    'dt = Mysql.LEER(Dtc.Rows(0).Item("SELECT facturas_emitidas.Id_FE, facturas_emitidas.Monto_FE FROM facturas_emitidas where Id_FE = '" & Tb_num_fac.Text & "'").ToString)
                    Me.Text = "Registros Afectados: " & dt.Rows.Count
                    If dt.Rows.Count > 0 Then
                        ReDim SubItem(0 To Dtd.Rows.Count - 1)
                        Dim renglon As Integer = 0
                        For i As Integer = 0 To dt.Rows.Count - 1
                            For j As Integer = 0 To Dtd.Rows.Count - 1
                                If j = 0 Then
                                    Lv_efectivo.Items.Add(dt.Rows(i).Item(Dtd.Rows(j).Item("campo").ToString))
                                Else
                                    SubItem(j) = New Windows.Forms.ListViewItem.ListViewSubItem(Lv_efectivo.Items(renglon), dt.Rows(i).Item(Dtd.Rows(j).Item("campo").ToString))
                                    Lv_efectivo.Items(renglon).SubItems.Add(SubItem(j))
                                End If
                            Next j
                            Dim resto As Integer = renglon Mod 2
                            If resto = 0 Then
                                Lv_efectivo.Items(renglon).BackColor = Color.LightBlue
                            Else
                                Lv_efectivo.Items(renglon).BackColor = Color.LightYellow
                            End If
                            renglon = renglon + 1
                        Next i
                    End If
                End If

            End If
        End If
    End Sub


End Class