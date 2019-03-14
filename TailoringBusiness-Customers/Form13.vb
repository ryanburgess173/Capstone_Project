Public Class Form13
    Private Sub CommissionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CommissionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Commission' table. You can move, or remove it, as needed.
        Me.CommissionTableAdapter.Fill(Me.TailoringBusinessDataSet.Commission)

    End Sub
End Class