<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Dim Receipt_IDLabel As System.Windows.Forms.Label
        Dim Register_NumberLabel As System.Windows.Forms.Label
        Dim TransactionLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.Register_TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Register_TicketsTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.Register_TicketsTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.Register_TicketsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Register_TicketsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Receipt_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Register_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTextBox = New System.Windows.Forms.TextBox()
        Receipt_IDLabel = New System.Windows.Forms.Label()
        Register_NumberLabel = New System.Windows.Forms.Label()
        TransactionLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Register_TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Register_TicketsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Register_TicketsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Register_TicketsBindingSource
        '
        Me.Register_TicketsBindingSource.DataMember = "Register Tickets"
        Me.Register_TicketsBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'Register_TicketsTableAdapter
        '
        Me.Register_TicketsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Register_TicketsTableAdapter = Me.Register_TicketsTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'Register_TicketsBindingNavigator
        '
        Me.Register_TicketsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Register_TicketsBindingNavigator.BindingSource = Me.Register_TicketsBindingSource
        Me.Register_TicketsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Register_TicketsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Register_TicketsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Register_TicketsBindingNavigatorSaveItem})
        Me.Register_TicketsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Register_TicketsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Register_TicketsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Register_TicketsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Register_TicketsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Register_TicketsBindingNavigator.Name = "Register_TicketsBindingNavigator"
        Me.Register_TicketsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Register_TicketsBindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.Register_TicketsBindingNavigator.TabIndex = 0
        Me.Register_TicketsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Register_TicketsBindingNavigatorSaveItem
        '
        Me.Register_TicketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Register_TicketsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Register_TicketsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Register_TicketsBindingNavigatorSaveItem.Name = "Register_TicketsBindingNavigatorSaveItem"
        Me.Register_TicketsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Register_TicketsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Receipt_IDLabel
        '
        Receipt_IDLabel.AutoSize = True
        Receipt_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Receipt_IDLabel.Location = New System.Drawing.Point(111, 63)
        Receipt_IDLabel.Name = "Receipt_IDLabel"
        Receipt_IDLabel.Size = New System.Drawing.Size(101, 24)
        Receipt_IDLabel.TabIndex = 1
        Receipt_IDLabel.Text = "Receipt ID:"
        '
        'Receipt_IDTextBox
        '
        Me.Receipt_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_TicketsBindingSource, "Receipt_ID", True))
        Me.Receipt_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_IDTextBox.Location = New System.Drawing.Point(218, 60)
        Me.Receipt_IDTextBox.Name = "Receipt_IDTextBox"
        Me.Receipt_IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Receipt_IDTextBox.TabIndex = 2
        '
        'Register_NumberLabel
        '
        Register_NumberLabel.AutoSize = True
        Register_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Register_NumberLabel.Location = New System.Drawing.Point(56, 130)
        Register_NumberLabel.Name = "Register_NumberLabel"
        Register_NumberLabel.Size = New System.Drawing.Size(158, 24)
        Register_NumberLabel.TabIndex = 3
        Register_NumberLabel.Text = "Register Number:"
        '
        'Register_NumberTextBox
        '
        Me.Register_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_TicketsBindingSource, "Register Number", True))
        Me.Register_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_NumberTextBox.Location = New System.Drawing.Point(218, 127)
        Me.Register_NumberTextBox.Name = "Register_NumberTextBox"
        Me.Register_NumberTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Register_NumberTextBox.TabIndex = 4
        '
        'TransactionLabel
        '
        TransactionLabel.AutoSize = True
        TransactionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TransactionLabel.Location = New System.Drawing.Point(99, 195)
        TransactionLabel.Name = "TransactionLabel"
        TransactionLabel.Size = New System.Drawing.Size(113, 24)
        TransactionLabel.TabIndex = 5
        TransactionLabel.Text = "Transaction:"
        '
        'TransactionTextBox
        '
        Me.TransactionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Register_TicketsBindingSource, "Transaction", True))
        Me.TransactionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTextBox.Location = New System.Drawing.Point(218, 194)
        Me.TransactionTextBox.Name = "TransactionTextBox"
        Me.TransactionTextBox.Size = New System.Drawing.Size(100, 29)
        Me.TransactionTextBox.TabIndex = 6
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 288)
        Me.Controls.Add(TransactionLabel)
        Me.Controls.Add(Me.TransactionTextBox)
        Me.Controls.Add(Register_NumberLabel)
        Me.Controls.Add(Me.Register_NumberTextBox)
        Me.Controls.Add(Receipt_IDLabel)
        Me.Controls.Add(Me.Receipt_IDTextBox)
        Me.Controls.Add(Me.Register_TicketsBindingNavigator)
        Me.Name = "Form8"
        Me.Text = "Register Tickets"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Register_TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Register_TicketsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Register_TicketsBindingNavigator.ResumeLayout(False)
        Me.Register_TicketsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents Register_TicketsBindingSource As BindingSource
    Friend WithEvents Register_TicketsTableAdapter As TailoringBusinessDataSetTableAdapters.Register_TicketsTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Register_TicketsBindingNavigator As BindingNavigator
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
    Friend WithEvents Register_TicketsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Receipt_IDTextBox As TextBox
    Friend WithEvents Register_NumberTextBox As TextBox
    Friend WithEvents TransactionTextBox As TextBox
End Class
