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
Public Class uscVendor
    Dim dt As DataTable
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Public Sub ClearFields()
        Me.txtVendorNo.Text = ""
        Me.txtVendorName.Text = ""
        Me.txtVendorAddr.Text = ""
        Me.TxtVendorContact.Text = ""
    End Sub

    Public Sub Load_Record(ByVal iVendorID As Integer)
        dt = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty

        sSQL = "SELECT vendor_id, vendor_name, vendor_address, vendor_contact_no from lib_vendor where vendor_id=@iVendorID "
        'Try
        conn = New OleDbConnection(constring)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sSQL
        cmd.Parameters.Add("@iVendorID", OleDbType.Numeric).Value = iVendorID
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Me.txtVendorNo.Text = dr("vendor_id")
                Me.txtVendorName.Text = dr("vendor_name")
                ''Me.txtVendorAddr.Text = dr("vendor_address")
                Me.txtVendorAddr.Text = IIf(Not IsDBNull(dr("vendor_address")), dr("vendor_address"), "")
                ''Me.TxtVendorContact.Text = dr("vendor_contact_no")
                Me.TxtVendorContact.Text = IIf(Not IsDBNull(dr("vendor_contact_no")), dr("vendor_contact_no"), "")
            End While
        End If
        'Catch ex As Exception
        '    MsgBox(ErrorToString)
        'Finally
        conn.Close()
        'End Try
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

            If Len(Trim(Me.txtVendorNo.Text)) = 0 Then
                sSQL = "INSERT INTO lib_vendor ( vendor_name, vendor_address, vendor_contact_no )"
                sSQL = sSQL & "  VALUES(@vendor_name, @vendor_address, @vendor_contact_no )"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_author set vendor_name = @vendor_name, vendor_address =  @vendor_address, vendor_contact_no = @vendor_contact_no where vendor_id = @vendor_id"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@vendor_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtVendorName.Text)) > 0, Me.txtVendorName.Text, DBNull.Value)
            cmd.Parameters.Add("@vendor_address", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtVendorAddr.Text)) > 0, Me.txtVendorAddr.Text, DBNull.Value)
            cmd.Parameters.Add("@vendor_contact_no", OleDbType.VarChar).Value = IIf(Len(Trim(Me.TxtVendorContact.Text)) > 0, Me.TxtVendorContact.Text, DBNull.Value)
            If Len(Trim(Me.txtVendorNo.Text)) > 0 Then
                cmd.Parameters.Add("@vendor_id", OleDbType.Numeric).Value = Me.txtVendorNo.Text
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Data has been save.")
            Main_Library.search_vendor(Main_Library.TxtsearchVendor.Text)
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub 'Function to save Author Record

    Function ValidateInput() As String
        Dim sErrMsg As String = ""
        'Try
        If Len(Trim(Me.txtVendorName.Text)) = 0 Then
            sErrMsg = "First Name is required."
        End If
        If Len(Trim(Me.txtVendorAddr.Text)) = 0 Then
            sErrMsg = "Last Name is required."
        End If
        'Catch ex As Exception
        'End Try
        Return sErrMsg
    End Function 'Function to validate input for number data type

    Private Sub Delete_Vendor()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            sQuery = "DELETE FROM lib_vendor where vendor_id = @vendor_id"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@vendor_id", OleDbType.TinyInt).Value = Me.txtVendorNo.Text

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
                Main_Library.search_vendor(Main_Library.TxtsearchVendor.Text)
            Else
                MsgBox(sErr)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Vendor()
            ClearFields()
            MsgBox("Record has been deleted.")
            Main_Library.search_vendor(Main_Library.TxtsearchVendor.Text)
        End If
    End Sub
End Class
