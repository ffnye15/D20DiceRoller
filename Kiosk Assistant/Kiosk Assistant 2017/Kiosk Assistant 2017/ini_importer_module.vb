Imports System.IO, System.Net, MadMilkman.Ini
Module ini_importer_module
    ''' <summary>
    'This module will pull variables from the ini file, and then map them as variables that can be called from outside of the module. It's kind of confusing
    'ini_VARIABLE is the setting line in the ini that the application will look for
    'VARIABLE_fromINI is a temporary variable that is defined based on the ini string's value
    'VARIABLE_setting is the system variable that gets defined by this process. can get invoked elsewhere via My.Settings.VARIABLE_setting.ToString
    'btnVARIABLE defines the actions that the buttons will run. this does not have to stay in this module, they could be run in any subroutine so long as they define their funtion via the above My.Settings.VARIABLE_setting.ToString
    ''' </summary>


    'defines button action target variables
    Public btnassistantautostartpathtarget As String
    Public btnInternettarget As String
    Public btntouchscreentarget As String
    Public btnconfigtarget As String
    Public btnloginhelptarget As String
    ' account action variables, will depreciate with new watchdog system
    'Public adminaccounttarget As String
    'Public lockedaccounttarget As String
    'Public adminpasswordtarget As String

    'watchdog variables
    Public zamok1pathttarget As String
    Public zamok2pathttarget As String
    Public LApathttarget As String
    Public watchdogexepathtarget As String

    Public processnametarget As String
    'defines the path of the INI as the same folder that the executable sits in
    Public inipath As String = My.Application.Info.DirectoryPath + "\kiosk_assistant_settings.ini"
    '-------------------------------------------------------------------------------------------------------------------------------
    'sets the variables that the INI will load onto. Intermediary step. These offload onto onto system settings
    Public INI As New IniFile
    Public assistantautostartpath_fromINI As String
    Public touchscreenconfig_fromINI As String
    Public internethelppath_fromINI As String
    Public confighelpath_fromINI As String
    Public loginhelppath_fromINI As String


    'names for the locked accounts
    'Public lockedaccountname_fromINI As String
    'Public adminaccountname_fromINI As String
    'Public adminpassword_fromINI As String

    'watchdog stuff
    Public watchdogexepath_fromINI As String
    Public zamok1path_fromINI As String
    Public zamok2path_fromINI As String
    Public LApath_fromINI As String
    Public processname_fromINI As String

    '-------------------------------------------------------------------------------------------------------------------------------

    Public Sub iniimporter()
        Try
            'resets the system settings, just in case
            My.Settings.assistantautostartpath_setting = ""
            My.Settings.touchscreenconfig_setting = ""
            My.Settings.internethelppath_setting = ""
            My.Settings.confighelpath_setting = ""
            My.Settings.loginhelppath_setting = ""

            'My.Settings.lockedaccountname_setting = ""
            'My.Settings.adminaccountname_setting = ""
            'My.Settings.adminpassword_setting = ""

            My.Settings.zamok1path_setting = ""
            My.Settings.zamok2path_setting = ""
            My.Settings.lapath_setting = ""
            My.Settings.watchdogexepath_setting = ""
            My.Settings.processname_setting = ""
        Catch
            MsgBox("setting system variables to null failed")
        End Try
        Try
            'loads the form target variables from the INI. Groups broken up for debugging.

            INI.Load(inipath)
            assistantautostartpath_fromINI = INI.Sections("program_variables").Keys("ini_assistantautostartpath").Value.ToString
            touchscreenconfig_fromINI = INI.Sections("program_variables").Keys("ini_touchscreenconfig").Value.ToString
            internethelppath_fromINI = INI.Sections("program_variables").Keys("ini_internethelppath").Value.ToString
            confighelpath_fromINI = INI.Sections("program_variables").Keys("ini_confighelpath").Value.ToString
            loginhelppath_fromINI = INI.Sections("program_variables").Keys("ini_loginhelppath").Value.ToString
            'lockedaccountname_fromINI = INI.Sections("program_variables").Keys("ini_lockedaccountname").Value.ToString
            'adminaccountname_fromINI = INI.Sections("program_variables").Keys("ini_adminaccountname").Value.ToString
            'adminpassword_fromINI = INI.Sections("program_variables").Keys("ini_adminpassword").Value.ToString
        Catch
            MsgBox("defining form targets failed")
        End Try

        Try
            'loads watchdog variables from the INI. Groups broken up for debugging.
            watchdogexepath_fromINI = INI.Sections("watchdog_variables").Keys("ini_watchdogexe_path").Value.ToString
            zamok1path_fromINI = INI.Sections("watchdog_variables").Keys("ini_z1path").Value.ToString
            zamok2path_fromINI = INI.Sections("watchdog_variables").Keys("ini_z2path").Value.ToString
            LApath_fromINI = INI.Sections("watchdog_variables").Keys("ini_lapath").Value.ToString
            processname_fromINI = INI.Sections("watchdog_variables").Keys("ini_processname").Value.ToString
        Catch
            MsgBox("defining watchdog variables failed")
        End Try

        Try
            'Assigns the settings from the INI to the settings file. Groups broken up for debugging.
            My.Settings.assistantautostartpath_setting = assistantautostartpath_fromINI
            My.Settings.touchscreenconfig_setting = touchscreenconfig_fromINI
            My.Settings.internethelppath_setting = internethelppath_fromINI
            My.Settings.confighelpath_setting = confighelpath_fromINI
            My.Settings.loginhelppath_setting = loginhelppath_fromINI
            'My.Settings.lockedaccountname_setting = lockedaccountname_fromINI
            'My.Settings.adminaccountname_setting = adminaccountname_fromINI
            'My.Settings.adminpassword_setting = adminpassword_fromINI
            'watchdog variables
            My.Settings.watchdogexepath_setting = watchdogexepath_fromINI
            My.Settings.zamok1path_setting = zamok1path_fromINI
            My.Settings.zamok2path_setting = zamok2path_fromINI
            My.Settings.LApath_setting = LApath_fromINI
            My.Settings.processname_setting = processname_fromINI
            My.Settings.Save()


        Catch ex As Exception
            MsgBox("setting global settings from new INI files failed")
        End Try
        Try
            'assigns local variables from system settings
            'the below lines can exist anywhere in the application, so long as the module has been run before at some point in execution
            btnassistantautostartpathtarget = My.Settings.assistantautostartpath_setting.ToString
            btntouchscreentarget = My.Settings.touchscreenconfig_setting.ToString
            btnInternettarget = My.Settings.internethelppath_setting.ToString
            btnconfigtarget = My.Settings.confighelpath_setting.ToString
            btnloginhelptarget = My.Settings.loginhelppath_setting.ToString
            'lockedaccounttarget = My.Settings.lockedaccountname_setting.ToString
            'adminaccounttarget = My.Settings.adminaccountname_setting.ToString
            'adminpasswordtarget = My.Settings.adminpassword_setting.ToString

            'watchdog variables
            zamok1pathttarget = My.Settings.zamok1path_setting.ToString
            zamok2pathttarget = My.Settings.zamok2path_setting.ToString
            LApathttarget = My.Settings.LApath_setting.ToString
            watchdogexepathtarget = My.Settings.watchdogexepath_setting.ToString
            processnametarget = My.Settings.processname_setting.ToString
        Catch ex As Exception

        End Try
    End Sub
End Module
