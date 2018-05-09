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
Public Class uscMember
    Dim dtCourse As DataTable
    Dim dtMemType As DataTable
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)

    Private Sub uscMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Course()
        Load_MemberType()
        Clear_Fields()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to save data?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Save_Record()
            Main_Library.Load_Members(Main_Library.txtsearchmember.Text)
        End If
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

            If Len(Trim(Me.txtMemberID.Text)) = 0 Then
                sSQL = "INSERT INTO lib_member ( last_name, first_name, mid_ini, course_id, address, contact_no, validity_date, status, member_type )"
                sSQL = sSQL & "  VALUES(@last_name, @first_name, @mid_ini, @course_id, @address, @contact_no, @validity_date, @status, @member_type)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE lib_member set last_name = @last_name, first_name =  @first_name, mid_ini =  @mid_ini, course_id = @course_id, address = @address,"
                sSQL = sSQL & " contact_no = @contact_no, validity_date = @validity_date, status = @status, member_type = @member_type where member_id = @member_id"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@last_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtlname.Text)) > 0, Me.txtlname.Text, DBNull.Value)
            cmd.Parameters.Add("@first_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtfname.Text)) > 0, Me.txtfname.Text, DBNull.Value)
            cmd.Parameters.Add("@mid_ini", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtmname.Text)) > 0, Me.txtmname.Text, DBNull.Value)
            cmd.Parameters.Add("@course_id", OleDbType.Integer).Value = IIf(Len(Trim(Me.cboCourse.Text)) > 0, Me.cboCourse.SelectedValue, DBNull.Value)
            cmd.Parameters.Add("@address", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtAddress.Text)) > 0, Me.txtAddress.Text, DBNull.Value)
            cmd.Parameters.Add("@contact_no", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtContanct.Text)) > 0, Me.txtContanct.Text, DBNull.Value)
            cmd.Parameters.Add("@validity_date", OleDbType.Date).Value = IIf(Len(Trim(Me.dtpValidity.Text)) > 0, Me.dtpValidity.Text, DBNull.Value)
            cmd.Parameters.Add("@status", OleDbType.Integer).Value = IIf(Me.optYes.Checked, 1, 0)
            cmd.Parameters.Add("@member_type", OleDbType.Integer).Value = IIf(Len(Trim(Me.cboMemType.Text)) > 0, Me.cboMemType.SelectedValue, DBNull.Value)
            If Len(Trim(Me.txtMemberID.Text)) > 0 Then
                cmd.Parameters.Add("@member_id", OleDbType.Numeric).Value = Me.txtMemberID.Text
            End If
            cmd.ExecuteNonQuery()

            If Len(Trim(Me.txtMemberID.Text)) = 0 Then
                cmd.CommandText = "Select @@Identity"
                Me.txtMemberID.Text = cmd.ExecuteScalar()
            End If
            MsgBox("Data has been save.")

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_Record(ByVal iMemID As Integer)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim sSQL As String = String.Empty

        sSQL = "SELECT lib_member.member_id, lib_member.last_name, lib_member.first_name, lib_member.mid_ini, lib_course.code, lib_member.contact_no, lib_member.address, lib_member.validity_date, lib_member_type.member_description, lib_member.status "
        sSQL = sSQL & "FROM lib_course RIGHT JOIN (lib_member_type RIGHT JOIN lib_member ON lib_member_type.member_type_id = lib_member.member_type) ON lib_course.course_id = lib_member.course_id "
        sSQL = sSQL & "where lib_member.member_id = @member_id"
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            cmd.Parameters.Add("@member_id", OleDbType.Numeric).Value = iMemID
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtMemberID.Text = dr("member_id")
                    Me.txtfname.Text = IIf(Not IsDBNull(dr("first_name")), dr("first_name"), "")
                    Me.txtlname.Text = IIf(Not IsDBNull(dr("last_name")), dr("last_name"), "")
                    Me.txtmname.Text = IIf(Not IsDBNull(dr("mid_ini")), dr("mid_ini"), "")
                    Me.cboCourse.Text = IIf(Not IsDBNull(dr("code")), dr("code"), "")
                    Me.txtContanct.Text = IIf(Not IsDBNull(dr("contact_no")), dr("contact_no"), "")
                    Me.txtAddress.Text = IIf(Not IsDBNull(dr("address")), dr("address"), "")
                    If Not IsDBNull(dr("validity_date")) Then
                        Me.dtpValidity.Text = dr("validity_date")
                    End If
                    Me.cboMemType.Text = IIf(Not IsDBNull(dr("member_description")), dr("member_description"), "")
                    If Not IsDBNull(dr("status")) Then
                        If dr("status") = 1 Then
                            optYes.Checked = True
                        Else
                            optNo.Checked = True
                        End If
                    Else
                        optNo.Checked = True
                    End If
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Load_Course()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            dtCourse = New DataTable
            sQuery = "SELECT lib_course.course_id, lib_course.code FROM lib_course"
            conn = New OleDbConnection(constring)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            da.SelectCommand = cmd
            da.Fill(dtCourse)

            Me.cboCourse.DataSource = dtCourse
            Me.cboCourse.DisplayMember = "code"
            Me.cboCourse.ValueMember = "course_id"

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Load_MemberType()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try
            dtMemType = New DataTable
            sQuery = "SELECT lib_member_type.member_type_id, lib_member_type.member_description FROM lib_member_type"
            conn = New OleDbConnection(constring)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            da.SelectCommand = cmd
            da.Fill(dtMemType)

            Me.cboMemType.DataSource = dtMemType
            Me.cboMemType.DisplayMember = "member_description"
            Me.cboMemType.ValueMember = "member_type_id"

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Clear_Fields()
        With Me
            .txtMemberID.Text = ""
            .txtfname.Text = ""
            .txtlname.Text = ""
            .txtmname.Text = ""
            .cboCourse.SelectedIndex = -1
            .txtContanct.Text = ""
            .txtAddress.Text = ""
            .dtpValidity.Format = DateTimePickerFormat.Custom
            If Me.dtpValidity.Text <> "" Then
                .dtpValidity.Value = Now
            End If
            .cboMemType.SelectedIndex = -1
            .optYes.Checked = True
        End With
    End Sub

    Private Sub dtpValidity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpValidity.ValueChanged
        If dtpValidity.Text <> "" Then
            Me.dtpValidity.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub dtpValidity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpValidity.KeyDown
        If e.KeyCode = 8 Or e.KeyCode = 46 Then
            Me.dtpValidity.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Clear_Fields()
        Me.dtpValidity.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim res As New DialogResult

        res = MsgBox("Do you really want to delete record?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Delete_Member()
            Clear_Fields()
            MsgBox("Record has been deleted.")
            Main_Library.Load_Members(Main_Library.txtsearchmember.Text)
        End If
    End Sub

    Private Sub Delete_Member()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sQuery As String = String.Empty

        Try

            sQuery = "DELETE FROM lib_member where member_id = @member_id"
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sQuery
            cmd.Parameters.Add("@member_id", OleDbType.Numeric).Value = Me.txtMemberID.Text

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
