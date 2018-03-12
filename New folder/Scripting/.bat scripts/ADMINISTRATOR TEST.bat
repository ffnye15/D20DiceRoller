:: runs a test ping to all of our servers. Does everything automatically

@echo off
Echo Advanced Kiosks connection test tool

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

echo.
echo ATTEMPTING TO CONTACT GOOGLE DNS SERVER
echo.

ping 8.8.8.8 -n 1 -w 1000>nul
IF %ERRORLEVEL% NEQ 0 echo CONNECTION ERROR
IF %ERRORLEVEL% EQU 0 echo CONNECTION ESTABLISHED
ECHO.

echo.
echo ATTEMPTING TO CONTACT ZAMOK VOIP SIP SERVER
echo.

ping 97.107.141.97 -n 1 -w 1000>nul
IF %ERRORLEVEL% NEQ 0 echo CONNECTION ERROR
IF %ERRORLEVEL% EQU 0 echo CONNECTION ESTABLISHED
ECHO.

echo.
echo ATTEMPTING TO CONTACT ZAMOK VOIP RTP SERVERS
echo.
ping 66.228.45.12 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 66.228.45.12
ping 50.116.53.144  -n 1 -w 1000>nul || ECHO CONNECTION ERROR 50.116.53.144
ping 66.228.44.117 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 66.228.44.117
ping 23.92.17.107 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 23.92.17.107
ping 45.56.98.182 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 45.56.98.182
ping 45.79.133.98 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 45.79.133.98
ping 69.164.214.111 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 69.164.214.111
ping 104.200.29.114 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 104.200.29.114
ping 104.237.151.131 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 104.237.151.131
ping 45.56.102.133 -n 1 -w 1000>nul || ECHO CONNECTION ERROR 45.56.102.133

ECHO.

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
