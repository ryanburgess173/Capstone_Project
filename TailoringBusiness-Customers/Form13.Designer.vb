<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Amount_SoldLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Commission__Label As System.Windows.Forms.Label
        Dim Total_CommissionLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.CommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommissionTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.CommissionTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.CommissionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CommissionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_SoldTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Commission__TextBox = New System.Windows.Forms.TextBox()
        Me.Total_CommissionTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Amount_SoldLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Commission__Label = New System.Windows.Forms.Label()
        Total_CommissionLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommissionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommissionBindingSource
        '
        Me.CommissionBindingSource.DataMember = "Commission"
        Me.CommissionBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'CommissionTableAdapter
        '
        Me.CommissionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.CommissionTableAdapter = Me.CommissionTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.General_LedgersTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Register_TicketsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'CommissionBindingNavigator
        '
        Me.CommissionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CommissionBindingNavigator.BindingSource = Me.CommissionBindingSource
        Me.CommissionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CommissionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CommissionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CommissionBindingNavigatorSaveItem})
        Me.CommissionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CommissionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CommissionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CommissionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CommissionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CommissionBindingNavigator.Name = "CommissionBindingNavigator"
        Me.CommissionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CommissionBindingNavigator.Size = New System.Drawing.Size(432, 25)
        Me.CommissionBindingNavigator.TabIndex = 0
        Me.CommissionBindingNavigator.Text = "BindingNavigator1"
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
        'CommissionBindingNavigatorSaveItem
        '
        Me.CommissionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CommissionBindingNavigatorSaveItem.Image = CType(resources.GetObject("CommissionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CommissionBindingNavigatorSaveItem.Name = "CommissionBindingNavigatorSaveItem"
        Me.CommissionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CommissionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(141, 61)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommissionBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(177, 58)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(197, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'Amount_SoldLabel
        '
        Amount_SoldLabel.AutoSize = True
        Amount_SoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_SoldLabel.Location = New System.Drawing.Point(66, 119)
        Amount_SoldLabel.Name = "Amount_SoldLabel"
        Amount_SoldLabel.Size = New System.Drawing.Size(105, 20)
        Amount_SoldLabel.TabIndex = 3
        Amount_SoldLabel.Text = "Amount Sold:"
        '
        'Amount_SoldTextBox
        '
        Me.Amount_SoldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommissionBindingSource, "Amount Sold", True))
        Me.Amount_SoldTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_SoldTextBox.Location = New System.Drawing.Point(177, 116)
        Me.Amount_SoldTextBox.Name = "Amount_SoldTextBox"
        Me.Amount_SoldTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Amount_SoldTextBox.TabIndex = 4
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_IDLabel.Location = New System.Drawing.Point(67, 178)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(104, 20)
        Employee_IDLabel.TabIndex = 5
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommissionBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(177, 175)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Employee_IDTextBox.TabIndex = 6
        '
        'Commission__Label
        '
        Commission__Label.AutoSize = True
        Commission__Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Commission__Label.Location = New System.Drawing.Point(54, 238)
        Commission__Label.Name = "Commission__Label"
        Commission__Label.Size = New System.Drawing.Size(117, 20)
        Commission__Label.TabIndex = 7
        Commission__Label.Text = "Commission %:"
        '
        'Commission__TextBox
        '
        Me.Commission__TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommissionBindingSource, "Commission %", True))
        Me.Commission__TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commission__TextBox.Location = New System.Drawing.Point(177, 235)
        Me.Commission__TextBox.Name = "Commission__TextBox"
        Me.Commission__TextBox.Size = New System.Drawing.Size(197, 26)
        Me.Commission__TextBox.TabIndex = 8
        '
        'Total_CommissionLabel
        '
        Total_CommissionLabel.AutoSize = True
        Total_CommissionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_CommissionLabel.Location = New System.Drawing.Point(33, 299)
        Total_CommissionLabel.Name = "Total_CommissionLabel"
        Total_CommissionLabel.Size = New System.Drawing.Size(138, 20)
        Total_CommissionLabel.TabIndex = 9
        Total_CommissionLabel.Text = "Total Commission:"
        '
        'Total_CommissionTextBox
        '
        Me.Total_CommissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommissionBindingSource, "Total Commission", True))
        Me.Total_CommissionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_CommissionTextBox.Location = New System.Drawing.Point(177, 296)
        Me.Total_CommissionTextBox.Name = "Total_CommissionTextBox"
        Me.Total_CommissionTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Total_CommissionTextBox.TabIndex = 10
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 382)
        Me.Controls.Add(Total_CommissionLabel)
        Me.Controls.Add(Me.Total_CommissionTextBox)
        Me.Controls.Add(Commission__Label)
        Me.Controls.Add(Me.Commission__TextBox)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Amount_SoldLabel)
        Me.Controls.Add(Me.Amount_SoldTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.CommissionBindingNavigator)
        Me.Name = "Form13"
        Me.Text = "Commission Reports"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommissionBindingNavigator.ResumeLayout(False)
        Me.CommissionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents CommissionBindingSource As BindingSource
    Friend WithEvents CommissionTableAdapter As TailoringBusinessDataSetTableAdapters.CommissionTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CommissionBindingNavigator As BindingNavigator
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
    Friend WithEvents CommissionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Amount_SoldTextBox As TextBox
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents Commission__TextBox As TextBox
    Friend WithEvents Total_CommissionTextBox As TextBox
End Class
