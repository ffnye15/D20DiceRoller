::Disables and re enables NICs. Add as needed

@echo off
netsh interface set interface "Local Area Connection" DISABLED>nul
netsh interface set interface "Wireless Network Connection" DISABLED>nul
netsh interface set interface "Ethernet" DISABLED>nul
netsh interface set interface "Ethernet 2" DISABLED>nul

netsh interface set interface "Local Area Connection" ENABLED>nul
netsh interface set interface "Wireless Network Connection" ENABLED>nul
netsh interface set interface "Ethernet" ENABLED>nul
netsh interface set interface "Ethernet 2" ENABLED>nul