@ECHO OFF
:LOOPSTART
time /T >> pingresults.txt
ping 8.8.8.8 -n 4 >> pingresults.txt
PING localhost -n 1200 >NUL
GOTO LOOPSTART