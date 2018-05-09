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
Public Class uscReturn
    Public _IssuanceNo As Long
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Public Property IssuanceNo As Long
        Get
            Return _IssuanceNo
        End Get
        Set(ByVal value As Long)
            _IssuanceNo = value
        End Set
    End Property
    Private Sub uscReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtIssuanceNo.Text = _IssuanceNo
    End Sub
    Public Sub Load_Record(ByVal iBarrowNo As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_return.return_trn_no, lib_return.barrow_trn_no, lib_return.date_return, lib_return.remarks, lib_return.fine_amount "
        sSQL = sSQL & "FROM lib_return WHERE (((lib_return.return_trn_no)=@return_trn_no))"
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@return_trn_no", OleDbType.Numeric).Value = iBarrowNo
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtReturnNo.Text = dr("return_trn_no")
                    Me.txtIssuanceNo.Text = dr("barrow_trn_no")
                    Me.dtpRtnDate.Text = IIf(Not IsDBNull(dr("date_return")), dr("date_return"), "")
                    Me.txtRemarks.Text = IIf(Not IsDBNull(dr("remarks")), dr("remarks"), "")
                    Me.txtFine.Text = IIf(Not IsDBNull(dr("fine_amount")), dr("fine_amount"), "")
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

            If Len(Trim(Me.txtReturnNo.Text)) = 0 Then
                sSQL = "INSERT INTO lib_return ( barrow_trn_no, date_return, remarks, fine_amount )"
                sSQL = sSQL & "  VALUES(@barrow_trn_no, @date_return, @remarks, @fine_amount )"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_return set barrow_trn_no = @barrow_trn_no, date_return =  @date_return, remarks =  @remarks, fine_amount = @fine_amount where retrun_trn_no = @retrun_trn_no"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@barrow_trn_no", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtIssuanceNo.Text)) > 0, Me.txtIssuanceNo.Text, DBNull.Value)
            cmd.Parameters.Add("@date_return", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpRtnDate.Text)) > 0, Me.dtpRtnDate.Text, DBNull.Value)
            cmd.Parameters.Add("@remarks", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtRemarks.Text)) > 0, Me.txtRemarks.Text, DBNull.Value)
            cmd.Parameters.Add("@fine_amount", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtFine.Text)) > 0, Me.txtFine.Text, DBNull.Value)
            If Len(Trim(Me.txtReturnNo.Text)) > 0 Then
                cmd.Parameters.Add("@retrun_trn_no", OleDbType.Numeric).Value = Me.txtReturnNo.Text
            End If
            cmd.ExecuteNonQuery()

            If Len(Trim(Me.txtReturnNo.Text)) = 0 Then
                cmd.CommandText = "Select @@Identity"
                Me.txtReturnNo.Text = cmd.ExecuteScalar()
            End If
            MsgBox("Data has been save.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Dim sErr As String = ValidateInput()
            If Len(Trim(sErr)) = 0 Then
                Save_Record()
                Main_Library.Load_BarrowedBooks()
                Main_Library.Load_DueBooks()
                Main_Library.Load_ReturnBooks()
                Clear_Fields()
            Else
                MsgBox(sErr)
            End If
        End If
    End Sub
    Function ValidateInput() As String
        Dim sErrMsg As String = ""
        Try
            If Len(Trim(Me.dtpRtnDate.Text)) = 0 Then
                sErrMsg = "Return Date is required."
            End If
            If Len(Trim(txtFine.Text)) > 0 Then
                If Not IsNumeric(Me.txtFine.Text) Then
                    sErrMsg = sErrMsg & vbCrLf & "Fine amount is invalid format."
                End If
            End If
            Try
                If Len(Trim(Me.txtIssuanceNo.Text)) > 0 Then
                    Convert.ToInt16(Me.txtIssuanceNo.Text)
                End If
            Catch ex As Exception
                sErrMsg = sErrMsg & vbCrLf & "Only number is allowed in issuance no."
            End Try
        Catch ex As Exception

        End Try
        Return sErrMsg
    End Function

    Private Sub dtpRtnDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpRtnDate.ValueChanged
        If Me.dtpRtnDate.Text <> "" Then
            Me.dtpRtnDate.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub dtpRtnDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpRtnDate.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpRtnDate.Format = DateTimePickerFormat.Custom
        End If
    End Sub
    Public Sub Clear_Fields()
        With Me
            .txtReturnNo.Text = ""
            .txtIssuanceNo.Text = ""

            .dtpRtnDate.Format = DateTimePickerFormat.Custom
            If Me.dtpRtnDate.Text <> "" Then
                .dtpRtnDate.Value = Now
            End If
            .txtRemarks.Text = ""
            .txtFine.Text = ""
        End With
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Clear_Fields()
        Me.dtpRtnDate.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Book()
            Clear_Fields()
            Me.dtpRtnDate.Format = DateTimePickerFormat.Custom
            MsgBox("Record has been deleted.")
        End If
    End Sub
    Private Sub Delete_Book()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_return where retrun_trn_no = @retrun_trn_no"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@retrun_trn_no", OleDbType.Numeric).Value = Me.txtReturnNo.Text

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
