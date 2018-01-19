; Written by Marshall Nye 2017-6-8
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
;Automatic Driver Installation Toggle, Select "on" to turn automatic Driver isntallation on. Select "off" to turn automatic Driver installation off. 

Gui, Add, Button, x15 y50 w60 gOFF, OFF
Gui, Add, Button, x+20 w60 gON, ON
Gui, Add, Button, x+25 w60 gExit, EXIT
Gui, Font, s11 cBlack, Verdana
Gui, Add, Text, x25 y15, Automatic Driver Installation Toggle
Gui, Show, w300 h200, Test
Return

OFF:
;	RegWrite, REG_DWORD, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching, SearchOrderConfig, 00000003
	MsgBox, Automatic driver installation is now OFF
Return

ON:
;	RegWrite, REG_DWORD, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DriverSearching, SearchOrderConfig, 00000001
  	MsgBox, Automatic driver installation is now ON
Return

EXIT:
	ExitApp
return
	
GuiClose:
	ExitApp
Return