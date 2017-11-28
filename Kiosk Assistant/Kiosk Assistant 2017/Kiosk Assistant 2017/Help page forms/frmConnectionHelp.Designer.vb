<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionHelp
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(770, 535)
        Me.WebBrowser1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Appearance.Options.UseForeColor = True
        Me.btnClose.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.red
        Me.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.Location = New System.Drawing.Point(0, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(770, 70)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close this window"
        '
        'frmConnectionHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.WebBrowser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnectionHelp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
