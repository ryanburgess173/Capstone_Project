Public Class Form8
    Private Sub Register_TicketsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Register_TicketsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Register_TicketsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Register_Tickets' table. You can move, or remove it, as needed.
        Me.Register_TicketsTableAdapter.Fill(Me.TailoringBusinessDataSet.Register_Tickets)

    End Sub
End Class