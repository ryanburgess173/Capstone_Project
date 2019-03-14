Public Class Form1

    Dim EmployeesForm As New Form2
    Dim CustomersForm As New Form3
    Dim ItemsForm As New Form4
    Dim SuppliersForm As New Form5
    Dim VendorsForm As New Form6
    Dim TransactionsForm As New Form7
    Dim RegisterTicketsForm As New Form8
    Dim BankDepositsForm As New Form9
    Dim GeneralLedgerForm As New Form10
    Dim InventoryForm As New Form11
    Dim IReportsForm As New Form12
    Dim CommissionForm As New Form13

    'creating a reference to Form2
    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        EmployeesForm = New Form2
        EmployeesForm.Show()
        EmployeesForm.Activate()
    End Sub

    'Form3/CustomersForm Execution
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        CustomersForm = New Form3
        CustomersForm.Show()
        CustomersForm.Activate()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        ItemsForm = New Form4
        ItemsForm.Show()
        ItemsForm.Activate()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        SuppliersForm = New Form5
        SuppliersForm.Show()
        SuppliersForm.Activate()
    End Sub

    Private Sub btnVendors_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        VendorsForm = New Form6
        VendorsForm.Show()
        VendorsForm.Activate()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        TransactionsForm = New Form7
        TransactionsForm.Show()
        TransactionsForm.Activate()
    End Sub

    Private Sub btnRegisterTickets_Click(sender As Object, e As EventArgs) Handles btnRegisterTickets.Click
        RegisterTicketsForm = New Form8
        RegisterTicketsForm.Show()
        RegisterTicketsForm.Activate()
    End Sub

    Private Sub btnBankDeposits_Click(sender As Object, e As EventArgs) Handles btnBankDeposits.Click
        BankDepositsForm = New Form9
        BankDepositsForm.Show()
        BankDepositsForm.Activate()
    End Sub

    Private Sub btnGeneralLedgers_Click(sender As Object, e As EventArgs) Handles btnGeneralLedgers.Click
        GeneralLedgerForm = New Form10
        GeneralLedgerForm.Show()
        GeneralLedgerForm.Activate()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        InventoryForm = New Form11
        InventoryForm.Show()
        InventoryForm.Activate()
    End Sub

    Private Sub btnInventoryReports_Click(sender As Object, e As EventArgs) Handles btnInventoryReports.Click
        IReportsForm = New Form12
        IReportsForm.Show()
        IReportsForm.Activate()
    End Sub

    Private Sub btnCommission_Click(sender As Object, e As EventArgs) Handles btnCommission.Click
        CommissionForm = New Form13
        CommissionForm.Show()
        CommissionForm.Activate()
    End Sub
End Class
