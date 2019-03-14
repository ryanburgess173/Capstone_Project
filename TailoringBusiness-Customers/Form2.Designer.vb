<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim MobilePhoneLabel As System.Windows.Forms.Label
        Dim FaxNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateProvinceLabel As System.Windows.Forms.Label
        Dim ZIPPostalLabel As System.Windows.Forms.Label
        Dim CountryRegionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New TailoringBusiness_Customers.TailoringBusinessDataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.MobilePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.ZIPPostalTextBox = New System.Windows.Forms.TextBox()
        Me.CountryRegionTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        NameLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        MobilePhoneLabel = New System.Windows.Forms.Label()
        FaxNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateProvinceLabel = New System.Windows.Forms.Label()
        ZIPPostalLabel = New System.Windows.Forms.Label()
        CountryRegionLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(80, 52)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 20)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(38, 92)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(98, 20)
        DepartmentLabel.TabIndex = 3
        DepartmentLabel.Text = "Department:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(94, 138)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(42, 20)
        TitleLabel.TabIndex = 5
        TitleLabel.Text = "Title:"
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.AutoSize = True
        BusinessPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BusinessPhoneLabel.Location = New System.Drawing.Point(17, 187)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(128, 20)
        BusinessPhoneLabel.TabIndex = 7
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'MobilePhoneLabel
        '
        MobilePhoneLabel.AutoSize = True
        MobilePhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobilePhoneLabel.Location = New System.Drawing.Point(33, 278)
        MobilePhoneLabel.Name = "MobilePhoneLabel"
        MobilePhoneLabel.Size = New System.Drawing.Size(109, 20)
        MobilePhoneLabel.TabIndex = 11
        MobilePhoneLabel.Text = "Mobile Phone:"
        '
        'FaxNumberLabel
        '
        FaxNumberLabel.AutoSize = True
        FaxNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxNumberLabel.Location = New System.Drawing.Point(43, 327)
        FaxNumberLabel.Name = "FaxNumberLabel"
        FaxNumberLabel.Size = New System.Drawing.Size(99, 20)
        FaxNumberLabel.TabIndex = 13
        FaxNumberLabel.Text = "Fax Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(84, 376)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address1Label.Location = New System.Drawing.Point(483, 49)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(81, 20)
        Address1Label.TabIndex = 17
        Address1Label.Text = "Address1:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(525, 92)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(39, 20)
        CityLabel.TabIndex = 19
        CityLabel.Text = "City:"
        '
        'StateProvinceLabel
        '
        StateProvinceLabel.AutoSize = True
        StateProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateProvinceLabel.Location = New System.Drawing.Point(448, 138)
        StateProvinceLabel.Name = "StateProvinceLabel"
        StateProvinceLabel.Size = New System.Drawing.Size(116, 20)
        StateProvinceLabel.TabIndex = 21
        StateProvinceLabel.Text = "State Province:"
        '
        'ZIPPostalLabel
        '
        ZIPPostalLabel.AutoSize = True
        ZIPPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZIPPostalLabel.Location = New System.Drawing.Point(482, 184)
        ZIPPostalLabel.Name = "ZIPPostalLabel"
        ZIPPostalLabel.Size = New System.Drawing.Size(82, 20)
        ZIPPostalLabel.TabIndex = 23
        ZIPPostalLabel.Text = "ZIPPostal:"
        '
        'CountryRegionLabel
        '
        CountryRegionLabel.AutoSize = True
        CountryRegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryRegionLabel.Location = New System.Drawing.Point(441, 235)
        CountryRegionLabel.Name = "CountryRegionLabel"
        CountryRegionLabel.Size = New System.Drawing.Size(123, 20)
        CountryRegionLabel.TabIndex = 25
        CountryRegionLabel.Text = "Country Region:"
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.UpdateOrder = TailoringBusiness_Customers.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(870, 25)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(149, 49)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(254, 26)
        Me.NameTextBox.TabIndex = 2
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Department", True))
        Me.DepartmentComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"Executive", "Manufacturing", "Sales", "Book Keeping", "Purchasing"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(149, 89)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(254, 28)
        Me.DepartmentComboBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(149, 135)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(254, 26)
        Me.TitleTextBox.TabIndex = 6
        '
        'BusinessPhoneTextBox
        '
        Me.BusinessPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "BusinessPhone", True))
        Me.BusinessPhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusinessPhoneTextBox.Location = New System.Drawing.Point(149, 184)
        Me.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox"
        Me.BusinessPhoneTextBox.Size = New System.Drawing.Size(254, 26)
        Me.BusinessPhoneTextBox.TabIndex = 8
        '
        'MobilePhoneTextBox
        '
        Me.MobilePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "MobilePhone", True))
        Me.MobilePhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobilePhoneTextBox.Location = New System.Drawing.Point(149, 275)
        Me.MobilePhoneTextBox.Name = "MobilePhoneTextBox"
        Me.MobilePhoneTextBox.Size = New System.Drawing.Size(254, 26)
        Me.MobilePhoneTextBox.TabIndex = 12
        '
        'FaxNumberTextBox
        '
        Me.FaxNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "FaxNumber", True))
        Me.FaxNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaxNumberTextBox.Location = New System.Drawing.Point(149, 324)
        Me.FaxNumberTextBox.Name = "FaxNumberTextBox"
        Me.FaxNumberTextBox.Size = New System.Drawing.Size(254, 26)
        Me.FaxNumberTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(149, 373)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(254, 26)
        Me.EmailTextBox.TabIndex = 16
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address1", True))
        Me.Address1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(570, 46)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(255, 26)
        Me.Address1TextBox.TabIndex = 18
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(570, 92)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(255, 26)
        Me.CityTextBox.TabIndex = 20
        '
        'StateProvinceTextBox
        '
        Me.StateProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "StateProvince", True))
        Me.StateProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateProvinceTextBox.Location = New System.Drawing.Point(570, 135)
        Me.StateProvinceTextBox.Name = "StateProvinceTextBox"
        Me.StateProvinceTextBox.Size = New System.Drawing.Size(255, 26)
        Me.StateProvinceTextBox.TabIndex = 22
        '
        'ZIPPostalTextBox
        '
        Me.ZIPPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "ZIPPostal", True))
        Me.ZIPPostalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPPostalTextBox.Location = New System.Drawing.Point(570, 178)
        Me.ZIPPostalTextBox.Name = "ZIPPostalTextBox"
        Me.ZIPPostalTextBox.Size = New System.Drawing.Size(255, 26)
        Me.ZIPPostalTextBox.TabIndex = 24
        '
        'CountryRegionTextBox
        '
        Me.CountryRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "CountryRegion", True))
        Me.CountryRegionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryRegionTextBox.Location = New System.Drawing.Point(570, 229)
        Me.CountryRegionTextBox.Name = "CountryRegionTextBox"
        Me.CountryRegionTextBox.Size = New System.Drawing.Size(255, 26)
        Me.CountryRegionTextBox.TabIndex = 26
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HomePhoneLabel.Location = New System.Drawing.Point(36, 232)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(106, 20)
        HomePhoneLabel.TabIndex = 26
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(149, 229)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(254, 26)
        Me.HomePhoneTextBox.TabIndex = 27
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 461)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(CountryRegionLabel)
        Me.Controls.Add(Me.CountryRegionTextBox)
        Me.Controls.Add(ZIPPostalLabel)
        Me.Controls.Add(Me.ZIPPostalTextBox)
        Me.Controls.Add(StateProvinceLabel)
        Me.Controls.Add(Me.StateProvinceTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FaxNumberLabel)
        Me.Controls.Add(Me.FaxNumberTextBox)
        Me.Controls.Add(MobilePhoneLabel)
        Me.Controls.Add(Me.MobilePhoneTextBox)
        Me.Controls.Add(BusinessPhoneLabel)
        Me.Controls.Add(Me.BusinessPhoneTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Employee Records"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As TailoringBusinessDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As BindingNavigator
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
    Friend WithEvents EmployeesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents BusinessPhoneTextBox As TextBox
    Friend WithEvents MobilePhoneTextBox As TextBox
    Friend WithEvents FaxNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateProvinceTextBox As TextBox
    Friend WithEvents ZIPPostalTextBox As TextBox
    Friend WithEvents CountryRegionTextBox As TextBox
    Friend WithEvents HomePhoneTextBox As TextBox
End Class
