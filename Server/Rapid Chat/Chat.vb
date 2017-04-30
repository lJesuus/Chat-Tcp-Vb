Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Net
Imports System
Imports System.Net.Dns
Imports System.Drawing.Bitmap
Imports CustomControls.IconComboBox
Imports UNOLibs.Net.ClientClass
Imports RapChatLib.RapChatLib

Public Class Chat

#Region "Declarations"

    Dim Receptor As New TcpListener(6950)
    Dim Receptor1 As New TcpListener(6960)
    Dim Cliente1 As TcpClient
    Dim Cliente As ClaseParaCliente
    Dim Lector As StreamReader
    Dim Allclient As TcpClient
    Dim ListaCliente As New List(Of ClaseParaCliente)
    Dim Mensaje As String = ""
    Dim IPAdd As String
    Dim clnt As New UNOLibs.Net.ClientClass
    Dim WithEvents server As UNOLibs.Net.ServerClass

#End Region

#Region "Form"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = My.Settings.WindowPosition
        Me.Size = My.Settings.WindowSize
        txtNombre.Text = My.Settings.Username

        server = New UNOLibs.Net.ServerClass(6960, True)
        Receptor = New TcpListener(IPAddress.Any, 6950)
        Receptor.Start()
        UpdateList("CHATACA ------ V3.2.3", False)
        Receptor.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Receptor)

        Dim shostname As String
        shostname = System.Net.Dns.GetHostName
        Console.WriteLine("Nombre del dispositivo = " & shostname)
        Console.WriteLine("Tu IP = " & GetIPAddress())
        NotifyIcon1.Visible = True
        Dim me1 As New IconComboItem
        Dim ico As New Icon(My.Application.Info.DirectoryPath & "\Users.ico")
        me1.DisplayText = GetIPAddress()
        me1.ItemImage = ico
        cmbIP.Items.Add(me1)
        My.Application.SaveMySettingsOnExit = True
        cmbIP.SelectedIndex = 0
    End Sub


    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim offlinestring As String = " Se ha desconectado. No se puede enviar mas mensajes a este usuario."
        If RichTextBox1.Text.Contains(offlinestring) Then
            End
        Else
            txtMensaje.Text = txtNombre.Text & " Se ha desconectado. No se puede enviar mas mensajes a este usuario."
            btnEnviar.PerformClick()

            My.Settings.WindowPosition = Me.Location
            My.Settings.WindowSize = Me.Size
            My.Settings.Username = txtNombre.Text
            My.Settings.Save()

        End If
        Receptor1.Stop()
    End Sub

#End Region

#Region "Funcionamiento"

    Public Shared Function GetIPAddress() As String
        Dim oIP As System.Net.IPAddress
        Dim sIP
        With System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            oIP = New System.Net.IPAddress(.AddressList(0).Address)
            sIP = oIP.ToString
        End With
        GetIPAddress = sIP
    End Function

    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As Boolean)
    Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else
            RichTextBox1.AppendText(str & vbNewLine)
            If relay Then send(str)
        End If
    End Sub

    Sub send(ByVal str As String)
        For x As Integer = 0 To ListaCliente.Count - 1
            Try
                ListaCliente(x).Send(str)
            Catch ex As Exception
                ListaCliente.RemoveAt(x)
            End Try
        Next
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        UpdateList(txtNombre.Text & " Dice:" & txtMensaje.Text, True)
        txtMensaje.Clear()
        Try
            Cliente1 = New TcpClient(cmbIP.Text, 6960)
            Dim Writer As New StreamWriter(Cliente1.GetStream())
            Writer.Write("</> " & txtNombre.Text & " Dice:" & txtMensaje.Text & " <\>")
            Writer.Flush()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub MessageReceived(ByVal str As String)
        UpdateList(str, True)
    End Sub

    Private Sub txtMensaje_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtMensaje.KeyDown
        If txtMensaje.Text <> "" Then
            btnBorrar.Enabled = True
            btnEnviar.Enabled = True
        Else
            btnBorrar.Enabled = False
            btnEnviar.Enabled = False
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateList(txtNombre.Text & " Dice:" & txtMensaje.Text, True)
            txtMensaje.Clear()
        End If
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        If cmbIP.Text.Length < 4 Then
            MessageBox.Show("Por favor ingrese una IP Valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            btnConectar.Text = "Conectando"
            Dim pingresult As String = My.Computer.Network.Ping(cmbIP.Text)
            If pingresult = "True" Then
                btnConectar.Text = "Conectado"
            Else
                btnConectar.Text = "Desconectado"
            End If
        End If
    End Sub

    Sub AcceptClient(ByVal ar As IAsyncResult)
        Cliente = New ClaseParaCliente(Receptor.EndAcceptTcpClient(ar))
        AddHandler (Cliente.getMessage), AddressOf MessageReceived
        AddHandler (Cliente.clientLogout), AddressOf ClientExited
        ListaCliente.Add(Cliente)
        UpdateList("Un usuario se conectó", True)
        Receptor.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Receptor)
    End Sub

    Private Sub cmbIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIP.TextChanged
        btnConectar.Text = "Conectar"
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        txtMensaje.Text = ""
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Me.Text = ("Chat - " & txtNombre.Text)
    End Sub

    Private Sub ConectarAPuertoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConectarAPuertoToolStripMenuItem.Click
        frmNewAddress.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()

        If DialogResult.OK Then
            RichTextBox1.Text += (txtNombre.Text & " Se esta en enviando un archivo...") + vbCrLf
            clnt.SendFiles(cmbIP.Text, 6960, OpenFileDialog1.FileNames)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub CualEsMiIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CualEsMiIPToolStripMenuItem.Click
        IP.Show()
    End Sub

    Sub ClientExited(ByVal client As ClaseParaCliente)
        ListaCliente.Remove(client)
        UpdateList("Un usuario se desconectó", True)
    End Sub

    Private Sub _Load() Handles MyBase.Load
        Timer1.Start()
        Receptor1.Start()
    End Sub

    Private Sub _Tick() Handles Timer1.Tick
        Dim nStart As Integer
        Dim nLast As Integer

        If Receptor.Pending = True Then
            Cliente1 = Receptor1.AcceptTcpClient()
            Dim Reader As New StreamReader(Cliente1.GetStream())

            While Reader.Peek > -1
                Mensaje &= Convert.ToChar(Reader.Read()).ToString
            End While

            If Mensaje.Contains("</>") Then
                nStart = InStr(Mensaje, "</>") + 4
                nLast = InStr(Mensaje, "<\>")
                Mensaje = Mid(Mensaje, nStart, nLast - nStart)
            End If
        End If
    End Sub

#End Region
End Class
