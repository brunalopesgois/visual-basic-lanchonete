Module Module1
    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public sql, resp, aux_nome, obs, categoria, mesAno As String
    Public idProduto, idPedido, idDetalhePedido, idEntrada, idSaida, aux_lanche, aux As Integer
    Public qtd_maionese, qtd_queijo, qtd_tomate, qtd_alface, qtd_ovo, qtd_bacon, ingrediente As Double
    Public preco, total As Double
    Public sem_estoque As Boolean
    Sub gerar_id_produto()
        sql = "select * from tbProduto order by idProduto desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            idProduto = 1
        Else
            idProduto = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_pedido()
        sql = "select * from tbPedido order by idPedido desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            idPedido = 1
        Else
            idPedido = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_detalhe_pedido()
        sql = "select * from tbDetalhePedido order by idDetalhePedido desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            idDetalhePedido = 1
        Else
            idDetalhePedido = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_entrada()
        sql = "select * from tbEntrada order by idEntrada desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            idEntrada = 1
        Else
            idEntrada = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_saida()
        sql = "select * from tbSaida order by idSaida desc"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            idSaida = 1
        Else
            idSaida = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub carregar_dados_estoque()
        Try
            With frm_estoque.dgv_dados
                sql = "select * from tbProduto order by descricao asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,
                              rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub limpa_frm_estoque()
        Try
            With frm_estoque
                .txt_nome.Clear()
                .txt_qtd.Clear()
                .txt_preco.Clear()
                .txt_nome.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub conectaSQLServer()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-F58BHV4;initial catalog=lanchonete;trusted_connection=yes;")
            'MsgBox("Conexão com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub conectaAccess()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\lanchonete.mdb; Persist Security Info=False")
            'MsgBox("Conexão com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
