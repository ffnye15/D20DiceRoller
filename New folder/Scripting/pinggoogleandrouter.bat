::Pings every 30 minutes. Prints to log in working directory

@ECHO OFF
set IPADDRESS1=8.8.8.8
set IPADDRESS2=192.168.3.0
:PINGINTERVAL
ping %IPADDRESS1% -n 500 >> pingtest.txt
ping %IPADDRESS2% -n 500 >> pingtest.txt
GOTO PINGINTERVAL