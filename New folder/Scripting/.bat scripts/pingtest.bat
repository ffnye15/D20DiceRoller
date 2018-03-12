::Pings every 30 minutes. Prints to log in working directory

@ECHO OFF
set IPADDRESS=8.8.8.8
set INTERVAL=1800
:PINGINTERVAL
ping %IPADDRESS% -n 1 >> pingtest.txt
timeout %INTERVAL%
GOTO PINGINTERVAL