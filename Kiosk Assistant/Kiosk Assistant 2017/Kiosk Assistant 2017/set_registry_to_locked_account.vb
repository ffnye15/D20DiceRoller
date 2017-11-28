Module set_registry_to_locked_account
    Sub subregistrychange()
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\system", "Shell", Nothing) Is Nothing Then
            MsgBox("This would normally check for a key, does nothing currently",)
            ' My.Computer.Registry.LocalMachine.CreateSubKey("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\system\shell")
        End If

        ''resets registry to locked kiosk account, pulls value of the admin account name from the INI file
        MsgBox("This would normally set the change the registry, does nothing currently")
        MsgBox(lockedaccounttarget)
        MsgBox(watchdogexepathtarget)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultUserName", lockedaccounttarget)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Windows NT\CurrentVersion\Winlogon", "AutoAdminLogon", "1")
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\system", "Shell", watchdogexepathtarget)

        'REGISTRY SETTING TO DECLARE CUSTOM SHELL PATH
    End Sub
End Module
