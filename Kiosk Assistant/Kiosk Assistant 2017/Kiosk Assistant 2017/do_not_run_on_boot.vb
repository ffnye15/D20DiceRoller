
Public Class do_not_run_on_boot
    Private Sub do_not_run_on_boot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display stuff
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnRemoveFromStartup_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnRemoveFromStartup.ItemClick
        Dim result As Integer = MessageBox.Show("You will have to manually add Kiosk Assistant back to the startup folder if you do this. Are you sure?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            'check for file location
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + btnassistantautostartpathtarget) Then
                timer2.Start()
                frmWait.Show()

                Try
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\" + btnassistantautostartpathtarget)
                Catch
                End Try

            Else
                MsgBox("Kiosk Assistant has already been removed from your startup directory")
            End If
        End If
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnClose.ItemClick
        'reeeeaaalll complicated 
        End
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        'reeeeaaalll complicated 
        Me.Close()
    End Sub

    Private Sub btnRebootKiosk_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnRebootKiosk.ItemClick
        'reboots computer with confirmation
        Dim result As Integer = MessageBox.Show("Are you sure?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            System.Diagnostics.Process.Start("shutdown", "-r -t 00")
        Else
        End If
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        frmWait.Close()
        timer2.Stop()
    End Sub
End Class