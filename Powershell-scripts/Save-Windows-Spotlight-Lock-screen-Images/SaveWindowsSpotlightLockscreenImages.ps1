$pathImageDestination = "$env:USERPROFILE\Pictures\Spotlight\";

Copy-Item $env:USERPROFILE\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets\* $pathImageDestination

cd $pathImageDestination

Get-ChildItem -exclude "*.jpg" | WHere-Object{!$_.PsIsContainer} | Rename-Item -newname {$_.name + ".jpg"}