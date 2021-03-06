:: Connection to our servers test. For customer use

@echo off
Echo ADVANCED KIOSKS CONNECTION DIAGNOSTIC TOOL
pause
ECHO.
echo ATTEMPTING TO CONTACT ZAMOK2 SERVERS
echo.
ping 1.1.1.1 -n 1 -w 2000>nul
ping zamok2.com -n 1 -w 1000>nul || ECHO CONNECTION ERROR zamok2.com
ping googleapis.com -n 1 -w 1000>nul || ECHO CONNECTION ERROR googleapis.com
ping fonts.gstatic.com -n 1 -w 1000>nul || ECHO CONNECTION ERROR fonts.gstatic.com
ping firebase.google.com -n 1 -w 1000>nul || ECHO CONNECTION ERROR firebaseio.google.com
ping ifconfig.co -n 1 -w 1000>nul || ECHO CONNECTION ERROR ifconfig.co
IF %ERRORLEVEL% EQU 0 echo CONNECTION ESTABLISHED
ping localhost -n 1 >null
ECHO.
pause
echo.
echo ATTEMPTING TO CONTACT GOOGLE DNS SERVER
echo.
ping 1.1.1.1 -n 1 -w 2000>nul
ping 8.8.8.8 -n 1 -w 1000>nul
IF %ERRORLEVEL% NEQ 0 echo CONNECTION ERROR
IF %ERRORLEVEL% EQU 0 echo CONNECTION ESTABLISHED
ECHO.
PAUSE
echo.
echo ATTEMPTING TO CONTACT ZAMOK AND LOBBY ATTENDANT SERVERS.
echo.
ping zamok.advancedkiosks.com -n 4 -w 2000>nul
IF %ERRORLEVEL% NEQ 0 echo CONNECTION ERROR
IF %ERRORLEVEL% EQU 0 echo CONNECTION ESTABLISHED
ECHO.
echo.
echo.
echo.
echo.
echo PRESS ANY KEY TO EXIT
pause>nul
