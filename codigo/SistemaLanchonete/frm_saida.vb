Public Class frm_saida
    Private Sub btn_saida_Click(sender As Object, e As EventArgs) Handles btn_saida.Click
        If txt_descricao.Text = "" Or txt_valor.Text = "" Or cmb_classificacao.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            Try
                gerar_id_saida()
                sql = "insert into tbSaida values ('" & idSaida & "', '" & txt_descricao.Text & "', " &
                          txt_valor.Text & ", '" & dtp_data.Value.ToString("dd/MM/yyyy") & "', '" & cmb_classificacao.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Lançamento realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_descricao.Clear()
                txt_valor.Clear()
                cmb_classificacao.Text = ""
                txt_descricao.Focus()
            Catch ex As Exception
                MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End If
    End Sub
End Class