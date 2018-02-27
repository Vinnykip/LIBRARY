Public Class frm_loading

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Increment(+9)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False

            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+9)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False

            Me.Close()

            frm_main.Show()

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frm_loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Value = 0
    End Sub
End Class