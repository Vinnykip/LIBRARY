Public Class frm_book_list
    Public Sub save()
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Books_dataset)

    End Sub
    Private Sub BooksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Books_dataset)

    End Sub

    Private Sub frm_book_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Category_dataset.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.Category_dataset.Category)
        'TODO: This line of code loads data into the 'Books_dataset.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.orderby(Me.Books_dataset.books)

    End Sub



    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Are You Sure You Want To Delete Record?", MsgBoxStyle.Exclamation, vbOKCancel)
        Me.BooksBindingSource.RemoveCurrent()


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BooksBindingSource.MoveNext()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        frm_save.ShowDialog()

        MsgBox("Record Saved!", MsgBoxStyle.Information, vbOKCancel)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Books_dataset)

        ISBNTextBox.Enabled = False
        TitleTextBox.Enabled = False
        CategoryComboBox.Enabled = False
        DeweyDecimalClassNumTextBox.Enabled = False
        AuthorTextBox.Enabled = False
        PublisherNameTextBox.Enabled = False
        CopyrightDateTextBox.Enabled = False
        SourceTextBox.Enabled = False
        StatusComboBox.Enabled = False



    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click



        Book_CodeTextBox.Text = Val(TextBox1.Text)
     
        ISBNTextBox.Enabled = True
        TitleTextBox.Enabled = True
        CategoryComboBox.Enabled = True
        DeweyDecimalClassNumTextBox.Enabled = True
        AuthorTextBox.Enabled = True
        PublisherNameTextBox.Enabled = True
        CopyrightDateTextBox.Enabled = True
        SourceTextBox.Enabled = True
        StatusComboBox.Enabled = True


        Me.BooksBindingSource.AddNew()


    End Sub
    Private Sub btnmovefirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmovefirst.Click
        BooksBindingNavigator.MoveFirstItem.PerformClick()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        BooksBindingNavigator.MovePreviousItem.PerformClick()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BooksBindingNavigator.MoveNextItem.PerformClick()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BooksBindingNavigator.MoveLastItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MessageBox.Show("Do you want to Delete this Department? Click 'Yes' to Delete or 'No' to continue.", "Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BooksBindingNavigator.DeleteItem.PerformClick()
            Me.Validate()
            Me.BooksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Books_dataset)
            MessageBox.Show("Data Deleted")

        End If
    End Sub

  

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        ISBNTextBox.Enabled = True
        TitleTextBox.Enabled = True
        CategoryComboBox.Enabled = True
        DeweyDecimalClassNumTextBox.Enabled = True
        AuthorTextBox.Enabled = True
        PublisherNameTextBox.Enabled = True
        CopyrightDateTextBox.Enabled = True
        SourceTextBox.Enabled = True
        StatusComboBox.Enabled = True

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BooksTableAdapter.sort(Me.Books_dataset.books, ComboBox1.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BooksTableAdapter.sortby(Me.Books_dataset.books, ComboBox2.Text)
    End Sub

    
    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.BooksTableAdapter.Fill(Me.Books_dataset.books)
        Else
            Me.BooksTableAdapter.search(Me.Books_dataset.books, TextBox1.Text)

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Close this Form? Click 'Yes' to Close or 'No' to continue.", "Closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class