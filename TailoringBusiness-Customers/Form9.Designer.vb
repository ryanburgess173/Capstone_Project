<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Dim IDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Total_Of_Cash_DepositedLabel As System.Windows.Forms.Label
        Dim Total_Of_Checks_DepositedLabel As System.Windows.Forms.Label
        Dim Total_DepositedLabel As System.Windows.Forms.Label
        Dim AccountLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.Bank_DepositsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bank_DepositsTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.Bank_DepositsTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.Bank_DepositsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Bank_DepositsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_Of_Cash_DepositedTextBox = New System.Windows.Forms.TextBox()
        Me.Total_Of_Checks_DepositedTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DepositedTextBox = New System.Windows.Forms.TextBox()
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.CommentRichTextBox = New System.Windows.Forms.RichTextBox()
        IDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Total_Of_Cash_DepositedLabel = New System.Windows.Forms.Label()
        Total_Of_Checks_DepositedLabel = New System.Windows.Forms.Label()
        Total_DepositedLabel = New System.Windows.Forms.Label()
        AccountLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bank_DepositsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bank_DepositsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bank_DepositsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bank_DepositsBindingSource
        '
        Me.Bank_DepositsBindingSource.DataMember = "Bank Deposits"
        Me.Bank_DepositsBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'Bank_DepositsTableAdapter
        '
        Me.Bank_DepositsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Me.Bank_DepositsTableAdapter
        Me.TableAdapterManager.CommissionTableAdapter = Nothing
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
        'Bank_DepositsBindingNavigator
        '
        Me.Bank_DepositsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Bank_DepositsBindingNavigator.BindingSource = Me.Bank_DepositsBindingSource
        Me.Bank_DepositsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Bank_DepositsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Bank_DepositsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Bank_DepositsBindingNavigatorSaveItem})
        Me.Bank_DepositsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Bank_DepositsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Bank_DepositsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Bank_DepositsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Bank_DepositsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Bank_DepositsBindingNavigator.Name = "Bank_DepositsBindingNavigator"
        Me.Bank_DepositsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Bank_DepositsBindingNavigator.Size = New System.Drawing.Size(563, 25)
        Me.Bank_DepositsBindingNavigator.TabIndex = 0
        Me.Bank_DepositsBindingNavigator.Text = "BindingNavigator1"
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
        'Bank_DepositsBindingNavigatorSaveItem
        '
        Me.Bank_DepositsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bank_DepositsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Bank_DepositsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Bank_DepositsBindingNavigatorSaveItem.Name = "Bank_DepositsBindingNavigatorSaveItem"
        Me.Bank_DepositsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Bank_DepositsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(194, 64)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(230, 61)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(277, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(176, 100)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(48, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Bank_DepositsBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(230, 100)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(277, 26)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'Total_Of_Cash_DepositedLabel
        '
        Total_Of_Cash_DepositedLabel.AutoSize = True
        Total_Of_Cash_DepositedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Of_Cash_DepositedLabel.Location = New System.Drawing.Point(37, 141)
        Total_Of_Cash_DepositedLabel.Name = "Total_Of_Cash_DepositedLabel"
        Total_Of_Cash_DepositedLabel.Size = New System.Drawing.Size(187, 20)
        Total_Of_Cash_DepositedLabel.TabIndex = 5
        Total_Of_Cash_DepositedLabel.Text = "Total Of Cash Deposited:"
        '
        'Total_Of_Cash_DepositedTextBox
        '
        Me.Total_Of_Cash_DepositedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "Total Of Cash Deposited", True))
        Me.Total_Of_Cash_DepositedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Of_Cash_DepositedTextBox.Location = New System.Drawing.Point(230, 141)
        Me.Total_Of_Cash_DepositedTextBox.Name = "Total_Of_Cash_DepositedTextBox"
        Me.Total_Of_Cash_DepositedTextBox.Size = New System.Drawing.Size(277, 26)
        Me.Total_Of_Cash_DepositedTextBox.TabIndex = 6
        '
        'Total_Of_Checks_DepositedLabel
        '
        Total_Of_Checks_DepositedLabel.AutoSize = True
        Total_Of_Checks_DepositedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Of_Checks_DepositedLabel.Location = New System.Drawing.Point(21, 187)
        Total_Of_Checks_DepositedLabel.Name = "Total_Of_Checks_DepositedLabel"
        Total_Of_Checks_DepositedLabel.Size = New System.Drawing.Size(203, 20)
        Total_Of_Checks_DepositedLabel.TabIndex = 7
        Total_Of_Checks_DepositedLabel.Text = "Total Of Checks Deposited:"
        '
        'Total_Of_Checks_DepositedTextBox
        '
        Me.Total_Of_Checks_DepositedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "Total Of Checks Deposited", True))
        Me.Total_Of_Checks_DepositedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Of_Checks_DepositedTextBox.Location = New System.Drawing.Point(230, 184)
        Me.Total_Of_Checks_DepositedTextBox.Name = "Total_Of_Checks_DepositedTextBox"
        Me.Total_Of_Checks_DepositedTextBox.Size = New System.Drawing.Size(277, 26)
        Me.Total_Of_Checks_DepositedTextBox.TabIndex = 8
        '
        'Total_DepositedLabel
        '
        Total_DepositedLabel.AutoSize = True
        Total_DepositedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_DepositedLabel.Location = New System.Drawing.Point(99, 224)
        Total_DepositedLabel.Name = "Total_DepositedLabel"
        Total_DepositedLabel.Size = New System.Drawing.Size(125, 20)
        Total_DepositedLabel.TabIndex = 9
        Total_DepositedLabel.Text = "Total Deposited:"
        '
        'Total_DepositedTextBox
        '
        Me.Total_DepositedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "Total Deposited", True))
        Me.Total_DepositedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_DepositedTextBox.Location = New System.Drawing.Point(230, 224)
        Me.Total_DepositedTextBox.Name = "Total_DepositedTextBox"
        Me.Total_DepositedTextBox.Size = New System.Drawing.Size(277, 26)
        Me.Total_DepositedTextBox.TabIndex = 10
        '
        'AccountLabel
        '
        AccountLabel.AutoSize = True
        AccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountLabel.Location = New System.Drawing.Point(152, 262)
        AccountLabel.Name = "AccountLabel"
        AccountLabel.Size = New System.Drawing.Size(72, 20)
        AccountLabel.TabIndex = 11
        AccountLabel.Text = "Account:"
        '
        'AccountTextBox
        '
        Me.AccountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "Account", True))
        Me.AccountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountTextBox.Location = New System.Drawing.Point(230, 262)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(277, 26)
        Me.AccountTextBox.TabIndex = 12
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommentLabel.Location = New System.Drawing.Point(142, 306)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(82, 20)
        CommentLabel.TabIndex = 13
        CommentLabel.Text = "Comment:"
        '
        'CommentRichTextBox
        '
        Me.CommentRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bank_DepositsBindingSource, "Comment", True))
        Me.CommentRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentRichTextBox.Location = New System.Drawing.Point(230, 306)
        Me.CommentRichTextBox.Name = "CommentRichTextBox"
        Me.CommentRichTextBox.Size = New System.Drawing.Size(277, 96)
        Me.CommentRichTextBox.TabIndex = 14
        Me.CommentRichTextBox.Text = ""
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 446)
        Me.Controls.Add(CommentLabel)
        Me.Controls.Add(Me.CommentRichTextBox)
        Me.Controls.Add(AccountLabel)
        Me.Controls.Add(Me.AccountTextBox)
        Me.Controls.Add(Total_DepositedLabel)
        Me.Controls.Add(Me.Total_DepositedTextBox)
        Me.Controls.Add(Total_Of_Checks_DepositedLabel)
        Me.Controls.Add(Me.Total_Of_Checks_DepositedTextBox)
        Me.Controls.Add(Total_Of_Cash_DepositedLabel)
        Me.Controls.Add(Me.Total_Of_Cash_DepositedTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Bank_DepositsBindingNavigator)
        Me.Name = "Form9"
        Me.Text = "Bank Deposits"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bank_DepositsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bank_DepositsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bank_DepositsBindingNavigator.ResumeLayout(False)
        Me.Bank_DepositsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents Bank_DepositsBindingSource As BindingSource
    Friend WithEvents Bank_DepositsTableAdapter As TailoringBusinessDataSetTableAdapters.Bank_DepositsTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Bank_DepositsBindingNavigator As BindingNavigator
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
    Friend WithEvents Bank_DepositsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Total_Of_Cash_DepositedTextBox As TextBox
    Friend WithEvents Total_Of_Checks_DepositedTextBox As TextBox
    Friend WithEvents Total_DepositedTextBox As TextBox
    Friend WithEvents AccountTextBox As TextBox
    Friend WithEvents CommentRichTextBox As RichTextBox
End Class
