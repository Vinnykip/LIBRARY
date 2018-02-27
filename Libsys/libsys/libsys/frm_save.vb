Public Class frm_save

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+9)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False



            Me.Hide()


        End If
    End Sub

    Private Sub frm_save_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Value = 0
    End Sub
End Class