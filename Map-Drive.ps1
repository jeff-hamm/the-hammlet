param($DriveName = "H", $UserName = "homeassistant",)
if (!(Get-PSDrive -Name "$DriveName" -ErrorAction SilentlyContinue)) {
    echo "Mapping drive $DriveName to $Env:HaConfigPath"
    New-PSDrive -PSProvider FileSystem -Name "$DriveName" -Root "$Env:HaConfigPath" -Scope Global -Credential $cred
}
else {
    echo "Drive $HaName already mapped"
}