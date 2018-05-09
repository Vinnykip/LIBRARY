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
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Main_Library

#Region "Declaration: Variables"
    Dim WithEvents dtpFr As New DateTimePicker
    Dim WithEvents dtpTo As New DateTimePicker
    Dim lblFr As New ToolStripLabel
    Dim lblTo As New ToolStripLabel
    Dim WithEvents btnSearch As New ToolStripButton
    Dim constring As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Dbase\LibraryDB.accdb;"
    Dim cn As New OleDbConnection(constring)
    Dim dtBarrowed As DataTable
    Dim dtDueBook As DataTable
    Dim dtReturn As DataTable
    Dim dtLabUser As DataTable
    Dim dtBook As DataTable
    Dim dtAuthor As DataTable
    Dim dtVendor As DataTable
    Dim dtMember As DataTable
    Dim dtCourse As DataTable
    Dim dtDept As DataTable
    ''Dim dtLabUser As New DataTable

    Dim cBarrowDtl As uscBarrow
    Dim cBookDtl As uscBookDtl
    Dim cAuthorDtl As uscAuthorDtl
    Dim cVendorDtl As uscVendor
    Dim cMemberDtl As uscMember
    Dim cLabUserDtl As uscLabUser
    Public cReturn As uscReturn

    'Declaration for Crystal Report
    Dim dsReport As DataSet
    Private pDataset As DataSet
    Private pReportPath As String
    Private pReportTitle As String
#End Region

    'Application Menu Items

    Private Sub ToolLabUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolLabUser.Click
        frmLabUsers.ShowDialog()
    End Sub

    Private Sub ToolMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SetToolSripItem()
        dtpFr.Format = DateTimePickerFormat.Short
        dtpFr.Width = 100
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Width = 100
        lblFr.Text = "From :"
        lblTo.Text = "To :"
        btnSearch.Image = My.Resources.Resources.searchimg

        With ToolStripret.Items
            .Add(lblFr)
            .Add(New ToolStripControlHost(dtpFr))
            .Add(lblTo)
            .Add(New ToolStripControlHost(dtpTo))
            .Add(btnSearch)
        End With

    End Sub

