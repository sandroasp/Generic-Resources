# STEP 1 
# Defining the name of the project folder
[string]$projDrive = Read-Host -Prompt "Please enter the project location: " 

Get-ChildItem $projDrive -Recurse | %{ Unblock-File $_.FullName }