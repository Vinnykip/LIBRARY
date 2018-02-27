Public Class frm_book_return_details

    Private Sub ReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Return_dataset)

    End Sub

    Private Sub frm_book_return_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Return_dataset.Return_Details' table. You can move, or remove it, as needed.
        Me.Return_DetailsTableAdapter.Fill(Me.Return_dataset.Return_Details)
        'TODO: This line of code loads data into the 'Return_dataset._return' table. You can move, or remove it, as needed.
        Me.ReturnTableAdapter.Fill(Me.Return_dataset._return)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class