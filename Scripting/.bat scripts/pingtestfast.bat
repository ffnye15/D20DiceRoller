:: Pings every 5 seconds, prints to log in working path


@ECHO OFF
set IPADDRESS=8.8.8.8
set INTERVAL=5
:PINGINTERVAL
ping %IPADDRESS% -n 1 >> pingtest.txt
timeout %INTERVAL% >null
GOTO PINGINTERVAL