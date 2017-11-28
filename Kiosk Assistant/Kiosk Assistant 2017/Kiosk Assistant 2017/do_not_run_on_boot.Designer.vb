<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class do_not_run_on_boot
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(do_not_run_on_boot))
        Dim TileItemElement22 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement23 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement24 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement25 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement26 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement27 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement28 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.btnRebootKiosk = New DevExpress.XtraEditors.TileItem()
        Me.btnClose = New DevExpress.XtraEditors.TileItem()
        Me.btnRemoveFromStartup = New DevExpress.XtraEditors.TileItem()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.btnReboot = New DevExpress.XtraEditors.TileItem()
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
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
        Me.TileItem1.BackgroundImage = CType(resources.GetObject("TileItem1.BackgroundImage"), System.Drawing.Image)
        TileItemElement22.Text = "Exit Kiosk Assistant"
        TileItemElement22.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        Me.TileItem1.Elements.Add(TileItemElement22)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem1.Name = "TileItem1"
        '
        'TileControl1
        '
        Me.TileControl1.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.background
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 7
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(1153, 628)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.btnRebootKiosk)
        Me.TileGroup3.Items.Add(Me.btnClose)
        Me.TileGroup3.Items.Add(Me.btnRemoveFromStartup)
        Me.TileGroup3.Items.Add(Me.TileItem2)
        Me.TileGroup3.Name = "TileGroup3"
        '
        'btnRebootKiosk
        '
        Me.btnRebootKiosk.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRebootKiosk.AppearanceItem.Normal.Options.UseFont = True
        Me.btnRebootKiosk.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.orange
        Me.btnRebootKiosk.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement23.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources.power_button_off
        TileItemElement23.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement23.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement23.Text = "Reboot Computer"
        TileItemElement23.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.btnRebootKiosk.Elements.Add(TileItemElement23)
        Me.btnRebootKiosk.Id = 6
        Me.btnRebootKiosk.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnRebootKiosk.Name = "btnRebootKiosk"
        '
        'btnClose
        '
        Me.btnClose.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.AppearanceItem.Normal.Options.UseFont = True
        Me.btnClose.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.red
        Me.btnClose.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement24.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources.emergency_exit
        TileItemElement24.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement24.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement24.Text = "Exit Kiosk Assistant"
        TileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.btnClose.Elements.Add(TileItemElement24)
        Me.btnClose.Id = 3
        Me.btnClose.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnClose.Name = "btnClose"
        '
        'btnRemoveFromStartup
        '
        Me.btnRemoveFromStartup.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFromStartup.AppearanceItem.Normal.Options.UseFont = True
        Me.btnRemoveFromStartup.BackgroundImage = CType(resources.GetObject("btnRemoveFromStartup.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoveFromStartup.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement25.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources.cancel_button
        TileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement25.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement25.Text = "Disable Assistant Autorun"
        TileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.btnRemoveFromStartup.Elements.Add(TileItemElement25)
        Me.btnRemoveFromStartup.Id = 2
        Me.btnRemoveFromStartup.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnRemoveFromStartup.Name = "btnRemoveFromStartup"
        '
        'TileItem2
        '
        Me.TileItem2.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem2.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem2.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.green
        Me.TileItem2.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
        TileItemElement26.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources.back__1_
        TileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement26.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale
        TileItemElement26.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement26.Text = "Return"
        TileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.TileItem2.Elements.Add(TileItemElement26)
        Me.TileItem2.Id = 4
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem3
        '
        Me.TileItem3.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem3.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem3.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.red
        TileItemElement27.Text = "Exit Kiosk Assistant"
        TileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TileItem3.Elements.Add(TileItemElement27)
        Me.TileItem3.Id = 3
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem3.Name = "TileItem3"
        '
        'btnReboot
        '
        Me.btnReboot.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReboot.AppearanceItem.Normal.Options.UseFont = True
        Me.btnReboot.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.orange
        TileItemElement28.Text = "Reboot kiosk"
        TileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.btnReboot.Elements.Add(TileItemElement28)
        Me.btnReboot.Id = 5
        Me.btnReboot.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.btnReboot.Name = "btnReboot"
        '
        'timer2
        '
        Me.timer2.Interval = 1000
        '
        'do_not_run_on_boot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.TileControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "do_not_run_on_boot"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnRemoveFromStartup As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnClose As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnReboot As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnRebootKiosk As DevExpress.XtraEditors.TileItem
    Friend WithEvents timer2 As Timer
End Class
