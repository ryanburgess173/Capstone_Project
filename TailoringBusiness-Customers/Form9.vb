Public Class Form9
    Private Sub Bank_DepositsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Bank_DepositsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Bank_DepositsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Bank_Deposits' table. You can move, or remove it, as needed.
        Me.Bank_DepositsTableAdapter.Fill(Me.TailoringBusinessDataSet.Bank_Deposits)

    End Sub
End Class