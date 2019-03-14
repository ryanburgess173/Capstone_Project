<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Paid_with_CashLabel As System.Windows.Forms.Label
        Dim Item_IDLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim Sales_TaxLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.CustomersTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.CustomersTableAdapter()
        Me.TransactionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransactionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TailoringBusinessDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_with_CashCheckBox = New System.Windows.Forms.CheckBox()
        Me.Item_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_TaxTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        CustomerLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Paid_with_CashLabel = New System.Windows.Forms.Label()
        Item_IDLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        Sales_TaxLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionsBindingNavigator.SuspendLayout()
        CType(Me.TailoringBusinessDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        CustomerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CustomerLabel.Location = New System.Drawing.Point(91, 57)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(82, 20)
        CustomerLabel.TabIndex = 1
        CustomerLabel.Text = "Customer:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DateLabel.Location = New System.Drawing.Point(110, 118)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(48, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Employee_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Employee_IDLabel.Location = New System.Drawing.Point(24, 199)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(104, 20)
        Employee_IDLabel.TabIndex = 5
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Paid_with_CashLabel
        '
        Paid_with_CashLabel.AutoSize = True
        Paid_with_CashLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Paid_with_CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_with_CashLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Paid_with_CashLabel.Location = New System.Drawing.Point(291, 195)
        Paid_with_CashLabel.Name = "Paid_with_CashLabel"
        Paid_with_CashLabel.Size = New System.Drawing.Size(117, 20)
        Paid_with_CashLabel.TabIndex = 7
        Paid_with_CashLabel.Text = "Paid with Cash:"
        AddHandler Paid_with_CashLabel.Click, AddressOf Me.Paid_with_CashLabel_Click
        '
        'Item_IDLabel
        '
        Item_IDLabel.AutoSize = True
        Item_IDLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Item_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Item_IDLabel.Location = New System.Drawing.Point(62, 252)
        Item_IDLabel.Name = "Item_IDLabel"
        Item_IDLabel.Size = New System.Drawing.Size(66, 20)
        Item_IDLabel.TabIndex = 9
        Item_IDLabel.Text = "Item ID:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        QuantityLabel.Location = New System.Drawing.Point(291, 252)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        AddHandler QuantityLabel.Click, AddressOf Me.QuantityLabel_Click
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        SubTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SubTotalLabel.Location = New System.Drawing.Point(47, 335)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(81, 20)
        SubTotalLabel.TabIndex = 13
        SubTotalLabel.Text = "Sub Total:"
        '
        'Sales_TaxLabel
        '
        Sales_TaxLabel.AutoSize = True
        Sales_TaxLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Sales_TaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sales_TaxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Sales_TaxLabel.Location = New System.Drawing.Point(46, 386)
        Sales_TaxLabel.Name = "Sales_TaxLabel"
        Sales_TaxLabel.Size = New System.Drawing.Size(82, 20)
        Sales_TaxLabel.TabIndex = 15
        Sales_TaxLabel.Text = "Sales Tax:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TotalLabel.Location = New System.Drawing.Point(80, 440)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(48, 20)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.General_LedgersTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Register_TicketsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Me.TransactionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TransactionsBindingNavigator
        '
        Me.TransactionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransactionsBindingNavigator.BindingSource = Me.TransactionsBindingSource
        Me.TransactionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransactionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransactionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransactionsBindingNavigatorSaveItem})
        Me.TransactionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransactionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransactionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransactionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransactionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransactionsBindingNavigator.Name = "TransactionsBindingNavigator"
        Me.TransactionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransactionsBindingNavigator.Size = New System.Drawing.Size(541, 25)
        Me.TransactionsBindingNavigator.TabIndex = 0
        Me.TransactionsBindingNavigator.Text = "BindingNavigator1"
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
        'TransactionsBindingNavigatorSaveItem
        '
        Me.TransactionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransactionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransactionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransactionsBindingNavigatorSaveItem.Name = "TransactionsBindingNavigatorSaveItem"
        Me.TransactionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransactionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TailoringBusinessDataSetBindingSource
        '
        Me.TailoringBusinessDataSetBindingSource.DataSource = Me.TailoringBusinessDataSet
        Me.TailoringBusinessDataSetBindingSource.Position = 0
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.TailoringBusinessDataSetBindingSource
        '
        'CustomersTransactionsBindingSource
        '
        Me.CustomersTransactionsBindingSource.DataMember = "CustomersTransactions"
        Me.CustomersTransactionsBindingSource.DataSource = Me.CustomersBindingSource
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.TailoringBusinessDataSetBindingSource
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Customer", True))
        Me.CustomerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerTextBox.Location = New System.Drawing.Point(179, 54)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(282, 26)
        Me.CustomerTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransactionsBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(179, 113)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(282, 26)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(134, 196)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Employee_IDTextBox.TabIndex = 6
        '
        'Paid_with_CashCheckBox
        '
        Me.Paid_with_CashCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TransactionsBindingSource, "Paid with Cash", True))
        Me.Paid_with_CashCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid_with_CashCheckBox.Location = New System.Drawing.Point(424, 194)
        Me.Paid_with_CashCheckBox.Name = "Paid_with_CashCheckBox"
        Me.Paid_with_CashCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Paid_with_CashCheckBox.TabIndex = 8
        Me.Paid_with_CashCheckBox.UseVisualStyleBackColor = True
        '
        'Item_IDTextBox
        '
        Me.Item_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Item_ID", True))
        Me.Item_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_IDTextBox.Location = New System.Drawing.Point(134, 249)
        Me.Item_IDTextBox.Name = "Item_IDTextBox"
        Me.Item_IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Item_IDTextBox.TabIndex = 10
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(387, 249)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(70, 26)
        Me.QuantityTextBox.TabIndex = 12
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(134, 332)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SubTotalTextBox.TabIndex = 14
        '
        'Sales_TaxTextBox
        '
        Me.Sales_TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Sales Tax", True))
        Me.Sales_TaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_TaxTextBox.Location = New System.Drawing.Point(134, 383)
        Me.Sales_TaxTextBox.Name = "Sales_TaxTextBox"
        Me.Sales_TaxTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Sales_TaxTextBox.TabIndex = 16
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(134, 437)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalTextBox.TabIndex = 18
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(541, 512)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Sales_TaxLabel)
        Me.Controls.Add(Me.Sales_TaxTextBox)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Item_IDLabel)
        Me.Controls.Add(Me.Item_IDTextBox)
        Me.Controls.Add(Paid_with_CashLabel)
        Me.Controls.Add(Me.Paid_with_CashCheckBox)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.TransactionsBindingNavigator)
        Me.Name = "Form7"
        Me.Text = "Business Transactions"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionsBindingNavigator.ResumeLayout(False)
        Me.TransactionsBindingNavigator.PerformLayout()
        CType(Me.TailoringBusinessDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As TailoringBusinessDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransactionsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TransactionsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomersTableAdapter As TailoringBusinessDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TailoringBusinessDataSetBindingSource As BindingSource
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomersTransactionsBindingSource As BindingSource
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents Paid_with_CashCheckBox As CheckBox
    Friend WithEvents Item_IDTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Sales_TaxTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
End Class
