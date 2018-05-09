<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.CloudHeader3 = New CloudToolkitN6.CloudHeader()
        Me.txttitle = New CloudToolkitN6.CloudHeader()
        Me.Btnmin = New System.Windows.Forms.PictureBox()
        Me.Btnclose = New System.Windows.Forms.PictureBox()
        Me.txtloginoptions = New System.Windows.Forms.TextBox()
        Me.loginimage = New System.Windows.Forms.PictureBox()
        Me.Txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.BtnCancel = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.LnkNew = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toollogin = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloudHeader3
        '
        Me.CloudHeader3.BackColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloudHeader3.BorderColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BorderWidth = 1.0!
        Me.CloudHeader3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloudHeader3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloudHeader3.FillColor1 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CloudHeader3.FillColor2_2 = System.Drawing.Color.Gray
        Me.CloudHeader3.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader3.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader3.ForeColor = System.Drawing.Color.White
        Me.CloudHeader3.HeaderText = "Only authorized users are allowed to login"
        Me.CloudHeader3.Icon = Nothing
        Me.CloudHeader3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader3.IconPadding = 5
        Me.CloudHeader3.ImageHeader = False
        Me.CloudHeader3.Location = New System.Drawing.Point(0, 173)
        Me.CloudHeader3.Name = "CloudHeader3"
        Me.CloudHeader3.Size = New System.Drawing.Size(355, 27)
        Me.CloudHeader3.TabIndex = 10
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.Transparent
        Me.txttitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txttitle.BorderColor = System.Drawing.Color.Transparent
        Me.txttitle.BorderWidth = 1.0!
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txttitle.FillColor1 = System.Drawing.Color.Gray
        Me.txttitle.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttitle.FillColor2_1 = System.Drawing.Color.Black
        Me.txttitle.FillColor2_2 = System.Drawing.Color.Black
        Me.txttitle.FontColorMouseOn = System.Drawing.Color.White
        Me.txttitle.FontColorNormal = System.Drawing.Color.White
        Me.txttitle.ForeColor = System.Drawing.Color.White
        Me.txttitle.HeaderText = "Login"
        Me.txttitle.Icon = Nothing
        Me.txttitle.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.txttitle.IconPadding = 5
        Me.txttitle.ImageHeader = False
        Me.txttitle.Location = New System.Drawing.Point(0, 0)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(355, 27)
        Me.txttitle.TabIndex = 9
        '
        'Btnmin
        '
        Me.Btnmin.BackColor = System.Drawing.Color.Black
        Me.Btnmin.BackgroundImage = Global.Login.My.Resources.Resources.min
        Me.Btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnmin.Location = New System.Drawing.Point(303, -1)
        Me.Btnmin.Name = "Btnmin"
        Me.Btnmin.Size = New System.Drawing.Size(25, 25)
        Me.Btnmin.TabIndex = 14
        Me.Btnmin.TabStop = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.Black
        Me.Btnclose.BackgroundImage = Global.Login.My.Resources.Resources.close
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnclose.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnclose.Location = New System.Drawing.Point(328, -1)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(25, 25)
        Me.Btnclose.TabIndex = 13
        Me.Btnclose.TabStop = False
        '
        'txtloginoptions
        '
        Me.txtloginoptions.Location = New System.Drawing.Point(337, 112)
        Me.txtloginoptions.Name = "txtloginoptions"
        Me.txtloginoptions.Size = New System.Drawing.Size(10, 19)
        Me.txtloginoptions.TabIndex = 15
        Me.txtloginoptions.Visible = False
        '
        'loginimage
        '
        Me.loginimage.BackColor = System.Drawing.Color.Transparent
        Me.loginimage.Location = New System.Drawing.Point(7, 52)
        Me.loginimage.Name = "loginimage"
        Me.loginimage.Size = New System.Drawing.Size(130, 113)
        Me.loginimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginimage.TabIndex = 16
        Me.loginimage.TabStop = False
        '
        'Txtuser
        '
        Me.Txtuser.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Txtuser.Location = New System.Drawing.Point(204, 63)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(143, 20)
        Me.Txtuser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(138, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Username"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(142, 86)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 13)
        Me.label3.TabIndex = 64
        Me.label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(126, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Account no."
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtpass.Location = New System.Drawing.Point(204, 86)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(143, 20)
        Me.txtpass.TabIndex = 3
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(204, 40)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(143, 20)
        Me.txtuserid.TabIndex = 1
        '
        'BtnLogin
        '
        Me.BtnLogin.AnimationOpacityChange = 0.1R
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLogin.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnLogin.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnLogin.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BtnLogin.ControlOpacity = 255
        Me.BtnLogin.CornerRadius = 1
        Me.BtnLogin.DrawHoverOverIcon = False
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.GlowColor = System.Drawing.Color.BlueViolet
        Me.BtnLogin.Icon = Nothing
        Me.BtnLogin.IsAnimated = True
        Me.BtnLogin.Location = New System.Drawing.Point(204, 139)
        Me.BtnLogin.MaximumGlowOpacity = 0.8R
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BtnLogin.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnLogin.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnLogin.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BtnLogin.Size = New System.Drawing.Size(75, 29)
        Me.BtnLogin.StartMenuIndex = 0
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.TextCentered = True
        Me.BtnLogin.TextDistanceFromBorder = 5
        Me.BtnLogin.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'BtnCancel
        '
        Me.BtnCancel.AnimationOpacityChange = 0.1R
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.ButtonText = "Cancel"
        Me.BtnCancel.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnCancel.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnCancel.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnCancel.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BtnCancel.ControlOpacity = 255
        Me.BtnCancel.CornerRadius = 1
        Me.BtnCancel.DrawHoverOverIcon = False
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.GlowColor = System.Drawing.Color.BlueViolet
        Me.BtnCancel.Icon = Nothing
        Me.BtnCancel.IsAnimated = True
        Me.BtnCancel.Location = New System.Drawing.Point(280, 139)
        Me.BtnCancel.MaximumGlowOpacity = 0.8R
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BtnCancel.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnCancel.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnCancel.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BtnCancel.Size = New System.Drawing.Size(67, 29)
        Me.BtnCancel.StartMenuIndex = 0
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.TextCentered = True
        Me.BtnCancel.TextDistanceFromBorder = 5
        Me.BtnCancel.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'LnkNew
        '
        Me.LnkNew.AutoSize = True
        Me.LnkNew.BackColor = System.Drawing.Color.Transparent
        Me.LnkNew.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkNew.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LnkNew.LinkColor = System.Drawing.Color.White
        Me.LnkNew.Location = New System.Drawing.Point(201, 110)
        Me.LnkNew.Name = "LnkNew"
        Me.LnkNew.Size = New System.Drawing.Size(116, 15)
        Me.LnkNew.TabIndex = 67
        Me.LnkNew.TabStop = True
        Me.LnkNew.Text = "Create New Account"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toollogin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(355, 24)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'toollogin
        '
        Me.toollogin.Name = "toollogin"
        Me.toollogin.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.toollogin.Size = New System.Drawing.Size(128, 20)
        Me.toollogin.Text = "ToolStripMenuItem1"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Login.My.Resources.Resources.BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(355, 200)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LnkNew)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtuser)
        Me.Controls.Add(Me.loginimage)
        Me.Controls.Add(Me.txtloginoptions)
        Me.Controls.Add(Me.Btnmin)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.CloudHeader3)
        Me.Controls.Add(Me.txttitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logn"
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloudHeader3 As CloudToolkitN6.CloudHeader
    Friend WithEvents txttitle As CloudToolkitN6.CloudHeader
    Friend WithEvents Btnmin As System.Windows.Forms.PictureBox
    Friend WithEvents Btnclose As System.Windows.Forms.PictureBox
    Friend WithEvents txtloginoptions As System.Windows.Forms.TextBox
    Friend WithEvents loginimage As System.Windows.Forms.PictureBox
    Friend WithEvents Txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents BtnCancel As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents LnkNew As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toollogin As System.Windows.Forms.ToolStripMenuItem
End Class
