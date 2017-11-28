Imports System.IO, System.Net, MadMilkman.Ini
Public Class frmCustomPath

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myfiledlog As New OpenFileDialog()
        myfiledlog.InitialDirectory = "c:\"
        myfiledlog.ShowDialog()
        txtPasswordEntry.Text = myfiledlog.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'pulls data in from the browse window
        Dim custompath As String
        Dim customprocessname As String
        custompath = txtPasswordEntry.Text
        customprocessname = Path.GetFileNameWithoutExtension(txtPasswordEntry.Text)

        If custompath = "" Then
            'do nuffin. gotsa have dat path son.
            MsgBox("Please select your application path!", MessageBoxIcon.Asterisk)
        Else
            Dim iniFile As New IniFile()
            Dim result As Integer = MessageBox.Show("This will lock your kiosk down to " + customprocessname + ". Do you want to continue?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                'deletes INI so it can replace it with new content
                File.Delete(inipath)
                iniFile.Sections.Add(
                            New IniSection(iniFile, "program_variables",
                                New IniKey(iniFile, "ini_touchscreenconfig", btntouchscreentarget),
                                New IniKey(iniFile, "ini_internethelppath", btnInternettarget),
                                New IniKey(iniFile, "ini_confighelpath", btnconfigtarget),
                                New IniKey(iniFile, "ini_loginhelppath", btnloginhelptarget)))
                iniFile.Sections.Add(
                            New IniSection(iniFile, "watchdog_variables",
                                New IniKey(iniFile, "ini_z1path", zamok1pathttarget),
                                New IniKey(iniFile, "ini_z2path", zamok2pathttarget),
                                New IniKey(iniFile, "ini_lapath", LApathttarget),
                                New IniKey(iniFile, "ini_watchdogexe_path", custompath),
                                New IniKey(iniFile, "ini_processname", customprocessname)))
                iniFile.Save(inipath)
                MsgBox("This kiosk has been locked down to " + customprocessname + ". Please restart kiosk to boot into the application")
                Me.Close()
            End If
        End If
    End Sub

End Class