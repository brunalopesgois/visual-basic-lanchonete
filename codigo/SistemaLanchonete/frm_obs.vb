Public Class frm_obs

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Me.Hide()
    End Sub

    Private Sub btn_add_obs_Click(sender As Object, e As EventArgs) Handles btn_add_obs.Click
        If obs = "" Then
            obs = cmb_retirar.Text
        Else
            obs = obs & ", " & cmb_retirar.Text
        End If
        If cmb_retirar.Text = "Sem Maionese" Then
            qtd_maionese = 0
        ElseIf cmb_retirar.Text = "Sem Queijo" Then
            qtd_queijo = 0
        ElseIf cmb_retirar.Text = "Sem Alface" Then
            qtd_alface = 0
        ElseIf cmb_retirar.Text = "Sem tomate" Then
            qtd_tomate = 0
        End If
        MsgBox(obs)
    End Sub

    Private Sub btn_add_acr_Click(sender As Object, e As EventArgs) Handles btn_add_acr.Click
        If obs = "" Then
            obs = cmb_acrescentar.Text
        Else
            obs = obs & ", " & cmb_acrescentar.Text
        End If
        With frm_vendas
            preco = preco + 1
            .txt_preco.Text = preco
        End With
        If cmb_acrescentar.Text = "Bacon" Then
            qtd_bacon = 0.1
        ElseIf cmb_acrescentar.Text = "Ovo" Then
            qtd_ovo = 1
        End If
        MsgBox(obs)
    End Sub
End Class