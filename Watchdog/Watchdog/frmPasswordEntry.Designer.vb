<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordEntry
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordEntry))
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.btnClose = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.btnSubmit = New DevExpress.XtraEditors.TileItem()
        Me.txtPasswordEntry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.BackgroundImage = Global.Watchdog.My.Resources.Resources.background
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 2
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(18, 150, 18, 18)
        Me.TileControl1.Size = New System.Drawing.Size(459, 402)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.btnClose)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'btnClose
        '
        Me.btnClose.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.AppearanceItem.Normal.Options.UseFont = True
        Me.btnClose.BackgroundImage = Global.Watchdog.My.Resources.Resources.red
        TileItemElement1.Text = "Cancel"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnClose.Elements.Add(TileItemElement1)
        Me.btnClose.Id = 0
        Me.btnClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btnClose.Name = "btnClose"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.btnSubmit)
        Me.TileGroup3.Name = "TileGroup3"
        '
        'btnSubmit
        '
        Me.btnSubmit.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.AppearanceItem.Normal.Options.UseFont = True
        Me.btnSubmit.BackgroundImage = Global.Watchdog.My.Resources.Resources.bluie
        TileItemElement2.Text = "Submit"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnSubmit.Elements.Add(TileItemElement2)
        Me.btnSubmit.Id = 1
        Me.btnSubmit.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.btnSubmit.Name = "btnSubmit"
        '
        'txtPasswordEntry
        '
        Me.txtPasswordEntry.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPasswordEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordEntry.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordEntry.Location = New System.Drawing.Point(12, 94)
        Me.txtPasswordEntry.Name = "txtPasswordEntry"
        Me.txtPasswordEntry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordEntry.Size = New System.Drawing.Size(427, 47)
        Me.txtPasswordEntry.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter your password"
        '
        'frmPasswordEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPasswordEntry)
        Me.Controls.Add(Me.TileControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPasswordEntry"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnClose As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnSubmit As DevExpress.XtraEditors.TileItem
    Friend WithEvents txtPasswordEntry As TextBox
    Friend WithEvents Label1 As Label
End Class
