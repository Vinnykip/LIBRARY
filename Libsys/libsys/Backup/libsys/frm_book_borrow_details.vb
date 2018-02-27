Public Class frm_book_borrow_details

    Private Sub BorrowBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Borrow_dataset)

    End Sub

    Private Sub frm_borrow_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow_dataset.Borrow_Details' table. You can move, or remove it, as needed.
        Me.Borrow_DetailsTableAdapter.Fill(Me.Borrow_dataset.Borrow_Details)
        'TODO: This line of code loads data into the 'Borrow_dataset.borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.Borrow_dataset.borrow)

    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    
End Class