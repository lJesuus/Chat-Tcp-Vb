Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System
Imports System.Net
Imports System.Net.Dns
Imports System.Drawing.Bitmap
Imports CustomControls.IconComboBox
Imports UNOLibs.Net.ClientClass
Imports RapChatLib.RapChatLib

Public Class Chat

#Region "Declarations"

    Dim Receptor As New TcpListener(6960)
    Dim Cliente As New TcpClient
    Dim Mensaje As String = ""
    Dim IPAdd As String
    Dim sWriter As StreamWriter
    Dim clnt As New UNOLibs.Net.ClientClass
    Dim WithEvents server As UNOLibs.Net.ServerClass

#End Region

#Region "Form"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = My.Settings.WindowPosition
        Me.Size = My.Settings.WindowSize
        txtNombre.Text = My.Settings.Username

        server = New UNOLibs.Net.ServerClass(6960, True)

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
            Receptor.Stop()
        End If
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

    Delegate Sub _xUpdate(ByVal str As String)
    Sub xUpdate(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            RichTextBox1.AppendText(str & vbNewLine)
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(Cliente.GetStream).ReadLine)
            Cliente.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        Catch ex As Exception
            xUpdate("Te has desconectado del servidor")
            Exit Sub
        End Try
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(Cliente.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("No estas conectado con alguien")
        End Try
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If txtNombre.Text = "" Or cmbIP.Text = "" Then
            MessageBox.Show("El nombre de usario esta vacio", "Error al enviar el mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                send(txtNombre.Text & " Dice: " & txtMensaje.Text)
                txtMensaje.Clear()
            Catch ex As Exception
                Console.WriteLine(ex)
                Dim Errorresult As String = ex.Message
                MessageBox.Show(Errorresult & vbCrLf & vbCrLf & "Por favor revise la IP", "Error al enviar el mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                Cliente = New TcpClient(cmbIP.Text, 6950)
                Dim Writer As New StreamWriter(Cliente.GetStream())
                Writer.Write("</> " & txtNombre.Text & " Dice: " & txtMensaje.Text & " <\>")
                Writer.Flush()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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
            send(txtNombre.Text & " Dice : " & txtMensaje.Text)
            txtMensaje.Clear()
        End If
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        If cmbIP.Text.Length < 4 Then
            MessageBox.Show("Por favor ingrese una IP Valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If btnConectar.Text = "Conectar" Then
                Try
                    Cliente = New TcpClient(cmbIP.Text, CInt(TextBox2.Text))
                    Cliente.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                    Button1.Text = "Desconectar"
                Catch ex As Exception
                    xUpdate("No se puede conectar con el usuario")
                End Try
            Else
                Cliente.Client.Close()
                Cliente = Nothing
                Button1.Text = "Conectar"
            End If
        End If

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
            RichTextBox1.Text += (txtNombre.Text & " Is Sending You a File...") + vbCrLf
            clnt.SendFiles(cmbIP.Text, 6950, OpenFileDialog1.FileNames)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub CualEsMiIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CualEsMiIPToolStripMenuItem.Click
        IP.Show()
    End Sub

    Private Sub _Load() Handles MyBase.Load
        Timer1.Start()
        Receptor.Start()
    End Sub

    Private Sub _Tick() Handles Timer1.Tick
        Dim nStart As Integer
        Dim nLast As Integer

        If Receptor.Pending = True Then
            Cliente = Receptor.AcceptTcpClient()
            Dim Reader As New StreamReader(Cliente.GetStream())

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
