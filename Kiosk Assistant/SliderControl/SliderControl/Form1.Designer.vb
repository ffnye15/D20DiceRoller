<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.btnf9 = New DevExpress.XtraEditors.TileItem()
        Me.btnf10 = New DevExpress.XtraEditors.TileItem()
        Me.btnf11 = New DevExpress.XtraEditors.TileItem()
        Me.btnf12 = New DevExpress.XtraEditors.TileItem()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 6
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(838, 496)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.btnf9)
        Me.TileGroup2.Items.Add(Me.btnf10)
        Me.TileGroup2.Items.Add(Me.btnf11)
        Me.TileGroup2.Items.Add(Me.btnf12)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'btnf9
        '
        Me.btnf9.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnf9.AppearanceItem.Normal.Options.UseFont = True
        Me.btnf9.BackgroundImage = CType(resources.GetObject("btnf9.BackgroundImage"), System.Drawing.Image)
        Me.btnf9.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement1.Text = "Landing Gear"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnf9.Elements.Add(TileItemElement1)
        Me.btnf9.Id = 0
        Me.btnf9.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnf9.Name = "btnf9"
        '
        'btnf10
        '
        Me.btnf10.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnf10.AppearanceItem.Normal.Options.UseFont = True
        Me.btnf10.BackgroundImage = CType(resources.GetObject("btnf10.BackgroundImage"), System.Drawing.Image)
        Me.btnf10.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement2.Text = "Ship Lights"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnf10.Elements.Add(TileItemElement2)
        Me.btnf10.Id = 1
        Me.btnf10.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnf10.Name = "btnf10"
        '
        'btnf11
        '
        Me.btnf11.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnf11.AppearanceItem.Normal.Options.UseFont = True
        Me.btnf11.BackgroundImage = CType(resources.GetObject("btnf11.BackgroundImage"), System.Drawing.Image)
        Me.btnf11.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement3.Text = "High Wake"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnf11.Elements.Add(TileItemElement3)
        Me.btnf11.Id = 2
        Me.btnf11.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnf11.Name = "btnf11"
        '
        'btnf12
        '
        Me.btnf12.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnf12.AppearanceItem.Normal.Options.UseFont = True
        Me.btnf12.BackgroundImage = CType(resources.GetObject("btnf12.BackgroundImage"), System.Drawing.Image)
        Me.btnf12.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement4.Text = "Low Wake"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnf12.Elements.Add(TileItemElement4)
        Me.btnf12.Id = 3
        Me.btnf12.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnf12.Name = "btnf12"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(838, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.TileControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnf9 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnf10 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnf11 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnf12 As DevExpress.XtraEditors.TileItem
End Class
