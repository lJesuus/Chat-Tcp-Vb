Imports CustomControls.IconComboBox

Public Class frmNewAddress

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click
        Dim NewAdd As New IconComboItem
        Dim ico As New Icon(My.Application.Info.DirectoryPath & "\Users.ico")
        NewAdd.DisplayText = txtIP.Text
        NewAdd.ItemImage = ico
        Chat.cmbIP.Items.Add(NewAdd)
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class