Imports System.IO, System.Net, MadMilkman.Ini
Module importermodule

    'defines variables needed to complete the INI pull operation
    Public watchdogtarget As String
    Public processname As String
    Public watchdogtarget_fromINI As String
    Public processname_fromINI As String
    Public INI As New IniFile

    'name of INI is hardcoded
    Public inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"

    Public Sub iniimporter()
        Try
            'resets system settings
            My.Settings.watchdogtargetsetting = ""
            My.Settings.processname_setting = ""

            'loads INI, and pulls the settings
            INI.Load(inipath)
            watchdogtarget_fromINI = INI.Sections("watchdog_variables").Keys("ini_watchdogexe_path").Value.ToString
            processname_fromINI = INI.Sections("watchdog_variables").Keys("ini_processname").Value.ToString

            'sets the system settings from the data that we pulled fromthe INI. IDK why I need the extra step, but the tutorial said I needed it. Don't judge me, I don't want to break it
            My.Settings.watchdogtargetsetting = watchdogtarget_fromINI
            My.Settings.processname_setting = processname_fromINI
        Catch
            MsgBox("Error importing data from the configuration INI. Please make sure INI file is present and named correctly.")
        End Try
    End Sub
End Module
