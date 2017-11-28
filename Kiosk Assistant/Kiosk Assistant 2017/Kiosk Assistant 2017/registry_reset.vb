Module registry_reset

    Sub subregistryreset()
        'checks to see if there is a registry key for autologin and creates it if it does not exist
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultPassword", Nothing) Is Nothing Then
            MsgBox("This would normally check for a key, does nothing currently",)
            ' My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\DefaultPassword")
        End If
        'resets registry to normal, pulls value of the admin account name and password from the INI file
        MsgBox("This would normally set the reset the registry, does nothing currently")
        MsgBox(adminaccounttarget)
        MsgBox(adminpasswordtarget)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultUserName", adminaccounttarget)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "AutoAdminLogon", "1")
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultPassword", adminpasswordtarget)
    End Sub
End Module
