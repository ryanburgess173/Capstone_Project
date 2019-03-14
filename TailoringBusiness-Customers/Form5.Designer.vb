<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Discount__Label As System.Windows.Forms.Label
        Dim FinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim Item_IDLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.SuppliersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SuppliersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Discount__TextBox = New System.Windows.Forms.TextBox()
        Me.FinalTextBox = New System.Windows.Forms.TextBox()
        Me.btnFillFinal = New System.Windows.Forms.Button()
        Me.Item_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TailoringBusinessDataSet1 = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.TailoringBusinessDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.ItemsTableAdapter()
        NameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Discount__Label = New System.Windows.Forms.Label()
        FinalLabel = New System.Windows.Forms.Label()
        Item_IDLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliersBindingNavigator.SuspendLayout()
        CType(Me.TailoringBusinessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TailoringBusinessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(54, 49)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(58, 143)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(54, 20)
        PriceLabel.TabIndex = 5
        PriceLabel.Text = "Price:"
        '
        'Discount__Label
        '
        Discount__Label.AutoSize = True
        Discount__Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Discount__Label.Location = New System.Drawing.Point(29, 194)
        Discount__Label.Name = "Discount__Label"
        Discount__Label.Size = New System.Drawing.Size(105, 20)
        Discount__Label.TabIndex = 7
        Discount__Label.Text = "Discount %:"
        '
        'FinalLabel
        '
        FinalLabel.AutoSize = True
        FinalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinalLabel.Location = New System.Drawing.Point(60, 244)
        FinalLabel.Name = "FinalLabel"
        FinalLabel.Size = New System.Drawing.Size(53, 20)
        FinalLabel.TabIndex = 9
        FinalLabel.Text = "Final:"
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.General_LedgersTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Register_TicketsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'SuppliersBindingNavigator
        '
        Me.SuppliersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SuppliersBindingNavigator.BindingSource = Me.SuppliersBindingSource
        Me.SuppliersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SuppliersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SuppliersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SuppliersBindingNavigatorSaveItem})
        Me.SuppliersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SuppliersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SuppliersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SuppliersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SuppliersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SuppliersBindingNavigator.Name = "SuppliersBindingNavigator"
        Me.SuppliersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SuppliersBindingNavigator.Size = New System.Drawing.Size(429, 25)
        Me.SuppliersBindingNavigator.TabIndex = 0
        Me.SuppliersBindingNavigator.Text = "BindingNavigator1"
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
        'SuppliersBindingNavigatorSaveItem
        '
        Me.SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuppliersBindingNavigatorSaveItem.Image = CType(resources.GetObject("SuppliersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SuppliersBindingNavigatorSaveItem.Name = "SuppliersBindingNavigatorSaveItem"
        Me.SuppliersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SuppliersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(147, 46)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NameTextBox.TabIndex = 2
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(147, 140)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PriceTextBox.TabIndex = 6
        '
        'Discount__TextBox
        '
        Me.Discount__TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Discount %", True))
        Me.Discount__TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discount__TextBox.Location = New System.Drawing.Point(147, 191)
        Me.Discount__TextBox.Name = "Discount__TextBox"
        Me.Discount__TextBox.Size = New System.Drawing.Size(220, 26)
        Me.Discount__TextBox.TabIndex = 8
        '
        'FinalTextBox
        '
        Me.FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Final", True))
        Me.FinalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalTextBox.Location = New System.Drawing.Point(147, 241)
        Me.FinalTextBox.Name = "FinalTextBox"
        Me.FinalTextBox.Size = New System.Drawing.Size(220, 26)
        Me.FinalTextBox.TabIndex = 10
        '
        'btnFillFinal
        '
        Me.btnFillFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillFinal.Location = New System.Drawing.Point(140, 297)
        Me.btnFillFinal.Name = "btnFillFinal"
        Me.btnFillFinal.Size = New System.Drawing.Size(148, 43)
        Me.btnFillFinal.TabIndex = 11
        Me.btnFillFinal.Text = "Calculate Final"
        Me.btnFillFinal.UseVisualStyleBackColor = True
        '
        'Item_IDLabel
        '
        Item_IDLabel.AutoSize = True
        Item_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_IDLabel.Location = New System.Drawing.Point(40, 96)
        Item_IDLabel.Name = "Item_IDLabel"
        Item_IDLabel.Size = New System.Drawing.Size(74, 20)
        Item_IDLabel.TabIndex = 11
        Item_IDLabel.Text = "Item ID:"
        '
        'Item_IDComboBox
        '
        Me.Item_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Item ID", True))
        Me.Item_IDComboBox.DataSource = Me.ItemsBindingSource
        Me.Item_IDComboBox.DisplayMember = "ID"
        Me.Item_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_IDComboBox.FormattingEnabled = True
        Me.Item_IDComboBox.Location = New System.Drawing.Point(147, 93)
        Me.Item_IDComboBox.Name = "Item_IDComboBox"
        Me.Item_IDComboBox.Size = New System.Drawing.Size(220, 28)
        Me.Item_IDComboBox.TabIndex = 12
        Me.Item_IDComboBox.ValueMember = "ID"
        '
        'TailoringBusinessDataSet1
        '
        Me.TailoringBusinessDataSet1.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TailoringBusinessDataSet1BindingSource
        '
        Me.TailoringBusinessDataSet1BindingSource.DataSource = Me.TailoringBusinessDataSet1
        Me.TailoringBusinessDataSet1BindingSource.Position = 0
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.TailoringBusinessDataSet1BindingSource
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 364)
        Me.Controls.Add(Item_IDLabel)
        Me.Controls.Add(Me.Item_IDComboBox)
        Me.Controls.Add(Me.btnFillFinal)
        Me.Controls.Add(FinalLabel)
        Me.Controls.Add(Me.FinalTextBox)
        Me.Controls.Add(Discount__Label)
        Me.Controls.Add(Me.Discount__TextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.SuppliersBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Suppliers"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliersBindingNavigator.ResumeLayout(False)
        Me.SuppliersBindingNavigator.PerformLayout()
        CType(Me.TailoringBusinessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TailoringBusinessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As TailoringBusinessDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppliersBindingNavigator As BindingNavigator
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
    Friend WithEvents SuppliersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Discount__TextBox As TextBox
    Friend WithEvents FinalTextBox As TextBox
    Friend WithEvents btnFillFinal As Button
    Friend WithEvents Item_IDComboBox As ComboBox
    Friend WithEvents TailoringBusinessDataSet1BindingSource As BindingSource
    Friend WithEvents TailoringBusinessDataSet1 As TailoringBusinessDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As TailoringBusinessDataSetTableAdapters.ItemsTableAdapter
End Class
