#persistent
;Uncrashable 2.0 designed for the SFO kiosk builds. Checks for and runs Zamok 2 every 5 seconds

;kills explorer.exe
run, taskkill /f /im explorer.exe

;invokes the menuFunction


; The Following process checks to see if Zamok is running every second. If it isn't, it opens Zamok 2.
Loop
	{
	f1::Gosub, menuFunction

;defines the menuFunction
menuFunction:
	{

	InputBox, user, Please Enter User Name
	InputBox,pass, Please Enter Password
	username=1
	password=1
	If (user!=%username%||pass!=%password%)
	
		MsgBox, 4, Shutdown Uncrashable, Press Yes to shutdown Uncrashable, 5
		IfMsgBox Yes
			run, %windir%\explorer.exe	
			Exit
		IfMsgBox No
			return

	Else

		MsgBox, 0, That is incorrect
	}	
return
	; Checks for Fadecandy server, assigns result to variable
	Process, Exist, fcserver.exe 

	try 
		{
		; If it is not running, it kills explorer.exe and then it opens Zamok
		If (ErrorLevel = 0) 
			{
			;runs Fcserver
			Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\fcserver.exe
			}
	
		; If Fcserver is running, the program does nothing.
		Else 
			{
			}
	
		}

	; if it can't find path, this will close script and throw error message
	catch
		{
		MsgBox, unable to start fadecandy server! Check to make sure it is installed in the default pathway.
		
		}

	; Checks for Zamok, assigns result to variable
	
	Process, Exist, zamok.exe 

	try 
		{
		; If it is not running it opens Zamok
		If (ErrorLevel = 0) 
			{
			;runs Zamok
			Run, C:\Program Files (x86)\Advanced Kiosks\Zamok\Zamok.exe
			}
	
		; If Zamok is running, the program does nothing.
		Else 
			{
			}
	
		}

	; if it can't find path, this will close script and throw error message
	catch
		{
		MsgBox, Unable to start Zamok 2.0! Check to make sure it is installed in the default pathway.
		
		}

		
	; pauses script for 1 second before checking again.
	Sleep 1000	
	}       

	