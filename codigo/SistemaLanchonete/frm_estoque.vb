Public Class frm_estoque
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_nome.Text = "" Or txt_qtd.Text = "" Or txt_preco.Text = "" Or
               cmb_categoria.Text = "" Or cmb_tipo_unitario.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tbProduto where descricao = '" & txt_nome.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tbProduto set quantidade = " & txt_qtd.Text & ", preco = " & txt_preco.Text &
                           ", tipoUnitario = '" & cmb_tipo_unitario.Text & "', categoria = '" & cmb_categoria.Text & "'" &
                           "where descricao = '" & txt_nome.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados do produto atualizados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    gerar_id_produto()
                    sql = "insert into tbProduto values ('" & idProduto & "', '" & txt_nome.Text & "', '" & txt_qtd.Text &
                          "', '" & txt_preco.Text & "', '" & cmb_tipo_unitario.Text & "', '" & cmb_categoria.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                limpa_frm_estoque()
                carregar_dados_estoque()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus
        Try
            sql = "select * from tbProduto where descricao = '" & txt_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_qtd.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_qtd.Text = rs.Fields(2).Value.ToString().Replace(",", ".")
                txt_preco.Text = rs.Fields(3).Value.ToString().Replace(",", ".")
                cmb_tipo_unitario.Text = rs.Fields(4).Value
                cmb_categoria.Text = rs.Fields(5).Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick
        limpa_frm_estoque()
    End Sub

    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_estoque()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dgv_dados
                sql = "select * from tbProduto where descricao like '" & txt_busca.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value,
                    rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(6).Selected = True Then
                    tab_cadastro.SelectTab(0)
                    txt_nome.Text = .CurrentRow.Cells(1).Value
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux_nome = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o produto" + vbNewLine &
                                  aux_nome & "?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                    If resp = vbYes Then
                        sql = "delete from tbProduto where descricao = '" & aux_nome & "'"
                        rs = db.Execute(sql)
                        carregar_dados_estoque()
                        aux_nome = ""
                    End If
                Else
                    Exit sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class