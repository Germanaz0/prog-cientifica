Public Class ClassUsuario

    Friend ID As Integer = 0
    Friend Usuario As String = ""
    Friend Password As String = ""
    Friend Nombre As String = ""
    Friend TipoUsuarioID As Integer = 0
    Friend Activo As Boolean = 0

    Private MySQL As New Mysql

    Public Sub New()

    End Sub

    Public Sub Login(ByVal Usuario As String, ByVal Password As String)

        If (Usuario.Length = 0 Or Password.Length = 0) Then
            Throw New Exception("El usuario o la clave no deben estar vacios")
        End If

        Dim Dt As System.Data.DataTable
        Dim Consulta As String
        Consulta = "SELECT Id, usuario, password, nombre, tipo_usuario_id, activo FROM usuarios WHERE usuario='{0}' AND password='{1}' LIMIT 1;"
        Consulta = String.Format(Consulta, Usuario, Password)

        Dt = Me.MySQL.LEER(Consulta)

        If (Dt.Rows.Count = 0) Then
            Throw New Exception("El Nombre de Usuario o la contraseña son invalidos")
        End If

        Me.ID = Dt.Rows(0).Item("Id")
        Me.Usuario = Dt.Rows(0).Item("usuario")
        Me.Password = Dt.Rows(0).Item("password")
        Me.Nombre = Dt.Rows(0).Item("nombre")
        Me.TipoUsuarioID = Dt.Rows(0).Item("tipo_usuario_id")
        Me.Activo = Dt.Rows(0).Item("activo")

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Usuario & ": " & Me.Nombre
    End Function

    Public Function ObtenerMenu() As System.Data.DataTable
        Dim Consulta As String

        ''"SELECT `menues`.`Id_Perfil`, `menues`.`Nombre_Menu`, `menues`.`Nivel`, `menues`.`Formulario` FROM `perfiles` INNER JOIN `menues` ON `perfiles`.`Id_Perfiles` = `menues`.`Id_Perfil` AND menues.id_perfil <= '" & Dtu.Rows(0).Item("Id_Perfil") & "' Order by Id_Menu")
        Consulta = "SELECT Id_Perfil, Nombre_Menu, Nivel, Formulario FROM perfiles pe INNER JOIN menues as me ON pe.Id_Perfiles = me.Id_Perfil AND me.id_perfil <= '{0}' ORDER BY me.Id_menu"

        Return Me.MySQL.LEER(String.Format(Consulta, Me.TipoUsuarioID))


    End Function


End Class
