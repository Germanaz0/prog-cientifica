Public Class frm_alta_usuario

    Private Sub BM_usu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Combo_País.Text = ""
        Combo_Prov.Text = ""
        Combo_Loc.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Combo_Perfil.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

        Dim sql As New Mysql
        Dim Dt As System.Data.DataTable
        Dt = sql.LEER("Select pais From paises")

        Dim pais As String

        If Dt.Rows.Count = 0 Then
            MsgBox("NO se encontraron PAÍSES")
            Exit Sub
        Else
            For x = 0 To Dt.Rows.Count - 1
                pais = Dt.Rows(x).ItemArray(0)
                Combo_País.Items.Add(pais)


            Next x

        End If


        'Dim sql3 As New Mysql
        'Dim Dt3 As System.Data.DataTable
        'Dt3 = sql3.LEER("SELECT * FROM perfiles_usuarios")
        'Dim perfiles_usuarios As String

        'If Dt3.Rows.Count = 0 Then
        '    MsgBox("Registro NO ENCONTRADO")
        '    Exit Sub
        'Else

        '    For x = 0 To Dt3.Rows.Count - 1
        '        perfiles_usuarios = Dt3.Rows(x).ItemArray(1)
        '        Combo_Perfil.Items.Add(perfiles_usuarios)
        '    Next x
        'End If

    End Sub
    Private Sub Combo_País_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_País.SelectedIndexChanged

        Combo_Prov.Items.Clear()
        Combo_Prov.Text = ""
        Combo_Loc.Text = ""
        Combo_Loc.Items.Clear()

        Dim sql As New Mysql
        Dim Dt As System.Data.DataTable
        Dim Dt1 As System.Data.DataTable
        Dim valorid As Integer

        Dt1 = sql.LEER("SELECT paises.Id_Pais from paises where paises.Pais = '" & Combo_País.Text & "'")
        For x = 0 To Dt1.Rows.Count - 1
            valorid = Dt1.Rows(x).ItemArray(0)

        Next

        Dt = sql.LEER("SELECT provincia.Provincia  FROM provincia, paises WHERE paises.Pais = '" & Combo_País.Text & "' and provincia.Id_Pais = " & valorid & " Order by provincia.Provincia ")

        Dim provincia As String


        If Dt.Rows.Count = 0 Then
            MsgBox("No se encontro Provincias para ese PAIS")
            Exit Sub
        Else

            For x = 0 To Dt.Rows.Count - 1
                provincia = Dt.Rows(x).ItemArray(0)
                Combo_Prov.Items.Add(provincia)


            Next x
        End If

    End Sub
    Private Sub Combo_Prov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_Prov.SelectedIndexChanged
        Combo_Loc.Items.Clear()
        Combo_Loc.Text = ""

        Dim sql As New Mysql
        Dim Dt As System.Data.DataTable
        Dim Dt1 As System.Data.DataTable
        Dim valorid As Integer

        Dt1 = sql.LEER("SELECT provincia.Id_Provincia from provincia where provincia = '" & Combo_Prov.Text & "'")
        For x = 0 To Dt1.Rows.Count - 1
            valorid = Dt1.Rows(x).ItemArray(0)

        Next

        Dt = sql.LEER("SELECT localidad.localidad FROM provincia, localidad WHERE provincia.Provincia = '" & Combo_Prov.Text & "' and localidad.Id_Provincia = " & valorid & " Order by localidad.localidad")

        Dim localidad As String


        If Dt.Rows.Count = 0 Then
            MsgBox("No hay localidades para esa PROVINCIA")
            Exit Sub
        Else

            For x = 0 To Dt.Rows.Count - 1
                localidad = Dt.Rows(x).ItemArray(0)
                Combo_Loc.Items.Add(localidad)


            Next x
        End If

    End Sub



    Private Sub b_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cancelar.Click
        Me.Close()

    End Sub

    Private Sub b_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_guardar.Click

        'valida que todos los datos estan cargados
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or Combo_País.Text = "" Or Combo_Prov.Text = "" Or Combo_Loc.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or Combo_Perfil.Text = "" Or TextBox7.Text = " " Or TextBox8.Text = "" Then
            MsgBox("Hay datos faltantes")

        Else

            '' pasa a mayusculas
            TextBox2.Text = UCase(TextBox2.Text)
            TextBox3.Text = UCase(TextBox3.Text)
            Combo_País.Text = UCase(Combo_País.Text)  '
            Combo_Prov.Text = UCase(Combo_Prov.Text)
            Combo_Loc.Text = UCase(Combo_Loc.Text)
            TextBox4.Text = UCase(TextBox4.Text)
            Combo_Perfil.Text = UCase(Combo_Perfil.Text)
            TextBox7.Text = UCase(TextBox7.Text)

            Dim sql As New Mysql
            Dim res As Integer = sql.QUERY("INSERT INTO usuarios(Num_Docu, Apellido, Nombres, Pais, Provincia, Localidad, Domicilio, Cod_Area, Num_Tel, Id_Perfil, Login, Password)VALUES('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.Combo_País.Text & "','" & Me.Combo_Prov.Text & "','" & Me.Combo_Loc.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.Combo_Perfil.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "')")

            MsgBox("CAMBIOS GUARDADOS CON EXITO")




            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Combo_País.Text = ""
            Combo_Prov.Text = ""
            Combo_Loc.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            Combo_Perfil.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""

            TextBox1.Focus()
        End If


    End Sub

End Class