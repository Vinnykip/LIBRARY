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
Public Class uscAuthorDtl
    Dim dt As DataTable
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Public Sub ClearFields()
        Me.txtAuthorID.Text = ""
        Me.txtFname.Text = ""
        Me.txtLName.Text = ""
    End Sub

    Public Sub Load_Record(ByVal iAuthorID As Integer)
        dt = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty

        sSQL = "SELECT author_id, firstname, lastname from lib_author where author_id=@AuthorID"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@AuthorID", OleDbType.Numeric).Value = iAuthorID
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtAuthorID.Text = dr("author_id")
                    Me.txtFname.Text = dr("firstname")
                    Me.txtLName.Text = dr("lastname")
                End While
            End If
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Save_Record()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try

            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If Len(Trim(Me.txtAuthorID.Text)) = 0 Then
                sSQL = "INSERT INTO lib_author ( firstname, lastname )"
                sSQL = sSQL & "  VALUES(@firstname, @lastname)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_author set firstname = @firstname, lastname =  @lastname where author_id = @AuthorID"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@firstname", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtFname.Text)) > 0, Me.txtFname.Text, DBNull.Value)
            cmd.Parameters.Add("@lastname", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtLName.Text)) > 0, Me.txtLName.Text, DBNull.Value)
            If Len(Trim(Me.txtAuthorID.Text)) > 0 Then
                cmd.Parameters.Add("@AuthorID", OleDbType.Numeric).Value = Me.txtAuthorID.Text
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data has been save.")
            Main_Library.search_Author(Main_Library.TxtsearchAuthor.Text)
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to save Author Record

    Function ValidateInput() As String
        Dim sErrMsg As String = ""
        Try
            If Len(Trim(Me.txtFname.Text)) = 0 Then
                sErrMsg = "First Name is required."
            End If
            If Len(Trim(Me.txtLName.Text)) = 0 Then
                sErrMsg = "Last Name is required."
            End If
        Catch ex As Exception
        End Try
        Return sErrMsg
    End Function 'Function to validate input for number data type

    Private Sub Delete_Author()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_author where author_id = @author_id"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@author_id", OleDbType.Numeric).Value = Me.txtAuthorID.Text

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to delete book records 

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearFields()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Dim sErr As String = ValidateInput()
            If Len(Trim(sErr)) = 0 Then
                Save_Record()
                Main_Library.search_Author(Main_Library.TxtsearchAuthor.Text)
            Else
                MsgBox(sErr)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Author()
            ClearFields()
            MsgBox("Record has been deleted.")
            Main_Library.search_Author(Main_Library.TxtsearchAuthor.Text)
        End If
    End Sub
End Class
