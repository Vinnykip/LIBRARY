<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_return
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
        Dim ReturnIDLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Date_ReturnLabel As System.Windows.Forms.Label
        Dim Due_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_return))
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.ReturnIDTextBox = New System.Windows.Forms.TextBox
        Me.ReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Return_dataset = New libsys.return_dataset
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.Due_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ReturnTableAdapter = New libsys.return_datasetTableAdapters.returnTableAdapter
        Me.TableAdapterManager = New libsys.return_datasetTableAdapters.TableAdapterManager
        Me.Return_DetailsTableAdapter = New libsys.return_datasetTableAdapters.Return_DetailsTableAdapter
        Me.ReturnBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.ReturnBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Date_ReturnTextBox = New System.Windows.Forms.TextBox
        Me.Return_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Return_DetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.BooksID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberdatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_dataset = New libsys.member_dataset
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.MembersTableAdapter = New libsys.member_datasetTableAdapters.MembersTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox
        Me.LastnameTextBox = New System.Windows.Forms.TextBox
        ReturnIDLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        Date_ReturnLabel = New System.Windows.Forms.Label
        Due_DateLabel = New System.Windows.Forms.Label
        FirstnameLabel = New System.Windows.Forms.Label
        LastnameLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Return_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReturnBindingNavigator.SuspendLayout()
        CType(Me.Return_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Return_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberdatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturnIDLabel
        '
        ReturnIDLabel.AutoSize = True
        ReturnIDLabel.Location = New System.Drawing.Point(39, 75)
        ReturnIDLabel.Name = "ReturnIDLabel"
        ReturnIDLabel.Size = New System.Drawing.Size(93, 20)
        ReturnIDLabel.TabIndex = 0
        ReturnIDLabel.Text = "Return ID:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(97, 108)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 20)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'Date_ReturnLabel
        '
        Date_ReturnLabel.AutoSize = True
        Date_ReturnLabel.Location = New System.Drawing.Point(581, 65)
        Date_ReturnLabel.Name = "Date_ReturnLabel"
        Date_ReturnLabel.Size = New System.Drawing.Size(112, 20)
        Date_ReturnLabel.TabIndex = 8
        Date_ReturnLabel.Text = "Date Return:"
        '
        'Due_DateLabel
        '
        Due_DateLabel.AutoSize = True
        Due_DateLabel.Location = New System.Drawing.Point(604, 99)
        Due_DateLabel.Name = "Due_DateLabel"
        Due_DateLabel.Size = New System.Drawing.Size(89, 20)
        Due_DateLabel.TabIndex = 18
        Due_DateLabel.Text = "Due Date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 55)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Return Books"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Location = New System.Drawing.Point(676, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 221)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.libsys.My.Resources.Resources._001_291
        Me.PictureBox1.Location = New System.Drawing.Point(50, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 43)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Close(ALT+C)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.libsys.My.Resources.Resources.Actions_document_save_icon
        Me.PictureBox3.Location = New System.Drawing.Point(45, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.libsys.My.Resources.Resources.Add
        Me.PictureBox2.Location = New System.Drawing.Point(57, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(39, 93)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(171, 43)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "&Return(ALT+S)"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(39, 33)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(171, 42)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "&New(ALT+N)"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 358)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 26)
        Me.TextBox1.TabIndex = 44
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(299, 356)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 34)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "&Add(Alt+A)"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(LastnameLabel)
        Me.GroupBox2.Controls.Add(Me.LastnameTextBox)
        Me.GroupBox2.Controls.Add(FirstnameLabel)
        Me.GroupBox2.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(ReturnIDLabel)
        Me.GroupBox2.Controls.Add(Me.ReturnIDTextBox)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 233)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.libsys.My.Resources.Resources.Search11
        Me.PictureBox7.Location = New System.Drawing.Point(356, 110)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(331, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 42)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Search"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ReturnIDTextBox
        '
        Me.ReturnIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "ReturnID", True))
        Me.ReturnIDTextBox.Enabled = False
        Me.ReturnIDTextBox.Location = New System.Drawing.Point(156, 69)
        Me.ReturnIDTextBox.Name = "ReturnIDTextBox"
        Me.ReturnIDTextBox.Size = New System.Drawing.Size(307, 26)
        Me.ReturnIDTextBox.TabIndex = 1
        '
        'ReturnBindingSource
        '
        Me.ReturnBindingSource.DataMember = "return"
        Me.ReturnBindingSource.DataSource = Me.Return_dataset
        '
        'Return_dataset
        '
        Me.Return_dataset.DataSetName = "return_dataset"
        Me.Return_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(156, 108)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(160, 26)
        Me.IDTextBox.TabIndex = 3
        '
        'Due_DateDateTimePicker
        '
        Me.Due_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReturnBindingSource, "Due_Date", True))
        Me.Due_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Due_DateDateTimePicker.Location = New System.Drawing.Point(699, 94)
        Me.Due_DateDateTimePicker.Name = "Due_DateDateTimePicker"
        Me.Due_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Due_DateDateTimePicker.TabIndex = 19
        '
        'ReturnTableAdapter
        '
        Me.ReturnTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Return_DetailsTableAdapter = Me.Return_DetailsTableAdapter
        Me.TableAdapterManager.returnTableAdapter = Me.ReturnTableAdapter
        Me.TableAdapterManager.UpdateOrder = libsys.return_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Return_DetailsTableAdapter
        '
        Me.Return_DetailsTableAdapter.ClearBeforeFill = True
        '
        'ReturnBindingNavigator
        '
        Me.ReturnBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReturnBindingNavigator.BindingSource = Me.ReturnBindingSource
        Me.ReturnBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReturnBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReturnBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReturnBindingNavigatorSaveItem})
        Me.ReturnBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReturnBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReturnBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReturnBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReturnBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReturnBindingNavigator.Name = "ReturnBindingNavigator"
        Me.ReturnBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReturnBindingNavigator.Size = New System.Drawing.Size(977, 25)
        Me.ReturnBindingNavigator.TabIndex = 46
        Me.ReturnBindingNavigator.Text = "BindingNavigator1"
        Me.ReturnBindingNavigator.Visible = False
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
        'ReturnBindingNavigatorSaveItem
        '
        Me.ReturnBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReturnBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReturnBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReturnBindingNavigatorSaveItem.Name = "ReturnBindingNavigatorSaveItem"
        Me.ReturnBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReturnBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Date_ReturnTextBox
        '
        Me.Date_ReturnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Date_Return", True))
        Me.Date_ReturnTextBox.Enabled = False
        Me.Date_ReturnTextBox.Location = New System.Drawing.Point(699, 62)
        Me.Date_ReturnTextBox.Name = "Date_ReturnTextBox"
        Me.Date_ReturnTextBox.Size = New System.Drawing.Size(223, 26)
        Me.Date_ReturnTextBox.TabIndex = 9
        '
        'Return_DetailsBindingSource
        '
        Me.Return_DetailsBindingSource.DataMember = "return_Return_Details"
        Me.Return_DetailsBindingSource.DataSource = Me.ReturnBindingSource
        '
        'Return_DetailsDataGridView
        '
        Me.Return_DetailsDataGridView.AllowUserToAddRows = False
        Me.Return_DetailsDataGridView.AllowUserToDeleteRows = False
        Me.Return_DetailsDataGridView.AutoGenerateColumns = False
        Me.Return_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Return_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BooksID, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Return_DetailsDataGridView.DataSource = Me.Return_DetailsBindingSource
        Me.Return_DetailsDataGridView.Location = New System.Drawing.Point(22, 396)
        Me.Return_DetailsDataGridView.Name = "Return_DetailsDataGridView"
        Me.Return_DetailsDataGridView.ReadOnly = True
        Me.Return_DetailsDataGridView.Size = New System.Drawing.Size(900, 200)
        Me.Return_DetailsDataGridView.TabIndex = 46
        '
        'BooksID
        '
        Me.BooksID.DataPropertyName = "BooksID"
        Me.BooksID.HeaderText = "BookID"
        Me.BooksID.Name = "BooksID"
        Me.BooksID.ReadOnly = True
        Me.BooksID.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 400
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MembersBindingSource
        Me.ComboBox1.DisplayMember = "Firstname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(997, 191)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(18, 28)
        Me.ComboBox1.TabIndex = 47
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.MemberdatasetBindingSource
        '
        'MemberdatasetBindingSource
        '
        Me.MemberdatasetBindingSource.DataSource = Me.Member_dataset
        Me.MemberdatasetBindingSource.Position = 0
        '
        'Member_dataset
        '
        Me.Member_dataset.DataSetName = "member_dataset"
        Me.Member_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MembersBindingSource
        Me.ComboBox2.DisplayMember = "Lastname"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(1029, 192)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(19, 28)
        Me.ComboBox2.TabIndex = 48
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(35, 148)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(94, 20)
        FirstnameLabel.TabIndex = 18
        FirstnameLabel.Text = "Firstname:"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(156, 148)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(307, 26)
        Me.FirstnameTextBox.TabIndex = 19
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Location = New System.Drawing.Point(38, 187)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(91, 20)
        LastnameLabel.TabIndex = 19
        LastnameLabel.Text = "Lastname:"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Lastname", True))
        Me.LastnameTextBox.Location = New System.Drawing.Point(156, 184)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(307, 26)
        Me.LastnameTextBox.TabIndex = 20
        '
        'frm_return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 605)
        Me.ControlBox = False
        Me.Controls.Add(Due_DateLabel)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Due_DateDateTimePicker)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Return_DetailsDataGridView)
        Me.Controls.Add(Me.ReturnBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Date_ReturnTextBox)
        Me.Controls.Add(Date_ReturnLabel)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Return_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReturnBindingNavigator.ResumeLayout(False)
        Me.ReturnBindingNavigator.PerformLayout()
        CType(Me.Return_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Return_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberdatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Return_dataset As libsys.return_dataset
    Friend WithEvents ReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnTableAdapter As libsys.return_datasetTableAdapters.returnTableAdapter
    Friend WithEvents TableAdapterManager As libsys.return_datasetTableAdapters.TableAdapterManager
    Friend WithEvents ReturnBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReturnBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReturnIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ReturnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Return_DetailsTableAdapter As libsys.return_datasetTableAdapters.Return_DetailsTableAdapter
    Friend WithEvents Return_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Return_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Member_dataset As libsys.member_dataset
    Friend WithEvents MemberdatasetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As libsys.member_datasetTableAdapters.MembersTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BooksID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Due_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
End Class
