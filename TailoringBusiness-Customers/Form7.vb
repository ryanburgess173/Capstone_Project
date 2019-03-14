Public Class Form7
    Private Sub TransactionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransactionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TailoringBusinessDataSet.Customers)
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.TailoringBusinessDataSet.Transactions)

    End Sub

    Private Sub Paid_with_CashLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuantityLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class