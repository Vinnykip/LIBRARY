Imports System.Data.OleDb

Public Class frm_borrow
    Dim conn As New OleDbConnection
    Private Sub BorrowBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Borrow_dataset)

    End Sub

    Private Sub frm_borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Member_dataset.Members' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Borrow_dataset.Borrow_Details' table. You can move, or remove it, as needed.
        Me.Borrow_DetailsTableAdapter.Fill(Me.Borrow_dataset.Borrow_Details)
        'TODO: This line of code loads data into the 'Borrow_dataset.borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.Borrow_dataset.borrow)


        Dim cnString As String

        cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\libsys.mdb"

        conn = New OleDbConnection(cnString)

        Try
            conn.Open()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Date_BorrowTextBox.Text = Date.Today

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.MembersTableAdapter.search_id(Me.Member_dataset.Members, IDTextBox.Text)

        FirstnameTextBox.Text = ComboBox1.Text
        LastnameTextBox.Text = ComboBox2.Text

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim sqlQRY As String = "SELECT * FROM books WHERE Status= 'Available' and Book_Code = '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        If rdr.HasRows Then
            rdr.Read()

            Dim a = rdr("BooksID").ToString
            Dim b = rdr("title").ToString
            Dim c = rdr("Author").ToString

            Dim newRow As borrow_dataset.Borrow_DetailsRow = Borrow_dataset.Borrow_Details.NewBorrow_DetailsRow

            newRow.BorrowID = BorrowIDTextBox.Text
            newRow.BooksID = a
            newRow.Title = b
            newRow.Author = c

            Borrow_dataset.Borrow_Details.Rows.Add(newRow)

            TextBox1.Text = ""
            TextBox1.Focus()
        Else
            MessageBox.Show("Material not Available!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox1.Text = ""
            TextBox1.Focus()
        End If

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.MembersTableAdapter.Fill(Me.Member_dataset.Members)
        IDTextBox.Text = ""
        BorrowIDTextBox.Enabled = True
        IDTextBox.Enabled = True
        FirstnameTextBox.Enabled = True
        LastnameTextBox.Enabled = True
        Due_DateDateTimePicker.Enabled = True
        TextBox1.Enabled = True


        BorrowBindingNavigator.AddNewItem.PerformClick()
        IDTextBox.Focus()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
      
        For Each row As DataGridViewRow In Me.Borrow_DetailsDataGridView.Rows

            Dim intProductID As Integer
            Dim strSQL As String

            If row.Cells(Me.BooksID.Index).Value > 0 Then
                intProductID = row.Cells(Me.BooksID.Index).Value


                strSQL = "UPDATE books SET status = 'Borrowed' WHERE BooksID = " & intProductID

                Dim cmd_a As OleDbCommand = New OleDbCommand(strSQL, conn)

                cmd_a.ExecuteNonQuery()
            End If
        Next row


        MsgBox("Book/s had been successfully borrowed!", MsgBoxStyle.Information, vbOKOnly)

        frm_save.ShowDialog()

        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Borrow_dataset)

   
        BorrowIDTextBox.Enabled = False
        IDTextBox.Enabled = False
        FirstnameTextBox.Enabled = False
        LastnameTextBox.Enabled = False
        Due_DateDateTimePicker.Enabled = False
        TextBox1.Enabled = False

        BorrowIDTextBox.Text = ""
        IDTextBox.Text = ""
        FirstnameTextBox.Text = ""
        LastnameTextBox.Text = ""
        Due_DateDateTimePicker.Text = ""



    End Sub

    
   
 
End Class