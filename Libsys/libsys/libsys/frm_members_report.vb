Public Class frm_members_report

    Private Sub frm_members_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'member_dataset.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.member_dataset.Members)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class