<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.btnInitateexit = New DevExpress.XtraEditors.TileItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'TileControl1
        '
        Me.TileControl1.BackColor = System.Drawing.Color.Transparent
        Me.TileControl1.BackgroundImage = Global.Watchdog.My.Resources.Resources.background
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.ItemBackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.StretchHorizontal
        Me.TileControl1.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 2
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(815, 566)
        Me.TileControl1.TabIndex = 3
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem1.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.TileItem1.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TileItem1.BackgroundImage = Global.Watchdog.My.Resources.Resources.red
        TileItemElement1.Image = Global.Watchdog.My.Resources.Resources.smallexitimg
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None
        TileItemElement1.Text = "Exit Uncrashable"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.TileItem1.Elements.Add(TileItemElement1)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem1.Name = "TileItem1"
        '
        'btnInitateexit
        '
        Me.btnInitateexit.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInitateexit.AppearanceItem.Normal.Options.UseFont = True
        Me.btnInitateexit.BackgroundImage = Global.Watchdog.My.Resources.Resources.red
        TileItemElement2.Text = "Exit Kiosk Defender"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnInitateexit.Elements.Add(TileItemElement2)
        Me.btnInitateexit.Id = 0
        Me.btnInitateexit.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnInitateexit.Name = "btnInitateexit"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(815, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.TileControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInitateexit As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Public WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
