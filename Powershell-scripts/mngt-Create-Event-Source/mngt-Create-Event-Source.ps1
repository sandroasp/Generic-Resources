########################################################################################################
#                                                                                                      #
# Author: Sandro Pereira                                                                               #
#                                                                                                      #
# Description: This script will allow you to create a new Log Source and Log Name on the Event Viewer. #
#                                                                                                      #
########################################################################################################

function Register-New-EventLog(
	[string]$logName,
	[string]$logSource,
    [string]$accessGrpOrUSers)
{
    $logFileExists = Get-EventLog -list | Where-Object {$_.logdisplayname -eq $logName} 
    if (! $logFileExists) {
        New-EventLog -LogName $logName -Source $logSource

	    # Compose Key:
	    $logPath = 'HKLM:\SYSTEM\CurrentControlSet\services\eventlog\'+$logName;
	    if(Test-Path $logPath)
	    {
	        $acl = Get-Acl $logPath
		    $accessGrpOrUSers | %{
		        $ace = New-Object System.Security.AccessControl.RegistryAccessRule $_,'WriteKey, ReadKey','allow'
		        $acl.AddAccessRule($ace)
		    }
	    }
        else
        {
            Write-Error "Cannot acesss log $logName"
        }
    }
    else 
    {
	    New-EventLog -LogName $logName -Source $logSource
    }
}

#############################################################
# Main script logic
#############################################################
Write-Host "Starting creating a new EventLog in Event Viewer ..." -Fore DarkGreen

# STEP 1 
# Ask for the LogName
[string]$ln = Read-Host -Prompt "Please enter Name of the Windows Custom Event Log (LogName) that you want to create (Application)" 

# STEP 2 
# Ask for the LogSource
[string]$ls = Read-Host -Prompt "Please enter Source Name that you want to create to be associated with the Custom Event Log you are creating or that already exists (MSSQLSERVER)"

# STEP 3
# Ask for the Group Or Users
[string]$ac = Read-Host -Prompt "List of users or groups that will have permissions to write in the Windows Custom Event Log ('Administrator')"

#STEP 4
# trigger function Register-New-EventLog
Register-New-EventLog $ln $ls $ac

# STEP 5
# Restarting Windows Event Log Service
$windowsShell = new-object -comobject wscript.shell
$questionResult = $windowsShell.popup("For these setting to take effect you need to restart Windows Event Log Service, however this will have impact on BizTalk Server services, all of them will also have to be restarted. 
Do you want to restart Windows Event Log Service?", 0,"Restart Windows Event Log Service",4)
If ($questionResult -eq 6) {
    Write-Host "Restarting services... please wait." -Fore DarkGreen
	restart-service 'EventLog' -Force
	Write-Host "Windows Event Log Service restarted successfully..." -Fore DarkGreen
}

# STEP 6
# Finish
Write-Host "Event Source successfully created" -Fore DarkGreen