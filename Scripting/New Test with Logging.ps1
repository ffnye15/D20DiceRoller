#-------------------------------------<Global Variables>-------------------------------------------------#
    #Sets name of the error log. This always is created in the script's working directory
    $ErrorLog = "ConnectionErrorLog.txt"

    #Gets the computer's IPv4 and IPv6 addresses, and makes them individual strings
    $ComputerIPv4 = ((gwmi -query "Select IPAddress From Win32_NetworkAdapterConfiguration Where IPEnabled = True").IPAddress)[0]
    $ComputerIPv6 = ((gwmi -query "Select IPAddress From Win32_NetworkAdapterConfiguration Where IPEnabled = True").IPAddress)[1]
    
    #Gets the computer's IPv4 and IPv6 Default gateways, and makes them individual strings
    $DefaultGatewayIPv4 = ((Get-WmiObject Win32_NetworkAdapterConfiguration -Filter “DHCPEnabled = $true AND IPEnabled = $true”).DefaultIPGateway)[0]
    $DefaultGatewayIPv6 = ((Get-WmiObject Win32_NetworkAdapterConfiguration -Filter “DHCPEnabled = $true AND IPEnabled = $true”).DefaultIPGateway)[1]
    
    #Gets the Primary DNS and Secondary DNS
    $PrimaryDNS = ((Get-WmiObject Win32_NetworkAdapterConfiguration -Filter “DHCPEnabled = $true AND IPEnabled = $true”).DNSServerSearchOrder)[0] #Pulls first item in array
    $SecondaryDNS = ((Get-WmiObject Win32_NetworkAdapterConfiguration -Filter “DHCPEnabled = $true AND IPEnabled = $true”).DNSServerSearchOrder)[1] #Pulls second item in array

    #builds array for basic stack test
    $PingArray =
        (
        "127.0.0.1",
        $ComputerIPv4,
        $ComputerIPv6,
        $DefaultGatewayIPv4,
        $DefaultGatewayIPv6,
        $PrimaryDNS,
        $SecondaryDNS,
        #Added Google DNS here, in case the network's DNS is down
        "8.8.8.8",
        "8.8.4.4"
        )  

    #builds array for Zamok Resource Test
    $ResourceArray =
        (
        "zamok2.com",
        "googleapis.com",
        "fonts.gstatic.com", 
        "firebase.google.com", 
        "ifconfig.co",
        "zamok.advancedkiosks.com"
        )

#</Global Variables>


#-------------------------------------<Functions>-------------------------------------------------#

    #Creates new log file if one does not exist
    Function New-txt
        {
        if (!(Test-Path $ErrorLog)) 
            {
            New-Item -Path . -Name "ConnectionErrorLog.txt" -ItemType "file"
            }
        Else
            {
            #Does Nothing
            }
        }

    #Generates Timestamp variable from system time
    function Get-TimeStamp
        {   
        return "[{0:yy/MM/dd} {0:HH:mm:ss}]" -f (Get-Date)
        }
    
    #Creates a line in between test blocks
    function add-line
        {
        "-------Next Section-----" | Add-Content $ErrorLog
        }

#</Functions>

#-------------------------------------<Script Body>-------------------------------------------------#
$multiplelines = @"
           _______      __     _   _  _____ ______ _____    
     /\   |  __ \ \    / /\   | \ | |/ ____|  ____|  __ \   
    /  \  | |  | \ \  / /  \  |  \| | |    | |__  | |  | |  
   / /\ \ | |  | |\ \/ / /\ \ | .  ` | |    |  __| | |  | |  
  / ____ \| |__| | \  / ____ \| |\  | |____| |____| |__| |  
 /_/ ___\_\_____/   \/_/_ _ \_\_|_\_|\_____|______|_____/   
 | |/ /_   _/ __ \ / ____| |/ // ____|                      
 | ' /  | || |  | | (___ | ' /| (___                        
 |  <   | || |  | |\___ \|  <  \___ \                       
 | . \ _| || |__| |____) | . \ ____) |                      
 |_|\_\_____\____/|_____/|_|\_\_____/                                                                                                                                                                                                 
"@

Write-Host $multiplelines
Write-host "NETWORK DIAGNOSTIC UTILITY" -ForegroundColor white -BackgroundColor darkred
Write-host "Written by Marshall Nye, 2018"

New-Txt

"-------NEW TEST-----" | Add-Content $ErrorLog

#Runs a simple IP Check, NO PORTS. Pulls the IP it is testing from $PingArray
ForEach($TargetIP in $PingArray)
    {
    If(Test-Connection $TargetIP -Count 2 -Quiet)   
        {
        "$(Get-TimeStamp) $TargetIP Connection Successful" | Add-Content $ErrorLog 
        }
    else
        {
        "$(Get-TimeStamp) $TargetIP Connection Failed" | Add-Content $ErrorLog 
        }
    }

add-line

# Tests port 80 connection for each domain in $ResourceArray
ForEach($TargetDomain in $ResourceArray)
    {
    If(Test-NetConnection -ComputerName $TargetDomain -Port 80)   
        {
        "$(Get-TimeStamp) Connection to $TargetDomain on port 80 successful" | Add-Content $ErrorLog 
        }
    else
        {
        "$(Get-TimeStamp) Connection to $TargetDomain on port 80 failed" | Add-Content $ErrorLog 
        }
    }

add-line

# Tests port 443 connection for each domain in $ResourceArray
ForEach($TargetDomain in $ResourceArray)
    {
    If(Test-NetConnection $TargetDomain -Port 443)   
        {
        "$(Get-TimeStamp) Connection to $TargetDomain on port 443 Successful" | Add-Content $ErrorLog 
        }
    else
        {
        "$(Get-TimeStamp) Connection to $TargetDomain on port 443 Failed" | Add-Content $ErrorLog 
        }
    }

add-line
$a=Get-Date; Invoke-WebRequest https://download.zamok2.com/10mb|Out-Null; "Download speed from Zamok 2 server is $((10/((Get-Date)-$a).TotalSeconds)*8) Mbps" | Add-Content $ErrorLog 
$a=Get-Date; Invoke-WebRequest https://apps.advancedkiosks.com/10mb|Out-Null; "Download speed Zamok 1 server is $((10/((Get-Date)-$a).TotalSeconds)*8) Mbps" | Add-Content $ErrorLog 
"-------END TEST-----" | Add-Content $ErrorLog

#</Script Body>