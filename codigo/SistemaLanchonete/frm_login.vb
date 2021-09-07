Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            sql = "select * from tbLogin where usuario = '" & txt_usuario.Text & "'or email = '" &
                  txt_usuario.Text & "' and senha = '" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Bem vindo " & rs.Fields(1).Value & "!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                frm_menu.ShowDialog()
            Else
                MsgBox("Usuário ou senha incorretos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
