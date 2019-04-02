''' <summary>
''' 
''' Johnathan R. Burgess
''' CSC-289 Programming Capstone Project
''' Customer Management System
''' 
''' </summary>
Public Class Form1
    Dim CustomersView As New Form2
    Dim CustomersEdit As New Form3
    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        CustomersView = New Form2
        CustomersView.Show()
        CustomersView.Activate()
    End Sub

    Private Sub ViewCustomerDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomerDataToolStripMenuItem.Click
        CustomersView = New Form2
        CustomersView.Show()
        CustomersView.Activate()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Johnathan R. Burgess. For comments, questions, and/or concerns, you can reach me at ryanburgess173@outlook.com", MsgBoxStyle.OkOnly, "About this Application")
    End Sub

    Private Sub btnAddRemove_Click(sender As Object, e As EventArgs) Handles btnAddRemove.Click
        CustomersEdit = New Form3
        CustomersEdit.Show()
        CustomersEdit.Activate()
    End Sub

    Private Sub EditCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerToolStripMenuItem.Click
        CustomersEdit = New Form3
        CustomersEdit.Show()
        CustomersEdit.Activate()
    End Sub
End Class
