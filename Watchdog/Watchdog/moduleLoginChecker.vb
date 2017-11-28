Module moduleLoginChecker
    Public kioskassistantpath As String = My.Application.Info.DirectoryPath + "\autostarter.lnk"

    Public Sub killwatchdog()
        Try
            Process.Start("explorer.exe")
        Catch
        End Try
        Try
            Process.Start(kioskassistantpath)
        Catch
            'MsgBox("Kiosk assistant not in uncrashable path")


        End Try
        frmPasswordEntry.Close()
        Form1.Close()
        End
    End Sub

    Public Sub passfailed()
        frmPasswordEntry.Close()
        Form1.Show()
        Form1.Timer2.Start()

    End Sub
End Module
