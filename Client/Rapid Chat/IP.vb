Public Class IP

    Private Sub frmIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIP.Text = Chat.GetIPAddress
        lblConnection.Text = My.Computer.Network.IsAvailable
    End Sub

End Class