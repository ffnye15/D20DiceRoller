Imports System.IO, System.Net, MadMilkman.Ini

''' <summary>
''' This is an assistive program for our kiosks, so customers have an easier time getting set up. It pulls data in from an INI file that sits in its directory.
''' The INI name is harcoded, so that can't ever change.
''' </summary>

Public Class frmMain

    ''' <summary>
    ''' subroutines for the main form 
    ''' </summary>
    ''' 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'this controls the close time of the "Please wait..." dialog box that shows.
        frmWait.Close()
        Timer1.Stop()
    End Sub
    Private Sub Close_windows()
        'closes windows, so we don't somehow get a shit ton of windows
        frmConnectionHelp.Close()
        frmLoginHelp.Close()
        browserZamokConfig.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'main form load event. runs initial ini importer
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow
        ini_importer_module.iniimporter()

    End Sub

    ''' <summary>
    ''' Button press events
    ''' </summary>

    Private Sub closebutton(sender As Object, e As EventArgs) Handles btnClose.Click
        'I messed up the naming, this loads a form, and it is the "are you sure you want to exit" along with an option to remove this application from startup, reboot or cancel
        do_not_run_on_boot.Show()
    End Sub


    Private Sub btnCalibrate_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnCalibrate.ItemClick
        'opens up the touchscreen configuration application

        'starts the timer, and shows the waiting window
        Timer1.Start()
        frmWait.Show()
        'dims a var and pulls touchscreen target from the INI
        Dim touchscreenconfigtarget As String
        touchscreenconfigtarget = My.Settings.touchscreenconfig_setting.ToString
        Try
            Process.Start(touchscreenconfigtarget)
        Catch ex As Exception
            'close wait box and show error
            frmWait.Close()
            MsgBox("Could not load the on screen calibration tool! Please check the application path in the settings file.")
        End Try
    End Sub

    Private Sub btnInternet_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnInternet.ItemClick
        'opens up a window with instructions on how to connect to a network
        Close_windows()
        frmConnectionHelp.Show()
    End Sub

    Private Sub btnCredentials_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnCredentials.ItemClick
        'shows where the credntials are located on the quickstart quide
        Close_windows()
        frmLoginHelp.Show()
    End Sub

    Private Sub btnConfiguration_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnConfiguration.ItemClick
        'shows instructions on how to configure Zamok
        Close_windows()
        browserZamokConfig.Show()
    End Sub

    Private Sub btnONSecure_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnONSecure.ItemClick
        'shows the application selection form, which will write to the INI file
        Close_windows()
        frmLockDownSelect.Show()
    End Sub

    Private Sub btnOFFSecure_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnOFFSecure.ItemClick
        'sets the watchdog path to run explorer, essentially turning it off

        Close_windows()
        'please change this message for production. Consider adding a subroutine with prettier buttons
        Dim result As Integer = MessageBox.Show("This will unlock your kiosk. On the next reboot, you will be presented with this application.", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If result = DialogResult.No Then
            'don't do anything
            MsgBox("Secure account editing cancelled")

        ElseIf result = DialogResult.Yes Then
            Try
                Dim inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"
                Dim iniFile As New IniFile()

                'deletes the INI, as we will rebuild it again in a second
                File.Delete(inipath)

                'resets the watchdog path and target as explorer. There is logic in watchdog, where if it detects the path to be explorer, it kills it self and starts explorer and the kiosk assistant.
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
                                New IniKey(iniFile, "ini_watchdogexe_path", "explorer.exe"),
                                New IniKey(iniFile, "ini_processname", "explorer.exe")))
                iniFile.Save(inipath)
                MsgBox("This kiosk has now been unlocked.")
            Catch
            End Try
        End If
    End Sub

End Class
