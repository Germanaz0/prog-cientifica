Imports System.Text

Public Class Frm_Consultas
    Public Nombre_Consulta As String = " "
    Dim Sactivate As Boolean = False
    Private Mysql As New Mysql
 
    Dim valor As Integer
    Private Sub Frm_Consultas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Sactivate = True Then
            Exit Sub
        End If
        Sactivate = True
        'Procesar()


    End Sub

    Private Sub cargacombo()
        Sactivate = False
        Combo_campo.Items.Clear()
        Combo_campo.Text = ""
        Dim sql As New Mysql

        Dim Dt As System.Data.DataTable
        Dt = sql.LEER("select detalle_consulta.Titulo from detalle_consulta where Es_Busqueda = 'SI' and nombre_consulta = '" & consultaformulario & "' ")
        Dim cargacomb As String

        If Dt.Rows.Count = 0 Then
            MsgBox("Registro NO ENCONTRADO")

            Exit Sub
        Else

            For x = 0 To Dt.Rows.Count - 1
                cargacomb = Dt.Rows(x).ItemArray(0)
                Combo_campo.Items.Add(cargacomb)

            Next x
        End If
    End Sub



    Private Sub Frm_Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Sactivate = False
        Combo_campo.Items.Clear()
        Combo_campo.Text = ""


        Combo_campo.Items.Add("BANCOS")
        Combo_campo.Items.Add("CLIENTES")
        Combo_campo.Items.Add("USUARIOS")

    End Sub

    Private Sub Procesar()
        If Combo_campo.Text = ("BANCOS") Then
            var = "BANCOS"
            valor = 1
        End If
        If Combo_campo.Text = ("CLIENTES") Then
            var = "CLIENTES"
            valor = 2
        End If
        If Combo_campo.Text = ("USUARIOS") Then
            var = "USUARIOS"
            valor = 3
        End If
        LV_Consulta.Clear()
        LV_Consulta.View = View.Details
        Dim Dtc, Dtd, dt As System.Data.DataTable
        Dim Str As String = ("SELECT * FROM consultas WHERE NOMBRE_CONSULTA = '" & var & "'")
        Dim SubItem() As Windows.Forms.ListViewItem.ListViewSubItem
        Dtc = Mysql.LEER(Str)

        If Dtc.Rows.Count = 0 Then
            MsgBox("NO HAY REGISTROS PARA CONSULTAR")
            Exit Sub
        Else
            Str = ("SELECT * FROM detalle_consulta where es_busqueda = 'si' and nombre_consulta = '" & var & "' order by orden ")
            Dtd = Mysql.LEER(Str)
            If Dtd.Rows.Count = 0 Then
                MsgBox("NO HAY ESTRUCTURA PARA CONSULTAR")
                Exit Sub
            Else
                For i As Integer = 0 To Dtd.Rows.Count - 1
                    'Título de la columna
                    'El texto y  el ancho
                    Dim ancho As Integer = Dtd.Rows(i).Item("longitud").ToString
                    LV_Consulta.Columns.Add(Dtd.Rows(i).Item("titulo").ToString, ancho) ' texto y ancho

                    'Alineación de la Columna
                    Select Case Dtd.Rows(i).Item("alineacion").ToString
                        Case "izquierda"
                            LV_Consulta.Columns(i).TextAlign = HorizontalAlignment.Left
                        Case "derecha"
                            LV_Consulta.Columns(i).TextAlign = HorizontalAlignment.Right
                        Case "centrada"
                            LV_Consulta.Columns(i).TextAlign = HorizontalAlignment.Center
                    End Select
                Next
                Application.DoEvents()
            End If
            dt = Nothing
            dt = Mysql.LEER(Dtc.Rows(0).Item("Str_Consulta_SQL").ToString)
            Me.Text = "Registros Afectados: " & dt.Rows.Count
            If dt.Rows.Count > 0 Then
                ReDim SubItem(0 To Dtd.Rows.Count - 1)
                Dim renglon As Integer = 0
                For i As Integer = 0 To dt.Rows.Count - 1
                    For j As Integer = 0 To Dtd.Rows.Count - 1
                        If j = 0 Then
                            LV_Consulta.Items.Add(dt.Rows(i).Item(Dtd.Rows(j).Item("campo").ToString))
                        Else
                            SubItem(j) = New Windows.Forms.ListViewItem.ListViewSubItem(LV_Consulta.Items(renglon), dt.Rows(i).Item(Dtd.Rows(j).Item("campo").ToString))
                            LV_Consulta.Items(renglon).SubItems.Add(SubItem(j))
                        End If
                    Next j
                    Dim resto As Integer = renglon Mod 2
                    If resto = 0 Then
                        LV_Consulta.Items(renglon).BackColor = Color.LightBlue
                    Else
                        LV_Consulta.Items(renglon).BackColor = Color.LightYellow
                    End If
                    renglon = renglon + 1
                Next i
            End If
        End If
        var = ""

    End Sub


 
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As New Mysql

        Procesar()

    End Sub


    Private Sub b_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_nuevo.Click

        '###########################################
        '##                                       ##
        '##     HACER EL FORMULARIO DE BANCO      ##
        '##                                       ##
        '###########################################
        'If valor = 1 Then

        'End If

        If valor = 2 Then
            frm_alta_cliente.ShowDialog()
        End If
        If valor = 3 Then
            frm_alta_usuario.ShowDialog()
        End If

    End Sub


    Private Sub b_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_eliminar.Click
        For i As Integer = LV_Consulta.SelectedItems.Count - 1 To 0 Step -1
            LV_Consulta.SelectedItems(i).Remove()
        Next

        ''FALTA HACER QUE ELIMNE DE LA BASE DE DATOS

    End Sub


    Private Sub b_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_editar.Click
        If Combo_campo.Text = "CLIENTES" Then
            frm_alta_cliente.ShowDialog()
        Else
            frm_alta_usuario.ShowDialog()
        End If

        '' FALTA CARGAR LOS TEXTBOX CON LA INFORMACION DE LA LISTVIEW
    End Sub



    Private Sub Combo_campo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_campo.SelectedIndexChanged
        If Combo_campo.Text = ("BANCOS") Then
            Procesar()
            Dim sql As New Mysql
            Dim Dt As System.Data.DataTable
            Dt = sql.LEER("select detalle_consulta.Titulo from detalle_consulta where Es_Busqueda = 'SI' and nombre_consulta = 'bancos' Order by orden")
            Dim cargacomb As String

            If Dt.Rows.Count = 0 Then
                MsgBox("Registro NO ENCONTRADO")

                Exit Sub
            Else

                For x = 0 To Dt.Rows.Count - 1
                    cargacomb = Dt.Rows(x).ItemArray(0)
                    Combo_busqueda.Items.Add(cargacomb)

                Next x
            End If
        End If


        If Combo_campo.Text = ("CLIENTES") Then
            Procesar()
            Dim sql As New Mysql
            Dim Dt As System.Data.DataTable
            Dt = sql.LEER("select detalle_consulta.Titulo from detalle_consulta where Es_Busqueda = 'SI' and nombre_consulta = 'clientes' Order by orden")
            Dim cargacomb As String

            If Dt.Rows.Count = 0 Then
                MsgBox("Registro NO ENCONTRADO")

                Exit Sub
            Else

                For x = 0 To Dt.Rows.Count - 1
                    cargacomb = Dt.Rows(x).ItemArray(0)
                    Combo_busqueda.Items.Add(cargacomb)

                Next x
            End If
        End If
        If Combo_campo.Text = ("USUARIOS") Then
            Procesar()
            Dim sql As New Mysql
            Dim Dt As System.Data.DataTable
            Dt = sql.LEER("select detalle_consulta.Titulo from detalle_consulta where Es_Busqueda = 'SI' and nombre_consulta = 'usuarios' Order by orden")
            Dim cargacomb As String

            If Dt.Rows.Count = 0 Then
                MsgBox("Registro NO ENCONTRADO")

                Exit Sub
            Else

                For x = 0 To Dt.Rows.Count - 1
                    cargacomb = Dt.Rows(x).ItemArray(0)
                    Combo_busqueda.Items.Add(cargacomb)

                Next x
            End If

        End If
    End Sub


End Class