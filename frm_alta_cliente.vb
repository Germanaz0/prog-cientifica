Public Class frm_alta_cliente


    Private Sub BM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Combo_País.Text = ""
        Combo_Prov.Text = ""
        Combo_Loc.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

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
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Combo_País.Text = ""
        Combo_Prov.Text = ""
        Combo_Loc.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Me.Close()
    End Sub



End Class