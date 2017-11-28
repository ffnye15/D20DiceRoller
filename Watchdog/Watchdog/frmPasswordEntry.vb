Public Class frmPasswordEntry

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnClose.ItemClick
        'closes password entry window and restarts the timers
        Me.Close()
        Form1.Show()
        Form1.Timer2.Start()
    End Sub
    Public Sub runcheck()

        'compares entered value against hardcoded password
        If txtPasswordEntry.Text = "advancedkiosks" Then
            moduleLoginChecker.killwatchdog()
        Else
            MsgBox("Password entry failed")
            moduleLoginChecker.passfailed()
        End If
    End Sub

    Public Sub submitbtnclick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSubmit.ItemClick
        'runs runcheck on button press
        runcheck()
    End Sub

    Private Sub password_entry_press_enter_key(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasswordEntry.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            'runs runcheck on enter key
            runcheck()
        End If

    End Sub

    Private Sub frmPasswordEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets textbox as default focus on load
        txtPasswordEntry.Select()
    End Sub


End Class