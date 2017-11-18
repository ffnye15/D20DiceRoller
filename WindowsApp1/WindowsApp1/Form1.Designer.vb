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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYourRoll = New System.Windows.Forms.TextBox()
        Me.txtEnemyRoll = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Roll"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enemy's Roll"
        '
        'txtYourRoll
        '
        Me.txtYourRoll.Location = New System.Drawing.Point(113, 28)
        Me.txtYourRoll.Name = "txtYourRoll"
        Me.txtYourRoll.Size = New System.Drawing.Size(58, 20)
        Me.txtYourRoll.TabIndex = 3
        '
        'txtEnemyRoll
        '
        Me.txtEnemyRoll.Location = New System.Drawing.Point(113, 61)
        Me.txtEnemyRoll.Name = "txtEnemyRoll"
        Me.txtEnemyRoll.Size = New System.Drawing.Size(58, 20)
        Me.txtEnemyRoll.TabIndex = 4
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(113, 91)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(175, 20)
        Me.txtResults.TabIndex = 5
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(12, 129)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(135, 62)
        Me.btnRoll.TabIndex = 6
        Me.btnRoll.Text = "Roll the Dice!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(153, 129)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 62)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 206)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtEnemyRoll)
        Me.Controls.Add(Me.txtYourRoll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYourRoll As TextBox
    Friend WithEvents txtEnemyRoll As TextBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label3 As Label
End Class
