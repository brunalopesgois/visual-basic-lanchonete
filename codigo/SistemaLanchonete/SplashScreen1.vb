Public NotInheritable Class SplashScreen1
    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint
        Timer1.Start()
        conectaAccess()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            Timer1.Stop()
            ProgressBar1.Value = 0
            Me.Hide()
            frm_login.ShowDialog()
        End If
    End Sub
End Class