#Region "Functions: LOAD"

    Public Sub Load_BarrowedBooks()
        dtBarrowed = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT lib_barrow.barrow_trn_no, lib_books.title, lib_member.first_name + ' ' + lib_member.last_name as mem_name, lib_barrow.date_barrow, lib_barrow.due_date "
        sSQL = sSQL & "FROM (lib_member RIGHT JOIN (lib_books RIGHT JOIN lib_barrow ON lib_books.BookID = lib_barrow.bookID) ON lib_member.member_id = lib_barrow.member_id) LEFT JOIN lib_return ON lib_barrow.barrow_trn_no = lib_return.barrow_trn_no "
        sSQL = sSQL & "where(lib_return.barrow_trn_no Is null) order by lib_barrow.date_barrow asc"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtBarrowed)
            Me.dtgBarrowRes.DataSource = dtBarrowed
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_DueBooks()
        dtDueBook = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT lib_books.title, lib_member.first_name + ' ' + lib_member.last_name as mem_name, lib_barrow.date_barrow, lib_barrow.due_date, lib_member.contact_no, lib_member.address "
        sSQL = sSQL & "FROM lib_member RIGHT JOIN (lib_books RIGHT JOIN (lib_barrow LEFT JOIN lib_return ON lib_barrow.barrow_trn_no = lib_return.barrow_trn_no) ON lib_books.BookID = lib_barrow.bookID) ON lib_member.member_id = lib_barrow.member_id "
        sSQL = sSQL & "WHERE (((lib_barrow.due_date)<=Date()) AND ((lib_return.barrow_trn_no) Is Null)) order by lib_barrow.due_date"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtDueBook)
            Me.dtgDueRes.DataSource = dtDueBook

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_ReturnBooks()
        dtReturn = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_return.return_trn_no, lib_books.title, lib_return.date_return, lib_member.first_name + ' ' + lib_member.last_name as mem_name "
        sSQL = sSQL & "FROM lib_books RIGHT JOIN (lib_member RIGHT JOIN (lib_barrow RIGHT JOIN lib_return ON lib_barrow.barrow_trn_no = lib_return.barrow_trn_no) ON lib_member.member_id = lib_barrow.member_id) ON lib_books.BookID = lib_barrow.bookID "
        sSQL = sSQL & "WHERE (((lib_return.date_return)>=#" & dtpFr.Text & "# And (lib_return.date_return)<=#" & dtpTo.Text & "#))"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtReturn)
            Me.dtgReturnRes.DataSource = dtReturn

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_LabUsers()
        dtLabUser = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT member_laboratory_logs.log_id, lib_member.first_name+' '+lib_member.last_name AS mem_name, member_laboratory_logs.entry_time, lib_course.code "
        sSQL = sSQL & "FROM lib_course RIGHT JOIN (lib_member RIGHT JOIN member_laboratory_logs ON lib_member.member_id = member_laboratory_logs.member_id) ON lib_course.course_id = lib_member.course_id "
        sSQL = sSQL & "WHERE (((member_laboratory_logs.entry_date)=Date())) "

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtLabUser)
            Me.dtgLabRes.DataSource = dtLabUser

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_Books(ByVal strSearch As String)
        dtBook = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT d.BookID, d.title, b.category_description, c.firstname+' '+c.lastname AS author_name "
        sSQL = sSQL & "FROM lib_category AS b RIGHT JOIN (lib_author AS c RIGHT JOIN lib_books AS d ON c.author_id = d.author_id) ON b.category_id = d.category_id "
        If Len(Trim(strSearch)) > 0 Then
            sSQL = sSQL & "where title like '%" & strSearch & "%'"
        End If

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtBook)
            Me.dtgBook.DataSource = dtBook
            Me.ToolBookscount.Text = "Number of Books : " & Me.dtgBook.RowCount & ""  'Show number of records to the footer"
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_Members(ByVal strSearch As String)
        dtMember = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_member.member_id, lib_member.first_name + ' ' + lib_member.last_name as mem_name, lib_member.contact_no, lib_course.code as course_description, lib_member_type.member_description "
        sSQL = sSQL & "FROM lib_course RIGHT JOIN (lib_member_type RIGHT JOIN lib_member ON lib_member_type.member_type_id = lib_member.member_type) ON lib_course.course_id = lib_member.course_id "
        If Len(Trim(strSearch)) > 0 Then
            sSQL = sSQL & "where lib_member.first_name + ' ' + lib_member.last_name like '%" & strSearch & "%'"
        End If

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dtMember)
            Me.dtgMemRes.DataSource = dtMember
            Me.ToolMemcount.Text = "Number of Members : " & Me.dtgMemRes.RowCount & ""  'Show number of records to the footer"
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

#End Region

#Region "Functions:Search"
    Public Sub search_Author(ByVal sSearch As String)
        dtAuthor = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT author_id, firstname, lastname from lib_author "

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
            da.Fill(dtAuthor)
            Me.dtgAuthor.DataSource = dtAuthor

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub search_vendor(ByVal sSearch As String)
        dtVendor = New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        sSQL = "SELECT vendor_id, vendor_name, vendor_address, vendor_contact_no from lib_vendor "

        If Len(Trim(sSearch)) > 0 Then
            sSQL = sSQL & "where vendor_name like '%" & sSearch & "%'"
        End If

        'Try
        conn = New OleDbConnection(constring)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sSQL
        da.SelectCommand = cmd
        da.Fill(dtVendor)
        Me.dtgVendor.DataSource = dtVendor

        'Catch ex As Exception
        '    MsgBox(ErrorToString)
        'Finally
        conn.Close()
        'End Try
    End Sub
