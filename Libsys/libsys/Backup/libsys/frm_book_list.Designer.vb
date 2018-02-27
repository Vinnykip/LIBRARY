<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_book_list
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
        Dim SourceLabel As System.Windows.Forms.Label
        Dim CopyrightDateLabel As System.Windows.Forms.Label
        Dim PublisherNameLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim DeweyDecimalClassNumLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim CategoryLabel1 As System.Windows.Forms.Label
        Dim Book_CodeLabel As System.Windows.Forms.Label
        Dim StatusLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_book_list))
        Me.BooksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Books_dataset = New libsys.books_dataset
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
        Me.BooksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BooksTableAdapter = New libsys.books_datasetTableAdapters.booksTableAdapter
        Me.TableAdapterManager = New libsys.books_datasetTableAdapters.TableAdapterManager
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button7 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Category_dataset = New libsys.category_dataset
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Book_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnprev = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnmovefirst = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.Book_CodeTextBox = New System.Windows.Forms.TextBox
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox
        Me.ISBNTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.DeweyDecimalClassNumTextBox = New System.Windows.Forms.TextBox
        Me.AuthorTextBox = New System.Windows.Forms.TextBox
        Me.PublisherNameTextBox = New System.Windows.Forms.TextBox
        Me.CopyrightDateTextBox = New System.Windows.Forms.TextBox
        Me.SourceTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CategoryTableAdapter = New libsys.category_datasetTableAdapters.CategoryTableAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        SourceLabel = New System.Windows.Forms.Label
        CopyrightDateLabel = New System.Windows.Forms.Label
        PublisherNameLabel = New System.Windows.Forms.Label
        AuthorLabel = New System.Windows.Forms.Label
        DeweyDecimalClassNumLabel = New System.Windows.Forms.Label
        CategoryLabel = New System.Windows.Forms.Label
        TitleLabel = New System.Windows.Forms.Label
        ISBNLabel = New System.Windows.Forms.Label
        CategoryLabel1 = New System.Windows.Forms.Label
        Book_CodeLabel = New System.Windows.Forms.Label
        StatusLabel1 = New System.Windows.Forms.Label
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BooksBindingNavigator.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Books_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Category_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SourceLabel
        '
        SourceLabel.AutoSize = True
        SourceLabel.Location = New System.Drawing.Point(34, 315)
        SourceLabel.Name = "SourceLabel"
        SourceLabel.Size = New System.Drawing.Size(69, 20)
        SourceLabel.TabIndex = 22
        SourceLabel.Text = "Source:"
        '
        'CopyrightDateLabel
        '
        CopyrightDateLabel.AutoSize = True
        CopyrightDateLabel.Location = New System.Drawing.Point(34, 278)
        CopyrightDateLabel.Name = "CopyrightDateLabel"
        CopyrightDateLabel.Size = New System.Drawing.Size(134, 20)
        CopyrightDateLabel.TabIndex = 20
        CopyrightDateLabel.Text = "Copyright Date:"
        '
        'PublisherNameLabel
        '
        PublisherNameLabel.AutoSize = True
        PublisherNameLabel.Location = New System.Drawing.Point(34, 242)
        PublisherNameLabel.Name = "PublisherNameLabel"
        PublisherNameLabel.Size = New System.Drawing.Size(140, 20)
        PublisherNameLabel.TabIndex = 18
        PublisherNameLabel.Text = "Publisher Name:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(34, 204)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(69, 20)
        AuthorLabel.TabIndex = 16
        AuthorLabel.Text = "Author:"
        '
        'DeweyDecimalClassNumLabel
        '
        DeweyDecimalClassNumLabel.AutoSize = True
        DeweyDecimalClassNumLabel.Location = New System.Drawing.Point(34, 167)
        DeweyDecimalClassNumLabel.Name = "DeweyDecimalClassNumLabel"
        DeweyDecimalClassNumLabel.Size = New System.Drawing.Size(225, 20)
        DeweyDecimalClassNumLabel.TabIndex = 14
        DeweyDecimalClassNumLabel.Text = "Dewey Decimal Class Num:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(34, 129)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(84, 20)
        CategoryLabel.TabIndex = 12
        CategoryLabel.Text = "Category:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(34, 88)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(48, 20)
        TitleLabel.TabIndex = 10
        TitleLabel.Text = "Title:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(34, 47)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(54, 20)
        ISBNLabel.TabIndex = 8
        ISBNLabel.Text = "ISBN:"
        '
        'CategoryLabel1
        '
        CategoryLabel1.AutoSize = True
        CategoryLabel1.Location = New System.Drawing.Point(339, 132)
        CategoryLabel1.Name = "CategoryLabel1"
        CategoryLabel1.Size = New System.Drawing.Size(0, 20)
        CategoryLabel1.TabIndex = 23
        '
        'Book_CodeLabel
        '
        Book_CodeLabel.AutoSize = True
        Book_CodeLabel.Location = New System.Drawing.Point(34, 15)
        Book_CodeLabel.Name = "Book_CodeLabel"
        Book_CodeLabel.Size = New System.Drawing.Size(99, 20)
        Book_CodeLabel.TabIndex = 25
        Book_CodeLabel.Text = "Book Code:"
        '
        'StatusLabel1
        '
        StatusLabel1.AutoSize = True
        StatusLabel1.Location = New System.Drawing.Point(34, 356)
        StatusLabel1.Name = "StatusLabel1"
        StatusLabel1.Size = New System.Drawing.Size(65, 20)
        StatusLabel1.TabIndex = 26
        StatusLabel1.Text = "Status:"
        '
        'BooksBindingNavigator
        '
        Me.BooksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BooksBindingNavigator.BindingSource = Me.BooksBindingSource
        Me.BooksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BooksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BooksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BooksBindingNavigatorSaveItem})
        Me.BooksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BooksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BooksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BooksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BooksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BooksBindingNavigator.Name = "BooksBindingNavigator"
        Me.BooksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BooksBindingNavigator.Size = New System.Drawing.Size(1267, 25)
        Me.BooksBindingNavigator.TabIndex = 0
        Me.BooksBindingNavigator.Text = "BindingNavigator1"
        Me.BooksBindingNavigator.Visible = False
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
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.Books_dataset
        '
        'Books_dataset
        '
        Me.Books_dataset.DataSetName = "books_dataset"
        Me.Books_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BooksBindingNavigatorSaveItem
        '
        Me.BooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BooksBindingNavigatorSaveItem.Image = CType(resources.GetObject("BooksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BooksBindingNavigatorSaveItem.Name = "BooksBindingNavigatorSaveItem"
        Me.BooksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BooksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = libsys.books_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BooksDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1235, 427)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grid View"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(358, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 32)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Sort By Status:"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Borrowed", "Available"})
        Me.ComboBox2.Location = New System.Drawing.Point(527, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(212, 28)
        Me.ComboBox2.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(750, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 32)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Sort By Category:"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoryBindingSource
        Me.ComboBox1.DisplayMember = "CategoryName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(919, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(302, 28)
        Me.ComboBox1.TabIndex = 16
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.Category_dataset
        '
        'Category_dataset
        '
        Me.Category_dataset.DataSetName = "category_dataset"
        Me.Category_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Status, Me.Book_Code})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        Me.BooksDataGridView.Location = New System.Drawing.Point(3, 50)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        Me.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksDataGridView.Size = New System.Drawing.Size(1229, 421)
        Me.BooksDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DeweyDecimalClassNum"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DeweyDecimal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PublisherName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PublisherName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CopyrightDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CopyrightDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 140
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Source"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Source"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Book_Code
        '
        Me.Book_Code.DataPropertyName = "Book_Code"
        Me.Book_Code.HeaderText = "Book_Code"
        Me.Book_Code.Name = "Book_Code"
        Me.Book_Code.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btnprev)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.btnmovefirst)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1235, 427)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail View"
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(995, 277)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(150, 42)
        Me.btnprev.TabIndex = 30
        Me.btnprev.Text = "<< Previous"
        Me.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(995, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 42)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = ">>Next"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(995, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 42)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "<| Move to Last"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnmovefirst
        '
        Me.btnmovefirst.Location = New System.Drawing.Point(995, 231)
        Me.btnmovefirst.Name = "btnmovefirst"
        Me.btnmovefirst.Size = New System.Drawing.Size(150, 42)
        Me.btnmovefirst.TabIndex = 13
        Me.btnmovefirst.Text = "|> Move to First "
        Me.btnmovefirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmovefirst.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(StatusLabel1)
        Me.GroupBox2.Controls.Add(Me.StatusComboBox)
        Me.GroupBox2.Controls.Add(Book_CodeLabel)
        Me.GroupBox2.Controls.Add(Me.Book_CodeTextBox)
        Me.GroupBox2.Controls.Add(CategoryLabel1)
        Me.GroupBox2.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox2.Controls.Add(ISBNLabel)
        Me.GroupBox2.Controls.Add(Me.ISBNTextBox)
        Me.GroupBox2.Controls.Add(TitleLabel)
        Me.GroupBox2.Controls.Add(Me.TitleTextBox)
        Me.GroupBox2.Controls.Add(CategoryLabel)
        Me.GroupBox2.Controls.Add(DeweyDecimalClassNumLabel)
        Me.GroupBox2.Controls.Add(Me.DeweyDecimalClassNumTextBox)
        Me.GroupBox2.Controls.Add(AuthorLabel)
        Me.GroupBox2.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox2.Controls.Add(PublisherNameLabel)
        Me.GroupBox2.Controls.Add(Me.PublisherNameTextBox)
        Me.GroupBox2.Controls.Add(CopyrightDateLabel)
        Me.GroupBox2.Controls.Add(Me.CopyrightDateTextBox)
        Me.GroupBox2.Controls.Add(SourceLabel)
        Me.GroupBox2.Controls.Add(Me.SourceTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 398)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Status", True))
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Enabled = False
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Available", "Borrowed"})
        Me.StatusComboBox.Location = New System.Drawing.Point(265, 353)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(369, 28)
        Me.StatusComboBox.TabIndex = 27
        '
        'Book_CodeTextBox
        '
        Me.Book_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Book_Code", True))
        Me.Book_CodeTextBox.Enabled = False
        Me.Book_CodeTextBox.Location = New System.Drawing.Point(265, 12)
        Me.Book_CodeTextBox.Name = "Book_CodeTextBox"
        Me.Book_CodeTextBox.Size = New System.Drawing.Size(196, 26)
        Me.Book_CodeTextBox.TabIndex = 26
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Category", True))
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Enabled = False
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(265, 126)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(369, 28)
        Me.CategoryComboBox.TabIndex = 24
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ISBN", True))
        Me.ISBNTextBox.Enabled = False
        Me.ISBNTextBox.Location = New System.Drawing.Point(265, 44)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(369, 26)
        Me.ISBNTextBox.TabIndex = 9
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.TitleTextBox.Enabled = False
        Me.TitleTextBox.Location = New System.Drawing.Point(265, 85)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(369, 26)
        Me.TitleTextBox.TabIndex = 11
        '
        'DeweyDecimalClassNumTextBox
        '
        Me.DeweyDecimalClassNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "DeweyDecimalClassNum", True))
        Me.DeweyDecimalClassNumTextBox.Enabled = False
        Me.DeweyDecimalClassNumTextBox.Location = New System.Drawing.Point(265, 164)
        Me.DeweyDecimalClassNumTextBox.Name = "DeweyDecimalClassNumTextBox"
        Me.DeweyDecimalClassNumTextBox.Size = New System.Drawing.Size(369, 26)
        Me.DeweyDecimalClassNumTextBox.TabIndex = 15
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Enabled = False
        Me.AuthorTextBox.Location = New System.Drawing.Point(265, 201)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(369, 26)
        Me.AuthorTextBox.TabIndex = 17
        '
        'PublisherNameTextBox
        '
        Me.PublisherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "PublisherName", True))
        Me.PublisherNameTextBox.Enabled = False
        Me.PublisherNameTextBox.Location = New System.Drawing.Point(265, 239)
        Me.PublisherNameTextBox.Name = "PublisherNameTextBox"
        Me.PublisherNameTextBox.Size = New System.Drawing.Size(369, 26)
        Me.PublisherNameTextBox.TabIndex = 19
        '
        'CopyrightDateTextBox
        '
        Me.CopyrightDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "CopyrightDate", True))
        Me.CopyrightDateTextBox.Enabled = False
        Me.CopyrightDateTextBox.Location = New System.Drawing.Point(265, 275)
        Me.CopyrightDateTextBox.Name = "CopyrightDateTextBox"
        Me.CopyrightDateTextBox.Size = New System.Drawing.Size(369, 26)
        Me.CopyrightDateTextBox.TabIndex = 21
        '
        'SourceTextBox
        '
        Me.SourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Source", True))
        Me.SourceTextBox.Enabled = False
        Me.SourceTextBox.Location = New System.Drawing.Point(265, 312)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(369, 26)
        Me.SourceTextBox.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Location = New System.Drawing.Point(956, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 222)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.libsys.My.Resources.Resources.application24
        Me.PictureBox7.Location = New System.Drawing.Point(58, 174)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(40, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 43)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "&Edit(ALT+E)"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.libsys.My.Resources.Resources._001_49
        Me.PictureBox6.Location = New System.Drawing.Point(48, 123)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 43)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "&Delete(ALT+D)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.libsys.My.Resources.Resources.Actions_document_save_icon
        Me.PictureBox3.Location = New System.Drawing.Point(59, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.libsys.My.Resources.Resources.Add
        Me.PictureBox2.Location = New System.Drawing.Point(57, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(39, 66)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(171, 43)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "&Save(ALT+S)"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(39, 18)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(171, 42)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "&Add(ALT+A)"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1243, 460)
        Me.TabControl1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 45)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(792, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Search by  Book Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.libsys.My.Resources.Resources.folder_home22
        Me.PictureBox5.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.libsys.My.Resources.Resources.Search1
        Me.PictureBox4.Location = New System.Drawing.Point(977, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Books List"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1018, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 26)
        Me.TextBox1.TabIndex = 0
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(0, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1267, 57)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.libsys.My.Resources.Resources._001_29
        Me.PictureBox1.Location = New System.Drawing.Point(1095, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1081, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Close(ALT+C)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_book_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BooksBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_book_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BooksBindingNavigator.ResumeLayout(False)
        Me.BooksBindingNavigator.PerformLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Books_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Category_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Books_dataset As libsys.books_dataset
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As libsys.books_datasetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As libsys.books_datasetTableAdapters.TableAdapterManager
    Friend WithEvents BooksBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BooksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BooksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeweyDecimalClassNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CopyrightDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Category_dataset As libsys.category_dataset
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As libsys.category_datasetTableAdapters.CategoryTableAdapter
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnmovefirst As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Book_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
