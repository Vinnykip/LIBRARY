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
Public Class uscBookDtl
    Public WithEvents search As frmSearch
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)
    Dim dtCategory As DataTable
    Dim dtgVendor As DataTable

    Private Sub uscBookDtl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Category()
        Load_Vendor()
        Clear_Fields()
    End Sub

    'FUNCTIONS USED

    Public Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try

            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If Len(Trim(Me.txtBookID.Text)) = 0 Then
                sSQL = "INSERT INTO lib_books ( title, category_id, author_id, isbn_no, pages, publish_date, vendor_id )"
                sSQL = sSQL & "  VALUES(@title, @category_id, @author_id, @isbn_no, @pages, @publish_date, @vendor_id)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_books set title = @title, category_id =  @category_id, author_id =  @author_id, isbn_no = @isbn_no, pages = @pages, publish_date = @publish_date, vendor_id = @vendor_id where BookID = @BookID"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@title", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtTitle.Text)) > 0, Me.txtTitle.Text, DBNull.Value)
            cmd.Parameters.Add("@category_id", OleDbType.TinyInt).Value = IIf(Len(Trim(Me.cboCategory.Text)) > 0, Me.cboCategory.SelectedValue, DBNull.Value)
            cmd.Parameters.Add("@author_id", OleDbType.TinyInt).Value = IIf(Len(Trim(Me.txtAuthor.Text)) > 0, Me.txtAuthor.Tag, DBNull.Value)
            cmd.Parameters.Add("@isbn_no", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtISBN.Text)) > 0, Me.txtISBN.Text, DBNull.Value)
            cmd.Parameters.Add("@pages", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtPages.Text)) > 0, Me.txtPages.Text, DBNull.Value)
            cmd.Parameters.Add("@publish_date", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpPubDate.Text)) > 0, Me.dtpPubDate.Text, DBNull.Value)
            cmd.Parameters.Add("@vendor_id", OleDbType.TinyInt).Value = IIf(Len(Trim(Me.cboVendor.Text)) > 0, Me.cboVendor.SelectedValue, DBNull.Value)
            If Len(Trim(Me.txtBookID.Text)) > 0 Then
                cmd.Parameters.Add("@BookID", OleDbType.Numeric).Value = Me.txtBookID.Text
            End If
            cmd.ExecuteNonQuery()

            If Len(Trim(Me.txtBookID.Text)) = 0 Then
                cmd.CommandText = "Select @@Identity"
                Me.txtBookID.Text = cmd.ExecuteScalar()
            End If
            MsgBox("Data has been save.")
            Main_Library.Load_Books(Main_Library.txtBookSearch.Text)
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to save Book Record

    Public Sub Load_Record(ByVal iBookID As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty

        sSQL = "SELECT BookID, d.title, b.category_description, d.author_id, c.firstname + ' ' + c.lastname as author_name, d.isbn_no, d.pages, d.publish_date, a.vendor_name "
        sSQL = sSQL & "FROM lib_vendor as a RIGHT JOIN (lib_category as b RIGHT JOIN (lib_author as c RIGHT JOIN lib_books as d "
        sSQL = sSQL & "ON c.author_id = d.author_id) ON b.category_id = d.category_id) ON a.vendor_id = d.vendor_id "
        sSQL = sSQL & "where BookID = @BookID"
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@BookID", OleDbType.Numeric).Value = iBookID
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtBookID.Text = dr("BookID")
                    Me.txtTitle.Text = dr("title")
                    Me.cboCategory.Text = IIf(Not IsDBNull(dr("category_description")), dr("category_description"), "")
                    Me.dtpPubDate.Text = IIf(Not IsDBNull(dr("publish_date")), dr("publish_date"), "")
                    Me.txtISBN.Text = IIf(Not IsDBNull(dr("isbn_no")), dr("isbn_no"), "")
                    Me.txtPages.Text = IIf(Not IsDBNull(dr("pages")), dr("pages"), "")
                    If Not IsDBNull(dr("author_id")) Then
                        Me.txtAuthor.Tag = dr("author_id")
                        Me.txtAuthor.Text = dr("author_name")
                    End If
                    Me.cboVendor.Text = IIf(Not IsDBNull(dr("vendor_name")), dr("vendor_name"), "")
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to load datagrid with book records

    Private Sub Load_Category()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            dtCategory = New DataTable
            sQuery = "SELECT lib_category.category_id, lib_category.category_description FROM lib_category"
            conn = New OleDbConnection(constring)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            da.SelectCommand = cmd
            da.Fill(dtCategory)

            Me.cboCategory.DataSource = dtCategory
            Me.cboCategory.DisplayMember = "category_description"
            Me.cboCategory.ValueMember = "category_id"

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to load categories to combobox

    Private Sub Load_Vendor()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            dtgVendor = New DataTable
            sQuery = "SELECT lib_vendor.vendor_id, lib_vendor.vendor_name FROM lib_vendor"
            conn = New OleDbConnection(constring)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            da.SelectCommand = cmd
            da.Fill(dtgVendor)

            Me.cboVendor.DataSource = dtgVendor
            Me.cboVendor.DisplayMember = "vendor_name"
            Me.cboVendor.ValueMember = "vendor_id"

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to load vendors to combobox

    Public Sub Clear_Fields()
        With Me
            .txtBookID.Text = ""
            .txtTitle.Text = ""
            .cboCategory.SelectedIndex = -1
            .dtpPubDate.Format = DateTimePickerFormat.Custom
            '.dtpPubDate.Value = DateAdd(DateInterval.Day, -1, .dtpPubDate.Value)
            If Me.dtpPubDate.Text <> "" Then
                .dtpPubDate.Value = Now
            End If
            .txtISBN.Text = ""
            .txtPages.Text = ""
            .txtAuthor.Tag = 0
            .txtAuthor.Text = ""
            .cboVendor.SelectedValue = -1
        End With
    End Sub 'Clear function

    Private Sub Delete_Book()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_books where BookID = @BookID"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@BookID", OleDbType.Numeric).Value = Me.txtBookID.Text

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to delete book records 

    Function ValidateInput() As String
        Dim sErrMsg As String = ""
        Try
            If Len(Trim(Me.txtTitle.Text)) = 0 Then
                sErrMsg = "Title is required."
            End If
            Try
                If Len(Trim(Me.txtPages.Text)) > 0 Then
                    Convert.ToInt16(Me.txtPages.Text)
                End If
            Catch ex As Exception
                sErrMsg = sErrMsg & vbCrLf & "Only number is allowed in page count."
            End Try
        Catch ex As Exception

        End Try
        Return sErrMsg
    End Function 'Function to validate input for number data type

    'BUTTON EVENTS

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Clear_Fields()
        Me.dtpPubDate.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Dim sErr As String = ValidateInput()
            If Len(Trim(sErr)) = 0 Then
                Save_Record()
                Main_Library.Load_Books(Main_Library.txtBookSearch.Text)
            Else
                MsgBox(sErr)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Book()
            Clear_Fields()
            MsgBox("Record has been deleted.")
            Main_Library.Load_Books(Main_Library.txtBookSearch.Text)
        End If
    End Sub

    Private Sub dtpPubDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPubDate.ValueChanged
        If Me.dtpPubDate.Text <> "" Then
            Me.dtpPubDate.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub dtpPubDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpPubDate.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpPubDate.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub btnVendRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendRefresh.Click
        Load_Vendor()
    End Sub

    Private Sub btnAuthSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuthSearch.Click
        search = New frmSearch
        search.SearchType = 1
        search.ShowDialog()
    End Sub
    Private Sub SearchResult(ByVal row As DataRow) Handles search.SearchResult
        With Me
            .txtAuthor.Tag = row("author_id")
            .txtAuthor.Text = row("author_name")
        End With
    End Sub

    Private Sub linkAuthor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAuthor.LinkClicked
        'Dim frm As New frmAuthor
        'frm.ShowDialog()
        'frm = Nothing
        Main_Library.MainTab3.SelectedTabIndex = 1
    End Sub

    Private Sub lnVenor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnVenor.LinkClicked
        'Dim frm As New frmVendor
        'frm.ShowDialog()
        'frm = Nothing
        Main_Library.MainTab3.SelectedTabIndex = 2
    End Sub

    Private Sub linkCategory_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCategory.LinkClicked
        'Main_Library.MainTab3.SelectedTabIndex = 2
        CatDialog.ShowDialog()
    End Sub

    Private Sub btnCatRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatRefresh.Click
        Load_Category()
    End Sub

End Class
