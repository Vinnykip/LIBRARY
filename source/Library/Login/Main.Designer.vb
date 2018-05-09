<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Strip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolRole = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolUname = New System.Windows.Forms.ToolStripLabel()
        Me.Strip1 = New System.Windows.Forms.ToolStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMinimize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolApp = New System.Windows.Forms.ToolStripButton()
        Me.ToolHide = New System.Windows.Forms.ToolStripButton()
        Me.ToolLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolShutdown = New System.Windows.Forms.ToolStripButton()
        Me.notif = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PnlDesktop = New System.Windows.Forms.Panel()
        Me.BtnLibrary = New CloudToolkitN6.CloudDesktopButton()
        Me.tmrFancyStuff = New System.Windows.Forms.Timer(Me.components)
        Me.Strip2.SuspendLayout()
        Me.Strip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PnlDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Strip2
        '
        Me.Strip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Strip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Strip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Strip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator11, Me.ToolStripLabel3, Me.ToolStripSeparator9, Me.ToolStripLabel4, Me.ToolStripSeparator10, Me.ToolRole, Me.ToolStripSeparator1, Me.ToolUname})
        Me.Strip2.Location = New System.Drawing.Point(0, 0)
        Me.Strip2.Name = "Strip2"
        Me.Strip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Strip2.Size = New System.Drawing.Size(721, 25)
        Me.Strip2.TabIndex = 6
        Me.Strip2.Text = "ToolStrip2"
        Me.Strip2.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripLabel1.Text = "My Application 2014"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Image = CType(resources.GetObject("ToolStripLabel3.Image"), System.Drawing.Image)
        Me.ToolStripLabel3.LinkColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel3.Text = "  ToolStripLabel3"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Image = CType(resources.GetObject("ToolStripLabel4.Image"), System.Drawing.Image)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel4.Text = "  ToolStripLabel4"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolRole
        '
        Me.ToolRole.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolRole.ForeColor = System.Drawing.Color.White
        Me.ToolRole.Name = "ToolRole"
        Me.ToolRole.Size = New System.Drawing.Size(98, 22)
        Me.ToolRole.Text = "  Not Logged In"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolUname
        '
        Me.ToolUname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolUname.ForeColor = System.Drawing.Color.White
        Me.ToolUname.Image = CType(resources.GetObject("ToolUname.Image"), System.Drawing.Image)
        Me.ToolUname.Name = "ToolUname"
        Me.ToolUname.Size = New System.Drawing.Size(118, 22)
        Me.ToolUname.Text = "  Not Logged In"
        '
        'Strip1
        '
        Me.Strip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Strip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Strip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Strip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.Strip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolApp, Me.ToolHide, Me.ToolLogout, Me.ToolShutdown})
        Me.Strip1.Location = New System.Drawing.Point(0, 0)
        Me.Strip1.Name = "Strip1"
        Me.Strip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Strip1.Size = New System.Drawing.Size(55, 426)
        Me.Strip1.TabIndex = 7
        Me.Strip1.Text = "ToolStrip1"
        Me.Strip1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRestore, Me.BtnMinimize, Me.ToolStripSeparator2, Me.BtnClose})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 76)
        '
        'BtnRestore
        '
        Me.BtnRestore.ForeColor = System.Drawing.Color.White
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(123, 22)
        Me.BtnRestore.Text = "Restore"
        '
        'BtnMinimize
        '
        Me.BtnMinimize.ForeColor = System.Drawing.Color.White
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(123, 22)
        Me.BtnMinimize.Text = "Minimize"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
        '
        'BtnClose
        '
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(123, 22)
        Me.BtnClose.Text = "Close"
        '
        'ToolApp
        '
        Me.ToolApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolApp.Image = CType(resources.GetObject("ToolApp.Image"), System.Drawing.Image)
        Me.ToolApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolApp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolApp.Name = "ToolApp"
        Me.ToolApp.Size = New System.Drawing.Size(52, 52)
        Me.ToolApp.Text = "Library System"
        Me.ToolApp.Visible = False
        '
        'ToolHide
        '
        Me.ToolHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolHide.Image = CType(resources.GetObject("ToolHide.Image"), System.Drawing.Image)
        Me.ToolHide.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolHide.Name = "ToolHide"
        Me.ToolHide.Size = New System.Drawing.Size(52, 54)
        Me.ToolHide.Text = "Hide"
        Me.ToolHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolHide.ToolTipText = "Hide to Notification Bar"
        '
        'ToolLogout
        '
        Me.ToolLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolLogout.Image = CType(resources.GetObject("ToolLogout.Image"), System.Drawing.Image)
        Me.ToolLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolLogout.Name = "ToolLogout"
        Me.ToolLogout.Size = New System.Drawing.Size(52, 54)
        Me.ToolLogout.Tag = ""
        Me.ToolLogout.Text = "Log Out"
        '
        'ToolShutdown
        '
        Me.ToolShutdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolShutdown.Image = CType(resources.GetObject("ToolShutdown.Image"), System.Drawing.Image)
        Me.ToolShutdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolShutdown.Name = "ToolShutdown"
        Me.ToolShutdown.Size = New System.Drawing.Size(52, 54)
        Me.ToolShutdown.Tag = ""
        Me.ToolShutdown.Text = "Exit"
        '
        'notif
        '
        Me.notif.BalloonTipText = "My Application is currently running!"
        Me.notif.Icon = CType(resources.GetObject("notif.Icon"), System.Drawing.Icon)
        Me.notif.Text = "My Application is currently running!"
        Me.notif.Visible = True
        '
        'PnlDesktop
        '
        Me.PnlDesktop.BackgroundImage = Global.Login.My.Resources.Resources.Main_BG
        Me.PnlDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlDesktop.Controls.Add(Me.BtnLibrary)
        Me.PnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PnlDesktop.Name = "PnlDesktop"
        Me.PnlDesktop.Size = New System.Drawing.Size(721, 426)
        Me.PnlDesktop.TabIndex = 9
        Me.PnlDesktop.Visible = False
        '
        'BtnLibrary
        '
        Me.BtnLibrary.AnimationSpeed = 5
        Me.BtnLibrary.BackColor = System.Drawing.Color.Transparent
        Me.BtnLibrary.BackgroundOpacity = 100
        Me.BtnLibrary.BackgroundOpacity_MouseDown = 170
        Me.BtnLibrary.BorderColor = System.Drawing.Color.White
        Me.BtnLibrary.BorderOpacity = 170
        Me.BtnLibrary.BorderWidth = 1
        Me.BtnLibrary.ControlText = "Library"
        Me.BtnLibrary.CornerRadius = 1
        Me.BtnLibrary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLibrary.DrawBlackTextBackground = True
        Me.BtnLibrary.FillColor = System.Drawing.Color.Azure
        Me.BtnLibrary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLibrary.ForeColor = System.Drawing.Color.White
        Me.BtnLibrary.Icon = CType(resources.GetObject("BtnLibrary.Icon"), System.Drawing.Bitmap)
        Me.BtnLibrary.Location = New System.Drawing.Point(72, 41)
        Me.BtnLibrary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLibrary.Name = "BtnLibrary"
        Me.BtnLibrary.Size = New System.Drawing.Size(52, 61)
        Me.BtnLibrary.TabIndex = 2
        '
        'tmrFancyStuff
        '
        Me.tmrFancyStuff.Interval = 15
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Login.My.Resources.Resources.Main_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 426)
        Me.Controls.Add(Me.PnlDesktop)
        Me.Controls.Add(Me.Strip2)
        Me.Controls.Add(Me.Strip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main - Library Management System"
        Me.Strip2.ResumeLayout(False)
        Me.Strip2.PerformLayout()
        Me.Strip1.ResumeLayout(False)
        Me.Strip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PnlDesktop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Strip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolRole As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Strip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolHide As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolShutdown As System.Windows.Forms.ToolStripButton
    Friend WithEvents hidenotif As System.Windows.Forms.NotifyIcon
    Friend WithEvents notif As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolUname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PnlDesktop As System.Windows.Forms.Panel
    Friend WithEvents BtnLibrary As CloudToolkitN6.CloudDesktopButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnMinimize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolApp As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrFancyStuff As System.Windows.Forms.Timer
    Friend WithEvents ToolLogout As System.Windows.Forms.ToolStripButton
End Class
