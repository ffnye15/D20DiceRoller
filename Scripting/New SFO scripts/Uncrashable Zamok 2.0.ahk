#persistent
;Uncrashable 2.0 designed for the SFO kiosk builds. Checks for and runs Zamok 2 every 5 seconds
;Run watchdog
Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\watchdog.exe
;kills explorer.exe
run, taskkill /f /im explorer.exe

f12::Gosub, menuFunction
Pause

menuFunction:
	{
	InputBox, inputtedpassword, Password Entry, Please enter your password to shut down Uncrashable, HIDE, , 150 
	password=advancedkiosks
	If inputtedpassword = advancedkiosks
		{
		MsgBox, 4, Uncrashable Control Panel, Press Yes to shutdown Uncrashable, 5
		IfMsgBox Yes
			run, taskkill /f /im watchdog.exe
			run, taskkill /f /im zamok.exe
			run, taskkill /f /im fcserver.exe
			run, %windir%\explorer.exe	
			Exit
			ExitApp
		IfMsgBox No
			return
		IfMsgBox TIMEOUT
			return
		}
	Else
		{
		MsgBox, 0, , That is an incorrect password
		}
	}	
return


	