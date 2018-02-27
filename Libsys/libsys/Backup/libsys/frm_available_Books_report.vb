Public Class frm_available_Books_report

    Private Sub frm_available_Books_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'books_dataset.books' table. You can move, or remove it, as needed.
        Me.booksTableAdapter.available(Me.books_dataset.books)

        Me.ReportViewer1.RefreshReport()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class