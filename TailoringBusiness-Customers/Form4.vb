Public Class Form4
    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.TailoringBusinessDataSet.Items)

    End Sub
End Class