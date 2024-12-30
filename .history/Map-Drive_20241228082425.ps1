param($DriveName = "H", $UserName = "homeassistant")
if (!(Get-PSDrive -Name "$DriveName" -ErrorAction SilentlyContinue)) {
    Write-Information "Mapping drive $DriveName to $Env:HaConfigPath"
    $cred = Get-SecretCredential -Name "\\$Env:HaServerName" -Username="$UserName"
    New-PSDrive -PSProvider FileSystem -Name "$DriveName" -Root "$Env:HaConfigPath" -Scope Global -Credential $cred
}
else {
    Write-Information "Drive $HaName already mapped"
}