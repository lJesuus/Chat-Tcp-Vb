<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAddress
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cancelar = New Glass.GlassButton
        Me.btnAñadir = New Glass.GlassButton
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.btnAñadir)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese la Direccion IP"
        '
        'Cancelar
        '
        Me.Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancelar.BackColor = System.Drawing.Color.LightGray
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.ForeColor = System.Drawing.Color.Black
        Me.Cancelar.GlowColor = System.Drawing.Color.Red
        Me.Cancelar.Location = New System.Drawing.Point(88, 42)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(60, 23)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        '
        'btnAñadir
        '
        Me.btnAñadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAñadir.BackColor = System.Drawing.Color.LightGray
        Me.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadir.ForeColor = System.Drawing.Color.Black
        Me.btnAñadir.GlowColor = System.Drawing.Color.Gold
        Me.btnAñadir.Location = New System.Drawing.Point(154, 42)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(60, 23)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir"
        '
        'txtIP
        '
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtIP.Location = New System.Drawing.Point(3, 16)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(211, 20)
        Me.txtIP.TabIndex = 0
        '
        'frmNewAddress
        '
        Me.AcceptButton = Me.btnAñadir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(217, 73)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewAddress"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Direccion IP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents btnAñadir As Glass.GlassButton
    Friend WithEvents Cancelar As Glass.GlassButton
End Class
