;Alert window to tell you Uncrashable is going to run.
SplashImage, uncrashablesplash.jpg,,Copyright Advanced Kiosks 2017
Sleep 5000
SplashImage, Off


; The Following process checks to see if Zamok is running every second. If it isn't, it opens wamp.
Loop
	{

	; Checks for Wamp, assigns result to variable
	Process, Exist, zamok.browser.exe 

	try 
		{
		; If it is not running, it kills explorer.exe and then it opens Zamok
		If (ErrorLevel = 0) 
			{
			;kills explorer.exe
			Process, Close, explorer.exe
			;runs Zamok
			Run, C:\Advanced Kiosks\Program Files\Zamok\Zamok.Browser.exe
			}
	
		; If Zamok is running, the program does nothing.
		Else 
			{
			}
	
		}

	; if it can't find path, this will close script and throw error message
	catch
		{
		MsgBox, zamok.browser.exe not found! Check to make sure it is installed in the default pathway.
		Exit
		}

	; pauses script for 1 second before checking again.
	Sleep 1000	

	}       