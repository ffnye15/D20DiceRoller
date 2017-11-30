@ echo off
echo TURNING OFF SECURE KIOSK MODE
ping 1.1.1.1 -n 1 -w 2000>nul
echo .
ping 1.1.1.1 -n 1 -w 2000>nul
echo .
ping 1.1.1.1 -n 1 -w 2000>nul
echo .
reg add "HKLM\Software\Microsoft\Windows NT\CurrentVersion\Winlogon" /v AutoAdminLogon /t REG_SZ /d 1
reg add "HKLM\Software\Microsoft\Windows NT\CurrentVersion\Winlogon" /v DefaultUserName /t REG_SZ /d AKAdmin
reg add "HKLM\Software\Microsoft\Windows NT\CurrentVersion\Winlogon" /v DefaultPassword /t REG_SZ /d advancedkiosks
reg add "HKLM\Software\Microsoft\Windows NT\CurrentVersion\Winlogon" /v AutoLogonCount /t REG_DWORD /d 0
echo SECURE KIOSK MODE IS OFF. PRESS ANY KEY TO EXIT
pause>nul