#End Region

    Private Sub Main_Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainTab1.SelectedTabIndex = 0
        Maintab1Books.Visible = False
        MainTab1Manage.Visible = True
        MainTab1Users.Visible = False
        MainTab1Reports.Visible = False
        SetToolSripItem()
        Load_BarrowedBooks()
        If dtBook Is Nothing Then
            Load_Books(txtBookSearch.Text)
        End If
        'If dtMember Is Nothing Then
        Load_Members(txtsearchmember.Text)
        'End If
    End Sub

    'Menu Item: Records

    Private Sub ToolBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBooks.Click
        MainTab1.SelectedTabIndex = 1

        If ToolBooks.CheckState = CheckState.Checked Then
            Maintab1Books.Visible = True
            MainTab1.SelectedTabIndex = 1
        Else
            Maintab1Books.Visible = False
        End If
    End Sub

    Private Sub ToolLibUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolLibUsers.Click
        MainTab1.SelectedTabIndex = 2
        If ToolLibUsers.CheckState = CheckState.Checked Then
            MainTab1Users.Visible = True
            MainTab1.SelectedTabIndex = 2
        Else
            MainTab1Users.Visible = False
        End If
    End Sub

    Private Sub ToolReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolReports.Click
        MainTab1.SelectedTabIndex = 3
        If ToolReports.CheckState = CheckState.Checked Then
            MainTab1Reports.Visible = True
            MainTab1.SelectedTabIndex = 3
        Else
            MainTab1Reports.Visible = False
        End If
    End Sub

    Private Sub ToolManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolManage.Click
        MainTab1.SelectedTabIndex = 0
        If ToolManage.CheckState = CheckState.Checked Then
            MainTab1Manage.Visible = True
            MainTab1.SelectedTabIndex = 0
        ElseIf ToolManage.CheckState = CheckState.Unchecked Then
            MainTab1Manage.Visible = True
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Load_ReturnBooks()
    End Sub

    Private Sub MainTab2_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles MainTab2.SelectedTabChanged
        Select Case MainTab2.SelectedTabIndex
            Case 0
                ''Load_BarrowedBooks()
            Case 1
                Load_DueBooks()
            Case 2
                Load_ReturnBooks()
            Case 3
                Load_LabUsers()
        End Select
    End Sub

    Private Sub MainTab3_SelectedTabChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles MainTab3.SelectedTabChanged
        Select Case MainTab3.SelectedTabIndex
            Case 0
                'If dtBook Is Nothing Then
                '    Load_Books(txtBookSearch.Text)
                'End If
            Case 1
                If dtAuthor Is Nothing Then
                    search_Author(TxtsearchAuthor.Text)
                End If
            Case 2
                search_vendor(Me.TxtsearchVendor.Text)
        End Select
    End Sub

    Private Sub dtgBarrowRes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBarrowRes.CellClick
        If splitborrow.Panel2.Controls.Count = 0 Then
            cBarrowDtl = New uscBarrow
            splitborrow.Panel2.Controls.Add(cBarrowDtl)
        End If
        cBarrowDtl.Clear_Fields()
        cBarrowDtl.Load_Record(Me.dtgBarrowRes.Item(0, Me.dtgBarrowRes.CurrentRow.Index).Value)
    End Sub

    Private Sub tsbBookSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Books(txtBookSearch.Text)
    End Sub

    Private Sub dtgBook_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBook.CellClick
        If SplitContainer1.Panel2.Controls.Count = 0 Then
            cBookDtl = New uscBookDtl
            SplitContainer1.Panel2.Controls.Add(cBookDtl)
        End If
        cBookDtl.Clear_Fields()
        cBookDtl.Load_Record(Me.dtgBook.Item(0, Me.dtgBook.CurrentRow.Index).Value)

    End Sub

    Private Sub txtBookSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBookSearch.TextChanged
        Load_Books(txtBookSearch.Text)
    End Sub

    'CONTEXTMENU: Book / Borrow

    Private Sub toolbookrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbookrefresh.Click
        Load_Books(txtBookSearch.Text)
    End Sub

    Private Sub toolbookhide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbookhide.Click
        If SplitContainer1.Panel2Collapsed = False Then
            SplitContainer1.Panel2Collapsed = True
            toolbookhide.Enabled = False
            toolbookdisp.Enabled = True
        End If
    End Sub

    Private Sub toolbookdisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbookdisp.Click
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
            toolbookhide.Enabled = True
            toolbookdisp.Enabled = False
        End If
    End Sub

    Private Sub toolborrowrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolborrowrefresh.Click
        Load_BarrowedBooks()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolborrowdisp.Click
        If splitborrow.Panel2Collapsed = True Then
            splitborrow.Panel2Collapsed = False
            toolborrowhide.Enabled = True
            toolborrowdisp.Enabled = False
        End If
    End Sub

    Private Sub toolborrowhide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolborrowhide.Click
        If splitborrow.Panel2Collapsed = False Then
            splitborrow.Panel2Collapsed = True
            toolborrowhide.Enabled = False
            toolborrowdisp.Enabled = True
        End If
    End Sub



    '/ AUTHOR TAB ////////////>>>>>>


    Private Sub TxtsearchAuthor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtsearchAuthor.TextChanged
        search_Author(TxtsearchAuthor.Text)
    End Sub

    Private Sub dtgAuthor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgAuthor.CellClick
        If SplitContainer2.Panel2.Controls.Count = 0 Then
            cAuthorDtl = New uscAuthorDtl
            SplitContainer2.Panel2.Controls.Add(cAuthorDtl)
        End If
        cAuthorDtl.ClearFields()
        cAuthorDtl.Load_Record(Me.dtgAuthor.Item(0, Me.dtgAuthor.CurrentRow.Index).Value)
    End Sub



    '/ VENDOR TAB ////////////>>>>>>

    Private Sub TxtsearchVendor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtsearchVendor.TextChanged
        search_vendor(Me.TxtsearchVendor.Text)
    End Sub

    Private Sub dtgVendor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVendor.CellClick
        If SplitContainer3.Panel2.Controls.Count = 0 Then
            cVendorDtl = New uscVendor
            SplitContainer3.Panel2.Controls.Add(cVendorDtl)
        End If
        cVendorDtl.ClearFields()
        cVendorDtl.Load_Record(Me.dtgVendor.Item(0, Me.dtgVendor.CurrentRow.Index).Value)
    End Sub



    '/ MEMBERS TAB ////////////>>>>>>


    Private Sub txtsearchmember_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearchmember.TextChanged
        Load_Members(txtsearchmember.Text)
    End Sub

    Private Sub dtgMemRes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgMemRes.CellClick
        If SplitContainer8.Panel2.Controls.Count = 0 Then
            cMemberDtl = New uscMember
            SplitContainer8.Panel2.Controls.Add(cMemberDtl)
        End If
        cMemberDtl.Clear_Fields()
        cMemberDtl.Load_Record(Me.dtgMemRes.Item(0, Me.dtgMemRes.CurrentRow.Index).Value)
    End Sub

    Private Sub ToolMemberRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolMemberRefresh.Click
        Load_Members(txtsearchmember.Text)
    End Sub

    Private Sub ToolMemberDisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolMemberDisp.Click
        If SplitContainer8.Panel2Collapsed = True Then
            SplitContainer8.Panel2Collapsed = False
            ToolMemberHide.Enabled = True
            ToolMemberDisp.Enabled = False
        End If
    End Sub

    Private Sub ToolMemberHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolMemberHide.Click
        If SplitContainer8.Panel2Collapsed = False Then
            SplitContainer8.Panel2Collapsed = True
            ToolMemberHide.Enabled = False
            ToolMemberDisp.Enabled = True
        End If
    End Sub


    '/ REPORTS TAB /////////>>>>>>>

