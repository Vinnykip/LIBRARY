<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscBookDtl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscBookDtl))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCatRefresh = New System.Windows.Forms.Button()
        Me.linkCategory = New System.Windows.Forms.LinkLabel()
        Me.lnVenor = New System.Windows.Forms.LinkLabel()
        Me.linkAuthor = New System.Windows.Forms.LinkLabel()
        Me.btnVendRefresh = New System.Windows.Forms.Button()
        Me.btnAuthSearch = New System.Windows.Forms.Button()
        Me.cboVendor = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpPubDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(175, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 41)
        Me.btnDelete.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete Book")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(112, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 41)
        Me.btnSave.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Book")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(49, 200)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(57, 41)
        Me.btnNew.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.btnNew, "New Book")
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCatRefresh)
        Me.Panel1.Controls.Add(Me.linkCategory)
        Me.Panel1.Controls.Add(Me.lnVenor)
        Me.Panel1.Controls.Add(Me.linkAuthor)
        Me.Panel1.Controls.Add(Me.btnVendRefresh)
        Me.Panel1.Controls.Add(Me.btnAuthSearch)
        Me.Panel1.Controls.Add(Me.cboVendor)
        Me.Panel1.Controls.Add(Me.cboCategory)
        Me.Panel1.Controls.Add(Me.txtAuthor)
        Me.Panel1.Controls.Add(Me.txtPages)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtISBN)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpPubDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBookID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 174)
        Me.Panel1.TabIndex = 42
        '
        'btnCatRefresh
        '
        Me.btnCatRefresh.FlatAppearance.BorderSize = 0
        Me.btnCatRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatRefresh.Image = CType(resources.GetObject("btnCatRefresh.Image"), System.Drawing.Image)
        Me.btnCatRefresh.Location = New System.Drawing.Point(222, 44)
        Me.btnCatRefresh.Name = "btnCatRefresh"
        Me.btnCatRefresh.Size = New System.Drawing.Size(19, 21)
        Me.btnCatRefresh.TabIndex = 58
        Me.btnCatRefresh.UseVisualStyleBackColor = True
        '
        'linkCategory
        '
        Me.linkCategory.AutoSize = True
        Me.linkCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkCategory.ForeColor = System.Drawing.Color.White
        Me.linkCategory.LinkColor = System.Drawing.Color.White
        Me.linkCategory.Location = New System.Drawing.Point(0, 48)
        Me.linkCategory.Name = "linkCategory"
        Me.linkCategory.Size = New System.Drawing.Size(53, 13)
        Me.linkCategory.TabIndex = 57
        Me.linkCategory.TabStop = True
        Me.linkCategory.Text = "Category"
        '
        'lnVenor
        '
        Me.lnVenor.AutoSize = True
        Me.lnVenor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnVenor.ForeColor = System.Drawing.Color.White
        Me.lnVenor.LinkColor = System.Drawing.Color.White
        Me.lnVenor.Location = New System.Drawing.Point(0, 153)
        Me.lnVenor.Name = "lnVenor"
        Me.lnVenor.Size = New System.Drawing.Size(45, 13)
        Me.lnVenor.TabIndex = 56
        Me.lnVenor.TabStop = True
        Me.lnVenor.Text = "Vendor"
        '
        'linkAuthor
        '
        Me.linkAuthor.AutoSize = True
        Me.linkAuthor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkAuthor.ForeColor = System.Drawing.Color.White
        Me.linkAuthor.LinkColor = System.Drawing.Color.White
        Me.linkAuthor.Location = New System.Drawing.Point(0, 131)
        Me.linkAuthor.Name = "linkAuthor"
        Me.linkAuthor.Size = New System.Drawing.Size(43, 13)
        Me.linkAuthor.TabIndex = 55
        Me.linkAuthor.TabStop = True
        Me.linkAuthor.Text = "Author"
        '
        'btnVendRefresh
        '
        Me.btnVendRefresh.FlatAppearance.BorderSize = 0
        Me.btnVendRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendRefresh.Image = CType(resources.GetObject("btnVendRefresh.Image"), System.Drawing.Image)
        Me.btnVendRefresh.Location = New System.Drawing.Point(222, 150)
        Me.btnVendRefresh.Name = "btnVendRefresh"
        Me.btnVendRefresh.Size = New System.Drawing.Size(23, 21)
        Me.btnVendRefresh.TabIndex = 54
        Me.btnVendRefresh.UseVisualStyleBackColor = True
        '
        'btnAuthSearch
        '
        Me.btnAuthSearch.FlatAppearance.BorderSize = 0
        Me.btnAuthSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuthSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuthSearch.Image = CType(resources.GetObject("btnAuthSearch.Image"), System.Drawing.Image)
        Me.btnAuthSearch.Location = New System.Drawing.Point(218, 127)
        Me.btnAuthSearch.Name = "btnAuthSearch"
        Me.btnAuthSearch.Size = New System.Drawing.Size(31, 21)
        Me.btnAuthSearch.TabIndex = 53
        Me.btnAuthSearch.UseVisualStyleBackColor = True
        '
        'cboVendor
        '
        Me.cboVendor.BackColor = System.Drawing.Color.Black
        Me.cboVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVendor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVendor.ForeColor = System.Drawing.Color.DarkGray
        Me.cboVendor.FormattingEnabled = True
        Me.cboVendor.Location = New System.Drawing.Point(62, 150)
        Me.cboVendor.Name = "cboVendor"
        Me.cboVendor.Size = New System.Drawing.Size(158, 21)
        Me.cboVendor.TabIndex = 51
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.Black
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.ForeColor = System.Drawing.Color.DarkGray
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(62, 44)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(158, 21)
        Me.cboCategory.TabIndex = 50
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.Black
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAuthor.Location = New System.Drawing.Point(61, 129)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.Size = New System.Drawing.Size(159, 22)
        Me.txtAuthor.TabIndex = 49
        '
        'txtPages
        '
        Me.txtPages.BackColor = System.Drawing.Color.Black
        Me.txtPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPages.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPages.Location = New System.Drawing.Point(61, 108)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.Size = New System.Drawing.Size(41, 22)
        Me.txtPages.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Pages"
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Black
        Me.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.ForeColor = System.Drawing.Color.DarkGray
        Me.txtISBN.Location = New System.Drawing.Point(61, 87)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(178, 22)
        Me.txtISBN.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "ISBN No."
        '
        'dtpPubDate
        '
        Me.dtpPubDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpPubDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.dtpPubDate.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.dtpPubDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpPubDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpPubDate.CustomFormat = " "
        Me.dtpPubDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPubDate.Location = New System.Drawing.Point(62, 65)
        Me.dtpPubDate.Name = "dtpPubDate"
        Me.dtpPubDate.Size = New System.Drawing.Size(100, 22)
        Me.dtpPubDate.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Publish Date"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Black
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.txtTitle.Location = New System.Drawing.Point(61, 23)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(178, 22)
        Me.txtTitle.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Title"
        '
        'txtBookID
        '
        Me.txtBookID.BackColor = System.Drawing.Color.Black
        Me.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBookID.Location = New System.Drawing.Point(61, 2)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(57, 22)
        Me.txtBookID.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "BOOK FORM"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uscBookDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "uscBookDtl"
        Me.Size = New System.Drawing.Size(269, 242)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lnVenor As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAuthor As System.Windows.Forms.LinkLabel
    Friend WithEvents btnVendRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAuthSearch As System.Windows.Forms.Button
    Friend WithEvents cboVendor As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtPages As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpPubDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents linkCategory As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCatRefresh As System.Windows.Forms.Button

End Class
