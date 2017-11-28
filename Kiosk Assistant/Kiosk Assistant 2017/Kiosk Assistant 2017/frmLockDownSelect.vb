Imports System.IO, System.Net, MadMilkman.Ini
Public Class frmLockDownSelect

    ''' <summary>
    ''' This form is for the user to select the application they want to lock the kiosk down to. The Zamok1 button is commented, and the others are not. They are essentially a copy past job. 
    ''' I didn't bother to make it its own routine to pass variables to. Too much to fuck up.
    ''' </summary>

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmlockdownselect_onload(sender As Object, e As EventArgs) Handles MyBase.Load
        'load event that sets the visual and layout of page
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnbsetZamok1toLoad_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnbsetZamok1toLoad.ItemClick
        'button event for choosing Zamok 1
        'runs the importer module
        ini_importer_module.iniimporter()
        'note the path of the INI is hardcoded
        Dim inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"
        Dim iniFile As New IniFile()
        Dim result As Integer = MessageBox.Show("This will lock your kiosk down to Zamok 1. Do you wish to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            'tries to delete the existing INI file, because we're going to replace it with a new copy at the end of this routine
            Try
                File.Delete(inipath)
            Catch ex As Exception
                MsgBox("deletion failed. you should not see this message")
            End Try
            'adds temp data to the new INI that we're going to create. Note that the watchdog path is pulled from the a variable, but the process check name is static right now. 
            'I may change it, but I'm lazy.
            iniFile.Sections.Add(
                        New IniSection(iniFile, "program_variables",
                            New IniKey(iniFile, "ini_assistantautostartpath", btnassistantautostartpathtarget),
                            New IniKey(iniFile, "ini_touchscreenconfig", btntouchscreentarget),
                            New IniKey(iniFile, "ini_internethelppath", btnInternettarget),
                            New IniKey(iniFile, "ini_confighelpath", btnconfigtarget),
                            New IniKey(iniFile, "ini_loginhelppath", btnloginhelptarget)))
            iniFile.Sections.Add(
                        New IniSection(iniFile, "watchdog_variables",
                            New IniKey(iniFile, "ini_z1path", zamok1pathttarget),
                            New IniKey(iniFile, "ini_z2path", zamok2pathttarget),
                            New IniKey(iniFile, "ini_lapath", LApathttarget),
                            New IniKey(iniFile, "ini_watchdogexe_path", zamok1pathttarget),
                            New IniKey(iniFile, "ini_processname", "zamok.browser")))
            iniFile.Save(inipath)
            MsgBox("This kiosk has been locked down. Please restart kiosk to boot into the applicaiton")
            Me.Close()
        End If
    End Sub

    Private Sub btnsetLAtoLoad_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnsetLAtoLoad.ItemClick
        Dim inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"
        Dim iniFile As New IniFile()
        Dim result As Integer = MessageBox.Show("This will lock your kiosk down to the Lobby Attendant Suite. Do you want to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then

            File.Delete(inipath)
            iniFile.Sections.Add(
                        New IniSection(iniFile, "program_variables",
                            New IniKey(iniFile, "ini_assistantautostartpath", btnassistantautostartpathtarget),
                            New IniKey(iniFile, "ini_touchscreenconfig", btntouchscreentarget),
                            New IniKey(iniFile, "ini_internethelppath", btnInternettarget),
                            New IniKey(iniFile, "ini_confighelpath", btnconfigtarget),
                            New IniKey(iniFile, "ini_loginhelppath", btnloginhelptarget)))
            iniFile.Sections.Add(
                        New IniSection(iniFile, "watchdog_variables",
                            New IniKey(iniFile, "ini_z1path", zamok1pathttarget),
                            New IniKey(iniFile, "ini_z2path", zamok2pathttarget),
                            New IniKey(iniFile, "ini_lapath", LApathttarget),
                            New IniKey(iniFile, "ini_watchdogexe_path", LApathttarget),
                            New IniKey(iniFile, "ini_processname", "LAPATH.exe")))
            iniFile.Save(inipath)
            MsgBox("This kiosk has been locked down. Please restart kiosk to boot into the applicaiton")
            Me.Close()
        End If
    End Sub

    Private Sub btnSetZamok2toLoad_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSetZamok2toLoad.ItemClick
        Dim inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"
        Dim iniFile As New IniFile()
        Dim result As Integer = MessageBox.Show("This will lock your kiosk down to the Zamok 2. Do you want to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then

            File.Delete(inipath)
            iniFile.Sections.Add(
                        New IniSection(iniFile, "program_variables",
                            New IniKey(iniFile, "ini_assistantautostartpath", btnassistantautostartpathtarget),
                            New IniKey(iniFile, "ini_touchscreenconfig", btntouchscreentarget),
                            New IniKey(iniFile, "ini_internethelppath", btnInternettarget),
                            New IniKey(iniFile, "ini_confighelpath", btnconfigtarget),
                            New IniKey(iniFile, "ini_loginhelppath", btnloginhelptarget)))
            iniFile.Sections.Add(
                        New IniSection(iniFile, "watchdog_variables",
                            New IniKey(iniFile, "ini_z1path", zamok1pathttarget),
                            New IniKey(iniFile, "ini_z2path", zamok2pathttarget),
                            New IniKey(iniFile, "ini_lapath", LApathttarget),
                            New IniKey(iniFile, "ini_watchdogexe_path", zamok2pathttarget),
                            New IniKey(iniFile, "ini_processname", "zZAMOK@PATH.exe")))
            iniFile.Save(inipath)
            MsgBox("This kiosk has been locked down. Please restart kiosk to boot into the applicaiton")
            Me.Close()
        End If
    End Sub

    Private Sub btnSelectCustomPath_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnSelectCustomPath.ItemClick
        frmCustomPath.Show()
    End Sub

End Class