#Region "REPORTS TAB ////////////>>>>>> CHART VIEWER"

    Private Sub Load_Lab_User_Report()
        dtLabUser = GetLabUser()
        Dim totCount As Double = 0

        For Each row As DataRow In dtLabUser.Rows
            totCount = totCount + row(1)
        Next

        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add(0)
        Chart1.Series.Clear()
        Chart1.Series.Add("Departments")

        'Chart1.DataSource = dt

        Dim CArea As ChartArea = Chart1.ChartAreas(0)
        Chart1.Titles.Clear()
        Dim T As Title = Chart1.Titles.Add("Libarary Laboratory Report from " & Format(CDate(Me.dtpFrom.Text), "MMM dd, yyyy") & " to " & Format(CDate(Me.dtpTodate.Text), "MMM dd, yyyy"))
        With T
            .ForeColor = Color.White
            .BackColor = Color.DodgerBlue

            .Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Regular)
            .BorderColor = Color.Black
        End With


        Dim Series1 As Series = Chart1.Series("Departments")
        Chart1.Series(Series1.Name).Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular)
        Chart1.Series(Series1.Name).YValueType = ChartValueType.Double
        Chart1.Series(Series1.Name).IsValueShownAsLabel = True
        Chart1.Series(Series1.Name).LabelForeColor = Color.Black
        Chart1.Series(Series1.Name).LabelFormat = "{#.00}%"
        For Each row As DataRow In dtLabUser.Rows
            Dim dPercnt As Double = (row(1) / totCount) * 100
            Chart1.Series("Departments").Points.AddXY(row(0), dPercnt)
        Next

        'Chart1.Series("Departments").Points.AddXY("Jordan", 30.1)
        'Chart1.Series("Departments").Points.AddXY("Yen", 39.9)
        'Chart1.Series("Departments").Points.AddXY("Nick", 20.0)
        Chart1.Series("Departments").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Departments")("PieLabelStyle") = "Outside"
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True

        Dim LG As Legend = Chart1.Legends(0)
        LG.BackColor = Color.Transparent
        LG.ForeColor = Color.White
        LG.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular)

        LG.Title = "List of Departments"
        LG.TitleFont = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular)
        LG.TitleForeColor = Color.White
        Chart1.Location = New System.Drawing.Point(3, 7)
        Chart1.Size = New System.Drawing.Size(630, 350)
    End Sub

    Function GetLabUser()
        Dim dt As New DataTable
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty

        'HAVING (((member_laboratory_logs.entry_date)<="today"));


        sSQL = "SELECT lib_department.department_description, Count(lib_department.department_id) AS dep_count "
        sSQL = sSQL & "FROM (lib_department INNER JOIN (lib_course INNER JOIN lib_member ON lib_course.course_id = lib_member.course_id) ON lib_department.department_id = lib_course.department_id) INNER JOIN member_laboratory_logs ON lib_member.member_id = member_laboratory_logs.member_id "
        sSQL = sSQL & "WHERE (((member_laboratory_logs.entry_date)>=#" & dtpFrom.Text & "# And (member_laboratory_logs.entry_date)<=#" & dtpTodate.Text & "#))"
        sSQL = sSQL & "GROUP BY lib_department.department_description"

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            If Me.cboReport.SelectedIndex >= 0 Then
                Select Case Me.cboReport.Text
                    Case "Lab Users by Department"
                        Load_Lab_User_Report()
                End Select
            End If
        Catch
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If Me.Chart1.Series.Count > 0 Then
            Chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = True
            Chart1.Printing.PrintPreview()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Me.Chart1.Series.Count > 0 Then
            Chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = True
            Chart1.Printing.Print(True)
        End If
    End Sub

