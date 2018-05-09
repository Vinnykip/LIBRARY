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
Public Class uscLabUser
    Public WithEvents search As frmSearch
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Private Sub uscLabUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dtpEntryTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEntryTime.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtpEntryTime.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtpEntryTime_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEntryTime.Leave
        If dtpEntryTime.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM" Then
            dtpEntryTime.Format = DateTimePickerFormat.Custom
            dtpEntryTime.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtpEntryTime_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpEntryTime.MouseDown
        If dtpEntryTime.Format = DateTimePickerFormat.Custom Then
            dtpEntryTime.Format = DateTimePickerFormat.Time
            dtpEntryTime.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
        End If
    End Sub

    Private Sub dtpExitTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpExitTime.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            dtpExitTime.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtpExitTime_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpExitTime.Leave
        If dtpExitTime.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM" Then
            dtpExitTime.Format = DateTimePickerFormat.Custom
            dtpExitTime.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub dtpExitTime_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpExitTime.MouseDown
        If dtpExitTime.Format = DateTimePickerFormat.Custom Then
            dtpExitTime.Format = DateTimePickerFormat.Time
            dtpExitTime.Value = Format(Today, "MM/dd/yyyy") & " 12:00:00 AM"
        End If
    End Sub

    Public Sub Load_Record(ByVal iLogID As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty

        sSQL = "SELECT member_laboratory_logs.log_id, member_laboratory_logs.member_id, lib_member.first_name + ' ' + lib_member.last_name as mem_name, member_laboratory_logs.entry_date,  "
        sSQL = sSQL & "member_laboratory_logs.entry_time, member_laboratory_logs.computer_no, member_laboratory_logs.baggage_rack_no, member_laboratory_logs.printing, member_laboratory_logs.print_amount, "
        sSQL = sSQL & "member_laboratory_logs.scanning, member_laboratory_logs.scan_amount, member_laboratory_logs.photo_copy, member_laboratory_logs.photo_copy_amount, member_laboratory_logs.internet, "
        sSQL = sSQL & " member_laboratory_logs.internet_fee, member_laboratory_logs.exit_time, member_laboratory_logs.total_amount "
        sSQL = sSQL & "FROM lib_member RIGHT JOIN member_laboratory_logs ON lib_member.member_id = member_laboratory_logs.member_id where log_id = @log_id"
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@log_id", OleDbType.Numeric).Value = iLogID
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtLogID.Text = dr("log_id")
                    If Not IsDBNull(dr("member_id")) Then
                        Me.txtMemName.Tag = dr("member_id")
                        Me.txtMemName.Text = dr("mem_name")
                    End If
                    Me.dtpEntryDate.Text = IIf(Not IsDBNull(dr("entry_date")), dr("entry_date"), "")
                    If Not IsDBNull(dr("entry_time")) Then
                        Me.dtpEntryTime.Format = DateTimePickerFormat.Time
                        Me.dtpEntryTime.Text = IIf(Not IsDBNull(dr("entry_time")), dr("entry_time"), "")
                    End If
                    Me.txtCompNo.Text = IIf(Not IsDBNull(dr("computer_no")), dr("computer_no"), "")
                    Me.txtBaggageNo.Text = IIf(Not IsDBNull(dr("baggage_rack_no")), dr("baggage_rack_no"), "")
                    If Not IsDBNull(dr("exit_time")) Then
                        Me.dtpExitTime.Format = DateTimePickerFormat.Time
                        Me.dtpExitTime.Text = IIf(Not IsDBNull(dr("exit_time")), dr("exit_time"), "")
                    End If

                    Me.chkPrint.Checked = dr("printing")
                    Me.txtPrint.Text = IIf(Not IsDBNull(dr("print_amount")), dr("print_amount"), "")
                    Me.chkScan.Checked = dr("scanning")
                    Me.txtScan.Text = IIf(Not IsDBNull(dr("scan_amount")), dr("scan_amount"), "")
                    Me.chkCopy.Checked = dr("photo_copy")
                    Me.txtPhotocopy.Text = IIf(Not IsDBNull(dr("photo_copy_amount")), dr("photo_copy_amount"), "")
                    Me.chkIntFee.Checked = dr("internet")
                    Me.txtInternet.Text = IIf(Not IsDBNull(dr("internet_fee")), dr("internet_fee"), "")
                    Me.txtTotal.Text = IIf(Not IsDBNull(dr("total_amount")), dr("total_amount"), "")
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

            If Len(Trim(Me.txtLogID.Text)) = 0 Then
                sSQL = "INSERT INTO member_laboratory_logs ( member_id, entry_date, entry_time, computer_no, baggage_rack_no, printing, print_amount, scanning, scan_amount, photo_copy, photo_copy_amount, internet, internet_fee, exit_time, total_amount )"
                sSQL = sSQL & "  VALUES(@member_id, @entry_date, @entry_time, @computer_no, @baggage_rack_no, @printing, @print_amount, @scanning, @scan_amount, @photo_copy, @photo_copy_amount, @internet, @internet_fee, @exit_time, @total_amount )"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE member_laboratory_logs set member_id = @member_id, entry_date =  @entry_date, entry_time =  @entry_time, computer_no = @computer_no, baggage_rack_no = @baggage_rack_no, printing = @printing , print_amount = @print_amount, scanning = @scanning, "
                sSQL = sSQL & " scan_amount = @scan_amount, photo_copy = @photo_copy, photo_copy_amount = @photo_copy_amount, internet = @internet, internet_fee = @internet_fee, exit_time = @exit_time, total_amount = @total_amount where log_id = @log_id"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@member_id", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtMemName.Text)) > 0, Me.txtMemName.Tag, DBNull.Value)
            cmd.Parameters.Add("@entry_date", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpEntryDate.Text)) > 0, Me.dtpEntryDate.Text, DBNull.Value)
            cmd.Parameters.Add("@entry_time", OleDbType.VarChar).Value = IIf(Len(Trim(Me.dtpEntryTime.Text)) > 0, Me.dtpEntryTime.Text, DBNull.Value)
            cmd.Parameters.Add("@computer_no", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtCompNo.Text)) > 0, Me.txtCompNo.Text, DBNull.Value)
            cmd.Parameters.Add("@baggage_rack_no", OleDbType.Integer).Value = IIf(Len(Trim(Me.txtBaggageNo.Text)) > 0, Me.txtBaggageNo.Text, DBNull.Value)
            cmd.Parameters.Add("@printing", OleDbType.Boolean).Value = IIf(Me.chkPrint.Checked, 1, 0)
            cmd.Parameters.Add("@print_amount", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtPrint.Text)) > 0, Me.txtPrint.Text, DBNull.Value)
            cmd.Parameters.Add("@scanning", OleDbType.Boolean).Value = IIf(Me.chkScan.Checked, 1, 0)
            cmd.Parameters.Add("@scan_amount", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtScan.Text)) > 0, Me.txtScan.Text, DBNull.Value)
            cmd.Parameters.Add("@photo_copy", OleDbType.Boolean).Value = IIf(Me.chkCopy.Checked, 1, 0)
            cmd.Parameters.Add("@photo_copy", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtPhotocopy.Text)) > 0, Me.txtPhotocopy.Text, DBNull.Value)
            cmd.Parameters.Add("@internet", OleDbType.Boolean).Value = IIf(Me.chkIntFee.Checked, 1, 0)
            cmd.Parameters.Add("@internet_fee", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtInternet.Text)) > 0, Me.txtInternet.Text, DBNull.Value)
            cmd.Parameters.Add("@exit_time", OleDbType.VarChar).Value = IIf(Len(Trim(Me.dtpExitTime.Text)) > 0, Me.dtpExitTime.Text, DBNull.Value)
            cmd.Parameters.Add("@total_amount", OleDbType.Numeric).Value = IIf(Len(Trim(Me.txtTotal.Text)) > 0, Me.txtTotal.Text, DBNull.Value)
            If Len(Trim(Me.txtLogID.Text)) > 0 Then
                cmd.Parameters.Add("@log_id", OleDbType.Numeric).Value = Me.txtLogID.Text
            End If
            cmd.ExecuteNonQuery()

            If Len(Trim(Me.txtLogID.Text)) = 0 Then
                cmd.CommandText = "Select @@Identity"
                Me.txtLogID.Text = cmd.ExecuteScalar()
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
            .txtLogID.Text = ""
            .txtMemName.Tag = ""
            .txtMemName.Text = ""
            .dtpEntryDate.Format = DateTimePickerFormat.Custom
            If Me.dtpEntryDate.Text <> "" Then
                .dtpEntryDate.Value = Now
            End If
            .dtpEntryTime.Format = DateTimePickerFormat.Custom
            If Me.dtpEntryTime.Text <> "" Then
                .dtpEntryTime.Value = Now
            End If
            .txtCompNo.Text = ""
            .txtBaggageNo.Text = ""
            .dtpExitTime.Format = DateTimePickerFormat.Custom
            If Me.dtpExitTime.Text <> "" Then
                .dtpExitTime.Value = Now
            End If
            .chkPrint.Checked = False
            .chkScan.Checked = False
            .chkCopy.Checked = False
            .chkIntFee.Checked = False
            .txtTotal.Text = "0.00"
        End With
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Dim sErr As String = ValidateInput()
            If Len(Trim(sErr)) = 0 Then
                Save_Record()
                Main_Library.Load_LabUsers()
            Else
                MsgBox(sErr)
            End If
        End If
    End Sub
    Function ValidateInput() As String
        Dim sErrMsg As String = ""
        Try
            If Len(Trim(Me.txtMemName.Text)) = 0 Then
                sErrMsg = "Member name is required."
            End If
            If Len(Trim(Me.dtpEntryDate.Text)) = 0 Then
                sErrMsg = sErrMsg & vbCrLf & "Entry date is required."
            End If
            If Len(Trim(Me.dtpEntryTime.Text)) = 0 Then
                sErrMsg = sErrMsg & vbCrLf & "Entry time is required."
            End If
            If Len(Trim(Me.txtPrint.Text)) > 0 Then
                If Not IsNumeric(Me.txtPrint.Text) Then
                    sErrMsg = sErrMsg & vbCrLf & "Invalid format print amount."
                End If
            End If
            If Len(Trim(Me.txtScan.Text)) > 0 Then
                If Not IsNumeric(Me.txtScan.Text) Then
                    sErrMsg = sErrMsg & vbCrLf & "Invalid format scan amount."
                End If
            End If
            If Len(Trim(Me.txtPhotocopy.Text)) > 0 Then
                If Not IsNumeric(Me.txtPhotocopy.Text) Then
                    sErrMsg = sErrMsg & vbCrLf & "Invalid format photocopy amount."
                End If
            End If
            If Len(Trim(Me.txtInternet.Text)) > 0 Then
                If Not IsNumeric(Me.txtInternet.Text) Then
                    sErrMsg = sErrMsg & vbCrLf & "Invalid format internet fee amount."
                End If
            End If

        Catch ex As Exception

        End Try
        Return sErrMsg
    End Function

    Private Sub chkPrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrint.CheckedChanged
        If Me.chkPrint.Checked Then
            Me.txtPrint.ReadOnly = False
        Else
            Me.txtPrint.ReadOnly = True
            Me.txtPrint.Text = "0.00"
        End If
    End Sub

    Private Sub chkScan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScan.CheckedChanged
        If Me.chkScan.Checked Then
            Me.txtScan.ReadOnly = False
        Else
            Me.txtScan.ReadOnly = True
            Me.txtScan.Text = "0.00"
        End If
    End Sub

    Private Sub chkCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCopy.CheckedChanged
        If Me.chkCopy.Checked Then
            Me.txtPhotocopy.ReadOnly = False
        Else
            Me.txtPhotocopy.ReadOnly = True
            Me.txtPhotocopy.Text = "0.00"
        End If
    End Sub

    Private Sub chkIntFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIntFee.CheckedChanged
        If Me.chkIntFee.Checked Then
            Me.txtInternet.ReadOnly = False
        Else
            Me.txtInternet.ReadOnly = True
            Me.txtInternet.Text = "0.00"
        End If
    End Sub

    Private Sub txtPrint_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrint.TextChanged
        CalculateFees()
    End Sub
    Private Sub txtScan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScan.TextChanged
        CalculateFees()
    End Sub

    Private Sub txtPhotocopy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhotocopy.TextChanged
        CalculateFees()
    End Sub

    Private Sub txtInternet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInternet.TextChanged
        CalculateFees()
    End Sub
    Private Sub CalculateFees()
        Dim subAmount As String = String.Empty

        If IsNumeric(Me.txtPrint.Text) And IsNumeric(Me.txtScan.Text) And IsNumeric(Me.txtPhotocopy.Text) And IsNumeric(Me.txtInternet.Text) Then
            Me.txtTotal.Text = Val(Replace(Me.txtPrint.Text, ",", "")) + Val(Replace(Me.txtScan.Text, ",", "")) + Val(Replace(Me.txtPhotocopy.Text, ",", "")) + Val(Replace(Me.txtInternet.Text, ",", ""))
        End If

    End Sub

    Private Sub btnBookSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookSearch.Click
        search = New frmSearch
        search.SearchType = 3
        search.ShowDialog()
    End Sub
    Private Sub SearchResult(ByVal row As DataRow) Handles search.SearchResult
        With Me
            .txtMemName.Tag = row("member_id")
            .txtMemName.Text = row("member_name")
        End With
    End Sub

    Private Sub dtpEntryDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEntryDate.ValueChanged
        If Me.dtpEntryDate.Text <> "" Then
            Me.dtpEntryDate.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub dtpEntryDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEntryDate.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpEntryDate.Format = DateTimePickerFormat.Custom
        End If
    End Sub

End Class
