; The Following process checks to see if wamp is running every second. If it isn't, it opens wamp.
Loop
	{

	; Checks for Wamp, assigns result to variable
	Process, Exist, wampmanager.exe 

	try 
		{
		; If it is not running, it opens
		If (ErrorLevel = 0) 
			{
			Run, C:\wamp\wampmanager.exe
			}
	
		; If WAMP is running, the program does nothing.
		Else 
			{
			}
	
		}

	; if it can't find path, this will close script and throw error message
	catch
		{
		MsgBox, wampmanager.exe not found! Check to make sure it is installed in the default pathway.
		Exit
		}

	; pauses script for 1 second before checking again.
	Sleep 1000	

	}       