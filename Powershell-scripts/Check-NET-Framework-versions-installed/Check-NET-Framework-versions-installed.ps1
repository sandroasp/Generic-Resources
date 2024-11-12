######################################################################
#                                                                    #
# How to check which .NET Framework versions are installed           #
# Author: Sandro Pereira                                             #
#                                                                    #
######################################################################

Get-ChildItem 'HKLM:\SOFTWARE\Microsoft\NET Framework Setup\NDP' -Recurse | Get-ItemProperty -Name version -EA 0 | Where { $_.PSChildName -Match '^(?!S)\p{L}'} | Select PSChildName, version