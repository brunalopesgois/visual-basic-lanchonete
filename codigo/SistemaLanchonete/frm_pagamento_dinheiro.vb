Public Class frm_pagamento_dinheiro
    Private Sub frm_pagamento_dinheiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_total.Text = total
        txt_valor.Clear()
        txt_troco.Clear()
    End Sub
    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged
        Try
            If CDbl(txt_valor.Text) - total >= 0 Then
                txt_troco.Text = CDbl(txt_valor.Text) - total
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_valor.Text = "" Then
            MsgBox("Informe o valor recebido!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            Try
                aux_lanche = vbEmpty
                ingrediente = vbEmpty
                aux = vbEmpty
                sem_estoque = False
                With frm_vendas.dgv_carrinho
                    For i As Integer = 0 To .Rows.Count - 1
                        If .Rows(i).Cells(3).Value = "Lanche" Then
                            aux_lanche = aux_lanche + 1
                        Else
                            aux = aux + 1
                        End If
                    Next
                End With
                ingrediente = aux_lanche * 0.05
                sql = "select * from tbProduto where categoria <> 'Bebidas'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    If rs.Fields(2).Value < ingrediente Then
                        sem_estoque = True
                    End If
                    rs.MoveNext()
                Loop
                With frm_vendas.dgv_carrinho
                    For i As Integer = 0 To .Rows.Count - 1
                        sql = "select * from tbProduto where descricao = '" & .Rows(i).Cells(0).Value & "'"
                        rs = db.Execute(sql)
                        Do While rs.EOF = False
                            If rs.Fields(2).Value < aux Then
                                sem_estoque = True
                            End If
                            rs.MoveNext()
                        Loop
                    Next
                End With
                If sem_estoque = True Then
                    resp = MsgBox("Você está tentando efetuar a compra" + vbNewLine &
                           "de um produto indisponível no estoque!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                End If
                resp = "DINHEIRO"
                mesAno = Date.Today
                mesAno = mesAno.Substring(3)
                gerar_id_pedido()
                sql = "insert into tbPedido values ('" & idPedido & "', '" & Date.Now & "', '" & resp & "'," &
              frm_vendas.txt_total.Text.Replace(",", ".") & ", '" & frm_menu.lbl_usuario.Text & "', '" & mesAno & "')"
                rs = db.Execute(UCase(sql))
                sql = "select * from tbPedido order by idPedido desc"
                rs = db.Execute(sql)
                idPedido = rs.Fields(0).Value
                With frm_vendas.dgv_carrinho
                    For i As Integer = 0 To .Rows.Count - 1
                        gerar_id_detalhe_pedido()
                        gerar_id_entrada()
                        preco = .Rows(i).Cells(2).Value
                        sql = "insert into tbDetalhePedido values ('" & idDetalhePedido & "', '" & idPedido & "', '" &
                          .Rows(i).Cells(0).Value & "', " & preco.ToString.Replace(",", ".") & ", '" & .Rows(i).Cells(1).Value & "')"
                        rs = db.Execute(UCase(sql))
                        sql = "insert into tbEntrada values ('" & idEntrada & "', '" & .Rows(i).Cells(0).Value &
                          "', " & preco.ToString.Replace(",", ".") & ", '" & Date.Today & "', '" & resp & "', '" & mesAno & "')"
                        rs = db.Execute(UCase(sql))
                        If .Rows(i).Cells(3).Value = "Lanche" Then
                            sql = "update tbProduto set quantidade = (quantidade - 1) where descricao = 'PÃO DE HAMBURGUER'"
                            rs = db.Execute(sql)
                            sql = "update tbProduto set quantidade = (quantidade - 1) where descricao = 'HAMBURGUER BOVINO'"
                            rs = db.Execute(sql)
                            sql = "update tbProduto set quantidade = (quantidade - " & qtd_maionese.ToString().Replace(",", ".") & ") where descricao = 'SACHÊ DE MAIONESE'"
                            rs = db.Execute(sql)
                            sql = "update tbProduto set quantidade = (quantidade - " & qtd_queijo.ToString().Replace(",", ".") & ") where descricao = 'QUEIJO MUSSARELA'"
                            rs = db.Execute(sql)
                            If .Rows(i).Cells(0).Value <> "X Burguer" Then
                                sql = "update tbProduto set quantidade = (quantidade - " & qtd_ovo.ToString().Replace(",", ".") & ") where descricao = 'OVOS'"
                                rs = db.Execute(sql)
                                sql = "update tbProduto set quantidade = (quantidade - " & qtd_alface.ToString().Replace(",", ".") & ") where descricao = 'ALFACE'"
                                rs = db.Execute(sql)
                                sql = "update tbProduto set quantidade = (quantidade - " & qtd_tomate.ToString().Replace(",", ".") & ") where descricao = 'TOMATE'"
                                rs = db.Execute(sql)
                                If .Rows(i).Cells(0).Value = "X Bacon" Then
                                    sql = "update tbProduto set quantidade = (quantidade - " & qtd_bacon.ToString().Replace(",", ".") & ") where descricao = 'BACON'"
                                    rs = db.Execute(sql)
                                End If
                            End If
                        Else
                            sql = "update tbProduto set quantidade = (quantidade - 1) where descricao = '" & UCase(.Rows(i).Cells(0).Value) & "'"
                            rs = db.Execute(sql)
                        End If
                    Next
                End With
                MsgBox("Compra efetuada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                preco = vbEmpty
                total = vbEmpty
                obs = vbEmpty
                With frm_vendas
                    .txt_nome.Clear()
                    .txt_preco.Clear()
                    .txt_total.Clear()
                    .dgv_carrinho.Rows.Clear()
                End With
                Me.Hide()
            Catch ex As Exception
                MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub
End Class