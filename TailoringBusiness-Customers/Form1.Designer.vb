<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.CustomersTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnVendors = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnRegisterTickets = New System.Windows.Forms.Button()
        Me.btnBankDeposits = New System.Windows.Forms.Button()
        Me.btnGeneralLedgers = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnInventoryReports = New System.Windows.Forms.Button()
        Me.btnCommission = New System.Windows.Forms.Button()
        Me.btnVendorInvoices = New System.Windows.Forms.Button()
        Me.lblWelcomeMsg = New System.Windows.Forms.Label()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.CommissionTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
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
        'btnCustomers
        '
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.Location = New System.Drawing.Point(49, 122)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(233, 57)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Location = New System.Drawing.Point(49, 196)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(233, 57)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.Location = New System.Drawing.Point(49, 270)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(233, 57)
        Me.btnItems.TabIndex = 2
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.Location = New System.Drawing.Point(49, 344)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(233, 57)
        Me.btnSuppliers.TabIndex = 3
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnVendors
        '
        Me.btnVendors.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendors.Location = New System.Drawing.Point(49, 414)
        Me.btnVendors.Name = "btnVendors"
        Me.btnVendors.Size = New System.Drawing.Size(233, 57)
        Me.btnVendors.TabIndex = 4
        Me.btnVendors.Text = "Vendors"
        Me.btnVendors.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.Location = New System.Drawing.Point(49, 488)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(233, 57)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'btnRegisterTickets
        '
        Me.btnRegisterTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterTickets.Location = New System.Drawing.Point(49, 563)
        Me.btnRegisterTickets.Name = "btnRegisterTickets"
        Me.btnRegisterTickets.Size = New System.Drawing.Size(233, 57)
        Me.btnRegisterTickets.TabIndex = 6
        Me.btnRegisterTickets.Text = "Register Tickets"
        Me.btnRegisterTickets.UseVisualStyleBackColor = True
        '
        'btnBankDeposits
        '
        Me.btnBankDeposits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankDeposits.Location = New System.Drawing.Point(325, 122)
        Me.btnBankDeposits.Name = "btnBankDeposits"
        Me.btnBankDeposits.Size = New System.Drawing.Size(233, 57)
        Me.btnBankDeposits.TabIndex = 7
        Me.btnBankDeposits.Text = "Bank Deposits"
        Me.btnBankDeposits.UseVisualStyleBackColor = True
        '
        'btnGeneralLedgers
        '
        Me.btnGeneralLedgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralLedgers.Location = New System.Drawing.Point(325, 196)
        Me.btnGeneralLedgers.Name = "btnGeneralLedgers"
        Me.btnGeneralLedgers.Size = New System.Drawing.Size(233, 57)
        Me.btnGeneralLedgers.TabIndex = 8
        Me.btnGeneralLedgers.Text = "General Ledgers"
        Me.btnGeneralLedgers.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(325, 270)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(233, 57)
        Me.btnInventory.TabIndex = 9
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnInventoryReports
        '
        Me.btnInventoryReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryReports.Location = New System.Drawing.Point(325, 344)
        Me.btnInventoryReports.Name = "btnInventoryReports"
        Me.btnInventoryReports.Size = New System.Drawing.Size(233, 57)
        Me.btnInventoryReports.TabIndex = 10
        Me.btnInventoryReports.Text = "Inventory Reports"
        Me.btnInventoryReports.UseVisualStyleBackColor = True
        '
        'btnCommission
        '
        Me.btnCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommission.Location = New System.Drawing.Point(325, 414)
        Me.btnCommission.Name = "btnCommission"
        Me.btnCommission.Size = New System.Drawing.Size(233, 57)
        Me.btnCommission.TabIndex = 11
        Me.btnCommission.Text = "Commission"
        Me.btnCommission.UseVisualStyleBackColor = True
        '
        'btnVendorInvoices
        '
        Me.btnVendorInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendorInvoices.Location = New System.Drawing.Point(325, 488)
        Me.btnVendorInvoices.Name = "btnVendorInvoices"
        Me.btnVendorInvoices.Size = New System.Drawing.Size(233, 57)
        Me.btnVendorInvoices.TabIndex = 12
        Me.btnVendorInvoices.Text = "Vendor Invoices"
        Me.btnVendorInvoices.UseVisualStyleBackColor = True
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.AutoSize = True
        Me.lblWelcomeMsg.Font = New System.Drawing.Font("Script MT Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWelcomeMsg.Location = New System.Drawing.Point(29, 41)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New System.Drawing.Size(549, 58)
        Me.lblWelcomeMsg.TabIndex = 13
        Me.lblWelcomeMsg.Text = "Larry's Tailoring Business"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 662)
        Me.Controls.Add(Me.lblWelcomeMsg)
        Me.Controls.Add(Me.btnVendorInvoices)
        Me.Controls.Add(Me.btnCommission)
        Me.Controls.Add(Me.btnInventoryReports)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnGeneralLedgers)
        Me.Controls.Add(Me.btnBankDeposits)
        Me.Controls.Add(Me.btnRegisterTickets)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnVendors)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnCustomers)
        Me.Name = "Form1"
        Me.Text = "Business Data Center - Version 1.0"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As TailoringBusinessDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnVendors As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnRegisterTickets As Button
    Friend WithEvents btnBankDeposits As Button
    Friend WithEvents btnGeneralLedgers As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnInventoryReports As Button
    Friend WithEvents btnCommission As Button
    Friend WithEvents btnVendorInvoices As Button
    Friend WithEvents lblWelcomeMsg As Label
End Class
