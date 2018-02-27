Imports System.Data.OleDb

Public Class frm_return
    Dim conn As New OleDbConnection

    Private Sub ReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Return_dataset)

    End Sub

    Private Sub frm_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Member_dataset.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.Member_dataset.Members)
        'TODO: This line of code loads data into the 'Return_dataset.Return_Details' table. You can move, or remove it, as needed.
        Me.Return_DetailsTableAdapter.Fill(Me.Return_dataset.Return_Details)
        'TODO: This line of code loads data into the 'Return_dataset._return' table. You can move, or remove it, as needed.
        Me.ReturnTableAdapter.Fill(Me.Return_dataset._return)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        ReturnIDTextBox.Enabled = True
        IDTextBox.Enabled = True
        FirstnameTextBox.Enabled = True
        LastnameTextBox.Enabled = True
        Due_DateDateTimePicker.Enabled = True
        TextBox1.Enabled = True

        ReturnBindingNavigator.AddNewItem.PerformClick()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        For Each row As DataGridViewRow In Me.Return_DetailsDataGridView.Rows

            Dim intProductID As Integer
            Dim strSQL As String

            If row.Cells(Me.BooksID.Index).Value > 0 Then
                intProductID = row.Cells(Me.BooksID.Index).Value


                strSQL = "UPDATE books SET status = 'Available' WHERE BooksID = " & intProductID

                Dim cmd_a As OleDbCommand = New OleDbCommand(strSQL, conn)

                cmd_a.ExecuteNonQuery()
            End If
        Next row


        MsgBox("Book\s had successfully returned!", MsgBoxStyle.Information, vbOKOnly)
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Return_dataset)

        ReturnIDTextBox.Enabled = False
        IDTextBox.Enabled = False
        FirstnameTextBox.Enabled = False
        LastnameTextBox.Enabled = False
        Due_DateDateTimePicker.Enabled = False
        TextBox1.Enabled = False

        ReturnIDTextBox.Text = ""
        IDTextBox.Text = ""
        FirstnameTextBox.Text = ""
        LastnameTextBox.Text = ""
        Due_DateDateTimePicker.Text = ""

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.MembersTableAdapter.search_id(Me.Member_dataset.Members, IDTextBox.Text)

        FirstnameTextBox.Text = ComboBox1.Text
        LastnameTextBox.Text = ComboBox2.Text


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim sqlQRY As String = "SELECT * FROM books WHERE Status= 'Borrowed' and Book_Code = '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        If rdr.HasRows Then
            rdr.Read()

            Dim a = rdr("BooksID").ToString
            Dim b = rdr("title").ToString
            Dim c = rdr("Author").ToString

            Dim newRow As return_dataset.Return_DetailsRow = Return_dataset.Return_Details.NewReturn_DetailsRow



            newRow.ReturnID = ReturnIDTextBox.Text
            newRow.BooksID = a
            newRow.Title = b
            newRow.Author = c

            Return_dataset.Return_Details.Rows.Add(newRow)


            TextBox1.Text = ""
            TextBox1.Focus()
        Else
            MessageBox.Show("Book not on your list!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Date_ReturnTextBox.Text = Date.Today
    End Sub

   
End Class