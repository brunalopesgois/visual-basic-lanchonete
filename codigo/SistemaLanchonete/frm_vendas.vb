Public Class frm_vendas
    Private Sub btn_burguer_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_burguer.Text
        preco = 9.99
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        With dgv_carrinho
            .Rows.Add(txt_nome.Text, obs, preco, categoria, Nothing)
            total = total + preco
            txt_total.Text = total
        End With
        obs = ""
    End Sub

    Private Sub btn_salada_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_salada.Text
        preco = 10.99
    End Sub

    Private Sub btn_bacon_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_bacon.Text
        preco = 12.49
    End Sub

    Private Sub btn_coca_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_coca.Text
        preco = 5.5
    End Sub

    Private Sub btn_fanta_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_fanta.Text
        preco = 4.99
    End Sub

    Private Sub btn_suco_Click(sender As Object, e As EventArgs)
        txt_nome.Text = btn_suco.Text
        preco = 3.99
    End Sub

    Private Sub btn_obs_Click(sender As Object, e As EventArgs) Handles btn_obs.Click
        frm_obs.ShowDialog()
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If dgv_carrinho.Rows.Count = 0 Then
            MsgBox("Nenhum produto selecionado para compra!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            frm_forma_pagamento.ShowDialog()
        End If
    End Sub

    Private Sub frm_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Clear()
        txt_preco.Clear()
        txt_total.Clear()
        total = vbEmpty
        dgv_carrinho.Rows.Clear()
    End Sub

    Private Sub dgv_carrinho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_carrinho.CellContentClick
        Try
            With dgv_carrinho
                If .CurrentRow.Cells(4).Selected = True Then
                    total = total - CDbl(.CurrentRow.Cells(2).Value)
                    txt_total.Text = total
                    .Rows.Remove(.CurrentRow)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_burguer_Click_1(sender As Object, e As EventArgs) Handles btn_burguer.Click
        txt_nome.Text = btn_burguer.Text
        preco = 10
        txt_preco.Text = preco
        categoria = "Lanche"
        qtd_maionese = 0.05
        qtd_queijo = 0.05
    End Sub

    Private Sub btn_salada_Click_1(sender As Object, e As EventArgs) Handles btn_salada.Click
        txt_nome.Text = btn_salada.Text
        preco = 11.99
        txt_preco.Text = preco
        categoria = "Lanche"
        qtd_maionese = 0.05
        qtd_queijo = 0.05
        qtd_alface = 0.05
        qtd_tomate = 0.05
    End Sub

    Private Sub btn_bacon_Click_1(sender As Object, e As EventArgs) Handles btn_bacon.Click
        txt_nome.Text = btn_bacon.Text
        preco = 13.5
        txt_preco.Text = preco
        categoria = "Lanche"
        qtd_queijo = 0.05
        qtd_alface = 0.05
        qtd_tomate = 0.05
        qtd_bacon = 0.05
    End Sub

    Private Sub btn_coca_Click_1(sender As Object, e As EventArgs) Handles btn_coca.Click
        txt_nome.Text = btn_coca.Text
        preco = 5.5
        txt_preco.Text = preco
        categoria = "Bebida"
    End Sub

    Private Sub btn_fanta_Click_1(sender As Object, e As EventArgs) Handles btn_fanta.Click
        txt_nome.Text = btn_fanta.Text
        preco = 4.99
        txt_preco.Text = preco
        categoria = "Bebida"
    End Sub

    Private Sub btn_suco_Click_1(sender As Object, e As EventArgs) Handles btn_suco.Click
        txt_nome.Text = btn_suco.Text
        preco = 3.99
        txt_preco.Text = preco
        categoria = "Bebida"
    End Sub

    Private Sub btn_saida_Click(sender As Object, e As EventArgs) Handles btn_saida.Click
        frm_saida.ShowDialog()
    End Sub
End Class