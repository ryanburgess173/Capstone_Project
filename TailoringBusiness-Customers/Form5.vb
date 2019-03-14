Public Class Form5
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet1.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.TailoringBusinessDataSet1.Items)
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.TailoringBusinessDataSet.Suppliers)

    End Sub

    Private Sub btnFillFinal_Click(sender As Object, e As EventArgs) Handles btnFillFinal.Click
        FinalTextBox.Text = Convert.ToDouble(PriceTextBox.Text) - (Convert.ToDouble(PriceTextBox.Text) * (Convert.ToDouble(Discount__TextBox.Text) / 100))
    End Sub
End Class