#End Region

#Region "REPORTS TAB ////////////>>>>>> REPORT VIEWER"

    Function GetListOfBooks() As DataSet
        Dim ds As New DataSet
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_books.title, lib_author.firstname+' '+lib_author.lastname AS author_name, lib_books.isbn_no, lib_books.publish_date, lib_category.category_description "
        sSQL = sSQL & "FROM lib_category INNER JOIN (lib_author INNER JOIN lib_books ON lib_author.author_id = lib_books.author_id) ON lib_category.category_id = lib_books.category_id order by lib_books.title "
        'sSQL = sSQL & "where lib_barrow.barrow_trn_no = @trnno"
        Try
            conn = New OleDbConnection(constring)
            'conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            'cmd.Parameters.Add("@trnno", OleDbType.Numeric).Value = 1
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return ds
    End Function

    Function GetListOfBorrowedBooks() As DataSet
        Dim ds As New DataSet
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_barrow.barrow_trn_no, lib_books.title, lib_member.first_name + ' ' + lib_member.last_name as mem_name, lib_barrow.date_barrow, lib_barrow.due_date "
        sSQL = sSQL & "FROM (lib_member RIGHT JOIN (lib_books RIGHT JOIN lib_barrow ON lib_books.BookID = lib_barrow.bookID) ON lib_member.member_id = lib_barrow.member_id) LEFT JOIN lib_return ON lib_barrow.barrow_trn_no = lib_return.barrow_trn_no "
        sSQL = sSQL & "where(lib_return.barrow_trn_no Is null) order by lib_barrow.date_barrow asc"
        Try
            conn = New OleDbConnection(constring)
            'conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            'cmd.Parameters.Add("@trnno", OleDbType.Numeric).Value = 1
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return ds
    End Function

    Function GetListOfBooksReturned() As DataSet
        Dim ds As New DataSet
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim sSQL As String = String.Empty


        sSQL = "SELECT lib_return.return_trn_no, lib_books.title, lib_return.date_return, lib_member.first_name + ' ' + lib_member.last_name as mem_name "
        sSQL = sSQL & "FROM lib_books RIGHT JOIN (lib_member RIGHT JOIN (lib_barrow RIGHT JOIN lib_return ON lib_barrow.barrow_trn_no = lib_return.barrow_trn_no) ON lib_member.member_id = lib_barrow.member_id) ON lib_books.BookID = lib_barrow.bookID "
        Try
            conn = New OleDbConnection(constring)
            'conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sSQL
            'cmd.Parameters.Add("@trnno", OleDbType.Numeric).Value = 1
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return ds
    End Function

    Private Sub BtnPreviewRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreviewRpt.Click
        ''Dim frm As New frmReportViewer
        ''frm.ReportDataSet = dsReport
        'Me.ReportDataSet = dsReport
        'Me.ReportPath = My.Application.Info.DirectoryPath.ToString() & "\Reports"
        'Me.ReportTitle = Me.Cmbreport.Text
        'PrintPreview()

        If Cmbreport.Text = "List of Books" Then
            dsReport = GetListOfBooks()
            CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath.ToString() & "\Reports\ListOfBooks.rpt"
        ElseIf Cmbreport.Text = "List of Borrowed Books" Then
            dsReport = GetListOfBorrowedBooks()
            CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath.ToString() & "\Reports\ListOfBooksBorrowed.rpt"
        ElseIf Cmbreport.Text = "List of Books Returned" Then
            dsReport = GetListOfBooksReturned()
            CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath.ToString() & "\Reports\ListOfBooksReturned.rpt"
        End If
    End Sub

    Public Property ReportDataSet As DataSet
        Get
            Return pDataset
        End Get
        Set(ByVal value As DataSet)
            pDataset = value
        End Set
    End Property

    Public Property ReportPath As String
        Get
            Return pReportPath
        End Get
        Set(ByVal value As String)
            pReportPath = value
        End Set
    End Property

    Public Property ReportTitle As String
        Get
            Return pReportTitle
        End Get
        Set(ByVal value As String)
            pReportTitle = value
        End Set
    End Property

    Function GetReportFileName() As String
        Dim sRptFileName As String = String.Empty

        Select Case pReportTitle
            Case "List of Books"
                sRptFileName = "ListOfBooks.rpt"
        End Select
        Return sRptFileName
    End Function

    Public Sub PrintPreview()
        Dim rptDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        'Dim lCRViewerForm As ReportViewer = Nothing
        'Try
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        If rptDocument Is Nothing Then
            rptDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        End If

        'If lCRViewerForm Is Nothing Then
        '    lCRViewerForm = New ReportViewer
        'End If

        'If Not IO.File.Exists(pReportPath) Then
        '    Throw (New Exception("Unable to locate report file:" & _
        '        vbCrLf & pReportPath))
        '    Exit Sub
        'End If
        If Microsoft.VisualBasic.Right(pReportPath, 1) = "\" Then
            pReportPath = pReportPath & GetReportFileName()
        Else
            pReportPath = pReportPath & "\" & GetReportFileName()
            ''pReportPath = pReportPath
        End If

        rptDocument.Load(pReportPath)
        rptDocument.SetDataSource(pDataset.Tables(0))

        CrystalReportViewer1.ReportSource = rptDocument


        'lCRViewerForm.Text = pReportTitle
        'lCRViewerForm.ShowDialog()
        'rptDocument.Dispose()
        'lCRViewerForm = Nothing

        'Catch ex As Exception
        '    MessageBox.Show("mod_generic - PrintPreview" & ControlChars.NewLine & ex.Message.ToString())
        '    Exit Sub
        'Finally

        'End Try
    End Sub

