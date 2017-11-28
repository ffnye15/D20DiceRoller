Imports System.IO, System.Net, MadMilkman.Ini
Public Class Form1
    'defines the path of the INI file. This should be made dynamic to the applicaiton directory
    Dim inipath As String = "C:\Users\Marshall PC\Desktop\settings.ini"
    'for purposes of testing, this is all set in the frm load window. Should be moved around for deployment
    'defines this process' variables
    Dim btn1target As String
    Dim btn2target As String
    Dim btn3target As String
    Dim btn4target As String
    Dim pathtarget As String

    Public Sub loadsettingsfromtheINIfile()

    End Sub

    Public Sub activator()
        'subroutine to run the set focus onto the applicaiton. pulls variability from system settings
        Dim processpathtorun As String
        processpathtorun = My.Settings.processnamesetting
        Try
            AppActivate(processpathtorun)
        Catch
            MsgBox("Failed to set focus onto applicaiton, please check the process name listed in the .ini file!")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the variables that the INI will load onto. Intermediary step until it can load onto system variables
        Dim INI As New IniFile
        Dim btn1fromINI As String
        Dim btn2fromINI As String
        Dim btn3fromINI As String
        Dim btn4fromINI As String
        Dim processpathfromINI As String
        'resets the system settings, just in case
        My.Settings.button1setting = ""
        My.Settings.button2setting = ""
        My.Settings.button3setting = ""
        My.Settings.button4setting = ""
        My.Settings.processnamesetting = ""

        Try
            'loads the variables from the INI
            INI.Load(inipath)
            btn1fromINI = INI.Sections("keyfunctionsettings").Keys("button1").Value.ToString
            btn2fromINI = INI.Sections("keyfunctionsettings").Keys("button2").Value.ToString
            btn3fromINI = INI.Sections("keyfunctionsettings").Keys("button3").Value.ToString
            btn4fromINI = INI.Sections("keyfunctionsettings").Keys("button4").Value.ToString
            processpathfromINI = INI.Sections("keyfunctionsettings").Keys("processpath").Value.ToString
            'Assigns the settings from the INI to the settings file
            My.Settings.button1setting = btn1fromINI
            My.Settings.button2setting = btn2fromINI
            My.Settings.button3setting = btn3fromINI
            My.Settings.button4setting = btn4fromINI
            My.Settings.processnamesetting = processpathfromINI
            My.Settings.Save()
        Catch ex As Exception

        End Try
        Try
            'assigns local variables from system settings
            btn1target = My.Settings.button1setting.ToString
            btn2target = My.Settings.button2setting.ToString
            btn3target = My.Settings.button3setting.ToString
            btn4target = My.Settings.button4setting.ToString
            pathtarget = My.Settings.processnamesetting.ToString
        Catch ex As Exception

        End Try


        MsgBox(btn1target)
        MsgBox(btn2target)
        MsgBox(btn3target)
        MsgBox(btn4target)
        MsgBox(pathtarget)
    End Sub

    Private Sub btnf9_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnf9.ItemClick
        activator()
        SendKeys.Send(btn1target)
    End Sub

    Private Sub btnf11_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnf11.ItemClick
        SendKeys.Send("{f10}")
        activator()
    End Sub

    Private Sub btnf10_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnf10.ItemClick
        SendKeys.Send("{f11}")
        activator()
    End Sub

    Private Sub btnf12_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnf12.ItemClick
        SendKeys.Send("{f12}")
        activator()
    End Sub

End Class