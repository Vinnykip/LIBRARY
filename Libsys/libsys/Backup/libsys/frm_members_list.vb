Public Class frm_members_list

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Member_dataset)

    End Sub

    Private Sub frm_members_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Member_dataset.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.Member_dataset.Members)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        FirstnameTextBox.Enabled = True
        LastnameTextBox.Enabled = True
        MITextBox.Enabled = True
        AgeTextBox.Enabled = True
        AddressTextBox.Enabled = True
        ContactNumberTextBox.Enabled = True
        GenderComboBox.Enabled = True

        Me.MembersBindingNavigator.AddNewItem.PerformClick()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        MsgBox("Record Saved!", MsgBoxStyle.Information, vbOKCancel)

        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Member_dataset)

        FirstnameTextBox.Enabled = False
        LastnameTextBox.Enabled = False
        MITextBox.Enabled = False
        AgeTextBox.Enabled = False
        AddressTextBox.Enabled = False
        ContactNumberTextBox.Enabled = False
        GenderComboBox.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MessageBox.Show("Do you want to Delete this Department? Click 'Yes' to Delete or 'No' to continue.", "Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            MembersBindingNavigator.DeleteItem.PerformClick()

            Me.Validate()
            Me.MembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Member_dataset)
            MessageBox.Show("Data Deleted")

        End If
    End Sub

    Private Sub btnmovefirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmovefirst.Click
        MembersBindingNavigator.MoveFirstItem.PerformClick()

    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        MembersBindingNavigator.MovePreviousItem.PerformClick()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MembersBindingNavigator.MoveNextItem.PerformClick()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MembersBindingNavigator.MoveLastItem.PerformClick()

    End Sub

  
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        FirstnameTextBox.Enabled = True
        LastnameTextBox.Enabled = True
        MITextBox.Enabled = True
        AgeTextBox.Enabled = True
        AddressTextBox.Enabled = True
        ContactNumberTextBox.Enabled = True
        GenderComboBox.Enabled = True
        
        


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            Me.MembersTableAdapter.Fill(Me.Member_dataset.Members)
        Else
            Me.MembersTableAdapter.search_id(Me.Member_dataset.Members, TextBox1.Text)
        End If
    End Sub

    
End Class