#End Region

    Private Sub dtgLabRes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgLabRes.CellClick
        If SplitContainer4.Panel2.Controls.Count = 0 Then
            cLabUserDtl = New uscLabUser
            SplitContainer4.Panel2.Controls.Add(cLabUserDtl)
        End If
        cLabUserDtl.Clear_Fields()
        cLabUserDtl.Load_Record(Me.dtgLabRes.Item(0, Me.dtgLabRes.CurrentRow.Index).Value)
    End Sub

    Private Sub dtgReturnRes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgReturnRes.CellClick
        If SplitContainer5.Panel2.Controls.Count = 0 Then
            cReturn = New uscReturn
            SplitContainer5.Panel2.Controls.Add(cReturn)
        End If
        cReturn.Clear_Fields()
        cReturn.Load_Record(Me.dtgReturnRes.Item(0, Me.dtgReturnRes.CurrentRow.Index).Value)
    End Sub

#Region " HELP------------------------------------------HELP''"
    Private Sub ToolAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAbout.Click
        MainTab1.SelectedTabIndex = 4
    End Sub
#End Region

    Private Sub ToolAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolAccount.Click
        FrmNewUser.BtnCancel.ButtonText = "Close"
        FrmNewUser.Btnclose.Visible = False
        FrmNewUser.Btnmin.Visible = False
        FrmNewUser.ShowDialog()
    End Sub


    'Private Sub CmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCourse.SelectedIndexChanged
    '    Filter_Members()
    'End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub
End Class