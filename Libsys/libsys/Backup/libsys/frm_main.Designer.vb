<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrowDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturnDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MembersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentBookBorrowedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AvailableBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MembersRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.BooksToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.MembersToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1053, 90)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.SystemToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemToolStripMenuItem.Image = CType(resources.GetObject("SystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(79, 84)
        Me.SystemToolStripMenuItem.Text = "System"
        Me.SystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionToolStripMenuItem.Image = Global.libsys.My.Resources.Resources.transaction1
        Me.TransactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(113, 84)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        Me.TransactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TransactionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.BorrowToolStripMenuItem.Text = "Borrow"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.BorrowDetailsToolStripMenuItem, Me.ReturnDetailsToolStripMenuItem})
        Me.BooksToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksToolStripMenuItem.Image = Global.libsys.My.Resources.Resources.folder_home21
        Me.BooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(69, 84)
        Me.BooksToolStripMenuItem.Text = "Books"
        Me.BooksToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'BorrowDetailsToolStripMenuItem
        '
        Me.BorrowDetailsToolStripMenuItem.Name = "BorrowDetailsToolStripMenuItem"
        Me.BorrowDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.BorrowDetailsToolStripMenuItem.Text = "Borrow Details"
        '
        'ReturnDetailsToolStripMenuItem
        '
        Me.ReturnDetailsToolStripMenuItem.Name = "ReturnDetailsToolStripMenuItem"
        Me.ReturnDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ReturnDetailsToolStripMenuItem.Text = "Return Details"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookReportToolStripMenuItem, Me.MembersReportToolStripMenuItem, Me.CurrentBookBorrowedToolStripMenuItem, Me.AvailableBooksToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Image = Global.libsys.My.Resources.Resources._41267841319675478
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(82, 84)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookReportToolStripMenuItem
        '
        Me.BookReportToolStripMenuItem.Name = "BookReportToolStripMenuItem"
        Me.BookReportToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.BookReportToolStripMenuItem.Text = "Books Report"
        '
        'MembersReportToolStripMenuItem
        '
        Me.MembersReportToolStripMenuItem.Name = "MembersReportToolStripMenuItem"
        Me.MembersReportToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.MembersReportToolStripMenuItem.Text = "Members Report"
        '
        'CurrentBookBorrowedToolStripMenuItem
        '
        Me.CurrentBookBorrowedToolStripMenuItem.Name = "CurrentBookBorrowedToolStripMenuItem"
        Me.CurrentBookBorrowedToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.CurrentBookBorrowedToolStripMenuItem.Text = "Book Borrowed"
        '
        'AvailableBooksToolStripMenuItem
        '
        Me.AvailableBooksToolStripMenuItem.Name = "AvailableBooksToolStripMenuItem"
        Me.AvailableBooksToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.AvailableBooksToolStripMenuItem.Text = "Available Books"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSystemToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Image = Global.libsys.My.Resources.Resources._100227023905969
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(86, 84)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        Me.SettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ManageSystemToolStripMenuItem
        '
        Me.ManageSystemToolStripMenuItem.Name = "ManageSystemToolStripMenuItem"
        Me.ManageSystemToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.ManageSystemToolStripMenuItem.Text = "Updating Category"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Image = Global.libsys.My.Resources.Resources.About_icon
        Me.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 84)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersRecordToolStripMenuItem})
        Me.MembersToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembersToolStripMenuItem.Image = Global.libsys.My.Resources.Resources.user_group_icon
        Me.MembersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(94, 84)
        Me.MembersToolStripMenuItem.Text = "Members"
        Me.MembersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MembersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MembersRecordToolStripMenuItem
        '
        Me.MembersRecordToolStripMenuItem.Name = "MembersRecordToolStripMenuItem"
        Me.MembersRecordToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.MembersRecordToolStripMenuItem.Text = "Members Record"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1053, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(184, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.libsys.My.Resources.Resources.Download_Windows_8_for_Dummies_E_Book_for_Free_copy1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1053, 697)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentBookBorrowedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AvailableBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
