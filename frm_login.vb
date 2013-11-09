Imports System.Data

Public Class frm_login
    Dim menustrip As New MenuStrip
    Dim Item, InnerItem, SubInnerItem As ToolStripMenuItem

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IniciarFormDeUsuarioDeslogueado()
    End Sub

    Private Sub IniciarFormDeUsuarioDeslogueado()
        ModInicio.MIUsuario = New ClassUsuario

        GroupBox1.Visible = True
        Log_usuario.Text = ""
        Log_contra.Text = ""
        Log_usuario.Focus()

        Me.Text = "Ingresar - Sistema de Cajas"

    End Sub

    Private Sub Crear_Menu(ByVal Nivel As Integer, ByVal Texto As String, ByVal Referencia As String)
        Select Case Nivel
            Case 1
                Item = New ToolStripMenuItem()
                Item.Text = Texto
                Item.Tag = Referencia
                menustrip.Items.Add(Item)
                AddHandler Item.Click, AddressOf Nivel_Click
            Case 2
                InnerItem = New ToolStripMenuItem()
                InnerItem.Text = Texto
                InnerItem.Tag = Referencia
                Item.DropDownItems.Add(InnerItem)
                AddHandler InnerItem.Click, AddressOf Nivel_Click
            Case 3
                SubInnerItem = New ToolStripMenuItem()
                SubInnerItem.Text = Texto
                SubInnerItem.Tag = Referencia
                InnerItem.DropDownItems.Add(SubInnerItem)
                AddHandler SubInnerItem.Click, AddressOf Nivel_Click
        End Select
    End Sub

    Private Sub Nivel_Click(ByVal Sender As Object, ByVal e As EventArgs)

        If (Sender.Tag = "salir") Then
            Me.Close()
            Exit Sub
        End If

        If (Sender.Tag = "cerrar_sesion") Then
            menustrip.Items.Clear()
            menustrip.Visible = True
            IniciarFormDeUsuarioDeslogueado()
            Exit Sub
        End If

        If (Sender.Tag <> "") Then
            Dim mform As String
            mform = "Koch." & Sender.Tag
            Dim objNewForm As Object = Activator.CreateInstance(Type.GetType(mform))
            Dim frm_p As Form = DirectCast(objNewForm, Form)
            frm_p.Show()
            Sender.Tag()
        End If


    End Sub


    Private Sub Log_ingr_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log_ingr.Click
        DoLogin()
    End Sub


    Private Sub DoLogin()
        Dim Usuario As String = Log_usuario.Text
        Dim Password As String = Log_contra.Text

        If (Usuario.Length = 0 Or Password.Length = 0) Then
            MsgBox("El usuario o la contraseña no deben estar vacios", MsgBoxStyle.Critical, "Error al Ingresar")
            Exit Sub
        End If

        ''Ejecutamos la consulta para loguearnos y devuelve true o false
        Dim LoginCorrecto = MiLogin(Usuario, Password) 

        If (LoginCorrecto = False) Then
            Exit Sub
        End If

        Me.IniciarFormDeUsuarioLogueado()

    End Sub

    Private Sub Log_usuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Log_usuario.KeyPress

        If e.KeyChar = Chr(13) Then

            If Log_usuario.Text = "" Then
                Log_usuario.Focus()
                Exit Sub
            End If

            Log_contra.Focus()
        End If

    End Sub

    Private Sub Log_contra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Log_contra.KeyPress

        If e.KeyChar = Chr(13) Then

            If Log_contra.Text = "" Then
                Log_contra.Focus()
                Exit Sub
            End If

            DoLogin()

        End If

    End Sub

    Private Sub Log_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log_salir.Click
        Me.Close()
    End Sub

    Private Sub IniciarFormDeUsuarioLogueado()
        Dim MenuUsuario As System.Data.DataTable
        Dim MenuCount As Integer
        Dim IndiceMenu As Integer = 0

        ''Obtenemos el menu del usuario
        MenuUsuario = MIUsuario.ObtenerMenu()
        MenuCount = MenuUsuario.Rows.Count

        If (MenuCount = 0) Then
            MsgBox("No es posible acceder a la aplicación", MsgBoxStyle.Critical, "Problema de Acceso")
            Exit Sub
        End If

        GroupBox1.Visible = False

        My.Computer.Audio.Play(My.Resources.beep_21, AudioPlayMode.WaitToComplete)

        For IndiceMenu = 0 To MenuCount - 1
            Me.Crear_Menu(MenuUsuario(IndiceMenu).Item("nivel"), MenuUsuario(IndiceMenu).Item("nombre_menu"), MenuUsuario(IndiceMenu).Item("formulario"))
        Next IndiceMenu

        Me.Controls.Add(menustrip)
        Me.MainMenuStrip = menustrip

        Me.Text = "Bienvenidos al Sistema de Cajas"

    End Sub




End Class
