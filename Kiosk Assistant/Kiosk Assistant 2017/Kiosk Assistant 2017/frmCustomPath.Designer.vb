<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomPath
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
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPasswordEntry = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.background
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 2
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(18, 150, 18, 18)
        Me.TileControl1.Size = New System.Drawing.Size(752, 408)
        Me.TileControl1.TabIndex = 1
        Me.TileControl1.Text = "TileControl1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a program"
        '
        'txtPasswordEntry
        '
        Me.txtPasswordEntry.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPasswordEntry.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordEntry.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordEntry.Location = New System.Drawing.Point(20, 82)
        Me.txtPasswordEntry.Name = "txtPasswordEntry"
        Me.txtPasswordEntry.Size = New System.Drawing.Size(720, 43)
        Me.txtPasswordEntry.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(505, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Browse..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(20, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 94)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.BackgroundImage = Global.Kiosk_Assistant_2017.My.Resources.Resources.bluie
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(505, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 94)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Accept"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmCustomPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPasswordEntry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TileControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomPath"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswordEntry As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
