Public Class frm_menu
    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conectaSQLServer()
        Timer1.Start()
        lbl_usuario.Text = UCase(frm_login.txt_usuario.Text)
        'lbl_usuario.Text = "ADMIN"
        lbl_data.Text = Date.Now
    End Sub

    Private Sub CONTROLEDEESTOQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLEDEESTOQUEToolStripMenuItem.Click
        frm_estoque.ShowDialog()
    End Sub

    Private Sub PONTODEVENDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PONTODEVENDAToolStripMenuItem.Click
        frm_vendas.ShowDialog()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Hide()
        frm_login.txt_usuario.Clear()
        frm_login.txt_senha.Clear()
        frm_login.txt_usuario.Focus()
    End Sub
End Class