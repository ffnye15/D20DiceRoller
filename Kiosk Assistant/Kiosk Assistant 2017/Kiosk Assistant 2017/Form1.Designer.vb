<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.btnCalibrate = New DevExpress.XtraEditors.TileItem()
        Me.btnConfiguration = New DevExpress.XtraEditors.TileItem()
        Me.btnOFFSecure = New DevExpress.XtraEditors.TileItem()
        Me.btnInternet = New DevExpress.XtraEditors.TileItem()
        Me.btnCredentials = New DevExpress.XtraEditors.TileItem()
        Me.btnONSecure = New DevExpress.XtraEditors.TileItem()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.TileControl1.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.TileControl1.AppearanceText.Font = New System.Drawing.Font("Segoe UI Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileControl1.AppearanceText.ForeColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceText.Options.UseFont = True
        Me.TileControl1.AppearanceText.Options.UseForeColor = True
        Me.TileControl1.AppearanceText.Options.UseTextOptions = True
        Me.TileControl1.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.TileControl1.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.background
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 11
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(18, 18, 18, 88)
        Me.TileControl1.SelectionColor = System.Drawing.Color.Maroon
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(1073, 696)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "Welcome to the Kiosk Assistant"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.btnCalibrate)
        Me.TileGroup2.Items.Add(Me.btnConfiguration)
        Me.TileGroup2.Items.Add(Me.btnOFFSecure)
        Me.TileGroup2.Items.Add(Me.btnInternet)
        Me.TileGroup2.Items.Add(Me.btnCredentials)
        Me.TileGroup2.Items.Add(Me.btnONSecure)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'btnCalibrate
        '
        Me.btnCalibrate.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalibrate.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnCalibrate.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnCalibrate.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalibrate.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnCalibrate.AppearanceItem.Normal.Options.UseFont = True
        Me.btnCalibrate.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnCalibrate.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCalibrate.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalibrate.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnCalibrate.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnCalibrate.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnCalibrate.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnCalibrate.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.bluie
        Me.btnCalibrate.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement1.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources._006_computer1
        TileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement1.ImageToTextIndent = 18
        TileItemElement1.Text = "Help me calibrate my touchscreen"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnCalibrate.Elements.Add(TileItemElement1)
        Me.btnCalibrate.Id = 0
        Me.btnCalibrate.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnCalibrate.Name = "btnCalibrate"
        '
        'btnConfiguration
        '
        Me.btnConfiguration.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguration.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnConfiguration.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguration.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguration.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnConfiguration.AppearanceItem.Normal.Options.UseFont = True
        Me.btnConfiguration.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnConfiguration.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnConfiguration.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguration.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnConfiguration.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnConfiguration.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnConfiguration.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnConfiguration.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.fushiamotherfucker
        Me.btnConfiguration.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement2.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources._003_three1
        TileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement2.ImageToTextIndent = 18
        TileItemElement2.Text = "I need help configuring my software"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnConfiguration.Elements.Add(TileItemElement2)
        Me.btnConfiguration.Id = 2
        Me.btnConfiguration.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnConfiguration.Name = "btnConfiguration"
        '
        'btnOFFSecure
        '
        Me.btnOFFSecure.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOFFSecure.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnOFFSecure.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnOFFSecure.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOFFSecure.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnOFFSecure.AppearanceItem.Normal.Options.UseFont = True
        Me.btnOFFSecure.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnOFFSecure.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnOFFSecure.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOFFSecure.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnOFFSecure.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnOFFSecure.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnOFFSecure.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnOFFSecure.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.darkerblue
        Me.btnOFFSecure.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement3.ImageToTextIndent = 18
        TileItemElement3.Text = "I want to disable the secure kiosk account"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnOFFSecure.Elements.Add(TileItemElement3)
        Me.btnOFFSecure.Id = 9
        Me.btnOFFSecure.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnOFFSecure.Name = "btnOFFSecure"
        '
        'btnInternet
        '
        Me.btnInternet.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternet.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnInternet.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnInternet.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternet.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnInternet.AppearanceItem.Normal.Options.UseFont = True
        Me.btnInternet.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnInternet.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnInternet.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternet.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnInternet.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnInternet.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnInternet.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnInternet.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.orange
        Me.btnInternet.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement4.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources._005_connection1
        TileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement4.ImageToTextIndent = 18
        TileItemElement4.Text = "Help me connect to the internet"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnInternet.Elements.Add(TileItemElement4)
        Me.btnInternet.Id = 6
        Me.btnInternet.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnInternet.Name = "btnInternet"
        '
        'btnCredentials
        '
        Me.btnCredentials.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredentials.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnCredentials.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnCredentials.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredentials.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnCredentials.AppearanceItem.Normal.Options.UseFont = True
        Me.btnCredentials.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnCredentials.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCredentials.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredentials.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnCredentials.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnCredentials.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnCredentials.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnCredentials.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.purple
        Me.btnCredentials.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement5.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources._004_key1
        TileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement5.ImageToTextIndent = 18
        TileItemElement5.Text = "I need my  log in credentials"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnCredentials.Elements.Add(TileItemElement5)
        Me.btnCredentials.Id = 8
        Me.btnCredentials.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnCredentials.Name = "btnCredentials"
        '
        'btnONSecure
        '
        Me.btnONSecure.AppearanceItem.Hovered.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnONSecure.AppearanceItem.Hovered.Options.UseFont = True
        Me.btnONSecure.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent
        Me.btnONSecure.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnONSecure.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btnONSecure.AppearanceItem.Normal.Options.UseFont = True
        Me.btnONSecure.AppearanceItem.Normal.Options.UseTextOptions = True
        Me.btnONSecure.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnONSecure.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI Light", 34.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnONSecure.AppearanceItem.Pressed.FontSizeDelta = 2
        Me.btnONSecure.AppearanceItem.Pressed.ForeColor = System.Drawing.Color.Silver
        Me.btnONSecure.AppearanceItem.Pressed.Options.UseFont = True
        Me.btnONSecure.AppearanceItem.Pressed.Options.UseForeColor = True
        Me.btnONSecure.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.green
        Me.btnONSecure.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
        TileItemElement6.Image = Global.Kiosk_Assistant_2017.My.Resources.Resources._002_security1
        TileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right
        TileItemElement6.ImageToTextIndent = 18
        TileItemElement6.Text = "I want to enable the secure kiosk account"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.btnONSecure.Elements.Add(TileItemElement6)
        Me.btnONSecure.Id = 7
        Me.btnONSecure.ItemSize = DevExpress.XtraEditors.TileItemSize.Small
        Me.btnONSecure.Name = "btnONSecure"
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
        Me.btnClose.Location = New System.Drawing.Point(0, 626)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(1073, 70)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close Kiosk Assistant"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1073, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TileControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents btnCalibrate As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnConfiguration As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnInternet As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnONSecure As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnCredentials As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnOFFSecure As DevExpress.XtraEditors.TileItem
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As Timer
End Class
