<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Dim IDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Balance_Brought_Forward_DateLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CreditsLabel As System.Windows.Forms.Label
        Dim DebitsLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.General_LedgersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.General_LedgersTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.General_LedgersTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.General_LedgersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.General_LedgersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Balance_Brought_Forward_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CreditsTextBox = New System.Windows.Forms.TextBox()
        Me.DebitsTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Balance_Brought_Forward_DateLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CreditsLabel = New System.Windows.Forms.Label()
        DebitsLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.General_LedgersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.General_LedgersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.General_LedgersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'General_LedgersBindingSource
        '
        Me.General_LedgersBindingSource.DataMember = "General Ledgers"
        Me.General_LedgersBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'General_LedgersTableAdapter
        '
        Me.General_LedgersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.CommissionTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.General_LedgersTableAdapter = Me.General_LedgersTableAdapter
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Register_TicketsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'General_LedgersBindingNavigator
        '
        Me.General_LedgersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.General_LedgersBindingNavigator.BindingSource = Me.General_LedgersBindingSource
        Me.General_LedgersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.General_LedgersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.General_LedgersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.General_LedgersBindingNavigatorSaveItem})
        Me.General_LedgersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.General_LedgersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.General_LedgersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.General_LedgersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.General_LedgersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.General_LedgersBindingNavigator.Name = "General_LedgersBindingNavigator"
        Me.General_LedgersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.General_LedgersBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.General_LedgersBindingNavigator.TabIndex = 0
        Me.General_LedgersBindingNavigator.Text = "BindingNavigator1"
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
        'General_LedgersBindingNavigatorSaveItem
        '
        Me.General_LedgersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.General_LedgersBindingNavigatorSaveItem.Image = CType(resources.GetObject("General_LedgersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.General_LedgersBindingNavigatorSaveItem.Name = "General_LedgersBindingNavigatorSaveItem"
        Me.General_LedgersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.General_LedgersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(237, 61)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.General_LedgersBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(273, 58)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(285, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(218, 108)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(48, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.General_LedgersBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(273, 103)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(285, 26)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'Balance_Brought_Forward_DateLabel
        '
        Balance_Brought_Forward_DateLabel.AutoSize = True
        Balance_Brought_Forward_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Balance_Brought_Forward_DateLabel.Location = New System.Drawing.Point(34, 157)
        Balance_Brought_Forward_DateLabel.Name = "Balance_Brought_Forward_DateLabel"
        Balance_Brought_Forward_DateLabel.Size = New System.Drawing.Size(233, 20)
        Balance_Brought_Forward_DateLabel.TabIndex = 5
        Balance_Brought_Forward_DateLabel.Text = "Balance Brought Forward Date:"
        '
        'Balance_Brought_Forward_DateDateTimePicker
        '
        Me.Balance_Brought_Forward_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.General_LedgersBindingSource, "Balance Brought Forward Date", True))
        Me.Balance_Brought_Forward_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance_Brought_Forward_DateDateTimePicker.Location = New System.Drawing.Point(273, 152)
        Me.Balance_Brought_Forward_DateDateTimePicker.Name = "Balance_Brought_Forward_DateDateTimePicker"
        Me.Balance_Brought_Forward_DateDateTimePicker.Size = New System.Drawing.Size(285, 26)
        Me.Balance_Brought_Forward_DateDateTimePicker.TabIndex = 6
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(174, 206)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(93, 20)
        DescriptionLabel.TabIndex = 7
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.General_LedgersBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(273, 203)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(285, 26)
        Me.DescriptionTextBox.TabIndex = 8
        '
        'CreditsLabel
        '
        CreditsLabel.AutoSize = True
        CreditsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CreditsLabel.Location = New System.Drawing.Point(204, 257)
        CreditsLabel.Name = "CreditsLabel"
        CreditsLabel.Size = New System.Drawing.Size(63, 20)
        CreditsLabel.TabIndex = 9
        CreditsLabel.Text = "Credits:"
        '
        'CreditsTextBox
        '
        Me.CreditsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.General_LedgersBindingSource, "Credits", True))
        Me.CreditsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditsTextBox.Location = New System.Drawing.Point(273, 254)
        Me.CreditsTextBox.Name = "CreditsTextBox"
        Me.CreditsTextBox.Size = New System.Drawing.Size(285, 26)
        Me.CreditsTextBox.TabIndex = 10
        '
        'DebitsLabel
        '
        DebitsLabel.AutoSize = True
        DebitsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DebitsLabel.Location = New System.Drawing.Point(208, 309)
        DebitsLabel.Name = "DebitsLabel"
        DebitsLabel.Size = New System.Drawing.Size(59, 20)
        DebitsLabel.TabIndex = 11
        DebitsLabel.Text = "Debits:"
        '
        'DebitsTextBox
        '
        Me.DebitsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.General_LedgersBindingSource, "Debits", True))
        Me.DebitsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebitsTextBox.Location = New System.Drawing.Point(273, 306)
        Me.DebitsTextBox.Name = "DebitsTextBox"
        Me.DebitsTextBox.Size = New System.Drawing.Size(285, 26)
        Me.DebitsTextBox.TabIndex = 12
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NetLabel.Location = New System.Drawing.Point(229, 365)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(38, 20)
        NetLabel.TabIndex = 13
        NetLabel.Text = "Net:"
        '
        'NetTextBox
        '
        Me.NetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.General_LedgersBindingSource, "Net", True))
        Me.NetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetTextBox.Location = New System.Drawing.Point(273, 362)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.Size = New System.Drawing.Size(285, 26)
        Me.NetTextBox.TabIndex = 14
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 456)
        Me.Controls.Add(NetLabel)
        Me.Controls.Add(Me.NetTextBox)
        Me.Controls.Add(DebitsLabel)
        Me.Controls.Add(Me.DebitsTextBox)
        Me.Controls.Add(CreditsLabel)
        Me.Controls.Add(Me.CreditsTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Balance_Brought_Forward_DateLabel)
        Me.Controls.Add(Me.Balance_Brought_Forward_DateDateTimePicker)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.General_LedgersBindingNavigator)
        Me.Name = "Form10"
        Me.Text = "General Ledger"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.General_LedgersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.General_LedgersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.General_LedgersBindingNavigator.ResumeLayout(False)
        Me.General_LedgersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents General_LedgersBindingSource As BindingSource
    Friend WithEvents General_LedgersTableAdapter As TailoringBusinessDataSetTableAdapters.General_LedgersTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents General_LedgersBindingNavigator As BindingNavigator
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
    Friend WithEvents General_LedgersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Balance_Brought_Forward_DateDateTimePicker As DateTimePicker
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents CreditsTextBox As TextBox
    Friend WithEvents DebitsTextBox As TextBox
    Friend WithEvents NetTextBox As TextBox
End Class
