<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscBarrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscBarrow))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBrwSearch = New System.Windows.Forms.Button()
        Me.btnBookSearch = New System.Windows.Forms.Button()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBarrowDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBarrower = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBrowNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReturn.Enabled = False
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReturn.FlatAppearance.BorderSize = 2
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Image = CType(resources.GetObject("btnReturn.Image"), System.Drawing.Image)
        Me.btnReturn.Location = New System.Drawing.Point(200, 178)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(57, 41)
        Me.btnReturn.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return Book Borrowed")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(137, 178)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 41)
        Me.btnDelete.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete Borrow")
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(74, 178)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 41)
        Me.btnSave.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Borrow")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(11, 178)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(57, 41)
        Me.btnNew.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.btnNew, "New Borrow")
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "BORROWED BOOK FORM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBrwSearch)
        Me.Panel1.Controls.Add(Me.btnBookSearch)
        Me.Panel1.Controls.Add(Me.dtpDueDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpBarrowDate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtBarrower)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBook)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBrowNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 150)
        Me.Panel1.TabIndex = 60
        '
        'btnBrwSearch
        '
        Me.btnBrwSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBrwSearch.FlatAppearance.BorderSize = 0
        Me.btnBrwSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrwSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrwSearch.Image = CType(resources.GetObject("btnBrwSearch.Image"), System.Drawing.Image)
        Me.btnBrwSearch.Location = New System.Drawing.Point(212, 64)
        Me.btnBrwSearch.Name = "btnBrwSearch"
        Me.btnBrwSearch.Size = New System.Drawing.Size(31, 21)
        Me.btnBrwSearch.TabIndex = 93
        Me.btnBrwSearch.UseVisualStyleBackColor = True
        '
        'btnBookSearch
        '
        Me.btnBookSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBookSearch.FlatAppearance.BorderSize = 0
        Me.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookSearch.Image = CType(resources.GetObject("btnBookSearch.Image"), System.Drawing.Image)
        Me.btnBookSearch.Location = New System.Drawing.Point(212, 40)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(31, 21)
        Me.btnBookSearch.TabIndex = 92
        Me.btnBookSearch.UseVisualStyleBackColor = True
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.dtpDueDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpDueDate.CustomFormat = " "
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(68, 110)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpDueDate.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Due Date"
        '
        'dtpBarrowDate
        '
        Me.dtpBarrowDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpBarrowDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.dtpBarrowDate.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.dtpBarrowDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpBarrowDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtpBarrowDate.CustomFormat = " "
        Me.dtpBarrowDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBarrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBarrowDate.Location = New System.Drawing.Point(68, 87)
        Me.dtpBarrowDate.Name = "dtpBarrowDate"
        Me.dtpBarrowDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpBarrowDate.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Borrow Date"
        '
        'txtBarrower
        '
        Me.txtBarrower.BackColor = System.Drawing.Color.Black
        Me.txtBarrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarrower.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrower.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBarrower.Location = New System.Drawing.Point(68, 64)
        Me.txtBarrower.Name = "txtBarrower"
        Me.txtBarrower.ReadOnly = True
        Me.txtBarrower.Size = New System.Drawing.Size(143, 23)
        Me.txtBarrower.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Barrower"
        '
        'txtBook
        '
        Me.txtBook.BackColor = System.Drawing.Color.Black
        Me.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBook.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBook.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBook.Location = New System.Drawing.Point(68, 41)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.ReadOnly = True
        Me.txtBook.Size = New System.Drawing.Size(143, 23)
        Me.txtBook.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Book Title"
        '
        'txtBrowNo
        '
        Me.txtBrowNo.BackColor = System.Drawing.Color.Black
        Me.txtBrowNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrowNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrowNo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBrowNo.Location = New System.Drawing.Point(68, 18)
        Me.txtBrowNo.Name = "txtBrowNo"
        Me.txtBrowNo.ReadOnly = True
        Me.txtBrowNo.Size = New System.Drawing.Size(61, 23)
        Me.txtBrowNo.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "BORROWED BOOK FORM"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uscBarrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "uscBarrow"
        Me.Size = New System.Drawing.Size(269, 242)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBrwSearch As System.Windows.Forms.Button
    Friend WithEvents btnBookSearch As System.Windows.Forms.Button
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpBarrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBarrower As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBrowNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
