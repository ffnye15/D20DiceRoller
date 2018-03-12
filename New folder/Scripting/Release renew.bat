@ECHO OFF
ipconfig /release
ipconfig /renew
ping 8.8.8.8 -n 4 >> pingresults.txt

