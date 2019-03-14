Public Class Form6
    Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.TailoringBusinessDataSet.Vendors)

    End Sub
End Class