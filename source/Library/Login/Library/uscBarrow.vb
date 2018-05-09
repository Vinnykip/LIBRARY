' Library Management System v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system with MS Access DB, developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Imports System.Data.OleDb
Public Class uscBarrow
    Public WithEvents search As frmSearch
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Private Sub uscBarrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Save_Record()
        End If
    End Sub
    Public Sub Load_Record(ByVal iTrnNo As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_barrow.barrow_trn_no, lib_barrow.bookID, lib_barrow.member_id, lib_books.title, lib_member.first_name + ' ' + lib_member.last_name as mem_name, lib_barrow.date_barrow, lib_barrow.due_date "
        sSQL = sSQL & "FROM lib_member RIGHT JOIN (lib_books RIGHT JOIN lib_barrow ON lib_books.BookID = lib_barrow.bookID) ON lib_member.member_id = lib_barrow.member_id "
        sSQL = sSQL & "where lib_barrow.barrow_trn_no = @trnno"
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@trnno", OleDbType.Numeric).Value = iTrnNo
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtBrowNo.Text = dr("barrow_trn_no")
                    If Not IsDBNull(dr("bookID")) Then
                        Me.txtBook.Tag = dr("bookID")
                        Me.txtBook.Text = dr("title")
                    End If

                    If Not IsDBNull(dr("member_id")) Then
                        Me.txtBarrower.Tag = dr("member_id")
                        Me.txtBarrower.Text = dr("mem_name")
                    End If
                    Me.dtpBarrowDate.Text = IIf(Not IsDBNull(dr("date_barrow")), dr("date_barrow"), "")
                    Me.dtpDueDate.Text = IIf(Not IsDBNull(dr("due_date")), dr("due_date"), "")
                    Me.btnReturn.Enabled = True
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try

            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If Len(Trim(Me.txtBrowNo.Text)) = 0 Then
                sSQL = "INSERT INTO lib_barrow ( bookID, member_id, date_barrow, due_date )"
                sSQL = sSQL & "  VALUES(@bookID, @member_id, @date_barrow, @due_date)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_barrow set bookID = @bookID, member_id =  @member_id, date_barrow =  @date_barrow, due_date = @due_date where barrow_trn_no = @barrow_trn_no"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@bookID", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtBook.Text)) > 0, Me.txtBook.Tag, DBNull.Value)
            cmd.Parameters.Add("@member_id", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtBarrower.Text)) > 0, Me.txtBarrower.Tag, DBNull.Value)
            cmd.Parameters.Add("@date_barrow", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpBarrowDate.Text)) > 0, Me.dtpBarrowDate.Text, DBNull.Value)
            cmd.Parameters.Add("@due_date", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpDueDate.Text)) > 0, Me.dtpDueDate.Text, DBNull.Value)
            If Len(Trim(Me.txtBrowNo.Text)) > 0 Then
                cmd.Parameters.Add("@barrow_trn_no", OleDbType.Numeric).Value = Me.txtBrowNo.Text
            End If
            cmd.ExecuteNonQuery()

            'If the record is new then we have to get its ID so that we can edit it rightaway after the insertion.
            If Len(Trim(Me.txtBrowNo.Text)) = 0 Then
                cmd.CommandText = "Select @@Identity"
                'Set textbox tag property with the ID of new record
                Me.txtBrowNo.Text = cmd.ExecuteScalar()
            End If
            MsgBox("Data has been save.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Clear_Fields()
        With Me
            .txtBrowNo.Text = ""
            .txtBook.Text = ""
            .txtBook.Tag = 0
            .txtBarrower.Text = ""
            .txtBarrower.Tag = 0
            .dtpBarrowDate.Format = DateTimePickerFormat.Custom
            If Me.dtpBarrowDate.Text <> "" Then
                .dtpBarrowDate.Value = Now
            End If
            .dtpDueDate.Format = DateTimePickerFormat.Custom
            If Me.dtpDueDate.Text <> "" Then
                .dtpDueDate.Value = Now
            End If
        End With
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Book()
            Clear_Fields()
            MsgBox("Record has been deleted.")
        End If
    End Sub
    Private Sub Delete_Book()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_barrow where barrow_trn_no = @barrow_trn_no"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@barrow_trn_no", OleDbType.Numeric).Value = Me.txtBrowNo.Text

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dtpBarrowDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBarrowDate.ValueChanged
        If Me.dtpBarrowDate.Text <> "" Then
            Me.dtpBarrowDate.Format = DateTimePickerFormat.Short
        End If
    End Sub
    Private Sub dtpBarrowDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpBarrowDate.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpBarrowDate.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtpDueDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDueDate.ValueChanged
        If Me.dtpDueDate.Text <> "" Then
            Me.dtpDueDate.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub dtpDueDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDueDate.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpDueDate.Format = DateTimePickerFormat.Custom
        End If
    End Sub
    Private Sub SearchResult(ByVal row As DataRow) Handles search.SearchResult

        Select Case search.SearchType
            Case 2
                With Me
                    .txtBook.Tag = row("bookID")
                    .txtBook.Text = row("title")
                End With
            Case 3
                With Me
                    .txtBarrower.Tag = row("member_id")
                    .txtBarrower.Text = row("member_name")
                End With
        End Select

    End Sub

    Private Sub btnBookSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookSearch.Click
        search = New frmSearch
        search.SearchType = 2
        search.ShowDialog()
    End Sub

    Private Sub btnBrwSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrwSearch.Click
        search = New frmSearch
        search.SearchType = 3
        search.ShowDialog()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Clear_Fields()
        Me.dtpBarrowDate.Format = DateTimePickerFormat.Custom
        Me.dtpDueDate.Format = DateTimePickerFormat.Custom
    End Sub


    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        'Dim frm As New frmReturn
        'frm.IssuanceNo = Me.txtBrowNo.Text
        'frm.ShowDialog()
        'frm = Nothing
        Main_Library.MainTab2.SelectedTabIndex = 2

        If Main_Library.SplitContainer5.Panel2.Controls.Count = 0 Then
            Main_Library.cReturn = New uscReturn
            Main_Library.SplitContainer5.Panel2.Controls.Add(Main_Library.cReturn)
            Main_Library.cReturn.txtIssuanceNo.Text = Me.txtBrowNo.Text
        End If

    End Sub
End Class
