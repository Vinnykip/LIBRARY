<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_borrow
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
        Dim BorrowIDLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Date_BorrowLabel As System.Windows.Forms.Label
        Dim Due_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_borrow))
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Me.BorrowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrow_dataset = New libsys.borrow_dataset
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BorrowBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BorrowIDTextBox = New System.Windows.Forms.TextBox
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_dataset = New libsys.member_dataset
        Me.Date_BorrowTextBox = New System.Windows.Forms.TextBox
        Me.Borrow_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BorrowTableAdapter = New libsys.borrow_datasetTableAdapters.borrowTableAdapter
        Me.TableAdapterManager = New libsys.borrow_datasetTableAdapters.TableAdapterManager
        Me.Borrow_DetailsTableAdapter = New libsys.borrow_datasetTableAdapters.Borrow_DetailsTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Due_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.MembersTableAdapter = New libsys.member_datasetTableAdapters.MembersTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Borrow_DetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.BooksID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox
        Me.LastnameTextBox = New System.Windows.Forms.TextBox
        BorrowIDLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        Date_BorrowLabel = New System.Windows.Forms.Label
        Due_DateLabel = New System.Windows.Forms.Label
        FirstnameLabel = New System.Windows.Forms.Label
        LastnameLabel = New System.Windows.Forms.Label
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowBindingNavigator.SuspendLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Borrow_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowIDLabel
        '
        BorrowIDLabel.AutoSize = True
        BorrowIDLabel.Location = New System.Drawing.Point(18, 63)
        BorrowIDLabel.Name = "BorrowIDLabel"
        BorrowIDLabel.Size = New System.Drawing.Size(93, 20)
        BorrowIDLabel.TabIndex = 1
        BorrowIDLabel.Text = "Borrow ID:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(18, 101)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(102, 20)
        IDLabel.TabIndex = 3
        IDLabel.Text = "Member ID:"
        '
        'Date_BorrowLabel
        '
        Date_BorrowLabel.AutoSize = True
        Date_BorrowLabel.Location = New System.Drawing.Point(564, 64)
        Date_BorrowLabel.Name = "Date_BorrowLabel"
        Date_BorrowLabel.Size = New System.Drawing.Size(112, 20)
        Date_BorrowLabel.TabIndex = 9
        Date_BorrowLabel.Text = "Date Borrow:"
        '
        'Due_DateLabel
        '
        Due_DateLabel.AutoSize = True
        Due_DateLabel.Location = New System.Drawing.Point(564, 93)
        Due_DateLabel.Name = "Due_DateLabel"
        Due_DateLabel.Size = New System.Drawing.Size(89, 20)
        Due_DateLabel.TabIndex = 16
        Due_DateLabel.Text = "Due Date:"
        '
        'BorrowBindingNavigator
        '
        Me.BorrowBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowBindingNavigator.BindingSource = Me.BorrowBindingSource
        Me.BorrowBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BorrowBindingNavigatorSaveItem})
        Me.BorrowBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowBindingNavigator.Name = "BorrowBindingNavigator"
        Me.BorrowBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowBindingNavigator.Size = New System.Drawing.Size(956, 25)
        Me.BorrowBindingNavigator.TabIndex = 0
        Me.BorrowBindingNavigator.Text = "BindingNavigator1"
        Me.BorrowBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BorrowBindingSource
        '
        Me.BorrowBindingSource.DataMember = "borrow"
        Me.BorrowBindingSource.DataSource = Me.Borrow_dataset
        '
        'Borrow_dataset
        '
        Me.Borrow_dataset.DataSetName = "borrow_dataset"
        Me.Borrow_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BorrowBindingNavigatorSaveItem
        '
        Me.BorrowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowBindingNavigatorSaveItem.Name = "BorrowBindingNavigatorSaveItem"
        Me.BorrowBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BorrowBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BorrowIDTextBox
        '
        Me.BorrowIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BorrowID", True))
        Me.BorrowIDTextBox.Enabled = False
        Me.BorrowIDTextBox.Location = New System.Drawing.Point(153, 52)
        Me.BorrowIDTextBox.Name = "BorrowIDTextBox"
        Me.BorrowIDTextBox.Size = New System.Drawing.Size(345, 26)
        Me.BorrowIDTextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(153, 99)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(186, 26)
        Me.IDTextBox.TabIndex = 4
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.Member_dataset
        '
        'Member_dataset
        '
        Me.Member_dataset.DataSetName = "member_dataset"
        Me.Member_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Date_BorrowTextBox
        '
        Me.Date_BorrowTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Date_Borrow", True))
        Me.Date_BorrowTextBox.Enabled = False
        Me.Date_BorrowTextBox.Location = New System.Drawing.Point(682, 61)
        Me.Date_BorrowTextBox.Name = "Date_BorrowTextBox"
        Me.Date_BorrowTextBox.Size = New System.Drawing.Size(237, 26)
        Me.Date_BorrowTextBox.TabIndex = 10
        '
        'Borrow_DetailsBindingSource
        '
        Me.Borrow_DetailsBindingSource.DataMember = "borrow_Borrow_Details"
        Me.Borrow_DetailsBindingSource.DataSource = Me.BorrowBindingSource
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Borrow_DetailsTableAdapter = Me.Borrow_DetailsTableAdapter
        Me.TableAdapterManager.borrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.UpdateOrder = libsys.borrow_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Borrow_DetailsTableAdapter
        '
        Me.Borrow_DetailsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Location = New System.Drawing.Point(673, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 219)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.libsys.My.Resources.Resources._001_291
        Me.PictureBox1.Location = New System.Drawing.Point(50, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Close(ALT+C)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.libsys.My.Resources.Resources.Actions_document_save_icon
        Me.PictureBox3.Location = New System.Drawing.Point(45, 103)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.libsys.My.Resources.Resources.Add
        Me.PictureBox2.Location = New System.Drawing.Point(57, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(39, 96)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(171, 43)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "Bo&rrow(ALT+R)"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(39, 27)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(171, 42)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "&New(ALT+N)"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(LastnameLabel)
        Me.GroupBox2.Controls.Add(Me.LastnameTextBox)
        Me.GroupBox2.Controls.Add(FirstnameLabel)
        Me.GroupBox2.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(BorrowIDLabel)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.BorrowIDTextBox)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 219)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.libsys.My.Resources.Resources.Search11
        Me.PictureBox7.Location = New System.Drawing.Point(391, 98)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(366, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 42)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Search"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Due_DateDateTimePicker
        '
        Me.Due_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "Due_Date", True))
        Me.Due_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Due_DateDateTimePicker.Location = New System.Drawing.Point(682, 93)
        Me.Due_DateDateTimePicker.Name = "Due_DateDateTimePicker"
        Me.Due_DateDateTimePicker.Size = New System.Drawing.Size(143, 26)
        Me.Due_DateDateTimePicker.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MembersBindingSource
        Me.ComboBox2.DisplayMember = "Lastname"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(991, 169)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(10, 28)
        Me.ComboBox2.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MembersBindingSource
        Me.ComboBox1.DisplayMember = "Firstname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(966, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(10, 28)
        Me.ComboBox1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 55)
        Me.Panel1.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrow Books"
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 324)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 26)
        Me.TextBox1.TabIndex = 41
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(235, 322)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 34)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "&Add(ALT+A)"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Borrow_DetailsDataGridView
        '
        Me.Borrow_DetailsDataGridView.AllowUserToAddRows = False
        Me.Borrow_DetailsDataGridView.AutoGenerateColumns = False
        Me.Borrow_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Borrow_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BooksID, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Borrow_DetailsDataGridView.DataSource = Me.Borrow_DetailsBindingSource
        Me.Borrow_DetailsDataGridView.Location = New System.Drawing.Point(12, 366)
        Me.Borrow_DetailsDataGridView.Name = "Borrow_DetailsDataGridView"
        Me.Borrow_DetailsDataGridView.ReadOnly = True
        Me.Borrow_DetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Borrow_DetailsDataGridView.Size = New System.Drawing.Size(910, 213)
        Me.Borrow_DetailsDataGridView.TabIndex = 41
        '
        'BooksID
        '
        Me.BooksID.DataPropertyName = "BooksID"
        Me.BooksID.HeaderText = "BookID"
        Me.BooksID.Name = "BooksID"
        Me.BooksID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 500
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 270
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(18, 138)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(94, 20)
        FirstnameLabel.TabIndex = 16
        FirstnameLabel.Text = "Firstname:"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(153, 138)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(345, 26)
        Me.FirstnameTextBox.TabIndex = 17
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Location = New System.Drawing.Point(18, 173)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(91, 20)
        LastnameLabel.TabIndex = 17
        LastnameLabel.Text = "Lastname:"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Lastname", True))
        Me.LastnameTextBox.Location = New System.Drawing.Point(153, 170)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(345, 26)
        Me.LastnameTextBox.TabIndex = 18
        '
        'frm_borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 593)
        Me.ControlBox = False
        Me.Controls.Add(Due_DateLabel)
        Me.Controls.Add(Me.Borrow_DetailsDataGridView)
        Me.Controls.Add(Me.Due_DateDateTimePicker)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BorrowBindingNavigator)
        Me.Controls.Add(Date_BorrowLabel)
        Me.Controls.Add(Me.Date_BorrowTextBox)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowBindingNavigator.ResumeLayout(False)
        Me.BorrowBindingNavigator.PerformLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Borrow_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Borrow_dataset As libsys.borrow_dataset
    Friend WithEvents BorrowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BorrowTableAdapter As libsys.borrow_datasetTableAdapters.borrowTableAdapter
    Friend WithEvents TableAdapterManager As libsys.borrow_datasetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BorrowBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Borrow_DetailsTableAdapter As libsys.borrow_datasetTableAdapters.Borrow_DetailsTableAdapter
    Friend WithEvents BorrowIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_BorrowTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Borrow_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Member_dataset As libsys.member_dataset
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As libsys.member_datasetTableAdapters.MembersTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Borrow_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Due_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BooksID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
End Class
