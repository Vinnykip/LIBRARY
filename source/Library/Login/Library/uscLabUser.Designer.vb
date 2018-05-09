<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscLabUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscLabUser))
        Me.txtMemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpEntryTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBaggageNo = New System.Windows.Forms.TextBox()
        Me.chkPrint = New System.Windows.Forms.CheckBox()
        Me.txtPrint = New System.Windows.Forms.TextBox()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.chkScan = New System.Windows.Forms.CheckBox()
        Me.txtPhotocopy = New System.Windows.Forms.TextBox()
        Me.chkCopy = New System.Windows.Forms.CheckBox()
        Me.txtInternet = New System.Windows.Forms.TextBox()
        Me.chkIntFee = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpExitTime = New System.Windows.Forms.DateTimePicker()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBookSearch = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtMemName
        '
        Me.txtMemName.BackColor = System.Drawing.Color.Black
        Me.txtMemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMemName.Location = New System.Drawing.Point(113, 45)
        Me.txtMemName.Name = "txtMemName"
        Me.txtMemName.ReadOnly = True
        Me.txtMemName.Size = New System.Drawing.Size(112, 23)
        Me.txtMemName.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Member Name"
        '
        'txtLogID
        '
        Me.txtLogID.BackColor = System.Drawing.Color.Black
        Me.txtLogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogID.ForeColor = System.Drawing.Color.DarkGray
        Me.txtLogID.Location = New System.Drawing.Point(113, 27)
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.ReadOnly = True
        Me.txtLogID.Size = New System.Drawing.Size(61, 23)
        Me.txtLogID.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Log No."
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.CustomFormat = " "
        Me.dtpEntryDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntryDate.Location = New System.Drawing.Point(113, 66)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.Size = New System.Drawing.Size(112, 23)
        Me.dtpEntryDate.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Entry Date"
        '
        'dtpEntryTime
        '
        Me.dtpEntryTime.CustomFormat = " "
        Me.dtpEntryTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntryTime.Location = New System.Drawing.Point(113, 85)
        Me.dtpEntryTime.Name = "dtpEntryTime"
        Me.dtpEntryTime.ShowUpDown = True
        Me.dtpEntryTime.Size = New System.Drawing.Size(112, 23)
        Me.dtpEntryTime.TabIndex = 64
        Me.dtpEntryTime.Tag = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Entry Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Computer No."
        '
        'txtCompNo
        '
        Me.txtCompNo.BackColor = System.Drawing.Color.Black
        Me.txtCompNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompNo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCompNo.Location = New System.Drawing.Point(113, 108)
        Me.txtCompNo.Name = "txtCompNo"
        Me.txtCompNo.Size = New System.Drawing.Size(61, 23)
        Me.txtCompNo.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Baggage No."
        '
        'txtBaggageNo
        '
        Me.txtBaggageNo.BackColor = System.Drawing.Color.Black
        Me.txtBaggageNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaggageNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaggageNo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBaggageNo.Location = New System.Drawing.Point(113, 124)
        Me.txtBaggageNo.Name = "txtBaggageNo"
        Me.txtBaggageNo.Size = New System.Drawing.Size(61, 23)
        Me.txtBaggageNo.TabIndex = 68
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrint.ForeColor = System.Drawing.Color.White
        Me.chkPrint.Location = New System.Drawing.Point(6, 168)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(51, 19)
        Me.chkPrint.TabIndex = 0
        Me.chkPrint.Text = "Print"
        Me.chkPrint.UseVisualStyleBackColor = True
        '
        'txtPrint
        '
        Me.txtPrint.BackColor = System.Drawing.Color.Black
        Me.txtPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrint.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPrint.Location = New System.Drawing.Point(113, 166)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.ReadOnly = True
        Me.txtPrint.Size = New System.Drawing.Size(112, 23)
        Me.txtPrint.TabIndex = 70
        Me.txtPrint.Text = "0.00"
        Me.txtPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScan
        '
        Me.txtScan.BackColor = System.Drawing.Color.Black
        Me.txtScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.ForeColor = System.Drawing.Color.DarkGray
        Me.txtScan.Location = New System.Drawing.Point(113, 183)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.ReadOnly = True
        Me.txtScan.Size = New System.Drawing.Size(112, 23)
        Me.txtScan.TabIndex = 72
        Me.txtScan.Text = "0.00"
        Me.txtScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkScan
        '
        Me.chkScan.AutoSize = True
        Me.chkScan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScan.ForeColor = System.Drawing.Color.White
        Me.chkScan.Location = New System.Drawing.Point(6, 185)
        Me.chkScan.Name = "chkScan"
        Me.chkScan.Size = New System.Drawing.Size(51, 19)
        Me.chkScan.TabIndex = 71
        Me.chkScan.Text = "Scan"
        Me.chkScan.UseVisualStyleBackColor = True
        '
        'txtPhotocopy
        '
        Me.txtPhotocopy.BackColor = System.Drawing.Color.Black
        Me.txtPhotocopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhotocopy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhotocopy.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPhotocopy.Location = New System.Drawing.Point(113, 199)
        Me.txtPhotocopy.Name = "txtPhotocopy"
        Me.txtPhotocopy.ReadOnly = True
        Me.txtPhotocopy.Size = New System.Drawing.Size(112, 23)
        Me.txtPhotocopy.TabIndex = 74
        Me.txtPhotocopy.Text = "0.00"
        Me.txtPhotocopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCopy
        '
        Me.chkCopy.AutoSize = True
        Me.chkCopy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopy.ForeColor = System.Drawing.Color.White
        Me.chkCopy.Location = New System.Drawing.Point(6, 201)
        Me.chkCopy.Name = "chkCopy"
        Me.chkCopy.Size = New System.Drawing.Size(84, 19)
        Me.chkCopy.TabIndex = 73
        Me.chkCopy.Text = "Photocopy"
        Me.chkCopy.UseVisualStyleBackColor = True
        '
        'txtInternet
        '
        Me.txtInternet.BackColor = System.Drawing.Color.Black
        Me.txtInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInternet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInternet.ForeColor = System.Drawing.Color.DarkGray
        Me.txtInternet.Location = New System.Drawing.Point(113, 216)
        Me.txtInternet.Name = "txtInternet"
        Me.txtInternet.ReadOnly = True
        Me.txtInternet.Size = New System.Drawing.Size(112, 23)
        Me.txtInternet.TabIndex = 76
        Me.txtInternet.Text = "0.00"
        Me.txtInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkIntFee
        '
        Me.chkIntFee.AutoSize = True
        Me.chkIntFee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIntFee.ForeColor = System.Drawing.Color.White
        Me.chkIntFee.Location = New System.Drawing.Point(6, 218)
        Me.chkIntFee.Name = "chkIntFee"
        Me.chkIntFee.Size = New System.Drawing.Size(88, 19)
        Me.chkIntFee.TabIndex = 75
        Me.chkIntFee.Text = "Internet Fee"
        Me.chkIntFee.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Exit Time"
        '
        'dtpExitTime
        '
        Me.dtpExitTime.CustomFormat = " "
        Me.dtpExitTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExitTime.Location = New System.Drawing.Point(113, 145)
        Me.dtpExitTime.Name = "dtpExitTime"
        Me.dtpExitTime.ShowUpDown = True
        Me.dtpExitTime.Size = New System.Drawing.Size(112, 23)
        Me.dtpExitTime.TabIndex = 77
        Me.dtpExitTime.Tag = "0"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGray
        Me.txtTotal.Location = New System.Drawing.Point(113, 234)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(112, 23)
        Me.txtTotal.TabIndex = 83
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "MEMBER LOGIN FORM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(124, 263)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 41)
        Me.btnDelete.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete Log")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(61, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 41)
        Me.btnSave.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save Log")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBookSearch
        '
        Me.btnBookSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBookSearch.FlatAppearance.BorderSize = 0
        Me.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookSearch.Image = CType(resources.GetObject("btnBookSearch.Image"), System.Drawing.Image)
        Me.btnBookSearch.Location = New System.Drawing.Point(230, 45)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(31, 21)
        Me.btnBookSearch.TabIndex = 93
        Me.btnBookSearch.UseVisualStyleBackColor = True
        '
        'uscLabUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnBookSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpExitTime)
        Me.Controls.Add(Me.txtInternet)
        Me.Controls.Add(Me.chkIntFee)
        Me.Controls.Add(Me.txtPhotocopy)
        Me.Controls.Add(Me.chkCopy)
        Me.Controls.Add(Me.txtScan)
        Me.Controls.Add(Me.chkScan)
        Me.Controls.Add(Me.txtPrint)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBaggageNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpEntryTime)
        Me.Controls.Add(Me.dtpEntryDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLogID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uscLabUser"
        Me.Size = New System.Drawing.Size(267, 308)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEntryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpEntryTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBaggageNo As System.Windows.Forms.TextBox
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrint As System.Windows.Forms.TextBox
    Friend WithEvents txtScan As System.Windows.Forms.TextBox
    Friend WithEvents chkScan As System.Windows.Forms.CheckBox
    Friend WithEvents txtPhotocopy As System.Windows.Forms.TextBox
    Friend WithEvents chkCopy As System.Windows.Forms.CheckBox
    Friend WithEvents txtInternet As System.Windows.Forms.TextBox
    Friend WithEvents chkIntFee As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpExitTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBookSearch As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
