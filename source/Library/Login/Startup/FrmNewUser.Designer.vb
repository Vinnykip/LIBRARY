<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewUser))
        Me.CloudHeader3 = New CloudToolkitN6.CloudHeader()
        Me.CloudHeader1 = New CloudToolkitN6.CloudHeader()
        Me.Btnmin = New System.Windows.Forms.PictureBox()
        Me.Btnclose = New System.Windows.Forms.PictureBox()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Btnrefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.myimage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtConformPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Btncreate = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.BtnCancel = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.Btnbrowse = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.BtnReset = New CloudToolkitN6.Windows.Vista.CloudStartMenuButton()
        Me.txtaaccntno = New System.Windows.Forms.MaskedTextBox()
        Me.listUser = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.myimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.CloudHeader3.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CloudHeader3.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader3.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader3.ForeColor = System.Drawing.Color.White
        Me.CloudHeader3.HeaderText = "Number of User Accounts"
        Me.CloudHeader3.Icon = Nothing
        Me.CloudHeader3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader3.IconPadding = 5
        Me.CloudHeader3.ImageHeader = False
        Me.CloudHeader3.Location = New System.Drawing.Point(0, 265)
        Me.CloudHeader3.Name = "CloudHeader3"
        Me.CloudHeader3.Size = New System.Drawing.Size(522, 27)
        Me.CloudHeader3.TabIndex = 16
        '
        'CloudHeader1
        '
        Me.CloudHeader1.BackColor = System.Drawing.Color.Transparent
        Me.CloudHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloudHeader1.BorderColor = System.Drawing.Color.Transparent
        Me.CloudHeader1.BorderWidth = 1.0!
        Me.CloudHeader1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloudHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CloudHeader1.FillColor1 = System.Drawing.Color.Gray
        Me.CloudHeader1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CloudHeader1.FillColor2_1 = System.Drawing.Color.Black
        Me.CloudHeader1.FillColor2_2 = System.Drawing.Color.Black
        Me.CloudHeader1.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader1.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader1.ForeColor = System.Drawing.Color.White
        Me.CloudHeader1.HeaderText = "Create New User Account"
        Me.CloudHeader1.Icon = Nothing
        Me.CloudHeader1.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader1.IconPadding = 5
        Me.CloudHeader1.ImageHeader = False
        Me.CloudHeader1.Location = New System.Drawing.Point(0, 0)
        Me.CloudHeader1.Name = "CloudHeader1"
        Me.CloudHeader1.Size = New System.Drawing.Size(522, 27)
        Me.CloudHeader1.TabIndex = 15
        '
        'Btnmin
        '
        Me.Btnmin.BackColor = System.Drawing.Color.Black
        Me.Btnmin.BackgroundImage = Global.Login.My.Resources.Resources.min
        Me.Btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnmin.Location = New System.Drawing.Point(470, -1)
        Me.Btnmin.Name = "Btnmin"
        Me.Btnmin.Size = New System.Drawing.Size(25, 25)
        Me.Btnmin.TabIndex = 20
        Me.Btnmin.TabStop = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.Black
        Me.Btnclose.BackgroundImage = Global.Login.My.Resources.Resources.close
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnclose.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnclose.Location = New System.Drawing.Point(495, -1)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(25, 25)
        Me.Btnclose.TabIndex = 19
        Me.Btnclose.TabStop = False
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btnrefresh, Me.BtnEdit, Me.BtnDelete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 70)
        '
        'Btnrefresh
        '
        Me.Btnrefresh.ForeColor = System.Drawing.Color.White
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(113, 22)
        Me.Btnrefresh.Text = "Refresh"
        '
        'BtnEdit
        '
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(113, 22)
        Me.BtnEdit.Text = "Edit"
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(113, 22)
        Me.BtnDelete.Text = "Delete"
        '
        'myimage
        '
        Me.myimage.BackColor = System.Drawing.Color.Transparent
        Me.myimage.Image = Global.Login.My.Resources.Resources.defaultimg
        Me.myimage.Location = New System.Drawing.Point(406, 14)
        Me.myimage.Name = "myimage"
        Me.myimage.Size = New System.Drawing.Size(88, 87)
        Me.myimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.myimage.TabIndex = 149
        Me.myimage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(161, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Account No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(192, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Name :"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(246, 58)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(155, 23)
        Me.txtname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(171, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Username :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(174, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(151, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Conform Pass :"
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(246, 112)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(155, 23)
        Me.txtuname.TabIndex = 5
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(246, 139)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(155, 23)
        Me.txtpassword.TabIndex = 6
        '
        'txtConformPass
        '
        Me.txtConformPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConformPass.Location = New System.Drawing.Point(246, 166)
        Me.txtConformPass.Name = "txtConformPass"
        Me.txtConformPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConformPass.Size = New System.Drawing.Size(155, 23)
        Me.txtConformPass.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(195, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Email :"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(246, 85)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(155, 23)
        Me.txtemail.TabIndex = 4
        '
        'Btncreate
        '
        Me.Btncreate.AnimationOpacityChange = 0.1R
        Me.Btncreate.BackColor = System.Drawing.Color.Transparent
        Me.Btncreate.ButtonText = "Create"
        Me.Btncreate.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btncreate.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Btncreate.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Btncreate.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Btncreate.ControlOpacity = 255
        Me.Btncreate.CornerRadius = 1
        Me.Btncreate.DrawHoverOverIcon = False
        Me.Btncreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncreate.ForeColor = System.Drawing.Color.White
        Me.Btncreate.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Btncreate.Icon = Nothing
        Me.Btncreate.IsAnimated = True
        Me.Btncreate.Location = New System.Drawing.Point(411, 131)
        Me.Btncreate.MaximumGlowOpacity = 0.8R
        Me.Btncreate.Name = "Btncreate"
        Me.Btncreate.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Btncreate.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Btncreate.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Btncreate.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Btncreate.Size = New System.Drawing.Size(83, 29)
        Me.Btncreate.StartMenuIndex = 0
        Me.Btncreate.TabIndex = 147
        Me.Btncreate.TextCentered = True
        Me.Btncreate.TextDistanceFromBorder = 5
        Me.Btncreate.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
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
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnCancel.Icon = Nothing
        Me.BtnCancel.IsAnimated = True
        Me.BtnCancel.Location = New System.Drawing.Point(411, 190)
        Me.BtnCancel.MaximumGlowOpacity = 0.8R
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BtnCancel.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnCancel.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnCancel.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BtnCancel.Size = New System.Drawing.Size(83, 29)
        Me.BtnCancel.StartMenuIndex = 0
        Me.BtnCancel.TabIndex = 148
        Me.BtnCancel.TextCentered = True
        Me.BtnCancel.TextDistanceFromBorder = 5
        Me.BtnCancel.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'Btnbrowse
        '
        Me.Btnbrowse.AnimationOpacityChange = 0.1R
        Me.Btnbrowse.BackColor = System.Drawing.Color.Transparent
        Me.Btnbrowse.ButtonText = "Browse"
        Me.Btnbrowse.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btnbrowse.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Btnbrowse.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Btnbrowse.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Btnbrowse.ControlOpacity = 255
        Me.Btnbrowse.CornerRadius = 1
        Me.Btnbrowse.DrawHoverOverIcon = False
        Me.Btnbrowse.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Btnbrowse.ForeColor = System.Drawing.Color.White
        Me.Btnbrowse.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Btnbrowse.Icon = Nothing
        Me.Btnbrowse.IsAnimated = True
        Me.Btnbrowse.Location = New System.Drawing.Point(411, 102)
        Me.Btnbrowse.MaximumGlowOpacity = 0.8R
        Me.Btnbrowse.Name = "Btnbrowse"
        Me.Btnbrowse.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Btnbrowse.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Btnbrowse.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Btnbrowse.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Btnbrowse.Size = New System.Drawing.Size(83, 29)
        Me.Btnbrowse.StartMenuIndex = 0
        Me.Btnbrowse.TabIndex = 150
        Me.Btnbrowse.TextCentered = True
        Me.Btnbrowse.TextDistanceFromBorder = 5
        Me.Btnbrowse.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'BtnReset
        '
        Me.BtnReset.AnimationOpacityChange = 0.1R
        Me.BtnReset.BackColor = System.Drawing.Color.Transparent
        Me.BtnReset.ButtonText = "Clear"
        Me.BtnReset.ClickedColors_1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnReset.ClickedColors_2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnReset.ClickedColors_3 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnReset.ClickedColors_4 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BtnReset.ControlOpacity = 255
        Me.BtnReset.CornerRadius = 1
        Me.BtnReset.DrawHoverOverIcon = False
        Me.BtnReset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.GlowColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnReset.Icon = Nothing
        Me.BtnReset.IsAnimated = True
        Me.BtnReset.Location = New System.Drawing.Point(411, 160)
        Me.BtnReset.MaximumGlowOpacity = 0.8R
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.NormalColors_1 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BtnReset.NormalColors_2 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnReset.NormalColors_3 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnReset.NormalColors_4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BtnReset.Size = New System.Drawing.Size(83, 29)
        Me.BtnReset.StartMenuIndex = 0
        Me.BtnReset.TabIndex = 152
        Me.BtnReset.TextCentered = True
        Me.BtnReset.TextDistanceFromBorder = 5
        Me.BtnReset.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon
        '
        'txtaaccntno
        '
        Me.txtaaccntno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaaccntno.Location = New System.Drawing.Point(246, 31)
        Me.txtaaccntno.Mask = "00-0000"
        Me.txtaaccntno.Name = "txtaaccntno"
        Me.txtaaccntno.Size = New System.Drawing.Size(155, 23)
        Me.txtaaccntno.TabIndex = 2
        '
        'listUser
        '
        Me.listUser.ContextMenuStrip = Me.ContextMenuStrip1
        Me.listUser.FormattingEnabled = True
        Me.listUser.ItemHeight = 17
        Me.listUser.Location = New System.Drawing.Point(10, 21)
        Me.listUser.Name = "listUser"
        Me.listUser.Size = New System.Drawing.Size(134, 191)
        Me.listUser.TabIndex = 155
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.listUser)
        Me.GroupBox2.Controls.Add(Me.txtaaccntno)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.Btnbrowse)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.Btncreate)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtConformPass)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.txtuname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.myimage)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 225)
        Me.GroupBox2.TabIndex = 134
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Accounts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(262, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 15)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Right Click on the list to edit or delete accounts"
        '
        'FrmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 292)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btnmin)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.CloudHeader3)
        Me.Controls.Add(Me.CloudHeader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New User Account"
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.myimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnmin As System.Windows.Forms.PictureBox
    Friend WithEvents Btnclose As System.Windows.Forms.PictureBox
    Friend WithEvents CloudHeader3 As CloudToolkitN6.CloudHeader
    Friend WithEvents CloudHeader1 As CloudToolkitN6.CloudHeader
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btnrefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myimage As System.Windows.Forms.PictureBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtname As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtuname As System.Windows.Forms.TextBox
    Private WithEvents txtpassword As System.Windows.Forms.TextBox
    Private WithEvents txtConformPass As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Btncreate As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents BtnCancel As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents Btnbrowse As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents BtnReset As CloudToolkitN6.Windows.Vista.CloudStartMenuButton
    Friend WithEvents txtaaccntno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents listUser As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
