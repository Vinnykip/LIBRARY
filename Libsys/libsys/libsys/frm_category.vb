Public Class frm_category

    Private Sub CategoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Category_dataset)

    End Sub

    Private Sub frm_category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Category_dataset.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.Category_dataset.Category)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        CategoryNameTextBox.Enabled = True

        Me.CategoryBindingNavigator.AddNewItem.PerformClick()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        MsgBox("Record Saved!", MsgBoxStyle.Information, vbOKCancel)

        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Category_dataset)

        CategoryNameTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Do you want to Delete this Department? Click 'Yes' to Delete or 'No' to continue.", "Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            CategoryBindingNavigator.DeleteItem.PerformClick()

            Me.Validate()
            Me.CategoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Category_dataset)
         
            MessageBox.Show("Data Deleted")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CategoryNameTextBox.Enabled = True
    End Sub

    Private Sub btnmovefirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmovefirst.Click
        CategoryBindingNavigator.MoveFirstItem.PerformClick()

    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        CategoryBindingNavigator.MovePreviousItem.PerformClick()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CategoryBindingNavigator.MoveNextItem.PerformClick()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CategoryBindingNavigator.MoveLastItem.PerformClick()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            Me.CategoryTableAdapter.Fill(Me.Category_dataset.Category)
        Else
            Me.CategoryTableAdapter.search(Me.Category_dataset.Category, TextBox1.Text)
        End If

    End Sub
End Class