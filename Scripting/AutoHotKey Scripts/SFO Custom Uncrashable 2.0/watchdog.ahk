﻿;Uncrashable 2.0 designed for the SFO kiosk builds. Checks for and runs Zamok 2 every 5 seconds

; The Following process checks to see if Zamok is running every second. If it isn't, it opens Zamok 2.
Loop
	{
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
