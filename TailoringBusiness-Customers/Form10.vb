Public Class Form10
    Private Sub General_LedgersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles General_LedgersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.General_LedgersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.General_Ledgers' table. You can move, or remove it, as needed.
        Me.General_LedgersTableAdapter.Fill(Me.TailoringBusinessDataSet.General_Ledgers)

    End Sub
End Class