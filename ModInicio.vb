Module ModInicio
    Public var As String
    Public op As Integer
    Public consultaformulario As String
    Public MIUsuario As ClassUsuario
    Public FORMATO_IMPORTE As String
    Public FORMATO_NROCOMPROBANTE As String
    Public FORMATO_RECIBO As String
    Public FORMATO_IMPORTE_DB As String


    Public MiMySQL As New Mysql


    Public Sub Main()
        FORMATO_IMPORTE_DB = "###0.00"
        FORMATO_IMPORTE = "###0.00"
        FORMATO_NROCOMPROBANTE = "#00000000"
        FORMATO_RECIBO = "#0001-00000000"



        frm_login.ShowDialog()
    End Sub

    Public Function MiLogin(ByVal Usuario As String, ByVal Password As String)

        Dim UsuarioTmp As New ClassUsuario

        Try
            UsuarioTmp.Login(Usuario, Password)
        Catch ex As Exception
            ''My.Computer.Audio.Play(My.Resources.errorcontra, AudioPlayMode.WaitToComplete)
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error de conección")
            Return False
        End Try

        MIUsuario = UsuarioTmp

        Return True

    End Function

    Public Function Obtenercierrecaja() As System.Data.DataRow
        Dim Consulta As String
        Dim Resultado As System.Data.DataTable

        Consulta = "SELECT cr.*, ua.nombre AS nombre_usuario_apertura, uc.nombre AS nombre_usuario_cierre, cierre_efectivo+cierre_cheques As cierre_total FROM caja_registro cr INNER JOIN usuarios ua ON ua.Id = cr.apertura_usuario_id INNER JOIN usuarios uc ON uc.Id = cr.cierre_usuario_id WHERE cierre_fecha IS NOT NULL ORDER BY cierre_fecha DESC LIMIT 1"
        Resultado = MiMySQL.LEER(Consulta)

        If (Resultado.Rows.Count > 0) Then
            Return Resultado.Rows(0)
        End If

        Return Nothing

    End Function
End Module
