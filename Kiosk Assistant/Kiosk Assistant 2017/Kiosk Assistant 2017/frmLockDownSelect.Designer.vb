<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockDownSelect
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
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.btnbsetZamok1toLoad = New DevExpress.XtraEditors.TileItem()
        Me.btnSetZamok2toLoad = New DevExpress.XtraEditors.TileItem()
        Me.btnsetLAtoLoad = New DevExpress.XtraEditors.TileItem()
        Me.btnSelectCustomPath = New DevExpress.XtraEditors.TileItem()
        Me.SuspendLayout()
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
        Me.btnClose.Location = New System.Drawing.Point(0, 540)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(937, 70)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cancel"
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileControl1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileControl1.AppearanceText.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileControl1.AppearanceText.ForeColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceText.Options.UseFont = True
        Me.TileControl1.AppearanceText.Options.UseForeColor = True
        Me.TileControl1.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.background
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 4
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(18, 18, 18, 88)
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(937, 610)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "Select an application to lock down to"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.btnbsetZamok1toLoad)
        Me.TileGroup2.Items.Add(Me.btnSetZamok2toLoad)
        Me.TileGroup2.Items.Add(Me.btnsetLAtoLoad)
        Me.TileGroup2.Items.Add(Me.btnSelectCustomPath)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'btnbsetZamok1toLoad
        '
        Me.btnbsetZamok1toLoad.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbsetZamok1toLoad.AppearanceItem.Normal.Options.UseFont = True
        Me.btnbsetZamok1toLoad.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.bluie
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement1.Text = "Zamok 1"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnbsetZamok1toLoad.Elements.Add(TileItemElement1)
        Me.btnbsetZamok1toLoad.Id = 0
        Me.btnbsetZamok1toLoad.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnbsetZamok1toLoad.Name = "btnbsetZamok1toLoad"
        '
        'btnSetZamok2toLoad
        '
        Me.btnSetZamok2toLoad.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetZamok2toLoad.AppearanceItem.Normal.Options.UseFont = True
        Me.btnSetZamok2toLoad.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.orange
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement2.Text = "Zamok 2"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnSetZamok2toLoad.Elements.Add(TileItemElement2)
        Me.btnSetZamok2toLoad.Id = 1
        Me.btnSetZamok2toLoad.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnSetZamok2toLoad.Name = "btnSetZamok2toLoad"
        '
        'btnsetLAtoLoad
        '
        Me.btnsetLAtoLoad.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetLAtoLoad.AppearanceItem.Normal.Options.UseFont = True
        Me.btnsetLAtoLoad.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.purple
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement3.Text = "Lobby Attendant"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnsetLAtoLoad.Elements.Add(TileItemElement3)
        Me.btnsetLAtoLoad.Id = 2
        Me.btnsetLAtoLoad.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnsetLAtoLoad.Name = "btnsetLAtoLoad"
        '
        'btnSelectCustomPath
        '
        Me.btnSelectCustomPath.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectCustomPath.AppearanceItem.Normal.Options.UseFont = True
        Me.btnSelectCustomPath.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.fushiamotherfucker
        TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement4.Text = "Browse.."
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnSelectCustomPath.Elements.Add(TileItemElement4)
        Me.btnSelectCustomPath.Id = 3
        Me.btnSelectCustomPath.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnSelectCustomPath.Name = "btnSelectCustomPath"
        '
        'frmLockDownSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(937, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TileControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLockDownSelect"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnbsetZamok1toLoad As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnSetZamok2toLoad As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnsetLAtoLoad As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnSelectCustomPath As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
