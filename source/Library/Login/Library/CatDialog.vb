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
Public Class CatDialog

    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim txtCatid As New TextBox
    Dim dtcat As DataTable
    Public conn As New System.Data.OleDb.OleDbConnection

    Public Sub Load_Category()
        dtcat = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT * FROM lib_category"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtcat)
            Me.dtgCat.DataSource = dtcat
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Save_Category()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try

            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If Len(Trim(Me.txtCatid.Text)) = 0 Then
                sSQL = "INSERT INTO lib_category ( category_description )"
                sSQL = sSQL & "  VALUES(@cat_description)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_category set category_description = @cat_description where Category_ID = @CatID"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@cat_description", OleDbType.VarChar).Value = IIf(Len(Trim(Me.cat_description.Text)) > 0, Me.cat_description.Text, DBNull.Value)
            If Len(Trim(Me.txtCatid.Text)) > 0 Then
                cmd.Parameters.Add("@CatID", OleDbType.Numeric).Value = Me.txtCatid.Text
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data has been save.")
            Load_Category()
            cat_description.Clear()
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to save Book Record

    Private Sub Delete_category()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_category where Category_ID = @CatID"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            If Len(Trim(Me.txtCatid.Text)) > 0 Then
                cmd.Parameters.Add("@CatID", OleDbType.Numeric).Value = Me.txtCatid.Text
            End If

            cmd.ExecuteNonQuery()
            Load_Category()
            cat_description.Clear()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try

    End Sub 'Function to delete book records 


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_category()
            'Clear_Fields()
            MsgBox("Record has been deleted.")
        End If
    End Sub

    Private Sub CatDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Category()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        cat_description.Clear()
        txtCatid.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
       If cat_description.Text = "" Then
            MessageBox.Show("Insert Categury Name Please!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Save_Category()
        End If
    End Sub

    Private Sub dtgCat_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCat.CellClick
        Try
            If dtgCat.Rows.Count > 0 Then
                cat_description.Text = dtgCat.SelectedCells(1).Value
                txtCatid.Text = dtgCat.SelectedCells(0).Value
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class