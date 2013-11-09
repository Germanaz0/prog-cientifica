Module ModInicio
    Public var As String
    Public op As Integer
    Public consultaformulario As String

    Public MIUsuario As ClassUsuario

    Public Sub Main()
        frm_login.ShowDialog()
    End Sub

    Public Function MiLogin(ByVal Usuario As String, ByVal Password As String)

        Dim UsuarioTmp As New ClassUsuario

        Try
            UsuarioTmp.Login(Usuario, Password)
        Catch ex As Exception
            ''My.Computer.Audio.Play(My.Resources.errorcontra, AudioPlayMode.WaitToComplete)
            MsgBox(ex.Message(), MsgBoxStyle.Exclamation, "Error de conección")
            Return False
        End Try

        MIUsuario = UsuarioTmp

        Return True

    End Function


End Module
