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
Public Class frmSearch
    Event SearchResult(ByVal row As DataRow)
    Private _searchType As Short
    Dim dt As DataTable
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Public Property SearchType As Short
        Get
            Return _searchType
        End Get
        Set(ByVal value As Short)
            _searchType = value
        End Set
    End Property
    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDataGrid()
        'SetAddButton()
        btnSearch_Click(sender, e)
    End Sub
    Private Sub SetDataGrid()
        With dtgResult
            Select Case _searchType
                Case 1
                    'author
                    .Columns.Add("ID", "Author ID")
                    .Columns("ID").DataPropertyName = "author_id"
                    .Columns("ID").Width = 80

                    .Columns.Add("author_name", "Name")
                    .Columns("author_name").DataPropertyName = "author_name"
                    .Columns("author_name").Width = 250
                Case 2
                    'book
                    .Columns.Add("ID", "Book ID")
                    .Columns("ID").DataPropertyName = "bookID"
                    .Columns("ID").Width = 80

                    .Columns.Add("BookTitle", "Title")
                    .Columns("BookTitle").DataPropertyName = "title"
                    .Columns("BookTitle").Width = 300
                Case 3
                    'member
                    .Columns.Add("ID", "Member ID")
                    .Columns("ID").DataPropertyName = "member_id"
                    .Columns("ID").Width = 80

                    .Columns.Add("membername", "Member Name")
                    .Columns("membername").DataPropertyName = "member_name"
                    .Columns("membername").Width = 300

                    .Columns.Add("code", "Course")
                    .Columns("code").DataPropertyName = "code"
                    .Columns("code").Width = 80
            End Select
        End With
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Load_record()
    End Sub
    Private Sub Load_record()
        Select Case _searchType
            Case 1
                search_Author(Me.txtSearchBox.Text)
            Case 2
                search_book(Me.txtSearchBox.Text)
            Case 3
                search_member(Me.txtSearchBox.Text)
        End Select
    End Sub
    Private Sub search_Author(ByVal sSearch As String)
        dt = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT author_id,  firstname+' '+ lastname AS author_name from lib_author "

        If Len(Trim(sSearch)) > 0 Then
            sSQL = sSQL & "where firstname+' '+ lastname like '%" & sSearch & "%'"
        End If

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)
            Me.dtgResult.DataSource = dt

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub search_book(ByVal sSearch As String)
        dt = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT bookID,  title from lib_books "

        If Len(Trim(sSearch)) > 0 Then
            sSQL = sSQL & "where title like '%" & sSearch & "%'"
        End If

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)
            Me.dtgResult.DataSource = dt

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub search_member(ByVal sSearch As String)
        dt = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        'sSQL = "SELECT member_id,   first_name+' '+ last_name AS member_name from lib_member "
        sSQL = "SELECT lib_member.member_id, first_name+' '+ last_name AS member_name, lib_course.code "
        sSQL = sSQL & "FROM lib_course RIGHT JOIN lib_member ON lib_course.course_id = lib_member.course_id "
        If Len(Trim(sSearch)) > 0 Then
            sSQL = sSQL & "where first_name+' '+ last_name like '%" & sSearch & "%'"
        End If

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)
            Me.dtgResult.DataSource = dt

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        With Me
            If .dtgResult.RowCount > 0 Then
                Dim row As DataRow
                row = dt.Rows(Me.dtgResult.CurrentRow.Index)
                RaiseEvent SearchResult(row)
            Else
                MsgBox("Unable to apply, no record found.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Library Management")
            End If

        End With
        Me.Close()
    End Sub

    'Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    '    Select Case _searchType
    '        Case 1
    '            Dim frm As New frmAuthor
    '            frm.ShowDialog()
    '            frm = Nothing
    '    End Select
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class