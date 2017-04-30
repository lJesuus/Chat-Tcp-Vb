<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnConectar = New Glass.GlassButton
        Me.cmbIP = New CustomControls.IconComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtMensaje = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.fntFont = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnEnviar = New Glass.GlassButton
        Me.btnBorrar = New Glass.GlassButton
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.clrFont = New System.Windows.Forms.ColorDialog
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnImage = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConexionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConectarAServidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConectarAPuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CualEsMiIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnConectar)
        Me.GroupBox1.Controls.Add(Me.cmbIP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 147)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Puerto"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Enviar Archivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConectar.BackColor = System.Drawing.Color.LightGray
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.ForeColor = System.Drawing.Color.Black
        Me.btnConectar.GlowColor = System.Drawing.Color.Gold
        Me.btnConectar.Location = New System.Drawing.Point(129, 16)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(93, 23)
        Me.btnConectar.TabIndex = 6
        Me.btnConectar.Text = "Conectar"
        Me.ToolTip2.SetToolTip(Me.btnConectar, "Test Connection to Client Address")
        '
        'cmbIP
        '
        Me.cmbIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbIP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbIP.FormattingEnabled = True
        Me.cmbIP.ItemHeight = 16
        Me.cmbIP.Location = New System.Drawing.Point(6, 17)
        Me.cmbIP.Name = "cmbIP"
        Me.cmbIP.SelectedItem = Nothing
        Me.cmbIP.Size = New System.Drawing.Size(120, 22)
        Me.cmbIP.TabIndex = 5
        Me.cmbIP.ToolTipText = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre de Usuario:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(6, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(144, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.Location = New System.Drawing.Point(15, 413)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(258, 48)
        Me.txtMensaje.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Rapid Chat"
        Me.NotifyIcon1.Visible = True
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        Me.ofdImage.Filter = "Bitmap Images (*.bmp)|*.bmp*"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Rapid Chat"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Send Files"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.BackColor = System.Drawing.Color.LightGray
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.GlowColor = System.Drawing.Color.DodgerBlue
        Me.btnEnviar.Location = New System.Drawing.Point(276, 413)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(53, 23)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Enviar"
        Me.ToolTip2.SetToolTip(Me.btnEnviar, "Send Message to Client")
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.BackColor = System.Drawing.Color.LightGray
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.GlowColor = System.Drawing.Color.Red
        Me.btnBorrar.Location = New System.Drawing.Point(276, 435)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(53, 24)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.Text = "Borrar"
        Me.ToolTip2.SetToolTip(Me.btnBorrar, "Clear Text from Message Box")
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "Rapid Chat"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 72)
        Me.TextBox1.MaxLength = 88888
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(6, 69)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(75, 23)
        Me.btnImage.TabIndex = 4
        Me.btnImage.Text = "Button3"
        Me.btnImage.UseVisualStyleBackColor = True
        Me.btnImage.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(311, 208)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.btnImage)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 227)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mensajes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(341, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConexionesToolStripMenuItem
        '
        Me.ConexionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarAServidorToolStripMenuItem, Me.ConectarAPuertoToolStripMenuItem, Me.CualEsMiIPToolStripMenuItem})
        Me.ConexionesToolStripMenuItem.Name = "ConexionesToolStripMenuItem"
        Me.ConexionesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ConexionesToolStripMenuItem.Text = "Conexiones"
        '
        'ConectarAServidorToolStripMenuItem
        '
        Me.ConectarAServidorToolStripMenuItem.Name = "ConectarAServidorToolStripMenuItem"
        Me.ConectarAServidorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConectarAServidorToolStripMenuItem.Text = "Conectar a Servidor"
        '
        'ConectarAPuertoToolStripMenuItem
        '
        Me.ConectarAPuertoToolStripMenuItem.Name = "ConectarAPuertoToolStripMenuItem"
        Me.ConectarAPuertoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConectarAPuertoToolStripMenuItem.Text = "Conectar a Usuario"
        '
        'CualEsMiIPToolStripMenuItem
        '
        Me.CualEsMiIPToolStripMenuItem.Name = "CualEsMiIPToolStripMenuItem"
        Me.CualEsMiIPToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CualEsMiIPToolStripMenuItem.Text = "Cual es mi IP"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(11, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(90, 147)
        Me.Panel1.TabIndex = 7
        '
        'Chat
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(349, 505)
        Me.Name = "Chat"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents cmbIP As CustomControls.IconComboBox
    Friend WithEvents btnConectar As Glass.GlassButton
    Friend WithEvents fntFont As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnEnviar As Glass.GlassButton
    Friend WithEvents btnBorrar As Glass.GlassButton
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents clrFont As System.Windows.Forms.ColorDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConexionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarAServidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarAPuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CualEsMiIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
