#persistent
;Uncrashable 2.0 designed for the SFO kiosk builds. Checks for and runs Zamok 2 every 5 seconds
;kills explorer.exe
run, taskkill /f /im explorer.exe

;run fadecandy
Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\fcserver.exe

;Wait 5 seconds, allows zamok to load over fadecandy
sleep, 5000

;Run Zamok
Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\Zamok.exe

sleep, 10000

;Run watchdog
Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\watchdog.exe
f1::Gosub, menuFunction
Pause

menuFunction:
	{

	InputBox, user, Please Enter User Name
	InputBox,pass, Please Enter Password
	username=1
	password=1	
	If (user!=%username%||pass!=%password%)
	
		MsgBox, 4, Shutdown Uncrashable, Press Yes to shutdown Uncrashable, 5
		IfMsgBox Yes
			run, taskkill /f /im watchdog.exe
			run, taskkill /f /im zamok.exe
			run, taskkill /f /im fcserver.exe
			run, %windir%\explorer.exe	
			Exit
		IfMsgBox No
			return

	Else

		MsgBox, 0, That is incorrect
	}	
return


	